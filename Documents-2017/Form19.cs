using ControlsLbr;
using Documents.DataSets;
using Documents.Properties;
using FormLbr;
using FormLbr.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;

internal class Form19 : FormBase
{
    private bool bool_0;
    private bool bool_1;
    private Button button_0;
    private Button button_1;
    private Button button_2;
    private Button button_3;
    private Button button_4;
    private ComboBox comboBox_0;
    private ComboBox comboBox_1;
    private ComboBox comboBox_2;
    private ComboBox comboBox_3;
    private ComboBox comboBox_4;
    private ComboBox comboBox_5;
    private ComboBox comboBox_6;
    private ComboBox comboBox_7;
    private ComboBoxReadOnly comboBoxReadOnly_0;
    private DataGridView dataGridView_0;
    private DataGridView dataGridView_1;
    private DataGridView dataGridView_2;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;
    private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_0;
    private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_1;
    private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_2;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;
    private DataSetOrder dataSetOrder_0;
    private DateTime dateTime_0;
    private DateTime dateTime_1;
    private Dictionary<int, string> dictionary_0;
    private IContainer icontainer_0;
    private int int_0;
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
    private Label label_2;
    private Label label_3;
    private Label label_4;
    private Label label_5;
    private Label label_6;
    private Label label_7;
    private Label label_8;
    private Label label_9;
    private ListBox listBox_0;
    private MultiColumnComboBox multiColumnComboBox_0;
    [CompilerGenerated]
    private int? nullable_0;
    private NullableDateTimePicker nullableDateTimePicker_0;
    private NullableDateTimePicker nullableDateTimePicker_1;
    private NullableDateTimePicker nullableDateTimePicker_2;
    private NullableDateTimePicker nullableDateTimePicker_3;
    private NullableDateTimePicker nullableDateTimePicker_4;
    private NullableDateTimePicker nullableDateTimePicker_5;
    private Panel panel_0;
    private RichTextBox richTextBox_0;
    private RichTextBox richTextBox_1;
    private SplitContainer splitContainer_0;
    private TextBox textBox_0;
    private TextBox textBox_1;
    private TextBox textBox_2;
    private TextBox textBox_3;
    private TextBox textBox_4;
    private TextBox textBox_5;
    private ToolStrip toolStrip_0;
    private ToolStrip toolStrip_1;
    private ToolStripButton toolStripButton_0;
    private ToolStripButton toolStripButton_1;
    private ToolStripButton toolStripButton_2;
    private ToolStripButton toolStripButton_3;
    private ToolStripButton toolStripButton_4;

    internal Form19()
    {
        this.int_0 = -1;
        this.dateTime_0 = new DateTime(0x76c, 1, 1);
        this.dateTime_1 = new DateTime(0x2328, 1, 1);
        this.bool_1 = true;
        this.dictionary_0 = new Dictionary<int, string>();
        this.method_21();
    }

    internal Form19(int int_1, bool bool_2)
    {
        this.int_0 = -1;
        this.dateTime_0 = new DateTime(0x76c, 1, 1);
        this.dateTime_1 = new DateTime(0x2328, 1, 1);
        this.bool_1 = true;
        this.dictionary_0 = new Dictionary<int, string>();
        this.method_21();
        this.int_0 = int_1;
        this.bool_0 = bool_2;
        this.dataGridViewComboBoxColumn_1.AutoComplete = true;
    }

    protected override void ApplyConfig(XmlDocument xmlDocument_0)
    {
        XmlNode node = xmlDocument_0.SelectSingleNode(base.Name);
        if (node != null)
        {
            XmlAttribute attribute = node.Attributes["X"];
            int? nullable = null;
            int? nullable2 = null;
            if (attribute != null)
            {
                nullable = new int?(Convert.ToInt32(attribute.Value));
            }
            attribute = node.Attributes["Y"];
            if (attribute != null)
            {
                nullable2 = new int?(Convert.ToInt32(attribute.Value));
            }
            if (nullable.HasValue && nullable2.HasValue)
            {
                base.Location = new Point(nullable.Value, nullable2.Value);
            }
            attribute = node.Attributes["Width"];
            if (attribute != null)
            {
                base.Width = Convert.ToInt32(attribute.Value);
            }
            attribute = node.Attributes["Height"];
            if (attribute != null)
            {
                base.Height = Convert.ToInt32(attribute.Value);
            }
            attribute = node.Attributes["SplitterDistance"];
            if (attribute != null)
            {
                this.splitContainer_0.SplitterDistance = Convert.ToInt32(attribute.Value);
            }
        }
    }

    private void button_0_Click(object sender, EventArgs e)
    {
        if (this.method_12())
        {
            this.method_10();
        }
    }

    private void button_1_Click(object sender, EventArgs e)
    {
        if ((this.dataSetOrder_0.tJ_Order.Rows.Count > 0) && this.method_13())
        {
            if (this.method_10())
            {
                this.dataSetOrder_0.tJ_Order.Rows[0]["Registered"] = true;
                this.dataSetOrder_0.tJ_Order.Rows[0].EndEdit();
                if (base.UpdateSqlData(this.dataSetOrder_0, this.dataSetOrder_0.tJ_Order))
                {
                    this.method_9();
                    this.method_8();
                }
                else
                {
                    this.dataSetOrder_0.tJ_Order.Rows[0]["Registered"] = false;
                }
            }
            else
            {
                this.dataSetOrder_0.tJ_Order.Rows[0]["Registered"] = false;
            }
        }
    }

    private void button_2_Click(object sender, EventArgs e)
    {
        if (this.bool_1)
        {
            if (this.int_0 > 0)
            {
                if (this.nullableDateTimePicker_3.get_Value() == null)
                {
                    MessageBox.Show("Не введена дата выдачи разрешения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                if (this.comboBox_6.SelectedValue == null)
                {
                    MessageBox.Show("Не выбран диспетчер, выдающий разрешение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                if ((DateTime.Now < Convert.ToDateTime(this.nullableDateTimePicker_0.get_Value())) && (MessageBox.Show("Текущее время, меньше чем дата начала работ.\n Вы уверены, что хотите выдать разрешение?", "Нельзя выдать разрешение", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2) == DialogResult.No))
                {
                    return;
                }
                DataRow row = this.dataSetOrder_0.tJ_OrderResolution.NewRow();
                row["idOrder"] = this.int_0;
                row["idWorker"] = this.comboBox_6.SelectedValue;
                row["datebegin"] = Convert.ToDateTime(this.nullableDateTimePicker_3.get_Value()).AddSeconds((double) -Convert.ToDateTime(this.nullableDateTimePicker_3.get_Value()).Second);
                this.dataSetOrder_0.tJ_OrderResolution.Rows.Add(row);
                base.InsertSqlData(this.dataSetOrder_0, this.dataSetOrder_0.tJ_OrderResolution);
            }
        }
        else if (this.int_0 > 0)
        {
            int count = this.dataSetOrder_0.tJ_OrderResolution.Rows.Count;
            if (count > 0)
            {
                if (this.nullableDateTimePicker_3.get_Value() == null)
                {
                    MessageBox.Show("Не введена дата окончания работы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                this.dataSetOrder_0.tJ_OrderResolution.Rows[count - 1]["dateEnd"] = Convert.ToDateTime(this.nullableDateTimePicker_3.get_Value()).AddSeconds((double) -Convert.ToDateTime(this.nullableDateTimePicker_3.get_Value()).Second);
                this.dataSetOrder_0.tJ_OrderResolution.Rows[count - 1].EndEdit();
                base.UpdateSqlData(this.dataSetOrder_0, this.dataSetOrder_0.tJ_OrderResolution);
            }
        }
        this.method_17();
    }

    private void button_3_Click(object sender, EventArgs e)
    {
        if (this.nullableDateTimePicker_4.get_Value() == null)
        {
            MessageBox.Show("Не введена дата закрытия наряда", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        else if (this.comboBox_7.SelectedValue == null)
        {
            MessageBox.Show("Не выбран диспетчер, закрывающий наряд", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        else
        {
            if ((this.dataSetOrder_0.tJ_Order.Rows.Count > 0) && Convert.ToBoolean(this.dataSetOrder_0.tJ_Order.Rows[0]["Registered"]))
            {
                this.dataSetOrder_0.tJ_Order.Rows[0]["DateClose"] = Convert.ToDateTime(this.nullableDateTimePicker_4.get_Value()).AddSeconds((double) -Convert.ToDateTime(this.nullableDateTimePicker_4.get_Value()).Second);
                this.dataSetOrder_0.tJ_Order.Rows[0]["closeWorker"] = this.comboBox_7.SelectedValue;
                this.method_10();
            }
            this.method_9();
            this.method_8();
        }
    }

    private void button_4_Click(object sender, EventArgs e)
    {
        if (this.dataSetOrder_0.tJ_Order.Rows.Count > 0)
        {
            if (this.multiColumnComboBox_0.SelectedIndex < 0)
            {
                MessageBox.Show("Не выбран сотрудник, продливающий наряд");
            }
            else if (this.nullableDateTimePicker_5.get_Value() == null)
            {
                MessageBox.Show("Не выбрана дата продления");
            }
            else if (this.method_10())
            {
                this.method_8();
                if (this.nullableDateTimePicker_5.get_Value() != null)
                {
                    if (this.nullableDateTimePicker_2.MaxDate > ((DateTime) this.nullableDateTimePicker_5.get_Value()))
                    {
                        this.nullableDateTimePicker_2.MaxDate = (DateTime) this.nullableDateTimePicker_5.get_Value();
                    }
                    this.nullableDateTimePicker_3.MaxDate = (DateTime) this.nullableDateTimePicker_5.get_Value();
                }
            }
        }
    }

    private void comboBox_0_SelectedValueChanged(object sender, EventArgs e)
    {
        if (this.comboBox_0.SelectedValue != null)
        {
            this.label_4.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
        }
    }

    private void comboBox_1_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.method_20((ComboBox) sender, this.textBox_5);
    }

    private void comboBox_1_SelectedValueChanged(object sender, EventArgs e)
    {
        if (this.comboBox_1.SelectedValue != null)
        {
            this.label_6.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
        }
    }

    private void comboBox_1_TextChanged(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(((ComboBox) sender).Text))
        {
            ((ComboBox) sender).SelectedIndex = -1;
            this.method_20((ComboBox) sender, this.textBox_5);
        }
    }

    private void comboBox_2_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.method_20((ComboBox) sender, this.textBox_1);
    }

    private void comboBox_2_TextChanged(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(((ComboBox) sender).Text))
        {
            ((ComboBox) sender).SelectedIndex = -1;
            if (this.dataSetOrder_0.tJ_Order.Rows.Count > 0)
            {
                this.dataSetOrder_0.tJ_Order.Rows[0]["headWorker"] = DBNull.Value;
            }
            this.method_20((ComboBox) sender, this.textBox_1);
        }
    }

    private void comboBox_3_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.method_20((ComboBox) sender, this.textBox_4);
    }

    private void comboBox_3_TextChanged(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(((ComboBox) sender).Text))
        {
            ((ComboBox) sender).SelectedIndex = -1;
            if (this.dataSetOrder_0.tJ_Order.Rows.Count > 0)
            {
                this.dataSetOrder_0.tJ_Order.Rows[0]["watchWorker"] = DBNull.Value;
            }
            this.method_20((ComboBox) sender, this.textBox_4);
        }
    }

    private void comboBox_4_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.method_20((ComboBox) sender, this.textBox_3);
    }

    private void comboBox_4_SelectedValueChanged(object sender, EventArgs e)
    {
        if (this.comboBox_4.SelectedValue != null)
        {
            this.label_8.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
        }
    }

    private void comboBox_4_TextChanged(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(((ComboBox) sender).Text))
        {
            ((ComboBox) sender).SelectedIndex = -1;
            this.method_20((ComboBox) sender, this.textBox_3);
        }
    }

    private void comboBox_5_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.method_20((ComboBox) sender, this.textBox_2);
        if ((this.comboBox_5.SelectedValue != null) && (this.nullableDateTimePicker_2.get_Value() == null))
        {
            if (this.nullableDateTimePicker_2.MaxDate >= DateTime.Now)
            {
                if (this.nullableDateTimePicker_2.MinDate <= DateTime.Now)
                {
                    this.nullableDateTimePicker_2.set_Value(DateTime.Now);
                }
                else
                {
                    this.nullableDateTimePicker_2.set_Value(this.nullableDateTimePicker_2.MinDate);
                }
            }
            else
            {
                this.nullableDateTimePicker_2.set_Value(this.nullableDateTimePicker_2.MaxDate);
            }
        }
    }

    private void comboBox_5_SelectedValueChanged(object sender, EventArgs e)
    {
        if ((this.comboBox_5.SelectedValue != null) && (this.nullableDateTimePicker_2.get_Value() != null))
        {
            this.label_11.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
        }
    }

    private void comboBox_5_TextChanged(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(((ComboBox) sender).Text))
        {
            ((ComboBox) sender).SelectedIndex = -1;
            this.method_20((ComboBox) sender, this.textBox_2);
        }
    }

    private void comboBox_6_SelectedIndexChanged(object sender, EventArgs e)
    {
        if ((this.comboBox_6.SelectedValue != null) && (this.nullableDateTimePicker_3.get_Value() == null))
        {
            if (this.nullableDateTimePicker_3.MaxDate >= DateTime.Now)
            {
                if (this.nullableDateTimePicker_3.MinDate <= DateTime.Now)
                {
                    this.nullableDateTimePicker_3.set_Value(DateTime.Now);
                }
                else
                {
                    this.nullableDateTimePicker_3.set_Value(this.nullableDateTimePicker_3.MinDate);
                }
            }
            else
            {
                this.nullableDateTimePicker_3.set_Value(this.nullableDateTimePicker_3.MinDate);
            }
        }
    }

