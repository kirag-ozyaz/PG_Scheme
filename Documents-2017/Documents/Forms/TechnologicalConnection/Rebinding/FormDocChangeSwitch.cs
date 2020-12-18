namespace Documents.Forms.TechnologicalConnection.Rebinding
{
    using Constants;
    using ControlsLbr;
    using ControlsLbr.DataGridViewExcelFilter;
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
    using System.Windows.Forms;
    using System.Xml;

    public class FormDocChangeSwitch : FormBase
    {
        private BindingSource bindingSource_0;
        private BindingSource bindingSource_1;
        private BindingSource bindingSource_2;
        private bool bool_0;
        private bool bool_1;
        private Button button_0;
        private Button button_1;
        private CheckBox checkBox_0;
        private CheckBox checkBox_1;
        private ComboBox comboBox_0;
        private ComboBox comboBox_1;
        private ComboBox comboBox_2;
        private ComboBox comboBox_3;
        private ComboBox comboBox_4;
        private ComboBox comboBox_5;
        private ComboBox comboBox_6;
        private ComboBox comboBox_7;
        private DataColumn dataColumn_0;
        private DataColumn dataColumn_1;
        private DataColumn dataColumn_2;
        private DataColumn dataColumn_3;
        private DataColumn dataColumn_4;
        private DataColumn dataColumn_5;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_0;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_0;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_1;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_2;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;
        private DataGridViewImageColumnNotNull dataGridViewImageColumnNotNull_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;
        private DataSet dataSet_0;
        private DataSetTechConnection dataSetTechConnection_0;
        private DataTable dataTable_0;
        private DataTable dataTable_1;
        private DateTimePicker dateTimePicker_0;
        private Dictionary<string, FileWatcherArgsAddl> dictionary_0 = new Dictionary<string, FileWatcherArgsAddl>();
        private GroupBox groupBox_0;
        private GroupBox groupBox_1;
        private GroupBox groupBox_2;
        private IContainer icontainer_0;
        private Label label_0;
        private Label label_1;
        private Label label_10;
        private Label label_11;
        private Label label_12;
        private Label label_13;
        private Label label_2;
        private Label label_3;
        private Label label_4;
        private Label label_5;
        private Label label_6;
        private Label label_7;
        private Label label_8;
        private Label label_9;
        private int? nullable_0;
        private NullableDateTimePicker nullableDateTimePicker_0;
        private NullableDateTimePicker nullableDateTimePicker_1;
        private string string_0 = "";
        private TabControl tabControl_0;
        private TabPage tabPage_0;
        private TabPage tabPage_1;
        private TextBox textBox_0;
        private TextBox textBox_1;
        private ToolStrip toolStrip_0;
        private ToolStrip toolStrip_1;
        private ToolStripButton toolStripButton_0;
        private ToolStripButton toolStripButton_1;
        private ToolStripButton toolStripButton_2;
        private ToolStripButton toolStripButton_3;
        private ToolStripButton toolStripButton_4;
        private ToolStripButton toolStripButton_5;
        private ToolStripButton toolStripButton_6;
        private ToolStripButton toolStripButton_7;
        private ToolStripDropDownButton toolStripDropDownButton_0;
        private ToolStripMenuItem toolStripMenuItem_0;
        private ToolStripSeparator toolStripSeparator_0;
        private ToolStripSeparator toolStripSeparator_1;

        public FormDocChangeSwitch(int? idDoc = new int?(), bool isReadOnly = false)
        {
            this.method_39();
            this.nullable_0 = idDoc;
            this.bool_1 = isReadOnly;
            if (isReadOnly)
            {
                this.button_0.Visible = false;
            }
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            base.Close();
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

        private void checkBox_0_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_0.Checked)
            {
                this.nullableDateTimePicker_1.set_Value(DateTime.Now.Date);
                DataTable table = new DataTable("tUser");
                table.Columns.Add("idWorker", typeof(int));
                base.SelectSqlData(table, true, "where [Login] = SYSTEM_USER", false);
                if ((table.Rows.Count > 0) && (table.Rows[0]["idWorker"] != DBNull.Value))
                {
                    this.comboBox_7.SelectedValue = table.Rows[0]["idWorker"];
                }
            }
            else if (this.dataSetTechConnection_0.tTC_ChangeSwitch.Rows.Count > 0)
            {
                this.nullableDateTimePicker_1.set_Value(null);
                this.comboBox_7.SelectedIndex = -1;
            }
            this.bool_0 = true;
        }

        private void checkBox_1_CheckedChanged(object sender, EventArgs e)
        {
            using (IEnumerator enumerator = ((IEnumerable) this.dataGridViewExcelFilter_0.Rows).GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    ((DataGridViewRow) enumerator.Current).Cells[this.dataGridViewCheckBoxColumn_0.Name].Value = this.checkBox_1.Checked;
                }
            }
            this.bool_0 = true;
        }

        private void comboBox_0_SelectedValueChanged(object sender, EventArgs e)
        {
            this.bool_0 = true;
        }

        private void comboBox_4_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.method_12();
            this.bool_0 = true;
        }

        private void comboBox_5_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox box = (ComboBox) sender;
            ComboBox box2 = this.comboBox_4;
            if (box == this.comboBox_2)
            {
                box2 = this.comboBox_1;
            }
            if ((box.SelectedIndex >= 0) && (box.SelectedValue != null))
            {
                this.method_11(box2, Convert.ToInt32(box.SelectedValue));
            }
            else
            {
                box2.DataSource = null;
            }
            if (box == this.comboBox_5)
            {
                this.method_12();
            }
            this.bool_0 = true;
        }

        private void comboBox_6_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox box = (ComboBox) sender;
            ComboBox box2 = this.comboBox_5;
            if (box == this.comboBox_3)
            {
                box2 = this.comboBox_2;
            }
            if ((box.SelectedIndex >= 0) && (box.SelectedValue != null))
            {
                this.method_10(box2, Convert.ToInt32(box.SelectedValue));
            }
            else
            {
                box2.DataSource = null;
            }
            if (box == this.comboBox_6)
            {
                this.method_12();
            }
            this.bool_0 = true;
        }

        private void dataGridViewExcelFilter_0_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.bool_0 = true;
        }

        private void dataGridViewExcelFilter_2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.toolStripButton_6_Click(sender, e);
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

        private void FormDocChangeSwitch_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((base.DialogResult != DialogResult.OK) && ((this.bool_1 || !this.bool_0) || (MessageBox.Show("Сохранить внесенные изменения", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)))
            {
                base.DialogResult = DialogResult.Cancel;
            }
            else if (this.method_15())
            {
                if ((this.checkBox_0.Enabled && this.checkBox_0.Checked) && (MessageBox.Show("Привязка у объектов изменится!!! Провести документ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No))
                {
                    base.DialogResult = DialogResult.Cancel;
                    e.Cancel = true;
                }
                else if (this.method_16())
                {
                    base.DialogResult = DialogResult.OK;
                }
                else
                {
                    base.DialogResult = DialogResult.None;
                    e.Cancel = true;
                }
            }
            else
            {
                base.DialogResult = DialogResult.None;
                e.Cancel = true;
            }
        }

        private void FormDocChangeSwitch_Load(object sender, EventArgs e)
        {
            this.dateTimePicker_0.Value = DateTime.Now.Date;
            this.method_3();
            this.method_9();
            this.method_2();
            if (!this.nullable_0.HasValue)
            {
                this.method_0();
                this.method_1();
            }
            else
            {
                base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Doc, true, "where id = " + this.nullable_0.ToString());
                if (this.dataSetTechConnection_0.tTC_Doc.Rows.Count > 0)
                {
                    base.SelectSqlData(this.dataSetTechConnection_0.tTC_ChangeSwitch, true, "where id = " + this.nullable_0.ToString(), false);
                    if (this.dataSetTechConnection_0.tTC_ChangeSwitch.Rows.Count == 0)
                    {
                        this.method_1();
                    }
                    else
                    {
                        this.method_4();
                        if ((this.dataSetTechConnection_0.tTC_ChangeSwitch.Rows[0]["isApply"] != DBNull.Value) && Convert.ToBoolean(this.dataSetTechConnection_0.tTC_ChangeSwitch.Rows[0]["isApply"]))
                        {
                            this.groupBox_2.Enabled = false;
                            this.groupBox_1.Enabled = false;
                            this.checkBox_0.Enabled = false;
                            this.nullableDateTimePicker_1.Enabled = false;
                            this.comboBox_7.Enabled = false;
                            this.checkBox_1.Enabled = false;
                            this.dataGridViewExcelFilter_0.ReadOnly = true;
                        }
                        this.method_14();
                    }
                    this.method_32();
                }
                else
                {
                    this.method_0();
                    this.method_1();
                }
            }
            this.method_24();
            this.bool_0 = false;
        }

        private void FormDocChangeSwitch_Shown(object sender, EventArgs e)
        {
            this.method_13();
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
            DataRow row = this.dataSetTechConnection_0.tTC_Doc.NewRow();
            row["dateDoc"] = DateTime.Now.Date;
            row["typeDoc"] = 0x542;
            this.dataSetTechConnection_0.tTC_Doc.Rows.Add(row);
        }

        private void method_1()
        {
            DataRow row = this.dataSetTechConnection_0.tTC_ChangeSwitch.NewRow();
            row["id"] = this.dataSetTechConnection_0.tTC_Doc.Rows[0]["id"];
            row["idSchmObjOld"] = -1;
            row["idSchmObjNew"] = -1;
            row["isApply"] = false;
            this.dataSetTechConnection_0.tTC_ChangeSwitch.Rows.Add(row);
        }

        private void method_10(ComboBox comboBox_8, int int_0)
        {
            string str = "";
            foreach (SchmTypeBus bus in Enum.GetValues(typeof(SchmTypeBus)))
            {
                str = str + Convert.ToInt32(bus).ToString() + ",";
            }
            str = str.Remove(str.Length - 1);
            DataTable table = new DataTable("vSchm_ObjList");
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("typeCodeSocr", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("TypeName", typeof(string), "TypeCodeSocr + '-' + Name");
            comboBox_8.DataSource = table;
            comboBox_8.DisplayMember = "TypeName";
            comboBox_8.ValueMember = "id";
            base.SelectSqlData(table, true, "where idParent = " + int_0.ToString() + " and typecodeid in (" + str + ") and deleted = 0 order by typecodeSocr, name", false);
            comboBox_8.SelectedIndex = -1;
        }

        private void method_11(ComboBox comboBox_8, int int_0)
        {
            DataTable table = new DataTable("vSchm_TreeCellLine");
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("FullName", typeof(string));
            comboBox_8.DataSource = table;
            comboBox_8.DisplayMember = "FullName";
            comboBox_8.ValueMember = "id";
            base.SelectSqlData(table, true, " where ParentLink = " + int_0.ToString() + " order by fullname", false);
            comboBox_8.SelectedIndex = -1;
        }

        private void method_12()
        {
            int? nullable = null;
            if (this.comboBox_4.SelectedValue != null)
            {
                nullable = new int?(Convert.ToInt32(this.comboBox_4.SelectedValue));
            }
            else if (this.comboBox_5.SelectedValue != null)
            {
                nullable = new int?(Convert.ToInt32(this.comboBox_5.SelectedValue));
            }
            else
            {
                if (this.comboBox_6.SelectedValue == null)
                {
                    this.dataSetTechConnection_0.vAbnObj.Clear();
                    return;
                }
                nullable = new int?(Convert.ToInt32(this.comboBox_6.SelectedValue));
            }
            if (nullable.HasValue)
            {
                base.SelectSqlData(this.dataSetTechConnection_0.vAbnObj, true, string.Format(" inner join tl_schmAbn l on l.idAbnObj = vAbnObj.id  where l.idSchmObj = {0} and vAbnObj.deleted = 0 and vAbnObj.isActive = 1", nullable), false);
                using (IEnumerator enumerator = ((IEnumerable) this.dataGridViewExcelFilter_0.Rows).GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        ((DataGridViewRow) enumerator.Current).Cells[this.dataGridViewCheckBoxColumn_0.Name].Value = this.checkBox_1.Checked;
                    }
                    return;
                }
            }
            this.dataSetTechConnection_0.vAbnObj.Clear();
        }

        private void method_13()
        {
            if ((this.dataSetTechConnection_0.tTC_ChangeSwitch.Rows.Count == 0) || (this.dataSetTechConnection_0.tTC_ChangeSwitch.Rows[0]["listIdAbnObj"] == DBNull.Value))
            {
                return;
            }
            List<string> list = new List<string>();
            XmlDocument document = new XmlDocument();
            document.LoadXml(this.dataSetTechConnection_0.tTC_ChangeSwitch.Rows[0]["listIdAbnObj"].ToString());
            if (document == null)
            {
                return;
            }
            XmlNode node = document.SelectSingleNode("List");
            if (node == null)
            {
                return;
            }
            using (IEnumerator enumerator = node.SelectNodes("idAbnObj").GetEnumerator())
            {
            Label_00A7:
                if (!enumerator.MoveNext())
                {
                    goto Label_01A0;
                }
                XmlNode current = (XmlNode) enumerator.Current;
                if (string.IsNullOrEmpty(current.InnerText))
                {
                    goto Label_00A7;
                }
                int num = Convert.ToInt32(current.InnerText);
                bool flag = false;
                using (IEnumerator enumerator2 = ((IEnumerable) this.dataGridViewExcelFilter_0.Rows).GetEnumerator())
                {
                    DataGridViewRow row;
                    while (enumerator2.MoveNext())
                    {
                        row = (DataGridViewRow) enumerator2.Current;
                        if (Convert.ToInt32(row.Cells[this.dataGridViewTextBoxColumn_1.Name].Value) == num)
                        {
                            goto Label_0133;
                        }
                    }
                    goto Label_0181;
                Label_0133:
                    row.Cells[this.dataGridViewCheckBoxColumn_0.Name].Value = true;
                    flag = true;
                    goto Label_0181;
                }
            Label_016F:
                list.Add(num.ToString());
                goto Label_00A7;
            Label_0181:
                if (flag)
                {
                    goto Label_00A7;
                }
                goto Label_016F;
            }
        Label_01A0:
            if (list.Count > 0)
            {
                string str = string.Join(",", list.ToArray());
                DataSetTechConnection.vAbnObjDataTable table = new DataSetTechConnection.vAbnObjDataTable();
                base.SelectSqlData(table, true, "where id in (" + str + ")", false);
                foreach (DataRow row2 in table.Rows)
                {
                    this.dataSetTechConnection_0.vAbnObj.ImportRow(row2);
                    this.dataGridViewExcelFilter_0.Rows[this.dataGridViewExcelFilter_0.Rows.Count - 1].Cells[this.dataGridViewCheckBoxColumn_0.Name].Value = true;
                }
            }
            this.dataGridViewExcelFilter_0.Refresh();
        }

        private void method_14()
        {
            if ((this.dataSetTechConnection_0.tTC_ChangeSwitch.Rows.Count != 0) && (this.dataSetTechConnection_0.tTC_ChangeSwitch.Rows[0]["docsIn"] != DBNull.Value))
            {
                XmlDocument document = new XmlDocument();
                document.LoadXml(this.dataSetTechConnection_0.tTC_ChangeSwitch.Rows[0]["docsIn"].ToString());
                if (document != null)
                {
                    XmlNode node = document.SelectSingleNode("List");
                    if (node != null)
                    {
                        foreach (XmlNode node2 in node.SelectNodes("row"))
                        {
                            DataRow row = this.dataTable_0.NewRow();
                            foreach (DataColumn column in this.dataTable_0.Columns)
                            {
                                XmlAttribute attribute = node2.Attributes[column.ColumnName];
                                if ((attribute != null) && !string.IsNullOrEmpty(attribute.Value))
                                {
                                    if (column.DataType == typeof(DateTime))
                                    {
                                        row[column.ColumnName] = Convert.ToDateTime(attribute.Value);
                                    }
                                    else if (column.DataType == typeof(int))
                                    {
                                        row[column.ColumnName] = Convert.ToInt32(attribute.Value);
                                    }
                                    else
                                    {
                                        row[column.ColumnName] = attribute.Value;
                                    }
                                }
                            }
                            this.dataTable_0.Rows.Add(row);
                        }
                    }
                }
            }
        }

        private bool method_15()
        {
            return true;
        }

        private bool method_16()
        {
            if (!this.method_17())
            {
                return false;
            }
            if (!this.method_18())
            {
                return false;
            }
            if (!this.method_33())
            {
                return false;
            }
            return true;
        }

        private bool method_17()
        {
            this.dataSetTechConnection_0.tTC_Doc.Rows[0].EndEdit();
            if (!this.nullable_0.HasValue)
            {
                this.nullable_0 = new int?(base.InsertSqlDataOneRow(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Doc));
                int? nullable = this.nullable_0;
                if ((nullable.GetValueOrDefault() == -1) ? nullable.HasValue : false)
                {
                    return false;
                }
            }
            else if (!base.UpdateSqlData(this.dataSetTechConnection_0.tTC_Doc))
            {
                return false;
            }
            return true;
        }

        private bool method_18()
        {
            this.dataSetTechConnection_0.tTC_ChangeSwitch.Rows[0]["id"] = this.nullable_0;
            int? nullable = this.method_19();
            if (nullable.HasValue)
            {
                this.dataSetTechConnection_0.tTC_ChangeSwitch.Rows[0]["idSchmObjOld"] = nullable;
            }
            else
            {
                this.dataSetTechConnection_0.tTC_ChangeSwitch.Rows[0]["idSchmObjOld"] = DBNull.Value;
            }
            int? nullable2 = this.method_20();
            if (nullable2.HasValue)
            {
                this.dataSetTechConnection_0.tTC_ChangeSwitch.Rows[0]["idSchmObjNew"] = nullable2;
            }
            else
            {
                this.dataSetTechConnection_0.tTC_ChangeSwitch.Rows[0]["idSchmObjNew"] = DBNull.Value;
            }
            this.dataSetTechConnection_0.tTC_ChangeSwitch.Rows[0]["listIdAbnObj"] = this.method_22().InnerXml;
            if (this.nullableDateTimePicker_1.get_Value() == null)
            {
                this.dataSetTechConnection_0.tTC_ChangeSwitch.Rows[0]["dateApply"] = DBNull.Value;
            }
            else
            {
                this.dataSetTechConnection_0.tTC_ChangeSwitch.Rows[0]["dateApply"] = this.nullableDateTimePicker_1.get_Value();
            }
            if (this.comboBox_7.SelectedIndex < 0)
            {
                this.dataSetTechConnection_0.tTC_ChangeSwitch.Rows[0]["idWorkerApply"] = DBNull.Value;
            }
            else
            {
                this.dataSetTechConnection_0.tTC_ChangeSwitch.Rows[0]["idWorkerApply"] = this.comboBox_7.SelectedValue;
            }
            this.dataSetTechConnection_0.tTC_ChangeSwitch.Rows[0]["docsIn"] = this.method_23().InnerXml;
            this.dataSetTechConnection_0.tTC_ChangeSwitch.Rows[0].EndEdit();
            if (!base.InsertSqlData(this.dataSetTechConnection_0.tTC_ChangeSwitch))
            {
                return false;
            }
            if (!base.UpdateSqlData(this.dataSetTechConnection_0.tTC_ChangeSwitch))
            {
                return false;
            }
            if (!this.method_21(nullable, nullable2))
            {
                return false;
            }
            return true;
        }

        private int? method_19()
        {
            if (this.comboBox_4.SelectedIndex >= 0)
            {
                return new int?(Convert.ToInt32(this.comboBox_4.SelectedValue));
            }
            if (this.comboBox_5.SelectedIndex >= 0)
            {
                return new int?(Convert.ToInt32(this.comboBox_5.SelectedValue));
            }
            if (this.comboBox_6.SelectedIndex >= 0)
            {
                return new int?(Convert.ToInt32(this.comboBox_6.SelectedValue));
            }
            return null;
        }

        private void method_2()
        {
            DataTable table = new DataTable("vR_Worker");
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("fio", typeof(string));
            base.SelectSqlData(table, true, "where dateEnd is null order by fio", false);
            this.comboBox_7.DisplayMember = "fio";
            this.comboBox_7.ValueMember = "id";
            this.comboBox_7.DataSource = table;
            this.comboBox_7.SelectedIndex = -1;
        }

        private int? method_20()
        {
            if (this.comboBox_1.SelectedIndex >= 0)
            {
                return new int?(Convert.ToInt32(this.comboBox_1.SelectedValue));
            }
            if (this.comboBox_2.SelectedIndex >= 0)
            {
                return new int?(Convert.ToInt32(this.comboBox_2.SelectedValue));
            }
            if (this.comboBox_3.SelectedIndex >= 0)
            {
                return new int?(Convert.ToInt32(this.comboBox_3.SelectedValue));
            }
            return null;
        }

        private bool method_21(int? nullable_1, int? nullable_2)
        {
            if ((nullable_1.HasValue && nullable_2.HasValue) && (this.checkBox_0.Checked && this.checkBox_0.Enabled))
            {
                bool flag;
                List<string> list = new List<string>();
                foreach (DataGridViewRow row in (IEnumerable) this.dataGridViewExcelFilter_0.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[this.dataGridViewCheckBoxColumn_0.Name].Value))
                    {
                        list.Add(row.Cells[this.dataGridViewTextBoxColumn_1.Name].Value.ToString());
                    }
                }
                if (list.Count == 0)
                {
                    return true;
                }
                DataSetTechConnection.tL_SchmAbnDataTable table = new DataSetTechConnection.tL_SchmAbnDataTable();
                base.SelectSqlData(table, true, string.Format("where idSchmObj = {0} and idAbnObj in ({1}) and typeDoc = {2} and idDoc is not null", nullable_1, string.Join(",", list.ToArray()), 0x1f1), false);
                using (SqlConnection connection = new SqlConnection(this.get_SqlSettings().GetConnectionString()))
                {
                    try
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(string.Format("update tL_SchmAbn set idSchmObj = {0}, idDoc = {1}, TypeDoc = {2}  where idSchmObj = {3} and idAbnObj in ({4})", new object[] { nullable_2, this.nullable_0, 0x542, nullable_1, string.Join(",", list.ToArray()) }), connection))
                        {
                            command.ExecuteNonQuery();
                        }
                        if (table.Rows.Count > 0)
                        {
                            string str = "";
                            foreach (DataRow row2 in table.Rows)
                            {
                                if (string.IsNullOrEmpty(str))
                                {
                                    str = row2["idDoc"].ToString();
                                }
                                else
                                {
                                    str = str + "," + row2["idDoc"].ToString();
                                }
                            }
                            using (SqlCommand command2 = new SqlCommand(string.Format("update tAbnobjDoc_AKtRBP set idActRebinding = {0} where idList in ({1})", this.nullable_0, str), connection))
                            {
                                command2.ExecuteNonQuery();
                            }
                        }
                        goto Label_0289;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, exception.Source);
                        flag = false;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                return flag;
            }
        Label_0289:
            return true;
        }

        private XmlDocument method_22()
        {
            XmlDocument document = new XmlDocument();
            XmlNode newChild = document.CreateElement("List");
            document.AppendChild(newChild);
            foreach (DataGridViewRow row in (IEnumerable) this.dataGridViewExcelFilter_0.Rows)
            {
                if (Convert.ToBoolean(row.Cells[this.dataGridViewCheckBoxColumn_0.Name].Value))
                {
                    XmlNode node2 = document.CreateElement("idAbnObj");
                    node2.InnerText = row.Cells[this.dataGridViewTextBoxColumn_1.Name].Value.ToString();
                    newChild.AppendChild(node2);
                }
            }
            return document;
        }

        private XmlDocument method_23()
        {
            XmlDocument document = new XmlDocument();
            XmlNode newChild = document.CreateElement("List");
            document.AppendChild(newChild);
            foreach (DataRow row in this.dataTable_0.Rows)
            {
                XmlNode node2 = document.CreateElement("row");
                foreach (DataColumn column in this.dataTable_0.Columns)
                {
                    XmlAttribute node = document.CreateAttribute(column.ColumnName);
                    if (row[column.ColumnName] != DBNull.Value)
                    {
                        node.Value = row[column.ColumnName].ToString();
                    }
                    node2.Attributes.Append(node);
                }
                newChild.AppendChild(node2);
            }
            return document;
        }

        private void method_24()
        {
        }

        private string method_25(string string_1, int? nullable_1 = new int?(), byte[] byte_0 = null)
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
            FileWatcherArgsAddl addl = new FileWatcherArgsAddl(nullable_1, fileName, null, 2);
            this.dictionary_0.Add(fileName, addl);
            DataSetTechConnection.Class252 class2 = this.dataSetTechConnection_0.tTC_DocFile.method_5();
            class2.idDoc = -1;
            class2.FileName = fileName;
            if (byte_0 == null)
            {
                FileBinary binary = new FileBinary(string_1);
                class2.File = binary.get_ByteArray();
                class2.dateChange = binary.get_LastChanged();
            }
            else
            {
                class2.File = byte_0;
                class2.dateChange = DateTime.Now;
            }
            if (nullable_1.HasValue)
            {
                class2.idTemplate = nullable_1.Value;
            }
            this.dataSetTechConnection_0.tTC_DocFile.method_0(class2);
            return fileName;
        }

        private void method_26(object sender, EventArgs e)
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
            str3 = this.method_31();
            string str4 = FileBinary.GetNewFileNameIsExists(str3, str, false);
            string str5 = this.method_25(str, new int?(tag), buffer);
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
                    watcher.add_AnyChanged(new FileSystemEventHandler(this.method_28));
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

        private void method_27(bool bool_2 = false)
        {
            if (this.bindingSource_1.Current != null)
            {
                byte[] file;
                DataSetTechConnection.Class252 row = (DataSetTechConnection.Class252) ((DataRowView) this.bindingSource_1.Current).Row;
                string fileName = row.FileName;
                string str2 = this.method_31();
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
                if (bool_2)
                {
                    if (this.dictionary_0.ContainsKey(fileName))
                    {
                        if (this.dictionary_0[fileName].get_Watcher() == null)
                        {
                            FileWatcher watcher = new FileWatcher(str2, str3);
                            watcher.add_AnyChanged(new FileSystemEventHandler(this.method_28));
                            watcher.Start();
                            this.dictionary_0[fileName].set_Watcher(watcher);
                        }
                        else
                        {
                            this.dictionary_0[fileName].get_Watcher().remove_AnyChanged(new FileSystemEventHandler(this.method_28));
                            this.dictionary_0[fileName].get_Watcher().Stop();
                            FileWatcher watcher2 = new FileWatcher(str2, str3);
                            watcher2.add_AnyChanged(new FileSystemEventHandler(this.method_28));
                            watcher2.Start();
                            this.dictionary_0[fileName].set_Watcher(watcher2);
                        }
                        this.dictionary_0[fileName].set_TempName(str3);
                        this.dictionary_0[fileName].set_OpenState(1);
                    }
                    else
                    {
                        FileWatcher watcher3 = new FileWatcher(str2, str3);
                        watcher3.add_AnyChanged(new FileSystemEventHandler(this.method_28));
                        watcher3.Start();
                        FileWatcherArgsAddl addl = new FileWatcherArgsAddl(nullable, fileName, str3, watcher3, 1);
                        this.dictionary_0.Add(fileName, addl);
                    }
                }
            }
        }

        private void method_28(object sender, FileSystemEventArgs e)
        {
            Class283 class2 = new Class283 {
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
                    if (this.nullable_0.HasValue)
                    {
                        row.idDoc = this.nullable_0.Value;
                    }
                    else
                    {
                        row.idDoc = -1;
                    }
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
            this.method_30();
        }

        private bool method_29(string string_1)
        {
            Class284 class2 = new Class284 {
                string_0 = string_1
            };
            return (this.dataSetTechConnection_0.tTC_DocFile.Where<DataSetTechConnection.Class252>(new Func<DataSetTechConnection.Class252, bool>(class2.method_0)).Count<DataSetTechConnection.Class252>() > 0);
        }

        private void method_3()
        {
            DataTable table = new DataTable("tR_Classifier");
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("name", typeof(string));
            base.SelectSqlData(table, true, "where ParentKey = ';TechConnect;TypeDoc;Rebinding;TypeDocInRebinding;' and isGroup = 0 and deleted = 0 order by name", false);
            this.comboBox_0.DisplayMember = "name";
            this.comboBox_0.ValueMember = "id";
            this.comboBox_0.DataSource = table;
            this.comboBox_0.SelectedIndex = -1;
            base.SelectSqlData(this.dataTable_1, true, "where ParentKey = ';TechConnect;TypeDoc;Rebinding;TypeDocInRebinding;' and isGroup = 0 order by name", false);
        }

        private void method_30()
        {
            if (base.InvokeRequired)
            {
                base.Invoke(new Action(this.method_40));
            }
            else
            {
                this.bindingSource_1.ResetBindings(false);
            }
        }

        private string method_31()
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

        private void method_32()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(this.get_SqlSettings().GetConnectionString()))
                {
                    connection.Open();
                    SqlDataReader reader = new SqlCommand("SELECT id, idDoc, FileName, dateChange, idTemplate FROM tTC_DocFile WHERE idDoc = " + this.nullable_0.ToString(), connection).ExecuteReader();
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

        private bool method_33()
        {
            foreach (DataRow row in this.dataSetTechConnection_0.tTC_DocFile)
            {
                if ((row.RowState != DataRowState.Deleted) && (row.RowState != DataRowState.Detached))
                {
                    int? nullable = this.nullable_0;
                    if ((Convert.ToInt32(row["idDoc"]) == nullable.GetValueOrDefault()) ? !nullable.HasValue : true)
                    {
                        row["idDoc"] = this.nullable_0;
                        row.EndEdit();
                    }
                }
            }
            if ((base.InsertSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_DocFile) && base.UpdateSqlDataOnlyChange(this.dataSetTechConnection_0.tTC_DocFile)) && base.DeleteSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_DocFile))
            {
                this.dataSetTechConnection_0.tTC_DocFile.AcceptChanges();
                return true;
            }
            return false;
        }

        private void method_34(object sender, DataGridViewCellValueEventArgs e)
        {
            if ((((DataGridView) sender).RowCount > 0) && (this.dataGridViewExcelFilter_1[this.dataGridViewFilterTextBoxColumn_0.Name, e.RowIndex].Value != null))
            {
                if (e.ColumnIndex == this.dataGridViewExcelFilter_1.Columns[this.dataGridViewImageColumnNotNull_0.Name].Index)
                {
                    if (!string.IsNullOrEmpty(Path.GetFileName(this.dataGridViewExcelFilter_1[this.dataGridViewFilterTextBoxColumn_0.Name, e.RowIndex].Value.ToString())))
                    {
                        e.Value = Path.GetFileName(this.dataGridViewExcelFilter_1[this.dataGridViewFilterTextBoxColumn_0.Name, e.RowIndex].Value.ToString());
                    }
                    else
                    {
                        e.Value = this.dataGridViewExcelFilter_1[this.dataGridViewFilterTextBoxColumn_0.Name, e.RowIndex].Value.ToString();
                    }
                }
                if (e.ColumnIndex == this.dataGridViewExcelFilter_1.Columns[this.dataGridViewImageColumnNotNull_0.Name].Index)
                {
                    Icon icon = FileInfo.IconOfFile(this.dataGridViewExcelFilter_1[this.dataGridViewFilterTextBoxColumn_0.Name, e.RowIndex].Value.ToString());
                    if (icon != null)
                    {
                        e.Value = icon.ToBitmap();
                    }
                }
            }
        }

        private void method_35(object sender, DataGridViewCellEventArgs e)
        {
            this.toolStripButton_1_Click(sender, e);
        }

        private void method_36(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridViewExcelFilter_1.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_0.ReadOnly = true;
            string key = this.dataGridViewExcelFilter_1[e.ColumnIndex, e.RowIndex].Value.ToString() + Path.GetExtension(this.string_0);
            if (key != this.string_0)
            {
                if (this.dictionary_0.ContainsKey(this.string_0))
                {
                    FileWatcherArgsAddl addl = this.dictionary_0[this.string_0];
                    addl.set_OriginalName(key);
                    this.dictionary_0.Remove(this.string_0);
                    this.dictionary_0.Add(key, addl);
                    this.dataGridViewExcelFilter_1[e.ColumnIndex, e.RowIndex].Value = key;
                    this.bool_0 = true;
                }
                this.string_0 = null;
            }
        }

        private void method_37(object sender, DataGridViewCellValidatingEventArgs e)
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

        private void method_38(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (((e.RowIndex >= 0) && (e.ColumnIndex >= 0)) && (e.Button == MouseButtons.Right))
            {
                this.dataGridViewExcelFilter_1.ClearSelection();
                this.dataGridViewExcelFilter_1.Rows[e.RowIndex].Selected = true;
                this.dataGridViewExcelFilter_1.CurrentCell = this.dataGridViewExcelFilter_1[e.ColumnIndex, e.RowIndex];
                this.dataGridViewExcelFilter_1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
            }
        }

        private void method_39()
        {
            this.icontainer_0 = new Container();
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            this.tabControl_0 = new TabControl();
            this.tabPage_0 = new TabPage();
            this.comboBox_7 = new ComboBox();
            this.dataSetTechConnection_0 = new DataSetTechConnection();
            this.label_12 = new Label();
            this.nullableDateTimePicker_1 = new NullableDateTimePicker();
            this.label_13 = new Label();
            this.checkBox_1 = new CheckBox();
            this.dataGridViewExcelFilter_0 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
            this.bindingSource_0 = new BindingSource(this.icontainer_0);
            this.label_5 = new Label();
            this.groupBox_1 = new GroupBox();
            this.label_6 = new Label();
            this.comboBox_1 = new ComboBox();
            this.label_7 = new Label();
            this.comboBox_2 = new ComboBox();
            this.comboBox_3 = new ComboBox();
            this.label_8 = new Label();
            this.groupBox_2 = new GroupBox();
            this.label_9 = new Label();
            this.comboBox_4 = new ComboBox();
            this.label_10 = new Label();
            this.comboBox_5 = new ComboBox();
            this.comboBox_6 = new ComboBox();
            this.label_11 = new Label();
            this.checkBox_0 = new CheckBox();
            this.label_0 = new Label();
            this.textBox_0 = new TextBox();
            this.label_1 = new Label();
            this.groupBox_0 = new GroupBox();
            this.dataGridViewExcelFilter_2 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewComboBoxColumn_0 = new DataGridViewComboBoxColumn();
            this.dataSet_0 = new DataSet();
            this.dataTable_0 = new DataTable();
            this.dataColumn_0 = new DataColumn();
            this.dataColumn_1 = new DataColumn();
            this.dataColumn_2 = new DataColumn();
            this.dataColumn_3 = new DataColumn();
            this.dataTable_1 = new DataTable();
            this.dataColumn_4 = new DataColumn();
            this.dataColumn_5 = new DataColumn();
            this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_12 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_13 = new DataGridViewTextBoxColumn();
            this.bindingSource_2 = new BindingSource(this.icontainer_0);
            this.toolStrip_1 = new ToolStrip();
            this.toolStripButton_5 = new ToolStripButton();
            this.toolStripButton_6 = new ToolStripButton();
            this.toolStripButton_7 = new ToolStripButton();
            this.comboBox_0 = new ComboBox();
            this.label_2 = new Label();
            this.nullableDateTimePicker_0 = new NullableDateTimePicker();
            this.label_3 = new Label();
            this.textBox_1 = new TextBox();
            this.label_4 = new Label();
            this.dateTimePicker_0 = new DateTimePicker();
            this.tabPage_1 = new TabPage();
            this.dataGridViewExcelFilter_1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewImageColumnNotNull_0 = new DataGridViewImageColumnNotNull();
            this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
            this.bindingSource_1 = new BindingSource(this.icontainer_0);
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
            this.button_0 = new Button();
            this.button_1 = new Button();
            this.tabControl_0.SuspendLayout();
            this.tabPage_0.SuspendLayout();
            this.dataSetTechConnection_0.BeginInit();
            this.dataGridViewExcelFilter_0.BeginInit();
            ((ISupportInitialize) this.bindingSource_0).BeginInit();
            this.groupBox_1.SuspendLayout();
            this.groupBox_2.SuspendLayout();
            this.groupBox_0.SuspendLayout();
            this.dataGridViewExcelFilter_2.BeginInit();
            this.dataSet_0.BeginInit();
            this.dataTable_0.BeginInit();
            this.dataTable_1.BeginInit();
            ((ISupportInitialize) this.bindingSource_2).BeginInit();
            this.toolStrip_1.SuspendLayout();
            this.tabPage_1.SuspendLayout();
            this.dataGridViewExcelFilter_1.BeginInit();
            ((ISupportInitialize) this.bindingSource_1).BeginInit();
            this.toolStrip_0.SuspendLayout();
            base.SuspendLayout();
            this.tabControl_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.tabControl_0.Controls.Add(this.tabPage_0);
            this.tabControl_0.Controls.Add(this.tabPage_1);
            this.tabControl_0.Location = new Point(0, 0);
            this.tabControl_0.Name = "tabControl";
            this.tabControl_0.SelectedIndex = 0;
            this.tabControl_0.Size = new Size(0x23c, 0x1c5);
            this.tabControl_0.TabIndex = 0;
            this.tabPage_0.Controls.Add(this.comboBox_7);
            this.tabPage_0.Controls.Add(this.label_12);
            this.tabPage_0.Controls.Add(this.nullableDateTimePicker_1);
            this.tabPage_0.Controls.Add(this.label_13);
            this.tabPage_0.Controls.Add(this.checkBox_1);
            this.tabPage_0.Controls.Add(this.dataGridViewExcelFilter_0);
            this.tabPage_0.Controls.Add(this.label_5);
            this.tabPage_0.Controls.Add(this.groupBox_1);
            this.tabPage_0.Controls.Add(this.groupBox_2);
            this.tabPage_0.Controls.Add(this.checkBox_0);
            this.tabPage_0.Controls.Add(this.label_0);
            this.tabPage_0.Controls.Add(this.textBox_0);
            this.tabPage_0.Controls.Add(this.label_1);
            this.tabPage_0.Controls.Add(this.groupBox_0);
            this.tabPage_0.Controls.Add(this.dateTimePicker_0);
            this.tabPage_0.Location = new Point(4, 0x16);
            this.tabPage_0.Name = "tabPage1";
            this.tabPage_0.Padding = new Padding(3);
            this.tabPage_0.Size = new Size(0x234, 0x1ab);
            this.tabPage_0.TabIndex = 0;
            this.tabPage_0.Text = "Общие";
            this.tabPage_0.UseVisualStyleBackColor = true;
            this.comboBox_7.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.comboBox_7.DataBindings.Add(new Binding("SelectedValue", this.dataSetTechConnection_0, "tTC_ChangeSwitch.idWorkerApply", true));
            this.comboBox_7.FormattingEnabled = true;
            this.comboBox_7.Location = new Point(0x1ad, 0x191);
            this.comboBox_7.Name = "cmbWorkerApply";
            this.comboBox_7.Size = new Size(0x84, 0x15);
            this.comboBox_7.TabIndex = 0x1d;
            this.comboBox_7.SelectedValueChanged += new EventHandler(this.comboBox_0_SelectedValueChanged);
            this.dataSetTechConnection_0.DataSetName = "DataSetTechConnection";
            this.dataSetTechConnection_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.label_12.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.label_12.AutoSize = true;
            this.label_12.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.label_12.Location = new Point(0x14f, 0x195);
            this.label_12.Name = "label14";
            this.label_12.Size = new Size(0x58, 13);
            this.label_12.TabIndex = 0x1c;
            this.label_12.Text = "Согласующий";
            this.nullableDateTimePicker_1.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.nullableDateTimePicker_1.DataBindings.Add(new Binding("Value", this.dataSetTechConnection_0, "tTC_ChangeSwitch.dateApply", true));
            this.nullableDateTimePicker_1.Location = new Point(180, 0x191);
            this.nullableDateTimePicker_1.Name = "dtpApply";
            this.nullableDateTimePicker_1.Size = new Size(0x95, 20);
            this.nullableDateTimePicker_1.TabIndex = 0x1b;
            this.nullableDateTimePicker_1.set_Value(new DateTime(0x7df, 4, 0x1c, 8, 0x16, 0x1f, 0x26d));
            this.nullableDateTimePicker_1.ValueChanged += new EventHandler(this.dateTimePicker_0_ValueChanged);
            this.label_13.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.label_13.AutoSize = true;
            this.label_13.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.label_13.Location = new Point(0x89, 0x195);
            this.label_13.Name = "label13";
            this.label_13.Size = new Size(0x25, 13);
            this.label_13.TabIndex = 0x1a;
            this.label_13.Text = "Дата";
            this.checkBox_1.AutoSize = true;
            this.checkBox_1.Checked = true;
            this.checkBox_1.CheckState = CheckState.Checked;
            this.checkBox_1.Location = new Point(0x4b, 0x11b);
            this.checkBox_1.Name = "checkBoxSelAll";
            this.checkBox_1.Size = new Size(0x5b, 0x11);
            this.checkBox_1.TabIndex = 0x19;
            this.checkBox_1.Text = "Выбрать все";
            this.checkBox_1.UseVisualStyleBackColor = true;
            this.checkBox_1.CheckedChanged += new EventHandler(this.checkBox_1_CheckedChanged);
            this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToResizeRows = false;
            this.dataGridViewExcelFilter_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
            this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewCheckBoxColumn_0, this.dataGridViewTextBoxColumn_0, this.dataGridViewTextBoxColumn_1, this.dataGridViewTextBoxColumn_2, this.dataGridViewTextBoxColumn_3, this.dataGridViewTextBoxColumn_4, this.dataGridViewTextBoxColumn_5, this.dataGridViewTextBoxColumn_6, this.dataGridViewTextBoxColumn_7 };
            this.dataGridViewExcelFilter_0.Columns.AddRange(dataGridViewColumns);
            this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
            this.dataGridViewExcelFilter_0.Location = new Point(0, 300);
            this.dataGridViewExcelFilter_0.Name = "dgvAbnObj";
            this.dataGridViewExcelFilter_0.RowHeadersVisible = false;
            this.dataGridViewExcelFilter_0.Size = new Size(0x234, 0x62);
            this.dataGridViewExcelFilter_0.TabIndex = 0x18;
            this.dataGridViewExcelFilter_0.CellValueChanged += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_0_CellValueChanged);
            this.dataGridViewCheckBoxColumn_0.HeaderText = "";
            this.dataGridViewCheckBoxColumn_0.Name = "cmbChecked";
            this.dataGridViewCheckBoxColumn_0.Resizable = DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn_0.SortMode = DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn_0.Width = 50;
            this.dataGridViewTextBoxColumn_0.DataPropertyName = "CodeAbonent";
            this.dataGridViewTextBoxColumn_0.HeaderText = "Код";
            this.dataGridViewTextBoxColumn_0.Name = "codeAbonentDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewTextBoxColumn_1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_1.HeaderText = "id";
            this.dataGridViewTextBoxColumn_1.Name = "idAbnObjDgvColumn";
            this.dataGridViewTextBoxColumn_1.Visible = false;
            this.dataGridViewTextBoxColumn_2.DataPropertyName = "idAbn";
            this.dataGridViewTextBoxColumn_2.HeaderText = "idAbn";
            this.dataGridViewTextBoxColumn_2.Name = "idAbnDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_2.Visible = false;
            this.dataGridViewTextBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn_3.HeaderText = "Абонент";
            this.dataGridViewTextBoxColumn_3.Name = "nameDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_3.ReadOnly = true;
            this.dataGridViewTextBoxColumn_4.DataPropertyName = "TypeAbn";
            this.dataGridViewTextBoxColumn_4.HeaderText = "TypeAbn";
            this.dataGridViewTextBoxColumn_4.Name = "typeAbnDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_4.Visible = false;
            this.dataGridViewTextBoxColumn_5.DataPropertyName = "typeAbnName";
            this.dataGridViewTextBoxColumn_5.HeaderText = "typeAbnName";
            this.dataGridViewTextBoxColumn_5.Name = "typeAbnNameDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_5.Visible = false;
            this.dataGridViewTextBoxColumn_6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_6.DataPropertyName = "nameObj";
            this.dataGridViewTextBoxColumn_6.HeaderText = "Объект";
            this.dataGridViewTextBoxColumn_6.Name = "nameObjDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_6.ReadOnly = true;
            this.dataGridViewTextBoxColumn_7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_7.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn_7.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn_7.Name = "addressDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_7.ReadOnly = true;
            this.bindingSource_0.DataMember = "vAbnObj";
            this.bindingSource_0.DataSource = this.dataSetTechConnection_0;
            this.label_5.AutoSize = true;
            this.label_5.Location = new Point(0x10, 0x11c);
            this.label_5.Name = "label12";
            this.label_5.Size = new Size(0x35, 13);
            this.label_5.TabIndex = 0x17;
            this.label_5.Text = "Объекты";
            this.groupBox_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.groupBox_1.Controls.Add(this.label_6);
            this.groupBox_1.Controls.Add(this.comboBox_1);
            this.groupBox_1.Controls.Add(this.label_7);
            this.groupBox_1.Controls.Add(this.comboBox_2);
            this.groupBox_1.Controls.Add(this.comboBox_3);
            this.groupBox_1.Controls.Add(this.label_8);
            this.groupBox_1.Location = new Point(6, 0xd9);
            this.groupBox_1.Name = "groupBoxNewSchm";
            this.groupBox_1.Size = new Size(550, 0x40);
            this.groupBox_1.TabIndex = 0x16;
            this.groupBox_1.TabStop = false;
            this.groupBox_1.Text = "Новый объект";
            this.label_6.AutoSize = true;
            this.label_6.Location = new Point(0x133, 0x10);
            this.label_6.Name = "label9";
            this.label_6.Size = new Size(0x2c, 13);
            this.label_6.TabIndex = 5;
            this.label_6.Text = "Ячейка";
            this.comboBox_1.FormattingEnabled = true;
            this.comboBox_1.Location = new Point(0x128, 0x20);
            this.comboBox_1.Name = "cmbCellNew";
            this.comboBox_1.Size = new Size(0x79, 0x15);
            this.comboBox_1.TabIndex = 4;
            this.comboBox_1.SelectedValueChanged += new EventHandler(this.comboBox_0_SelectedValueChanged);
            this.label_7.AutoSize = true;
            this.label_7.Location = new Point(0xa9, 0x10);
            this.label_7.Name = "label10";
            this.label_7.Size = new Size(0x22, 13);
            this.label_7.TabIndex = 3;
            this.label_7.Text = "Шина";
            this.comboBox_2.FormattingEnabled = true;
            this.comboBox_2.Location = new Point(160, 0x20);
            this.comboBox_2.Name = "cmbBusNew";
            this.comboBox_2.Size = new Size(0x79, 0x15);
            this.comboBox_2.TabIndex = 2;
            this.comboBox_2.SelectedIndexChanged += new EventHandler(this.comboBox_5_SelectedIndexChanged);
            this.comboBox_2.SelectedValueChanged += new EventHandler(this.comboBox_0_SelectedValueChanged);
            this.comboBox_3.FormattingEnabled = true;
            this.comboBox_3.Location = new Point(13, 0x20);
            this.comboBox_3.Name = "cmbSubNew";
            this.comboBox_3.Size = new Size(0x79, 0x15);
            this.comboBox_3.TabIndex = 1;
            this.comboBox_3.SelectedIndexChanged += new EventHandler(this.comboBox_6_SelectedIndexChanged);
            this.comboBox_3.SelectedValueChanged += new EventHandler(this.comboBox_0_SelectedValueChanged);
            this.label_8.AutoSize = true;
            this.label_8.Location = new Point(10, 0x10);
            this.label_8.Name = "label11";
            this.label_8.Size = new Size(0x44, 13);
            this.label_8.TabIndex = 0;
            this.label_8.Text = "Подстанция";
            this.groupBox_2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.groupBox_2.Controls.Add(this.label_9);
            this.groupBox_2.Controls.Add(this.comboBox_4);
            this.groupBox_2.Controls.Add(this.label_10);
            this.groupBox_2.Controls.Add(this.comboBox_5);
            this.groupBox_2.Controls.Add(this.comboBox_6);
            this.groupBox_2.Controls.Add(this.label_11);
            this.groupBox_2.Location = new Point(6, 0x93);
            this.groupBox_2.Name = "groupBoxOldSchm";
            this.groupBox_2.Size = new Size(550, 0x40);
            this.groupBox_2.TabIndex = 0x15;
            this.groupBox_2.TabStop = false;
            this.groupBox_2.Text = "Старый объект";
            this.label_9.AutoSize = true;
            this.label_9.Location = new Point(0x133, 0x10);
            this.label_9.Name = "label8";
            this.label_9.Size = new Size(0x2c, 13);
            this.label_9.TabIndex = 5;
            this.label_9.Text = "Ячейка";
            this.comboBox_4.FormattingEnabled = true;
            this.comboBox_4.Location = new Point(0x128, 0x20);
            this.comboBox_4.Name = "cmbCellOld";
            this.comboBox_4.Size = new Size(0x79, 0x15);
            this.comboBox_4.TabIndex = 4;
            this.comboBox_4.SelectedIndexChanged += new EventHandler(this.comboBox_4_SelectedIndexChanged);
            this.comboBox_4.SelectedValueChanged += new EventHandler(this.comboBox_0_SelectedValueChanged);
            this.label_10.AutoSize = true;
            this.label_10.Location = new Point(0xa9, 0x10);
            this.label_10.Name = "label7";
            this.label_10.Size = new Size(0x22, 13);
            this.label_10.TabIndex = 3;
            this.label_10.Text = "Шина";
            this.comboBox_5.FormattingEnabled = true;
            this.comboBox_5.Location = new Point(160, 0x20);
            this.comboBox_5.Name = "cmbBusOld";
            this.comboBox_5.Size = new Size(0x79, 0x15);
            this.comboBox_5.TabIndex = 2;
            this.comboBox_5.SelectedIndexChanged += new EventHandler(this.comboBox_5_SelectedIndexChanged);
            this.comboBox_5.SelectedValueChanged += new EventHandler(this.comboBox_0_SelectedValueChanged);
            this.comboBox_6.FormattingEnabled = true;
            this.comboBox_6.Location = new Point(13, 0x20);
            this.comboBox_6.Name = "cmbSubOld";
            this.comboBox_6.Size = new Size(0x79, 0x15);
            this.comboBox_6.TabIndex = 1;
            this.comboBox_6.SelectedIndexChanged += new EventHandler(this.comboBox_6_SelectedIndexChanged);
            this.comboBox_6.SelectedValueChanged += new EventHandler(this.comboBox_0_SelectedValueChanged);
            this.label_11.AutoSize = true;
            this.label_11.Location = new Point(10, 0x10);
            this.label_11.Name = "label6";
            this.label_11.Size = new Size(0x44, 13);
            this.label_11.TabIndex = 0;
            this.label_11.Text = "Подстанция";
            this.checkBox_0.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.checkBox_0.AutoSize = true;
            this.checkBox_0.DataBindings.Add(new Binding("Checked", this.dataSetTechConnection_0, "tTC_ChangeSwitch.isApply", true));
            this.checkBox_0.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.checkBox_0.Location = new Point(11, 0x194);
            this.checkBox_0.Name = "checkBoxApply";
            this.checkBox_0.Size = new Size(0x67, 0x11);
            this.checkBox_0.TabIndex = 20;
            this.checkBox_0.Text = "Согласовано";
            this.checkBox_0.TextAlign = ContentAlignment.MiddleCenter;
            this.checkBox_0.UseVisualStyleBackColor = true;
            this.checkBox_0.CheckedChanged += new EventHandler(this.checkBox_0_CheckedChanged);
            this.label_0.AutoSize = true;
            this.label_0.Location = new Point(8, 12);
            this.label_0.Name = "label1";
            this.label_0.Size = new Size(0x4b, 13);
            this.label_0.TabIndex = 5;
            this.label_0.Text = "№ документа";
            this.textBox_0.BackColor = SystemColors.Window;
            this.textBox_0.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tTC_Doc.numDoc", true));
            this.textBox_0.Location = new Point(0x59, 9);
            this.textBox_0.Name = "txtDocNum";
            this.textBox_0.ReadOnly = true;
            this.textBox_0.Size = new Size(0x52, 20);
            this.textBox_0.TabIndex = 6;
            this.label_1.AutoSize = true;
            this.label_1.Location = new Point(0xb1, 12);
            this.label_1.Name = "label2";
            this.label_1.Size = new Size(90, 13);
            this.label_1.TabIndex = 7;
            this.label_1.Text = "Дата документа";
            this.groupBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.groupBox_0.Controls.Add(this.dataGridViewExcelFilter_2);
            this.groupBox_0.Controls.Add(this.toolStrip_1);
            this.groupBox_0.Controls.Add(this.comboBox_0);
            this.groupBox_0.Controls.Add(this.label_2);
            this.groupBox_0.Controls.Add(this.nullableDateTimePicker_0);
            this.groupBox_0.Controls.Add(this.label_3);
            this.groupBox_0.Controls.Add(this.textBox_1);
            this.groupBox_0.Controls.Add(this.label_4);
            this.groupBox_0.Location = new Point(8, 0x27);
            this.groupBox_0.Name = "groupBoxDocIn";
            this.groupBox_0.Size = new Size(550, 0x6b);
            this.groupBox_0.TabIndex = 9;
            this.groupBox_0.TabStop = false;
            this.groupBox_0.Text = "Регламентирующие документы";
            this.dataGridViewExcelFilter_2.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_2.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_2.AutoGenerateColumns = false;
            this.dataGridViewExcelFilter_2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray2 = new DataGridViewColumn[] { this.dataGridViewComboBoxColumn_0, this.dataGridViewTextBoxColumn_11, this.dataGridViewTextBoxColumn_12, this.dataGridViewTextBoxColumn_13 };
            this.dataGridViewExcelFilter_2.Columns.AddRange(columnArray2);
            this.dataGridViewExcelFilter_2.DataSource = this.bindingSource_2;
            this.dataGridViewExcelFilter_2.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_2.Location = new Point(0x1b, 0x10);
            this.dataGridViewExcelFilter_2.Name = "dgvDocIn";
            this.dataGridViewExcelFilter_2.ReadOnly = true;
            this.dataGridViewExcelFilter_2.Size = new Size(520, 0x58);
            this.dataGridViewExcelFilter_2.TabIndex = 7;
            this.dataGridViewExcelFilter_2.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_2_CellDoubleClick);
            this.dataGridViewComboBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewComboBoxColumn_0.DataPropertyName = "typeDoc";
            this.dataGridViewComboBoxColumn_0.DataSource = this.dataSet_0;
            this.dataGridViewComboBoxColumn_0.DisplayMember = "tR_Classifier.name";
            this.dataGridViewComboBoxColumn_0.HeaderText = "Тип";
            this.dataGridViewComboBoxColumn_0.Name = "typeDocDataGridViewTextBoxColumn";
            this.dataGridViewComboBoxColumn_0.ReadOnly = true;
            this.dataGridViewComboBoxColumn_0.Resizable = DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn_0.SortMode = DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn_0.ValueMember = "tR_Classifier.id";
            this.dataSet_0.DataSetName = "NewDataSet";
            DataTable[] tables = new DataTable[] { this.dataTable_0, this.dataTable_1 };
            this.dataSet_0.Tables.AddRange(tables);
            DataColumn[] columns = new DataColumn[] { this.dataColumn_0, this.dataColumn_1, this.dataColumn_2, this.dataColumn_3 };
            this.dataTable_0.Columns.AddRange(columns);
            this.dataTable_0.TableName = "dtDocIn";
            this.dataColumn_0.ColumnName = "numDoc";
            this.dataColumn_1.ColumnName = "dateDoc";
            this.dataColumn_1.DataType = typeof(DateTime);
            this.dataColumn_2.ColumnName = "typeDoc";
            this.dataColumn_2.DataType = typeof(int);
            this.dataColumn_3.ColumnName = "Comment";
            DataColumn[] columnArray4 = new DataColumn[] { this.dataColumn_4, this.dataColumn_5 };
            this.dataTable_1.Columns.AddRange(columnArray4);
            this.dataTable_1.TableName = "tR_Classifier";
            this.dataColumn_4.ColumnName = "id";
            this.dataColumn_4.DataType = typeof(int);
            this.dataColumn_5.ColumnName = "name";
            this.dataGridViewTextBoxColumn_11.DataPropertyName = "numDoc";
            this.dataGridViewTextBoxColumn_11.HeaderText = "№ док.";
            this.dataGridViewTextBoxColumn_11.Name = "numDocDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_11.ReadOnly = true;
            this.dataGridViewTextBoxColumn_11.Width = 80;
            this.dataGridViewTextBoxColumn_12.DataPropertyName = "dateDoc";
            this.dataGridViewTextBoxColumn_12.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn_12.Name = "dateDocDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_12.ReadOnly = true;
            this.dataGridViewTextBoxColumn_12.Width = 80;
            this.dataGridViewTextBoxColumn_13.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_13.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn_13.HeaderText = "Комментарий";
            this.dataGridViewTextBoxColumn_13.Name = "commentDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_13.ReadOnly = true;
            this.bindingSource_2.DataMember = "dtDocIn";
            this.bindingSource_2.DataSource = this.dataSet_0;
            this.toolStrip_1.Dock = DockStyle.Left;
            this.toolStrip_1.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripButton_5, this.toolStripButton_6, this.toolStripButton_7 };
            this.toolStrip_1.Items.AddRange(toolStripItems);
            this.toolStrip_1.Location = new Point(3, 0x10);
            this.toolStrip_1.Name = "toolStripDocIn";
            this.toolStrip_1.Size = new Size(0x18, 0x58);
            this.toolStrip_1.TabIndex = 6;
            this.toolStrip_1.Text = "toolStrip1";
            this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_5.Image = Resources.ElementAdd;
            this.toolStripButton_5.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_5.Name = "toolBtnAddDocIn";
            this.toolStripButton_5.Size = new Size(0x15, 20);
            this.toolStripButton_5.Text = "toolStripButton1";
            this.toolStripButton_5.Click += new EventHandler(this.toolStripButton_5_Click);
            this.toolStripButton_6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_6.Image = Resources.ElementEdit;
            this.toolStripButton_6.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_6.Name = "toolBtnEditDocIn";
            this.toolStripButton_6.Size = new Size(0x15, 20);
            this.toolStripButton_6.Text = "toolStripButton2";
            this.toolStripButton_6.Click += new EventHandler(this.toolStripButton_6_Click);
            this.toolStripButton_7.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_7.Image = Resources.ElementDel;
            this.toolStripButton_7.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_7.Name = "toolBtnDelDocIn";
            this.toolStripButton_7.Size = new Size(0x15, 20);
            this.toolStripButton_7.Text = "toolStripButton3";
            this.toolStripButton_7.Click += new EventHandler(this.toolStripButton_7_Click);
            this.comboBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.comboBox_0.DataBindings.Add(new Binding("SelectedValue", this.dataSetTechConnection_0, "tTC_ChangeSwitch.TypeDocIn", true));
            this.comboBox_0.FormattingEnabled = true;
            this.comboBox_0.Location = new Point(0xac, 0x17);
            this.comboBox_0.Name = "cmbTypeDocIn";
            this.comboBox_0.Size = new Size(0xd4, 0x15);
            this.comboBox_0.TabIndex = 5;
            this.comboBox_0.SelectedValueChanged += new EventHandler(this.comboBox_0_SelectedValueChanged);
            this.label_2.AutoSize = true;
            this.label_2.Location = new Point(0xb2, 15);
            this.label_2.Name = "label5";
            this.label_2.Size = new Size(0x53, 13);
            this.label_2.TabIndex = 4;
            this.label_2.Text = "Тип документа";
            this.nullableDateTimePicker_0.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.nullableDateTimePicker_0.set_CustomFormat("");
            this.nullableDateTimePicker_0.DataBindings.Add(new Binding("Value", this.dataSetTechConnection_0, "tTC_ChangeSwitch.dateDocIn", true));
            this.nullableDateTimePicker_0.Location = new Point(0x1ad, 0x15);
            this.nullableDateTimePicker_0.Name = "dtpDateDocIn";
            this.nullableDateTimePicker_0.Size = new Size(0x73, 20);
            this.nullableDateTimePicker_0.TabIndex = 3;
            this.nullableDateTimePicker_0.set_Value(new DateTime(0x7dd, 4, 15, 13, 0x1c, 0x35, 0x324));
            this.nullableDateTimePicker_0.ValueChanged += new EventHandler(this.dateTimePicker_0_ValueChanged);
            this.label_3.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.label_3.AutoSize = true;
            this.label_3.Location = new Point(390, 0x1a);
            this.label_3.Name = "label3";
            this.label_3.Size = new Size(0x21, 13);
            this.label_3.TabIndex = 2;
            this.label_3.Text = "Дата";
            this.textBox_1.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tTC_ChangeSwitch.numDocIn", true));
            this.textBox_1.Location = new Point(0x39, 0x18);
            this.textBox_1.Name = "txtNumDocIn";
            this.textBox_1.Size = new Size(0x6a, 20);
            this.textBox_1.TabIndex = 1;
            this.textBox_1.TextChanged += new EventHandler(this.textBox_1_TextChanged);
            this.label_4.AutoSize = true;
            this.label_4.Location = new Point(10, 0x1b);
            this.label_4.Name = "label4";
            this.label_4.Size = new Size(0x29, 13);
            this.label_4.TabIndex = 0;
            this.label_4.Text = "Номер";
            this.dateTimePicker_0.DataBindings.Add(new Binding("Value", this.dataSetTechConnection_0, "tTC_Doc.dateDoc", true));
            this.dateTimePicker_0.Location = new Point(0x111, 9);
            this.dateTimePicker_0.Name = "dtpDateDoc";
            this.dateTimePicker_0.Size = new Size(0x92, 20);
            this.dateTimePicker_0.TabIndex = 8;
            this.dateTimePicker_0.ValueChanged += new EventHandler(this.dateTimePicker_0_ValueChanged);
            this.tabPage_1.Controls.Add(this.dataGridViewExcelFilter_1);
            this.tabPage_1.Controls.Add(this.toolStrip_0);
            this.tabPage_1.Location = new Point(4, 0x16);
            this.tabPage_1.Name = "tabPage2";
            this.tabPage_1.Padding = new Padding(3);
            this.tabPage_1.Size = new Size(0x234, 0x1ab);
            this.tabPage_1.TabIndex = 1;
            this.tabPage_1.Text = "Файлы";
            this.tabPage_1.UseVisualStyleBackColor = true;
            this.dataGridViewExcelFilter_1.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_1.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_1.AllowUserToResizeColumns = false;
            this.dataGridViewExcelFilter_1.AllowUserToResizeRows = false;
            this.dataGridViewExcelFilter_1.AutoGenerateColumns = false;
            this.dataGridViewExcelFilter_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray5 = new DataGridViewColumn[] { this.dataGridViewImageColumnNotNull_0, this.dataGridViewFilterTextBoxColumn_0, this.dataGridViewTextBoxColumn_8, this.dataGridViewTextBoxColumn_9, this.dataGridViewTextBoxColumn_10 };
            this.dataGridViewExcelFilter_1.Columns.AddRange(columnArray5);
            this.dataGridViewExcelFilter_1.DataSource = this.bindingSource_1;
            this.dataGridViewExcelFilter_1.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_1.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewExcelFilter_1.Location = new Point(3, 0x1c);
            this.dataGridViewExcelFilter_1.Name = "dgvFile";
            this.dataGridViewExcelFilter_1.ReadOnly = true;
            this.dataGridViewExcelFilter_1.RowHeadersVisible = false;
            this.dataGridViewExcelFilter_1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExcelFilter_1.Size = new Size(0x22e, 0x18c);
            this.dataGridViewExcelFilter_1.TabIndex = 8;
            this.dataGridViewExcelFilter_1.VirtualMode = true;
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
            this.dataGridViewTextBoxColumn_8.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_8.HeaderText = "id";
            this.dataGridViewTextBoxColumn_8.Name = "id";
            this.dataGridViewTextBoxColumn_8.ReadOnly = true;
            this.dataGridViewTextBoxColumn_8.Visible = false;
            this.dataGridViewTextBoxColumn_9.DataPropertyName = "dateChange";
            this.dataGridViewTextBoxColumn_9.HeaderText = "dateChange";
            this.dataGridViewTextBoxColumn_9.Name = "dateChangeDgvColumn";
            this.dataGridViewTextBoxColumn_9.ReadOnly = true;
            this.dataGridViewTextBoxColumn_9.Visible = false;
            this.dataGridViewTextBoxColumn_10.DataPropertyName = "idTemplate";
            this.dataGridViewTextBoxColumn_10.HeaderText = "idTemplate";
            this.dataGridViewTextBoxColumn_10.Name = "idTemplateDgvColumn";
            this.dataGridViewTextBoxColumn_10.ReadOnly = true;
            this.dataGridViewTextBoxColumn_10.Visible = false;
            this.bindingSource_1.DataMember = "tTC_DocFile";
            this.bindingSource_1.DataSource = this.dataSetTechConnection_0;
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.toolStripDropDownButton_0, this.toolStripButton_0, this.toolStripButton_1, this.toolStripButton_2, this.toolStripSeparator_1, this.toolStripButton_3, this.toolStripButton_4 };
            this.toolStrip_0.Items.AddRange(itemArray2);
            this.toolStrip_0.Location = new Point(3, 3);
            this.toolStrip_0.Name = "toolStripFile";
            this.toolStrip_0.Size = new Size(0x22e, 0x19);
            this.toolStrip_0.TabIndex = 7;
            this.toolStrip_0.Text = "toolStrip1";
            this.toolStripDropDownButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripItem[] itemArray3 = new ToolStripItem[] { this.toolStripMenuItem_0, this.toolStripSeparator_0 };
            this.toolStripDropDownButton_0.DropDownItems.AddRange(itemArray3);
            this.toolStripDropDownButton_0.Image = Resources.ElementAdd;
            this.toolStripDropDownButton_0.ImageTransparentColor = Color.Magenta;
            this.toolStripDropDownButton_0.Name = "toolBtnAddFile";
            this.toolStripDropDownButton_0.Size = new Size(0x1d, 0x16);
            this.toolStripDropDownButton_0.Text = "Добавить файл";
            this.toolStripMenuItem_0.Name = "toolItemAddExistFile";
            this.toolStripMenuItem_0.Size = new Size(190, 0x16);
            this.toolStripMenuItem_0.Text = "Сущесвующий файл";
            this.toolStripMenuItem_0.Click += new EventHandler(this.toolStripMenuItem_0_Click);
            this.toolStripSeparator_0.Name = "toolStripSeparator2";
            this.toolStripSeparator_0.Size = new Size(0xbb, 6);
            this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_0.Image = Resources.ElementEdit;
            this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_0.Name = "toolBtnEditFile";
            this.toolStripButton_0.Size = new Size(0x17, 0x16);
            this.toolStripButton_0.Text = "Редактировать файл";
            this.toolStripButton_0.Click += new EventHandler(this.toolStripButton_0_Click);
            this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_1.Image = Resources.ElementInformation;
            this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_1.Name = "toolBtnOpenFile";
            this.toolStripButton_1.Size = new Size(0x17, 0x16);
            this.toolStripButton_1.Text = "Открыть файл";
            this.toolStripButton_1.Click += new EventHandler(this.toolStripButton_1_Click);
            this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_2.Image = Resources.ElementDel;
            this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_2.Name = "toolBtnDelFile";
            this.toolStripButton_2.Size = new Size(0x17, 0x16);
            this.toolStripButton_2.Text = "Удалить файл";
            this.toolStripButton_2.Click += new EventHandler(this.toolStripButton_2_Click);
            this.toolStripSeparator_1.Name = "toolStripSeparator3";
            this.toolStripSeparator_1.Size = new Size(6, 0x19);
            this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_3.Image = Resources.rename;
            this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_3.Name = "toolBtnRenameFile";
            this.toolStripButton_3.Size = new Size(0x17, 0x16);
            this.toolStripButton_3.Text = "Переименовать";
            this.toolStripButton_3.Click += new EventHandler(this.toolStripButton_3_Click);
            this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_4.Image = Resources.save;
            this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_4.Name = "toolBtnSaveFile";
            this.toolStripButton_4.Size = new Size(0x17, 0x16);
            this.toolStripButton_4.Text = "Сохранить файл на диск";
            this.toolStripButton_4.Click += new EventHandler(this.toolStripButton_4_Click);
            this.button_0.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.button_0.DialogResult = DialogResult.OK;
            this.button_0.Location = new Point(0x15d, 0x1cb);
            this.button_0.Name = "buttonSaveAndClose";
            this.button_0.Size = new Size(0x84, 0x17);
            this.button_0.TabIndex = 0x15;
            this.button_0.Text = "Сохранить и закрыть";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new EventHandler(this.button_0_Click);
            this.button_1.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.button_1.DialogResult = DialogResult.Cancel;
            this.button_1.Location = new Point(0x1e7, 0x1cb);
            this.button_1.Name = "buttonClose";
            this.button_1.Size = new Size(0x4b, 0x17);
            this.button_1.TabIndex = 20;
            this.button_1.Text = "Закрыть";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new EventHandler(this.button_1_Click);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x23c, 0x1eb);
            base.Controls.Add(this.button_0);
            base.Controls.Add(this.button_1);
            base.Controls.Add(this.tabControl_0);
            base.Name = "FormDocChangeSwitch";
            this.Text = "Смена рубильника";
            base.FormClosing += new FormClosingEventHandler(this.FormDocChangeSwitch_FormClosing);
            base.Load += new EventHandler(this.FormDocChangeSwitch_Load);
            base.Shown += new EventHandler(this.FormDocChangeSwitch_Shown);
            this.tabControl_0.ResumeLayout(false);
            this.tabPage_0.ResumeLayout(false);
            this.tabPage_0.PerformLayout();
            this.dataSetTechConnection_0.EndInit();
            this.dataGridViewExcelFilter_0.EndInit();
            ((ISupportInitialize) this.bindingSource_0).EndInit();
            this.groupBox_1.ResumeLayout(false);
            this.groupBox_1.PerformLayout();
            this.groupBox_2.ResumeLayout(false);
            this.groupBox_2.PerformLayout();
            this.groupBox_0.ResumeLayout(false);
            this.groupBox_0.PerformLayout();
            this.dataGridViewExcelFilter_2.EndInit();
            this.dataSet_0.EndInit();
            this.dataTable_0.EndInit();
            this.dataTable_1.EndInit();
            ((ISupportInitialize) this.bindingSource_2).EndInit();
            this.toolStrip_1.ResumeLayout(false);
            this.toolStrip_1.PerformLayout();
            this.tabPage_1.ResumeLayout(false);
            this.tabPage_1.PerformLayout();
            this.dataGridViewExcelFilter_1.EndInit();
            ((ISupportInitialize) this.bindingSource_1).EndInit();
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            base.ResumeLayout(false);
        }

        private void method_4()
        {
            if (this.dataSetTechConnection_0.tTC_ChangeSwitch.Rows.Count != 0)
            {
                if (this.dataSetTechConnection_0.tTC_ChangeSwitch.Rows[0]["idSchmObjOld"] != DBNull.Value)
                {
                    this.method_5(Convert.ToInt32(this.dataSetTechConnection_0.tTC_ChangeSwitch.Rows[0]["idSchmObjOld"]), true);
                }
                if (this.dataSetTechConnection_0.tTC_ChangeSwitch.Rows[0]["idSchmObjNew"] != DBNull.Value)
                {
                    this.method_5(Convert.ToInt32(this.dataSetTechConnection_0.tTC_ChangeSwitch.Rows[0]["idSchmObjNew"]), false);
                }
            }
        }

        [CompilerGenerated]
        private void method_40()
        {
            this.bindingSource_1.ResetBindings(false);
        }

        private void method_5(int int_0, bool bool_2)
        {
            DataTable table = new DataTable("tSchm_ObjList");
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("typeCodeId", typeof(int));
            base.SelectSqlData(table, true, "where id = " + int_0, false);
            if (table.Rows.Count > 0)
            {
                int num2;
                int num3;
                if (this.method_6(Convert.ToInt32(table.Rows[0]["TypeCodeId"])))
                {
                    int num = Convert.ToInt32(table.Rows[0]["id"]);
                    string str = "";
                    foreach (SchmTypeBus bus in Enum.GetValues(typeof(SchmTypeBus)))
                    {
                        str = str + Convert.ToInt32(bus).ToString() + ",";
                    }
                    str = str.Remove(str.Length - 1);
                    DataTable table2 = new DataTable("vSchm_TreeCellLine");
                    table2.Columns.Add("ParentLink", typeof(int));
                    base.SelectSqlData(table2, true, " left join vSchm_ObjList l on vSchm_TreeCellLine.ParentLink = l.id  where vSchm_TreeCellLine.id = " + num.ToString() + " and l.typeCodeId in (" + str + ")", false);
                    if (table2.Rows.Count > 0)
                    {
                        num2 = Convert.ToInt32(table2.Rows[0]["ParentLink"]);
                        DataTable table3 = new DataTable("tSchm_ObjList");
                        table3.Columns.Add("idParent", typeof(int));
                        base.SelectSqlData(table3, true, "where id = " + num2.ToString(), false);
                        if ((table3.Rows.Count > 0) && (table3.Rows[0]["idParent"] != DBNull.Value))
                        {
                            num3 = Convert.ToInt32(table3.Rows[0]["idParent"]);
                            if (bool_2)
                            {
                                this.comboBox_6.SelectedValue = num3;
                                this.comboBox_5.SelectedValue = num2;
                                this.comboBox_4.SelectedValue = num;
                            }
                            else
                            {
                                this.comboBox_3.SelectedValue = num3;
                                this.comboBox_2.SelectedValue = num2;
                                this.comboBox_1.SelectedValue = num;
                            }
                        }
                    }
                }
                else if (this.method_7(Convert.ToInt32(table.Rows[0]["TypeCodeId"])))
                {
                    num2 = int_0;
                    DataTable table4 = new DataTable("tSchm_ObjList");
                    table4.Columns.Add("idParent", typeof(int));
                    base.SelectSqlData(table4, true, "where id = " + num2.ToString(), false);
                    if ((table4.Rows.Count > 0) && (table4.Rows[0]["idParent"] != DBNull.Value))
                    {
                        num3 = Convert.ToInt32(table4.Rows[0]["idParent"]);
                        if (bool_2)
                        {
                            this.comboBox_6.SelectedValue = num3;
                            this.comboBox_5.SelectedValue = num2;
                        }
                        else
                        {
                            this.comboBox_3.SelectedValue = num3;
                            this.comboBox_2.SelectedValue = num2;
                        }
                    }
                }
                else if (this.method_8(Convert.ToInt32(table.Rows[0]["TypeCodeId"])))
                {
                    num3 = int_0;
                    if (bool_2)
                    {
                        this.comboBox_6.SelectedValue = num3;
                    }
                    else
                    {
                        this.comboBox_3.SelectedValue = num3;
                    }
                }
            }
        }

        private bool method_6(int int_0)
        {
            using (IEnumerator enumerator = Enum.GetValues(typeof(SchmTypeCell)).GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    if (((SchmTypeBus) enumerator.Current) == int_0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool method_7(int int_0)
        {
            using (IEnumerator enumerator = Enum.GetValues(typeof(SchmTypeBus)).GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    if (((SchmTypeBus) enumerator.Current) == int_0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool method_8(int int_0)
        {
            using (IEnumerator enumerator = Enum.GetValues(typeof(SchmTypeSubstation)).GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    if (((SchmTypeBus) enumerator.Current) == int_0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void method_9()
        {
            string str = "";
            foreach (SchmTypeSubstation substation in Enum.GetValues(typeof(SchmTypeSubstation)))
            {
                str = str + Convert.ToInt32(substation).ToString() + ",";
            }
            str = str.Remove(str.Length - 1);
            DataTable table = new DataTable("vSchm_ObjList");
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("typeCodeSocr", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("TypeName", typeof(string), "TypeCodeSocr + '-' + Name");
            BindingSource source = new BindingSource {
                DataSource = table
            };
            this.comboBox_6.DataSource = source;
            this.comboBox_6.DisplayMember = "TypeName";
            this.comboBox_6.ValueMember = "id";
            BindingSource source2 = new BindingSource {
                DataSource = table
            };
            this.comboBox_3.DataSource = source2;
            this.comboBox_3.DisplayMember = "TypeName";
            this.comboBox_3.ValueMember = "id";
            base.SelectSqlData(table, true, "where typecodeid in (" + str + ") and deleted = 0 order by typecodeSocr, name", false);
        }

        private void textBox_1_TextChanged(object sender, EventArgs e)
        {
            this.bool_0 = true;
        }

        private void toolStripButton_0_Click(object sender, EventArgs e)
        {
            this.method_27(true);
        }

        private void toolStripButton_1_Click(object sender, EventArgs e)
        {
            this.method_27(false);
        }

        private void toolStripButton_2_Click(object sender, EventArgs e)
        {
            if ((this.bindingSource_1.Current != null) && (MessageBox.Show("Вы действительно хотите удалить выбранный файл?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                DataSetTechConnection.Class252 row = (DataSetTechConnection.Class252) ((DataRowView) this.bindingSource_1.Current).Row;
                string fileName = row.FileName;
                if (this.dictionary_0.ContainsKey(fileName))
                {
                    if (this.dictionary_0[fileName].get_Watcher() != null)
                    {
                        this.dictionary_0[fileName].get_Watcher().remove_AnyChanged(new FileSystemEventHandler(this.method_28));
                        this.dictionary_0[fileName].get_Watcher().Stop();
                    }
                    this.dictionary_0.Remove(fileName);
                }
                row.Delete();
                this.bool_0 = true;
            }
        }

        private void toolStripButton_3_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_1.CurrentRow != null)
            {
                this.string_0 = this.dataGridViewExcelFilter_1.CurrentRow.Cells[this.dataGridViewFilterTextBoxColumn_0.Name].Value.ToString();
                this.dataGridViewExcelFilter_1.CurrentCell = this.dataGridViewExcelFilter_1.CurrentRow.Cells[this.dataGridViewFilterTextBoxColumn_0.Name];
                this.dataGridViewExcelFilter_1.CurrentCell.Value = Path.GetFileNameWithoutExtension(this.string_0);
                this.dataGridViewExcelFilter_1.ReadOnly = false;
                this.dataGridViewFilterTextBoxColumn_0.ReadOnly = false;
                this.dataGridViewExcelFilter_1.BeginEdit(true);
            }
        }

        private void toolStripButton_4_Click(object sender, EventArgs e)
        {
            if (this.bindingSource_1.Current != null)
            {
                DataSetTechConnection.Class252 row = (DataSetTechConnection.Class252) ((DataRowView) this.bindingSource_1.Current).Row;
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

        private void toolStripButton_5_Click(object sender, EventArgs e)
        {
            DataRow row = this.dataTable_0.NewRow();
            Form10 form1 = new Form10(row);
            form1.set_SqlSettings(this.get_SqlSettings());
            if (form1.ShowDialog() == DialogResult.OK)
            {
                this.dataTable_0.Rows.Add(row);
                this.bool_0 = true;
            }
        }

        private void toolStripButton_6_Click(object sender, EventArgs e)
        {
            if (this.bindingSource_2.Current != null)
            {
                Form10 form1 = new Form10(((DataRowView) this.bindingSource_2.Current).Row);
                form1.set_SqlSettings(this.get_SqlSettings());
                if (form1.ShowDialog() == DialogResult.OK)
                {
                    this.bool_0 = true;
                }
            }
        }

        private void toolStripButton_7_Click(object sender, EventArgs e)
        {
            if ((this.dataGridViewExcelFilter_2.CurrentRow != null) && (MessageBox.Show("Вы действительно хотите удалить текущую строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                this.dataGridViewExcelFilter_2.Rows.Remove(this.dataGridViewExcelFilter_2.CurrentRow);
                this.bool_0 = true;
            }
        }

        private void toolStripMenuItem_0_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog {
                Multiselect = true
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string str in dialog.FileNames)
                {
                    int? nullable = null;
                    if (!string.IsNullOrEmpty(this.method_25(str, nullable, null)))
                    {
                        this.bool_0 = true;
                    }
                }
            }
        }

        internal int? IdDoc
        {
            get
            {
                return this.nullable_0;
            }
        }

        [CompilerGenerated]
        private sealed class Class283
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
        private sealed class Class284
        {
            public string string_0;

            internal bool method_0(DataSetTechConnection.Class252 class252_0)
            {
                return (class252_0.FileName == this.string_0);
            }
        }
    }
}

