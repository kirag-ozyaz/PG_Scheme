using ControlsLbr;
using ControlsLbr.DataGridViewExcelFilter;
using Documents.DataSets;
//using Documents.Forms.RequestForRepair;
using Documents.Properties;
using FormLbr;
using FormLbr.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;
namespace Documents.JournalRequestForRepair
{
    /// <summary>
    /// Журнал аварийных заявок на ремонт оборудования
    /// </summary>

    public partial  class FormJournalRequestForRepairAddEdit : FormBase
    {
        private BindingSource bindingSource_0;
        private BindingSource bindingSource_1;
        private bool bool_0;
        private Button button_0;
        private Button button_1;
        private Button button_2;
        private Button button_3;
        private CheckBox checkBox_0;
        private CheckBox checkBox_1;
        private CheckBox checkBox_2;
        private ComboBox comboBox_0;
        private ComboBox comboBox_1;
        private ComboBox comboBox_2;
        private ComboBox comboBox_3;
        private ComboBox comboBox_4;
        private ComboBox comboBox_5;
        private ComboBox comboBox_6;
        private DataColumn dataColumn_0;
        private DataColumn dataColumn_1;
        private DataColumn dataColumn_2;
        private DataColumn dataColumn_3;
        private DataColumn dataColumn_4;
        private DataColumn dataColumn_5;
        private DataColumn dataColumn_6;
        private DataColumn dataColumn_7;
        private DataColumn dataColumn_8;
        private DataGridView dataGridView_0;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_0;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_1;
        private DataGridViewFilterDateTimePickerColumn dataGridViewFilterDateTimePickerColumn_0;
        private DataGridViewFilterDateTimePickerColumn dataGridViewFilterDateTimePickerColumn_1;
        private DataGridViewImageColumnNotNull dataGridViewImageColumnNotNull_0;
        private DataGridViewLinkColumn dataGridViewLinkColumn_0;
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
        private DataRow dataRow_0;
        private DataSet dataSet_0;
        private DataSetGES dataSetGES_0;
        private DataTable dataTable_0;
        private DataTable dataTable_1;
        private DataTable dataTable_2;
        private DateTime dateTime_0;
        private DateTime dateTime_1;
        private DateTimePicker dateTimePicker_0;
        private DateTimePicker dateTimePicker_1;
        private Dictionary<int, string> dictionary_0;
        private eActionRequestRepair enum11_0;
        private GroupBox groupBox_0;
        private GroupBox groupBox_1;
        private GroupBox groupBox_2;
        private IContainer icontainer_0;
        private int int_0;
        private int int_1;
        private const int int_2 = 920;
        private int int_3;
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
        private NullableDateTimePicker nullableDateTimePicker_0;
        private NullableDateTimePicker nullableDateTimePicker_1;
        private NullableDateTimePicker nullableDateTimePicker_2;
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
        private ToolStrip toolStrip_1;
        private ToolStrip toolStrip_2;
        private ToolStripButton toolStripButton_0;
        private ToolStripButton toolStripButton_1;
        private ToolStripButton toolStripButton_2;
        private ToolStripButton toolStripButton_3;
        private ToolStripButton toolStripButton_4;
        private ToolStripButton toolStripButton_5;
        private ToolStripButton toolStripButton_6;
        private ToolStripButton toolStripButton_7;
        private ToolStripButton toolStripButton_8;

        public FormJournalRequestForRepairAddEdit()
        {
            this.int_0 = -1;
            this.int_1 = -1;
            this.enum11_0 = eActionRequestRepair.Read;
            this.dateTime_0 = new DateTime(0x76c, 1, 1);
            this.dateTime_1 = new DateTime(0x2328, 1, 1);
            this.dictionary_0 = new Dictionary<int, string>();
            this.int_3 = -1;
            this.InitializeComponent();
        }

        internal FormJournalRequestForRepairAddEdit(DataRow row)
        {
            this.int_0 = -1;
            this.int_1 = -1;
            this.enum11_0 = eActionRequestRepair.Read;
            this.dateTime_0 = new DateTime(0x76c, 1, 1);
            this.dateTime_1 = new DateTime(0x2328, 1, 1);
            this.dictionary_0 = new Dictionary<int, string>();
            this.int_3 = -1;
            this.InitializeComponent();
            this.int_0 = -1;
            this.int_1 = Convert.ToInt32(row["idDivision"]);
            this.enum11_0 = eActionRequestRepair.Add;
            this.dataRow_0 = row;
        }

        internal FormJournalRequestForRepairAddEdit(int int_4, int int_5, eActionRequestRepair enum11_1, bool bool_1 = false)
        {
            this.int_0 = -1;
            this.int_1 = -1;
            this.enum11_0 = eActionRequestRepair.Read;
            this.dateTime_0 = new DateTime(0x76c, 1, 1);
            this.dateTime_1 = new DateTime(0x2328, 1, 1);
            this.dictionary_0 = new Dictionary<int, string>();
            this.int_3 = -1;
            this.InitializeComponent();
            this.int_0 = int_4;
            this.int_1 = int_5;
            this.enum11_0 = enum11_1;
            this.bool_0 = bool_1;
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
                    int? nullable3 = nullable;
                    if ((nullable3.GetValueOrDefault() < 0) ? nullable3.HasValue : false)
                    {
                        nullable = 0;
                    }
                    nullable3 = nullable2;
                    if ((nullable3.GetValueOrDefault() < 0) ? nullable3.HasValue : false)
                    {
                        nullable2 = 0;
                    }
                    base.Location = new Point(nullable.Value, nullable2.Value);
                }
                attribute = node.Attributes["SR"];
                if (attribute != null)
                {
                    this.int_3 = Convert.ToInt32(attribute.Value);
                }
            }
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.OK;
            base.Close();
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
            base.Close();
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            bool flag = false;
            this.dataGridView_0.RowsAdded -= new DataGridViewRowsAddedEventHandler(this.dataGridView_0_RowsAdded);
            if (this.checkBox_2.Checked)
            {
                int num = 0;
                while (true)
                {
                    TimeSpan span = (TimeSpan)(this.dateTimePicker_0.Value - this.dateTimePicker_1.Value);
                    if (num > span.Days)
                    {
                        goto Label_022F;
                    }
                    if (this.checkBox_1.Checked || ((this.dateTimePicker_1.Value.AddDays((double)num).DayOfWeek != DayOfWeek.Saturday) && (this.dateTimePicker_1.Value.AddDays((double)num).DayOfWeek != DayOfWeek.Sunday)))
                    {
                        try
                        {
                            DataRow row = this.dataSetGES_0.tJ_RequestForRepairDaily.NewRow();
                            row["idRequest"] = this.int_0;
                            row["dateBeg"] = this.dateTimePicker_1.Value.AddDays((double)num);
                            row["dateEnd"] = this.dateTimePicker_1.Value.AddDays((double)num).Date + this.dateTimePicker_0.Value.TimeOfDay;
                            this.dataSetGES_0.tJ_RequestForRepairDaily.Rows.Add(row);
                            flag = true;
                            this.groupBox_2.ForeColor = SystemColors.ControlText;
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, exception.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                    num++;
                }
            }
            try
            {
                DataRow row2 = this.dataSetGES_0.tJ_RequestForRepairDaily.NewRow();
                row2["idRequest"] = this.int_0;
                row2["dateBeg"] = this.dateTimePicker_1.Value;
                row2["dateEnd"] = this.dateTimePicker_0.Value;
                this.dataSetGES_0.tJ_RequestForRepairDaily.Rows.Add(row2);
                flag = true;
                this.groupBox_2.ForeColor = SystemColors.ControlText;
            }
            catch (Exception exception2)
            {
                MessageBox.Show(exception2.Message, exception2.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            Label_022F:
            this.dataGridView_0.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dataGridView_0_RowsAdded);
            if (flag)
            {
                DataRow row3 = this.dataSetGES_0.tJ_RequestForRepairDaily.Where<DataSetGES.Class51>((C_1.C_9__32_0 ?? (C_1.C_9__32_0 = new Func<DataSetGES.Class51, bool>(C_1.C_9.method_5)))).OrderByDescending<DataSetGES.Class51, DateTime>((C_1.C_9__32_1 ?? (C_1.C_9__32_1 = new Func<DataSetGES.Class51, DateTime>(C_1.C_9.method_6)))).First<DataSetGES.Class51>();
                if (Convert.ToDateTime(row3["DateEnd"]) > this.dateTimePicker_1.MaxDate)
                {
                    this.dateTimePicker_1.MaxDate = this.dateTime_1;
                }
                this.dateTimePicker_1.MinDate = Convert.ToDateTime(row3["DateEnd"]);
            }
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            if (this.dataSetGES_0.tJ_RequestForRepair.Rows.Count > 0)
            {
                DataRow row = this.dataSetGES_0.tJ_RequestForRepair.NewRow();
                row.ItemArray = this.dataSetGES_0.tJ_RequestForRepair.Rows[0].ItemArray;
                this.dataSetGES_0.tJ_RequestForRepairDoc.Clear();
                this.dataSetGES_0.tJ_RequestForRepairDaily.Clear();
                DataRow row2 = this.dataSetGES_0.tJ_RequestForRepair.NewRow();
                row2["num"] = 0;
                row2["dateCreate"] = DateTime.Now;
                if (row["idWorker"] != DBNull.Value)
                {
                    row2["idWorker"] = row["idWorker"];
                }
                row2["reguestFiled"] = row["reguestFiled"];
                row2["idSR"] = row["idSR"];
                row2["schmObj"] = row["schmObj"];
                row2["Purpose"] = row["Purpose"];
                row2["IsPlanned"] = row["IsPlanned"];
                row2["Crash"] = row["Crash"];
                row2["agreed"] = false;
                row2["iddivision"] = row["iddivision"];
                DataTable table = this.method_3();
                base.SelectSqlData(table, true, " where [Login] = SYSTEM_USER ");
                if (table.Rows.Count > 0)
                {
                    row2["idUserCreate"] = table.Rows[0]["iduser"];
                    if (table.Rows[0]["idWorker"] != DBNull.Value)
                    {
                        row2["IdWorker"] = table.Rows[0]["idWorker"];
                    }
                }
                if (row2["idWorker"] == DBNull.Value)
                {
                    row2["idWorker"] = -1;
                }
                this.int_0 = -1;
                this.enum11_0 = eActionRequestRepair.Add;
                this.dataSetGES_0.tJ_RequestForRepair.Rows.Add(row2);
                this.dataSetGES_0.tJ_RequestForRepair.Rows.RemoveAt(0);
            }
        }

        private void checkBox_0_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_0.Checked)
            {
                if ((this.dataSetGES_0.tJ_RequestForRepair.Rows.Count > 0) && (this.nullableDateTimePicker_0.Value == null))
                {
                    object obj2;
                    this.dataSetGES_0.tJ_RequestForRepair.Rows[0]["Agreed"] = true;
                    this.dataSetGES_0.tJ_RequestForRepair.Rows[0]["DateAgreed"] = obj2 = DateTime.Now;
                    this.nullableDateTimePicker_0.Value = (obj2);
                }
            }
            else if ((this.dataSetGES_0.tJ_RequestForRepair.Rows.Count > 0) && (this.nullableDateTimePicker_0.Value != null))
            {
                this.dataSetGES_0.tJ_RequestForRepair.Rows[0]["Agreed"] = false;
                this.nullableDateTimePicker_0.Value = (null);
                this.dataSetGES_0.tJ_RequestForRepair.Rows[0]["DateAgreed"] = DBNull.Value;
            }
        }

        private void checkBox_2_CheckedChanged(object sender, EventArgs e)
        {
            this.checkBox_1.Enabled = this.checkBox_2.Checked;
        }

