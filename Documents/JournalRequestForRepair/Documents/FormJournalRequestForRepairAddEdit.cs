using ControlsLbr;
using ControlsLbr.DataGridViewExcelFilter;
//using Documents.DataSets;
//using Documents.Forms.RequestForRepair;
//using Documents.Properties;
using FormLbr;
using FormLbr.Classes;
using RequestForRepair.DataSets;
//using RequestsClient.Forms.JournalRequestForRepair;
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
    /// Журнал аварийных заявок на ремонт оборудования (старый)
    /// c000096
    /// RrnmVPQMePxiJyIxevn/c0001db
    /// </summary>
    public partial  class FormJournalRequestForRepairAddEdit : FormBase
    {
        private BindingSource bindingSource_0;
        private BindingSource bindingSource_1;
        /// <summary>
        /// Тип заявки (ремонт или авария)
        /// </summary>
        private bool TypeRequestRepair;
        private Button buttonOK;
        private Button buttonCancel;
        private Button buttonDaily;
        private Button buttonCopy;
        private CheckBox checkBoxAgreed;
        private CheckBox checkBoxWeekEnd;
        private CheckBox checkBoxDaily;
        private ComboBox cmbSR;
        private ComboBox cmbIsPlanned;
        private ComboBox cmbDispatcher;
        private ComboBox cmbUserCreate;
        private ComboBox comboBox_4;
        private ComboBox cmbStatus;
        private ComboBox cmbWorker;
        private DataColumn dataColumn_0;
        private DataColumn dataColumn_1;
        private DataColumn dataColumn_2;
        private DataColumn dataColumn_3;
        private DataColumn dataColumn_4;
        private DataColumn dataColumn_5;
        private DataColumn dataColumn_6;
        private DataColumn dataColumn_7;
        private DataColumn dataColumn_8;
        private DataGridView dgvDaily;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvLinkObjects;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvDocs;
        private DataGridViewFilterDateTimePickerColumn dataGridViewFilterDateTimePickerColumn_0;
        private DataGridViewFilterDateTimePickerColumn dataGridViewFilterDateTimePickerColumn_1;
        private DataGridViewImageColumnNotNull dataGridViewImageColumnNotNull_0;
        private DataGridViewLinkColumn dataGridViewLinkColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumnDoc;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;
        private DataRow RowCurrent;
        private DataSet dataSet_0;
        private DataSetN dataSetN;
        private DataTable dataTable_0;
        private DataTable dataTable_1;
        private DataTable dataTable_2;
        private DateTime dateTime_0;
        private DateTime dateTime_1;
        private DateTimePicker dateTimePickerEnd;
        private DateTimePicker dateTimePickerBeg;
        private Dictionary<int, string> dictionary_0;
        private eActionRequestRepair eAction;
        private GroupBox groupBox_0;
        private GroupBox groupBoxODS;
        private GroupBox groupBoxDaily;
        private IContainer icontainer_0=null;
        private int IdRequest;
        private int IdDivision;
        private const int int_2 = 920;
        private int IdSR;
        private Label label_0;
        private Label label_1;
        private Label label_10;
        private Label label_11;
        private Label label_12;
        private Label label_13;
        private Label label_14;
        private Label label_15;
        private Label labelStatus;
        private Label labelWorker;
        private Label label_2;
        private Label label_3;
        private Label labelIsPlanned;
        private Label labelPurpose;
        private Label labelObject;
        private Label label_7;
        private Label label_8;
        private Label label_9;
        private NullableDateTimePicker dateTimePickerDateAgreed;
        private NullableDateTimePicker dtpDateCreate;
        private NullableDateTimePicker dtpFactEnd;
        private TabControl tabControl;
        private TabPage tabPageGeneral;
        private TabPage tabPageSwitching;
        private TabPage tabPageDocuments;
        private TextBox txtPurpose;
        private TextBox txtObject;
        private TextBox txtComment;
        private TextBox txtAgreeWith;
        private TextBox txtNum;
        private TextBox txtAdress;
        private ToolStrip toolStripScheme;
        private ToolStrip toolStrip_1;
        private ToolStrip toolStripMain;
        private ToolStripButton toolBtnLinkSchmObj;
        private ToolStripButton toolBtnDelSchmObj;
        private ToolStripButton toolBtnViewSChmObj;
        private ToolStripButton toolBtnLinkSchmObjEdit;
        private ToolStripButton toolBtnAddDoc;
        private ToolStripButton toolBtnDelDoc;
        private ToolStripButton toolBtnViewDoc;
        private ToolStripButton toolBtnSaveDoc;
        private ToolStripButton toolBtnCopy;

        public FormJournalRequestForRepairAddEdit()
        {
            this.IdRequest = -1;
            this.IdDivision = -1;
            this.eAction = eActionRequestRepair.Read;
            this.dateTime_0 = new DateTime(0x76c, 1, 1);
            this.dateTime_1 = new DateTime(0x2328, 1, 1);
            this.dictionary_0 = new Dictionary<int, string>();
            this.IdSR = -1;
            //****************************************************//
            this.InitializeComponent();
        }

        internal FormJournalRequestForRepairAddEdit(DataRow row)
        {
            this.IdRequest = -1;
            this.IdDivision = -1;
            this.eAction = eActionRequestRepair.Read;
            this.dateTime_0 = new DateTime(0x76c, 1, 1);
            this.dateTime_1 = new DateTime(0x2328, 1, 1);
            this.dictionary_0 = new Dictionary<int, string>();
            this.IdSR = -1;
            //****************************************************//
            this.InitializeComponent();
            this.IdRequest = -1;
            this.IdDivision = Convert.ToInt32(row["idDivision"]);
            this.eAction = eActionRequestRepair.Add;
            this.RowCurrent = row;
        }

        internal FormJournalRequestForRepairAddEdit(int idRequest, int idDivision, eActionRequestRepair e, bool typeRequestRepair = false)
        {
            this.IdRequest = -1;
            this.IdDivision = -1;
            this.eAction = eActionRequestRepair.Read;
            this.dateTime_0 = new DateTime(0x76c, 1, 1);
            this.dateTime_1 = new DateTime(0x2328, 1, 1);
            this.dictionary_0 = new Dictionary<int, string>();
            this.IdSR = -1;
            //****************************************************//
            this.InitializeComponent();
            this.IdRequest = idRequest;
            this.IdDivision = idDivision;
            this.eAction = e;
            this.TypeRequestRepair = typeRequestRepair;
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
                    this.IdSR = Convert.ToInt32(attribute.Value);
                }
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.OK;
            base.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
            base.Close();
        }

        private void buttonDaily_Click(object sender, EventArgs e)
        {
            bool flag = false;
            this.dgvDaily.RowsAdded -= new DataGridViewRowsAddedEventHandler(this.dgvDaily_RowsAdded);
            if (this.checkBoxDaily.Checked)
            {
                int num = 0;
                while (true)
                {
                    TimeSpan span = (TimeSpan)(this.dateTimePickerEnd.Value - this.dateTimePickerBeg.Value);
                    if (num > span.Days)
                    {
                        goto Label_022F;
                    }
                    if (this.checkBoxWeekEnd.Checked || ((this.dateTimePickerBeg.Value.AddDays((double)num).DayOfWeek != DayOfWeek.Saturday) && (this.dateTimePickerBeg.Value.AddDays((double)num).DayOfWeek != DayOfWeek.Sunday)))
                    {
                        try
                        {
                            DataRow row = this.dataSetN.tJ_RequestForRepairDaily.NewRow();
                            row["idRequest"] = this.IdRequest;
                            row["dateBeg"] = this.dateTimePickerBeg.Value.AddDays((double)num);
                            row["dateEnd"] = this.dateTimePickerBeg.Value.AddDays((double)num).Date + this.dateTimePickerEnd.Value.TimeOfDay;
                            this.dataSetN.tJ_RequestForRepairDaily.Rows.Add(row);
                            flag = true;
                            this.groupBoxDaily.ForeColor = SystemColors.ControlText;
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
                DataRow row2 = this.dataSetN.tJ_RequestForRepairDaily.NewRow();
                row2["idRequest"] = this.IdRequest;
                row2["dateBeg"] = this.dateTimePickerBeg.Value;
                row2["dateEnd"] = this.dateTimePickerEnd.Value;
                this.dataSetN.tJ_RequestForRepairDaily.Rows.Add(row2);
                flag = true;
                this.groupBoxDaily.ForeColor = SystemColors.ControlText;
            }
            catch (Exception exception2)
            {
                MessageBox.Show(exception2.Message, exception2.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            Label_022F:
            this.dgvDaily.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dgvDaily_RowsAdded);
            if (flag)
            {
                //DataRow row3 = this.dataSetN.tJ_RequestForRepairDaily
                //    .Where<DataSetGES.Class51>((C_1.C_9__32_0 ?? (C_1.C_9__32_0 = new Func<DataSetGES.Class51, bool>(C_1.C_9.method_5))))
                //    .OrderByDescending<DataSetGES.Class51, DateTime>((C_1.C_9__32_1 ?? (C_1.C_9__32_1 = new Func<DataSetGES.Class51, DateTime>(C_1.C_9.method_6))))
                //    .First<DataSetGES.Class51>();
                DataRow row3 = this.dataSetN.tJ_RequestForRepairDaily
                    .Where(r => ((r.RowState != DataRowState.Deleted) && (r.RowState != DataRowState.Detached)))
                    .OrderByDescending(r => r.dateEnd)
                    .First();

                if (Convert.ToDateTime(row3["DateEnd"]) > this.dateTimePickerBeg.MaxDate)
                {
                    this.dateTimePickerBeg.MaxDate = this.dateTime_1;
                }
                this.dateTimePickerBeg.MinDate = Convert.ToDateTime(row3["DateEnd"]);
            }
        }

        private void toolBtnCopy_Click(object sender, EventArgs e)
        {
            if (this.dataSetN.tJ_RequestForRepair.Rows.Count > 0)
            {
                DataRow row = this.dataSetN.tJ_RequestForRepair.NewRow();
                row.ItemArray = this.dataSetN.tJ_RequestForRepair.Rows[0].ItemArray;
                this.dataSetN.tJ_RequestForRepairDoc.Clear();
                this.dataSetN.tJ_RequestForRepairDaily.Clear();
                DataRow row2 = this.dataSetN.tJ_RequestForRepair.NewRow();
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
                this.IdRequest = -1;
                this.eAction = eActionRequestRepair.Add;
                this.dataSetN.tJ_RequestForRepair.Rows.Add(row2);
                this.dataSetN.tJ_RequestForRepair.Rows.RemoveAt(0);
            }
        }

        private void checkBoxAgreed_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxAgreed.Checked)
            {
                if ((this.dataSetN.tJ_RequestForRepair.Rows.Count > 0) && (this.dateTimePickerDateAgreed.Value == null))
                {
                    object obj2;
                    this.dataSetN.tJ_RequestForRepair.Rows[0]["Agreed"] = true;
                    this.dataSetN.tJ_RequestForRepair.Rows[0]["DateAgreed"] = obj2 = DateTime.Now;
                    this.dateTimePickerDateAgreed.Value = (obj2);
                }
            }
            else if ((this.dataSetN.tJ_RequestForRepair.Rows.Count > 0) && (this.dateTimePickerDateAgreed.Value != null))
            {
                this.dataSetN.tJ_RequestForRepair.Rows[0]["Agreed"] = false;
                this.dateTimePickerDateAgreed.Value = (null);
                this.dataSetN.tJ_RequestForRepair.Rows[0]["DateAgreed"] = DBNull.Value;
            }
        }

        private void checkBoxDaily_CheckedChanged(object sender, EventArgs e)
        {
            this.checkBoxWeekEnd.Enabled = this.checkBoxDaily.Checked;
        }

        private void cmbSR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbSR.SelectedIndex >= 0)
            {
                this.label_2.ForeColor = SystemColors.ControlText;
            }
        }

        private void comboBox_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbIsPlanned.SelectedIndex >= 0)
            {
                this.labelIsPlanned.ForeColor = SystemColors.ControlText;
            }
            if (this.dataSetN.tJ_RequestForRepair.Rows.Count > 0)
            {
                if (this.cmbIsPlanned.SelectedIndex == 0)
                {
                    this.dataSetN.tJ_RequestForRepair.Rows[0]["IsPlanned"] = false;
                }
                else
                {
                    this.dataSetN.tJ_RequestForRepair.Rows[0]["IsPlanned"] = true;
                }
            }
        }

        private void cmbWorker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbWorker.SelectedIndex >= 0)
            {
                this.labelWorker.ForeColor = SystemColors.ControlText;
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
            if (this.eAction == eActionRequestRepair.Add)
            {
                node.Value = this.cmbSR.SelectedValue.ToString();
            }
            else
            {
                node.Value = this.IdSR.ToString();
            }
            node2.Attributes.Append(node);
            return document1;
        }

        private void dgvDaily_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == (this.dgvDaily.Rows.Count - 1))
            {
                DateTime time = Convert.ToDateTime(this.dgvDaily[this.dataGridViewFilterDateTimePickerColumn_1.Name, e.RowIndex].Value);
                if (time > this.dateTimePickerBeg.MaxDate)
                {
                    this.dateTimePickerBeg.MaxDate = DateTimePicker.MaximumDateTime;
                }
                this.dateTimePickerBeg.MinDate = time;
            }
        }

        private void dgvDaily_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DayOfWeek dayOfWeek = Convert.ToDateTime(this.dgvDaily[this.dataGridViewFilterDateTimePickerColumn_0.Name, e.RowIndex].Value).DayOfWeek;
                DayOfWeek week2 = Convert.ToDateTime(this.dgvDaily[this.dataGridViewFilterDateTimePickerColumn_1.Name, e.RowIndex].Value).DayOfWeek;
                if (((dayOfWeek == DayOfWeek.Sunday) || (dayOfWeek == DayOfWeek.Saturday)) && (this.dgvDaily.Columns[e.ColumnIndex] == this.dataGridViewFilterDateTimePickerColumn_0))
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                if (((week2 == DayOfWeek.Sunday) || (week2 == DayOfWeek.Saturday)) && (this.dgvDaily.Columns[e.ColumnIndex] == this.dataGridViewFilterDateTimePickerColumn_1))
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void dgvDaily_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is DateTimePicker)
            {
                if (this.dgvDaily.CurrentCell.OwningColumn.Name == this.dataGridViewFilterDateTimePickerColumn_0.Name)
                {
                    (e.Control as DateTimePicker).MaxDate = Convert.ToDateTime(this.dgvDaily[this.dataGridViewFilterDateTimePickerColumn_1.Name, this.dgvDaily.CurrentCell.RowIndex].Value);
                    if (this.dgvDaily.CurrentCell.RowIndex == 0)
                    {
                        (e.Control as DateTimePicker).MinDate = new DateTime(0x7d0, 1, 1);
                    }
                    if (this.dgvDaily.CurrentCell.RowIndex > 0)
                    {
                        (e.Control as DateTimePicker).MinDate = Convert.ToDateTime(this.dgvDaily[this.dataGridViewFilterDateTimePickerColumn_1.Name, this.dgvDaily.CurrentCell.RowIndex - 1].Value);
                    }
                }
                if (this.dgvDaily.CurrentCell.OwningColumn.Name == this.dataGridViewFilterDateTimePickerColumn_1.Name)
                {
                    (e.Control as DateTimePicker).MinDate = Convert.ToDateTime(this.dgvDaily[this.dataGridViewFilterDateTimePickerColumn_0.Name, this.dgvDaily.CurrentCell.RowIndex].Value);
                    if (this.dgvDaily.CurrentCell.RowIndex == (this.dgvDaily.Rows.Count - 1))
                    {
                        (e.Control as DateTimePicker).MaxDate = new DateTime(0x270e, 12, 0x1f);
                    }
                    if (this.dgvDaily.CurrentCell.RowIndex < (this.dgvDaily.Rows.Count - 1))
                    {
                        (e.Control as DateTimePicker).MaxDate = Convert.ToDateTime(this.dgvDaily[this.dataGridViewFilterDateTimePickerColumn_0.Name, this.dgvDaily.CurrentCell.RowIndex + 1].Value);
                    }
                }
            }
        }

        private void dgvDaily_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //DataRow row = this.dataSetGES_0.tJ_RequestForRepairDaily
            //    .WhereDataSetGES.Class51>((C_1.C_9__27_0 ?? (C_1.C_9__27_0 = new Func<DataSetGES.Class51, bool>(C_1.C_9.method_0))))
            //    .OrderByDescending<DataSetGES.Class51, DateTime>((C_1.C_9__27_1 ?? (C_1.C_9__27_1 = new Func<DataSetGES.Class51, DateTime>(C_1.C_9.method_1))))
            //    .First<DataSetGES.Class51>();
            DataRow row = this.dataSetN.tJ_RequestForRepairDaily
                .Where(r => ((r.RowState != DataRowState.Deleted) && (r.RowState != DataRowState.Detached)))
                .OrderByDescending(r => r.dateEnd)
                .First();

            if (Convert.ToDateTime(row["DateEnd"]) > this.dateTimePickerBeg.MaxDate)
            {
                this.dateTimePickerBeg.MaxDate = DateTimePicker.MaximumDateTime;
            }
            this.dateTimePickerBeg.MinDate = Convert.ToDateTime(row["DateEnd"]);
        }

        private void dgvDaily_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (this.dataSetN.tJ_RequestForRepairDaily.Rows.Count > 0)
            {
                //if (this.dataSetGES_0.tJ_RequestForRepairDaily
                //    .Where<DataSetGES.Class51>((C_1.C_9__28_0 ?? (C_1.C_9__28_0 = new Func<DataSetGES.Class51, bool>(C_1.C_9.method_2))))
                //    .Count<DataSetGES.Class51>() > 0)
                if (this.dataSetN.tJ_RequestForRepairDaily
                    .Where(r => ((r.RowState != DataRowState.Deleted) && (r.RowState != DataRowState.Detached)))
                    .Count() > 0)
                {
                    //DataRow row = this.dataSetGES_0.tJ_RequestForRepairDaily
                    //    .Where<DataSetGES.Class51>((C_1.C_9__28_1 ?? (C_1.C_9__28_1 = new Func<DataSetGES.Class51, bool>(C_1.C_9.method_3))))
                    //    .OrderByDescending<DataSetGES.Class51, DateTime>((C_1.C_9__28_2 ?? (C_1.C_9__28_2 = new Func<DataSetGES.Class51, DateTime>(C_1.C_9.method_4))))
                    //    .First<DataSetGES.Class51>();
                    DataRow row = this.dataSetN.tJ_RequestForRepairDaily
                        .Where(r => ((r.RowState != DataRowState.Deleted) && (r.RowState != DataRowState.Detached)))
                        .OrderByDescending(r => r.dateEnd)
                        .First();
                    this.dateTimePickerBeg.MinDate = Convert.ToDateTime(row["DateEnd"]);
                }
                else
                {
                    this.dateTimePickerBeg.MinDate = this.dateTime_0;
                }
            }
            else
            {
                this.dateTimePickerBeg.MinDate = this.dateTime_0;
            }
        }

        private void dgvLinkObjects_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.toolBtnLinkSchmObjEdit_Click(sender, e);
        }

        private void dgvDocs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvDocs.CurrentRow != null)
            {
                int num = Convert.ToInt32(this.dgvDocs.CurrentRow.Cells[this.idDataGridViewTextBoxColumnDoc.Name].Value);
                if (e.ColumnIndex == this.dgvDocs.Columns[this.dataGridViewLinkColumn_0.Name].Index)
                {
                    //byte[] buffer = (byte[])this.dataSetN.tJ_RequestForRepairDoc.FindByid(num)["Document"];

                    byte[] buffer = (byte[])this.dataSetN.tJ_RequestForRepairDoc.Rows.Find(num)["Document"];

                    //string path = Path.ChangeExtension(Path.GetTempFileName(), Path.GetExtension(this.dataSetN.tJ_RequestForRepairDoc.FindByid(num)["FileName"].ToString()));

                    string path = Path.ChangeExtension(Path.GetTempFileName(), Path.GetExtension(this.dataSetN.tJ_RequestForRepairDoc.Rows.Find(num)["FileName"].ToString()));

                    FileStream stream1 = File.Create(path);
                    stream1.Write(buffer, 0, buffer.Length);
                    stream1.Close();
                    new Process
                    {
                        StartInfo =
                        {
                            FileName = path,
                            UseShellExecute = true
                        }
                    }.Start();
                }
            }
        }

        private void dgvDocs_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (((this.dgvDocs.RowCount > 0) && (this.dgvDocs[this.dataGridViewLinkColumn_0.Name, e.RowIndex].Value != null)) && (e.ColumnIndex == this.dgvDocs.Columns[this.dataGridViewImageColumnNotNull_0.Name].Index))
            {
                e.Value = FormLbr.Classes.FileInfo.IconOfFile(this.dgvDocs[this.dataGridViewLinkColumn_0.Name, e.RowIndex].Value.ToString()).ToBitmap();
            }
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePickerBeg.MaxDate = this.dateTimePickerEnd.Value.AddMinutes(-1.0);
        }

        private void dateTimePickerBeg_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePickerEnd.MinDate = this.dateTimePickerBeg.Value.AddMinutes(1.0);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormJournalRequestForRepairAddEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            base.SaveFormConfig(null);
        }

        private void FormJournalRequestForRepairAddEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (base.DialogResult == DialogResult.OK)
            {
                if ((this.eAction != eActionRequestRepair.Read) && !this.method_6())
                {
                    MessageBox.Show("Не введены обязательные поля", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    e.Cancel = true;
                }
                else
                {
                    switch (this.eAction)
                    {
                        case eActionRequestRepair.Add:
                            this.dataSetN.tJ_RequestForRepair.Rows[0].EndEdit();
                            this.IdRequest = base.InsertSqlDataOneRow(this.dataSetN, this.dataSetN.tJ_RequestForRepair);
                            foreach (DataRow row in this.dataSetN.tJ_RequestForRepairDaily)
                            {
                                if ((row.RowState != DataRowState.Detached) && (row.RowState != DataRowState.Deleted))
                                {
                                    row["idRequest"] = this.IdRequest;
                                    row.EndEdit();
                                }
                            }
                            base.InsertSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDaily);
                            base.UpdateSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDaily);
                            base.DeleteSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDaily);
                            this.method_10();
                            this.method_11();
                            break;

                        case eActionRequestRepair.Edit:
                            this.dataSetN.tJ_RequestForRepair.Rows[0].EndEdit();
                            base.UpdateSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepair);
                            foreach (DataRow row2 in this.dataSetN.tJ_RequestForRepairDaily)
                            {
                                if ((row2.RowState != DataRowState.Detached) && (row2.RowState != DataRowState.Deleted))
                                {
                                    row2["idRequest"] = this.IdRequest;
                                    row2.EndEdit();
                                }
                            }
                            base.InsertSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDaily);
                            base.UpdateSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDaily);
                            base.DeleteSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDaily);
                            this.method_10();
                            this.method_11();
                            break;
                    }
                }
            }
        }

        private void FormJournalRequestForRepairAddEdit_Load(object sender, EventArgs e)
        {
            this.dtpDateCreate.Value = (DateTime.Now);
            this.dateTimePickerBeg.Value = DateTime.Now.Date.AddHours(8.0);
            this.dateTimePickerEnd.Value = DateTime.Now.Date.AddHours(17.0);
            this.method_1();
            this.method_4();
            this.method_5();
            this.method_0();
            base.LoadFormConfig(null);
            switch (this.eAction)
            {
                case eActionRequestRepair.Add:
                    {
                        if (this.RowCurrent == null)
                        {
                            DataRow row2 = this.dataSetN.tJ_RequestForRepair.NewRow();
                            row2["num"] = 0;
                            row2["dateCreate"] = DateTime.Now;
                            row2["idWorker"] = -1;
                            row2["reguestFiled"] = "";
                            row2["idSR"] = this.IdSR;
                            row2["schmObj"] = "";
                            row2["Purpose"] = "";
                            row2["Crash"] = this.TypeRequestRepair;
                            if (this.TypeRequestRepair)
                            {
                                row2["isPlanned"] = false;
                            }
                            else
                            {
                                row2["IsPlanned"] = true;
                            }
                            row2["agreed"] = false;
                            row2["iddivision"] = this.IdDivision;
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
                            this.dataSetN.tJ_RequestForRepair.Rows.Add(row2);
                            if (this.TypeRequestRepair)
                            {
                                this.cmbIsPlanned.SelectedIndex = 0;
                            }
                            else
                            {
                                this.cmbIsPlanned.SelectedIndex = 1;
                            }
                            if (this.cmbWorker.SelectedItem != null)
                            {
                                row2["reguestFiled"] = this.cmbWorker.Text;
                            }
                            break;
                        }
                        DataRow row = this.dataSetN.tJ_RequestForRepair.NewRow();
                        row["num"] = 0;
                        row["dateCreate"] = DateTime.Now;
                        row["idWorker"] = this.RowCurrent["idWorker"];
                        row["reguestFiled"] = this.RowCurrent["reguestFiled"];
                        row["idSR"] = this.RowCurrent["idSR"];
                        row["schmObj"] = this.RowCurrent["schmObj"];
                        row["Purpose"] = this.RowCurrent["Purpose"];
                        row["IsPlanned"] = this.RowCurrent["IsPlanned"];
                        row["agreed"] = this.RowCurrent["agreed"];
                        row["iddivision"] = this.RowCurrent["iddivision"];
                        row["Crash"] = this.RowCurrent["Crash"];
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
                        this.dataSetN.tJ_RequestForRepair.Rows.Add(row);
                        break;
                    }
                case eActionRequestRepair.Edit:
                    if (this.IdRequest > 0)
                    {
                        base.SelectSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepair, true, " where id = " + this.IdRequest.ToString());
                        base.SelectSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDaily, true, " where idRequest = " + this.IdRequest.ToString());
                        base.SelectSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDoc, true, " where idRequest = " + this.IdRequest.ToString());
                        this.method_9();
                    }
                    break;

                case eActionRequestRepair.Read:
                    if (this.IdRequest > 0)
                    {
                        base.SelectSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepair, true, " where id = " + this.IdRequest.ToString());
                        base.SelectSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDaily, true, " where idRequest = " + this.IdRequest.ToString());
                        base.SelectSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDoc, true, " where idRequest = " + this.IdRequest.ToString());
                        this.method_9();
                    }
                    this.cmbWorker.Enabled = false;
                    this.comboBox_4.Enabled = false;
                    this.cmbSR.Enabled = false;
                    this.txtObject.ReadOnly = true;
                    this.txtPurpose.ReadOnly = true;
                    this.cmbIsPlanned.Enabled = false;
                    this.groupBoxDaily.Enabled = false;
                    this.txtAgreeWith.ReadOnly = true;
                    this.txtComment.ReadOnly = true;
                    this.txtAdress.ReadOnly = true;
                    this.checkBoxAgreed.Enabled = false;
                    this.dateTimePickerDateAgreed.Enabled = false;
                    this.cmbDispatcher.Enabled = false;
                    break;
            }
            if (this.dataSetN.tJ_RequestForRepair.Rows.Count > 0)
            {
                if (this.IdDivision <= 0)
                {
                    this.IdDivision = Convert.ToInt32(this.dataSetN.tJ_RequestForRepair.Rows[0]["IdDivision"]);
                }
                if (Convert.ToBoolean(this.dataSetN.tJ_RequestForRepair.Rows[0]["IsPlanned"]))
                {
                    this.cmbIsPlanned.SelectedIndex = 1;
                }
                else
                {
                    this.cmbIsPlanned.SelectedIndex = 0;
                }
                if ((this.dataSetN.tJ_RequestForRepair.Rows[0]["Crash"] != DBNull.Value) && Convert.ToBoolean(this.dataSetN.tJ_RequestForRepair.Rows[0]["Crash"]))
                {
                    this.cmbIsPlanned.Enabled = false;
                }
            }
            if (this.IdDivision == 0x399)
            {
                this.groupBoxODS.Visible = false;
            }
        }

        private void groupBoxODS_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.groupBoxODS.Visible)
            {
                this.tabControl.Height = 0x145;
                base.Height = 0x187;
                this.buttonCancel.Location = new Point(this.buttonCancel.Location.X, 0x14b);
                this.buttonOK.Location = new Point(this.buttonOK.Location.X, 0x14b);
            }
            else
            {
                this.tabControl.Height = 0x245;
                base.Height = 0x287;
                this.buttonCancel.Location = new Point(this.buttonCancel.Location.X, 0x24b);
                this.buttonOK.Location = new Point(this.buttonOK.Location.X, 0x24b);
            }
        }

        private void method_0()
        {
            DataTable table = new DataTable("tUser");
            table.Columns.Add("idUser", typeof(int));
            base.SelectSqlData(table, true, " left join vworkergroup w on w.id = tuser.idWorker\r\n                                where w.ParentKey = ';GroupWorker;Dispatchers;' and tuser.login = SYSTEM_USER");
            if (table.Rows.Count == 0)
            {
                this.groupBoxODS.Enabled = false;
                this.dtpDateCreate.Enabled = false;
                this.dtpFactEnd.Enabled = false;
            }
            else
            {
                this.groupBoxODS.Enabled = true;
                this.dtpDateCreate.Enabled = true;
                this.dtpFactEnd.Enabled = true;
            }
        }

        private void method_1()
        {
            if (this.IdDivision > 0)
            {
                base.SelectSqlData(this.dataSetN, this.dataSetN.tR_Classifier, true, "where id = " + this.IdDivision.ToString());
            }
            string str = "";
            if (this.dataSetN.tR_Classifier.Rows.Count > 0)
            {
                str = " " + this.dataSetN.tR_Classifier.Rows[0]["SocrName"].ToString();
            }
            switch (this.eAction)
            {
                case eActionRequestRepair.Add:
                    if (!this.TypeRequestRepair)
                    {
                        this.Text = "Создать новую заявку" + str;
                        return;
                    }
                    this.Text = "Создать новую аварийную заявку" + str;
                    return;

                case eActionRequestRepair.Edit:
                    if (!this.TypeRequestRepair)
                    {
                        this.Text = "Редактирование заявки" + str;
                        return;
                    }
                    this.Text = "Редактирование аварийной заявки" + str;
                    return;

                case eActionRequestRepair.Read:
                    if (!this.TypeRequestRepair)
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
            foreach (DataRow row in this.dataSetN.tL_RequestForRepairSchmObjList)
            {
                if ((row.RowState != DataRowState.Detached) && (row.RowState != DataRowState.Deleted))
                {
                    row["idRequest"] = this.IdRequest;
                    row.EndEdit();
                }
            }
            base.InsertSqlData(this.dataSetN, this.dataSetN.tL_RequestForRepairSchmObjList);
            base.UpdateSqlData(this.dataSetN, this.dataSetN.tL_RequestForRepairSchmObjList);
            base.DeleteSqlData(this.dataSetN, this.dataSetN.tL_RequestForRepairSchmObjList);
            this.dataSetN.tL_RequestForRepairSchmObjList.AcceptChanges();
        }

        private void method_11()
        {
            foreach (DataRow row in this.dataSetN.tJ_RequestForRepairDoc)
            {
                if ((row.RowState != DataRowState.Detached) && (row.RowState != DataRowState.Deleted))
                {
                    row["idRequest"] = this.IdRequest;
                    row.EndEdit();
                }
            }
            base.InsertSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDoc);
            base.UpdateSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDoc);
            base.DeleteSqlData(this.dataSetN, this.dataSetN.tJ_RequestForRepairDoc);
            this.dataSetN.tL_RequestForRepairSchmObjList.AcceptChanges();
        }

        private void InitializeComponent()
        {
            this.icontainer_0 = new Container();
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            DataGridViewCellStyle style3 = new DataGridViewCellStyle();
            DataGridViewCellStyle style4 = new DataGridViewCellStyle();
            this.dataSetN = new DataSetN();
            this.label_0 = new Label();
            this.label_1 = new Label();
            this.label_2 = new Label();
            this.cmbSR = new ComboBox();
            this.groupBox_0 = new GroupBox();
            this.cmbIsPlanned = new ComboBox();
            this.labelIsPlanned = new Label();
            this.labelPurpose = new Label();
            this.txtPurpose = new TextBox();
            this.txtObject = new TextBox();
            this.cmbWorker = new ComboBox();
            this.labelObject = new Label();
            this.labelWorker = new Label();
            this.toolStripScheme = new ToolStrip();
            this.toolBtnLinkSchmObj = new ToolStripButton();
            this.toolBtnLinkSchmObjEdit = new ToolStripButton();
            this.toolBtnDelSchmObj = new ToolStripButton();
            this.toolBtnViewSChmObj = new ToolStripButton();
            this.groupBoxDaily = new GroupBox();
            this.buttonDaily = new Button();
            this.dgvDaily = new DataGridView();
            this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterDateTimePickerColumn_0 = new DataGridViewFilterDateTimePickerColumn();
            this.dataGridViewFilterDateTimePickerColumn_1 = new DataGridViewFilterDateTimePickerColumn();
            this.checkBoxWeekEnd = new CheckBox();
            this.checkBoxDaily = new CheckBox();
            this.dateTimePickerEnd = new DateTimePicker();
            this.label_7 = new Label();
            this.dateTimePickerBeg = new DateTimePicker();
            this.label_3 = new Label();
            this.dtpFactEnd = new NullableDateTimePicker();
            this.label_15 = new Label();
            this.groupBoxODS = new GroupBox();
            this.cmbStatus = new ComboBox();
            this.labelStatus = new Label();
            this.txtAdress = new TextBox();
            this.cmbDispatcher = new ComboBox();
            this.label_8 = new Label();
            this.label_9 = new Label();
            this.dateTimePickerDateAgreed = new NullableDateTimePicker();
            this.checkBoxAgreed = new CheckBox();
            this.dtpDateCreate = new NullableDateTimePicker();
            this.label_14 = new Label();
            this.label_10 = new Label();
            this.label_11 = new Label();
            this.label_12 = new Label();
            this.txtComment = new TextBox();
            this.txtAgreeWith = new TextBox();
            this.buttonOK = new Button();
            this.buttonCancel = new Button();
            this.cmbUserCreate = new ComboBox();
            this.label_13 = new Label();
            this.txtNum = new TextBox();
            this.tabControl = new TabControl();
            this.tabPageGeneral = new TabPage();
            this.comboBox_4 = new ComboBox();
            this.toolStripMain = new ToolStrip();
            this.toolBtnCopy = new ToolStripButton();
            this.tabPageSwitching = new TabPage();
            this.dgvLinkObjects = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
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
            this.tabPageDocuments = new TabPage();
            this.dgvDocs = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.idDataGridViewTextBoxColumnDoc = new DataGridViewTextBoxColumn();
            this.dataGridViewImageColumnNotNull_0 = new DataGridViewImageColumnNotNull();
            this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
            this.dataGridViewLinkColumn_0 = new DataGridViewLinkColumn();
            this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
            this.bindingSource_1 = new BindingSource(this.icontainer_0);
            this.toolStrip_1 = new ToolStrip();
            this.toolBtnAddDoc = new ToolStripButton();
            this.toolBtnDelDoc = new ToolStripButton();
            this.toolBtnViewDoc = new ToolStripButton();
            this.toolBtnSaveDoc = new ToolStripButton();
            this.buttonCopy = new Button();
            this.dataSetN.BeginInit();
            this.groupBox_0.SuspendLayout();
            this.toolStripScheme.SuspendLayout();
            this.groupBoxDaily.SuspendLayout();
            ((ISupportInitialize)this.dgvDaily).BeginInit();
            this.groupBoxODS.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.tabPageSwitching.SuspendLayout();
            ((ISupportInitialize)this.dgvLinkObjects).BeginInit();
            ((ISupportInitialize)this.bindingSource_0).BeginInit();
            this.dataSet_0.BeginInit();
            this.dataTable_1.BeginInit();
            this.dataTable_2.BeginInit();
            this.tabPageDocuments.SuspendLayout();
            ((ISupportInitialize)this.dgvDocs).BeginInit();
            ((ISupportInitialize)this.bindingSource_1).BeginInit();
            this.toolStrip_1.SuspendLayout();
            base.SuspendLayout();
            this.dataSetN.DataSetName = "DataSetGES";
            this.dataSetN.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
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
            this.cmbSR.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbSR.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbSR.DataBindings.Add(new Binding("SelectedValue", this.dataSetN, "tJ_RequestForRepair.idSR", true));
            this.cmbSR.FormattingEnabled = true;
            this.cmbSR.Location = new Point(0x166, 0x20);
            this.cmbSR.Name = "cmbSR";
            this.cmbSR.Size = new Size(0xc6, 0x15);
            this.cmbSR.TabIndex = 7;
            this.cmbSR.SelectedIndexChanged += new EventHandler(this.cmbSR_SelectedIndexChanged);
            this.groupBox_0.Controls.Add(this.cmbIsPlanned);
            this.groupBox_0.Controls.Add(this.labelIsPlanned);
            this.groupBox_0.Controls.Add(this.labelPurpose);
            this.groupBox_0.Controls.Add(this.txtPurpose);
            this.groupBox_0.Controls.Add(this.txtObject);
            this.groupBox_0.Controls.Add(this.cmbWorker);
            this.groupBox_0.Controls.Add(this.labelObject);
            this.groupBox_0.Controls.Add(this.labelWorker);
            this.groupBox_0.Location = new Point(11, 0x35);
            this.groupBox_0.Name = "groupBox1";
            this.groupBox_0.Size = new Size(0x221, 0x61);
            this.groupBox_0.TabIndex = 8;
            this.groupBox_0.TabStop = false;
            this.cmbIsPlanned.FormattingEnabled = true;
            object[] items = new object[] { "Аварийный", "Плановый" };
            this.cmbIsPlanned.Items.AddRange(items);
            this.cmbIsPlanned.Location = new Point(0x65, 0x44);
            this.cmbIsPlanned.Name = "cmbIsPlanned";
            this.cmbIsPlanned.Size = new Size(0x79, 0x15);
            this.cmbIsPlanned.TabIndex = 5;
            this.cmbIsPlanned.SelectedIndexChanged += new EventHandler(this.comboBox_1_SelectedIndexChanged);
            this.labelIsPlanned.AutoSize = true;
            this.labelIsPlanned.Location = new Point(6, 0x47);
            this.labelIsPlanned.Name = "labelIsPlanned";
            this.labelIsPlanned.Size = new Size(0x59, 13);
            this.labelIsPlanned.TabIndex = 4;
            this.labelIsPlanned.Text = "Вид отключения";
            this.labelPurpose.AutoSize = true;
            this.labelPurpose.Location = new Point(6, 0x2d);
            this.labelPurpose.Name = "labelPurpose";
            this.labelPurpose.Size = new Size(0x21, 13);
            this.labelPurpose.TabIndex = 3;
            this.labelPurpose.Text = "Цель";
            this.txtPurpose.DataBindings.Add(new Binding("Text", this.dataSetN, "tJ_RequestForRepair.Purpose", true));
            this.txtPurpose.Location = new Point(0x65, 0x2a);
            this.txtPurpose.Name = "txtPurpose";
            this.txtPurpose.Size = new Size(0x1b6, 20);
            this.txtPurpose.TabIndex = 2;
            this.txtPurpose.TextChanged += new EventHandler(this.txtPurpose0_TextChanged);
            this.txtObject.DataBindings.Add(new Binding("Text", this.dataSetN, "tJ_RequestForRepair.schmObj", true));
            this.txtObject.Location = new Point(0x65, 0x10);
            this.txtObject.Name = "txtObject";
            this.txtObject.Size = new Size(0x1b6, 20);
            this.txtObject.TabIndex = 1;
            this.txtObject.TextChanged += new EventHandler(this.txtObject_TextChanged);
            this.cmbWorker.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbWorker.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbWorker.DataBindings.Add(new Binding("SelectedValue", this.dataSetN, "tJ_RequestForRepair.idWorker", true));
            this.cmbWorker.FormattingEnabled = true;
            this.cmbWorker.Location = new Point(0x13f, 0x44);
            this.cmbWorker.Name = "cmbWorker";
            this.cmbWorker.Size = new Size(0xc6, 0x15);
            this.cmbWorker.TabIndex = 3;
            this.cmbWorker.Visible = false;
            this.cmbWorker.SelectedIndexChanged += new EventHandler(this.cmbWorker_SelectedIndexChanged);
            this.labelObject.AutoSize = true;
            this.labelObject.Location = new Point(6, 0x10);
            this.labelObject.Name = "labelObject";
            this.labelObject.Size = new Size(0x2d, 13);
            this.labelObject.TabIndex = 0;
            this.labelObject.Text = "Объект";
            this.labelWorker.AutoSize = true;
            this.labelWorker.Location = new Point(0xfe, 0x47);
            this.labelWorker.Name = "labelWorker";
            this.labelWorker.Size = new Size(0x38, 13);
            this.labelWorker.TabIndex = 15;
            this.labelWorker.Text = "Оператор";
            this.labelWorker.Visible = false;
            this.toolStripScheme.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolBtnLinkSchmObj, this.toolBtnLinkSchmObjEdit, this.toolBtnDelSchmObj, this.toolBtnViewSChmObj };
            this.toolStripScheme.Items.AddRange(toolStripItems);
            this.toolStripScheme.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripScheme.Location = new Point(3, 3);
            this.toolStripScheme.Name = "toolStripScheme";
            this.toolStripScheme.Size = new Size(0x232, 0x19);
            this.toolStripScheme.TabIndex = 0x2f;
            this.toolStripScheme.Text = "toolStrip1";
            this.toolBtnLinkSchmObj.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnLinkSchmObj.Image = global::RequestForRepair.Properties.Resources.ElementAdd;
            this.toolBtnLinkSchmObj.ImageTransparentColor = Color.Magenta;
            this.toolBtnLinkSchmObj.Name = "toolBtnLinkSchmObj";
            this.toolBtnLinkSchmObj.Size = new Size(0x17, 0x16);
            this.toolBtnLinkSchmObj.Text = "Привязать к схеме";
            this.toolBtnLinkSchmObj.Click += new EventHandler(this.toolBtnLinkSchmObj_Click);
            this.toolBtnLinkSchmObjEdit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnLinkSchmObjEdit.Image = global::RequestForRepair.Properties.Resources.ElementEdit;
            this.toolBtnLinkSchmObjEdit.ImageTransparentColor = Color.Magenta;
            this.toolBtnLinkSchmObjEdit.Name = "toolBtnLinkSchmObjEdit";
            this.toolBtnLinkSchmObjEdit.Size = new Size(0x17, 0x16);
            this.toolBtnLinkSchmObjEdit.Text = "Редактировать";
            this.toolBtnLinkSchmObjEdit.Click += new EventHandler(this.toolBtnLinkSchmObjEdit_Click);
            this.toolBtnDelSchmObj.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnDelSchmObj.Image = global::RequestForRepair.Properties.Resources.ElementDel;
            this.toolBtnDelSchmObj.ImageTransparentColor = Color.Magenta;
            this.toolBtnDelSchmObj.Name = "toolBtnDelSchmObj";
            this.toolBtnDelSchmObj.Size = new Size(0x17, 0x16);
            this.toolBtnDelSchmObj.Text = "Удалить";
            this.toolBtnDelSchmObj.Click += new EventHandler(this.toolBtnDelSchmObj_Click);
            this.toolBtnViewSChmObj.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnViewSChmObj.Enabled = false;
            this.toolBtnViewSChmObj.Image = global::RequestForRepair.Properties.Resources.ElementInformation;
            this.toolBtnViewSChmObj.ImageTransparentColor = Color.Magenta;
            this.toolBtnViewSChmObj.Name = "toolBtnViewSChmObj";
            this.toolBtnViewSChmObj.Size = new Size(0x17, 0x16);
            this.toolBtnViewSChmObj.Text = "Показать на схеме";
            this.toolBtnViewSChmObj.Click += new EventHandler(this.toolStripButton_2_Click);
            this.groupBoxDaily.Controls.Add(this.buttonDaily);
            this.groupBoxDaily.Controls.Add(this.dgvDaily);
            this.groupBoxDaily.Controls.Add(this.checkBoxWeekEnd);
            this.groupBoxDaily.Controls.Add(this.checkBoxDaily);
            this.groupBoxDaily.Controls.Add(this.dateTimePickerEnd);
            this.groupBoxDaily.Controls.Add(this.label_7);
            this.groupBoxDaily.Controls.Add(this.dateTimePickerBeg);
            this.groupBoxDaily.Controls.Add(this.label_3);
            this.groupBoxDaily.Location = new Point(11, 0x97);
            this.groupBoxDaily.Name = "groupBoxDaily";
            this.groupBoxDaily.Size = new Size(0x221, 0x8d);
            this.groupBoxDaily.TabIndex = 10;
            this.groupBoxDaily.TabStop = false;
            this.groupBoxDaily.Text = "Даты отключения";
            this.buttonDaily.Location = new Point(9, 0x73);
            this.buttonDaily.Name = "buttonDaily";
            this.buttonDaily.Size = new Size(0x4b, 0x17);
            this.buttonDaily.TabIndex = 13;
            this.buttonDaily.Text = "Добавить";
            this.buttonDaily.UseVisualStyleBackColor = true;
            this.buttonDaily.Click += new EventHandler(this.buttonDaily_Click);
            this.dgvDaily.AllowUserToAddRows = false;
            this.dgvDaily.AllowUserToResizeColumns = false;
            this.dgvDaily.AllowUserToResizeRows = false;
            this.dgvDaily.AutoGenerateColumns = false;
            this.dgvDaily.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_8, this.dataGridViewTextBoxColumn_9, this.dataGridViewFilterDateTimePickerColumn_0, this.dataGridViewFilterDateTimePickerColumn_1 };
            this.dgvDaily.Columns.AddRange(dataGridViewColumns);
            this.dgvDaily.DataMember = "tJ_RequestForRepairDaily";
            this.dgvDaily.DataSource = this.dataSetN;
            this.dgvDaily.Location = new Point(0xb2, 8);
            this.dgvDaily.Name = "dgvDaily";
            this.dgvDaily.RowHeadersWidth = 30;
            this.dgvDaily.Size = new Size(0x16f, 0x65);
            this.dgvDaily.TabIndex = 12;
            this.dgvDaily.VirtualMode = true;
            this.dgvDaily.CellEndEdit += new DataGridViewCellEventHandler(this.dgvDaily_CellEndEdit);
            this.dgvDaily.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dgvDaily_CellFormatting);
            this.dgvDaily.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(this.dgvDaily_EditingControlShowing);
            this.dgvDaily.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dgvDaily_RowsAdded);
            this.dgvDaily.RowsRemoved += new DataGridViewRowsRemovedEventHandler(this.dgvDaily_RowsRemoved);
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
            this.checkBoxWeekEnd.AutoSize = true;
            this.checkBoxWeekEnd.Checked = true;
            this.checkBoxWeekEnd.CheckState = CheckState.Checked;
            this.checkBoxWeekEnd.Enabled = false;
            this.checkBoxWeekEnd.Location = new Point(9, 0x5c);
            this.checkBoxWeekEnd.Name = "checkBoxWeekEnd";
            this.checkBoxWeekEnd.Size = new Size(0x4e, 0x11);
            this.checkBoxWeekEnd.TabIndex = 11;
            this.checkBoxWeekEnd.Text = "Выходные";
            this.checkBoxWeekEnd.UseVisualStyleBackColor = true;
            this.checkBoxDaily.AutoSize = true;
            this.checkBoxDaily.Location = new Point(9, 0x45);
            this.checkBoxDaily.Name = "checkBoxDaily";
            this.checkBoxDaily.Size = new Size(0x53, 0x11);
            this.checkBoxDaily.TabIndex = 10;
            this.checkBoxDaily.Text = "Ежедневно";
            this.checkBoxDaily.UseVisualStyleBackColor = true;
            this.checkBoxDaily.CheckedChanged += new EventHandler(this.checkBoxDaily_CheckedChanged);
            this.dateTimePickerEnd.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.Location = new Point(30, 0x2b);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new Size(0x7c, 20);
            this.dateTimePickerEnd.TabIndex = 1;
            this.dateTimePickerEnd.ValueChanged += new EventHandler(this.dateTimePickerEnd_ValueChanged);
            this.label_7.AutoSize = true;
            this.label_7.Location = new Point(6, 50);
            this.label_7.Name = "label9";
            this.label_7.Size = new Size(0x13, 13);
            this.label_7.TabIndex = 9;
            this.label_7.Text = "по";
            this.dateTimePickerBeg.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerBeg.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerBeg.Location = new Point(30, 0x13);
            this.dateTimePickerBeg.Name = "dateTimePickerBeg";
            this.dateTimePickerBeg.Size = new Size(0x7c, 20);
            this.dateTimePickerBeg.TabIndex = 0;
            this.dateTimePickerBeg.ValueChanged += new EventHandler(this.dateTimePickerBeg_ValueChanged);
            this.label_3.AutoSize = true;
            this.label_3.Location = new Point(11, 0x16);
            this.label_3.Name = "label8";
            this.label_3.Size = new Size(13, 13);
            this.label_3.TabIndex = 8;
            this.label_3.Text = "с";
            this.dtpFactEnd.CustomFormat = ("dd.MM.yyyy HH:mm");
            this.dtpFactEnd.DataBindings.Add(new Binding("Value", this.dataSetN, "tJ_RequestForRepair.dateFactEnd", true));
            this.dtpFactEnd.Format = (DateTimePickerFormat.Custom);
            this.dtpFactEnd.Location = new Point(0x93, 0x2d);
            this.dtpFactEnd.Name = "dtpFactEnd";
            this.dtpFactEnd.Size = new Size(0xe3, 20);
            this.dtpFactEnd.TabIndex = 0x11;
            this.dtpFactEnd.Value = (new DateTime(0x7df, 8, 10, 13, 0x39, 6, 0x16));
            this.label_15.AutoSize = true;
            this.label_15.Location = new Point(10, 0x33);
            this.label_15.Name = "label3";
            this.label_15.Size = new Size(0x83, 13);
            this.label_15.TabIndex = 14;
            this.label_15.Text = "Время закрытия заявки";
            this.groupBoxODS.Controls.Add(this.dtpFactEnd);
            this.groupBoxODS.Controls.Add(this.label_15);
            this.groupBoxODS.Controls.Add(this.cmbStatus);
            this.groupBoxODS.Controls.Add(this.labelStatus);
            this.groupBoxODS.Controls.Add(this.txtAdress);
            this.groupBoxODS.Controls.Add(this.cmbDispatcher);
            this.groupBoxODS.Controls.Add(this.label_8);
            this.groupBoxODS.Controls.Add(this.label_9);
            this.groupBoxODS.Controls.Add(this.dateTimePickerDateAgreed);
            this.groupBoxODS.Controls.Add(this.checkBoxAgreed);
            this.groupBoxODS.Controls.Add(this.dtpDateCreate);
            this.groupBoxODS.Controls.Add(this.label_14);
            this.groupBoxODS.Controls.Add(this.label_10);
            this.groupBoxODS.Controls.Add(this.label_11);
            this.groupBoxODS.Controls.Add(this.label_12);
            this.groupBoxODS.Controls.Add(this.txtComment);
            this.groupBoxODS.Controls.Add(this.txtAgreeWith);
            this.groupBoxODS.Location = new Point(11, 0x126);
            this.groupBoxODS.Name = "groupBoxODS";
            this.groupBoxODS.Size = new Size(0x221, 0x100);
            this.groupBoxODS.TabIndex = 9;
            this.groupBoxODS.TabStop = false;
            this.groupBoxODS.VisibleChanged += new EventHandler(this.groupBoxODS_VisibleChanged);
            this.cmbStatus.DataBindings.Add(new Binding("SelectedValue", this.dataSetN, "tJ_RequestForRepair.status", true));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new Point(0xa5, 0xe0);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new Size(0x176, 0x15);
            this.cmbStatus.TabIndex = 15;
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new Point(0x4f, 0xe3);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new Size(80, 13);
            this.labelStatus.TabIndex = 14;
            this.labelStatus.Text = "Статус заявки";
            this.txtAdress.DataBindings.Add(new Binding("Text", this.dataSetN, "tJ_RequestForRepair.Address", true));
            this.txtAdress.Location = new Point(0x6a, 0x7e);
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new Size(0x1b1, 0x40);
            this.txtAdress.TabIndex = 11;
            this.cmbDispatcher.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbDispatcher.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbDispatcher.DataBindings.Add(new Binding("SelectedValue", this.dataSetN, "tJ_RequestForRepair.WorkerAgreed", true));
            this.cmbDispatcher.FormattingEnabled = true;
            this.cmbDispatcher.Location = new Point(400, 0xc4);
            this.cmbDispatcher.Name = "cmbDispatcher";
            this.cmbDispatcher.Size = new Size(0x8b, 0x15);
            this.cmbDispatcher.TabIndex = 10;
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
            this.dateTimePickerDateAgreed.DataBindings.Add(new Binding("Value", this.dataSetN, "tJ_RequestForRepair.DateAgreed", true));
            this.dateTimePickerDateAgreed.Location = new Point(0x93, 0xc4);
            this.dateTimePickerDateAgreed.Name = "dateTimePickerDateAgreed";
            this.dateTimePickerDateAgreed.Size = new Size(0xa3, 20);
            this.dateTimePickerDateAgreed.TabIndex = 7;
            this.dateTimePickerDateAgreed.Value = (new DateTime(0x7dc, 9, 0x1a, 9, 0x3a, 0x1c, 0x3a4));
            this.checkBoxAgreed.AutoSize = true;
            this.checkBoxAgreed.DataBindings.Add(new Binding("Checked", this.dataSetN, "tJ_RequestForRepair.Agreed", true));
            this.checkBoxAgreed.Location = new Point(14, 0xc7);
            this.checkBoxAgreed.Name = "checkBoxAgreed";
            this.checkBoxAgreed.Size = new Size(0x53, 0x11);
            this.checkBoxAgreed.TabIndex = 6;
            this.checkBoxAgreed.Text = "Разрешено";
            this.checkBoxAgreed.UseVisualStyleBackColor = true;
            this.checkBoxAgreed.CheckedChanged += new EventHandler(this.checkBoxAgreed_CheckedChanged);
            this.dtpDateCreate.CustomFormat = ("dd.MM.yyyy HH:mm");
            this.dtpDateCreate.DataBindings.Add(new Binding("Value", this.dataSetN, "tJ_RequestForRepair.dateOpenRequest", true));
            this.dtpDateCreate.Format = (DateTimePickerFormat.Custom);
            this.dtpDateCreate.Location = new Point(0x93, 0x13);
            this.dtpDateCreate.Name = "dtpDateCreate";
            this.dtpDateCreate.Size = new Size(0xe3, 20);
            this.dtpDateCreate.TabIndex = 0x11;
            this.dtpDateCreate.Value = (new DateTime(0x7dc, 10, 0x12, 8, 0x27, 0x29, 0xb2));
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
            this.txtComment.DataBindings.Add(new Binding("Text", this.dataSetN, "tJ_RequestForRepair.Comment", true));
            this.txtComment.Location = new Point(0x6a, 100);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new Size(0x1b1, 20);
            this.txtComment.TabIndex = 1;
            this.txtAgreeWith.DataBindings.Add(new Binding("Text", this.dataSetN, "tJ_RequestForRepair.AgreeWith", true));
            this.txtAgreeWith.Location = new Point(0x6a, 0x4a);
            this.txtAgreeWith.Name = "txtAgreeWith";
            this.txtAgreeWith.Size = new Size(0x1b1, 20);
            this.txtAgreeWith.TabIndex = 0;
            this.buttonOK.DialogResult = DialogResult.OK;
            this.buttonOK.Location = new Point(15, 0x24b);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new Size(0x4b, 0x17);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new EventHandler(this.buttonOK_Click);
            this.buttonCancel.DialogResult = DialogResult.Cancel;
            this.buttonCancel.Location = new Point(0x1e5, 0x24b);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new Size(0x4b, 0x17);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new EventHandler(this.buttonCancel_Click);
            this.cmbUserCreate.DataBindings.Add(new Binding("SelectedValue", this.dataSetN, "tJ_RequestForRepair.idUserCreate", true));
            this.cmbUserCreate.Enabled = false;
            this.cmbUserCreate.FormattingEnabled = true;
            this.cmbUserCreate.Location = new Point(0x65, 5);
            this.cmbUserCreate.Name = "cmbUserCreate";
            this.cmbUserCreate.Size = new Size(0xb5, 0x15);
            this.cmbUserCreate.TabIndex = 12;
            this.label_13.AutoSize = true;
            this.label_13.Location = new Point(0x12e, 8);
            this.label_13.Name = "label15";
            this.label_13.Size = new Size(0x29, 13);
            this.label_13.TabIndex = 13;
            this.label_13.Text = "Номер";
            this.txtNum.DataBindings.Add(new Binding("Text", this.dataSetN, "tJ_RequestForRepair.num", true));
            this.txtNum.Location = new Point(0x166, 5);
            this.txtNum.Name = "txtNum";
            this.txtNum.ReadOnly = true;
            this.txtNum.Size = new Size(0xc6, 20);
            this.txtNum.TabIndex = 14;
            this.tabControl.Controls.Add(this.tabPageGeneral);
            this.tabControl.Controls.Add(this.tabPageSwitching);
            this.tabControl.Controls.Add(this.tabPageDocuments);
            this.tabControl.Location = new Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new Size(0x240, 0x245);
            this.tabControl.TabIndex = 0x31;
            this.tabPageGeneral.Controls.Add(this.comboBox_4);
            this.tabPageGeneral.Controls.Add(this.toolStripMain);
            this.tabPageGeneral.Controls.Add(this.cmbSR);
            this.tabPageGeneral.Controls.Add(this.label_0);
            this.tabPageGeneral.Controls.Add(this.groupBoxDaily);
            this.tabPageGeneral.Controls.Add(this.label_1);
            this.tabPageGeneral.Controls.Add(this.groupBoxODS);
            this.tabPageGeneral.Controls.Add(this.groupBox_0);
            this.tabPageGeneral.Controls.Add(this.label_2);
            this.tabPageGeneral.Controls.Add(this.cmbUserCreate);
            this.tabPageGeneral.Controls.Add(this.txtNum);
            this.tabPageGeneral.Controls.Add(this.label_13);
            this.tabPageGeneral.Location = new Point(4, 0x16);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new Padding(3);
            this.tabPageGeneral.Size = new Size(0x238, 0x22b);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "Общие";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            this.comboBox_4.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_4.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox_4.DataBindings.Add(new Binding("Text", this.dataSetN, "tJ_RequestForRepair.reguestFiled", true));
            this.comboBox_4.FormattingEnabled = true;
            this.comboBox_4.Location = new Point(0x65, 0x20);
            this.comboBox_4.Name = "txtRequestFiled";
            this.comboBox_4.Size = new Size(0xb5, 0x15);
            this.comboBox_4.TabIndex = 0x13;
            this.toolStripMain.Dock = DockStyle.None;
            this.toolStripMain.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.toolBtnCopy };
            this.toolStripMain.Items.AddRange(itemArray2);
            this.toolStripMain.Location = new Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new Size(0x1a, 0x19);
            this.toolStripMain.TabIndex = 0x12;
            this.toolStripMain.Text = "toolStrip1";
            this.toolBtnCopy.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnCopy.Image = global::RequestForRepair.Properties.Resources.CopyBuffer;
            this.toolBtnCopy.ImageTransparentColor = Color.Magenta;
            this.toolBtnCopy.Name = "toolBtnCopy";
            this.toolBtnCopy.Size = new Size(0x17, 0x16);
            this.toolBtnCopy.Text = "Копировать";
            this.toolBtnCopy.Click += new EventHandler(this.toolBtnCopy_Click);
            this.tabPageSwitching.Controls.Add(this.dgvLinkObjects);
            this.tabPageSwitching.Controls.Add(this.toolStripScheme);
            this.tabPageSwitching.Location = new Point(4, 0x16);
            this.tabPageSwitching.Name = "tabPageSwitching";
            this.tabPageSwitching.Padding = new Padding(3);
            this.tabPageSwitching.Size = new Size(0x238, 0x22b);
            this.tabPageSwitching.TabIndex = 1;
            this.tabPageSwitching.Text = "Оперативные переключения";
            this.tabPageSwitching.UseVisualStyleBackColor = true;
            this.dgvLinkObjects.AllowUserToAddRows = false;
            this.dgvLinkObjects.AllowUserToDeleteRows = false;
            this.dgvLinkObjects.AllowUserToOrderColumns = true;
            this.dgvLinkObjects.AllowUserToVisibleColumns = (false);
            this.dgvLinkObjects.AutoGenerateColumns = false;
            this.dgvLinkObjects.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLinkObjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray2 = new DataGridViewColumn[] 
            {
                this.dataGridViewTextBoxColumn_0,
                this.dataGridViewTextBoxColumn_1,
                this.dataGridViewTextBoxColumn_2,
                this.dataGridViewTextBoxColumn_3,
                this.dataGridViewTextBoxColumn_4
            };
            this.dgvLinkObjects.Columns.AddRange(columnArray2);
            this.dgvLinkObjects.DataSource = this.bindingSource_0;
            this.dgvLinkObjects.Dock = DockStyle.Fill;
            this.dgvLinkObjects.Location = new Point(3, 0x1c);
            this.dgvLinkObjects.Name = "dgvLinkObjects";
            this.dgvLinkObjects.ReadOnly = true;
            this.dgvLinkObjects.RowHeadersWidth = 0x15;
            this.dgvLinkObjects.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLinkObjects.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvLinkObjects.Size = new Size(0x232, 0x20c);
            this.dgvLinkObjects.TabIndex = 0x31;
            this.dgvLinkObjects.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvLinkObjects_CellDoubleClick);
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
            this.tabPageDocuments.Controls.Add(this.dgvDocs);
            this.tabPageDocuments.Controls.Add(this.toolStrip_1);
            this.tabPageDocuments.Location = new Point(4, 0x16);
            this.tabPageDocuments.Name = "tabPageDocuments";
            this.tabPageDocuments.Padding = new Padding(3);
            this.tabPageDocuments.Size = new Size(0x238, 0x22b);
            this.tabPageDocuments.TabIndex = 2;
            this.tabPageDocuments.Text = "Документы";
            this.tabPageDocuments.UseVisualStyleBackColor = true;
            this.dgvDocs.AllowUserToAddRows = false;
            this.dgvDocs.AllowUserToDeleteRows = false;
            this.dgvDocs.AutoGenerateColumns = false;
            this.dgvDocs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray6 = new DataGridViewColumn[]
            {
                this.idDataGridViewTextBoxColumnDoc,
                this.dataGridViewImageColumnNotNull_0,
                this.dataGridViewTextBoxColumn_6,
                this.dataGridViewLinkColumn_0,
                this.dataGridViewTextBoxColumn_7
            };
            this.dgvDocs.Columns.AddRange(columnArray6);
            this.dgvDocs.DataSource = this.bindingSource_1;
            this.dgvDocs.Dock = DockStyle.Fill;
            this.dgvDocs.Location = new Point(3, 0x1c);
            this.dgvDocs.Name = "dgvDocs";
            this.dgvDocs.RowHeadersWidth = 0x15;
            this.dgvDocs.Size = new Size(0x232, 0x20c);
            this.dgvDocs.TabIndex = 1;
            this.dgvDocs.VirtualMode = true;
            this.dgvDocs.CellContentClick += new DataGridViewCellEventHandler(this.dgvDocs_CellContentClick);
            this.dgvDocs.CellValueNeeded += new DataGridViewCellValueEventHandler(this.dgvDocs_CellValueNeeded);
            this.idDataGridViewTextBoxColumnDoc.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumnDoc.HeaderText = "id";
            this.idDataGridViewTextBoxColumnDoc.Name = "idDataGridViewTextBoxColumnDoc";
            this.idDataGridViewTextBoxColumnDoc.ReadOnly = true;
            this.idDataGridViewTextBoxColumnDoc.Visible = false;
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
            this.bindingSource_1.DataSource = this.dataSetN;
            ToolStripItem[] itemArray3 = new ToolStripItem[] { this.toolBtnAddDoc, this.toolBtnDelDoc, this.toolBtnViewDoc, this.toolBtnSaveDoc };
            this.toolStrip_1.Items.AddRange(itemArray3);
            this.toolStrip_1.Location = new Point(3, 3);
            this.toolStrip_1.Name = "toolStripDocuments";
            this.toolStrip_1.Size = new Size(0x232, 0x19);
            this.toolStrip_1.TabIndex = 0;
            this.toolStrip_1.Text = "toolStrip1";
            this.toolBtnAddDoc.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnAddDoc.Image = global::RequestForRepair.Properties.Resources.ElementAdd;
            this.toolBtnAddDoc.ImageTransparentColor = Color.Magenta;
            this.toolBtnAddDoc.Name = "toolBtnAddDoc";
            this.toolBtnAddDoc.Size = new Size(0x17, 0x16);
            this.toolBtnAddDoc.Text = "Добавить документ";
            this.toolBtnAddDoc.Click += new EventHandler(this.toolBtnAddDoc_Click);
            this.toolBtnDelDoc.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnDelDoc.Image = global::RequestForRepair.Properties.Resources.ElementDel;
            this.toolBtnDelDoc.ImageTransparentColor = Color.Magenta;
            this.toolBtnDelDoc.Name = "toolBtnDelDoc";
            this.toolBtnDelDoc.Size = new Size(0x17, 0x16);
            this.toolBtnDelDoc.Text = "Удалить документ";
            this.toolBtnDelDoc.Click += new EventHandler(this.toolBtnDelDoc_Click);
            this.toolBtnViewDoc.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnViewDoc.Image = global::RequestForRepair.Properties.Resources.ElementInformation;
            this.toolBtnViewDoc.ImageTransparentColor = Color.Magenta;
            this.toolBtnViewDoc.Name = "toolBtnViewDoc";
            this.toolBtnViewDoc.Size = new Size(0x17, 0x16);
            this.toolBtnViewDoc.Text = "Открыть документ";
            this.toolBtnViewDoc.Click += new EventHandler(this.toolBtnViewDoc_Click);
            this.toolBtnSaveDoc.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnSaveDoc.Image = global::RequestForRepair.Properties.Resources.ElementGo;
            this.toolBtnSaveDoc.ImageTransparentColor = Color.Magenta;
            this.toolBtnSaveDoc.Name = "toolBtnSaveDoc";
            this.toolBtnSaveDoc.Size = new Size(0x17, 0x16);
            this.toolBtnSaveDoc.Text = "Сохранить документ";
            this.toolBtnSaveDoc.Click += new EventHandler(this.toolBtnSaveDoc_Click);
            this.buttonCopy.Location = new Point(240, 0x24b);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new Size(0x4b, 0x17);
            this.buttonCopy.TabIndex = 50;
            this.buttonCopy.Text = "Копировать";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Visible = false;
            this.buttonCopy.Click += new EventHandler(this.toolBtnCopy_Click);
            base.AcceptButton = this.buttonOK;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.CancelButton = this.buttonCancel;
            base.ClientSize = new Size(0x23c, 0x26b);
            base.Controls.Add(this.buttonCopy);
            base.Controls.Add(this.tabControl);
            base.Controls.Add(this.buttonCancel);
            base.Controls.Add(this.buttonOK);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.MaximizeBox = false;
            base.Name = "FormJournalRequestForRepairAddEdit";
            this.Text = "FormJournalRequestForRepairAddEdit";
            base.FormClosing += new FormClosingEventHandler(this.FormJournalRequestForRepairAddEdit_FormClosing);
            base.FormClosed += new FormClosedEventHandler(this.FormJournalRequestForRepairAddEdit_FormClosed);
            base.Load += new EventHandler(this.FormJournalRequestForRepairAddEdit_Load);
            this.dataSetN.EndInit();
            this.groupBox_0.ResumeLayout(false);
            this.groupBox_0.PerformLayout();
            this.toolStripScheme.ResumeLayout(false);
            this.toolStripScheme.PerformLayout();
            this.groupBoxDaily.ResumeLayout(false);
            this.groupBoxDaily.PerformLayout();
            ((ISupportInitialize)this.dgvDaily).EndInit();
            this.groupBoxODS.ResumeLayout(false);
            this.groupBoxODS.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageGeneral.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.tabPageSwitching.ResumeLayout(false);
            this.tabPageSwitching.PerformLayout();
            ((ISupportInitialize)this.dgvLinkObjects).EndInit();
            ((ISupportInitialize)this.bindingSource_0).EndInit();
            this.dataSet_0.EndInit();
            this.dataTable_1.EndInit();
            this.dataTable_2.EndInit();
            this.tabPageDocuments.ResumeLayout(false);
            this.tabPageDocuments.PerformLayout();
            ((ISupportInitialize)this.dgvDocs).EndInit();
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
            this.cmbUserCreate.DataSource = table;
            this.cmbUserCreate.DisplayMember = "NAME";
            this.cmbUserCreate.ValueMember = "IDUSER";
            DataTable table2 = this.method_2();
            base.SelectSqlData(table2, true, " where ParentKey in (';GroupWorker;ITR;')  and dateend is null group by id, fio, groupelectrical order by fio ");
            this.cmbWorker.DataSource = table2;
            this.cmbWorker.DisplayMember = "FIO";
            this.cmbWorker.ValueMember = "ID";
            this.comboBox_4.DataSource = table2;
            this.comboBox_4.DisplayMember = "FIO";
            this.comboBox_4.ValueMember = "ID";
            DataTable table3 = this.method_2();
            base.SelectSqlData(table3, true, " where ParentKey in (';GroupWorker;ReconcileRequestRepair;')  and dateend is null group by id, fio, groupelectrical order by fio ");
            this.cmbDispatcher.DataSource = table3;
            this.cmbDispatcher.DisplayMember = "FIO";
            this.cmbDispatcher.ValueMember = "ID";
            base.SelectSqlData(this.dataSetN, this.dataSetN.tR_Classifier, true, " where ParentKey = ';NetworkAreas;' and deleted = 0 and isGroup = 0 order by name ");
            this.cmbSR.DataSource = this.dataSetN.tR_Classifier;
            this.cmbSR.DisplayMember = "name";
            this.cmbSR.ValueMember = "ID";
        }

        private void method_5()
        {
            this.dataTable_0 = new DataTable("tR_RequestForRepairClient");
            base.SelectSqlData(this.dataTable_0, true, "where type = 5 order by name");
            DataTable table = new DataTable("tR_RequestForRepairClient");
            table.Columns.Add("name", typeof(string));
            table.Columns.Add("value", typeof(int));
            this.cmbStatus.DataSource = table;
            this.cmbStatus.DisplayMember = "Name";
            this.cmbStatus.ValueMember = "Value";
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
            if (this.cmbSR.SelectedIndex < 0)
            {
                this.label_2.ForeColor = Color.Red;
                flag = false;
            }
            if (string.IsNullOrEmpty(this.txtObject.Text))
            {
                this.labelObject.ForeColor = Color.Red;
                flag = false;
            }
            if (string.IsNullOrEmpty(this.txtPurpose.Text))
            {
                this.labelPurpose.ForeColor = Color.Red;
                flag = false;
            }
            if (this.cmbIsPlanned.SelectedIndex < 0)
            {
                this.labelIsPlanned.ForeColor = Color.Red;
                flag = false;
            }
            if (this.dataSetN.tJ_RequestForRepairDaily.Rows.Count <= 0)
            {
                List<Color> list = new List<Color>();
                foreach (Control control in this.groupBoxDaily.Controls)
                {
                    list.Add(control.ForeColor);
                }
                this.groupBoxDaily.ForeColor = Color.Red;
                int num = 0;
                //using (IEnumerator enumerator = groupBox_2.Controls.GetEnumerator())
                //{
                //    while (enumerator.MoveNext())
                //    {
                //        ((Control)enumerator.Current).ForeColor = list[num];
                //        num++;
                //    }
                //}
                foreach(IEnumerator enumerator in groupBoxDaily.Controls)
                {
                        ((Control)enumerator.Current).ForeColor = list[num];
                        num++;
                }
                flag = false;
            }
            if ((this.checkBoxAgreed.Checked && (this.IdDivision == 920)) && (this.cmbStatus.SelectedIndex < 0))
            {
                this.labelStatus.ForeColor = Color.Red;
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
            if (this.dataSetN.tL_RequestForRepairSchmObjList.Rows.Count > 0)
            {
                DataRow row3;
                DataView defaultView = this.dataSetN.tL_RequestForRepairSchmObjList.DefaultView;
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
                    this.toolBtnViewSChmObj.Enabled = true;
                }
                else
                {
                    this.toolBtnViewSChmObj.Enabled = false;
                }
            }
        }

        private void method_9()
        {
            base.SelectSqlData(this.dataSetN, this.dataSetN.tL_RequestForRepairSchmObjList, true, " where idRequest = " + this.IdRequest.ToString());
            this.method_8();
        }

        private void txtPurpose0_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtPurpose.Text))
            {
                this.labelObject.ForeColor = SystemColors.ControlText;
            }
        }

        private void txtObject_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtObject.Text))
            {
                this.labelObject.ForeColor = SystemColors.ControlText;
            }
        }

        private void toolBtnLinkSchmObj_Click(object sender, EventArgs e)
        {
            FormLinkRequestAndSchm schm = new FormLinkRequestAndSchm();
            schm.SqlSettings = (this.SqlSettings);
            if (schm.ShowDialog() == DialogResult.OK)
            {
                int num = 1;
                if (this.dataSetN.tL_RequestForRepairSchmObjList.Rows.Count > 0)
                {
                    //num = this.dataSetN.tL_RequestForRepairSchmObjList
                    //    .Max<DataSetGES.Class53, short>((C_1.C_9__42_0 ?? (C_1.C_9__42_0 = new Func<DataSetGES.Class53, short>(C_1.C_9.method_7)))) + 1;
                    num = this.dataSetN.tL_RequestForRepairSchmObjList
                         .Max(r => r.Num) + 1;
                }
                this.dictionary_0 = schm.LinkObjects;
                foreach (int num2 in this.dictionary_0.Keys)
                {
                    DataRow row = this.dataSetN.tL_RequestForRepairSchmObjList.NewRow();
                    row["idRequest"] = this.IdRequest;
                    row["idSchmObj"] = num2;
                    row["DAteBeg"] = schm.DateBeg;
                    row["DAteEnd"] = schm.DateEnd;
                    row["duration"] = schm.Duration;
                    row["num"] = num;
                    this.dataSetN.tL_RequestForRepairSchmObjList.Rows.Add(row);
                }
                this.method_8();
            }
        }

        private void toolBtnDelSchmObj_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvLinkObjects.SelectedRows)
            {
                DataRow[] rowArray = this.dataSetN.tL_RequestForRepairSchmObjList.Select("num = " + row.Cells[this.dataGridViewTextBoxColumn_4.Name].Value.ToString());
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
            foreach (DataGridViewRow row in this.dgvLinkObjects.SelectedRows)
            {
                foreach (DataRow row2 in this.dataSetN.tL_RequestForRepairSchmObjList.Select("num = " + row.Cells[this.dataGridViewTextBoxColumn_4.Name].Value.ToString()))
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

        private void toolBtnLinkSchmObjEdit_Click(object sender, EventArgs e)
        {
            if (this.dgvLinkObjects.CurrentRow != null)
            {
                DataRow[] rowArray = this.dataSetN.tL_RequestForRepairSchmObjList.Select("num = " + this.dgvLinkObjects.CurrentRow.Cells[this.dataGridViewTextBoxColumn_4.Name].Value.ToString());
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
                            DataRow row3 = this.dataSetN.tL_RequestForRepairSchmObjList.NewRow();
                            row3["idRequest"] = this.IdRequest;
                            row3["idSchmObj"] = num2;
                            row3["DAteBeg"] = schm.DateBeg;
                            row3["DAteEnd"] = schm.DateEnd;
                            row3["duration"] = schm.Duration;
                            row3["num"] = schm.Num;
                            this.dataSetN.tL_RequestForRepairSchmObjList.Rows.Add(row3);
                        }
                        this.method_8();
                    }
                }
            }
        }

        private void toolBtnAddDoc_Click(object sender, EventArgs e)
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
                        DataRow row = this.dataSetN.tJ_RequestForRepairDoc.NewRow();
                        row["idRequest"] = this.IdRequest;
                        row["Document"] = File.ReadAllBytes(dialog.FileNames[i]);
                        row["FileName"] = Path.GetFileName(dialog.FileNames[i]);
                        this.dataSetN.tJ_RequestForRepairDoc.Rows.Add(row);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source);
            }
        }

        private void toolBtnDelDoc_Click(object sender, EventArgs e)
        {
            if (this.dgvDocs.CurrentRow != null)
            {
                Convert.ToInt32(this.dgvDocs.CurrentRow.Cells[this.idDataGridViewTextBoxColumnDoc.Name].Value);
                this.dgvDocs.Rows.Remove(this.dgvDocs.CurrentRow);
            }
            else
            {
                MessageBox.Show("Не выбрано ни одного файла");
            }
        }

        private void toolBtnViewDoc_Click(object sender, EventArgs e)
        {
            if (this.dgvDocs.CurrentRow != null)
            {
                int num = Convert.ToInt32(this.dgvDocs.CurrentRow.Cells[this.idDataGridViewTextBoxColumnDoc.Name].Value);
                //byte[] buffer = (byte[])this.dataSetN.tJ_RequestForRepairDoc.method_2(num)["Document"];
                //string path = Path.ChangeExtension(Path.GetTempFileName(), Path.GetExtension(this.dataSetN.tJ_RequestForRepairDoc.method_2(num)["FileName"].ToString()));

                byte[] buffer = (byte[])this.dataSetN.tJ_RequestForRepairDoc.Rows.Find(num)["Document"];
                string path = Path.ChangeExtension(Path.GetTempFileName(), Path.GetExtension(this.dataSetN.tJ_RequestForRepairDoc.Rows.Find(num)["FileName"].ToString()));


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

        private void toolBtnSaveDoc_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(this.dgvDocs.CurrentRow.Cells[this.idDataGridViewTextBoxColumnDoc.Name].Value);
                string path = this.dgvDocs.CurrentRow.Cells[this.dataGridViewLinkColumn_0.Name].Value.ToString();
                string extension = Path.GetExtension(path);
                SaveFileDialog dialog = new SaveFileDialog
                {
                    Filter = "(*" + extension + ")|*" + extension,
                    FileName = path
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // byte[] buffer = (byte[])this.dataSetN.tJ_RequestForRepairDoc.method_2(num)["Document"];
                    byte[] buffer = (byte[])this.dataSetN.tJ_RequestForRepairDoc.Rows.Find(num)["Document"];
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

        //[Serializable, CompilerGenerated]
        //private sealed class C_1
        //{
        //    public static readonly FormJournalRequestForRepairAddEdit.C_1 C_9 = new FormJournalRequestForRepairAddEdit.C_1();
        //    public static Func<DataSetGES.Class51, bool> C_9__27_0;
        //    public static Func<DataSetGES.Class51, DateTime> C_9__27_1;
        //    public static Func<DataSetGES.Class51, bool> C_9__28_0;
        //    public static Func<DataSetGES.Class51, bool> C_9__28_1;
        //    public static Func<DataSetGES.Class51, DateTime> C_9__28_2;
        //    public static Func<DataSetGES.Class51, bool> C_9__32_0;
        //    public static Func<DataSetGES.Class51, DateTime> C_9__32_1;
        //    public static Func<DataSetGES.Class53, short> C_9__42_0;

        //    internal bool method_0(DataSetGES.Class51 class51_0)
        //    {
        //        return ((class51_0.RowState != DataRowState.Deleted) && (class51_0.RowState != DataRowState.Detached));
        //    }

        //    internal DateTime method_1(DataSetGES.Class51 class51_0)
        //    {
        //        return class51_0.dateEnd;
        //    }

        //    internal bool method_2(DataSetGES.Class51 class51_0)
        //    {
        //        return ((class51_0.RowState != DataRowState.Deleted) && (class51_0.RowState != DataRowState.Detached));
        //    }

        //    internal bool method_3(DataSetGES.Class51 class51_0)
        //    {
        //        return ((class51_0.RowState != DataRowState.Deleted) && (class51_0.RowState != DataRowState.Detached));
        //    }

        //    internal DateTime method_4(DataSetGES.Class51 class51_0)
        //    {
        //        return class51_0.dateEnd;
        //    }

        //    internal bool method_5(DataSetGES.Class51 class51_0)
        //    {
        //        return ((class51_0.RowState != DataRowState.Deleted) && (class51_0.RowState != DataRowState.Detached));
        //    }

        //    internal DateTime method_6(DataSetGES.Class51 class51_0)
        //    {
        //        return class51_0.dateEnd;
        //    }

        //    internal short method_7(DataSetGES.Class53 class53_0)
        //    {
        //        return class53_0.Num;
        //    }
        //}
    }

}