    private void comboBox_7_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (((this.dataSetOrder_0.tJ_Order.Rows.Count > 0) && (this.comboBox_7.SelectedValue != null)) && (this.nullableDateTimePicker_4.get_Value() == null))
        {
            if (this.nullableDateTimePicker_4.MaxDate >= DateTime.Now)
            {
                if (this.nullableDateTimePicker_4.MinDate > DateTime.Now)
                {
                    if ((this.int_0 > 0) && (this.dataSetOrder_0.tJ_Order.Rows.Count > 0))
                    {
                        this.dataSetOrder_0.tJ_Order.Rows[0]["dateclose"] = this.nullableDateTimePicker_4.MinDate;
                    }
                    else
                    {
                        this.nullableDateTimePicker_4.set_Value(this.nullableDateTimePicker_4.MinDate);
                    }
                }
                else
                {
                    try
                    {
                        this.nullableDateTimePicker_4.set_Value(DateTime.Now);
                    }
                    catch (Exception exception1)
                    {
                        MessageBox.Show(exception1.Message);
                    }
                }
            }
            else if ((this.int_0 > 0) && (this.dataSetOrder_0.tJ_Order.Rows.Count > 0))
            {
                this.dataSetOrder_0.tJ_Order.Rows[0]["dateclose"] = this.nullableDateTimePicker_4.MaxDate;
            }
            else
            {
                this.nullableDateTimePicker_4.set_Value(this.nullableDateTimePicker_4.MaxDate);
            }
        }
    }

    protected override XmlDocument CreateXmlConfig()
    {
        XmlDocument document1 = new XmlDocument();
        XmlNode newChild = document1.CreateXmlDeclaration("1.0", "UTF-8", null);
        document1.AppendChild(newChild);
        XmlNode node2 = document1.CreateElement(base.Name);
        document1.AppendChild(node2);
        XmlAttribute node = document1.CreateAttribute("X");
        node.Value = base.Location.X.ToString();
        node2.Attributes.Append(node);
        node = document1.CreateAttribute("Y");
        node.Value = base.Location.Y.ToString();
        node2.Attributes.Append(node);
        node = document1.CreateAttribute("Width");
        node.Value = base.Width.ToString();
        node2.Attributes.Append(node);
        node = document1.CreateAttribute("Height");
        node.Value = base.Height.ToString();
        node2.Attributes.Append(node);
        node = document1.CreateAttribute("SplitterDistance");
        node.Value = this.splitContainer_0.SplitterDistance.ToString();
        node2.Attributes.Append(node);
        return document1;
    }

    private void dataGridView_0_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
        if (((e.RowIndex >= 0) && (this.dataGridView_0.Columns[e.ColumnIndex].Name == this.dataGridViewComboBoxColumn_1.Name)) && (this.dataGridView_0[e.ColumnIndex, e.RowIndex].Value != DBNull.Value))
        {
            using (IEnumerator enumerator = ((IEnumerable) this.dataGridView_0.Rows).GetEnumerator())
            {
                DataRow[] rowArray;
                while (enumerator.MoveNext())
                {
                    DataGridViewRow current = (DataGridViewRow) enumerator.Current;
                    if (((e.RowIndex != current.Index) && (current.Cells["brigadeWorkerColumn"].Value != null)) && ((this.dataGridView_0[e.ColumnIndex, e.RowIndex].Value != null) && (Convert.ToInt32(current.Cells["brigadeWorkerColumn"].Value) == Convert.ToInt32(this.dataGridView_0[e.ColumnIndex, e.RowIndex].Value))))
                    {
                        goto Label_0117;
                    }
                }
                return;
            Label_0117:
                rowArray = this.dataSetOrder_0.vWorkerGroup.Select("id = " + this.dataGridView_0[e.ColumnIndex, e.RowIndex].Value);
                string str = "";
                if (rowArray.Length != 0)
                {
                    str = rowArray[0]["FIO"].ToString();
                }
                MessageBox.Show("Работник " + str + " уже введен в данный наряд", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.dataGridView_0.BeginEdit(true);
            }
        }
    }

    private void dataGridView_0_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
        if ((e.RowIndex >= 0) && ((this.dataGridView_0[this.dataGridViewTextBoxColumn_10.Name, e.RowIndex].Value == DBNull.Value) || (Convert.ToInt32(this.dataGridView_0[this.dataGridViewTextBoxColumn_10.Name, e.RowIndex].Value) != this.int_0)))
        {
            this.dataGridView_0[this.dataGridViewTextBoxColumn_10.Name, e.RowIndex].Value = this.int_0;
        }
    }

    private void dataGridView_0_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
    {
        if (((this.dataGridView_0.CurrentCell == null) || (this.dataGridView_0.Columns[this.dataGridView_0.CurrentCell.ColumnIndex] != this.dataGridViewComboBoxColumn_2)) && (e.Control is ComboBox))
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
                    if (((this.dataGridView_0.CurrentCell == null) || (this.dataGridView_0.CurrentCell.RowIndex != row.Index)) && (row.Cells[this.dataGridViewComboBoxColumn_1.Name].Value != null))
                    {
                        str = str + row.Cells[this.dataGridViewComboBoxColumn_1.Name].Value.ToString() + ",";
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
            (e.Control as ComboBox).SelectedValueChanged -= new EventHandler(this.method_14);
            (e.Control as ComboBox).SelectedValueChanged += new EventHandler(this.method_14);
        }
    }

    private void dataGridView_0_KeyDown(object sender, KeyEventArgs e)
    {
        if (((this.dataGridView_0.CurrentCell != null) && (this.dataGridView_0.Columns[this.dataGridView_0.CurrentCell.ColumnIndex] == this.dataGridViewComboBoxColumn_2)) && ((Control.ModifierKeys == Keys.None) && (e.KeyCode == Keys.Delete)))
        {
            this.dataGridView_0.CurrentCell.Value = DBNull.Value;
        }
    }

    private void dataGridView_0_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
    {
        for (int i = 0; i < e.RowCount; i++)
        {
            DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell) this.dataGridView_0[this.dataGridViewComboBoxColumn_1.Name, e.RowIndex + i];
            if (!string.IsNullOrEmpty(this.get_SqlSettings().get_ServerDB()))
            {
                DataTable table = this.method_5();
                BindingSource source = new BindingSource {
                    DataSource = table
                };
                base.SelectSqlData(table, true, " where ParentKey in (';GroupWorker;Workers;')  and dateend is null group by id, fio, groupelectrical order by fio ", false);
                cell.DataSource = source;
                cell.DisplayMember = "FIOGROUP";
                cell.ValueMember = "ID";
            }
            if (this.dataGridView_0[this.dataGridViewComboBoxColumn_1.Name, e.RowIndex + i].Value != null)
            {
                DataRow row = ((cell.DataSource as BindingSource).DataSource as DataTable).Rows.Find(cell.Value);
                if ((row != null) && (row["GroupElectrical"] != DBNull.Value))
                {
                    switch (Convert.ToInt32(row["GroupElectrical"]))
                    {
                        case 1:
                        {
                            this.dataGridView_0[this.dataGridViewTextBoxColumn_11.Name, e.RowIndex + i].Value = "I";
                            continue;
                        }
                        case 2:
                        {
                            this.dataGridView_0[this.dataGridViewTextBoxColumn_11.Name, e.RowIndex + i].Value = "II";
                            continue;
                        }
                        case 3:
                        {
                            this.dataGridView_0[this.dataGridViewTextBoxColumn_11.Name, e.RowIndex + i].Value = "III";
                            continue;
                        }
                        case 4:
                        {
                            this.dataGridView_0[this.dataGridViewTextBoxColumn_11.Name, e.RowIndex + i].Value = "IV";
                            continue;
                        }
                        case 5:
                        {
                            this.dataGridView_0[this.dataGridViewTextBoxColumn_11.Name, e.RowIndex + i].Value = "V";
                            continue;
                        }
                    }
                    this.dataGridView_0[this.dataGridViewTextBoxColumn_11.Name, e.RowIndex + i].Value = "";
                }
            }
        }
    }

    private void dataGridView_1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if ((e.ColumnIndex == -1) && (e.RowIndex > -1))
        {
            DataRow row = this.dataSetOrder_0.tJ_OrderInstruction.NewRow();
            row["idorder"] = this.int_0;
            row["NameObj"] = "-";
            row["Instruction"] = "-";
            this.dataSetOrder_0.tJ_OrderInstruction.Rows.InsertAt(row, e.RowIndex);
        }
    }

    private void dataGridView_1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            this.dataGridView_1["idOrderDgvColumnInstruction", e.RowIndex].Value = this.int_0;
        }
    }

    private void dataGridView_1_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
        MessageBox.Show(e.Exception.Message);
        e.Cancel = true;
    }

    private void dataGridView_2_DataError(object sender, DataGridViewDataErrorEventArgs e)
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

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.icontainer_0 != null))
        {
            this.icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    private void Form19_FormClosed(object sender, FormClosedEventArgs e)
    {
        base.SaveFormConfig(null);
    }

    private void Form19_FormClosing(object sender, FormClosingEventArgs e)
    {
        if ((this.dataSetOrder_0.tJ_Order.Rows.Count > 0) && ((this.dataSetOrder_0.tJ_Order.Rows[0]["Registered"] == DBNull.Value) || !Convert.ToBoolean(this.dataSetOrder_0.tJ_Order.Rows[0]["Registered"])))
        {
            this.dataSetOrder_0.tJ_Order.Rows[0].EndEdit();
            DataTable changes = this.dataSetOrder_0.tJ_Order.GetChanges();
            if ((changes != null) && (changes.Rows.Count > 0))
            {
                if (MessageBox.Show("Сохранить внесенные изменения в наряд?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (this.method_12())
                    {
                        this.method_10();
                    }
                    else
                    {
                        e.Cancel = false;
                    }
                }
            }
            else
            {
                foreach (DataRow row in this.dataSetOrder_0.tJ_OrderBrigade.Rows)
                {
                    if (row.RowState != DataRowState.Deleted)
                    {
                        if (Convert.ToInt32(row["idorder"]) != this.method_2())
                        {
                            row["idorder"] = this.int_0;
                        }
                        row.EndEdit();
                    }
                }
                changes = this.dataSetOrder_0.tJ_OrderBrigade.GetChanges();
                if ((changes != null) && (changes.Rows.Count > 0))
                {
                    if (MessageBox.Show("Сохранить внесенные изменения в наряд?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (this.method_12())
                        {
                            this.method_10();
                        }
                        else
                        {
                            e.Cancel = false;
                        }
                    }
                }
                else
                {
                    int num = 0;
                    foreach (DataRow row2 in this.dataSetOrder_0.tJ_OrderInstruction.Rows)
                    {
                        if (row2.RowState != DataRowState.Deleted)
                        {
                            if (Convert.ToInt32(row2["idorder"]) != this.method_2())
                            {
                                row2["idorder"] = this.int_0;
                            }
                            if ((row2["rec_num"] == DBNull.Value) || (Convert.ToInt32(row2["rec_num"]) != num++))
                            {
                                row2["rec_num"] = num;
                            }
                            row2.EndEdit();
                        }
                    }
                    changes = this.dataSetOrder_0.tJ_OrderInstruction.GetChanges();
                    if ((changes != null) && (changes.Rows.Count > 0))
                    {
                        if (MessageBox.Show("Сохранить внесенные изменения в наряд?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (this.method_12())
                            {
                                this.method_10();
                            }
                            else
                            {
                                e.Cancel = false;
                            }
                        }
                    }
                    else
                    {
                        foreach (int num2 in this.dictionary_0.Keys)
                        {
                            if (this.dataSetOrder_0.tL_OrderSchmObjList.Select(" idSChmObj = " + num2.ToString()).Length == 0)
                            {
                                DataRow row3 = this.dataSetOrder_0.tL_OrderSchmObjList.NewRow();
                                row3["idOrder"] = this.method_2();
                                row3["idSchmObj"] = num2;
                                this.dataSetOrder_0.tL_OrderSchmObjList.Rows.Add(row3);
                            }
                        }
                        for (num = 0; num < this.dataSetOrder_0.tL_OrderSchmObjList.Rows.Count; num++)
                        {
                            if ((this.dataSetOrder_0.tL_OrderSchmObjList.Rows[num].RowState != DataRowState.Deleted) && !this.dictionary_0.ContainsKey(Convert.ToInt32(this.dataSetOrder_0.tL_OrderSchmObjList.Rows[num]["idSChmObj"])))
                            {
                                this.dataSetOrder_0.tL_OrderSchmObjList.Rows[num].Delete();
                            }
                        }
                        changes = this.dataSetOrder_0.tL_OrderSchmObjList.GetChanges();
                        if (((changes != null) && (changes.Rows.Count > 0)) && (MessageBox.Show("Сохранить внесенные изменения в наряд?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                        {
                            if (this.method_12())
                            {
                                this.method_10();
                            }
                            else
                            {
                                e.Cancel = false;
                            }
                        }
                    }
                }
            }
        }
    }

    private void Form19_KeyDown(object sender, KeyEventArgs e)
    {
    }

    private void Form19_Load(object sender, EventArgs e)
    {
        this.method_4();
        if (this.int_0 < 0)
        {
            DateTime now = DateTime.Now;
            this.nullableDateTimePicker_5.set_Value(null);
            this.nullableDateTimePicker_0.set_Value(now);
            this.nullableDateTimePicker_0.set_Value(null);
            this.nullableDateTimePicker_2.set_Value(now);
            this.nullableDateTimePicker_2.set_Value(null);
            this.nullableDateTimePicker_0.MaxDate = this.dateTime_1;
            this.nullableDateTimePicker_3.MinDate = this.dateTime_0;
            if (this.nullableDateTimePicker_2.get_Value() != null)
            {
                this.nullableDateTimePicker_1.MinDate = (DateTime) this.nullableDateTimePicker_2.get_Value();
            }
            else
            {
                this.nullableDateTimePicker_2.MinDate = this.dateTime_0;
            }
            if (this.nullableDateTimePicker_1.get_Value() != null)
            {
                this.nullableDateTimePicker_2.MaxDate = (DateTime) this.nullableDateTimePicker_1.get_Value();
            }
            else
            {
                this.nullableDateTimePicker_2.MaxDate = this.dateTime_1;
            }
        }
        base.LoadFormConfig(null);
        if (base.Location.X < 0)
        {
            base.Location = new Point(0, base.Location.Y);
        }
        if (base.Location.Y < 0)
        {
            base.Location = new Point(base.Location.X, 0);
        }
        if (base.Right > base.Parent.Right)
        {
            base.Width -= base.Right - base.Parent.Right;
        }
        if (base.Bottom > base.Parent.Bottom)
        {
            base.Height -= base.Bottom - base.Parent.Bottom;
        }
        this.method_3();
        base.SelectSqlData(this.dataSetOrder_0, this.dataSetOrder_0.vWorkerGroup, true, " where ParentKey in (';GroupWorker;ITR;', ';GroupWorker;Workers;', ';GroupWorker;Dispatchers;')  and dateend is null order by fio ");
        DataSetOrder order = new DataSetOrder();
        this.dataGridViewComboBoxColumn_2.DataSource = order;
        this.dataGridViewComboBoxColumn_2.ValueMember = "tR_Classifier.Id";
        this.dataGridViewComboBoxColumn_2.DisplayMember = "tR_Classifier.Name";
        base.SelectSqlData(order, order.tR_Classifier, true, " where parentkey = ';Other;JobTitle;' and isgroup = 0 and deleted = 0 order by [name]");
        this.method_6();
        if (this.int_0 == -1)
        {
            this.Text = "Новый наряд";
            if (this.method_0().HasValue && this.comboBoxReadOnly_0.get_Visible())
            {
                this.comboBoxReadOnly_0.SelectedValue = this.method_0();
            }
        }
        else
        {
            this.toolStripButton_4.Enabled = true;
            this.toolStripButton_0.Enabled = true;
            this.method_9();
            base.SelectSqlData(this.dataSetOrder_0, this.dataSetOrder_0.tJ_OrderBrigade, true, " where idorder = " + this.int_0.ToString());
            base.SelectSqlData(this.dataSetOrder_0, this.dataSetOrder_0.tJ_OrderInstruction, true, " where idorder = " + this.int_0.ToString() + " order by rec_num");
            base.SelectSqlData(this.dataSetOrder_0, this.dataSetOrder_0.tJ_OrderResolution, true, " where idorder = " + this.int_0.ToString() + " order by datebegin ");
            base.SelectSqlData(this.dataSetOrder_0, this.dataSetOrder_0.tL_OrderSchmObjList, true, " where idOrder = " + this.int_0.ToString());
            this.dictionary_0.Clear();
            foreach (DataRow row in this.dataSetOrder_0.tL_OrderSchmObjList)
            {
                string[] textArray1 = new string[] { row["idSchmObj"].ToString() };
                this.dictionary_0.Add(Convert.ToInt32(row["idSchmObj"]), base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", textArray1).ToString());
            }
            if (this.dictionary_0.Count > 0)
            {
                this.toolStripButton_3.Enabled = true;
            }
            this.method_19();
            if (this.bool_0)
            {
                this.Text = "Просмотр наряда №" + this.dataSetOrder_0.tJ_Order.Rows[0]["num"].ToString();
            }
            else
            {
                this.Text = "Редактирование наряда №" + this.dataSetOrder_0.tJ_Order.Rows[0]["num"].ToString();
            }
            if (this.nullableDateTimePicker_5.get_Value() != null)
            {
                if (this.nullableDateTimePicker_2.MaxDate > ((DateTime) this.nullableDateTimePicker_5.get_Value()))
                {
                    this.nullableDateTimePicker_2.MaxDate = (DateTime) this.nullableDateTimePicker_5.get_Value();
                }
                this.nullableDateTimePicker_3.MaxDate = (DateTime) this.nullableDateTimePicker_5.get_Value();
            }
        }
        this.method_8();
    }

    [CompilerGenerated]
    internal int? method_0()
    {
        return this.nullable_0;
    }

    [CompilerGenerated]
    internal void method_1(int? nullable_1)
    {
        this.nullable_0 = nullable_1;
    }

    private bool method_10()
    {
        if (this.int_0 == -1)
        {
            DataRow row = this.dataSetOrder_0.tJ_Order.NewRow();
            row["num"] = 0;
            row["DateBegin"] = this.nullableDateTimePicker_0.get_Value();
            row["DateEnd"] = this.nullableDateTimePicker_1.get_Value();
            row["idSR"] = this.comboBox_0.SelectedValue;
            row["Instruction"] = this.richTextBox_0.Text;
            row["headWorker"] = (this.comboBox_2.SelectedValue == null) ? DBNull.Value : this.comboBox_2.SelectedValue;
            row["acceptWorker"] = this.comboBox_1.SelectedValue;
            row["watchWorker"] = (this.comboBox_3.SelectedValue == null) ? DBNull.Value : this.comboBox_3.SelectedValue;
            row["makerWorker"] = this.comboBox_4.SelectedValue;
            if (!string.IsNullOrEmpty(this.richTextBox_1.Text))
            {
                row["otherInstruction"] = this.richTextBox_1.Text;
            }
            row["dateOutput"] = this.nullableDateTimePicker_2.get_Value();
            row["outputWorker"] = this.comboBox_5.SelectedValue;
            row["Registered"] = false;
            row["idDivision"] = (this.comboBoxReadOnly_0.SelectedValue == null) ? DBNull.Value : this.comboBoxReadOnly_0.SelectedValue;
            this.dataSetOrder_0.tJ_Order.Rows.Add(row);
            this.dataSetOrder_0.tJ_Order.Rows[0].EndEdit();
            this.int_0 = base.InsertSqlDataOneRow(this.dataSetOrder_0, this.dataSetOrder_0.tJ_Order);
            if (this.int_0 != -1)
            {
                this.toolStripButton_4.Enabled = true;
                this.toolStripButton_0.Enabled = true;
                this.method_9();
                this.button_1.Enabled = true;
                this.method_11();
                if (this.method_15() && this.method_16())
                {
                    return true;
                }
            }
            return false;
        }
        this.dataSetOrder_0.tJ_Order.Rows[0].EndEdit();
        if (base.UpdateSqlData(this.dataSetOrder_0, this.dataSetOrder_0.tJ_Order))
        {
            this.method_9();
            this.method_11();
            if (this.method_15() && this.method_16())
            {
                return true;
            }
        }
        return false;
    }

    private void method_11()
    {
        foreach (int num in this.dictionary_0.Keys)
        {
            if (this.dataSetOrder_0.tL_OrderSchmObjList.Select(" idSChmObj = " + num.ToString()).Length == 0)
            {
                DataRow row = this.dataSetOrder_0.tL_OrderSchmObjList.NewRow();
                row["idOrder"] = this.method_2();
                row["idSchmObj"] = num;
                this.dataSetOrder_0.tL_OrderSchmObjList.Rows.Add(row);
            }
        }
        for (int i = 0; i < this.dataSetOrder_0.tL_OrderSchmObjList.Rows.Count; i++)
        {
            if ((this.dataSetOrder_0.tL_OrderSchmObjList.Rows[i].RowState != DataRowState.Deleted) && !this.dictionary_0.ContainsKey(Convert.ToInt32(this.dataSetOrder_0.tL_OrderSchmObjList.Rows[i]["idSChmObj"])))
            {
                this.dataSetOrder_0.tL_OrderSchmObjList.Rows[i].Delete();
            }
        }
        base.InsertSqlData(this.dataSetOrder_0, this.dataSetOrder_0.tL_OrderSchmObjList);
        base.DeleteSqlData(this.dataSetOrder_0, this.dataSetOrder_0.tL_OrderSchmObjList);
        this.dataSetOrder_0.tL_OrderSchmObjList.AcceptChanges();
    }

    private bool method_12()
    {
        bool flag = true;
        if (this.nullableDateTimePicker_0.get_Value() == null)
        {
            this.label_1.ForeColor = Color.Red;
            flag = false;
        }
        if (this.nullableDateTimePicker_1.get_Value() == null)
        {
            this.label_2.ForeColor = Color.Red;
            flag = false;
        }
        if (string.IsNullOrEmpty(this.richTextBox_0.Text))
        {
            this.label_3.ForeColor = Color.Red;
            flag = false;
        }
        if (this.comboBox_0.SelectedValue == null)
        {
            this.label_4.ForeColor = Color.Red;
            flag = false;
        }
        if (this.comboBox_1.SelectedValue == null)
        {
            this.label_6.ForeColor = Color.Red;
            flag = false;
        }
        if (this.comboBox_4.SelectedValue == null)
        {
            this.label_8.ForeColor = Color.Red;
            flag = false;
        }
        if (this.comboBox_5.SelectedValue == null)
        {
            this.label_11.ForeColor = Color.Red;
            flag = false;
        }
        if (this.nullableDateTimePicker_2.get_Value() == null)
        {
            this.label_15.ForeColor = Color.Red;
            flag = false;
        }
        if (!flag)
        {
            MessageBox.Show("Не введены обязательные значения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        return flag;
    }

    private bool method_13()
    {
        if (!this.method_12())
        {
            return false;
        }
        if (this.listBox_0.Items.Count <= 0)
        {
            MessageBox.Show("Наряд не привязан к объектам схемы!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }
        if (this.dataSetOrder_0.tJ_OrderBrigade.Rows.Count <= 0)
        {
            MessageBox.Show("Нет ни одного члена бригады!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            return false;
        }
        return true;
    }

    private void method_14(object sender, EventArgs e)
    {
        if (((this.dataGridView_0.CurrentCell != null) && (((ComboBox) sender).SelectedValue != null)) && (((ComboBox) sender).SelectedValue.GetType() != typeof(DataRowView)))
        {
            BindingSource dataSource = ((ComboBox) sender).DataSource as BindingSource;
            if (dataSource != null)
            {
                DataTable table = dataSource.DataSource as DataTable;
                if (table != null)
                {
                    DataRow row = table.Rows.Find(((ComboBox) sender).SelectedValue);
                    if (row["GroupElectrical"] != DBNull.Value)
                    {
                        switch (Convert.ToInt32(row["GroupElectrical"]))
                        {
                            case 1:
                                this.dataGridView_0[this.dataGridViewTextBoxColumn_11.Name, this.dataGridView_0.CurrentCell.RowIndex].Value = "I";
                                return;

                            case 2:
                                this.dataGridView_0[this.dataGridViewTextBoxColumn_11.Name, this.dataGridView_0.CurrentCell.RowIndex].Value = "II";
                                return;

                            case 3:
                                this.dataGridView_0[this.dataGridViewTextBoxColumn_11.Name, this.dataGridView_0.CurrentCell.RowIndex].Value = "III";
                                return;

                            case 4:
                                this.dataGridView_0[this.dataGridViewTextBoxColumn_11.Name, this.dataGridView_0.CurrentCell.RowIndex].Value = "IV";
                                return;

                            case 5:
                                this.dataGridView_0[this.dataGridViewTextBoxColumn_11.Name, this.dataGridView_0.CurrentCell.RowIndex].Value = "V";
                                return;
                        }
                        this.dataGridView_0[this.dataGridViewTextBoxColumn_11.Name, this.dataGridView_0.CurrentCell.RowIndex].Value = "";
                    }
                    else
                    {
                        this.dataGridView_0[this.dataGridViewTextBoxColumn_11.Name, this.dataGridView_0.CurrentCell.RowIndex].Value = "";
                    }
                }
            }
        }
    }

    private bool method_15()
    {
        foreach (DataRow row in this.dataSetOrder_0.tJ_OrderBrigade.Rows)
        {
            if (row.RowState != DataRowState.Deleted)
            {
                row["idorder"] = this.int_0;
                row.EndEdit();
            }
        }
        if ((base.InsertSqlData(this.dataSetOrder_0, this.dataSetOrder_0.tJ_OrderBrigade) && base.UpdateSqlData(this.dataSetOrder_0, this.dataSetOrder_0.tJ_OrderBrigade)) && base.DeleteSqlData(this.dataSetOrder_0, this.dataSetOrder_0.tJ_OrderBrigade))
        {
            base.SelectSqlData(this.dataSetOrder_0, this.dataSetOrder_0.tJ_OrderBrigade, true, " where idorder = " + this.int_0.ToString());
            return true;
        }
        return false;
    }

    private bool method_16()
    {
        int num = 0;
        foreach (DataRow row in this.dataSetOrder_0.tJ_OrderInstruction.Rows)
        {
            if (row.RowState != DataRowState.Deleted)
            {
                row["idorder"] = this.int_0;
                row["rec_num"] = num++;
                row.EndEdit();
            }
        }
        if ((base.InsertSqlData(this.dataSetOrder_0, this.dataSetOrder_0.tJ_OrderInstruction) && base.UpdateSqlData(this.dataSetOrder_0, this.dataSetOrder_0.tJ_OrderInstruction)) && base.DeleteSqlData(this.dataSetOrder_0, this.dataSetOrder_0.tJ_OrderInstruction))
        {
            base.SelectSqlData(this.dataSetOrder_0, this.dataSetOrder_0.tJ_OrderInstruction, true, " where idorder = " + this.int_0.ToString() + " order by rec_num");
            return true;
        }
        return false;
    }

    private void method_17()
    {
        base.SelectSqlData(this.dataSetOrder_0, this.dataSetOrder_0.tJ_OrderResolution, true, " where idorder = " + this.int_0.ToString() + " order by datebegin ");
        this.method_8();
    }

    private void method_18()
    {
        this.nullableDateTimePicker_0.get_Value();
        this.nullableDateTimePicker_1.get_Value();
        object selectedValue = this.comboBox_0.SelectedValue;
        object text = this.richTextBox_0.Text;
        object obj4 = this.comboBox_2.SelectedValue;
        object obj5 = this.comboBox_1.SelectedValue;
        object obj6 = this.comboBox_3.SelectedValue;
        object obj7 = this.comboBox_4.SelectedValue;
        object obj8 = this.richTextBox_1.Text;
        this.nullableDateTimePicker_2.get_Value();
        object obj1 = this.comboBox_5.SelectedValue;
        object obj9 = this.comboBoxReadOnly_0.SelectedValue;
        this.dataSetOrder_0.tJ_Order.Clear();
        this.nullableDateTimePicker_0.set_Value(null);
        this.nullableDateTimePicker_1.set_Value(null);
        if (selectedValue == null)
        {
            this.comboBox_0.SelectedIndex = -1;
        }
        else
        {
            this.comboBox_0.SelectedValue = selectedValue;
        }
        this.richTextBox_0.Text = text.ToString();
        if (obj4 == null)
        {
            this.comboBox_2.SelectedIndex = -1;
        }
        else
        {
            this.comboBox_2.SelectedValue = obj4;
        }
        if (obj5 == null)
        {
            this.comboBox_1.SelectedIndex = -1;
        }
        else
        {
            this.comboBox_1.SelectedValue = obj5;
        }
        if (obj6 == null)
        {
            this.comboBox_3.SelectedIndex = -1;
        }
        else
        {
            this.comboBox_3.SelectedValue = obj6;
        }
        if (obj7 == null)
        {
            this.comboBox_4.SelectedIndex = -1;
        }
        else
        {
            this.comboBox_4.SelectedValue = obj7;
        }
        if (obj9 == null)
        {
            this.comboBoxReadOnly_0.SelectedIndex = -1;
        }
        else
        {
            this.comboBoxReadOnly_0.SelectedValue = obj9;
        }
        this.richTextBox_1.Text = obj8.ToString();
        this.nullableDateTimePicker_2.set_Value(null);
        this.comboBox_5.SelectedValue = DBNull.Value;
        this.dictionary_0.Clear();
        this.method_19();
        this.toolStripButton_3.Enabled = false;
    }

    private void method_19()
    {
        this.listBox_0.Items.Clear();
        foreach (int num in this.dictionary_0.Keys)
        {
            this.listBox_0.Items.Add(new Struct2(num, this.dictionary_0[num]));
        }
    }

    internal int method_2()
    {
        return this.int_0;
    }

    private void method_20(ComboBox comboBox_8, TextBox textBox_6)
    {
        if (comboBox_8.SelectedValue != null)
        {
            DataRow row = (comboBox_8.DataSource as DataTable).Rows.Find(comboBox_8.SelectedValue);
            if (row["GroupElectrical"] != DBNull.Value)
            {
                switch (Convert.ToInt32(row["GroupElectrical"]))
                {
                    case 1:
                        textBox_6.Text = "I";
                        return;

                    case 2:
                        textBox_6.Text = "II";
                        return;

                    case 3:
                        textBox_6.Text = "III";
                        return;

                    case 4:
                        textBox_6.Text = "IV";
                        return;

                    case 5:
                        textBox_6.Text = "V";
                        return;
                }
                textBox_6.Text = "";
            }
            else
            {
                textBox_6.Text = "";
            }
        }
        else
        {
            textBox_6.Text = "";
        }
    }

    private void method_21()
    {
        DataGridViewCellStyle style = new DataGridViewCellStyle();
        DataGridViewCellStyle style2 = new DataGridViewCellStyle();
        DataGridViewCellStyle style3 = new DataGridViewCellStyle();
        DataGridViewCellStyle style4 = new DataGridViewCellStyle();
        DataGridViewCellStyle style5 = new DataGridViewCellStyle();
        DataGridViewCellStyle style6 = new DataGridViewCellStyle();
        DataGridViewCellStyle style7 = new DataGridViewCellStyle();
        DataGridViewCellStyle style8 = new DataGridViewCellStyle();
        DataGridViewCellStyle style9 = new DataGridViewCellStyle();
        this.label_0 = new Label();
        this.textBox_0 = new TextBox();
        this.dataSetOrder_0 = new DataSetOrder();
        this.label_1 = new Label();
        this.label_2 = new Label();
        this.label_3 = new Label();
        this.richTextBox_0 = new RichTextBox();
        this.label_4 = new Label();
        this.comboBox_0 = new ComboBox();
        this.label_5 = new Label();
        this.label_6 = new Label();
        this.label_7 = new Label();
        this.label_8 = new Label();
        this.label_9 = new Label();
        this.label_10 = new Label();
        this.richTextBox_1 = new RichTextBox();
        this.label_11 = new Label();
        this.comboBox_1 = new ComboBox();
        this.nullableDateTimePicker_0 = new NullableDateTimePicker();
        this.nullableDateTimePicker_1 = new NullableDateTimePicker();
        this.comboBox_2 = new ComboBox();
        this.comboBox_3 = new ComboBox();
        this.comboBox_4 = new ComboBox();
        this.comboBox_5 = new ComboBox();
        this.nullableDateTimePicker_2 = new NullableDateTimePicker();
        this.button_0 = new Button();
        this.button_1 = new Button();
        this.dataGridView_0 = new DataGridView();
        this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
        this.dataGridViewComboBoxColumn_1 = new DataGridViewComboBoxColumn();
        this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
        this.dataGridViewComboBoxColumn_2 = new DataGridViewComboBoxColumn();
        this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
        this.label_12 = new Label();
        this.dataGridView_1 = new DataGridView();
        this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
        this.dataGridView_2 = new DataGridView();
        this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
        this.dataGridViewComboBoxColumn_0 = new DataGridViewComboBoxColumn();
        this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
        this.comboBox_6 = new ComboBox();
        this.nullableDateTimePicker_3 = new NullableDateTimePicker();
        this.button_2 = new Button();
        this.button_3 = new Button();
        this.nullableDateTimePicker_4 = new NullableDateTimePicker();
        this.comboBox_7 = new ComboBox();
        this.toolStrip_0 = new ToolStrip();
        this.toolStripButton_0 = new ToolStripButton();
        this.toolStripButton_4 = new ToolStripButton();
        this.splitContainer_0 = new SplitContainer();
        this.label_15 = new Label();
        this.panel_0 = new Panel();
        this.button_4 = new Button();
        this.nullableDateTimePicker_5 = new NullableDateTimePicker();
        this.multiColumnComboBox_0 = new MultiColumnComboBox();
        this.label_14 = new Label();
        this.textBox_2 = new TextBox();
        this.toolStrip_1 = new ToolStrip();
        this.toolStripButton_1 = new ToolStripButton();
        this.toolStripButton_2 = new ToolStripButton();
        this.toolStripButton_3 = new ToolStripButton();
        this.listBox_0 = new ListBox();
        this.label_17 = new Label();
        this.comboBoxReadOnly_0 = new ComboBoxReadOnly();
        this.label_16 = new Label();
        this.textBox_3 = new TextBox();
        this.textBox_4 = new TextBox();
        this.textBox_5 = new TextBox();
        this.textBox_1 = new TextBox();
        this.label_13 = new Label();
        this.dataSetOrder_0.BeginInit();
        ((ISupportInitialize) this.dataGridView_0).BeginInit();
        ((ISupportInitialize) this.dataGridView_1).BeginInit();
        ((ISupportInitialize) this.dataGridView_2).BeginInit();
        this.toolStrip_0.SuspendLayout();
        this.splitContainer_0.Panel1.SuspendLayout();
        this.splitContainer_0.Panel2.SuspendLayout();
        this.splitContainer_0.SuspendLayout();
        this.panel_0.SuspendLayout();
        this.toolStrip_1.SuspendLayout();
        base.SuspendLayout();
        this.label_0.AutoSize = true;
        this.label_0.Location = new Point(13, 0x25);
        this.label_0.Name = "label1";
        this.label_0.Size = new Size(0x5b, 13);
        this.label_0.TabIndex = 0;
        this.label_0.Text = "Наряд-допуск №";
        this.textBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.textBox_0.DataBindings.Add(new Binding("Text", this.dataSetOrder_0, "tJ_Order.num", true));
        this.textBox_0.Location = new Point(110, 0x22);
        this.textBox_0.Name = "txtNumOrder";
        this.textBox_0.ReadOnly = true;
        this.textBox_0.Size = new Size(0x66, 20);
        this.textBox_0.TabIndex = 1;
        this.dataSetOrder_0.DataSetName = "DataSetOrder";
        this.dataSetOrder_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        this.label_1.AutoSize = true;
        this.label_1.Location = new Point(13, 0x4d);
        this.label_1.Name = "labelDateBegin";
        this.label_1.Size = new Size(0x54, 13);
        this.label_1.TabIndex = 2;
        this.label_1.Text = "Начало работы";
        this.label_2.AutoSize = true;
        this.label_2.Location = new Point(13, 0x63);
        this.label_2.Name = "labelDateEnd";
        this.label_2.Size = new Size(0x66, 13);
        this.label_2.TabIndex = 3;
        this.label_2.Text = "Окончание работы";
        this.label_3.AutoSize = true;
        this.label_3.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        this.label_3.Location = new Point(13, 0x7b);
        this.label_3.Name = "labelInstruction";
        this.label_3.Size = new Size(0x57, 0x11);
        this.label_3.TabIndex = 6;
        this.label_3.Text = "Поручается";
        this.richTextBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.richTextBox_0.DataBindings.Add(new Binding("Text", this.dataSetOrder_0, "tJ_Order.instruction", true));
        this.richTextBox_0.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        this.richTextBox_0.Location = new Point(0x10, 0x8f);
        this.richTextBox_0.Name = "richTxtInstruction";
        this.richTextBox_0.Size = new Size(230, 0x56);
        this.richTextBox_0.TabIndex = 7;
        this.richTextBox_0.Text = "";
        this.richTextBox_0.TextChanged += new EventHandler(this.richTextBox_0_TextChanged);
        this.label_4.AutoSize = true;
        this.label_4.Location = new Point(0x2c, 0x11);
        this.label_4.Name = "labelSR";
        this.label_4.Size = new Size(0x52, 13);
        this.label_4.TabIndex = 8;
        this.label_4.Text = "Сетевой район";
        this.comboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        this.comboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
        this.comboBox_0.DataBindings.Add(new Binding("SelectedValue", this.dataSetOrder_0, "tJ_Order.idSR", true));
        this.comboBox_0.DataSource = this.dataSetOrder_0;
        this.comboBox_0.DisplayMember = "tR_Classifier.Name";
        this.comboBox_0.FormattingEnabled = true;
        this.comboBox_0.Location = new Point(0x84, 14);
        this.comboBox_0.Name = "cmbSR";
        this.comboBox_0.Size = new Size(0x9e, 0x15);
        this.comboBox_0.TabIndex = 9;
        this.comboBox_0.ValueMember = "tR_Classifier.Id";
        this.comboBox_0.SelectedValueChanged += new EventHandler(this.comboBox_0_SelectedValueChanged);
        this.label_5.AutoSize = true;
        this.label_5.Location = new Point(0x10, 0x43);
        this.label_5.Name = "label6";
        this.label_5.Size = new Size(110, 13);
        this.label_5.TabIndex = 10;
        this.label_5.Text = "Руководитель работ";
        this.label_6.AutoSize = true;
        this.label_6.Location = new Point(0x2c, 0x5f);
        this.label_6.Name = "labelAccept";
        this.label_6.Size = new Size(80, 13);
        this.label_6.TabIndex = 11;
        this.label_6.Text = "Допускающий";
        this.label_7.AutoSize = true;
        this.label_7.Location = new Point(0x2c, 0x7c);
        this.label_7.Name = "label8";
        this.label_7.Size = new Size(0x52, 13);
        this.label_7.TabIndex = 12;
        this.label_7.Text = "Наблюдающий";
        this.label_8.AutoSize = true;
        this.label_8.Location = new Point(6, 0x98);
        this.label_8.Name = "labelMaker";
        this.label_8.Size = new Size(0x76, 13);
        this.label_8.TabIndex = 13;
        this.label_8.Text = "Производитель работ";
        this.label_9.AutoSize = true;
        this.label_9.Location = new Point(0x133, 0x11);
        this.label_9.Name = "label10";
        this.label_9.Size = new Size(0x57, 13);
        this.label_9.TabIndex = 14;
        this.label_9.Text = "Члены бригады";
        this.label_10.AutoSize = true;
        this.label_10.Location = new Point(13, 0xe8);
        this.label_10.Name = "label11";
        this.label_10.Size = new Size(0x72, 13);
        this.label_10.TabIndex = 15;
        this.label_10.Text = "Отдельные указания";
        this.richTextBox_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
        this.richTextBox_1.DataBindings.Add(new Binding("Text", this.dataSetOrder_0, "tJ_Order.otherInstruction", true));
        this.richTextBox_1.Location = new Point(0x10, 0xf8);
        this.richTextBox_1.Name = "richTxtOtrherInstructions";
        this.richTextBox_1.Size = new Size(230, 0x55);
        this.richTextBox_1.TabIndex = 0x10;
        this.richTextBox_1.Text = "";
        this.label_11.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
        this.label_11.AutoSize = true;
        this.label_11.Location = new Point(13, 0x198);
        this.label_11.Name = "labelOutput";
        this.label_11.Size = new Size(0x4a, 13);
        this.label_11.TabIndex = 0x11;
        this.label_11.Text = "Наряд выдал";
        this.comboBox_1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        this.comboBox_1.AutoCompleteSource = AutoCompleteSource.ListItems;
        this.comboBox_1.DataBindings.Add(new Binding("SelectedValue", this.dataSetOrder_0, "tJ_Order.acceptworker", true));
        this.comboBox_1.DisplayMember = "FIO";
        this.comboBox_1.FormattingEnabled = true;
        this.comboBox_1.Location = new Point(0x84, 0x5c);
        this.comboBox_1.Name = "cmbAcceptWorker";
        this.comboBox_1.Size = new Size(0x85, 0x15);
        this.comboBox_1.TabIndex = 0x15;
        this.comboBox_1.ValueMember = "id";
        this.comboBox_1.SelectedIndexChanged += new EventHandler(this.comboBox_1_SelectedIndexChanged);
        this.comboBox_1.SelectedValueChanged += new EventHandler(this.comboBox_1_SelectedValueChanged);
        this.comboBox_1.TextChanged += new EventHandler(this.comboBox_1_TextChanged);
        this.nullableDateTimePicker_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.nullableDateTimePicker_0.set_CustomFormat("dd:MM:yyyy HH:mm");
        this.nullableDateTimePicker_0.DataBindings.Add(new Binding("Value", this.dataSetOrder_0, "tJ_Order.dateBegin", true));
        this.nullableDateTimePicker_0.set_Format(DateTimePickerFormat.Custom);
        this.nullableDateTimePicker_0.Location = new Point(0x73, 0x47);
        this.nullableDateTimePicker_0.Name = "dateTimePickerDateBegin";
        this.nullableDateTimePicker_0.Size = new Size(0x83, 20);
        this.nullableDateTimePicker_0.TabIndex = 0x18;
        this.nullableDateTimePicker_0.set_Value(new DateTime(0x7dc, 6, 5, 9, 0x19, 13, 0x11a));
        this.nullableDateTimePicker_0.ValueChanged += new EventHandler(this.nullableDateTimePicker_0_ValueChanged);
        this.nullableDateTimePicker_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.nullableDateTimePicker_1.set_CustomFormat("dd:MM:yyyy HH:mm");
        this.nullableDateTimePicker_1.DataBindings.Add(new Binding("Value", this.dataSetOrder_0, "tJ_Order.dateEnd", true));
        this.nullableDateTimePicker_1.set_Format(DateTimePickerFormat.Custom);
        this.nullableDateTimePicker_1.Location = new Point(0x73, 0x5d);
        this.nullableDateTimePicker_1.Name = "dateTimePickerDateEnd";
        this.nullableDateTimePicker_1.Size = new Size(0x83, 20);
        this.nullableDateTimePicker_1.TabIndex = 0x19;
        this.nullableDateTimePicker_1.set_Value(new DateTime(0x7dc, 6, 5, 9, 0x1c, 0x33, 0x3e3));
        this.nullableDateTimePicker_1.ValueChanged += new EventHandler(this.nullableDateTimePicker_1_ValueChanged);
        this.comboBox_2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        this.comboBox_2.AutoCompleteSource = AutoCompleteSource.ListItems;
        this.comboBox_2.DataBindings.Add(new Binding("SelectedValue", this.dataSetOrder_0, "tJ_Order.headworker", true));
        this.comboBox_2.DisplayMember = "FIO";
        this.comboBox_2.FormattingEnabled = true;
        this.comboBox_2.Location = new Point(0x84, 0x40);
        this.comboBox_2.Name = "cmbHeadWorker";
        this.comboBox_2.Size = new Size(0x85, 0x15);
        this.comboBox_2.TabIndex = 0x1a;
        this.comboBox_2.ValueMember = "id";
        this.comboBox_2.SelectedIndexChanged += new EventHandler(this.comboBox_2_SelectedIndexChanged);
        this.comboBox_2.TextChanged += new EventHandler(this.comboBox_2_TextChanged);
        this.comboBox_3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        this.comboBox_3.AutoCompleteSource = AutoCompleteSource.ListItems;
        this.comboBox_3.DataBindings.Add(new Binding("SelectedValue", this.dataSetOrder_0, "tJ_Order.watchWorker", true));
        this.comboBox_3.DisplayMember = "FIO";
        this.comboBox_3.FormattingEnabled = true;
        this.comboBox_3.Location = new Point(0x84, 0x79);
        this.comboBox_3.Name = "cmbWatchWorker";
        this.comboBox_3.Size = new Size(0x85, 0x15);
        this.comboBox_3.TabIndex = 0x1b;
        this.comboBox_3.ValueMember = "id";
        this.comboBox_3.SelectedIndexChanged += new EventHandler(this.comboBox_3_SelectedIndexChanged);
        this.comboBox_3.TextChanged += new EventHandler(this.comboBox_3_TextChanged);
        this.comboBox_4.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        this.comboBox_4.AutoCompleteSource = AutoCompleteSource.ListItems;
        this.comboBox_4.DataBindings.Add(new Binding("SelectedValue", this.dataSetOrder_0, "tJ_Order.makerWorker", true));
        this.comboBox_4.DisplayMember = "FIO";
        this.comboBox_4.FormattingEnabled = true;
        this.comboBox_4.Location = new Point(0x84, 0x95);
        this.comboBox_4.Name = "cmbMakerWorker";
        this.comboBox_4.Size = new Size(0x85, 0x15);
        this.comboBox_4.TabIndex = 0x1c;
        this.comboBox_4.ValueMember = "id";
        this.comboBox_4.SelectedIndexChanged += new EventHandler(this.comboBox_4_SelectedIndexChanged);
        this.comboBox_4.SelectedValueChanged += new EventHandler(this.comboBox_4_SelectedValueChanged);
        this.comboBox_4.TextChanged += new EventHandler(this.comboBox_4_TextChanged);
        this.comboBox_5.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
        this.comboBox_5.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        this.comboBox_5.AutoCompleteSource = AutoCompleteSource.ListItems;
        this.comboBox_5.DataBindings.Add(new Binding("SelectedValue", this.dataSetOrder_0, "tJ_Order.outputWorker", true));
        this.comboBox_5.DisplayMember = "FIO";
        this.comboBox_5.FormattingEnabled = true;
        this.comboBox_5.Location = new Point(0x5d, 0x195);
        this.comboBox_5.Name = "cmbOutputWorker";
        this.comboBox_5.Size = new Size(0x7c, 0x15);
        this.comboBox_5.TabIndex = 0x1d;
        this.comboBox_5.ValueMember = "id";
        this.comboBox_5.SelectedIndexChanged += new EventHandler(this.comboBox_5_SelectedIndexChanged);
        this.comboBox_5.SelectedValueChanged += new EventHandler(this.comboBox_5_SelectedValueChanged);
        this.comboBox_5.TextChanged += new EventHandler(this.comboBox_5_TextChanged);
        this.nullableDateTimePicker_2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
        this.nullableDateTimePicker_2.set_CustomFormat("dd:MM:yyyy HH:mm");
        this.nullableDateTimePicker_2.DataBindings.Add(new Binding("Value", this.dataSetOrder_0, "tJ_Order.dateOutput", true));
        this.nullableDateTimePicker_2.set_Format(DateTimePickerFormat.Custom);
        this.nullableDateTimePicker_2.Location = new Point(0x5d, 0x1af);
        this.nullableDateTimePicker_2.Name = "dateTimePickerDateOutput";
        this.nullableDateTimePicker_2.Size = new Size(0x98, 20);
        this.nullableDateTimePicker_2.TabIndex = 30;
        this.nullableDateTimePicker_2.set_Value(new DateTime(0x7dc, 6, 5, 9, 0x1c, 0x33, 0x3e3));
        this.nullableDateTimePicker_2.ValueChanged += new EventHandler(this.nullableDateTimePicker_2_ValueChanged);
        this.button_0.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
        this.button_0.Location = new Point(0x10, 0x205);
        this.button_0.Name = "buttonSave";
        this.button_0.Size = new Size(0x4b, 0x17);
        this.button_0.TabIndex = 0x1f;
        this.button_0.Text = "Сохранить";
        this.button_0.UseVisualStyleBackColor = true;
        this.button_0.Click += new EventHandler(this.button_0_Click);
        this.button_1.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
        this.button_1.Location = new Point(0x61, 0x205);
        this.button_1.Name = "buttonRegister";
        this.button_1.Size = new Size(0x72, 0x17);
        this.button_1.TabIndex = 0x20;
        this.button_1.Text = "Зарегистрировать";
        this.button_1.UseVisualStyleBackColor = true;
        this.button_1.Click += new EventHandler(this.button_1_Click);
        this.dataGridView_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.dataGridView_0.AutoGenerateColumns = false;
        style.Alignment = DataGridViewContentAlignment.MiddleLeft;
        style.BackColor = SystemColors.Control;
        style.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        style.ForeColor = SystemColors.WindowText;
        style.SelectionBackColor = SystemColors.Highlight;
        style.SelectionForeColor = SystemColors.HighlightText;
        style.WrapMode = DataGridViewTriState.True;
        this.dataGridView_0.ColumnHeadersDefaultCellStyle = style;
        this.dataGridView_0.ColumnHeadersVisible = false;
        DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_9, this.dataGridViewTextBoxColumn_10, this.dataGridViewComboBoxColumn_1, this.dataGridViewTextBoxColumn_11, this.dataGridViewComboBoxColumn_2, this.dataGridViewCheckBoxColumn_0 };
        this.dataGridView_0.Columns.AddRange(dataGridViewColumns);
        this.dataGridView_0.DataMember = "tJ_OrderBrigade";
        this.dataGridView_0.DataSource = this.dataSetOrder_0;
        style2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        style2.BackColor = SystemColors.Window;
        style2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        style2.ForeColor = SystemColors.ControlText;
        style2.SelectionBackColor = SystemColors.Highlight;
        style2.SelectionForeColor = SystemColors.HighlightText;
        style2.WrapMode = DataGridViewTriState.False;
        this.dataGridView_0.DefaultCellStyle = style2;
        this.dataGridView_0.Location = new Point(0x128, 0x24);
        this.dataGridView_0.Name = "dgvBrigade";
        style3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        style3.BackColor = SystemColors.Control;
        style3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        style3.ForeColor = SystemColors.WindowText;
        style3.SelectionBackColor = SystemColors.Highlight;
        style3.SelectionForeColor = SystemColors.HighlightText;
        style3.WrapMode = DataGridViewTriState.True;
        this.dataGridView_0.RowHeadersDefaultCellStyle = style3;
        this.dataGridView_0.RowHeadersWidth = 30;
        this.dataGridView_0.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        this.dataGridView_0.Size = new Size(310, 0x86);
        this.dataGridView_0.TabIndex = 0x21;
        this.dataGridView_0.CellEndEdit += new DataGridViewCellEventHandler(this.dataGridView_0_CellEndEdit);
        this.dataGridView_0.CellValueChanged += new DataGridViewCellEventHandler(this.dataGridView_0_CellValueChanged);
        this.dataGridView_0.DataError += new DataGridViewDataErrorEventHandler(this.dataGridView_2_DataError);
        this.dataGridView_0.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(this.dataGridView_0_EditingControlShowing);
        this.dataGridView_0.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dataGridView_0_RowsAdded);
        this.dataGridView_0.KeyDown += new KeyEventHandler(this.dataGridView_0_KeyDown);
        this.dataGridViewTextBoxColumn_9.DataPropertyName = "id";
        this.dataGridViewTextBoxColumn_9.HeaderText = "id";
        this.dataGridViewTextBoxColumn_9.Name = "idDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_9.ReadOnly = true;
        this.dataGridViewTextBoxColumn_9.Visible = false;
        this.dataGridViewTextBoxColumn_10.DataPropertyName = "idOrder";
        this.dataGridViewTextBoxColumn_10.HeaderText = "idOrder";
        this.dataGridViewTextBoxColumn_10.Name = "idOrderDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_10.Visible = false;
        this.dataGridViewComboBoxColumn_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.dataGridViewComboBoxColumn_1.DataPropertyName = "idWorker";
        this.dataGridViewComboBoxColumn_1.HeaderText = "idWorker";
        this.dataGridViewComboBoxColumn_1.Name = "brigadeWorkerColumn";
        this.dataGridViewComboBoxColumn_1.Resizable = DataGridViewTriState.True;
        this.dataGridViewComboBoxColumn_1.SortMode = DataGridViewColumnSortMode.Automatic;
        style4.BackColor = Color.LightGray;
        this.dataGridViewTextBoxColumn_11.DefaultCellStyle = style4;
        this.dataGridViewTextBoxColumn_11.HeaderText = "Гр";
        this.dataGridViewTextBoxColumn_11.Name = "GroupElectricalTxtColumn";
        this.dataGridViewTextBoxColumn_11.ReadOnly = true;
        this.dataGridViewTextBoxColumn_11.Width = 0x19;
        this.dataGridViewComboBoxColumn_2.DataPropertyName = "idJobTitle";
        this.dataGridViewComboBoxColumn_2.HeaderText = "должн.";
        this.dataGridViewComboBoxColumn_2.Name = "idJobTitleDgvColumn";
        this.dataGridViewCheckBoxColumn_0.DataPropertyName = "isUnderstudy";
        style5.Alignment = DataGridViewContentAlignment.MiddleCenter;
        style5.BackColor = Color.LightGray;
        style5.NullValue = false;
        this.dataGridViewCheckBoxColumn_0.DefaultCellStyle = style5;
        this.dataGridViewCheckBoxColumn_0.HeaderText = "дублер";
        this.dataGridViewCheckBoxColumn_0.Name = "isUnderstudyDgvColumn";
        this.dataGridViewCheckBoxColumn_0.Width = 40;
        this.label_12.AutoSize = true;
        this.label_12.Location = new Point(0x93, 0xb1);
        this.label_12.Name = "label13";
        this.label_12.Size = new Size(0xb7, 13);
        this.label_12.TabIndex = 0x22;
        this.label_12.Text = "Меры по подготовке рабочих мест";
        this.dataGridView_1.AllowDrop = true;
        this.dataGridView_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
        this.dataGridView_1.AutoGenerateColumns = false;
        this.dataGridView_1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
        style6.Alignment = DataGridViewContentAlignment.MiddleLeft;
        style6.BackColor = SystemColors.Control;
        style6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        style6.ForeColor = SystemColors.WindowText;
        style6.SelectionBackColor = SystemColors.Highlight;
        style6.SelectionForeColor = SystemColors.HighlightText;
        style6.WrapMode = DataGridViewTriState.True;
        this.dataGridView_1.ColumnHeadersDefaultCellStyle = style6;
        this.dataGridView_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DataGridViewColumn[] columnArray2 = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_4, this.dataGridViewTextBoxColumn_5, this.dataGridViewTextBoxColumn_6, this.dataGridViewTextBoxColumn_7, this.dataGridViewTextBoxColumn_8 };
        this.dataGridView_1.Columns.AddRange(columnArray2);
        this.dataGridView_1.DataMember = "tJ_OrderInstruction";
        this.dataGridView_1.DataSource = this.dataSetOrder_0;
        style7.Alignment = DataGridViewContentAlignment.MiddleLeft;
        style7.BackColor = SystemColors.Window;
        style7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        style7.ForeColor = SystemColors.ControlText;
        style7.SelectionBackColor = SystemColors.Highlight;
        style7.SelectionForeColor = SystemColors.HighlightText;
        style7.WrapMode = DataGridViewTriState.False;
        this.dataGridView_1.DefaultCellStyle = style7;
        this.dataGridView_1.Location = new Point(9, 0xc1);
        this.dataGridView_1.Name = "dgvInstruction";
        style8.Alignment = DataGridViewContentAlignment.MiddleLeft;
        style8.BackColor = SystemColors.Control;
        style8.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        style8.ForeColor = SystemColors.WindowText;
        style8.SelectionBackColor = SystemColors.Highlight;
        style8.SelectionForeColor = SystemColors.HighlightText;
        style8.WrapMode = DataGridViewTriState.True;
        this.dataGridView_1.RowHeadersDefaultCellStyle = style8;
        style9.WrapMode = DataGridViewTriState.True;
        this.dataGridView_1.RowsDefaultCellStyle = style9;
        this.dataGridView_1.RowTemplate.Height = 0x2c;
        this.dataGridView_1.RowTemplate.Resizable = DataGridViewTriState.True;
        this.dataGridView_1.Size = new Size(0x255, 0xa9);
        this.dataGridView_1.TabIndex = 0x23;
        this.dataGridView_1.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView_1_CellDoubleClick);
        this.dataGridView_1.CellValueChanged += new DataGridViewCellEventHandler(this.dataGridView_1_CellValueChanged);
        this.dataGridView_1.DataError += new DataGridViewDataErrorEventHandler(this.dataGridView_1_DataError);
        this.dataGridViewTextBoxColumn_4.DataPropertyName = "id";
        this.dataGridViewTextBoxColumn_4.HeaderText = "id";
        this.dataGridViewTextBoxColumn_4.Name = "idDataGridViewTextBoxColumn1";
        this.dataGridViewTextBoxColumn_4.ReadOnly = true;
        this.dataGridViewTextBoxColumn_4.Visible = false;
        this.dataGridViewTextBoxColumn_5.DataPropertyName = "idOrder";
        this.dataGridViewTextBoxColumn_5.HeaderText = "idOrder";
        this.dataGridViewTextBoxColumn_5.Name = "idOrderDgvColumnInstruction";
        this.dataGridViewTextBoxColumn_5.Visible = false;
        this.dataGridViewTextBoxColumn_6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.dataGridViewTextBoxColumn_6.DataPropertyName = "NameObj";
        this.dataGridViewTextBoxColumn_6.FillWeight = 35f;
        this.dataGridViewTextBoxColumn_6.HeaderText = "Наименование электроустановок";
        this.dataGridViewTextBoxColumn_6.Name = "nameObjDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_6.SortMode = DataGridViewColumnSortMode.NotSortable;
        this.dataGridViewTextBoxColumn_7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.dataGridViewTextBoxColumn_7.DataPropertyName = "Instruction";
        this.dataGridViewTextBoxColumn_7.FillWeight = 65f;
        this.dataGridViewTextBoxColumn_7.HeaderText = "Что должно быть отключено и где заземлено";
        this.dataGridViewTextBoxColumn_7.Name = "instructionDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_7.SortMode = DataGridViewColumnSortMode.NotSortable;
        this.dataGridViewTextBoxColumn_8.DataPropertyName = "rec_num";
        this.dataGridViewTextBoxColumn_8.HeaderText = "rec_num";
        this.dataGridViewTextBoxColumn_8.Name = "recnumDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_8.Visible = false;
        this.dataGridView_2.AllowUserToAddRows = false;
        this.dataGridView_2.AllowUserToDeleteRows = false;
        this.dataGridView_2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
        this.dataGridView_2.AutoGenerateColumns = false;
        this.dataGridView_2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DataGridViewColumn[] columnArray3 = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_0, this.dataGridViewTextBoxColumn_1, this.dataGridViewComboBoxColumn_0, this.dataGridViewTextBoxColumn_2, this.dataGridViewTextBoxColumn_3 };
        this.dataGridView_2.Columns.AddRange(columnArray3);
        this.dataGridView_2.DataMember = "tJ_OrderResolution";
        this.dataGridView_2.DataSource = this.dataSetOrder_0;
        this.dataGridView_2.Location = new Point(9, 0x17d);
        this.dataGridView_2.Name = "dgvResolution";
        this.dataGridView_2.ReadOnly = true;
        this.dataGridView_2.RowHeadersVisible = false;
        this.dataGridView_2.RowTemplate.Resizable = DataGridViewTriState.False;
        this.dataGridView_2.Size = new Size(0x1a5, 0x75);
        this.dataGridView_2.TabIndex = 0x24;
        this.dataGridView_2.DataError += new DataGridViewDataErrorEventHandler(this.dataGridView_2_DataError);
        this.dataGridViewTextBoxColumn_0.DataPropertyName = "id";
        this.dataGridViewTextBoxColumn_0.HeaderText = "id";
        this.dataGridViewTextBoxColumn_0.Name = "idDataGridViewTextBoxColumn2";
        this.dataGridViewTextBoxColumn_0.ReadOnly = true;
        this.dataGridViewTextBoxColumn_0.Visible = false;
        this.dataGridViewTextBoxColumn_1.DataPropertyName = "idOrder";
        this.dataGridViewTextBoxColumn_1.HeaderText = "idOrder";
        this.dataGridViewTextBoxColumn_1.Name = "idOrderDataGridViewTextBoxColumn1";
        this.dataGridViewTextBoxColumn_1.ReadOnly = true;
        this.dataGridViewTextBoxColumn_1.Visible = false;
        this.dataGridViewComboBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.dataGridViewComboBoxColumn_0.DataPropertyName = "idWorker";
        this.dataGridViewComboBoxColumn_0.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
        this.dataGridViewComboBoxColumn_0.FillWeight = 40f;
        this.dataGridViewComboBoxColumn_0.FlatStyle = FlatStyle.System;
        this.dataGridViewComboBoxColumn_0.HeaderText = "Выдал";
        this.dataGridViewComboBoxColumn_0.Name = "workerResolutionColumn";
        this.dataGridViewComboBoxColumn_0.ReadOnly = true;
        this.dataGridViewComboBoxColumn_0.Resizable = DataGridViewTriState.True;
        this.dataGridViewTextBoxColumn_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.dataGridViewTextBoxColumn_2.DataPropertyName = "DateBegin";
        this.dataGridViewTextBoxColumn_2.FillWeight = 30f;
        this.dataGridViewTextBoxColumn_2.HeaderText = "Начало работ";
        this.dataGridViewTextBoxColumn_2.Name = "dateBeginDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_2.ReadOnly = true;
        this.dataGridViewTextBoxColumn_2.SortMode = DataGridViewColumnSortMode.NotSortable;
        this.dataGridViewTextBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.dataGridViewTextBoxColumn_3.DataPropertyName = "DateEnd";
        this.dataGridViewTextBoxColumn_3.FillWeight = 30f;
        this.dataGridViewTextBoxColumn_3.HeaderText = "Работа закончена";
        this.dataGridViewTextBoxColumn_3.Name = "dateEndDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_3.ReadOnly = true;
        this.dataGridViewTextBoxColumn_3.SortMode = DataGridViewColumnSortMode.NotSortable;
        this.comboBox_6.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
        this.comboBox_6.Enabled = false;
        this.comboBox_6.FormattingEnabled = true;
        this.comboBox_6.Location = new Point(0x1b4, 0x17d);
        this.comboBox_6.Name = "cmbWorkerResolution";
        this.comboBox_6.Size = new Size(170, 0x15);
        this.comboBox_6.TabIndex = 0x25;
        this.comboBox_6.SelectedIndexChanged += new EventHandler(this.comboBox_6_SelectedIndexChanged);
        this.nullableDateTimePicker_3.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
        this.nullableDateTimePicker_3.set_CustomFormat("dd:MM:yyyy HH:mm");
        this.nullableDateTimePicker_3.Enabled = false;
        this.nullableDateTimePicker_3.set_Format(DateTimePickerFormat.Custom);
        this.nullableDateTimePicker_3.Location = new Point(0x1b4, 0x198);
        this.nullableDateTimePicker_3.Name = "dateTimePickerResolution";
        this.nullableDateTimePicker_3.Size = new Size(170, 20);
        this.nullableDateTimePicker_3.TabIndex = 0x26;
        this.nullableDateTimePicker_3.set_Value(new DateTime(0x7dc, 6, 5, 9, 0x1c, 0x33, 0x3e3));
        this.button_2.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
        this.button_2.Enabled = false;
        this.button_2.Location = new Point(0x1d8, 0x1b2);
        this.button_2.Name = "buttonResolution";
        this.button_2.Size = new Size(0x86, 0x17);
        this.button_2.TabIndex = 0x27;
        this.button_2.Text = "Выдать разрешение";
        this.button_2.UseVisualStyleBackColor = true;
        this.button_2.Click += new EventHandler(this.button_2_Click);
        this.button_3.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
        this.button_3.Enabled = false;
        this.button_3.Location = new Point(0x1d8, 0x205);
        this.button_3.Name = "buttonCloseOrder";
        this.button_3.Size = new Size(0x86, 0x17);
        this.button_3.TabIndex = 0x2a;
        this.button_3.Text = "Закрыть наряд";
        this.button_3.UseVisualStyleBackColor = true;
        this.button_3.Click += new EventHandler(this.button_3_Click);
        this.nullableDateTimePicker_4.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
        this.nullableDateTimePicker_4.set_CustomFormat("dd:MM:yyyy HH:mm");
        this.nullableDateTimePicker_4.Enabled = false;
        this.nullableDateTimePicker_4.set_Format(DateTimePickerFormat.Custom);
        this.nullableDateTimePicker_4.Location = new Point(260, 520);
        this.nullableDateTimePicker_4.Name = "dateTimePickerClose";
        this.nullableDateTimePicker_4.Size = new Size(170, 20);
        this.nullableDateTimePicker_4.TabIndex = 0x29;
        this.nullableDateTimePicker_4.set_Value(new DateTime(0x7dc, 6, 5, 9, 0x1c, 0x33, 0x3e3));
        this.comboBox_7.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
        this.comboBox_7.Enabled = false;
        this.comboBox_7.FormattingEnabled = true;
        this.comboBox_7.Location = new Point(0x54, 0x207);
        this.comboBox_7.Name = "cmbCloseWorker";
        this.comboBox_7.Size = new Size(170, 0x15);
        this.comboBox_7.TabIndex = 40;
        this.comboBox_7.SelectedIndexChanged += new EventHandler(this.comboBox_7_SelectedIndexChanged);
        this.toolStrip_0.GripStyle = ToolStripGripStyle.Hidden;
        ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripButton_0, this.toolStripButton_4 };
        this.toolStrip_0.Items.AddRange(toolStripItems);
        this.toolStrip_0.Location = new Point(0, 0);
        this.toolStrip_0.Name = "toolStripReport";
        this.toolStrip_0.Size = new Size(0xfc, 0x19);
        this.toolStrip_0.TabIndex = 0x2b;
        this.toolStrip_0.Text = "toolStrip1";
        this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_0.Enabled = false;
        this.toolStripButton_0.Image = Resources.microsoftoffice2007excel_7581;
        this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
        this.toolStripButton_0.Name = "toolBtnReport";
        this.toolStripButton_0.Size = new Size(0x17, 0x16);
        this.toolStripButton_0.Text = "Печать наряда";
        this.toolStripButton_0.Click += new EventHandler(this.toolStripButton_0_Click);
        this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_4.Enabled = false;
        this.toolStripButton_4.Image = Resources.CopyBuffer;
        this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
        this.toolStripButton_4.Name = "toolBtnCopyOrder";
        this.toolStripButton_4.Size = new Size(0x17, 0x16);
        this.toolStripButton_4.Text = "Копировать наряд";
        this.toolStripButton_4.Click += new EventHandler(this.toolStripButton_4_Click);
        this.splitContainer_0.Dock = DockStyle.Fill;
        this.splitContainer_0.FixedPanel = FixedPanel.Panel1;
        this.splitContainer_0.Location = new Point(0, 0);
        this.splitContainer_0.Name = "splitContainer";
        this.splitContainer_0.Panel1.Controls.Add(this.label_15);
        this.splitContainer_0.Panel1.Controls.Add(this.panel_0);
        this.splitContainer_0.Panel1.Controls.Add(this.textBox_2);
        this.splitContainer_0.Panel1.Controls.Add(this.toolStrip_1);
        this.splitContainer_0.Panel1.Controls.Add(this.listBox_0);
        this.splitContainer_0.Panel1.Controls.Add(this.button_0);
        this.splitContainer_0.Panel1.Controls.Add(this.toolStrip_0);
        this.splitContainer_0.Panel1.Controls.Add(this.label_0);
        this.splitContainer_0.Panel1.Controls.Add(this.textBox_0);
        this.splitContainer_0.Panel1.Controls.Add(this.label_1);
        this.splitContainer_0.Panel1.Controls.Add(this.label_2);
        this.splitContainer_0.Panel1.Controls.Add(this.label_3);
        this.splitContainer_0.Panel1.Controls.Add(this.richTextBox_0);
        this.splitContainer_0.Panel1.Controls.Add(this.label_10);
        this.splitContainer_0.Panel1.Controls.Add(this.richTextBox_1);
        this.splitContainer_0.Panel1.Controls.Add(this.label_11);
        this.splitContainer_0.Panel1.Controls.Add(this.nullableDateTimePicker_0);
        this.splitContainer_0.Panel1.Controls.Add(this.nullableDateTimePicker_1);
        this.splitContainer_0.Panel1.Controls.Add(this.button_1);
        this.splitContainer_0.Panel1.Controls.Add(this.comboBox_5);
        this.splitContainer_0.Panel1.Controls.Add(this.nullableDateTimePicker_2);
        this.splitContainer_0.Panel2.Controls.Add(this.label_17);
        this.splitContainer_0.Panel2.Controls.Add(this.comboBoxReadOnly_0);
        this.splitContainer_0.Panel2.Controls.Add(this.label_16);
        this.splitContainer_0.Panel2.Controls.Add(this.textBox_3);
        this.splitContainer_0.Panel2.Controls.Add(this.textBox_4);
        this.splitContainer_0.Panel2.Controls.Add(this.textBox_5);
        this.splitContainer_0.Panel2.Controls.Add(this.textBox_1);
        this.splitContainer_0.Panel2.Controls.Add(this.label_13);
        this.splitContainer_0.Panel2.Controls.Add(this.dataGridView_0);
        this.splitContainer_0.Panel2.Controls.Add(this.button_3);
        this.splitContainer_0.Panel2.Controls.Add(this.label_4);
        this.splitContainer_0.Panel2.Controls.Add(this.nullableDateTimePicker_4);
        this.splitContainer_0.Panel2.Controls.Add(this.comboBox_0);
        this.splitContainer_0.Panel2.Controls.Add(this.comboBox_7);
        this.splitContainer_0.Panel2.Controls.Add(this.label_5);
        this.splitContainer_0.Panel2.Controls.Add(this.button_2);
        this.splitContainer_0.Panel2.Controls.Add(this.label_6);
        this.splitContainer_0.Panel2.Controls.Add(this.nullableDateTimePicker_3);
        this.splitContainer_0.Panel2.Controls.Add(this.label_7);
        this.splitContainer_0.Panel2.Controls.Add(this.comboBox_6);
        this.splitContainer_0.Panel2.Controls.Add(this.label_8);
        this.splitContainer_0.Panel2.Controls.Add(this.dataGridView_2);
        this.splitContainer_0.Panel2.Controls.Add(this.label_9);
        this.splitContainer_0.Panel2.Controls.Add(this.dataGridView_1);
        this.splitContainer_0.Panel2.Controls.Add(this.comboBox_1);
        this.splitContainer_0.Panel2.Controls.Add(this.label_12);
        this.splitContainer_0.Panel2.Controls.Add(this.comboBox_2);
        this.splitContainer_0.Panel2.Controls.Add(this.comboBox_3);
        this.splitContainer_0.Panel2.Controls.Add(this.comboBox_4);
        this.splitContainer_0.Size = new Size(0x36c, 0x21f);
        this.splitContainer_0.SplitterDistance = 0xfc;
        this.splitContainer_0.TabIndex = 0x2c;
        this.label_15.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
        this.label_15.AutoSize = true;
        this.label_15.Location = new Point(13, 0x1b5);
        this.label_15.Name = "labelOutputDate";
        this.label_15.Size = new Size(0x4d, 13);
        this.label_15.TabIndex = 50;
        this.label_15.Text = "Дата и время";
        this.panel_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
        this.panel_0.BackColor = SystemColors.ControlDark;
        this.panel_0.Controls.Add(this.button_4);
        this.panel_0.Controls.Add(this.nullableDateTimePicker_5);
        this.panel_0.Controls.Add(this.multiColumnComboBox_0);
        this.panel_0.Controls.Add(this.label_14);
        this.panel_0.Enabled = false;
        this.panel_0.Location = new Point(13, 0x1c9);
        this.panel_0.Name = "panelExtension";
        this.panel_0.Size = new Size(0xe9, 0x36);
        this.panel_0.TabIndex = 0x31;
        this.button_4.Location = new Point(6, 0x1b);
        this.button_4.Name = "buttonExtension";
        this.button_4.Size = new Size(0x4b, 0x17);
        this.button_4.TabIndex = 0x20;
        this.button_4.Text = "Продлить";
        this.button_4.UseVisualStyleBackColor = true;
        this.button_4.Click += new EventHandler(this.button_4_Click);
        this.nullableDateTimePicker_5.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
        this.nullableDateTimePicker_5.set_CustomFormat("dd:MM:yyyy HH:mm");
        this.nullableDateTimePicker_5.DataBindings.Add(new Binding("Value", this.dataSetOrder_0, "tJ_Order.dateEndExt", true));
        this.nullableDateTimePicker_5.set_Format(DateTimePickerFormat.Custom);
        this.nullableDateTimePicker_5.Location = new Point(0x5d, 30);
        this.nullableDateTimePicker_5.Name = "dateTimePickerDateEndExt";
        this.nullableDateTimePicker_5.Size = new Size(0x89, 20);
        this.nullableDateTimePicker_5.TabIndex = 0x1f;
        this.nullableDateTimePicker_5.set_Value(new DateTime(0x7dc, 6, 5, 9, 0x1c, 0x33, 0x3e3));
        this.multiColumnComboBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left;
        this.multiColumnComboBox_0.set_AutoComplete(false);
        this.multiColumnComboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        this.multiColumnComboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
        this.multiColumnComboBox_0.set_AutoDropdown(false);
        this.multiColumnComboBox_0.set_BackColorEven(Color.White);
        this.multiColumnComboBox_0.set_BackColorOdd(Color.White);
        this.multiColumnComboBox_0.set_ColumnNames("");
        this.multiColumnComboBox_0.set_ColumnWidthDefault(0x4b);
        this.multiColumnComboBox_0.set_ColumnWidths("0;120;0;30");
        this.multiColumnComboBox_0.DataBindings.Add(new Binding("SelectedValue", this.dataSetOrder_0, "tJ_Order.extWorker", true));
        this.multiColumnComboBox_0.DisplayMember = "id";
        this.multiColumnComboBox_0.set_DrawMode(DrawMode.OwnerDrawVariable);
        this.multiColumnComboBox_0.FormattingEnabled = true;
        this.multiColumnComboBox_0.set_LinkedColumnIndex(0);
        this.multiColumnComboBox_0.set_LinkedTextBox(null);
        this.multiColumnComboBox_0.Location = new Point(0x5d, 3);
        this.multiColumnComboBox_0.Name = "cmbExtWorker";
        this.multiColumnComboBox_0.Size = new Size(0x89, 0x15);
        this.multiColumnComboBox_0.TabIndex = 30;
        this.multiColumnComboBox_0.ValueMember = "id";
        this.label_14.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
        this.label_14.AutoSize = true;
        this.label_14.Location = new Point(3, 1);
        this.label_14.Name = "label3";
        this.label_14.Size = new Size(0x54, 13);
        this.label_14.TabIndex = 0x12;
        this.label_14.Text = "Наряд продлил";
        this.textBox_2.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
        this.textBox_2.Location = new Point(0xda, 0x195);
        this.textBox_2.Name = "txtOutputWorker";
        this.textBox_2.ReadOnly = true;
        this.textBox_2.Size = new Size(0x1b, 20);
        this.textBox_2.TabIndex = 0x30;
        this.toolStrip_1.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
        this.toolStrip_1.Dock = DockStyle.None;
        this.toolStrip_1.GripStyle = ToolStripGripStyle.Hidden;
        ToolStripItem[] itemArray2 = new ToolStripItem[] { this.toolStripButton_1, this.toolStripButton_2, this.toolStripButton_3 };
        this.toolStrip_1.Items.AddRange(itemArray2);
        this.toolStrip_1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
        this.toolStrip_1.Location = new Point(0x10, 0x14b);
        this.toolStrip_1.Name = "toolStripScheme";
        this.toolStrip_1.Size = new Size(0x18, 0x47);
        this.toolStrip_1.TabIndex = 0x2e;
        this.toolStrip_1.Text = "toolStrip1";
        this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_1.Image = Resources.ElementAdd;
        this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
        this.toolStripButton_1.Name = "toolBtnLinkSchmObj";
        this.toolStripButton_1.Size = new Size(0x16, 20);
        this.toolStripButton_1.Text = "Привязать к схеме";
        this.toolStripButton_1.Click += new EventHandler(this.toolStripButton_1_Click);
        this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_2.Image = Resources.ElementDel;
        this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
        this.toolStripButton_2.Name = "toolBtnDelSchmObj";
        this.toolStripButton_2.Size = new Size(0x16, 20);
        this.toolStripButton_2.Text = "Удалить";
        this.toolStripButton_2.Click += new EventHandler(this.toolStripButton_2_Click);
        this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_3.Enabled = false;
        this.toolStripButton_3.Image = Resources.ElementInformation;
        this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
        this.toolStripButton_3.Name = "toolBtnViewSChmObj";
        this.toolStripButton_3.Size = new Size(0x16, 20);
        this.toolStripButton_3.Text = "Показать на схеме";
        this.toolStripButton_3.Click += new EventHandler(this.toolStripButton_3_Click);
        this.listBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
        this.listBox_0.FormattingEnabled = true;
        this.listBox_0.Location = new Point(0x2a, 0x14d);
        this.listBox_0.Name = "listBoxLinkScmObjects";
        this.listBox_0.SelectionMode = SelectionMode.MultiSimple;
        this.listBox_0.Size = new Size(0xcb, 0x45);
        this.listBox_0.Sorted = true;
        this.listBox_0.TabIndex = 0x2d;
        this.label_17.AutoSize = true;
        this.label_17.Location = new Point(0x27, 0x2b);
        this.label_17.Name = "labelDivision";
        this.label_17.Size = new Size(0x57, 13);
        this.label_17.TabIndex = 50;
        this.label_17.Text = "Подразделение";
        this.comboBoxReadOnly_0.BackColor = SystemColors.Control;
        this.comboBoxReadOnly_0.DataBindings.Add(new Binding("SelectedValue", this.dataSetOrder_0, "tJ_Order.idDivision", true, DataSourceUpdateMode.OnPropertyChanged));
        this.comboBoxReadOnly_0.ForeColor = SystemColors.WindowText;
        this.comboBoxReadOnly_0.FormattingEnabled = true;
        this.comboBoxReadOnly_0.Location = new Point(0x84, 40);
        this.comboBoxReadOnly_0.Name = "cmbDivision";
        this.comboBoxReadOnly_0.set_ReadOnly(true);
        this.comboBoxReadOnly_0.set_ReadOnlyBackColor(SystemColors.Window);
        this.comboBoxReadOnly_0.set_ReadOnlyForeColor(SystemColors.WindowText);
        this.comboBoxReadOnly_0.Size = new Size(0x9e, 0x15);
        this.comboBoxReadOnly_0.TabIndex = 0x31;
        this.label_16.Anchor = AnchorStyles.Right | AnchorStyles.Top;
        this.label_16.AutoSize = true;
        this.label_16.Location = new Point(0x231, 0x11);
        this.label_16.Name = "label4";
        this.label_16.Size = new Size(0x2d, 13);
        this.label_16.TabIndex = 0x30;
        this.label_16.Text = "Дублер";
        this.textBox_3.Location = new Point(0x107, 0x95);
        this.textBox_3.Name = "txtMakerWorker";
        this.textBox_3.ReadOnly = true;
        this.textBox_3.Size = new Size(0x1b, 20);
        this.textBox_3.TabIndex = 0x2f;
        this.textBox_4.Location = new Point(0x107, 0x79);
        this.textBox_4.Name = "txtWatchWorker";
        this.textBox_4.ReadOnly = true;
        this.textBox_4.Size = new Size(0x1b, 20);
        this.textBox_4.TabIndex = 0x2e;
        this.textBox_5.Location = new Point(0x107, 0x5c);
        this.textBox_5.Name = "txtAcceptWorker";
        this.textBox_5.ReadOnly = true;
        this.textBox_5.Size = new Size(0x1b, 20);
        this.textBox_5.TabIndex = 0x2d;
        this.textBox_1.Location = new Point(0x107, 0x40);
        this.textBox_1.Name = "txtHeadWorker";
        this.textBox_1.ReadOnly = true;
        this.textBox_1.Size = new Size(0x1b, 20);
        this.textBox_1.TabIndex = 0x2c;
        this.label_13.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
        this.label_13.AutoSize = true;
        this.label_13.Location = new Point(8, 0x16d);
        this.label_13.Name = "label2";
        this.label_13.Size = new Size(0x182, 13);
        this.label_13.TabIndex = 0x2b;
        this.label_13.Text = "Разрешение на подготовку рабочих мест и на допуск к выполнению работ";
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(0x36c, 0x21f);
        base.Controls.Add(this.splitContainer_0);
        base.KeyPreview = true;
        base.Name = "FormJournalOrderAddEdit";
        this.Text = "FormJournalOrderAddEdit";
        base.FormClosing += new FormClosingEventHandler(this.Form19_FormClosing);
        base.FormClosed += new FormClosedEventHandler(this.Form19_FormClosed);
        base.Load += new EventHandler(this.Form19_Load);
        base.KeyDown += new KeyEventHandler(this.Form19_KeyDown);
        this.dataSetOrder_0.EndInit();
        ((ISupportInitialize) this.dataGridView_0).EndInit();
        ((ISupportInitialize) this.dataGridView_1).EndInit();
        ((ISupportInitialize) this.dataGridView_2).EndInit();
        this.toolStrip_0.ResumeLayout(false);
        this.toolStrip_0.PerformLayout();
        this.splitContainer_0.Panel1.ResumeLayout(false);
        this.splitContainer_0.Panel1.PerformLayout();
        this.splitContainer_0.Panel2.ResumeLayout(false);
        this.splitContainer_0.Panel2.PerformLayout();
        this.splitContainer_0.ResumeLayout(false);
        this.panel_0.ResumeLayout(false);
        this.panel_0.PerformLayout();
        this.toolStrip_1.ResumeLayout(false);
        this.toolStrip_1.PerformLayout();
        base.ResumeLayout(false);
    }

    private void method_3()
    {
        if (!this.method_0().HasValue && (this.method_2() > 0))
        {
            DataTable table = new DataTable("tJ_Order");
            table.Columns.Add("idDivision", typeof(int));
            base.SelectSqlData(table, true, " where id = " + this.method_2().ToString(), false);
            if ((table.Rows.Count > 0) && (table.Rows[0]["idDivision"] != DBNull.Value))
            {
                this.method_1(new int?(Convert.ToInt32(table.Rows[0]["idDivision"])));
            }
        }
        if (this.method_0().HasValue)
        {
            base.SelectSqlData(this.dataSetOrder_0.tR_Classifier, true, string.Format(" where ParentId = {0} and isGRoup = 0 and deleted = 0 ", this.method_0().Value), false);
        }
        if (this.dataSetOrder_0.tR_Classifier.Rows.Count == 0)
        {
            base.SelectSqlData(this.dataSetOrder_0.tR_Classifier, true, " where parentkey = ';NetworkAreas;' and isgroup = 0 and deleted = 0", false);
        }
    }

    private void method_4()
    {
        DataTable table = new DataTable("tR_Classifier");
        table.Columns.Add("id", typeof(int));
        table.Columns.Add("name", typeof(string));
        table.Columns.Add("value", typeof(decimal));
        base.SelectSqlData(table, true, " where ((ParentKey = ';Other;DivisionOrder;' and isGRoup = 0)\r\n                                            or (ParentKey like ';Other;DivisionOrder;%;' and isGRoup = 1)) and deleted = 0 ", false);
        if (table.Rows.Count == 0)
        {
            this.label_17.Visible = false;
            this.comboBoxReadOnly_0.set_Visible(false);
        }
        else
        {
            this.comboBoxReadOnly_0.DisplayMember = "name";
            this.comboBoxReadOnly_0.ValueMember = "id";
            this.comboBoxReadOnly_0.DataSource = table;
        }
    }

    private DataTable method_5()
    {
        Type dataType = Type.GetType("System.Int32");
        DataTable table = new DataTable("vWorkerGroup");
        DataColumn column = new DataColumn("id", dataType);
        table.Columns.Add(column);
        DataColumn column2 = new DataColumn("fio", Type.GetType("System.String"));
        table.Columns.Add(column2);
        DataColumn column3 = new DataColumn("GroupElectrical", dataType);
        table.Columns.Add(column3);
        table.PrimaryKey = new DataColumn[] { column };
        DataColumn column4 = new DataColumn("GroupRoman", Type.GetType("System.String")) {
            Expression = "IIF(groupElectrical = 1, 'I', IIF(groupElectrical = 2, 'II', IIF(groupelectrical=3, 'III', IIF(groupelectrical = 4, 'IV', iif(groupelectrical = 5, 'V', '')))))"
        };
        table.Columns.Add(column4);
        DataColumn column5 = new DataColumn("fioGroup", Type.GetType("System.String")) {
            Expression = "fio + ' (' + GroupRoman + ')'"
        };
        table.Columns.Add(column5);
        return table;
    }

    private void method_6()
    {
        DataTable table = this.method_5();
        base.SelectSqlData(table, true, " where ParentKey in (';GroupWorker;ITR;')  and dateend is null group by id, fio, groupelectrical order by fio ", false);
        this.comboBox_2.DataSource = table;
        this.comboBox_2.DisplayMember = "FIOGROUP";
        this.comboBox_2.ValueMember = "ID";
        DataTable table2 = this.method_5();
        base.SelectSqlData(table2, true, " where ParentKey in (';GroupWorker;ITR;', ';GroupWorker;Workers;', ';GroupWorker;Dispatchers;')  and dateend is null group by id, fio, groupelectrical order by fio ", false);
        this.comboBox_1.DataSource = table2;
        this.comboBox_1.DisplayMember = "FIOGROUP";
        this.comboBox_1.ValueMember = "ID";
        DataTable table3 = this.method_5();
        base.SelectSqlData(table3, true, " where ParentKey in (';GroupWorker;ITR;', ';GroupWorker;Workers;')  and dateend is null group by id, fio, groupelectrical order by fio ", false);
        this.comboBox_3.DataSource = table3;
        this.comboBox_3.DisplayMember = "FIOGROUP";
        this.comboBox_3.ValueMember = "ID";
        DataTable table4 = this.method_5();
        base.SelectSqlData(table4, true, " where ParentKey in (';GroupWorker;ITR;', ';GroupWorker;Workers;')  and dateend is null group by id, fio, groupelectrical order by fio ", false);
        this.comboBox_4.DataSource = table4;
        this.comboBox_4.DisplayMember = "FIOGROUP";
        this.comboBox_4.ValueMember = "ID";
        DataTable table5 = this.method_5();
        base.SelectSqlData(table5, true, " where ParentKey in (';GroupWorker;ITR;', ';GroupWorker;Dispatchers;')  and dateend is null group by id, fio, groupelectrical order by fio ", false);
        this.comboBox_5.DataSource = table5;
        this.comboBox_5.DisplayMember = "FIOGROUP";
        this.comboBox_5.ValueMember = "ID";
        DataTable table6 = this.method_5();
        base.SelectSqlData(table6, true, " where ParentKey in (';GroupWorker;ITR;', ';GroupWorker;Dispatchers;')  and dateend is null group by id, fio, groupelectrical order by fio ", false);
        this.multiColumnComboBox_0.DataSource = table6;
        this.multiColumnComboBox_0.DisplayMember = "FIOGROUP";
        this.multiColumnComboBox_0.ValueMember = "ID";
        DataTable table7 = this.method_5();
        BindingSource source = new BindingSource {
            DataSource = table7
        };
        base.SelectSqlData(table7, true, " where ParentKey in (';GroupWorker;Workers;')  and dateend is null group by id, fio, groupelectrical order by fio ", false);
        this.dataGridViewComboBoxColumn_1.DataSource = source;
        this.dataGridViewComboBoxColumn_1.DisplayMember = "FIOGROUP";
        this.dataGridViewComboBoxColumn_1.ValueMember = "ID";
        this.method_7();
    }

    private void method_7()
    {
        int? nullable = null;
        if (this.int_0 > 0)
        {
            DataTable table3 = new DataTable("tJ_Order");
            table3.Columns.Add("idDivision", typeof(int));
            base.SelectSqlData(table3, true, " where id = " + this.int_0.ToString(), false);
            if ((table3.Rows.Count > 0) && (table3.Rows[0]["idDivision"] != DBNull.Value))
            {
                nullable = new int?(Convert.ToInt32(table3.Rows[0]["idDivision"]));
            }
        }
        if (!nullable.HasValue)
        {
            nullable = this.method_0();
        }
        decimal? nullable2 = null;
        if (nullable.HasValue)
        {
            DataTable table4 = new DataTable("tR_Classifier");
            table4.Columns.Add("Value", typeof(decimal));
            base.SelectSqlData(table4, true, "where id = " + nullable.ToString(), false);
            if ((table4.Rows.Count > 0) && (table4.Rows[0]["Value"] != DBNull.Value))
            {
                nullable2 = new decimal?(Convert.ToDecimal(table4.Rows[0]["Value"]));
            }
        }
        DataTable table = this.method_5();
        decimal? nullable3 = nullable2;
        decimal num = 2;
        if ((nullable3.GetValueOrDefault() == num) ? nullable3.HasValue : false)
        {
            base.SelectSqlData(table, true, " where ParentKey in (';GroupWorker;DispatchersSESNO;')  and dateend is null group by id, fio, groupelectrical order by fio ", false);
        }
        else
        {
            base.SelectSqlData(table, true, " where ParentKey in (';GroupWorker;Dispatchers;')  and dateend is null group by id, fio, groupelectrical order by fio ", false);
        }
        this.dataGridViewComboBoxColumn_0.DataSource = table;
        this.dataGridViewComboBoxColumn_0.DisplayMember = "FIOGROUP";
        this.dataGridViewComboBoxColumn_0.ValueMember = "ID";
        this.comboBox_6.DataSource = table;
        this.comboBox_6.DisplayMember = "FIOGROUP";
        this.comboBox_6.ValueMember = "ID";
        DataTable table2 = this.method_5();
        nullable3 = nullable2;
        num = 2;
        if ((nullable3.GetValueOrDefault() == num) ? nullable3.HasValue : false)
        {
            base.SelectSqlData(table2, true, " where ParentKey in (';GroupWorker;DispatchersSESNO;')  and dateend is null group by id, fio, groupelectrical order by fio ", false);
        }
        else
        {
            base.SelectSqlData(table2, true, " where ParentKey in (';GroupWorker;Dispatchers;')  and dateend is null group by id, fio, groupelectrical order by fio ", false);
        }
        this.comboBox_7.DataSource = table2;
        this.comboBox_7.DisplayMember = "FIOGROUP";
        this.comboBox_7.ValueMember = "ID";
    }

    private void method_8()
    {
        this.comboBox_6.SelectedIndex = -1;
        if (this.int_0 == -1)
        {
            this.nullableDateTimePicker_0.set_Value(null);
            this.nullableDateTimePicker_1.set_Value(null);
            this.textBox_0.BackColor = Color.Yellow;
            this.comboBox_0.SelectedIndex = -1;
            this.comboBox_2.SelectedIndex = -1;
            this.comboBox_1.SelectedIndex = -1;
            this.comboBox_3.SelectedIndex = -1;
            this.comboBox_4.SelectedIndex = -1;
            this.comboBox_5.SelectedIndex = -1;
            this.nullableDateTimePicker_2.set_Value(null);
            this.multiColumnComboBox_0.SelectedIndex = -1;
            this.nullableDateTimePicker_5.set_Value(null);
            this.button_1.Enabled = false;
        }
        else if (this.dataSetOrder_0.tJ_Order.Rows.Count > 0)
        {
            if (Convert.ToBoolean(this.dataSetOrder_0.tJ_Order.Rows[0]["Registered"]))
            {
                this.textBox_0.BackColor = Color.White;
                this.panel_0.Enabled = true;
                this.nullableDateTimePicker_0.Enabled = false;
                this.nullableDateTimePicker_1.Enabled = false;
                this.comboBox_0.Enabled = false;
                this.comboBox_2.Enabled = false;
                this.comboBox_1.Enabled = false;
                this.comboBox_3.Enabled = false;
                this.comboBox_4.Enabled = false;
                this.comboBox_5.Enabled = false;
                this.richTextBox_0.ReadOnly = true;
                this.richTextBox_1.ReadOnly = true;
                this.nullableDateTimePicker_2.Enabled = false;
                this.dataGridView_0.ReadOnly = true;
                this.dataGridView_0.AllowUserToAddRows = false;
                this.dataGridView_1.ReadOnly = true;
                this.dataGridView_1.AllowUserToAddRows = false;
                this.button_1.Enabled = false;
                this.button_0.Enabled = false;
                this.toolStripButton_2.Enabled = false;
                this.toolStripButton_1.Enabled = false;
                this.comboBox_6.Enabled = true;
                int count = this.dataSetOrder_0.tJ_OrderResolution.Rows.Count;
                if (count > 0)
                {
                    this.textBox_0.BackColor = Color.LawnGreen;
                    if (this.dataSetOrder_0.tJ_OrderResolution.Rows[count - 1]["DateEnd"] == DBNull.Value)
                    {
                        this.nullableDateTimePicker_3.MinDate = (DateTime) this.dataSetOrder_0.tJ_OrderResolution.Rows[count - 1]["DateBegin"];
                        if (this.nullableDateTimePicker_3.MinDate <= DateTime.Now)
                        {
                            if (this.nullableDateTimePicker_3.MaxDate >= DateTime.Now)
                            {
                                this.nullableDateTimePicker_3.set_Value(DateTime.Now);
                            }
                            else
                            {
                                this.nullableDateTimePicker_3.set_Value(this.nullableDateTimePicker_3.MaxDate);
                            }
                        }
                        else
                        {
                            this.nullableDateTimePicker_3.set_Value(this.nullableDateTimePicker_3.MinDate);
                        }
                        this.button_2.Text = "Закончить работу";
                        this.comboBox_6.Enabled = false;
                        this.bool_1 = false;
                    }
                    else
                    {
                        this.nullableDateTimePicker_3.MinDate = (DateTime) this.dataSetOrder_0.tJ_OrderResolution.Rows[count - 1]["DateEnd"];
                        this.nullableDateTimePicker_3.set_Value(null);
                        this.button_2.Text = "Выдать разрешение";
                        this.comboBox_6.Enabled = true;
                        this.bool_1 = true;
                    }
                }
                else
                {
                    this.nullableDateTimePicker_3.set_Value(null);
                }
                this.nullableDateTimePicker_3.Enabled = true;
                this.button_2.Enabled = true;
                this.comboBox_7.Enabled = true;
                this.nullableDateTimePicker_4.Enabled = true;
                this.button_3.Enabled = true;
                if (Convert.ToDateTime(this.nullableDateTimePicker_1.get_Value()) < DateTime.Now)
                {
                    if ((this.nullableDateTimePicker_5.get_Value() != null) && (this.nullableDateTimePicker_5.get_Value() != DBNull.Value))
                    {
                        if (Convert.ToDateTime(this.nullableDateTimePicker_5.get_Value()) < DateTime.Now)
                        {
                            this.button_2.Enabled = false;
                        }
                    }
                    else
                    {
                        this.button_2.Enabled = false;
                    }
                }
            }
            else
            {
                this.textBox_0.BackColor = Color.Yellow;
                this.panel_0.Enabled = false;
                this.nullableDateTimePicker_0.Enabled = true;
                this.nullableDateTimePicker_1.Enabled = true;
                this.comboBox_0.Enabled = true;
                this.comboBox_2.Enabled = true;
                this.comboBox_1.Enabled = true;
                this.comboBox_3.Enabled = true;
                this.comboBox_4.Enabled = true;
                this.comboBox_5.Enabled = true;
                this.richTextBox_0.ReadOnly = false;
                this.richTextBox_1.ReadOnly = false;
                this.nullableDateTimePicker_2.Enabled = true;
                this.dataGridView_0.ReadOnly = false;
                this.dataGridView_0.AllowUserToAddRows = true;
                this.dataGridView_1.ReadOnly = false;
                this.dataGridView_1.AllowUserToAddRows = true;
                this.button_1.Enabled = true;
                this.button_0.Enabled = true;
                this.toolStripButton_2.Enabled = true;
                this.toolStripButton_1.Enabled = true;
            }
            if (this.dataSetOrder_0.tJ_Order.Rows[0]["dateClose"] != DBNull.Value)
            {
                this.textBox_0.BackColor = Color.Gray;
                this.panel_0.Enabled = false;
                this.comboBox_6.Enabled = false;
                this.nullableDateTimePicker_3.Enabled = false;
                this.button_2.Enabled = false;
                this.comboBox_7.Enabled = false;
                this.nullableDateTimePicker_4.Enabled = false;
                this.button_3.Enabled = false;
            }
            if (this.dataSetOrder_0.tJ_Order.Rows[0]["dateEndExt"] != DBNull.Value)
            {
                this.button_4.Visible = false;
                this.panel_0.Enabled = false;
            }
        }
        if (this.bool_0)
        {
            this.nullableDateTimePicker_0.Enabled = false;
            this.nullableDateTimePicker_1.Enabled = false;
            this.comboBox_0.Enabled = false;
            this.comboBox_2.Enabled = false;
            this.comboBox_1.Enabled = false;
            this.comboBox_3.Enabled = false;
            this.comboBox_4.Enabled = false;
            this.comboBox_5.Enabled = false;
            this.richTextBox_0.ReadOnly = true;
            this.richTextBox_1.ReadOnly = true;
            this.nullableDateTimePicker_2.Enabled = false;
            this.dataGridView_0.ReadOnly = true;
            this.dataGridView_0.AllowUserToAddRows = false;
            this.dataGridView_1.ReadOnly = true;
            this.dataGridView_1.AllowUserToAddRows = false;
            this.button_1.Enabled = false;
            this.button_0.Enabled = false;
            this.comboBox_6.Enabled = false;
            this.comboBox_6.Enabled = false;
            this.nullableDateTimePicker_3.Enabled = false;
            this.button_2.Enabled = false;
            this.comboBox_7.Enabled = false;
            this.nullableDateTimePicker_4.Enabled = false;
            this.button_3.Enabled = false;
        }
        if (base.get_PermissionsControlsEnabled() || base.get_PermissionsControlsVisible())
        {
            base.SetControlsPropertiesUser();
        }
    }

    private void method_9()
    {
        if (this.method_2() > 0)
        {
            base.SelectSqlData(this.dataSetOrder_0, this.dataSetOrder_0.tJ_Order, true, " where id = " + this.int_0);
            if (this.dataSetOrder_0.tJ_Order.Rows.Count > 0)
            {
                this.nullableDateTimePicker_4.set_Value(this.dataSetOrder_0.tJ_Order.Rows[0]["DateClose"]);
                this.comboBox_7.SelectedValue = this.dataSetOrder_0.tJ_Order.Rows[0]["closeWorker"];
                if (this.comboBoxReadOnly_0.get_Visible() && (this.dataSetOrder_0.tJ_Order.Rows[0]["idDivision"] == DBNull.Value))
                {
                    DataRow[] rowArray = ((DataTable) this.comboBoxReadOnly_0.DataSource).Select("VAlue = 1");
                    if (rowArray.Length != 0)
                    {
                        this.comboBoxReadOnly_0.SelectedValue = rowArray[0]["id"];
                    }
                }
            }
        }
    }

    private void nullableDateTimePicker_0_ValueChanged(object sender, EventArgs e)
    {
        if (this.nullableDateTimePicker_0.get_Value() != null)
        {
            this.label_1.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
            this.nullableDateTimePicker_1.MaxDate = Convert.ToDateTime(this.nullableDateTimePicker_0.get_Value()).AddDays(15.0);
            this.nullableDateTimePicker_1.MinDate = (DateTime) this.nullableDateTimePicker_0.get_Value();
            this.nullableDateTimePicker_2.MaxDate = (DateTime) this.nullableDateTimePicker_0.get_Value();
            this.nullableDateTimePicker_3.MinDate = (DateTime) this.nullableDateTimePicker_0.get_Value();
        }
        else
        {
            this.nullableDateTimePicker_1.MaxDate = this.dateTime_1;
            this.nullableDateTimePicker_3.MinDate = this.dateTime_0;
            if (this.nullableDateTimePicker_2.get_Value() != null)
            {
                this.nullableDateTimePicker_1.MinDate = (DateTime) this.nullableDateTimePicker_2.get_Value();
            }
            else
            {
                this.nullableDateTimePicker_2.MinDate = this.dateTime_0;
            }
            if (this.nullableDateTimePicker_1.get_Value() != null)
            {
                this.nullableDateTimePicker_2.MaxDate = (DateTime) this.nullableDateTimePicker_1.get_Value();
            }
            else
            {
                this.nullableDateTimePicker_2.MaxDate = this.dateTime_1;
            }
        }
    }

    private void nullableDateTimePicker_1_ValueChanged(object sender, EventArgs e)
    {
        if (this.nullableDateTimePicker_1.get_Value() != null)
        {
            this.label_2.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
            this.nullableDateTimePicker_0.MaxDate = (DateTime) this.nullableDateTimePicker_1.get_Value();
            if ((this.nullableDateTimePicker_2.get_Value() != null) && (Convert.ToDateTime(this.nullableDateTimePicker_2.get_Value()) > Convert.ToDateTime(this.nullableDateTimePicker_1.get_Value()).AddDays(-15.0)))
            {
                this.nullableDateTimePicker_0.MinDate = (DateTime) this.nullableDateTimePicker_2.get_Value();
            }
            else
            {
                this.nullableDateTimePicker_0.MinDate = Convert.ToDateTime(this.nullableDateTimePicker_1.get_Value()).AddDays(-15.0);
            }
            if (this.nullableDateTimePicker_2.MaxDate > ((DateTime) this.nullableDateTimePicker_1.get_Value()))
            {
                this.nullableDateTimePicker_2.MaxDate = (DateTime) this.nullableDateTimePicker_1.get_Value();
            }
            if (this.nullableDateTimePicker_5.get_Value() != null)
            {
                this.nullableDateTimePicker_3.MaxDate = (DateTime) this.nullableDateTimePicker_5.get_Value();
            }
            else
            {
                this.nullableDateTimePicker_3.MaxDate = (DateTime) this.nullableDateTimePicker_1.get_Value();
            }
            this.nullableDateTimePicker_5.MinDate = (DateTime) this.nullableDateTimePicker_1.get_Value();
        }
        else
        {
            this.nullableDateTimePicker_5.MinDate = this.dateTime_0;
            this.nullableDateTimePicker_0.MaxDate = this.dateTime_1;
            this.nullableDateTimePicker_3.MaxDate = this.dateTime_1;
            if (this.nullableDateTimePicker_2.get_Value() != null)
            {
                this.nullableDateTimePicker_0.MinDate = (DateTime) this.nullableDateTimePicker_2.get_Value();
            }
            else
            {
                this.nullableDateTimePicker_0.MinDate = this.dateTime_0;
            }
            if (this.nullableDateTimePicker_0.get_Value() != null)
            {
                this.nullableDateTimePicker_2.MaxDate = (DateTime) this.nullableDateTimePicker_0.get_Value();
            }
            else
            {
                this.nullableDateTimePicker_2.MaxDate = this.dateTime_1;
            }
        }
    }

    private void nullableDateTimePicker_2_ValueChanged(object sender, EventArgs e)
    {
        if (this.nullableDateTimePicker_2.get_Value() != null)
        {
            this.label_15.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
            if (this.comboBox_5.SelectedValue != null)
            {
                this.label_11.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
            }
            if ((this.nullableDateTimePicker_1.get_Value() != null) && (Convert.ToDateTime(this.nullableDateTimePicker_2.get_Value()) < Convert.ToDateTime(this.nullableDateTimePicker_1.get_Value()).AddDays(-15.0)))
            {
                this.nullableDateTimePicker_0.MinDate = Convert.ToDateTime(this.nullableDateTimePicker_1.get_Value()).AddDays(-15.0);
            }
            else
            {
                this.nullableDateTimePicker_0.MinDate = (DateTime) this.nullableDateTimePicker_2.get_Value();
            }
            if (this.nullableDateTimePicker_1.MinDate < ((DateTime) this.nullableDateTimePicker_2.get_Value()))
            {
                this.nullableDateTimePicker_1.MinDate = (DateTime) this.nullableDateTimePicker_2.get_Value();
            }
            this.nullableDateTimePicker_4.MinDate = (DateTime) this.nullableDateTimePicker_2.get_Value();
        }
        else
        {
            this.nullableDateTimePicker_0.MinDate = this.dateTime_0;
            if (this.nullableDateTimePicker_0.get_Value() != null)
            {
                this.nullableDateTimePicker_1.MinDate = (DateTime) this.nullableDateTimePicker_0.get_Value();
            }
            else
            {
                this.nullableDateTimePicker_1.MinDate = this.dateTime_0;
            }
        }
    }

    private void richTextBox_0_TextChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(this.richTextBox_0.Text))
        {
            this.label_3.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
        }
    }

    private void toolStripButton_0_Click(object sender, EventArgs e)
    {
        if (this.method_2() > 0)
        {
            Class35.smethod_0(this.method_2(), this.get_SqlSettings());
        }
    }

    private void toolStripButton_1_Click(object sender, EventArgs e)
    {
        Form21 form = new Form21();
        form.method_1(this.dictionary_0);
        form.set_SqlSettings(this.get_SqlSettings());
        if (form.ShowDialog() == DialogResult.OK)
        {
            this.dictionary_0 = form.method_0();
            if (this.dictionary_0.Count > 0)
            {
                this.toolStripButton_3.Enabled = true;
            }
            this.method_19();
        }
    }

    private void toolStripButton_2_Click(object sender, EventArgs e)
    {
        foreach (object obj2 in this.listBox_0.SelectedItems)
        {
            this.dictionary_0.Remove(((Struct2) obj2).int_0);
        }
        this.method_19();
        if (this.dictionary_0.Count > 0)
        {
            this.toolStripButton_3.Enabled = true;
        }
        else
        {
            this.toolStripButton_3.Enabled = false;
        }
    }

    private void toolStripButton_3_Click(object sender, EventArgs e)
    {
        GoToSchemaEventArgs args = new GoToSchemaEventArgs(this.dictionary_0.Keys.ToList<int>());
        this.OnGoToSchema(args);
    }

    private void toolStripButton_4_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Скопировать текущий наряд?", "Копирование", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            this.int_0 = -1;
            this.dataSetOrder_0.tL_OrderSchmObjList.Clear();
            new DataSetOrder();
            this.dataSetOrder_0.tJ_OrderBrigade.Clear();
            this.dataGridView_0.DataMember = "";
            foreach (DataRow row in this.dataSetOrder_0.tJ_OrderBrigade.Copy().Rows)
            {
                DataRow row2 = this.dataSetOrder_0.tJ_OrderBrigade.NewRow();
                row2["idOrder"] = this.method_2();
                row2["idWorker"] = row["idWorker"];
                row2["idJobTitle"] = row["idJobTitle"];
                row2["isUnderstudy"] = row["isUnderstudy"];
                this.dataSetOrder_0.tJ_OrderBrigade.Rows.Add(row2);
            }
            this.dataGridView_0.DataMember = "tJ_OrderBrigade";
            this.dataSetOrder_0.tJ_OrderInstruction.Clear();
            foreach (DataRow row3 in this.dataSetOrder_0.tJ_OrderInstruction.Copy().Rows)
            {
                DataRow row4 = this.dataSetOrder_0.tJ_OrderInstruction.NewRow();
                row4["idOrder"] = this.method_2();
                row4["nameObj"] = row3["nameObj"];
                row4["Instruction"] = row3["Instruction"];
                row4["rec_num"] = row3["rec_num"];
                this.dataSetOrder_0.tJ_OrderInstruction.Rows.Add(row4);
            }
            this.dataSetOrder_0.tJ_OrderResolution.Clear();
            this.method_18();
            this.textBox_0.BackColor = Color.Yellow;
            this.panel_0.Enabled = false;
            this.nullableDateTimePicker_0.Enabled = true;
            this.nullableDateTimePicker_1.Enabled = true;
            this.comboBox_0.Enabled = true;
            this.comboBox_2.Enabled = true;
            this.comboBox_1.Enabled = true;
            this.comboBox_3.Enabled = true;
            this.comboBox_4.Enabled = true;
            this.comboBox_5.Enabled = true;
            this.richTextBox_0.ReadOnly = false;
            this.richTextBox_1.ReadOnly = false;
            this.nullableDateTimePicker_2.Enabled = true;
            this.dataGridView_0.ReadOnly = false;
            this.dataGridView_0.AllowUserToAddRows = true;
            this.dataGridView_1.ReadOnly = false;
            this.dataGridView_1.AllowUserToAddRows = true;
            this.button_1.Enabled = true;
            this.button_0.Enabled = true;
            this.toolStripButton_2.Enabled = true;
            this.toolStripButton_1.Enabled = true;
            this.panel_0.Enabled = false;
            this.comboBox_6.Enabled = false;
            this.nullableDateTimePicker_3.Enabled = false;
            this.button_2.Enabled = false;
            this.comboBox_7.Enabled = false;
            this.nullableDateTimePicker_4.Enabled = false;
            this.button_3.Enabled = false;
            this.panel_0.Enabled = false;
            this.toolStripButton_4.Enabled = false;
            this.toolStripButton_0.Enabled = false;
            if (base.get_PermissionsControlsEnabled() || base.get_PermissionsControlsVisible())
            {
                base.SetControlsPropertiesUser();
            }
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct Struct2
    {
        public string string_0;
        public int int_0;
        public Struct2(int int_1, string string_1)
        {
            this.string_0 = string_1;
            this.int_0 = int_1;
        }

        public override string ToString()
        {
            return this.string_0;
        }
    }
}