        private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox_0.SelectedIndex >= 0)
            {
                this.label_2.ForeColor = SystemColors.ControlText;
            }
        }

        private void comboBox_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox_1.SelectedIndex >= 0)
            {
                this.label_4.ForeColor = SystemColors.ControlText;
            }
            if (this.dataSetGES_0.tJ_RequestForRepair.Rows.Count > 0)
            {
                if (this.comboBox_1.SelectedIndex == 0)
                {
                    this.dataSetGES_0.tJ_RequestForRepair.Rows[0]["IsPlanned"] = false;
                }
                else
                {
                    this.dataSetGES_0.tJ_RequestForRepair.Rows[0]["IsPlanned"] = true;
                }
            }
        }

        private void comboBox_6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox_6.SelectedIndex >= 0)
            {
                this.label_17.ForeColor = SystemColors.ControlText;
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
            node = document1.CreateAttribute("SR");
            if (this.enum11_0 == eActionRequestRepair.Add)
            {
                node.Value = this.comboBox_0.SelectedValue.ToString();
            }
            else
            {
                node.Value = this.int_3.ToString();
            }
            node2.Attributes.Append(node);
            return document1;
        }

        private void dataGridView_0_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == (this.dataGridView_0.Rows.Count - 1))
            {
                DateTime time = Convert.ToDateTime(this.dataGridView_0[this.dataGridViewFilterDateTimePickerColumn_1.Name, e.RowIndex].Value);
                if (time > this.dateTimePicker_1.MaxDate)
                {
                    this.dateTimePicker_1.MaxDate = DateTimePicker.MaximumDateTime;
                }
                this.dateTimePicker_1.MinDate = time;
            }
        }

        private void dataGridView_0_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DayOfWeek dayOfWeek = Convert.ToDateTime(this.dataGridView_0[this.dataGridViewFilterDateTimePickerColumn_0.Name, e.RowIndex].Value).DayOfWeek;
                DayOfWeek week2 = Convert.ToDateTime(this.dataGridView_0[this.dataGridViewFilterDateTimePickerColumn_1.Name, e.RowIndex].Value).DayOfWeek;
                if (((dayOfWeek == DayOfWeek.Sunday) || (dayOfWeek == DayOfWeek.Saturday)) && (this.dataGridView_0.Columns[e.ColumnIndex] == this.dataGridViewFilterDateTimePickerColumn_0))
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                if (((week2 == DayOfWeek.Sunday) || (week2 == DayOfWeek.Saturday)) && (this.dataGridView_0.Columns[e.ColumnIndex] == this.dataGridViewFilterDateTimePickerColumn_1))
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void dataGridView_0_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is DateTimePicker)
            {
                if (this.dataGridView_0.CurrentCell.OwningColumn.Name == this.dataGridViewFilterDateTimePickerColumn_0.Name)
                {
                    (e.Control as DateTimePicker).MaxDate = Convert.ToDateTime(this.dataGridView_0[this.dataGridViewFilterDateTimePickerColumn_1.Name, this.dataGridView_0.CurrentCell.RowIndex].Value);
                    if (this.dataGridView_0.CurrentCell.RowIndex == 0)
                    {
                        (e.Control as DateTimePicker).MinDate = new DateTime(0x7d0, 1, 1);
                    }
                    if (this.dataGridView_0.CurrentCell.RowIndex > 0)
                    {
                        (e.Control as DateTimePicker).MinDate = Convert.ToDateTime(this.dataGridView_0[this.dataGridViewFilterDateTimePickerColumn_1.Name, this.dataGridView_0.CurrentCell.RowIndex - 1].Value);
                    }
                }
                if (this.dataGridView_0.CurrentCell.OwningColumn.Name == this.dataGridViewFilterDateTimePickerColumn_1.Name)
                {
                    (e.Control as DateTimePicker).MinDate = Convert.ToDateTime(this.dataGridView_0[this.dataGridViewFilterDateTimePickerColumn_0.Name, this.dataGridView_0.CurrentCell.RowIndex].Value);
                    if (this.dataGridView_0.CurrentCell.RowIndex == (this.dataGridView_0.Rows.Count - 1))
                    {
                        (e.Control as DateTimePicker).MaxDate = new DateTime(0x270e, 12, 0x1f);
                    }
                    if (this.dataGridView_0.CurrentCell.RowIndex < (this.dataGridView_0.Rows.Count - 1))
                    {
                        (e.Control as DateTimePicker).MaxDate = Convert.ToDateTime(this.dataGridView_0[this.dataGridViewFilterDateTimePickerColumn_0.Name, this.dataGridView_0.CurrentCell.RowIndex + 1].Value);
                    }
                }
            }
        }

        private void dataGridView_0_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataRow row = this.dataSetGES_0.tJ_RequestForRepairDaily.Where<DataSetGES.Class51>((C_1.C_9__27_0 ?? (C_1.C_9__27_0 = new Func<DataSetGES.Class51, bool>(C_1.C_9.method_0)))).OrderByDescending<DataSetGES.Class51, DateTime>((C_1.C_9__27_1 ?? (C_1.C_9__27_1 = new Func<DataSetGES.Class51, DateTime>(C_1.C_9.method_1)))).First<DataSetGES.Class51>();
            if (Convert.ToDateTime(row["DateEnd"]) > this.dateTimePicker_1.MaxDate)
            {
                this.dateTimePicker_1.MaxDate = DateTimePicker.MaximumDateTime;
            }
            this.dateTimePicker_1.MinDate = Convert.ToDateTime(row["DateEnd"]);
        }

        private void dataGridView_0_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (this.dataSetGES_0.tJ_RequestForRepairDaily.Rows.Count > 0)
            {
                if (this.dataSetGES_0.tJ_RequestForRepairDaily.Where<DataSetGES.Class51>((C_1.C_9__28_0 ?? (C_1.C_9__28_0 = new Func<DataSetGES.Class51, bool>(C_1.C_9.method_2)))).Count<DataSetGES.Class51>() > 0)
                {
                    DataRow row = this.dataSetGES_0.tJ_RequestForRepairDaily.Where<DataSetGES.Class51>((C_1.C_9__28_1 ?? (C_1.C_9__28_1 = new Func<DataSetGES.Class51, bool>(C_1.C_9.method_3)))).OrderByDescending<DataSetGES.Class51, DateTime>((C_1.C_9__28_2 ?? (C_1.C_9__28_2 = new Func<DataSetGES.Class51, DateTime>(C_1.C_9.method_4)))).First<DataSetGES.Class51>();
                    this.dateTimePicker_1.MinDate = Convert.ToDateTime(row["DateEnd"]);
                }
                else
                {
                    this.dateTimePicker_1.MinDate = this.dateTime_0;
                }
            }
            else
            {
                this.dateTimePicker_1.MinDate = this.dateTime_0;
            }
        }

        private void dataGridViewExcelFilter_0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.toolStripButton_3_Click(sender, e);
        }

        private void dataGridViewExcelFilter_1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridViewExcelFilter_1.CurrentRow != null)
            {
                int num = Convert.ToInt32(this.dataGridViewExcelFilter_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_5.Name].Value);
                if (e.ColumnIndex == this.dataGridViewExcelFilter_1.Columns[this.dataGridViewLinkColumn_0.Name].Index)
                {
                    byte[] buffer = (byte[])this.dataSetGES_0.tJ_RequestForRepairDoc.method_2(num)["Document"];
                    string path = Path.ChangeExtension(Path.GetTempFileName(), Path.GetExtension(this.dataSetGES_0.tJ_RequestForRepairDoc.method_2(num)["FileName"].ToString()));
                    FileStream stream1 = File.Create(path);
                    stream1.Write(buffer, 0, buffer.Length);
                    stream1.Close();
                    new Process
                    {
                        StartInfo = {
                    FileName = path,
                    UseShellExecute = true
                }
                    }.Start();
                }
            }
        }

        private void dataGridViewExcelFilter_1_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (((this.dataGridViewExcelFilter_1.RowCount > 0) && (this.dataGridViewExcelFilter_1[this.dataGridViewLinkColumn_0.Name, e.RowIndex].Value != null)) && (e.ColumnIndex == this.dataGridViewExcelFilter_1.Columns[this.dataGridViewImageColumnNotNull_0.Name].Index))
            {
                e.Value = FormLbr.Classes.FileInfo.IconOfFile(this.dataGridViewExcelFilter_1[this.dataGridViewLinkColumn_0.Name, e.RowIndex].Value.ToString()).ToBitmap();
            }
        }

        private void dateTimePicker_0_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePicker_1.MaxDate = this.dateTimePicker_0.Value.AddMinutes(-1.0);
        }

        private void dateTimePicker_1_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePicker_0.MinDate = this.dateTimePicker_1.Value.AddMinutes(1.0);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void Form43_FormClosed(object sender, FormClosedEventArgs e)
        {
            base.SaveFormConfig(null);
        }

        private void Form43_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (base.DialogResult == DialogResult.OK)
            {
                if ((this.enum11_0 != eActionRequestRepair.Read) && !this.method_6())
                {
                    MessageBox.Show("Не введены обязательные поля", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    e.Cancel = true;
                }
                else
                {
                    switch (this.enum11_0)
                    {
                        case eActionRequestRepair.Add:
                            this.dataSetGES_0.tJ_RequestForRepair.Rows[0].EndEdit();
                            this.int_0 = base.InsertSqlDataOneRow(this.dataSetGES_0, this.dataSetGES_0.tJ_RequestForRepair);
                            foreach (DataRow row in this.dataSetGES_0.tJ_RequestForRepairDaily)
                            {
                                if ((row.RowState != DataRowState.Detached) && (row.RowState != DataRowState.Deleted))
                                {
                                    row["idRequest"] = this.int_0;
                                    row.EndEdit();
                                }
                            }
                            base.InsertSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_RequestForRepairDaily);
                            base.UpdateSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_RequestForRepairDaily);
                            base.DeleteSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_RequestForRepairDaily);
                            this.method_10();
                            this.method_11();
                            break;

                        case eActionRequestRepair.Edit:
                            this.dataSetGES_0.tJ_RequestForRepair.Rows[0].EndEdit();
                            base.UpdateSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_RequestForRepair);
                            foreach (DataRow row2 in this.dataSetGES_0.tJ_RequestForRepairDaily)
                            {
                                if ((row2.RowState != DataRowState.Detached) && (row2.RowState != DataRowState.Deleted))
                                {
                                    row2["idRequest"] = this.int_0;
                                    row2.EndEdit();
                                }
                            }
                            base.InsertSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_RequestForRepairDaily);
                            base.UpdateSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_RequestForRepairDaily);
                            base.DeleteSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_RequestForRepairDaily);
                            this.method_10();
                            this.method_11();
                            break;
                    }
                }
            }
        }

        private void Form43_Load(object sender, EventArgs e)
        {
            this.nullableDateTimePicker_1.Value = (DateTime.Now);
            this.dateTimePicker_1.Value = DateTime.Now.Date.AddHours(8.0);
            this.dateTimePicker_0.Value = DateTime.Now.Date.AddHours(17.0);
            this.method_1();
            this.method_4();
            this.method_5();
            this.method_0();
            base.LoadFormConfig(null);
            switch (this.enum11_0)
            {
                case eActionRequestRepair.Add:
                    {
                        if (this.dataRow_0 == null)
                        {
                            DataRow row2 = this.dataSetGES_0.tJ_RequestForRepair.NewRow();
                            row2["num"] = 0;
                            row2["dateCreate"] = DateTime.Now;
                            row2["idWorker"] = -1;
                            row2["reguestFiled"] = "";
                            row2["idSR"] = this.int_3;
                            row2["schmObj"] = "";
                            row2["Purpose"] = "";
                            row2["Crash"] = this.bool_0;
                            if (this.bool_0)
                            {
                                row2["isPlanned"] = false;
                            }
                            else
                            {
                                row2["IsPlanned"] = true;
                            }
                            row2["agreed"] = false;
                            row2["iddivision"] = this.int_1;
                            DataTable table2 = this.method_3();
                            base.SelectSqlData(table2, true, " where [Login] = SYSTEM_USER ");
                            if (table2.Rows.Count > 0)
                            {
                                row2["idUserCreate"] = table2.Rows[0]["iduser"];
                                if (table2.Rows[0]["idWorker"] != DBNull.Value)
                                {
                                    row2["IdWorker"] = table2.Rows[0]["idWorker"];
                                }
                            }
                            this.dataSetGES_0.tJ_RequestForRepair.Rows.Add(row2);
                            if (this.bool_0)
                            {
                                this.comboBox_1.SelectedIndex = 0;
                            }
                            else
                            {
                                this.comboBox_1.SelectedIndex = 1;
                            }
                            if (this.comboBox_6.SelectedItem != null)
                            {
                                row2["reguestFiled"] = this.comboBox_6.Text;
                            }
                            break;
                        }
                        DataRow row = this.dataSetGES_0.tJ_RequestForRepair.NewRow();
                        row["num"] = 0;
                        row["dateCreate"] = DateTime.Now;
                        row["idWorker"] = this.dataRow_0["idWorker"];
                        row["reguestFiled"] = this.dataRow_0["reguestFiled"];
                        row["idSR"] = this.dataRow_0["idSR"];
                        row["schmObj"] = this.dataRow_0["schmObj"];
                        row["Purpose"] = this.dataRow_0["Purpose"];
                        row["IsPlanned"] = this.dataRow_0["IsPlanned"];
                        row["agreed"] = this.dataRow_0["agreed"];
                        row["iddivision"] = this.dataRow_0["iddivision"];
                        row["Crash"] = this.dataRow_0["Crash"];
                        DataTable table = this.method_3();
                        base.SelectSqlData(table, true, " where [Login] = SYSTEM_USER ");
                        if (table.Rows.Count > 0)
                        {
                            row["idUserCreate"] = table.Rows[0]["iduser"];
                            if (table.Rows[0]["idWorker"] != DBNull.Value)
                            {
                                row["IdWorker"] = table.Rows[0]["idWorker"];
                            }
                        }
                        this.dataSetGES_0.tJ_RequestForRepair.Rows.Add(row);
                        break;
                    }
                case eActionRequestRepair.Edit:
                    if (this.int_0 > 0)
                    {
                        base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_RequestForRepair, true, " where id = " + this.int_0.ToString());
                        base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_RequestForRepairDaily, true, " where idRequest = " + this.int_0.ToString());
                        base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_RequestForRepairDoc, true, " where idRequest = " + this.int_0.ToString());
                        this.method_9();
                    }
                    break;

                case eActionRequestRepair.Read:
                    if (this.int_0 > 0)
                    {
                        base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_RequestForRepair, true, " where id = " + this.int_0.ToString());
                        base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_RequestForRepairDaily, true, " where idRequest = " + this.int_0.ToString());
                        base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_RequestForRepairDoc, true, " where idRequest = " + this.int_0.ToString());
                        this.method_9();
                    }
                    this.comboBox_6.Enabled = false;
                    this.comboBox_4.Enabled = false;
                    this.comboBox_0.Enabled = false;
                    this.textBox_1.ReadOnly = true;
                    this.textBox_0.ReadOnly = true;
                    this.comboBox_1.Enabled = false;
                    this.groupBox_2.Enabled = false;
                    this.textBox_3.ReadOnly = true;
                    this.textBox_2.ReadOnly = true;
                    this.textBox_5.ReadOnly = true;
                    this.checkBox_0.Enabled = false;
                    this.nullableDateTimePicker_0.Enabled = false;
                    this.comboBox_2.Enabled = false;
                    break;
            }
            if (this.dataSetGES_0.tJ_RequestForRepair.Rows.Count > 0)
            {
                if (this.int_1 <= 0)
                {
                    this.int_1 = Convert.ToInt32(this.dataSetGES_0.tJ_RequestForRepair.Rows[0]["IdDivision"]);
                }
                if (Convert.ToBoolean(this.dataSetGES_0.tJ_RequestForRepair.Rows[0]["IsPlanned"]))
                {
                    this.comboBox_1.SelectedIndex = 1;
                }
                else
                {
                    this.comboBox_1.SelectedIndex = 0;
                }
                if ((this.dataSetGES_0.tJ_RequestForRepair.Rows[0]["Crash"] != DBNull.Value) && Convert.ToBoolean(this.dataSetGES_0.tJ_RequestForRepair.Rows[0]["Crash"]))
                {
                    this.comboBox_1.Enabled = false;
                }
            }
            if (this.int_1 == 0x399)
            {
                this.groupBox_1.Visible = false;
            }
        }

        private void groupBox_1_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.groupBox_1.Visible)
            {
                this.tabControl_0.Height = 0x145;
                base.Height = 0x187;
                this.button_1.Location = new Point(this.button_1.Location.X, 0x14b);
                this.button_0.Location = new Point(this.button_0.Location.X, 0x14b);
            }
            else
            {
                this.tabControl_0.Height = 0x245;
                base.Height = 0x287;
                this.button_1.Location = new Point(this.button_1.Location.X, 0x24b);
                this.button_0.Location = new Point(this.button_0.Location.X, 0x24b);
            }
        }

        private void method_0()
        {
            DataTable table = new DataTable("tUser");
            table.Columns.Add("idUser", typeof(int));
            base.SelectSqlData(table, true, " left join vworkergroup w on w.id = tuser.idWorker\r\n                                where w.ParentKey = ';GroupWorker;Dispatchers;' and tuser.login = SYSTEM_USER");
            if (table.Rows.Count == 0)
            {
                this.groupBox_1.Enabled = false;
                this.nullableDateTimePicker_1.Enabled = false;
                this.nullableDateTimePicker_2.Enabled = false;
            }
            else
            {
                this.groupBox_1.Enabled = true;
                this.nullableDateTimePicker_1.Enabled = true;
                this.nullableDateTimePicker_2.Enabled = true;
            }
        }

        private void method_1()
        {
            if (this.int_1 > 0)
            {
                base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tR_Classifier, true, "where id = " + this.int_1.ToString());
            }
            string str = "";
            if (this.dataSetGES_0.tR_Classifier.Rows.Count > 0)
            {
                str = " " + this.dataSetGES_0.tR_Classifier.Rows[0]["SocrName"].ToString();
            }
            switch (this.enum11_0)
            {
                case eActionRequestRepair.Add:
                    if (!this.bool_0)
                    {
                        this.Text = "Создать новую заявку" + str;
                        return;
                    }
                    this.Text = "Создать новую аварийную заявку" + str;
                    return;

                case eActionRequestRepair.Edit:
                    if (!this.bool_0)
                    {
                        this.Text = "Редактирование заявки" + str;
                        return;
                    }
                    this.Text = "Редактирование аварийной заявки" + str;
                    return;

                case eActionRequestRepair.Read:
                    if (!this.bool_0)
                    {
                        this.Text = "Просмотр заявки" + str;
                        return;
                    }
                    this.Text = "Просмотр аварийной заявки" + str;
                    return;
            }
        }

        private void method_10()
        {
            foreach (DataRow row in this.dataSetGES_0.tL_RequestForRepairSchmObjList)
            {
                if ((row.RowState != DataRowState.Detached) && (row.RowState != DataRowState.Deleted))
                {
                    row["idRequest"] = this.int_0;
                    row.EndEdit();
                }
            }
            base.InsertSqlData(this.dataSetGES_0, this.dataSetGES_0.tL_RequestForRepairSchmObjList);
            base.UpdateSqlData(this.dataSetGES_0, this.dataSetGES_0.tL_RequestForRepairSchmObjList);
            base.DeleteSqlData(this.dataSetGES_0, this.dataSetGES_0.tL_RequestForRepairSchmObjList);
            this.dataSetGES_0.tL_RequestForRepairSchmObjList.AcceptChanges();
        }

        private void method_11()
        {
            foreach (DataRow row in this.dataSetGES_0.tJ_RequestForRepairDoc)
            {
                if ((row.RowState != DataRowState.Detached) && (row.RowState != DataRowState.Deleted))
                {
                    row["idRequest"] = this.int_0;
                    row.EndEdit();
                }
            }
            base.InsertSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_RequestForRepairDoc);
            base.UpdateSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_RequestForRepairDoc);
            base.DeleteSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_RequestForRepairDoc);
            this.dataSetGES_0.tL_RequestForRepairSchmObjList.AcceptChanges();
        }

        private void InitializeComponent()
        {
            this.icontainer_0 = new Container();
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            DataGridViewCellStyle style3 = new DataGridViewCellStyle();
            DataGridViewCellStyle style4 = new DataGridViewCellStyle();
            this.dataSetGES_0 = new DataSetGES();
            this.label_0 = new Label();
            this.label_1 = new Label();
            this.label_2 = new Label();
            this.comboBox_0 = new ComboBox();
            this.groupBox_0 = new GroupBox();
            this.comboBox_1 = new ComboBox();
            this.label_4 = new Label();
            this.label_5 = new Label();
            this.textBox_0 = new TextBox();
            this.textBox_1 = new TextBox();
            this.comboBox_6 = new ComboBox();
            this.label_6 = new Label();
            this.label_17 = new Label();
            this.toolStrip_0 = new ToolStrip();
            this.toolStripButton_0 = new ToolStripButton();
            this.toolStripButton_3 = new ToolStripButton();
            this.toolStripButton_1 = new ToolStripButton();
            this.toolStripButton_2 = new ToolStripButton();
            this.groupBox_2 = new GroupBox();
            this.button_2 = new Button();
            this.dataGridView_0 = new DataGridView();
            this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterDateTimePickerColumn_0 = new DataGridViewFilterDateTimePickerColumn();
            this.dataGridViewFilterDateTimePickerColumn_1 = new DataGridViewFilterDateTimePickerColumn();
            this.checkBox_1 = new CheckBox();
            this.checkBox_2 = new CheckBox();
            this.dateTimePicker_0 = new DateTimePicker();
            this.label_7 = new Label();
            this.dateTimePicker_1 = new DateTimePicker();
            this.label_3 = new Label();
            this.nullableDateTimePicker_2 = new NullableDateTimePicker();
            this.label_15 = new Label();
            this.groupBox_1 = new GroupBox();
            this.comboBox_5 = new ComboBox();
            this.label_16 = new Label();
            this.textBox_5 = new TextBox();
            this.comboBox_2 = new ComboBox();
            this.label_8 = new Label();
            this.label_9 = new Label();
            this.nullableDateTimePicker_0 = new NullableDateTimePicker();
            this.checkBox_0 = new CheckBox();
            this.nullableDateTimePicker_1 = new NullableDateTimePicker();
            this.label_14 = new Label();
            this.label_10 = new Label();
            this.label_11 = new Label();
            this.label_12 = new Label();
            this.textBox_2 = new TextBox();
            this.textBox_3 = new TextBox();
            this.button_0 = new Button();
            this.button_1 = new Button();
            this.comboBox_3 = new ComboBox();
            this.label_13 = new Label();
            this.textBox_4 = new TextBox();
            this.tabControl_0 = new TabControl();
            this.tabPage_0 = new TabPage();
            this.comboBox_4 = new ComboBox();
            this.toolStrip_2 = new ToolStrip();
            this.toolStripButton_8 = new ToolStripButton();
            this.tabPage_1 = new TabPage();
            this.dataGridViewExcelFilter_0 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
            this.bindingSource_0 = new BindingSource(this.icontainer_0);
            this.dataSet_0 = new DataSet();
            this.dataTable_1 = new DataTable();
            this.dataColumn_0 = new DataColumn();
            this.dataColumn_1 = new DataColumn();
            this.dataColumn_2 = new DataColumn();
            this.dataColumn_3 = new DataColumn();
            this.dataColumn_4 = new DataColumn();
            this.dataTable_2 = new DataTable();
            this.dataColumn_5 = new DataColumn();
            this.dataColumn_6 = new DataColumn();
            this.dataColumn_7 = new DataColumn();
            this.dataColumn_8 = new DataColumn();
            this.tabPage_2 = new TabPage();
            this.dataGridViewExcelFilter_1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
            this.dataGridViewImageColumnNotNull_0 = new DataGridViewImageColumnNotNull();
            this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
            this.dataGridViewLinkColumn_0 = new DataGridViewLinkColumn();
            this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
            this.bindingSource_1 = new BindingSource(this.icontainer_0);
            this.toolStrip_1 = new ToolStrip();
            this.toolStripButton_4 = new ToolStripButton();
            this.toolStripButton_5 = new ToolStripButton();
            this.toolStripButton_6 = new ToolStripButton();
            this.toolStripButton_7 = new ToolStripButton();
            this.button_3 = new Button();
            this.dataSetGES_0.BeginInit();
            this.groupBox_0.SuspendLayout();
            this.toolStrip_0.SuspendLayout();
            this.groupBox_2.SuspendLayout();
            ((ISupportInitialize)this.dataGridView_0).BeginInit();
            this.groupBox_1.SuspendLayout();
            this.tabControl_0.SuspendLayout();
            this.tabPage_0.SuspendLayout();
            this.toolStrip_2.SuspendLayout();
            this.tabPage_1.SuspendLayout();
            ((ISupportInitialize)this.dataGridViewExcelFilter_0).BeginInit();
            ((ISupportInitialize)this.bindingSource_0).BeginInit();
            this.dataSet_0.BeginInit();
            this.dataTable_1.BeginInit();
            this.dataTable_2.BeginInit();
            this.tabPage_2.SuspendLayout();
            ((ISupportInitialize)this.dataGridViewExcelFilter_1).BeginInit();
            ((ISupportInitialize)this.bindingSource_1).BeginInit();
            this.toolStrip_1.SuspendLayout();
            base.SuspendLayout();
            this.dataSetGES_0.DataSetName = "DataSetGES";
            this.dataSetGES_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.label_0.AutoSize = true;
            this.label_0.Location = new Point(0x3a, 8);
            this.label_0.Name = "label1";
            this.label_0.Size = new Size(0x25, 13);
            this.label_0.TabIndex = 0;
            this.label_0.Text = "Автор";
            this.label_1.AutoSize = true;
            this.label_1.Location = new Point(0x13, 0x23);
            this.label_1.Name = "labelRequestFiled";
            this.label_1.Size = new Size(0x4c, 13);
            this.label_1.TabIndex = 4;
            this.label_1.Text = "Заявку подал";
            this.label_2.AutoSize = true;
            this.label_2.Location = new Point(0x12e, 0x23);
            this.label_2.Name = "labelSR";
            this.label_2.Size = new Size(0x26, 13);
            this.label_2.TabIndex = 6;
            this.label_2.Text = "Район";
            this.comboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox_0.DataBindings.Add(new Binding("SelectedValue", this.dataSetGES_0, "tJ_RequestForRepair.idSR", true));
            this.comboBox_0.FormattingEnabled = true;
            this.comboBox_0.Location = new Point(0x166, 0x20);
            this.comboBox_0.Name = "cmbSR";
            this.comboBox_0.Size = new Size(0xc6, 0x15);
            this.comboBox_0.TabIndex = 7;
            this.comboBox_0.SelectedIndexChanged += new EventHandler(this.comboBox_0_SelectedIndexChanged);
            this.groupBox_0.Controls.Add(this.comboBox_1);
            this.groupBox_0.Controls.Add(this.label_4);
            this.groupBox_0.Controls.Add(this.label_5);
            this.groupBox_0.Controls.Add(this.textBox_0);
            this.groupBox_0.Controls.Add(this.textBox_1);
            this.groupBox_0.Controls.Add(this.comboBox_6);
            this.groupBox_0.Controls.Add(this.label_6);
            this.groupBox_0.Controls.Add(this.label_17);
            this.groupBox_0.Location = new Point(11, 0x35);
            this.groupBox_0.Name = "groupBox1";
            this.groupBox_0.Size = new Size(0x221, 0x61);
            this.groupBox_0.TabIndex = 8;
            this.groupBox_0.TabStop = false;
            this.comboBox_1.FormattingEnabled = true;
            object[] items = new object[] { "Аварийный", "Плановый" };
            this.comboBox_1.Items.AddRange(items);
            this.comboBox_1.Location = new Point(0x65, 0x44);
            this.comboBox_1.Name = "cmbIsPlanned";
            this.comboBox_1.Size = new Size(0x79, 0x15);
            this.comboBox_1.TabIndex = 5;
            this.comboBox_1.SelectedIndexChanged += new EventHandler(this.comboBox_1_SelectedIndexChanged);
            this.label_4.AutoSize = true;
            this.label_4.Location = new Point(6, 0x47);
            this.label_4.Name = "labelIsPlanned";
            this.label_4.Size = new Size(0x59, 13);
            this.label_4.TabIndex = 4;
            this.label_4.Text = "Вид отключения";
            this.label_5.AutoSize = true;
            this.label_5.Location = new Point(6, 0x2d);
            this.label_5.Name = "labelPurpose";
            this.label_5.Size = new Size(0x21, 13);
            this.label_5.TabIndex = 3;
            this.label_5.Text = "Цель";
            this.textBox_0.DataBindings.Add(new Binding("Text", this.dataSetGES_0, "tJ_RequestForRepair.Purpose", true));
            this.textBox_0.Location = new Point(0x65, 0x2a);
            this.textBox_0.Name = "txtPurpose";
            this.textBox_0.Size = new Size(0x1b6, 20);
            this.textBox_0.TabIndex = 2;
            this.textBox_0.TextChanged += new EventHandler(this.textBox_0_TextChanged);
            this.textBox_1.DataBindings.Add(new Binding("Text", this.dataSetGES_0, "tJ_RequestForRepair.schmObj", true));
            this.textBox_1.Location = new Point(0x65, 0x10);
            this.textBox_1.Name = "txtObject";
            this.textBox_1.Size = new Size(0x1b6, 20);
            this.textBox_1.TabIndex = 1;
            this.textBox_1.TextChanged += new EventHandler(this.textBox_1_TextChanged);
            this.comboBox_6.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_6.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox_6.DataBindings.Add(new Binding("SelectedValue", this.dataSetGES_0, "tJ_RequestForRepair.idWorker", true));
            this.comboBox_6.FormattingEnabled = true;
            this.comboBox_6.Location = new Point(0x13f, 0x44);
            this.comboBox_6.Name = "cmbWorker";
            this.comboBox_6.Size = new Size(0xc6, 0x15);
            this.comboBox_6.TabIndex = 3;
            this.comboBox_6.Visible = false;
            this.comboBox_6.SelectedIndexChanged += new EventHandler(this.comboBox_6_SelectedIndexChanged);
            this.label_6.AutoSize = true;
            this.label_6.Location = new Point(6, 0x10);
            this.label_6.Name = "labelObject";
            this.label_6.Size = new Size(0x2d, 13);
            this.label_6.TabIndex = 0;
            this.label_6.Text = "Объект";
            this.label_17.AutoSize = true;
            this.label_17.Location = new Point(0xfe, 0x47);
            this.label_17.Name = "labelWorker";
            this.label_17.Size = new Size(0x38, 13);
            this.label_17.TabIndex = 15;
            this.label_17.Text = "Оператор";
            this.label_17.Visible = false;
            this.toolStrip_0.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripButton_0, this.toolStripButton_3, this.toolStripButton_1, this.toolStripButton_2 };
            this.toolStrip_0.Items.AddRange(toolStripItems);
            this.toolStrip_0.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip_0.Location = new Point(3, 3);
            this.toolStrip_0.Name = "toolStripScheme";
            this.toolStrip_0.Size = new Size(0x232, 0x19);
            this.toolStrip_0.TabIndex = 0x2f;
            this.toolStrip_0.Text = "toolStrip1";
            this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_0.Image = Resources.ElementAdd;
            this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_0.Name = "toolBtnLinkSchmObj";
            this.toolStripButton_0.Size = new Size(0x17, 0x16);
            this.toolStripButton_0.Text = "Привязать к схеме";
            this.toolStripButton_0.Click += new EventHandler(this.toolStripButton_0_Click);
            this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_3.Image = Resources.ElementEdit;
            this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_3.Name = "toolBtnLinkSchmObjEdit";
            this.toolStripButton_3.Size = new Size(0x17, 0x16);
            this.toolStripButton_3.Text = "Редактировать";
            this.toolStripButton_3.Click += new EventHandler(this.toolStripButton_3_Click);
            this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_1.Image = Resources.ElementDel;
            this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_1.Name = "toolBtnDelSchmObj";
            this.toolStripButton_1.Size = new Size(0x17, 0x16);
            this.toolStripButton_1.Text = "Удалить";
            this.toolStripButton_1.Click += new EventHandler(this.toolStripButton_1_Click);
            this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_2.Enabled = false;
            this.toolStripButton_2.Image = Resources.ElementInformation;
            this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_2.Name = "toolBtnViewSChmObj";
            this.toolStripButton_2.Size = new Size(0x17, 0x16);
            this.toolStripButton_2.Text = "Показать на схеме";
            this.toolStripButton_2.Click += new EventHandler(this.toolStripButton_2_Click);
            this.groupBox_2.Controls.Add(this.button_2);
            this.groupBox_2.Controls.Add(this.dataGridView_0);
            this.groupBox_2.Controls.Add(this.checkBox_1);
            this.groupBox_2.Controls.Add(this.checkBox_2);
            this.groupBox_2.Controls.Add(this.dateTimePicker_0);
            this.groupBox_2.Controls.Add(this.label_7);
            this.groupBox_2.Controls.Add(this.dateTimePicker_1);
            this.groupBox_2.Controls.Add(this.label_3);
            this.groupBox_2.Location = new Point(11, 0x97);
            this.groupBox_2.Name = "groupBoxDaily";
            this.groupBox_2.Size = new Size(0x221, 0x8d);
            this.groupBox_2.TabIndex = 10;
            this.groupBox_2.TabStop = false;
            this.groupBox_2.Text = "Даты отключения";
            this.button_2.Location = new Point(9, 0x73);
            this.button_2.Name = "buttonDaily";
            this.button_2.Size = new Size(0x4b, 0x17);
            this.button_2.TabIndex = 13;
            this.button_2.Text = "Добавить";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new EventHandler(this.button_2_Click);
            this.dataGridView_0.AllowUserToAddRows = false;
            this.dataGridView_0.AllowUserToResizeColumns = false;
            this.dataGridView_0.AllowUserToResizeRows = false;
            this.dataGridView_0.AutoGenerateColumns = false;
            this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_8, this.dataGridViewTextBoxColumn_9, this.dataGridViewFilterDateTimePickerColumn_0, this.dataGridViewFilterDateTimePickerColumn_1 };
            this.dataGridView_0.Columns.AddRange(dataGridViewColumns);
            this.dataGridView_0.DataMember = "tJ_RequestForRepairDaily";
            this.dataGridView_0.DataSource = this.dataSetGES_0;
            this.dataGridView_0.Location = new Point(0xb2, 8);
            this.dataGridView_0.Name = "dgvDaily";
            this.dataGridView_0.RowHeadersWidth = 30;
            this.dataGridView_0.Size = new Size(0x16f, 0x65);
            this.dataGridView_0.TabIndex = 12;
            this.dataGridView_0.VirtualMode = true;
            this.dataGridView_0.CellEndEdit += new DataGridViewCellEventHandler(this.dataGridView_0_CellEndEdit);
            this.dataGridView_0.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridView_0_CellFormatting);
            this.dataGridView_0.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(this.dataGridView_0_EditingControlShowing);
            this.dataGridView_0.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dataGridView_0_RowsAdded);
            this.dataGridView_0.RowsRemoved += new DataGridViewRowsRemovedEventHandler(this.dataGridView_0_RowsRemoved);
            this.dataGridViewTextBoxColumn_8.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_8.HeaderText = "id";
            this.dataGridViewTextBoxColumn_8.Name = "idDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_8.ReadOnly = true;
            this.dataGridViewTextBoxColumn_8.Visible = false;
            this.dataGridViewTextBoxColumn_9.DataPropertyName = "idRequest";
            this.dataGridViewTextBoxColumn_9.HeaderText = "idRequest";
            this.dataGridViewTextBoxColumn_9.Name = "idRequestDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_9.Visible = false;
            this.dataGridViewFilterDateTimePickerColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewFilterDateTimePickerColumn_0.DataPropertyName = "dateBeg";
            style.Format = "dd.MM.yyyy HH:mm";
            this.dataGridViewFilterDateTimePickerColumn_0.DefaultCellStyle = style;
            this.dataGridViewFilterDateTimePickerColumn_0.FillWeight = 50f;
            this.dataGridViewFilterDateTimePickerColumn_0.HeaderText = "Начало";
            this.dataGridViewFilterDateTimePickerColumn_0.Name = "dateBegDataGridViewTextBoxColumn";
            this.dataGridViewFilterDateTimePickerColumn_0.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterDateTimePickerColumn_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewFilterDateTimePickerColumn_1.DataPropertyName = "dateEnd";
            style2.Format = "dd.MM.yyyy HH:mm";
            this.dataGridViewFilterDateTimePickerColumn_1.DefaultCellStyle = style2;
            this.dataGridViewFilterDateTimePickerColumn_1.FillWeight = 50f;
            this.dataGridViewFilterDateTimePickerColumn_1.HeaderText = "Окончание";
            this.dataGridViewFilterDateTimePickerColumn_1.Name = "dateEndDataGridViewTextBoxColumn";
            this.dataGridViewFilterDateTimePickerColumn_1.Resizable = DataGridViewTriState.True;
            this.checkBox_1.AutoSize = true;
            this.checkBox_1.Checked = true;
            this.checkBox_1.CheckState = CheckState.Checked;
            this.checkBox_1.Enabled = false;
            this.checkBox_1.Location = new Point(9, 0x5c);
            this.checkBox_1.Name = "checkBoxWeekEnd";
            this.checkBox_1.Size = new Size(0x4e, 0x11);
            this.checkBox_1.TabIndex = 11;
            this.checkBox_1.Text = "Выходные";
            this.checkBox_1.UseVisualStyleBackColor = true;
            this.checkBox_2.AutoSize = true;
            this.checkBox_2.Location = new Point(9, 0x45);
            this.checkBox_2.Name = "checkBoxDaily";
            this.checkBox_2.Size = new Size(0x53, 0x11);
            this.checkBox_2.TabIndex = 10;
            this.checkBox_2.Text = "Ежедневно";
            this.checkBox_2.UseVisualStyleBackColor = true;
            this.checkBox_2.CheckedChanged += new EventHandler(this.checkBox_2_CheckedChanged);
            this.dateTimePicker_0.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePicker_0.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker_0.Location = new Point(30, 0x2b);
            this.dateTimePicker_0.Name = "dateTimePickerEnd";
            this.dateTimePicker_0.Size = new Size(0x7c, 20);
            this.dateTimePicker_0.TabIndex = 1;
            this.dateTimePicker_0.ValueChanged += new EventHandler(this.dateTimePicker_0_ValueChanged);
            this.label_7.AutoSize = true;
            this.label_7.Location = new Point(6, 50);
            this.label_7.Name = "label9";
            this.label_7.Size = new Size(0x13, 13);
            this.label_7.TabIndex = 9;
            this.label_7.Text = "по";
            this.dateTimePicker_1.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePicker_1.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker_1.Location = new Point(30, 0x13);
            this.dateTimePicker_1.Name = "dateTimePickerBeg";
            this.dateTimePicker_1.Size = new Size(0x7c, 20);
            this.dateTimePicker_1.TabIndex = 0;
            this.dateTimePicker_1.ValueChanged += new EventHandler(this.dateTimePicker_1_ValueChanged);
            this.label_3.AutoSize = true;
            this.label_3.Location = new Point(11, 0x16);
            this.label_3.Name = "label8";
            this.label_3.Size = new Size(13, 13);
            this.label_3.TabIndex = 8;
            this.label_3.Text = "с";
            this.nullableDateTimePicker_2.CustomFormat = ("dd.MM.yyyy HH:mm");
            this.nullableDateTimePicker_2.DataBindings.Add(new Binding("Value", this.dataSetGES_0, "tJ_RequestForRepair.dateFactEnd", true));
            this.nullableDateTimePicker_2.Format = (DateTimePickerFormat.Custom);
            this.nullableDateTimePicker_2.Location = new Point(0x93, 0x2d);
            this.nullableDateTimePicker_2.Name = "dtpFactEnd";
            this.nullableDateTimePicker_2.Size = new Size(0xe3, 20);
            this.nullableDateTimePicker_2.TabIndex = 0x11;
            this.nullableDateTimePicker_2.Value = (new DateTime(0x7df, 8, 10, 13, 0x39, 6, 0x16));
            this.label_15.AutoSize = true;
            this.label_15.Location = new Point(10, 0x33);
            this.label_15.Name = "label3";
            this.label_15.Size = new Size(0x83, 13);
            this.label_15.TabIndex = 14;
            this.label_15.Text = "Время закрытия заявки";
            this.groupBox_1.Controls.Add(this.nullableDateTimePicker_2);
            this.groupBox_1.Controls.Add(this.label_15);
            this.groupBox_1.Controls.Add(this.comboBox_5);
            this.groupBox_1.Controls.Add(this.label_16);
            this.groupBox_1.Controls.Add(this.textBox_5);
            this.groupBox_1.Controls.Add(this.comboBox_2);
            this.groupBox_1.Controls.Add(this.label_8);
            this.groupBox_1.Controls.Add(this.label_9);
            this.groupBox_1.Controls.Add(this.nullableDateTimePicker_0);
            this.groupBox_1.Controls.Add(this.checkBox_0);
            this.groupBox_1.Controls.Add(this.nullableDateTimePicker_1);
            this.groupBox_1.Controls.Add(this.label_14);
            this.groupBox_1.Controls.Add(this.label_10);
            this.groupBox_1.Controls.Add(this.label_11);
            this.groupBox_1.Controls.Add(this.label_12);
            this.groupBox_1.Controls.Add(this.textBox_2);
            this.groupBox_1.Controls.Add(this.textBox_3);
            this.groupBox_1.Location = new Point(11, 0x126);
            this.groupBox_1.Name = "groupBoxODS";
            this.groupBox_1.Size = new Size(0x221, 0x100);
            this.groupBox_1.TabIndex = 9;
            this.groupBox_1.TabStop = false;
            this.groupBox_1.VisibleChanged += new EventHandler(this.groupBox_1_VisibleChanged);
            this.comboBox_5.DataBindings.Add(new Binding("SelectedValue", this.dataSetGES_0, "tJ_RequestForRepair.status", true));
            this.comboBox_5.FormattingEnabled = true;
            this.comboBox_5.Location = new Point(0xa5, 0xe0);
            this.comboBox_5.Name = "cmbStatus";
            this.comboBox_5.Size = new Size(0x176, 0x15);
            this.comboBox_5.TabIndex = 15;
            this.label_16.AutoSize = true;
            this.label_16.Location = new Point(0x4f, 0xe3);
            this.label_16.Name = "labelStatus";
            this.label_16.Size = new Size(80, 13);
            this.label_16.TabIndex = 14;
            this.label_16.Text = "Статус заявки";
            this.textBox_5.DataBindings.Add(new Binding("Text", this.dataSetGES_0, "tJ_RequestForRepair.Address", true));
            this.textBox_5.Location = new Point(0x6a, 0x7e);
            this.textBox_5.Multiline = true;
            this.textBox_5.Name = "txtAdress";
            this.textBox_5.Size = new Size(0x1b1, 0x40);
            this.textBox_5.TabIndex = 11;
            this.comboBox_2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_2.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox_2.DataBindings.Add(new Binding("SelectedValue", this.dataSetGES_0, "tJ_RequestForRepair.WorkerAgreed", true));
            this.comboBox_2.FormattingEnabled = true;
            this.comboBox_2.Location = new Point(400, 0xc4);
            this.comboBox_2.Name = "cmbDispatcher";
            this.comboBox_2.Size = new Size(0x8b, 0x15);
            this.comboBox_2.TabIndex = 10;
            this.label_8.AutoSize = true;
            this.label_8.Location = new Point(0x13c, 0xc6);
            this.label_8.Name = "label14";
            this.label_8.Size = new Size(0x4e, 13);
            this.label_8.TabIndex = 9;
            this.label_8.Text = "Руководитель";
            this.label_9.AutoSize = true;
            this.label_9.Location = new Point(0x6c, 0xc6);
            this.label_9.Name = "label13";
            this.label_9.Size = new Size(0x21, 13);
            this.label_9.TabIndex = 8;
            this.label_9.Text = "Дата";
            this.nullableDateTimePicker_0.DataBindings.Add(new Binding("Value", this.dataSetGES_0, "tJ_RequestForRepair.DateAgreed", true));
            this.nullableDateTimePicker_0.Location = new Point(0x93, 0xc4);
            this.nullableDateTimePicker_0.Name = "dateTimePickerDateAgreed";
            this.nullableDateTimePicker_0.Size = new Size(0xa3, 20);
            this.nullableDateTimePicker_0.TabIndex = 7;
            this.nullableDateTimePicker_0.Value = (new DateTime(0x7dc, 9, 0x1a, 9, 0x3a, 0x1c, 0x3a4));
            this.checkBox_0.AutoSize = true;
            this.checkBox_0.DataBindings.Add(new Binding("Checked", this.dataSetGES_0, "tJ_RequestForRepair.Agreed", true));
            this.checkBox_0.Location = new Point(14, 0xc7);
            this.checkBox_0.Name = "checkBoxAgreed";
            this.checkBox_0.Size = new Size(0x53, 0x11);
            this.checkBox_0.TabIndex = 6;
            this.checkBox_0.Text = "Разрешено";
            this.checkBox_0.UseVisualStyleBackColor = true;
            this.checkBox_0.CheckedChanged += new EventHandler(this.checkBox_0_CheckedChanged);
            this.nullableDateTimePicker_1.CustomFormat = ("dd.MM.yyyy HH:mm");
            this.nullableDateTimePicker_1.DataBindings.Add(new Binding("Value", this.dataSetGES_0, "tJ_RequestForRepair.dateOpenRequest", true));
            this.nullableDateTimePicker_1.Format = (DateTimePickerFormat.Custom);
            this.nullableDateTimePicker_1.Location = new Point(0x93, 0x13);
            this.nullableDateTimePicker_1.Name = "dtpDateCreate";
            this.nullableDateTimePicker_1.Size = new Size(0xe3, 20);
            this.nullableDateTimePicker_1.TabIndex = 0x11;
            this.nullableDateTimePicker_1.Value = (new DateTime(0x7dc, 10, 0x12, 8, 0x27, 0x29, 0xb2));
            this.label_14.AutoSize = true;
            this.label_14.Location = new Point(11, 0x15);
            this.label_14.Name = "label2";
            this.label_14.Size = new Size(130, 13);
            this.label_14.TabIndex = 0x10;
            this.label_14.Text = "Время открытия заявки";
            this.label_10.AutoSize = true;
            this.label_10.Location = new Point(11, 0x81);
            this.label_10.Name = "label12";
            this.label_10.Size = new Size(0x2c, 13);
            this.label_10.TabIndex = 5;
            this.label_10.Text = "Адреса";
            this.label_11.AutoSize = true;
            this.label_11.Location = new Point(11, 0x67);
            this.label_11.Name = "label11";
            this.label_11.Size = new Size(0x4d, 13);
            this.label_11.TabIndex = 4;
            this.label_11.Text = "Комментарий";
            this.label_12.AutoSize = true;
            this.label_12.Location = new Point(11, 0x4d);
            this.label_12.Name = "label10";
            this.label_12.Size = new Size(0x51, 13);
            this.label_12.TabIndex = 3;
            this.label_12.Text = "Согласовать с";
            this.textBox_2.DataBindings.Add(new Binding("Text", this.dataSetGES_0, "tJ_RequestForRepair.Comment", true));
            this.textBox_2.Location = new Point(0x6a, 100);
            this.textBox_2.Name = "txtComment";
            this.textBox_2.Size = new Size(0x1b1, 20);
            this.textBox_2.TabIndex = 1;
            this.textBox_3.DataBindings.Add(new Binding("Text", this.dataSetGES_0, "tJ_RequestForRepair.AgreeWith", true));
            this.textBox_3.Location = new Point(0x6a, 0x4a);
            this.textBox_3.Name = "txtAgreeWith";
            this.textBox_3.Size = new Size(0x1b1, 20);
            this.textBox_3.TabIndex = 0;
            this.button_0.DialogResult = DialogResult.OK;
            this.button_0.Location = new Point(15, 0x24b);
            this.button_0.Name = "buttonOK";
            this.button_0.Size = new Size(0x4b, 0x17);
            this.button_0.TabIndex = 10;
            this.button_0.Text = "ОК";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new EventHandler(this.button_0_Click);
            this.button_1.DialogResult = DialogResult.Cancel;
            this.button_1.Location = new Point(0x1e5, 0x24b);
            this.button_1.Name = "buttonCancel";
            this.button_1.Size = new Size(0x4b, 0x17);
            this.button_1.TabIndex = 11;
            this.button_1.Text = "Отмена";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new EventHandler(this.button_1_Click);
            this.comboBox_3.DataBindings.Add(new Binding("SelectedValue", this.dataSetGES_0, "tJ_RequestForRepair.idUserCreate", true));
            this.comboBox_3.Enabled = false;
            this.comboBox_3.FormattingEnabled = true;
            this.comboBox_3.Location = new Point(0x65, 5);
            this.comboBox_3.Name = "cmbUserCreate";
            this.comboBox_3.Size = new Size(0xb5, 0x15);
            this.comboBox_3.TabIndex = 12;
            this.label_13.AutoSize = true;
            this.label_13.Location = new Point(0x12e, 8);
            this.label_13.Name = "label15";
            this.label_13.Size = new Size(0x29, 13);
            this.label_13.TabIndex = 13;
            this.label_13.Text = "Номер";
            this.textBox_4.DataBindings.Add(new Binding("Text", this.dataSetGES_0, "tJ_RequestForRepair.num", true));
            this.textBox_4.Location = new Point(0x166, 5);
            this.textBox_4.Name = "txtNum";
            this.textBox_4.ReadOnly = true;
            this.textBox_4.Size = new Size(0xc6, 20);
            this.textBox_4.TabIndex = 14;
            this.tabControl_0.Controls.Add(this.tabPage_0);
            this.tabControl_0.Controls.Add(this.tabPage_1);
            this.tabControl_0.Controls.Add(this.tabPage_2);
            this.tabControl_0.Location = new Point(0, 0);
            this.tabControl_0.Name = "tabControl";
            this.tabControl_0.SelectedIndex = 0;
            this.tabControl_0.Size = new Size(0x240, 0x245);
            this.tabControl_0.TabIndex = 0x31;
            this.tabPage_0.Controls.Add(this.comboBox_4);
            this.tabPage_0.Controls.Add(this.toolStrip_2);
            this.tabPage_0.Controls.Add(this.comboBox_0);
            this.tabPage_0.Controls.Add(this.label_0);
            this.tabPage_0.Controls.Add(this.groupBox_2);
            this.tabPage_0.Controls.Add(this.label_1);
            this.tabPage_0.Controls.Add(this.groupBox_1);
            this.tabPage_0.Controls.Add(this.groupBox_0);
            this.tabPage_0.Controls.Add(this.label_2);
            this.tabPage_0.Controls.Add(this.comboBox_3);
            this.tabPage_0.Controls.Add(this.textBox_4);
            this.tabPage_0.Controls.Add(this.label_13);
            this.tabPage_0.Location = new Point(4, 0x16);
            this.tabPage_0.Name = "tabPageGeneral";
            this.tabPage_0.Padding = new Padding(3);
            this.tabPage_0.Size = new Size(0x238, 0x22b);
            this.tabPage_0.TabIndex = 0;
            this.tabPage_0.Text = "Общие";
            this.tabPage_0.UseVisualStyleBackColor = true;
            this.comboBox_4.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_4.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox_4.DataBindings.Add(new Binding("Text", this.dataSetGES_0, "tJ_RequestForRepair.reguestFiled", true));
            this.comboBox_4.FormattingEnabled = true;
            this.comboBox_4.Location = new Point(0x65, 0x20);
            this.comboBox_4.Name = "txtRequestFiled";
            this.comboBox_4.Size = new Size(0xb5, 0x15);
            this.comboBox_4.TabIndex = 0x13;
            this.toolStrip_2.Dock = DockStyle.None;
            this.toolStrip_2.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.toolStripButton_8 };
            this.toolStrip_2.Items.AddRange(itemArray2);
            this.toolStrip_2.Location = new Point(0, 0);
            this.toolStrip_2.Name = "toolStripMain";
            this.toolStrip_2.Size = new Size(0x1a, 0x19);
            this.toolStrip_2.TabIndex = 0x12;
            this.toolStrip_2.Text = "toolStrip1";
            this.toolStripButton_8.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_8.Image = Resources.CopyBuffer;
            this.toolStripButton_8.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_8.Name = "toolBtnCopy";
            this.toolStripButton_8.Size = new Size(0x17, 0x16);
            this.toolStripButton_8.Text = "Копировать";
            this.toolStripButton_8.Click += new EventHandler(this.button_3_Click);
            this.tabPage_1.Controls.Add(this.dataGridViewExcelFilter_0);
            this.tabPage_1.Controls.Add(this.toolStrip_0);
            this.tabPage_1.Location = new Point(4, 0x16);
            this.tabPage_1.Name = "tabPageSwitching";
            this.tabPage_1.Padding = new Padding(3);
            this.tabPage_1.Size = new Size(0x238, 0x22b);
            this.tabPage_1.TabIndex = 1;
            this.tabPage_1.Text = "Оперативные переключения";
            this.tabPage_1.UseVisualStyleBackColor = true;
            this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToOrderColumns = true;
            this.dataGridViewExcelFilter_0.AllowUserToVisibleColumns = (false);
            this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
            this.dataGridViewExcelFilter_0.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray2 = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_0, this.dataGridViewTextBoxColumn_1, this.dataGridViewTextBoxColumn_2, this.dataGridViewTextBoxColumn_3, this.dataGridViewTextBoxColumn_4 };
            this.dataGridViewExcelFilter_0.Columns.AddRange(columnArray2);
            this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
            this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_0.Location = new Point(3, 0x1c);
            this.dataGridViewExcelFilter_0.Name = "dgvLinkObjects";
            this.dataGridViewExcelFilter_0.ReadOnly = true;
            this.dataGridViewExcelFilter_0.RowHeadersWidth = 0x15;
            this.dataGridViewExcelFilter_0.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewExcelFilter_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExcelFilter_0.Size = new Size(0x232, 0x20c);
            this.dataGridViewExcelFilter_0.TabIndex = 0x31;
            this.dataGridViewExcelFilter_0.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_0_CellDoubleClick);
            this.dataGridViewTextBoxColumn_0.DataPropertyName = "Objects";
            style3.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_0.DefaultCellStyle = style3;
            this.dataGridViewTextBoxColumn_0.HeaderText = "Объекты";
            this.dataGridViewTextBoxColumn_0.Name = "objectsDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewTextBoxColumn_0.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_0.Width = 250;
            this.dataGridViewTextBoxColumn_1.DataPropertyName = "DateBeg";
            this.dataGridViewTextBoxColumn_1.HeaderText = "Начало";
            this.dataGridViewTextBoxColumn_1.Name = "dateBegDataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn_1.ReadOnly = true;
            this.dataGridViewTextBoxColumn_1.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_1.Width = 90;
            this.dataGridViewTextBoxColumn_2.DataPropertyName = "DateEnd";
            this.dataGridViewTextBoxColumn_2.HeaderText = "Окончание";
            this.dataGridViewTextBoxColumn_2.Name = "dateEndDataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn_2.ReadOnly = true;
            this.dataGridViewTextBoxColumn_2.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_2.Width = 90;
            this.dataGridViewTextBoxColumn_3.DataPropertyName = "Duration";
            this.dataGridViewTextBoxColumn_3.HeaderText = "Длительность";
            this.dataGridViewTextBoxColumn_3.Name = "durationDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_3.ReadOnly = true;
            this.dataGridViewTextBoxColumn_3.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_3.Width = 90;
            this.dataGridViewTextBoxColumn_4.DataPropertyName = "Num";
            this.dataGridViewTextBoxColumn_4.HeaderText = "Num";
            this.dataGridViewTextBoxColumn_4.Name = "numDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_4.ReadOnly = true;
            this.dataGridViewTextBoxColumn_4.Visible = false;
            this.bindingSource_0.DataMember = "tableLinkObjects";
            this.bindingSource_0.DataSource = this.dataSet_0;
            this.bindingSource_0.Sort = "Num";
            this.dataSet_0.DataSetName = "NewDataSet";
            DataTable[] tables = new DataTable[] { this.dataTable_1, this.dataTable_2 };
            this.dataSet_0.Tables.AddRange(tables);
            DataColumn[] columns = new DataColumn[] { this.dataColumn_0, this.dataColumn_1, this.dataColumn_2, this.dataColumn_3, this.dataColumn_4 };
            this.dataTable_1.Columns.AddRange(columns);
            this.dataTable_1.TableName = "tableLinkObjects";
            this.dataColumn_0.ColumnName = "Objects";
            this.dataColumn_1.ColumnName = "DateBeg";
            this.dataColumn_1.DataType = typeof(DateTime);
            this.dataColumn_2.ColumnName = "DateEnd";
            this.dataColumn_2.DataType = typeof(DateTime);
            this.dataColumn_3.ColumnName = "Duration";
            this.dataColumn_4.ColumnName = "Num";
            this.dataColumn_4.DataType = typeof(short);
            DataColumn[] columnArray4 = new DataColumn[] { this.dataColumn_5, this.dataColumn_6, this.dataColumn_7, this.dataColumn_8 };
            this.dataTable_2.Columns.AddRange(columnArray4);
            Constraint[] constraints = new Constraint[1];
            string[] columnNames = new string[] { "id" };
            constraints[0] = new UniqueConstraint("Constraint1", columnNames, true);
            this.dataTable_2.Constraints.AddRange(constraints);
            this.dataTable_2.PrimaryKey = new DataColumn[] { this.dataColumn_5 };
            this.dataTable_2.TableName = "tJ_RequestForReapirDoc";
            this.dataColumn_5.AllowDBNull = false;
            this.dataColumn_5.AutoIncrement = true;
            this.dataColumn_5.ColumnName = "id";
            this.dataColumn_5.DataType = typeof(int);
            this.dataColumn_6.AllowDBNull = false;
            this.dataColumn_6.ColumnName = "idRequest";
            this.dataColumn_6.DataType = typeof(int);
            this.dataColumn_7.ColumnName = "FileName";
            this.dataColumn_8.ColumnName = "Comment";
            this.tabPage_2.Controls.Add(this.dataGridViewExcelFilter_1);
            this.tabPage_2.Controls.Add(this.toolStrip_1);
            this.tabPage_2.Location = new Point(4, 0x16);
            this.tabPage_2.Name = "tabPageDocuments";
            this.tabPage_2.Padding = new Padding(3);
            this.tabPage_2.Size = new Size(0x238, 0x22b);
            this.tabPage_2.TabIndex = 2;
            this.tabPage_2.Text = "Документы";
            this.tabPage_2.UseVisualStyleBackColor = true;
            this.dataGridViewExcelFilter_1.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_1.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_1.AutoGenerateColumns = false;
            this.dataGridViewExcelFilter_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray6 = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_5, this.dataGridViewImageColumnNotNull_0, this.dataGridViewTextBoxColumn_6, this.dataGridViewLinkColumn_0, this.dataGridViewTextBoxColumn_7 };
            this.dataGridViewExcelFilter_1.Columns.AddRange(columnArray6);
            this.dataGridViewExcelFilter_1.DataSource = this.bindingSource_1;
            this.dataGridViewExcelFilter_1.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_1.Location = new Point(3, 0x1c);
            this.dataGridViewExcelFilter_1.Name = "dgvDocs";
            this.dataGridViewExcelFilter_1.RowHeadersWidth = 0x15;
            this.dataGridViewExcelFilter_1.Size = new Size(0x232, 0x20c);
            this.dataGridViewExcelFilter_1.TabIndex = 1;
            this.dataGridViewExcelFilter_1.VirtualMode = true;
            this.dataGridViewExcelFilter_1.CellContentClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_1_CellContentClick);
            this.dataGridViewExcelFilter_1.CellValueNeeded += new DataGridViewCellValueEventHandler(this.dataGridViewExcelFilter_1_CellValueNeeded);
            this.dataGridViewTextBoxColumn_5.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_5.HeaderText = "id";
            this.dataGridViewTextBoxColumn_5.Name = "idDataGridViewTextBoxColumnDoc";
            this.dataGridViewTextBoxColumn_5.ReadOnly = true;
            this.dataGridViewTextBoxColumn_5.Visible = false;
            style4.NullValue = null;
            this.dataGridViewImageColumnNotNull_0.DefaultCellStyle = style4;
            this.dataGridViewImageColumnNotNull_0.HeaderText = "";
            this.dataGridViewImageColumnNotNull_0.Name = "ColumnImage";
            this.dataGridViewImageColumnNotNull_0.ReadOnly = true;
            this.dataGridViewImageColumnNotNull_0.Resizable = DataGridViewTriState.False;
            this.dataGridViewImageColumnNotNull_0.Width = 30;
            this.dataGridViewTextBoxColumn_6.DataPropertyName = "idRequest";
            this.dataGridViewTextBoxColumn_6.HeaderText = "idRequest";
            this.dataGridViewTextBoxColumn_6.Name = "idRequestDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_6.Visible = false;
            this.dataGridViewLinkColumn_0.DataPropertyName = "FileName";
            this.dataGridViewLinkColumn_0.HeaderText = "Файл";
            this.dataGridViewLinkColumn_0.Name = "fileNameDataGridViewTextBoxColumn";
            this.dataGridViewLinkColumn_0.ReadOnly = true;
            this.dataGridViewLinkColumn_0.Resizable = DataGridViewTriState.True;
            this.dataGridViewLinkColumn_0.SortMode = DataGridViewColumnSortMode.Automatic;
            this.dataGridViewLinkColumn_0.Width = 200;
            this.dataGridViewTextBoxColumn_7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_7.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn_7.HeaderText = "Комментарий";
            this.dataGridViewTextBoxColumn_7.Name = "commentDataGridViewTextBoxColumn";
            this.bindingSource_1.DataMember = "tJ_RequestForRepairDoc";
            this.bindingSource_1.DataSource = this.dataSetGES_0;
            ToolStripItem[] itemArray3 = new ToolStripItem[] { this.toolStripButton_4, this.toolStripButton_5, this.toolStripButton_6, this.toolStripButton_7 };
            this.toolStrip_1.Items.AddRange(itemArray3);
            this.toolStrip_1.Location = new Point(3, 3);
            this.toolStrip_1.Name = "toolStripDocuments";
            this.toolStrip_1.Size = new Size(0x232, 0x19);
            this.toolStrip_1.TabIndex = 0;
            this.toolStrip_1.Text = "toolStrip1";
            this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_4.Image = Resources.ElementAdd;
            this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_4.Name = "toolBtnAddDoc";
            this.toolStripButton_4.Size = new Size(0x17, 0x16);
            this.toolStripButton_4.Text = "Добавить документ";
            this.toolStripButton_4.Click += new EventHandler(this.toolStripButton_4_Click);
            this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_5.Image = Resources.ElementDel;
            this.toolStripButton_5.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_5.Name = "toolBtnDelDoc";
            this.toolStripButton_5.Size = new Size(0x17, 0x16);
            this.toolStripButton_5.Text = "Удалить документ";
            this.toolStripButton_5.Click += new EventHandler(this.toolStripButton_5_Click);
            this.toolStripButton_6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_6.Image = Resources.ElementInformation;
            this.toolStripButton_6.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_6.Name = "toolBtnViewDoc";
            this.toolStripButton_6.Size = new Size(0x17, 0x16);
            this.toolStripButton_6.Text = "Открыть документ";
            this.toolStripButton_6.Click += new EventHandler(this.toolStripButton_6_Click);
            this.toolStripButton_7.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_7.Image = Resources.ElementGo;
            this.toolStripButton_7.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_7.Name = "toolBtnSaveDoc";
            this.toolStripButton_7.Size = new Size(0x17, 0x16);
            this.toolStripButton_7.Text = "Сохранить документ";
            this.toolStripButton_7.Click += new EventHandler(this.toolStripButton_7_Click);
            this.button_3.Location = new Point(240, 0x24b);
            this.button_3.Name = "buttonCopy";
            this.button_3.Size = new Size(0x4b, 0x17);
            this.button_3.TabIndex = 50;
            this.button_3.Text = "Копировать";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Visible = false;
            this.button_3.Click += new EventHandler(this.button_3_Click);
            base.AcceptButton = this.button_0;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.CancelButton = this.button_1;
            base.ClientSize = new Size(0x23c, 0x26b);
            base.Controls.Add(this.button_3);
            base.Controls.Add(this.tabControl_0);
            base.Controls.Add(this.button_1);
            base.Controls.Add(this.button_0);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.MaximizeBox = false;
            base.Name = "FormJournalRequestForRepairAddEdit";
            this.Text = "FormJournalRequestForRepairAddEdit";
            base.FormClosing += new FormClosingEventHandler(this.Form43_FormClosing);
            base.FormClosed += new FormClosedEventHandler(this.Form43_FormClosed);
            base.Load += new EventHandler(this.Form43_Load);
            this.dataSetGES_0.EndInit();
            this.groupBox_0.ResumeLayout(false);
            this.groupBox_0.PerformLayout();
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            this.groupBox_2.ResumeLayout(false);
            this.groupBox_2.PerformLayout();
            ((ISupportInitialize)this.dataGridView_0).EndInit();
            this.groupBox_1.ResumeLayout(false);
            this.groupBox_1.PerformLayout();
            this.tabControl_0.ResumeLayout(false);
            this.tabPage_0.ResumeLayout(false);
            this.tabPage_0.PerformLayout();
            this.toolStrip_2.ResumeLayout(false);
            this.toolStrip_2.PerformLayout();
            this.tabPage_1.ResumeLayout(false);
            this.tabPage_1.PerformLayout();
            ((ISupportInitialize)this.dataGridViewExcelFilter_0).EndInit();
            ((ISupportInitialize)this.bindingSource_0).EndInit();
            this.dataSet_0.EndInit();
            this.dataTable_1.EndInit();
            this.dataTable_2.EndInit();
            this.tabPage_2.ResumeLayout(false);
            this.tabPage_2.PerformLayout();
            ((ISupportInitialize)this.dataGridViewExcelFilter_1).EndInit();
            ((ISupportInitialize)this.bindingSource_1).EndInit();
            this.toolStrip_1.ResumeLayout(false);
            this.toolStrip_1.PerformLayout();
            base.ResumeLayout(false);
        }

        private DataTable method_2()
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
            DataColumn column4 = new DataColumn("GroupRoman", Type.GetType("System.String"))
            {
                Expression = "IIF(groupElectrical = 1, 'I', IIF(groupElectrical = 2, 'II', IIF(groupelectrical=3, 'III', IIF(groupelectrical = 4, 'IV', iif(groupelectrical = 5, 'V', '')))))"
            };
            table.Columns.Add(column4);
            return table;
        }

        private DataTable method_3()
        {
            Type dataType = Type.GetType("System.Int32");
            DataTable table = new DataTable("tUser");
            DataColumn column = new DataColumn("idUser", dataType);
            table.Columns.Add(column);
            DataColumn column2 = new DataColumn("idWorker", dataType);
            table.Columns.Add(column2);
            DataColumn column3 = new DataColumn("name", Type.GetType("System.String"));
            table.Columns.Add(column3);
            table.PrimaryKey = new DataColumn[] { column };
            return table;
        }

        private void method_4()
        {
            DataTable table = this.method_3();
            base.SelectSqlData(table, true, " order by name ");
            this.comboBox_3.DataSource = table;
            this.comboBox_3.DisplayMember = "NAME";
            this.comboBox_3.ValueMember = "IDUSER";
            DataTable table2 = this.method_2();
            base.SelectSqlData(table2, true, " where ParentKey in (';GroupWorker;ITR;')  and dateend is null group by id, fio, groupelectrical order by fio ");
            this.comboBox_6.DataSource = table2;
            this.comboBox_6.DisplayMember = "FIO";
            this.comboBox_6.ValueMember = "ID";
            this.comboBox_4.DataSource = table2;
            this.comboBox_4.DisplayMember = "FIO";
            this.comboBox_4.ValueMember = "ID";
            DataTable table3 = this.method_2();
            base.SelectSqlData(table3, true, " where ParentKey in (';GroupWorker;ReconcileRequestRepair;')  and dateend is null group by id, fio, groupelectrical order by fio ");
            this.comboBox_2.DataSource = table3;
            this.comboBox_2.DisplayMember = "FIO";
            this.comboBox_2.ValueMember = "ID";
            base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tR_Classifier, true, " where ParentKey = ';NetworkAreas;' and deleted = 0 and isGroup = 0 order by name ");
            this.comboBox_0.DataSource = this.dataSetGES_0.tR_Classifier;
            this.comboBox_0.DisplayMember = "name";
            this.comboBox_0.ValueMember = "ID";
        }

        private void method_5()
        {
            this.dataTable_0 = new DataTable("tR_RequestForRepairClient");
            base.SelectSqlData(this.dataTable_0, true, "where type = 5 order by name");
            DataTable table = new DataTable("tR_RequestForRepairClient");
            table.Columns.Add("name", typeof(string));
            table.Columns.Add("value", typeof(int));
            this.comboBox_5.DataSource = table;
            this.comboBox_5.DisplayMember = "Name";
            this.comboBox_5.ValueMember = "Value";
            if (table.Rows.Count == 0)
            {
                foreach (DataRow row in this.dataTable_0.Rows)
                {
                    object[] values = new object[] { row["name"], row["Value"] };
                    table.Rows.Add(values);
                }
            }
        }

        private bool method_6()
        {
            bool flag = true;
            if (string.IsNullOrEmpty(this.comboBox_4.Text))
            {
                this.label_1.ForeColor = Color.Red;
                flag = false;
            }
            if (this.comboBox_0.SelectedIndex < 0)
            {
                this.label_2.ForeColor = Color.Red;
                flag = false;
            }
            if (string.IsNullOrEmpty(this.textBox_1.Text))
            {
                this.label_6.ForeColor = Color.Red;
                flag = false;
            }
            if (string.IsNullOrEmpty(this.textBox_0.Text))
            {
                this.label_5.ForeColor = Color.Red;
                flag = false;
            }
            if (this.comboBox_1.SelectedIndex < 0)
            {
                this.label_4.ForeColor = Color.Red;
                flag = false;
            }
            if (this.dataSetGES_0.tJ_RequestForRepairDaily.Rows.Count <= 0)
            {
                List<Color> list = new List<Color>();
                foreach (Control control in this.groupBox_2.Controls)
                {
                    list.Add(control.ForeColor);
                }
                this.groupBox_2.ForeColor = Color.Red;
                int num = 0;
                using (IEnumerator enumerator = groupBox_2.Controls.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        ((Control)enumerator.Current).ForeColor = list[num];
                        num++;
                    }
                }
                flag = false;
            }
            if ((this.checkBox_0.Checked && (this.int_1 == 920)) && (this.comboBox_5.SelectedIndex < 0))
            {
                this.label_16.ForeColor = Color.Red;
                flag = false;
            }
            return flag;
        }

        private void method_7(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.comboBox_4.Text))
            {
                this.label_1.ForeColor = SystemColors.ControlText;
            }
        }

        private void method_8()
        {
            this.dataSet_0.Tables[this.dataTable_1.TableName].Clear();
            if (this.dataSetGES_0.tL_RequestForRepairSchmObjList.Rows.Count > 0)
            {
                DataRow row3;
                DataView defaultView = this.dataSetGES_0.tL_RequestForRepairSchmObjList.DefaultView;
                defaultView.Sort = "Num";
                int num = 0;
                List<string> list = new List<string>();
                DateTime now = DateTime.Now;
                DateTime time2 = DateTime.Now;
                string str = "";
                foreach (DataRow row in defaultView.ToTable().Rows)
                {
                    if (num == Convert.ToInt16(row["num"]))
                    {
                        string[] textArray1 = new string[] { row["idSchmObj"].ToString() };
                        list.Add(base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", textArray1).ToString());
                    }
                    else
                    {
                        if (list.Count > 0)
                        {
                            list.Sort();
                            DataRow row2 = this.dataSet_0.Tables[this.dataTable_1.TableName].NewRow();
                            row2["Objects"] = "";
                            foreach (string str2 in list)
                            {
                                row3 = row2;
                                row3["Objects"] = row3["Objects"] + str2 + "\n";
                            }
                            row2["Objects"] = ((string)row2["Objects"]).Remove(row2["Objects"].ToString().Length - 1);
                            row2["DateBeg"] = now;
                            row2["DateEnd"] = time2;
                            row2["Duration"] = str;
                            row2["Num"] = num;
                            this.dataSet_0.Tables[this.dataTable_1.TableName].Rows.Add(row2);
                        }
                        list = new List<string>();
                        string[] textArray2 = new string[] { row["idSchmObj"].ToString() };
                        list.Add(base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", textArray2).ToString());
                        now = Convert.ToDateTime(row["DateBeg"]);
                        time2 = Convert.ToDateTime(row["DateEnd"]);
                        str = row["Duration"].ToString();
                        num = Convert.ToInt16(row["Num"]);
                    }
                }
                if (list.Count > 0)
                {
                    list.Sort();
                    DataRow row4 = this.dataSet_0.Tables[this.dataTable_1.TableName].NewRow();
                    row4["Objects"] = "";
                    foreach (string str3 in list)
                    {
                        row3 = row4;
                        row3["Objects"] = row3["Objects"] + str3 + "\n";
                    }
                    row4["Objects"] = ((string)row4["Objects"]).Remove(row4["Objects"].ToString().Length - 1);
                    row4["DateBeg"] = now;
                    row4["DateEnd"] = time2;
                    row4["Duration"] = str;
                    row4["Num"] = num;
                    this.dataSet_0.Tables[this.dataTable_1.TableName].Rows.Add(row4);
                }
                if (this.dataSet_0.Tables[this.dataTable_1.TableName].Rows.Count > 0)
                {
                    this.toolStripButton_2.Enabled = true;
                }
                else
                {
                    this.toolStripButton_2.Enabled = false;
                }
            }
        }

        private void method_9()
        {
            base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tL_RequestForRepairSchmObjList, true, " where idRequest = " + this.int_0.ToString());
            this.method_8();
        }

        private void textBox_0_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.textBox_0.Text))
            {
                this.label_6.ForeColor = SystemColors.ControlText;
            }
        }

        private void textBox_1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.textBox_1.Text))
            {
                this.label_6.ForeColor = SystemColors.ControlText;
            }
        }

        private void toolStripButton_0_Click(object sender, EventArgs e)
        {
            FormLinkRequestAndSchm schm = new FormLinkRequestAndSchm();
            schm.SqlSettings = (this.SqlSettings);
            if (schm.ShowDialog() == DialogResult.OK)
            {
                int num = 1;
                if (this.dataSetGES_0.tL_RequestForRepairSchmObjList.Rows.Count > 0)
                {
                    num = this.dataSetGES_0.tL_RequestForRepairSchmObjList.Max<DataSetGES.Class53, short>((C_1.C_9__42_0 ?? (C_1.C_9__42_0 = new Func<DataSetGES.Class53, short>(C_1.C_9.method_7)))) + 1;
                }
                this.dictionary_0 = schm.LinkObjects;
                foreach (int num2 in this.dictionary_0.Keys)
                {
                    DataRow row = this.dataSetGES_0.tL_RequestForRepairSchmObjList.NewRow();
                    row["idRequest"] = this.int_0;
                    row["idSchmObj"] = num2;
                    row["DAteBeg"] = schm.DateBeg;
                    row["DAteEnd"] = schm.DateEnd;
                    row["duration"] = schm.Duration;
                    row["num"] = num;
                    this.dataSetGES_0.tL_RequestForRepairSchmObjList.Rows.Add(row);
                }
                this.method_8();
            }
        }

        private void toolStripButton_1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridViewExcelFilter_0.SelectedRows)
            {
                DataRow[] rowArray = this.dataSetGES_0.tL_RequestForRepairSchmObjList.Select("num = " + row.Cells[this.dataGridViewTextBoxColumn_4.Name].Value.ToString());
                for (int i = 0; i < rowArray.Length; i++)
                {
                    rowArray[i].Delete();
                }
            }
            this.method_8();
        }

        private void toolStripButton_2_Click(object sender, EventArgs e)
        {
            this.dictionary_0.Clear();
            foreach (DataGridViewRow row in this.dataGridViewExcelFilter_0.SelectedRows)
            {
                foreach (DataRow row2 in this.dataSetGES_0.tL_RequestForRepairSchmObjList.Select("num = " + row.Cells[this.dataGridViewTextBoxColumn_4.Name].Value.ToString()))
                {
                    if (!this.dictionary_0.ContainsKey(Convert.ToInt32(row2["idSchmObj"])))
                    {
                        this.dictionary_0.Add(Convert.ToInt32(row2["idSchmObj"]), "");
                    }
                }
            }
            GoToSchemaEventArgs args = new GoToSchemaEventArgs(this.dictionary_0.Keys.ToList<int>());
            this.OnGoToSchema(args);
        }

        private void toolStripButton_3_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_0.CurrentRow != null)
            {
                DataRow[] rowArray = this.dataSetGES_0.tL_RequestForRepairSchmObjList.Select("num = " + this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_4.Name].Value.ToString());
                this.dictionary_0.Clear();
                if (rowArray.Length != 0)
                {
                    FormLinkRequestAndSchm schm = new FormLinkRequestAndSchm();
                    schm.SqlSettings = (this.SqlSettings);
                    schm.DateBeg = Convert.ToDateTime(rowArray[0]["dateBeg"]);
                    schm.DateEnd = Convert.ToDateTime(rowArray[0]["dateEnd"]);
                    schm.Duration = rowArray[0]["Duration"].ToString();
                    schm.Num = Convert.ToInt16(rowArray[0]["Num"]);
                    foreach (DataRow row in rowArray)
                    {
                        string[] textArray1 = new string[] { row["idSchmObj"].ToString() };
                        this.dictionary_0.Add(Convert.ToInt32(row["idSchmObj"]), base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", textArray1).ToString());
                    }
                    schm.LinkObjects = this.dictionary_0;
                    if (schm.ShowDialog() == DialogResult.OK)
                    {
                        this.dictionary_0 = schm.LinkObjects;
                        foreach (DataRow row2 in rowArray)
                        {
                            if (this.dictionary_0.ContainsKey(Convert.ToInt32(row2["idSchmObj"])))
                            {
                                row2["DAteBeg"] = schm.DateBeg;
                                row2["DAteEnd"] = schm.DateEnd;
                                row2["duration"] = schm.Duration;
                                this.dictionary_0.Remove(Convert.ToInt32(row2["idSchmObj"]));
                            }
                            else
                            {
                                row2.Delete();
                            }
                        }
                        foreach (int num2 in this.dictionary_0.Keys)
                        {
                            DataRow row3 = this.dataSetGES_0.tL_RequestForRepairSchmObjList.NewRow();
                            row3["idRequest"] = this.int_0;
                            row3["idSchmObj"] = num2;
                            row3["DAteBeg"] = schm.DateBeg;
                            row3["DAteEnd"] = schm.DateEnd;
                            row3["duration"] = schm.Duration;
                            row3["num"] = schm.Num;
                            this.dataSetGES_0.tL_RequestForRepairSchmObjList.Rows.Add(row3);
                        }
                        this.method_8();
                    }
                }
            }
        }

        private void toolStripButton_4_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog
                {
                    Multiselect = true
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    for (int i = 0; i < dialog.FileNames.Length; i++)
                    {
                        DataRow row = this.dataSetGES_0.tJ_RequestForRepairDoc.NewRow();
                        row["idRequest"] = this.int_0;
                        row["Document"] = File.ReadAllBytes(dialog.FileNames[i]);
                        row["FileName"] = Path.GetFileName(dialog.FileNames[i]);
                        this.dataSetGES_0.tJ_RequestForRepairDoc.Rows.Add(row);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source);
            }
        }

        private void toolStripButton_5_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_1.CurrentRow != null)
            {
                Convert.ToInt32(this.dataGridViewExcelFilter_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_5.Name].Value);
                this.dataGridViewExcelFilter_1.Rows.Remove(this.dataGridViewExcelFilter_1.CurrentRow);
            }
            else
            {
                MessageBox.Show("Не выбрано ни одного файла");
            }
        }

        private void toolStripButton_6_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_1.CurrentRow != null)
            {
                int num = Convert.ToInt32(this.dataGridViewExcelFilter_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_5.Name].Value);
                byte[] buffer = (byte[])this.dataSetGES_0.tJ_RequestForRepairDoc.method_2(num)["Document"];
                string path = Path.ChangeExtension(Path.GetTempFileName(), Path.GetExtension(this.dataSetGES_0.tJ_RequestForRepairDoc.method_2(num)["FileName"].ToString()));
                FileStream stream1 = File.Create(path);
                stream1.Write(buffer, 0, buffer.Length);
                stream1.Close();
                new Process
                {
                    StartInfo = {
                FileName = path,
                UseShellExecute = true
            }
                }.Start();
            }
        }

        private void toolStripButton_7_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(this.dataGridViewExcelFilter_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_5.Name].Value);
                string path = this.dataGridViewExcelFilter_1.CurrentRow.Cells[this.dataGridViewLinkColumn_0.Name].Value.ToString();
                string extension = Path.GetExtension(path);
                SaveFileDialog dialog = new SaveFileDialog
                {
                    Filter = "(*" + extension + ")|*" + extension,
                    FileName = path
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    byte[] buffer = (byte[])this.dataSetGES_0.tJ_RequestForRepairDoc.method_2(num)["Document"];
                    FileStream stream1 = File.Create(dialog.FileName);
                    stream1.Write(buffer, 0, buffer.Length);
                    stream1.Close();
                    MessageBox.Show("Файл успешно сохранен", "Сохранение");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source);
            }
        }

        [Serializable, CompilerGenerated]
        private sealed class C_1
        {
            public static readonly FormJournalRequestForRepairAddEdit.C_1 C_9 = new FormJournalRequestForRepairAddEdit.C_1();
            public static Func<DataSetGES.Class51, bool> C_9__27_0;
            public static Func<DataSetGES.Class51, DateTime> C_9__27_1;
            public static Func<DataSetGES.Class51, bool> C_9__28_0;
            public static Func<DataSetGES.Class51, bool> C_9__28_1;
            public static Func<DataSetGES.Class51, DateTime> C_9__28_2;
            public static Func<DataSetGES.Class51, bool> C_9__32_0;
            public static Func<DataSetGES.Class51, DateTime> C_9__32_1;
            public static Func<DataSetGES.Class53, short> C_9__42_0;

            internal bool method_0(DataSetGES.Class51 class51_0)
            {
                return ((class51_0.RowState != DataRowState.Deleted) && (class51_0.RowState != DataRowState.Detached));
            }

            internal DateTime method_1(DataSetGES.Class51 class51_0)
            {
                return class51_0.dateEnd;
            }

            internal bool method_2(DataSetGES.Class51 class51_0)
            {
                return ((class51_0.RowState != DataRowState.Deleted) && (class51_0.RowState != DataRowState.Detached));
            }

            internal bool method_3(DataSetGES.Class51 class51_0)
            {
                return ((class51_0.RowState != DataRowState.Deleted) && (class51_0.RowState != DataRowState.Detached));
            }

            internal DateTime method_4(DataSetGES.Class51 class51_0)
            {
                return class51_0.dateEnd;
            }

            internal bool method_5(DataSetGES.Class51 class51_0)
            {
                return ((class51_0.RowState != DataRowState.Deleted) && (class51_0.RowState != DataRowState.Detached));
            }

            internal DateTime method_6(DataSetGES.Class51 class51_0)
            {
                return class51_0.dateEnd;
            }

            internal short method_7(DataSetGES.Class53 class53_0)
            {
                return class53_0.Num;
            }
        }
    }

}