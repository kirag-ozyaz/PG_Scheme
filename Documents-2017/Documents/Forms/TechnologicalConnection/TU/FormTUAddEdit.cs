namespace Documents.Forms.TechnologicalConnection.TU
{
    using ControlsLbr;
    using ControlsLbr.DataGridViewExcelFilter;
    using DataSql;
    using Documents.Forms.TechnologicalConnection;
    using Documents.Properties;
    using FormLbr;
    using FormLbr.Classes;
    using OfficeLB.Word;
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

    public class FormTUAddEdit : FormBase
    {
        private BackgroundWorker backgroundWorker_0;
        private BackgroundWorker backgroundWorker_1;
        private BackgroundWorker backgroundWorker_2;
        private BindingSource bindingSource_0;
        private BindingSource bindingSource_1;
        private BindingSource bindingSource_2;
        private BindingSource bindingSource_3;
        private bool bool_0;
        private Button button_0;
        private Button button_1;
        private ComboBox comboBox_0;
        private ComboBox comboBox_1;
        private ComboBox comboBox_2;
        private ComboBox comboBox_3;
        private ContextMenuStrip contextMenuStrip_0;
        private DataColumn dataColumn_0;
        private DataColumn dataColumn_1;
        private DataGridView dataGridView_0;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_0;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_1;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_2;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_3;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;
        private DataGridViewImageColumnNotNull dataGridViewImageColumnNotNull_0;
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
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_37;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_38;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_39;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_40;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_41;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_42;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_43;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_44;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_45;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_46;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_47;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_48;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_49;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_50;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_51;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_52;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_53;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_54;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_55;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_56;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_57;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_58;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_59;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_60;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_61;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_62;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_63;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_64;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_65;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_66;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_67;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;
        private DataSet dataSet_0;
        private DataSetTechConnection dataSetTechConnection_0;
        private DataTable dataTable_0;
        private DataTable dataTable_1;
        private DateTimePicker dateTimePicker_0;
        private Dictionary<string, FileWatcherArgsAddl> dictionary_0;
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
        private Label label_2;
        private Label label_3;
        private Label label_4;
        private Label label_5;
        private Label label_6;
        private Label label_7;
        private Label label_8;
        private Label label_9;
        private NullableNumericUpDown nullableNumericUpDown_0;
        private NullableNumericUpDown nullableNumericUpDown_1;
        private NullableNumericUpDown nullableNumericUpDown_2;
        private SplitContainer splitContainer_0;
        private string string_0;
        private string string_1;
        private const string string_2 = "TypeWorkTU";
        private TabControl tabControl_0;
        private TabControl tabControl_1;
        private TabPage tabPage_0;
        private TabPage tabPage_1;
        private TabPage tabPage_2;
        private TabPage tabPage_3;
        private TabPage tabPage_4;
        private TextBox textBox_0;
        private TextBox textBox_1;
        private TextBox textBox_2;
        private TextBox textBox_3;
        private TextBox textBox_4;
        private ToolStrip toolStrip_0;
        private ToolStrip toolStrip_1;
        private ToolStrip toolStrip_2;
        private ToolStrip toolStrip_3;
        private ToolStripButton toolStripButton_0;
        private ToolStripButton toolStripButton_1;
        private ToolStripButton toolStripButton_10;
        private ToolStripButton toolStripButton_11;
        private ToolStripButton toolStripButton_12;
        private ToolStripButton toolStripButton_13;
        private ToolStripButton toolStripButton_14;
        private ToolStripButton toolStripButton_15;
        private ToolStripButton toolStripButton_16;
        private ToolStripButton toolStripButton_17;
        private ToolStripButton toolStripButton_2;
        private ToolStripButton toolStripButton_3;
        private ToolStripButton toolStripButton_4;
        private ToolStripButton toolStripButton_5;
        private ToolStripButton toolStripButton_6;
        private ToolStripButton toolStripButton_7;
        private ToolStripButton toolStripButton_8;
        private ToolStripButton toolStripButton_9;
        private ToolStripComboBox toolStripComboBox_0;
        private ToolStripComboBox toolStripComboBox_1;
        private ToolStripDropDownButton toolStripDropDownButton_0;
        private ToolStripLabel toolStripLabel_0;
        private ToolStripLabel toolStripLabel_1;
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
        private ToolStripSeparator toolStripSeparator_4;
        private ToolStripSeparator toolStripSeparator_5;
        private ToolStripSeparator toolStripSeparator_6;

        public FormTUAddEdit()
        {
            this.int_0 = -1;
            this.int_1 = -1;
            this.int_2 = -1;
            this.string_0 = "-1";
            this.int_3 = -1;
            this.int_4 = -1;
            this.dictionary_0 = new Dictionary<string, FileWatcherArgsAddl>();
            this.string_1 = "";
            this.method_31();
        }

        public FormTUAddEdit(int idTU = -1, int idDocIn = -1)
        {
            this.int_0 = -1;
            this.int_1 = -1;
            this.int_2 = -1;
            this.string_0 = "-1";
            this.int_3 = -1;
            this.int_4 = -1;
            this.dictionary_0 = new Dictionary<string, FileWatcherArgsAddl>();
            this.string_1 = "";
            this.method_31();
            this.int_0 = idTU;
            this.int_1 = idDocIn;
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            this.method_9();
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

        private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.bool_0 = true;
        }

        private void comboBox_0_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((this.comboBox_0.SelectedValue != null) && (this.comboBox_0.SelectedIndex != -1))
            {
                this.int_2 = Convert.ToInt32(this.comboBox_0.SelectedValue);
                this.method_4(this.int_2);
            }
            else
            {
                this.textBox_2.Text = this.textBox_1.Text = "";
                this.int_4 = -1;
                this.int_3 = -1;
                this.label_4.ForeColor = this.label_3.ForeColor = Color.Red;
                this.int_2 = -1;
            }
        }

        private void comboBox_0_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.comboBox_0.Text))
            {
                this.comboBox_0.SelectedIndex = -1;
                this.textBox_2.Text = this.textBox_1.Text = "";
                this.int_2 = -1;
            }
        }

        private void comboBox_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.bool_0 = true;
        }

        private void comboBox_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox_2.SelectedIndex >= 0)
            {
                this.bool_0 = true;
                this.label_8.ForeColor = SystemColors.ControlText;
            }
        }

        private void comboBox_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.bool_0 = true;
            if (this.comboBox_3.SelectedIndex >= 0)
            {
                if (string.IsNullOrEmpty(this.textBox_4.Text))
                {
                    this.textBox_4.Text = "ВРУ-" + this.comboBox_3.Text;
                    return;
                }
                using (IEnumerator enumerator = this.comboBox_3.Items.GetEnumerator())
                {
                    string str;
                    while (enumerator.MoveNext())
                    {
                        object current = enumerator.Current;
                        if (current is DataRowView)
                        {
                            str = ((DataRowView) current)["Name"].ToString();
                            if (this.textBox_4.Text.IndexOf("ВРУ-" + str) >= 0)
                            {
                                goto Label_00AC;
                            }
                        }
                    }
                    return;
                Label_00AC:
                    this.textBox_4.Text = this.textBox_4.Text.Replace("ВРУ-" + str, "ВРУ-" + this.comboBox_3.Text);
                    return;
                }
            }
            this.textBox_4.Text = "";
        }

        private void dataGridView_0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((e.RowIndex >= 0) && (e.ColumnIndex >= 0)) && (this.toolStripButton_1.Visible && this.toolStripButton_1.Enabled))
            {
                this.toolStripButton_1_Click(sender, e);
            }
        }

        private void dataGridViewExcelFilter_0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.toolStripMenuItem_4_Click(sender, e);
        }

        private void dataGridViewExcelFilter_0_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridViewExcelFilter_0.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_0.ReadOnly = true;
            string key = this.dataGridViewExcelFilter_0[e.ColumnIndex, e.RowIndex].Value.ToString() + Path.GetExtension(this.string_1);
            if (key != this.string_1)
            {
                if (this.dictionary_0.ContainsKey(this.string_1))
                {
                    FileWatcherArgsAddl addl = this.dictionary_0[this.string_1];
                    addl.set_OriginalName(key);
                    this.dictionary_0.Remove(this.string_1);
                    this.dictionary_0.Add(key, addl);
                    this.dataGridViewExcelFilter_0[e.ColumnIndex, e.RowIndex].Value = key;
                    this.bool_0 = true;
                }
                this.string_1 = null;
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
            if (((e.ColumnIndex == 1) && (e.RowIndex >= 0)) && !string.IsNullOrEmpty(this.string_1))
            {
                string key = e.FormattedValue + Path.GetExtension(this.string_1);
                if ((key != this.string_1) && this.dictionary_0.ContainsKey(key))
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

        private void dataGridViewExcelFilter_1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.RowIndex >= 0) && (Convert.ToInt32(this.dataGridViewExcelFilter_1[this.dataGridViewTextBoxColumn_26.Name, e.RowIndex].Value) == 0x459))
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                e.CellStyle.BackColor = Color.LightGray;
            }
        }

        private void dataGridViewExcelFilter_1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridViewExcelFilter_1.AutoResizeRow(e.RowIndex);
        }

        private void dataGridViewExcelFilter_2_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[this.dataGridViewTextBoxColumn_47.Name].Value = this.int_0;
            e.Row.Cells[this.dataGridViewTextBoxColumn_49.Name].Value = 1;
            e.Row.Cells[this.dataGridViewTextBoxColumn_48.Name].Value = e.Row.Index + 1;
        }

        private void dataGridViewExcelFilter_3_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.bool_0 = true;
        }

        private void dataGridViewExcelFilter_3_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[this.dataGridViewTextBoxColumn_42.Name].Value = this.int_0;
            e.Row.Cells[this.dataGridViewTextBoxColumn_44.Name].Value = 2;
            e.Row.Cells[this.dataGridViewTextBoxColumn_43.Name].Value = e.Row.Index + 1;
        }

        private void dataGridViewExcelFilter_3_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ((DataGridView) sender).AutoResizeRow(e.RowIndex);
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

        private void FormTUAddEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((this.bool_0 && (MessageBox.Show("Сохранить внесенные изменения?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)) && !this.method_9())
            {
                e.Cancel = true;
            }
            else
            {
                foreach (FileWatcherArgsAddl addl in this.dictionary_0.Values)
                {
                    if (addl.get_Watcher() != null)
                    {
                        addl.get_Watcher().Dispose();
                    }
                }
            }
        }

        private void FormTUAddEdit_Load(object sender, EventArgs e)
        {
            this.method_2();
            this.method_1();
            this.method_3();
            this.method_5();
            this.method_6();
            this.method_7();
            if (this.int_0 == -1)
            {
                this.Text = "Новое тех. условие";
            }
            else
            {
                decimal? nullable;
                this.Text = "Редактирование тех. условия";
                base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Doc, true, "where id = " + this.int_0.ToString());
                if ((this.dataSetTechConnection_0.tTC_Doc.Rows.Count > 0) && (this.dataSetTechConnection_0.tTC_Doc.Rows[0]["numDoc"] != DBNull.Value))
                {
                    this.string_0 = this.dataSetTechConnection_0.tTC_Doc.Rows[0]["numDoc"].ToString();
                }
                base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_DocOut, true, "where idDocOut = " + this.int_0.ToString());
                decimal? nullable2 = new decimal();
                this.nullableNumericUpDown_2.set_Value(nullable2);
                this.nullableNumericUpDown_1.set_Value(nullable = nullable2);
                this.nullableNumericUpDown_0.set_Value(nullable);
                base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_TU, true, "where id = " + this.int_0.ToString());
                base.SelectSqlData(this.dataSetTechConnection_0.tTC_TUTypeWork, true, "where idtu = " + this.int_0.ToString() + " order by num ", false);
                this.method_0();
                this.method_24(this.int_0);
            }
            this.method_15();
            this.method_27();
            this.method_28();
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
            this.dataGridView_0.Rows.Clear();
            string[] textArray1 = new string[] { " where idTU = ", this.int_0.ToString(), " and (typeDoc is null or typeDoc = ", 0x463.ToString(), ")   order by num" };
            string str = string.Concat(textArray1);
            base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_TUPointAttach, true, str);
            base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vTC_TUPointAttach, true, str);
            foreach (DataRow row in this.dataSetTechConnection_0.vTC_TUPointAttach)
            {
                object[] values = new object[] { 
                    row["id"], row["num"], row["idSubPoint"], row["SubPoint"], row["idBusPoint"], row["BusPoint"], row["idCellPoint"], row["CellPoint"], row["idSubCP"], row["SubCP"], row["idBusCP"], row["BusCP"], row["idCellCP"], row["CellCP"], row["VoltageLevel"], row["VoltageLevelName"],
                    row["PowerSum"], row["Description"]
                };
                this.dataGridView_0.Rows.Add(values);
            }
        }

        private void method_1()
        {
            decimal? nullable;
            decimal? nullable2 = null;
            this.nullableNumericUpDown_1.set_Value(nullable2);
            this.nullableNumericUpDown_2.set_Value(nullable = nullable2);
            this.nullableNumericUpDown_0.set_Value(nullable);
        }

        private void method_10()
        {
            DataRow row = this.dataSetTechConnection_0.tTC_Doc.NewRow();
            if (!string.IsNullOrEmpty(this.textBox_0.Text))
            {
                row["numDoc"] = this.textBox_0.Text;
            }
            row["dateDoc"] = this.dateTimePicker_0.Value.Date;
            row["typeDoc"] = 0x463;
            if (!string.IsNullOrEmpty(this.textBox_3.Text))
            {
                row["Body"] = this.textBox_3.Text;
            }
            this.dataSetTechConnection_0.tTC_Doc.Rows.Add(row);
            this.int_0 = base.InsertSqlDataOneRow(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Doc);
            if (this.int_0 > 0)
            {
                base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Doc, true, "where id = " + this.int_0.ToString());
            }
        }

        private bool method_11()
        {
            if (this.dataSetTechConnection_0.tTC_Doc.Rows.Count > 0)
            {
                this.dataSetTechConnection_0.tTC_Doc.Rows[0].EndEdit();
                return base.UpdateSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Doc);
            }
            return false;
        }

        private bool method_12()
        {
            if (this.dataSetTechConnection_0.tTC_DocOut.Rows.Count > 0)
            {
                if (this.comboBox_0.SelectedIndex >= 0)
                {
                    this.dataSetTechConnection_0.tTC_DocOut.Rows[0]["idDoc"] = Convert.ToInt32(this.comboBox_0.SelectedValue);
                    this.dataSetTechConnection_0.tTC_DocOut.Rows[0]["idDocOut"] = this.int_0;
                    this.dataSetTechConnection_0.tTC_DocOut.Rows[0].EndEdit();
                    return base.UpdateSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_DocOut);
                }
                if (Convert.ToInt32(this.dataSetTechConnection_0.tTC_DocOut.Rows[0]["id"]) > 0)
                {
                    if (base.DeleteSqlDataById(this.dataSetTechConnection_0.tTC_DocOut, Convert.ToInt32(this.dataSetTechConnection_0.tTC_DocOut.Rows[0]["id"])))
                    {
                        this.dataSetTechConnection_0.tTC_DocOut.Clear();
                        return true;
                    }
                    return false;
                }
            }
            else if ((this.int_0 > 0) && (this.comboBox_0.SelectedIndex >= 0))
            {
                DataRow row = this.dataSetTechConnection_0.tTC_DocOut.NewRow();
                row["idDoc"] = Convert.ToInt32(this.comboBox_0.SelectedValue);
                row["idDocOut"] = this.int_0;
                this.dataSetTechConnection_0.tTC_DocOut.Rows.Add(row);
                int num = base.InsertSqlDataOneRow(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_DocOut);
                if (num <= 0)
                {
                    this.dataSetTechConnection_0.tTC_DocOut.Clear();
                    return false;
                }
                base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_DocOut, true, " where id = " + num.ToString());
            }
            return true;
        }

        private bool method_13()
        {
            if (this.dataSetTechConnection_0.tTC_TU.Rows.Count > 0)
            {
                if (this.nullableNumericUpDown_0.get_Value().HasValue)
                {
                    this.dataSetTechConnection_0.tTC_TU.Rows[0]["Power"] = this.nullableNumericUpDown_0.get_Value();
                }
                else
                {
                    this.dataSetTechConnection_0.tTC_TU.Rows[0]["Power"] = DBNull.Value;
                }
                if (this.nullableNumericUpDown_1.get_Value().HasValue)
                {
                    this.dataSetTechConnection_0.tTC_TU.Rows[0]["PowerAdd"] = this.nullableNumericUpDown_1.get_Value();
                }
                else
                {
                    this.dataSetTechConnection_0.tTC_TU.Rows[0]["PowerAdd"] = DBNull.Value;
                }
                if (this.nullableNumericUpDown_2.get_Value().HasValue)
                {
                    this.dataSetTechConnection_0.tTC_TU.Rows[0]["PowerSum"] = this.nullableNumericUpDown_2.get_Value();
                }
                else
                {
                    this.dataSetTechConnection_0.tTC_TU.Rows[0]["PowerSum"] = DBNull.Value;
                }
                this.dataSetTechConnection_0.tTC_TU.Rows[0].EndEdit();
                return base.UpdateSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_TU);
            }
            if (this.int_0 <= 0)
            {
                return true;
            }
            DataRow row = this.dataSetTechConnection_0.tTC_TU.NewRow();
            row["id"] = this.int_0;
            if (this.nullableNumericUpDown_0.get_Value().HasValue)
            {
                row["Power"] = this.nullableNumericUpDown_0.get_Value();
            }
            if (this.nullableNumericUpDown_1.get_Value().HasValue)
            {
                row["PowerAdd"] = this.nullableNumericUpDown_1.get_Value();
            }
            if (this.nullableNumericUpDown_2.get_Value().HasValue)
            {
                row["PowerSum"] = this.nullableNumericUpDown_2.get_Value();
            }
            if (this.comboBox_1.SelectedIndex >= 0)
            {
                row["Category"] = this.comboBox_1.SelectedValue;
            }
            if (this.comboBox_3.SelectedIndex >= 0)
            {
                row["VoltageLevel"] = this.comboBox_3.SelectedValue;
            }
            if (this.comboBox_2.SelectedIndex >= 0)
            {
                row["Performer"] = this.comboBox_2.SelectedValue;
            }
            this.dataSetTechConnection_0.tTC_TU.Rows.Add(row);
            if (base.InsertSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_TU))
            {
                this.dataSetTechConnection_0.tTC_TU.AcceptChanges();
                return true;
            }
            this.dataSetTechConnection_0.tTC_TU.Clear();
            return false;
        }

        private bool method_14()
        {
            foreach (DataGridViewRow row in (IEnumerable) this.dataGridView_0.Rows)
            {
                if (row.Index < this.dataSetTechConnection_0.tTC_TUPointAttach.Rows.Count)
                {
                    this.dataSetTechConnection_0.tTC_TUPointAttach.Rows[row.Index]["idTU"] = this.int_0;
                    this.dataSetTechConnection_0.tTC_TUPointAttach.Rows[row.Index]["num"] = row.Index + 1;
                    this.dataSetTechConnection_0.tTC_TUPointAttach.Rows[row.Index]["idSubPoint"] = (row.Cells[this.dataGridViewTextBoxColumn_52.Name].Value != null) ? row.Cells[this.dataGridViewTextBoxColumn_52.Name].Value : DBNull.Value;
                    this.dataSetTechConnection_0.tTC_TUPointAttach.Rows[row.Index]["idBusPoint"] = (row.Cells[this.dataGridViewTextBoxColumn_54.Name].Value != null) ? row.Cells[this.dataGridViewTextBoxColumn_54.Name].Value : DBNull.Value;
                    this.dataSetTechConnection_0.tTC_TUPointAttach.Rows[row.Index]["idCellPoint"] = (row.Cells[this.dataGridViewTextBoxColumn_56.Name].Value != null) ? row.Cells[this.dataGridViewTextBoxColumn_56.Name].Value : DBNull.Value;
                    this.dataSetTechConnection_0.tTC_TUPointAttach.Rows[row.Index]["idSubCP"] = (row.Cells[this.dataGridViewTextBoxColumn_58.Name].Value != null) ? row.Cells[this.dataGridViewTextBoxColumn_58.Name].Value : DBNull.Value;
                    this.dataSetTechConnection_0.tTC_TUPointAttach.Rows[row.Index]["idBusCP"] = (row.Cells[this.dataGridViewTextBoxColumn_60.Name].Value != null) ? row.Cells[this.dataGridViewTextBoxColumn_60.Name].Value : DBNull.Value;
                    this.dataSetTechConnection_0.tTC_TUPointAttach.Rows[row.Index]["idCellCP"] = (row.Cells[this.dataGridViewTextBoxColumn_62.Name].Value != null) ? row.Cells[this.dataGridViewTextBoxColumn_62.Name].Value : DBNull.Value;
                    this.dataSetTechConnection_0.tTC_TUPointAttach.Rows[row.Index]["voltageLevel"] = (row.Cells[this.dataGridViewTextBoxColumn_64.Name].Value != null) ? row.Cells[this.dataGridViewTextBoxColumn_64.Name].Value : DBNull.Value;
                    this.dataSetTechConnection_0.tTC_TUPointAttach.Rows[row.Index]["PowerSum"] = (row.Cells[this.dataGridViewTextBoxColumn_66.Name].Value != null) ? row.Cells[this.dataGridViewTextBoxColumn_66.Name].Value : DBNull.Value;
                    this.dataSetTechConnection_0.tTC_TUPointAttach.Rows[row.Index]["Description"] = (row.Cells[this.dataGridViewTextBoxColumn_67.Name].Value != null) ? row.Cells[this.dataGridViewTextBoxColumn_67.Name].Value : DBNull.Value;
                    this.dataSetTechConnection_0.tTC_TUPointAttach.Rows[row.Index]["TypeDoc"] = 0x463;
                    this.dataSetTechConnection_0.tTC_TUPointAttach.Rows[row.Index].EndEdit();
                }
                else
                {
                    DataRow row2 = this.dataSetTechConnection_0.tTC_TUPointAttach.NewRow();
                    row2["idTU"] = this.int_0;
                    row2["num"] = row.Index + 1;
                    if (row.Cells[this.dataGridViewTextBoxColumn_52.Name].Value != null)
                    {
                        row2["idSubPoint"] = row.Cells[this.dataGridViewTextBoxColumn_52.Name].Value;
                    }
                    if (row.Cells[this.dataGridViewTextBoxColumn_54.Name].Value != null)
                    {
                        row2["idBusPoint"] = row.Cells[this.dataGridViewTextBoxColumn_54.Name].Value;
                    }
                    if (row.Cells[this.dataGridViewTextBoxColumn_56.Name].Value != null)
                    {
                        row2["idCellPoint"] = row.Cells[this.dataGridViewTextBoxColumn_56.Name].Value;
                    }
                    if (row.Cells[this.dataGridViewTextBoxColumn_58.Name].Value != null)
                    {
                        row2["idSubCP"] = row.Cells[this.dataGridViewTextBoxColumn_58.Name].Value;
                    }
                    if (row.Cells[this.dataGridViewTextBoxColumn_60.Name].Value != null)
                    {
                        row2["idBusCP"] = row.Cells[this.dataGridViewTextBoxColumn_60.Name].Value;
                    }
                    if (row.Cells[this.dataGridViewTextBoxColumn_62.Name].Value != null)
                    {
                        row2["idCellCP"] = row.Cells[this.dataGridViewTextBoxColumn_62.Name].Value;
                    }
                    if (row.Cells[this.dataGridViewTextBoxColumn_64.Name].Value != null)
                    {
                        row2["voltageLevel"] = row.Cells[this.dataGridViewTextBoxColumn_64.Name].Value;
                    }
                    if (row.Cells[this.dataGridViewTextBoxColumn_66.Name].Value != null)
                    {
                        row2["PowerSum"] = row.Cells[this.dataGridViewTextBoxColumn_66.Name].Value;
                    }
                    if (row.Cells[this.dataGridViewTextBoxColumn_67.Name].Value != null)
                    {
                        row2["Description"] = row.Cells[this.dataGridViewTextBoxColumn_67.Name].Value;
                    }
                    row2["TypeDoc"] = 0x463;
                    this.dataSetTechConnection_0.tTC_TUPointAttach.Rows.Add(row2);
                }
            }
            for (int i = this.dataSetTechConnection_0.tTC_TUPointAttach.Rows.Count - 1; i > (this.dataGridView_0.Rows.Count - 1); i--)
            {
                this.dataSetTechConnection_0.tTC_TUPointAttach.Rows[i].Delete();
            }
            base.InsertSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_TUPointAttach);
            base.UpdateSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_TUPointAttach);
            base.DeleteSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_TUPointAttach);
            this.method_0();
            return true;
        }

        private void method_15()
        {
            foreach (DataRow row in new SqlDataCommand(this.get_SqlSettings()).SelectSqlData(" SELECT doc.id, doc.FileName  FROM tR_DocTemplate AS doc  INNER JOIN [tR_Classifier] AS c ON doc.idTypeDoc = c.id  WHERE c.ParentKey = ';TypeDoc;tR_DocTemplate;' AND c.Deleted = ((0)) AND c.isGroup = ((0)) AND c.Value = 1 and doc.deleted = 0").Rows)
            {
                ToolStripMenuItem item = new ToolStripMenuItem {
                    Text = row["FileName"].ToString(),
                    Tag = row["id"]
                };
                item.Click += new EventHandler(this.method_17);
                this.toolStripDropDownButton_0.DropDownItems.Add(item);
                ToolStripMenuItem item2 = new ToolStripMenuItem {
                    Text = row["FileName"].ToString(),
                    Tag = row["id"]
                };
                item2.Click += new EventHandler(this.method_17);
                this.toolStripMenuItem_1.DropDownItems.Add(item2);
            }
        }

        private string method_16(string string_3, int? nullable_0 = new int?(), byte[] byte_0 = null)
        {
            string fileName = Path.GetFileName(string_3);
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
            if (byte_0 == null)
            {
                FileBinary binary = new FileBinary(string_3);
                class2.File = binary.get_ByteArray();
                class2.dateChange = binary.get_LastChanged();
            }
            else
            {
                class2.File = byte_0;
                class2.dateChange = DateTime.Now;
            }
            if (nullable_0.HasValue)
            {
                class2.idTemplate = nullable_0.Value;
            }
            this.dataSetTechConnection_0.tTC_DocFile.method_0(class2);
            return fileName;
        }

        private void method_17(object sender, EventArgs e)
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
            str3 = this.method_23();
            string str4 = FileBinary.GetNewFileNameIsExists(str3, str, false);
            string str5 = this.method_16(str, new int?(tag), buffer);
            if (!string.IsNullOrEmpty(str5))
            {
                this.bool_0 = true;
                FileBinary binary = new FileBinary(buffer, str4, DateTime.Now);
                binary.SaveToDisk(str3);
                extension = new FileInfo(str).Extension;
                if ((extension != ".doc") && (extension != ".docx"))
                {
                    Process.Start(str3 + @"\" + binary.get_Name());
                }
                else if (!this.method_18(str3 + @"\" + binary.get_Name()))
                {
                    Process.Start(str3 + @"\" + binary.get_Name());
                }
                if (this.dictionary_0.ContainsKey(str5))
                {
                    FileWatcher watcher = new FileWatcher(str3, binary.get_Name());
                    watcher.add_AnyChanged(new FileSystemEventHandler(this.method_20));
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

        private bool method_18(string string_3)
        {
            bool flag;
            try
            {
                Application application1 = new Application();
                Documents documents = application1.get_Documents();
                documents.Open(string_3);
                application1.set_Visible(true);
                Bookmarks bookmarks = documents.get_Item(1).get_Range().get_Bookmarks();
                if (bookmarks.Exists("NumTU"))
                {
                    bookmarks.get_Item("NumTU").get_Range().set_Text(this.textBox_0.Text);
                }
                if (bookmarks.Exists("DateTU"))
                {
                    bookmarks.get_Item("DateTU").get_Range().set_Text(this.dateTimePicker_0.Value.ToString("dd MMMM yyyy") + " г.");
                }
                if (bookmarks.Exists("NameAbn"))
                {
                    bookmarks.get_Item("NameAbn").get_Range().set_Text(this.textBox_1.Text);
                }
                if (bookmarks.Exists("VRU"))
                {
                    if (string.IsNullOrEmpty(this.textBox_4.Text))
                    {
                        bookmarks.get_Item("VRU").get_Range().set_Text("ВРУ-" + this.comboBox_3.Text);
                    }
                    else
                    {
                        bookmarks.get_Item("VRU").get_Range().set_Text(this.textBox_4.Text);
                    }
                }
                if (bookmarks.Exists("AbnObj"))
                {
                    bookmarks.get_Item("AbnObj").get_Range().set_Text(this.textBox_2.Text);
                }
                if (bookmarks.Exists("PowerMax"))
                {
                    bookmarks.get_Item("PowerMax").get_Range().set_Text(this.nullableNumericUpDown_2.get_Value().ToString());
                }
                if (bookmarks.Exists("Category"))
                {
                    bookmarks.get_Item("Category").get_Range().set_Text(this.comboBox_1.Text);
                }
                if (bookmarks.Exists("VoltageLevel"))
                {
                    bookmarks.get_Item("VoltageLevel").get_Range().set_Text(this.comboBox_3.Text);
                }
                if (bookmarks.Exists("PointAttach") && (this.dataGridView_0.Rows.Count > 0))
                {
                    int num = -1;
                    if ((this.dataGridView_0.Rows[0].Cells[this.dataGridViewTextBoxColumn_56.Name].Value != null) && (this.dataGridView_0.Rows[0].Cells[this.dataGridViewTextBoxColumn_56.Name].Value != DBNull.Value))
                    {
                        num = Convert.ToInt32(this.dataGridView_0.Rows[0].Cells[this.dataGridViewTextBoxColumn_56.Name].Value);
                    }
                    else if ((this.dataGridView_0.Rows[0].Cells[this.dataGridViewTextBoxColumn_54.Name].Value != null) && (this.dataGridView_0.Rows[0].Cells[this.dataGridViewTextBoxColumn_54.Name].Value != DBNull.Value))
                    {
                        num = Convert.ToInt32(this.dataGridView_0.Rows[0].Cells[this.dataGridViewTextBoxColumn_54.Name].Value);
                    }
                    else if ((this.dataGridView_0.Rows[0].Cells[this.dataGridViewTextBoxColumn_52.Name].Value != null) && (this.dataGridView_0.Rows[0].Cells[this.dataGridViewTextBoxColumn_52.Name].Value != DBNull.Value))
                    {
                        num = Convert.ToInt32(this.dataGridView_0.Rows[0].Cells[this.dataGridViewTextBoxColumn_52.Name].Value);
                    }
                    if (num > 0)
                    {
                        string[] textArray1 = new string[] { num.ToString() };
                        string str = base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", textArray1).ToString();
                        bookmarks.get_Item("PointAttach").get_Range().set_Text(str);
                    }
                }
                if (bookmarks.Exists("PowerMaxPoint"))
                {
                    bookmarks.get_Item("PowerMaxPoint").get_Range().set_Text("(" + this.nullableNumericUpDown_2.get_Value().ToString() + " кВт)");
                }
                if (bookmarks.Exists("CP"))
                {
                    if (this.dataGridView_0.Rows.Count > 0)
                    {
                        int num2 = -1;
                        if ((this.dataGridView_0.Rows[0].Cells[this.dataGridViewTextBoxColumn_62.Name].Value != null) && (this.dataGridView_0.Rows[0].Cells[this.dataGridViewTextBoxColumn_62.Name].Value != DBNull.Value))
                        {
                            num2 = Convert.ToInt32(this.dataGridView_0.Rows[0].Cells[this.dataGridViewTextBoxColumn_62.Name].Value);
                        }
                        else if ((this.dataGridView_0.Rows[0].Cells[this.dataGridViewTextBoxColumn_60.Name].Value != null) && (this.dataGridView_0.Rows[0].Cells[this.dataGridViewTextBoxColumn_60.Name].Value != DBNull.Value))
                        {
                            num2 = Convert.ToInt32(this.dataGridView_0.Rows[0].Cells[this.dataGridViewTextBoxColumn_60.Name].Value);
                        }
                        else if ((this.dataGridView_0.Rows[0].Cells[this.dataGridViewTextBoxColumn_58.Name].Value != null) && (this.dataGridView_0.Rows[0].Cells[this.dataGridViewTextBoxColumn_58.Name].Value != DBNull.Value))
                        {
                            num2 = Convert.ToInt32(this.dataGridView_0.Rows[0].Cells[this.dataGridViewTextBoxColumn_58.Name].Value);
                        }
                        if (num2 > 0)
                        {
                            string[] textArray2 = new string[] { num2.ToString() };
                            string str2 = base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", textArray2).ToString();
                            bookmarks.get_Item("CP").get_Range().set_Text(str2);
                        }
                        else
                        {
                            bookmarks.get_Item("CP").get_Range().set_Text("не предусмотрен");
                        }
                    }
                    else
                    {
                        bookmarks.get_Item("CP").get_Range().set_Text("не предусмотрен");
                    }
                }
                if (bookmarks.Exists("CP2"))
                {
                    if (this.dataGridView_0.Rows.Count > 1)
                    {
                        int num3 = -1;
                        if ((this.dataGridView_0.Rows[1].Cells[this.dataGridViewTextBoxColumn_62.Name].Value != null) && (this.dataGridView_0.Rows[1].Cells[this.dataGridViewTextBoxColumn_62.Name].Value != DBNull.Value))
                        {
                            num3 = Convert.ToInt32(this.dataGridView_0.Rows[1].Cells[this.dataGridViewTextBoxColumn_62.Name].Value);
                        }
                        else if ((this.dataGridView_0.Rows[1].Cells[this.dataGridViewTextBoxColumn_60.Name].Value != null) && (this.dataGridView_0.Rows[1].Cells[this.dataGridViewTextBoxColumn_60.Name].Value != DBNull.Value))
                        {
                            num3 = Convert.ToInt32(this.dataGridView_0.Rows[1].Cells[this.dataGridViewTextBoxColumn_60.Name].Value);
                        }
                        else if ((this.dataGridView_0.Rows[1].Cells[this.dataGridViewTextBoxColumn_58.Name].Value != null) && (this.dataGridView_0.Rows[1].Cells[this.dataGridViewTextBoxColumn_58.Name].Value != DBNull.Value))
                        {
                            num3 = Convert.ToInt32(this.dataGridView_0.Rows[1].Cells[this.dataGridViewTextBoxColumn_58.Name].Value);
                        }
                        if (num3 > 0)
                        {
                            string[] textArray3 = new string[] { num3.ToString() };
                            string str3 = base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", textArray3).ToString();
                            bookmarks.get_Item("CP2").get_Range().set_Text(str3);
                        }
                        else
                        {
                            bookmarks.get_Item("CP2").get_Range().set_Text("не предусмотрен");
                        }
                    }
                    else
                    {
                        bookmarks.get_Item("CP2").get_Range().set_Text("не предусмотрен");
                    }
                }
                if (bookmarks.Exists("NetWork"))
                {
                    string str4 = "";
                    foreach (DataGridViewRow row in (IEnumerable) this.dataGridViewExcelFilter_2.Rows)
                    {
                        if (row.Cells[this.dataGridViewTextBoxColumn_45.Name].Value != null)
                        {
                            if (string.IsNullOrEmpty(str4))
                            {
                                str4 = str4 + row.Cells[this.dataGridViewTextBoxColumn_45.Name].Value + ";";
                            }
                            else
                            {
                                object[] objArray1 = new object[] { str4, "\r\n", row.Cells[this.dataGridViewTextBoxColumn_45.Name].Value, ";" };
                                str4 = string.Concat(objArray1);
                            }
                        }
                    }
                    bookmarks.get_Item("NetWork").get_Range().set_Text(str4);
                }
                if (bookmarks.Exists("ClientWork"))
                {
                    string str5 = "";
                    foreach (DataGridViewRow row2 in (IEnumerable) this.dataGridViewExcelFilter_3.Rows)
                    {
                        if (row2.Cells[this.dataGridViewTextBoxColumn_40.Name].Value != null)
                        {
                            if (string.IsNullOrEmpty(str5))
                            {
                                str5 = str5 + row2.Cells[this.dataGridViewTextBoxColumn_40.Name].Value + ";";
                            }
                            else
                            {
                                object[] objArray2 = new object[] { str5, "\r\n", row2.Cells[this.dataGridViewTextBoxColumn_40.Name].Value, ";" };
                                str5 = string.Concat(objArray2);
                            }
                        }
                    }
                    bookmarks.get_Item("ClientWork").get_Range().set_Text(str5);
                }
                documents = null;
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source);
                flag = false;
            }
            return flag;
        }

        private void method_19(bool bool_1 = false)
        {
            if (this.bindingSource_0.Current != null)
            {
                byte[] file;
                DataSetTechConnection.Class252 row = (DataSetTechConnection.Class252) ((DataRowView) this.bindingSource_0.Current).Row;
                string fileName = row.FileName;
                string str2 = this.method_23();
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
                            watcher.add_AnyChanged(new FileSystemEventHandler(this.method_20));
                            watcher.Start();
                            this.dictionary_0[fileName].set_Watcher(watcher);
                        }
                        else
                        {
                            this.dictionary_0[fileName].get_Watcher().remove_AnyChanged(new FileSystemEventHandler(this.method_20));
                            this.dictionary_0[fileName].get_Watcher().Stop();
                            FileWatcher watcher2 = new FileWatcher(str2, str3);
                            watcher2.add_AnyChanged(new FileSystemEventHandler(this.method_20));
                            watcher2.Start();
                            this.dictionary_0[fileName].set_Watcher(watcher2);
                        }
                        this.dictionary_0[fileName].set_TempName(str3);
                        this.dictionary_0[fileName].set_OpenState(1);
                    }
                    else
                    {
                        FileWatcher watcher3 = new FileWatcher(str2, str3);
                        watcher3.add_AnyChanged(new FileSystemEventHandler(this.method_20));
                        watcher3.Start();
                        FileWatcherArgsAddl addl = new FileWatcherArgsAddl(nullable, fileName, str3, watcher3, 1);
                        this.dictionary_0.Add(fileName, addl);
                    }
                }
            }
        }

        private void method_2()
        {
            this.method_29();
            if (this.dataTable_0.Rows.Count > 0)
            {
                this.toolStripComboBox_0.ComboBox.DataSource = null;
                this.toolStripComboBox_0.Items.Clear();
                this.toolStripComboBox_0.ComboBox.DisplayMember = "Name";
                this.toolStripComboBox_0.ComboBox.ValueMember = "Name";
                this.toolStripComboBox_0.ComboBox.DataSource = this.dataTable_0;
            }
            if (this.dataTable_1.Rows.Count > 0)
            {
                this.toolStripComboBox_1.ComboBox.DataSource = null;
                this.toolStripComboBox_1.Items.Clear();
                this.toolStripComboBox_1.ComboBox.DisplayMember = "Name";
                this.toolStripComboBox_1.ComboBox.ValueMember = "Name";
                this.toolStripComboBox_1.ComboBox.DataSource = this.dataTable_1;
            }
        }

        private void method_20(object sender, FileSystemEventArgs e)
        {
            Class281 class2 = new Class281 {
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
            this.method_22();
        }

        private bool method_21(string string_3)
        {
            Class282 class2 = new Class282 {
                string_0 = string_3
            };
            return (this.dataSetTechConnection_0.tTC_DocFile.Where<DataSetTechConnection.Class252>(new Func<DataSetTechConnection.Class252, bool>(class2.method_0)).Count<DataSetTechConnection.Class252>() > 0);
        }

        private void method_22()
        {
            if (base.InvokeRequired)
            {
                base.Invoke(new Action(this.method_32));
            }
            else
            {
                this.bindingSource_0.ResetBindings(false);
            }
        }

        private string method_23()
        {
            string str = @"EIS\TU";
            if (!string.IsNullOrEmpty(this.textBox_0.Text))
            {
                str = str + @"\" + this.textBox_0.Text;
            }
            string path = Path.GetTempPath() + @"\" + str + @"\";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return path;
        }

        private void method_24(int int_5)
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

        private bool method_25()
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

        private bool method_26()
        {
            for (int i = this.dataGridViewExcelFilter_2.Rows.Count - 2; i >= 0; i--)
            {
                if (((this.dataGridViewExcelFilter_2[this.dataGridViewTextBoxColumn_45.Name, i].Value == null) || (this.dataGridViewExcelFilter_2[this.dataGridViewTextBoxColumn_45.Name, i].Value == DBNull.Value)) || string.IsNullOrEmpty(this.dataGridViewExcelFilter_2[this.dataGridViewTextBoxColumn_45.Name, i].Value.ToString()))
                {
                    this.dataGridViewExcelFilter_2.Rows.RemoveAt(i);
                }
            }
            for (int j = this.dataGridViewExcelFilter_3.Rows.Count - 2; j >= 0; j--)
            {
                if (((this.dataGridViewExcelFilter_3[this.dataGridViewTextBoxColumn_40.Name, j].Value == null) || (this.dataGridViewExcelFilter_3[this.dataGridViewTextBoxColumn_40.Name, j].Value == DBNull.Value)) || string.IsNullOrEmpty(this.dataGridViewExcelFilter_3[this.dataGridViewTextBoxColumn_40.Name, j].Value.ToString()))
                {
                    this.dataGridViewExcelFilter_3.Rows.RemoveAt(j);
                }
            }
            int num = 1;
            foreach (DataGridViewRow row in (IEnumerable) this.dataGridViewExcelFilter_2.Rows)
            {
                if ((row.Cells[this.dataGridViewTextBoxColumn_46.Name].Value != null) && (row.Cells[this.dataGridViewTextBoxColumn_46.Name].Value != DBNull.Value))
                {
                    DataSetTechConnection.Class255 class1 = this.dataSetTechConnection_0.tTC_TUTypeWork.method_2(Convert.ToInt32(row.Cells[this.dataGridViewTextBoxColumn_46.Name].Value));
                    class1["idTu"] = this.int_0;
                    class1["num"] = num;
                    class1.EndEdit();
                    num++;
                }
            }
            num = 1;
            foreach (DataGridViewRow row2 in (IEnumerable) this.dataGridViewExcelFilter_3.Rows)
            {
                if ((row2.Cells[this.dataGridViewTextBoxColumn_41.Name].Value != null) && (row2.Cells[this.dataGridViewTextBoxColumn_41.Name].Value != DBNull.Value))
                {
                    DataSetTechConnection.Class255 class2 = this.dataSetTechConnection_0.tTC_TUTypeWork.method_2(Convert.ToInt32(row2.Cells[this.dataGridViewTextBoxColumn_41.Name].Value));
                    class2["idTu"] = this.int_0;
                    class2["num"] = num;
                    class2.EndEdit();
                    num++;
                }
            }
            if (!base.InsertSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_TUTypeWork))
            {
                return false;
            }
            if (!base.UpdateSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_TUTypeWork))
            {
                return false;
            }
            if (!base.DeleteSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_TUTypeWork))
            {
                return false;
            }
            base.SelectSqlData(this.dataSetTechConnection_0.tTC_TUTypeWork, true, "where idtu = " + this.int_0.ToString() + " order by num ", false);
            return true;
        }

        private void method_27()
        {
            int num = 0;
            foreach (ToolStripItem item in this.toolStrip_2.Items)
            {
                if (item != this.toolStripComboBox_0)
                {
                    num += item.Width;
                }
            }
            this.toolStripComboBox_0.Width = (this.toolStrip_2.Width - num) - 20;
        }

        private void method_28()
        {
            int num = 0;
            foreach (ToolStripItem item in this.toolStrip_3.Items)
            {
                if (item != this.toolStripComboBox_1)
                {
                    num += item.Width;
                }
            }
            this.toolStripComboBox_1.Width = (this.toolStrip_3.Width - num) - 20;
        }

        private void method_29()
        {
            DataTable table = this.method_30();
            base.SelectSqlData(table, true, string.Format("where Module = '{0}'", "TypeWorkTU"), false);
            try
            {
                if ((table.Rows.Count > 0) && (table.Rows[0]["Settings"] != DBNull.Value))
                {
                    XmlDocument node = new XmlDocument();
                    node.LoadXml(table.Rows[0]["Settings"].ToString());
                    XmlNodeReader reader = new XmlNodeReader(node);
                    this.dataSet_0.Clear();
                    this.dataSet_0.ReadXml(reader);
                    reader.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source);
            }
        }

        private void method_3()
        {
            string[] textArray1 = new string[11];
            textArray1[0] = "select  r.id, r.numin, r.datein,  isnull(r.numIn, '') + ' от ' + isnull(convert( varchar(10),r.DateIn, 104), '') as numDateIn from ttc_request r left join ttc_doc d on d.id = r.id  where (d.typeDoc = ";
            textArray1[1] = 0x459.ToString();
            textArray1[2] = " or d.TypeDoc = ";
            textArray1[3] = 0x4b3.ToString();
            textArray1[4] = ")  and r.id not in (select docOut.idDoc  from ttc_docout docOut  left join ttc_doc r on r.id = docOut.idDoc and (r.typeDoc = ";
            textArray1[5] = 0x459.ToString();
            textArray1[6] = " or r.typeDoc = ";
            textArray1[7] = 0x4b3.ToString();
            textArray1[8] = ")  left join ttc_doc tu on tu.id = docout.iddocout and tu.typedoc = ";
            int num = 0x463;
            textArray1[9] = num.ToString();
            textArray1[10] = " where r.id is not null and tu.id is not null) ";
            string selectCommandText = string.Concat(textArray1);
            if (this.int_0 != -1)
            {
                string[] textArray2 = new string[9];
                textArray2[0] = selectCommandText;
                textArray2[1] = " union select  req.id, req.numin, req.datein,  isnull(req.numIn, '') + ' от ' + isnull(convert( varchar(10),req.DateIn, 104), '') as numDateIn  from ttc_docout docOut  left join ttc_doc r on r.id = docOut.idDoc and (r.typeDoc = ";
                num = 0x459;
                textArray2[2] = num.ToString();
                textArray2[3] = " or r.typeDoc = ";
                num = 0x4b3;
                textArray2[4] = num.ToString();
                textArray2[5] = ")  left join ttc_request req on r.id = req.id  left join ttc_doc tu on tu.id = docout.iddocout and tu.typedoc = ";
                textArray2[6] = 0x463.ToString();
                textArray2[7] = " where r.id is not null and tu.id = ";
                textArray2[8] = this.int_0.ToString();
                selectCommandText = string.Concat(textArray2);
            }
            selectCommandText = selectCommandText + " order by numIn, dateIn ";
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
                Sort = "numIn, dateIn"
            };
            this.comboBox_0.DataSource = source;
            this.comboBox_0.DisplayMember = "numDateIn";
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

        private DataTable method_30()
        {
            DataTable table = new DataTable("tSettings");
            DataColumn column = table.Columns.Add("id", typeof(int));
            column.AutoIncrement = true;
            table.PrimaryKey = new DataColumn[] { column };
            table.Columns.Add("settings", typeof(string));
            table.Columns.Add("module", typeof(string));
            return table;
        }

        private void method_31()
        {
            this.icontainer_0 = new Container();
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            DataGridViewCellStyle style3 = new DataGridViewCellStyle();
            DataGridViewCellStyle style4 = new DataGridViewCellStyle();
            DataGridViewCellStyle style5 = new DataGridViewCellStyle();
            DataGridViewCellStyle style6 = new DataGridViewCellStyle();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(FormTUAddEdit));
            DataGridViewCellStyle style7 = new DataGridViewCellStyle();
            DataGridViewCellStyle style8 = new DataGridViewCellStyle();
            this.label_0 = new Label();
            this.textBox_0 = new TextBox();
            this.dataSetTechConnection_0 = new DataSetTechConnection();
            this.label_1 = new Label();
            this.dateTimePicker_0 = new DateTimePicker();
            this.label_2 = new Label();
            this.comboBox_0 = new ComboBox();
            this.textBox_2 = new TextBox();
            this.label_3 = new Label();
            this.textBox_1 = new TextBox();
            this.label_4 = new Label();
            this.label_5 = new Label();
            this.textBox_3 = new TextBox();
            this.label_6 = new Label();
            this.comboBox_1 = new ComboBox();
            this.nullableNumericUpDown_0 = new NullableNumericUpDown();
            this.label_7 = new Label();
            this.label_8 = new Label();
            this.comboBox_2 = new ComboBox();
            this.label_9 = new Label();
            this.comboBox_3 = new ComboBox();
            this.nullableNumericUpDown_1 = new NullableNumericUpDown();
            this.label_10 = new Label();
            this.nullableNumericUpDown_2 = new NullableNumericUpDown();
            this.label_11 = new Label();
            this.label_12 = new Label();
            this.dataGridView_0 = new DataGridView();
            this.dataGridViewTextBoxColumn_50 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_51 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_52 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_53 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_54 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_55 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_56 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_57 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_58 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_59 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_60 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_61 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_62 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_63 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_64 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_65 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_66 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_67 = new DataGridViewTextBoxColumn();
            this.toolStrip_0 = new ToolStrip();
            this.toolStripButton_0 = new ToolStripButton();
            this.toolStripButton_1 = new ToolStripButton();
            this.toolStripButton_2 = new ToolStripButton();
            this.toolStripSeparator_0 = new ToolStripSeparator();
            this.toolStripButton_3 = new ToolStripButton();
            this.toolStripButton_4 = new ToolStripButton();
            this.button_0 = new Button();
            this.button_1 = new Button();
            this.tabControl_0 = new TabControl();
            this.tabPage_0 = new TabPage();
            this.label_13 = new Label();
            this.textBox_4 = new TextBox();
            this.tabControl_1 = new TabControl();
            this.tabPage_2 = new TabPage();
            this.tabPage_3 = new TabPage();
            this.dataGridViewExcelFilter_1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewTextBoxColumn_22 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_23 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_24 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_25 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_26 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_27 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_28 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_29 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_30 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_31 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_32 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_33 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_34 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_35 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_36 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_37 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_38 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_39 = new DataGridViewTextBoxColumn();
            this.bindingSource_1 = new BindingSource(this.icontainer_0);
            this.tabPage_4 = new TabPage();
            this.splitContainer_0 = new SplitContainer();
            this.dataGridViewExcelFilter_2 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewTextBoxColumn_45 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_46 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_47 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_48 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_49 = new DataGridViewTextBoxColumn();
            this.bindingSource_2 = new BindingSource(this.icontainer_0);
            this.toolStrip_2 = new ToolStrip();
            this.toolStripLabel_0 = new ToolStripLabel();
            this.toolStripButton_10 = new ToolStripButton();
            this.toolStripButton_11 = new ToolStripButton();
            this.toolStripSeparator_5 = new ToolStripSeparator();
            this.toolStripComboBox_0 = new ToolStripComboBox();
            this.toolStripButton_14 = new ToolStripButton();
            this.dataGridViewExcelFilter_3 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewTextBoxColumn_40 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_41 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_42 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_43 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_44 = new DataGridViewTextBoxColumn();
            this.bindingSource_3 = new BindingSource(this.icontainer_0);
            this.toolStrip_3 = new ToolStrip();
            this.toolStripLabel_1 = new ToolStripLabel();
            this.toolStripButton_12 = new ToolStripButton();
            this.toolStripButton_13 = new ToolStripButton();
            this.toolStripSeparator_6 = new ToolStripSeparator();
            this.toolStripComboBox_1 = new ToolStripComboBox();
            this.toolStripButton_15 = new ToolStripButton();
            this.tabPage_1 = new TabPage();
            this.dataGridViewExcelFilter_0 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewImageColumnNotNull_0 = new DataGridViewImageColumnNotNull();
            this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_18 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_19 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_20 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_21 = new DataGridViewTextBoxColumn();
            this.bindingSource_0 = new BindingSource(this.icontainer_0);
            this.toolStrip_1 = new ToolStrip();
            this.toolStripDropDownButton_0 = new ToolStripDropDownButton();
            this.toolStripMenuItem_0 = new ToolStripMenuItem();
            this.toolStripSeparator_1 = new ToolStripSeparator();
            this.toolStripButton_5 = new ToolStripButton();
            this.toolStripButton_6 = new ToolStripButton();
            this.toolStripButton_7 = new ToolStripButton();
            this.toolStripSeparator_2 = new ToolStripSeparator();
            this.toolStripButton_8 = new ToolStripButton();
            this.toolStripButton_9 = new ToolStripButton();
            this.backgroundWorker_0 = new BackgroundWorker();
            this.backgroundWorker_1 = new BackgroundWorker();
            this.backgroundWorker_2 = new BackgroundWorker();
            this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
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
            this.contextMenuStrip_0 = new ContextMenuStrip(this.icontainer_0);
            this.toolStripMenuItem_1 = new ToolStripMenuItem();
            this.toolStripMenuItem_2 = new ToolStripMenuItem();
            this.toolStripSeparator_3 = new ToolStripSeparator();
            this.toolStripMenuItem_3 = new ToolStripMenuItem();
            this.toolStripMenuItem_4 = new ToolStripMenuItem();
            this.toolStripMenuItem_5 = new ToolStripMenuItem();
            this.toolStripSeparator_4 = new ToolStripSeparator();
            this.toolStripMenuItem_6 = new ToolStripMenuItem();
            this.toolStripMenuItem_7 = new ToolStripMenuItem();
            this.toolStripButton_16 = new ToolStripButton();
            this.toolStripButton_17 = new ToolStripButton();
            this.dataSet_0 = new DataSet();
            this.dataTable_0 = new DataTable();
            this.dataColumn_0 = new DataColumn();
            this.dataTable_1 = new DataTable();
            this.dataColumn_1 = new DataColumn();
            this.dataSetTechConnection_0.BeginInit();
            this.nullableNumericUpDown_0.BeginInit();
            this.nullableNumericUpDown_1.BeginInit();
            this.nullableNumericUpDown_2.BeginInit();
            ((ISupportInitialize) this.dataGridView_0).BeginInit();
            this.toolStrip_0.SuspendLayout();
            this.tabControl_0.SuspendLayout();
            this.tabPage_0.SuspendLayout();
            this.tabControl_1.SuspendLayout();
            this.tabPage_2.SuspendLayout();
            this.tabPage_3.SuspendLayout();
            this.dataGridViewExcelFilter_1.BeginInit();
            ((ISupportInitialize) this.bindingSource_1).BeginInit();
            this.tabPage_4.SuspendLayout();
            this.splitContainer_0.Panel1.SuspendLayout();
            this.splitContainer_0.Panel2.SuspendLayout();
            this.splitContainer_0.SuspendLayout();
            this.dataGridViewExcelFilter_2.BeginInit();
            ((ISupportInitialize) this.bindingSource_2).BeginInit();
            this.toolStrip_2.SuspendLayout();
            this.dataGridViewExcelFilter_3.BeginInit();
            ((ISupportInitialize) this.bindingSource_3).BeginInit();
            this.toolStrip_3.SuspendLayout();
            this.tabPage_1.SuspendLayout();
            this.dataGridViewExcelFilter_0.BeginInit();
            ((ISupportInitialize) this.bindingSource_0).BeginInit();
            this.toolStrip_1.SuspendLayout();
            this.contextMenuStrip_0.SuspendLayout();
            this.dataSet_0.BeginInit();
            this.dataTable_0.BeginInit();
            this.dataTable_1.BeginInit();
            base.SuspendLayout();
            this.label_0.AutoSize = true;
            this.label_0.Location = new Point(0x10, 3);
            this.label_0.Name = "label1";
            this.label_0.Size = new Size(0x6b, 13);
            this.label_0.TabIndex = 0;
            this.label_0.Text = "Номер тех. условия";
            this.textBox_0.BackColor = SystemColors.Window;
            this.textBox_0.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tTC_Doc.numDoc", true));
            this.textBox_0.Enabled = false;
            this.textBox_0.Location = new Point(15, 0x13);
            this.textBox_0.Name = "txtNumDoc";
            this.textBox_0.Size = new Size(0x90, 20);
            this.textBox_0.TabIndex = 1;
            this.textBox_0.TextAlign = HorizontalAlignment.Right;
            this.textBox_0.TextChanged += new EventHandler(this.textBox_0_TextChanged);
            this.dataSetTechConnection_0.DataSetName = "DataSetTechConnection";
            this.dataSetTechConnection_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.label_1.AutoSize = true;
            this.label_1.Location = new Point(0xa6, 3);
            this.label_1.Name = "label2";
            this.label_1.Size = new Size(0x63, 13);
            this.label_1.TabIndex = 2;
            this.label_1.Text = "Дата тех. условия";
            this.dateTimePicker_0.DataBindings.Add(new Binding("Value", this.dataSetTechConnection_0, "tTC_Doc.dateDoc", true));
            this.dateTimePicker_0.Location = new Point(0xa9, 0x13);
            this.dateTimePicker_0.Name = "dateTimePickerDateDoc";
            this.dateTimePicker_0.Size = new Size(0xa3, 20);
            this.dateTimePicker_0.TabIndex = 3;
            this.dateTimePicker_0.ValueChanged += new EventHandler(this.dateTimePicker_0_ValueChanged);
            this.label_2.AutoSize = true;
            this.label_2.Location = new Point(6, 13);
            this.label_2.Name = "label3";
            this.label_2.Size = new Size(0x86, 13);
            this.label_2.TabIndex = 0;
            this.label_2.Text = "Номер и дата входящего";
            this.comboBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.comboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox_0.DataBindings.Add(new Binding("SelectedValue", this.dataSetTechConnection_0, "tTC_DocOut.idDoc", true));
            this.comboBox_0.FormattingEnabled = true;
            this.comboBox_0.Location = new Point(0x92, 10);
            this.comboBox_0.Name = "cmbNumDateIn";
            this.comboBox_0.Size = new Size(0x21d, 0x15);
            this.comboBox_0.TabIndex = 1;
            this.comboBox_0.SelectedIndexChanged += new EventHandler(this.comboBox_0_SelectedIndexChanged);
            this.comboBox_0.SelectedValueChanged += new EventHandler(this.comboBox_0_SelectedValueChanged);
            this.comboBox_0.TextChanged += new EventHandler(this.comboBox_0_TextChanged);
            this.textBox_2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_2.BackColor = SystemColors.Window;
            this.textBox_2.Location = new Point(0x92, 60);
            this.textBox_2.Name = "txtAbnObj";
            this.textBox_2.ReadOnly = true;
            this.textBox_2.Size = new Size(0x21d, 20);
            this.textBox_2.TabIndex = 5;
            this.label_3.AutoSize = true;
            this.label_3.Location = new Point(6, 0x3f);
            this.label_3.Name = "labelAbnObj";
            this.label_3.Size = new Size(0x2d, 13);
            this.label_3.TabIndex = 4;
            this.label_3.Text = "Объект";
            this.textBox_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_1.BackColor = SystemColors.Window;
            this.textBox_1.Location = new Point(0x92, 0x24);
            this.textBox_1.Name = "txtAbn";
            this.textBox_1.ReadOnly = true;
            this.textBox_1.Size = new Size(0x21d, 20);
            this.textBox_1.TabIndex = 3;
            this.label_4.AutoSize = true;
            this.label_4.Location = new Point(6, 0x27);
            this.label_4.Name = "labelAbn";
            this.label_4.Size = new Size(0x31, 13);
            this.label_4.TabIndex = 2;
            this.label_4.Text = "Абонент";
            this.label_5.AutoSize = true;
            this.label_5.Location = new Point(0x10, 0x1ad);
            this.label_5.Name = "label6";
            this.label_5.Size = new Size(70, 13);
            this.label_5.TabIndex = 20;
            this.label_5.Text = "Содержание";
            this.textBox_3.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.textBox_3.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tTC_Doc.body", true));
            this.textBox_3.Location = new Point(9, 0x1bd);
            this.textBox_3.Multiline = true;
            this.textBox_3.Name = "txtBody";
            this.textBox_3.Size = new Size(0x2c9, 0x3a);
            this.textBox_3.TabIndex = 0x15;
            this.textBox_3.TextChanged += new EventHandler(this.textBox_3_TextChanged);
            this.label_6.AutoSize = true;
            this.label_6.Location = new Point(12, 0xbf);
            this.label_6.Name = "label7";
            this.label_6.Size = new Size(160, 13);
            this.label_6.TabIndex = 7;
            this.label_6.Text = "Категория электроснабжения";
            this.comboBox_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.comboBox_1.DataBindings.Add(new Binding("SelectedValue", this.dataSetTechConnection_0, "tTC_TU.Category", true));
            this.comboBox_1.FormattingEnabled = true;
            this.comboBox_1.Location = new Point(0xb2, 0xbc);
            this.comboBox_1.Name = "cmbCategory";
            this.comboBox_1.Size = new Size(0x21a, 0x15);
            this.comboBox_1.TabIndex = 8;
            this.comboBox_1.SelectedIndexChanged += new EventHandler(this.comboBox_1_SelectedIndexChanged);
            this.nullableNumericUpDown_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.nullableNumericUpDown_0.DataBindings.Add(new Binding("Value", this.dataSetTechConnection_0, "tTC_TU.Power", true));
            this.nullableNumericUpDown_0.DecimalPlaces = 3;
            this.nullableNumericUpDown_0.Location = new Point(0xa5, 0xf2);
            int[] bits = new int[4];
            bits[0] = 0x186a0;
            this.nullableNumericUpDown_0.Maximum = new decimal(bits);
            this.nullableNumericUpDown_0.Name = "numPower";
            this.nullableNumericUpDown_0.Size = new Size(0x227, 20);
            this.nullableNumericUpDown_0.TabIndex = 12;
            this.nullableNumericUpDown_0.TextAlign = HorizontalAlignment.Right;
            decimal? nullable = null;
            this.nullableNumericUpDown_0.set_Value(nullable);
            this.nullableNumericUpDown_0.ValueChanged += new EventHandler(this.nullableNumericUpDown_0_ValueChanged);
            this.label_7.AutoSize = true;
            this.label_7.Location = new Point(13, 0xf4);
            this.label_7.Name = "label8";
            this.label_7.Size = new Size(0x87, 13);
            this.label_7.TabIndex = 11;
            this.label_7.Text = "Сущесвующая мощность";
            this.label_8.AutoSize = true;
            this.label_8.Location = new Point(0x15c, 3);
            this.label_8.Name = "labelPerformer";
            this.label_8.Size = new Size(0x4a, 13);
            this.label_8.TabIndex = 4;
            this.label_8.Text = "Исполнитель";
            this.comboBox_2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.comboBox_2.DataBindings.Add(new Binding("SelectedValue", this.dataSetTechConnection_0, "tTC_TU.Performer", true));
            this.comboBox_2.FormattingEnabled = true;
            this.comboBox_2.Location = new Point(0x15f, 0x12);
            this.comboBox_2.Name = "cmbPerformer";
            this.comboBox_2.Size = new Size(0x173, 0x15);
            this.comboBox_2.TabIndex = 5;
            this.comboBox_2.SelectedIndexChanged += new EventHandler(this.comboBox_2_SelectedIndexChanged);
            this.label_9.AutoSize = true;
            this.label_9.Location = new Point(12, 0xda);
            this.label_9.Name = "label11";
            this.label_9.Size = new Size(0x74, 13);
            this.label_9.TabIndex = 9;
            this.label_9.Text = "Уровень напряжения";
            this.comboBox_3.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.comboBox_3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_3.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox_3.DataBindings.Add(new Binding("SelectedValue", this.dataSetTechConnection_0, "tTC_TU.VoltageLevel", true));
            this.comboBox_3.FormattingEnabled = true;
            this.comboBox_3.Location = new Point(0xa5, 0xd7);
            this.comboBox_3.Name = "cmbVoltageLevel";
            this.comboBox_3.Size = new Size(0x227, 0x15);
            this.comboBox_3.TabIndex = 10;
            this.comboBox_3.Text = "10 кВТ";
            this.comboBox_3.SelectedIndexChanged += new EventHandler(this.comboBox_3_SelectedIndexChanged);
            this.nullableNumericUpDown_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.nullableNumericUpDown_1.DataBindings.Add(new Binding("Value", this.dataSetTechConnection_0, "tTC_TU.PowerAdd", true));
            this.nullableNumericUpDown_1.DecimalPlaces = 3;
            this.nullableNumericUpDown_1.Location = new Point(0xa5, 0x10c);
            int[] numArray2 = new int[4];
            numArray2[0] = 0x186a0;
            this.nullableNumericUpDown_1.Maximum = new decimal(numArray2);
            this.nullableNumericUpDown_1.Name = "numPowerAdd";
            this.nullableNumericUpDown_1.Size = new Size(0x227, 20);
            this.nullableNumericUpDown_1.TabIndex = 14;
            this.nullableNumericUpDown_1.TextAlign = HorizontalAlignment.Right;
            nullable = null;
            this.nullableNumericUpDown_1.set_Value(nullable);
            this.nullableNumericUpDown_1.ValueChanged += new EventHandler(this.nullableNumericUpDown_1_ValueChanged);
            this.label_10.AutoSize = true;
            this.label_10.Location = new Point(13, 270);
            this.label_10.Name = "label12";
            this.label_10.Size = new Size(0x94, 13);
            this.label_10.TabIndex = 13;
            this.label_10.Text = "Дополнительная мощность";
            this.nullableNumericUpDown_2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.nullableNumericUpDown_2.DataBindings.Add(new Binding("Value", this.dataSetTechConnection_0, "tTC_TU.PowerSum", true));
            this.nullableNumericUpDown_2.DecimalPlaces = 3;
            this.nullableNumericUpDown_2.Location = new Point(0xa5, 0x126);
            int[] numArray3 = new int[4];
            numArray3[0] = 0x186a0;
            this.nullableNumericUpDown_2.Maximum = new decimal(numArray3);
            this.nullableNumericUpDown_2.Name = "numPowerSum";
            this.nullableNumericUpDown_2.Size = new Size(0x227, 20);
            this.nullableNumericUpDown_2.TabIndex = 0x10;
            this.nullableNumericUpDown_2.TextAlign = HorizontalAlignment.Right;
            this.nullableNumericUpDown_2.set_Value(null);
            this.nullableNumericUpDown_2.ValueChanged += new EventHandler(this.nullableNumericUpDown_2_ValueChanged);
            this.label_11.AutoSize = true;
            this.label_11.Location = new Point(13, 0x128);
            this.label_11.Name = "label13";
            this.label_11.Size = new Size(0x8b, 13);
            this.label_11.TabIndex = 15;
            this.label_11.Text = "Максимальная мощность";
            this.label_12.AutoSize = true;
            this.label_12.Location = new Point(12, 0x144);
            this.label_12.Name = "label9";
            this.label_12.Size = new Size(0x76, 13);
            this.label_12.TabIndex = 0x11;
            this.label_12.Text = "Точки присоединения";
            this.dataGridView_0.AllowUserToAddRows = false;
            this.dataGridView_0.AllowUserToDeleteRows = false;
            this.dataGridView_0.AllowUserToResizeColumns = false;
            this.dataGridView_0.AllowUserToResizeRows = false;
            this.dataGridView_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style.BackColor = SystemColors.Control;
            style.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style.ForeColor = SystemColors.WindowText;
            style.SelectionBackColor = SystemColors.Highlight;
            style.SelectionForeColor = SystemColors.HighlightText;
            style.WrapMode = DataGridViewTriState.True;
            this.dataGridView_0.ColumnHeadersDefaultCellStyle = style;
            this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { 
                this.dataGridViewTextBoxColumn_50, this.dataGridViewTextBoxColumn_51, this.dataGridViewTextBoxColumn_52, this.dataGridViewTextBoxColumn_53, this.dataGridViewTextBoxColumn_54, this.dataGridViewTextBoxColumn_55, this.dataGridViewTextBoxColumn_56, this.dataGridViewTextBoxColumn_57, this.dataGridViewTextBoxColumn_58, this.dataGridViewTextBoxColumn_59, this.dataGridViewTextBoxColumn_60, this.dataGridViewTextBoxColumn_61, this.dataGridViewTextBoxColumn_62, this.dataGridViewTextBoxColumn_63, this.dataGridViewTextBoxColumn_64, this.dataGridViewTextBoxColumn_65,
                this.dataGridViewTextBoxColumn_66, this.dataGridViewTextBoxColumn_67
            };
            this.dataGridView_0.Columns.AddRange(dataGridViewColumns);
            style2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style2.BackColor = SystemColors.Window;
            style2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style2.ForeColor = SystemColors.ControlText;
            style2.SelectionBackColor = SystemColors.Highlight;
            style2.SelectionForeColor = SystemColors.HighlightText;
            style2.WrapMode = DataGridViewTriState.False;
            this.dataGridView_0.DefaultCellStyle = style2;
            this.dataGridView_0.Location = new Point(9, 340);
            this.dataGridView_0.MultiSelect = false;
            this.dataGridView_0.Name = "dgvPointAttach";
            this.dataGridView_0.ReadOnly = true;
            style3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style3.BackColor = SystemColors.Control;
            style3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style3.ForeColor = SystemColors.WindowText;
            style3.SelectionBackColor = SystemColors.Highlight;
            style3.SelectionForeColor = SystemColors.HighlightText;
            style3.WrapMode = DataGridViewTriState.True;
            this.dataGridView_0.RowHeadersDefaultCellStyle = style3;
            this.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_0.Size = new Size(0x2c9, 0x56);
            this.dataGridView_0.TabIndex = 0x13;
            this.dataGridView_0.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView_0_CellDoubleClick);
            this.dataGridViewTextBoxColumn_50.HeaderText = "id";
            this.dataGridViewTextBoxColumn_50.Name = "idDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_50.ReadOnly = true;
            this.dataGridViewTextBoxColumn_50.Visible = false;
            this.dataGridViewTextBoxColumn_51.HeaderText = "num";
            this.dataGridViewTextBoxColumn_51.Name = "numDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_51.ReadOnly = true;
            this.dataGridViewTextBoxColumn_51.Visible = false;
            this.dataGridViewTextBoxColumn_52.HeaderText = "idSubPoint";
            this.dataGridViewTextBoxColumn_52.Name = "idSubPointColumn";
            this.dataGridViewTextBoxColumn_52.ReadOnly = true;
            this.dataGridViewTextBoxColumn_52.Visible = false;
            this.dataGridViewTextBoxColumn_53.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_53.HeaderText = "ТП/РП";
            this.dataGridViewTextBoxColumn_53.Name = "subPointDgvColumn";
            this.dataGridViewTextBoxColumn_53.ReadOnly = true;
            this.dataGridViewTextBoxColumn_53.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_54.HeaderText = "idBusPoint";
            this.dataGridViewTextBoxColumn_54.Name = "idBusPointColumn";
            this.dataGridViewTextBoxColumn_54.ReadOnly = true;
            this.dataGridViewTextBoxColumn_54.Visible = false;
            this.dataGridViewTextBoxColumn_55.HeaderText = "Шина";
            this.dataGridViewTextBoxColumn_55.Name = "busPointDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_55.ReadOnly = true;
            this.dataGridViewTextBoxColumn_55.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_55.Width = 50;
            this.dataGridViewTextBoxColumn_56.HeaderText = "idCellPoint";
            this.dataGridViewTextBoxColumn_56.Name = "idCellPointColumn";
            this.dataGridViewTextBoxColumn_56.ReadOnly = true;
            this.dataGridViewTextBoxColumn_56.Visible = false;
            this.dataGridViewTextBoxColumn_57.HeaderText = "Ячейка";
            this.dataGridViewTextBoxColumn_57.Name = "cellPointDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_57.ReadOnly = true;
            this.dataGridViewTextBoxColumn_57.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_57.Width = 50;
            this.dataGridViewTextBoxColumn_58.HeaderText = "idSubCP";
            this.dataGridViewTextBoxColumn_58.Name = "idSubCPColumn";
            this.dataGridViewTextBoxColumn_58.ReadOnly = true;
            this.dataGridViewTextBoxColumn_58.Visible = false;
            this.dataGridViewTextBoxColumn_59.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_59.HeaderText = "ЦП";
            this.dataGridViewTextBoxColumn_59.Name = "subCPDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_59.ReadOnly = true;
            this.dataGridViewTextBoxColumn_59.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_60.HeaderText = "idBusCP";
            this.dataGridViewTextBoxColumn_60.Name = "idBusCPColumn";
            this.dataGridViewTextBoxColumn_60.ReadOnly = true;
            this.dataGridViewTextBoxColumn_60.Visible = false;
            this.dataGridViewTextBoxColumn_61.HeaderText = "Шина";
            this.dataGridViewTextBoxColumn_61.Name = "busCPDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_61.ReadOnly = true;
            this.dataGridViewTextBoxColumn_61.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_61.Width = 50;
            this.dataGridViewTextBoxColumn_62.HeaderText = "idCellCP";
            this.dataGridViewTextBoxColumn_62.Name = "idCellCPColumn";
            this.dataGridViewTextBoxColumn_62.ReadOnly = true;
            this.dataGridViewTextBoxColumn_62.Visible = false;
            this.dataGridViewTextBoxColumn_63.HeaderText = "Ячейка";
            this.dataGridViewTextBoxColumn_63.Name = "cellCPDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_63.ReadOnly = true;
            this.dataGridViewTextBoxColumn_63.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_63.Width = 50;
            this.dataGridViewTextBoxColumn_64.HeaderText = "VoltageLevel";
            this.dataGridViewTextBoxColumn_64.Name = "voltageLevelDgvColumn";
            this.dataGridViewTextBoxColumn_64.ReadOnly = true;
            this.dataGridViewTextBoxColumn_64.Visible = false;
            this.dataGridViewTextBoxColumn_65.HeaderText = "Напр-ние";
            this.dataGridViewTextBoxColumn_65.Name = "voltageLevelNameDgvColumn";
            this.dataGridViewTextBoxColumn_65.ReadOnly = true;
            this.dataGridViewTextBoxColumn_66.HeaderText = "Мощ-сть";
            this.dataGridViewTextBoxColumn_66.Name = "powerSumDgvColumn";
            this.dataGridViewTextBoxColumn_66.ReadOnly = true;
            this.dataGridViewTextBoxColumn_67.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_67.FillWeight = 80f;
            this.dataGridViewTextBoxColumn_67.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn_67.Name = "descriptionDgvColumn";
            this.dataGridViewTextBoxColumn_67.ReadOnly = true;
            this.toolStrip_0.Dock = DockStyle.None;
            this.toolStrip_0.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripButton_0, this.toolStripButton_1, this.toolStripButton_2, this.toolStripSeparator_0, this.toolStripButton_3, this.toolStripButton_4 };
            this.toolStrip_0.Items.AddRange(toolStripItems);
            this.toolStrip_0.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip_0.Location = new Point(0x98, 0x13a);
            this.toolStrip_0.Name = "toolStripDGV";
            this.toolStrip_0.Size = new Size(0x7c, 0x19);
            this.toolStrip_0.TabIndex = 0x12;
            this.toolStrip_0.Text = "toolStrip1";
            this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_0.Image = Resources.ElementAdd;
            this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_0.Name = "toolBtnAddLink";
            this.toolStripButton_0.Size = new Size(0x17, 0x16);
            this.toolStripButton_0.Text = "Добавить";
            this.toolStripButton_0.Click += new EventHandler(this.toolStripButton_0_Click);
            this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_1.Image = Resources.ElementEdit;
            this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_1.Name = "toolBtnEditLink";
            this.toolStripButton_1.Size = new Size(0x17, 0x16);
            this.toolStripButton_1.Text = "Редактировать";
            this.toolStripButton_1.Click += new EventHandler(this.toolStripButton_1_Click);
            this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_2.Image = Resources.ElementDel;
            this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_2.Name = "toolBtnDelLink";
            this.toolStripButton_2.Size = new Size(0x17, 0x16);
            this.toolStripButton_2.Text = "Удалить";
            this.toolStripButton_2.Click += new EventHandler(this.toolStripButton_2_Click);
            this.toolStripSeparator_0.Name = "toolStripSeparator1";
            this.toolStripSeparator_0.Size = new Size(6, 0x19);
            this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_3.Image = Resources.arrow0012;
            this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_3.Name = "toolBtnUpLink";
            this.toolStripButton_3.Size = new Size(0x17, 0x16);
            this.toolStripButton_3.Text = "Вверх";
            this.toolStripButton_3.Click += new EventHandler(this.toolStripButton_3_Click);
            this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_4.Image = Resources.arrow0030;
            this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_4.Name = "toolBtnDownLink";
            this.toolStripButton_4.Size = new Size(0x17, 0x16);
            this.toolStripButton_4.Text = "Вниз";
            this.toolStripButton_4.Click += new EventHandler(this.toolStripButton_4_Click);
            this.button_0.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.button_0.Location = new Point(12, 0x21d);
            this.button_0.Name = "buttonSave";
            this.button_0.Size = new Size(0x4b, 0x17);
            this.button_0.TabIndex = 0x16;
            this.button_0.Text = "Сохранить";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new EventHandler(this.button_0_Click);
            this.button_1.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.button_1.Location = new Point(0x287, 0x21d);
            this.button_1.Name = "buttonClose";
            this.button_1.Size = new Size(0x4b, 0x17);
            this.button_1.TabIndex = 0x17;
            this.button_1.Text = "Закрыть";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new EventHandler(this.button_1_Click);
            this.tabControl_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.tabControl_0.Controls.Add(this.tabPage_0);
            this.tabControl_0.Controls.Add(this.tabPage_4);
            this.tabControl_0.Controls.Add(this.tabPage_1);
            this.tabControl_0.Location = new Point(0, 0);
            this.tabControl_0.Name = "tabControl";
            this.tabControl_0.SelectedIndex = 0;
            this.tabControl_0.Size = new Size(0x2e0, 0x217);
            this.tabControl_0.TabIndex = 0x18;
            this.tabPage_0.Controls.Add(this.label_13);
            this.tabPage_0.Controls.Add(this.textBox_4);
            this.tabPage_0.Controls.Add(this.tabControl_1);
            this.tabPage_0.Controls.Add(this.label_0);
            this.tabPage_0.Controls.Add(this.textBox_0);
            this.tabPage_0.Controls.Add(this.label_1);
            this.tabPage_0.Controls.Add(this.toolStrip_0);
            this.tabPage_0.Controls.Add(this.dateTimePicker_0);
            this.tabPage_0.Controls.Add(this.dataGridView_0);
            this.tabPage_0.Controls.Add(this.label_12);
            this.tabPage_0.Controls.Add(this.label_5);
            this.tabPage_0.Controls.Add(this.nullableNumericUpDown_2);
            this.tabPage_0.Controls.Add(this.textBox_3);
            this.tabPage_0.Controls.Add(this.label_11);
            this.tabPage_0.Controls.Add(this.label_6);
            this.tabPage_0.Controls.Add(this.nullableNumericUpDown_1);
            this.tabPage_0.Controls.Add(this.comboBox_1);
            this.tabPage_0.Controls.Add(this.label_10);
            this.tabPage_0.Controls.Add(this.label_7);
            this.tabPage_0.Controls.Add(this.comboBox_3);
            this.tabPage_0.Controls.Add(this.nullableNumericUpDown_0);
            this.tabPage_0.Controls.Add(this.label_9);
            this.tabPage_0.Controls.Add(this.label_8);
            this.tabPage_0.Controls.Add(this.comboBox_2);
            this.tabPage_0.Location = new Point(4, 0x16);
            this.tabPage_0.Name = "tabPageGeneral";
            this.tabPage_0.Padding = new Padding(3);
            this.tabPage_0.Size = new Size(0x2d8, 0x1fd);
            this.tabPage_0.TabIndex = 0;
            this.tabPage_0.Text = "Общие";
            this.tabPage_0.UseVisualStyleBackColor = true;
            this.label_13.AutoSize = true;
            this.label_13.Location = new Point(13, 0xa5);
            this.label_13.Name = "label10";
            this.label_13.Size = new Size(0xdd, 13);
            this.label_13.TabIndex = 0x18;
            this.label_13.Text = "Наименование энергопринимающих уст-в";
            this.textBox_4.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_4.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tTC_TU.DeviceName", true));
            this.textBox_4.Location = new Point(240, 0xa2);
            this.textBox_4.Name = "txtDeviceName";
            this.textBox_4.Size = new Size(0x1dc, 20);
            this.textBox_4.TabIndex = 0x17;
            this.textBox_4.TextChanged += new EventHandler(this.textBox_4_TextChanged);
            this.tabControl_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.tabControl_1.Controls.Add(this.tabPage_2);
            this.tabControl_1.Controls.Add(this.tabPage_3);
            this.tabControl_1.Location = new Point(15, 0x2c);
            this.tabControl_1.Name = "tabControlRequest";
            this.tabControl_1.SelectedIndex = 0;
            this.tabControl_1.Size = new Size(0x2bd, 0x71);
            this.tabControl_1.TabIndex = 0x16;
            this.tabPage_2.Controls.Add(this.label_3);
            this.tabPage_2.Controls.Add(this.textBox_2);
            this.tabPage_2.Controls.Add(this.label_2);
            this.tabPage_2.Controls.Add(this.comboBox_0);
            this.tabPage_2.Controls.Add(this.textBox_1);
            this.tabPage_2.Controls.Add(this.label_4);
            this.tabPage_2.Location = new Point(4, 0x16);
            this.tabPage_2.Name = "tabPage1";
            this.tabPage_2.Padding = new Padding(3);
            this.tabPage_2.Size = new Size(0x2b5, 0x57);
            this.tabPage_2.TabIndex = 0;
            this.tabPage_2.Text = "Выбор заявки";
            this.tabPage_2.UseVisualStyleBackColor = true;
            this.tabPage_3.Controls.Add(this.dataGridViewExcelFilter_1);
            this.tabPage_3.Location = new Point(4, 0x16);
            this.tabPage_3.Name = "tabPagerequestHistory";
            this.tabPage_3.Padding = new Padding(3);
            this.tabPage_3.Size = new Size(0x2b5, 0x57);
            this.tabPage_3.TabIndex = 1;
            this.tabPage_3.Text = "История заявок";
            this.tabPage_3.UseVisualStyleBackColor = true;
            this.dataGridViewExcelFilter_1.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_1.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_1.AutoGenerateColumns = false;
            this.dataGridViewExcelFilter_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray2 = new DataGridViewColumn[] { 
                this.dataGridViewTextBoxColumn_22, this.dataGridViewTextBoxColumn_23, this.dataGridViewTextBoxColumn_24, this.dataGridViewTextBoxColumn_25, this.dataGridViewTextBoxColumn_26, this.dataGridViewTextBoxColumn_27, this.dataGridViewTextBoxColumn_28, this.dataGridViewTextBoxColumn_29, this.dataGridViewTextBoxColumn_30, this.dataGridViewTextBoxColumn_31, this.dataGridViewTextBoxColumn_32, this.dataGridViewTextBoxColumn_33, this.dataGridViewTextBoxColumn_34, this.dataGridViewTextBoxColumn_35, this.dataGridViewTextBoxColumn_36, this.dataGridViewTextBoxColumn_37,
                this.dataGridViewTextBoxColumn_38, this.dataGridViewTextBoxColumn_39
            };
            this.dataGridViewExcelFilter_1.Columns.AddRange(columnArray2);
            this.dataGridViewExcelFilter_1.DataSource = this.bindingSource_1;
            this.dataGridViewExcelFilter_1.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_1.Location = new Point(3, 3);
            this.dataGridViewExcelFilter_1.MultiSelect = false;
            this.dataGridViewExcelFilter_1.Name = "dgvRequestHistory";
            this.dataGridViewExcelFilter_1.ReadOnly = true;
            this.dataGridViewExcelFilter_1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExcelFilter_1.Size = new Size(0x2af, 0x51);
            this.dataGridViewExcelFilter_1.TabIndex = 4;
            this.dataGridViewExcelFilter_1.VirtualMode = true;
            this.dataGridViewExcelFilter_1.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridViewExcelFilter_1_CellFormatting);
            this.dataGridViewExcelFilter_1.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dataGridViewExcelFilter_1_RowPostPaint);
            this.dataGridViewTextBoxColumn_22.DataPropertyName = "numDateIn";
            style4.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_22.DefaultCellStyle = style4;
            this.dataGridViewTextBoxColumn_22.HeaderText = "№, дата вход.";
            this.dataGridViewTextBoxColumn_22.Name = "numDateInDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_22.ReadOnly = true;
            this.dataGridViewTextBoxColumn_22.Width = 80;
            this.dataGridViewTextBoxColumn_23.DataPropertyName = "numDoc";
            this.dataGridViewTextBoxColumn_23.HeaderText = "numDoc";
            this.dataGridViewTextBoxColumn_23.Name = "numDocDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_23.ReadOnly = true;
            this.dataGridViewTextBoxColumn_23.Visible = false;
            this.dataGridViewTextBoxColumn_24.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_24.HeaderText = "id";
            this.dataGridViewTextBoxColumn_24.Name = "idRequestHistoryDgvColumn";
            this.dataGridViewTextBoxColumn_24.ReadOnly = true;
            this.dataGridViewTextBoxColumn_24.Visible = false;
            this.dataGridViewTextBoxColumn_25.DataPropertyName = "dateDoc";
            this.dataGridViewTextBoxColumn_25.HeaderText = "Дата получения";
            this.dataGridViewTextBoxColumn_25.Name = "dateDocDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_25.ReadOnly = true;
            this.dataGridViewTextBoxColumn_25.Width = 80;
            this.dataGridViewTextBoxColumn_26.DataPropertyName = "TypeDoc";
            this.dataGridViewTextBoxColumn_26.HeaderText = "TypeDoc";
            this.dataGridViewTextBoxColumn_26.Name = "typeDocRequestHistoryDgvColumn";
            this.dataGridViewTextBoxColumn_26.ReadOnly = true;
            this.dataGridViewTextBoxColumn_26.Visible = false;
            this.dataGridViewTextBoxColumn_27.DataPropertyName = "numIn";
            this.dataGridViewTextBoxColumn_27.HeaderText = "numIn";
            this.dataGridViewTextBoxColumn_27.Name = "numInDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_27.ReadOnly = true;
            this.dataGridViewTextBoxColumn_27.Visible = false;
            this.dataGridViewTextBoxColumn_28.DataPropertyName = "dateIn";
            this.dataGridViewTextBoxColumn_28.HeaderText = "dateIn";
            this.dataGridViewTextBoxColumn_28.Name = "dateInDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_28.ReadOnly = true;
            this.dataGridViewTextBoxColumn_28.Visible = false;
            this.dataGridViewTextBoxColumn_29.DataPropertyName = "idAbn";
            this.dataGridViewTextBoxColumn_29.HeaderText = "idAbn";
            this.dataGridViewTextBoxColumn_29.Name = "idAbnDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_29.ReadOnly = true;
            this.dataGridViewTextBoxColumn_29.Visible = false;
            this.dataGridViewTextBoxColumn_30.DataPropertyName = "idAbnObj";
            this.dataGridViewTextBoxColumn_30.HeaderText = "idAbnObj";
            this.dataGridViewTextBoxColumn_30.Name = "idAbnObjDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_30.ReadOnly = true;
            this.dataGridViewTextBoxColumn_30.Visible = false;
            this.dataGridViewTextBoxColumn_31.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_31.DataPropertyName = "body";
            style5.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_31.DefaultCellStyle = style5;
            this.dataGridViewTextBoxColumn_31.HeaderText = "Тело письма";
            this.dataGridViewTextBoxColumn_31.Name = "bodyDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_31.ReadOnly = true;
            this.dataGridViewTextBoxColumn_32.DataPropertyName = "PowerCurrent";
            this.dataGridViewTextBoxColumn_32.HeaderText = "Текущая мощность";
            this.dataGridViewTextBoxColumn_32.Name = "powerCurrentDgvColumn";
            this.dataGridViewTextBoxColumn_32.ReadOnly = true;
            this.dataGridViewTextBoxColumn_32.Width = 70;
            this.dataGridViewTextBoxColumn_33.DataPropertyName = "PowerAdd";
            this.dataGridViewTextBoxColumn_33.HeaderText = "Доп мощность";
            this.dataGridViewTextBoxColumn_33.Name = "PowerAddDgvColumn";
            this.dataGridViewTextBoxColumn_33.ReadOnly = true;
            this.dataGridViewTextBoxColumn_33.Width = 70;
            this.dataGridViewTextBoxColumn_34.DataPropertyName = "Power";
            this.dataGridViewTextBoxColumn_34.HeaderText = "Суммарная мощность";
            this.dataGridViewTextBoxColumn_34.Name = "powerDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_34.ReadOnly = true;
            this.dataGridViewTextBoxColumn_34.Width = 70;
            this.dataGridViewTextBoxColumn_35.DataPropertyName = "VoltageName";
            this.dataGridViewTextBoxColumn_35.HeaderText = "Напряжение";
            this.dataGridViewTextBoxColumn_35.Name = "voltageNameDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_35.ReadOnly = true;
            this.dataGridViewTextBoxColumn_35.Width = 70;
            this.dataGridViewTextBoxColumn_36.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn_36.HeaderText = "Комментарий";
            this.dataGridViewTextBoxColumn_36.Name = "commentDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_36.ReadOnly = true;
            this.dataGridViewTextBoxColumn_36.Width = 70;
            this.dataGridViewTextBoxColumn_37.DataPropertyName = "VoltageLevel";
            this.dataGridViewTextBoxColumn_37.HeaderText = "VoltageLevel";
            this.dataGridViewTextBoxColumn_37.Name = "voltageLevelDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_37.ReadOnly = true;
            this.dataGridViewTextBoxColumn_37.Visible = false;
            this.dataGridViewTextBoxColumn_38.DataPropertyName = "VoltageValue";
            this.dataGridViewTextBoxColumn_38.HeaderText = "VoltageValue";
            this.dataGridViewTextBoxColumn_38.Name = "voltageValueDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_38.ReadOnly = true;
            this.dataGridViewTextBoxColumn_38.Visible = false;
            this.dataGridViewTextBoxColumn_39.DataPropertyName = "IdParent";
            this.dataGridViewTextBoxColumn_39.HeaderText = "IdParent";
            this.dataGridViewTextBoxColumn_39.Name = "idParentDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_39.ReadOnly = true;
            this.dataGridViewTextBoxColumn_39.Visible = false;
            this.bindingSource_1.DataMember = "vTC_RequestHistory";
            this.bindingSource_1.DataSource = this.dataSetTechConnection_0;
            this.tabPage_4.Controls.Add(this.splitContainer_0);
            this.tabPage_4.Location = new Point(4, 0x16);
            this.tabPage_4.Name = "tabPageTypeWork";
            this.tabPage_4.Size = new Size(0x2d8, 0x1fd);
            this.tabPage_4.TabIndex = 2;
            this.tabPage_4.Text = "Вид работ";
            this.tabPage_4.UseVisualStyleBackColor = true;
            this.splitContainer_0.Dock = DockStyle.Fill;
            this.splitContainer_0.Location = new Point(0, 0);
            this.splitContainer_0.Name = "splitContainerTypeWork";
            this.splitContainer_0.Orientation = Orientation.Horizontal;
            this.splitContainer_0.Panel1.Controls.Add(this.dataGridViewExcelFilter_2);
            this.splitContainer_0.Panel1.Controls.Add(this.toolStrip_2);
            this.splitContainer_0.Panel2.Controls.Add(this.dataGridViewExcelFilter_3);
            this.splitContainer_0.Panel2.Controls.Add(this.toolStrip_3);
            this.splitContainer_0.Size = new Size(0x2d8, 0x1fd);
            this.splitContainer_0.SplitterDistance = 0x100;
            this.splitContainer_0.TabIndex = 0;
            this.dataGridViewExcelFilter_2.AutoGenerateColumns = false;
            this.dataGridViewExcelFilter_2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray3 = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_45, this.dataGridViewTextBoxColumn_46, this.dataGridViewTextBoxColumn_47, this.dataGridViewTextBoxColumn_48, this.dataGridViewTextBoxColumn_49 };
            this.dataGridViewExcelFilter_2.Columns.AddRange(columnArray3);
            this.dataGridViewExcelFilter_2.DataSource = this.bindingSource_2;
            this.dataGridViewExcelFilter_2.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_2.Location = new Point(0, 0x19);
            this.dataGridViewExcelFilter_2.Name = "dgvNetWork";
            this.dataGridViewExcelFilter_2.RowHeadersWidth = 0x15;
            this.dataGridViewExcelFilter_2.Size = new Size(0x2d8, 0xe7);
            this.dataGridViewExcelFilter_2.TabIndex = 1;
            this.dataGridViewExcelFilter_2.CellValueChanged += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_3_CellValueChanged);
            this.dataGridViewExcelFilter_2.DefaultValuesNeeded += new DataGridViewRowEventHandler(this.dataGridViewExcelFilter_2_DefaultValuesNeeded);
            this.dataGridViewExcelFilter_2.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dataGridViewExcelFilter_3_RowPostPaint);
            this.dataGridViewTextBoxColumn_45.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_45.DataPropertyName = "Work";
            style6.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_45.DefaultCellStyle = style6;
            this.dataGridViewTextBoxColumn_45.HeaderText = "Работы";
            this.dataGridViewTextBoxColumn_45.Name = "netWorkDgvColumn";
            this.dataGridViewTextBoxColumn_45.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_45.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_46.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_46.HeaderText = "id";
            this.dataGridViewTextBoxColumn_46.Name = "idNetWorkDgvColumn";
            this.dataGridViewTextBoxColumn_46.ReadOnly = true;
            this.dataGridViewTextBoxColumn_46.Visible = false;
            this.dataGridViewTextBoxColumn_47.DataPropertyName = "idTU";
            this.dataGridViewTextBoxColumn_47.HeaderText = "idTU";
            this.dataGridViewTextBoxColumn_47.Name = "idTUNetWorkDgvColumn";
            this.dataGridViewTextBoxColumn_47.Visible = false;
            this.dataGridViewTextBoxColumn_48.DataPropertyName = "num";
            this.dataGridViewTextBoxColumn_48.HeaderText = "num";
            this.dataGridViewTextBoxColumn_48.Name = "numNetWorkDgvColumn";
            this.dataGridViewTextBoxColumn_48.Visible = false;
            this.dataGridViewTextBoxColumn_49.DataPropertyName = "TypeWork";
            this.dataGridViewTextBoxColumn_49.HeaderText = "TypeWork";
            this.dataGridViewTextBoxColumn_49.Name = "typeWorkNetWorkDgvColumn";
            this.dataGridViewTextBoxColumn_49.Visible = false;
            this.bindingSource_2.DataMember = "tTC_TUTypeWork";
            this.bindingSource_2.DataSource = this.dataSetTechConnection_0;
            this.bindingSource_2.Filter = "TypeWork = 1";
            this.bindingSource_2.Sort = "num";
            this.toolStrip_2.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.toolStripLabel_0, this.toolStripButton_10, this.toolStripButton_11, this.toolStripSeparator_5, this.toolStripComboBox_0, this.toolStripButton_14, this.toolStripButton_16 };
            this.toolStrip_2.Items.AddRange(itemArray2);
            this.toolStrip_2.Location = new Point(0, 0);
            this.toolStrip_2.Name = "toolStripNetWork";
            this.toolStrip_2.Size = new Size(0x2d8, 0x19);
            this.toolStrip_2.TabIndex = 2;
            this.toolStrip_2.Text = "toolStrip1";
            this.toolStrip_2.Resize += new EventHandler(this.toolStrip_2_Resize);
            this.toolStripLabel_0.Name = "toolStripLabel1";
            this.toolStripLabel_0.Size = new Size(0xa8, 0x16);
            this.toolStripLabel_0.Text = "Работы сетевой организации";
            this.toolStripButton_10.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_10.Image = Resources.arrow0012;
            this.toolStripButton_10.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_10.Name = "toolBtnUpNetWork";
            this.toolStripButton_10.Size = new Size(0x17, 0x16);
            this.toolStripButton_10.Text = "toolStripButton1";
            this.toolStripButton_10.Click += new EventHandler(this.toolStripButton_10_Click);
            this.toolStripButton_11.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_11.Image = Resources.arrow0030;
            this.toolStripButton_11.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_11.Name = "toolBtnDownNetWork";
            this.toolStripButton_11.Size = new Size(0x17, 0x16);
            this.toolStripButton_11.Text = "toolStripButton1";
            this.toolStripButton_11.Click += new EventHandler(this.toolStripButton_11_Click);
            this.toolStripSeparator_5.Name = "toolStripSeparator6";
            this.toolStripSeparator_5.Size = new Size(6, 0x19);
            this.toolStripComboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.toolStripComboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.toolStripComboBox_0.AutoSize = false;
            object[] items = new object[] { "Монтаж трансформаторной подстанции на границе участка. Тип ТП, количество и мощность силовых трансформаторов определить проектным решением;", manager.GetString("cmbNetWork.Items"), "Прокладку кабельных линий 6-10 кВ от  РУ-10 кВ ТП-                 на проектируемой ТП. Способ прокладки, марку и сечение проводников определить проектным решением ", "Прокладку кабельных линий 0,4 кВ от ТП   . Способ прокладки, марку и сечение проводников определить проектным решением;", "Присоединение энергопринимающего устройства спортивной базы  к вновь построенной ЛЭП-0,4 кВ ТП  ;", "Комплекс организационно-технических мероприятий по обеспечению технологического присоединения;", "Замену силового трансформатора на силовой трансформатор мощностью    кВА в ТП-  ;" };
            this.toolStripComboBox_0.Items.AddRange(items);
            this.toolStripComboBox_0.Name = "cmbNetWork";
            this.toolStripComboBox_0.Size = new Size(300, 0x17);
            this.toolStripButton_14.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_14.Image = Resources.ElementAdd;
            this.toolStripButton_14.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_14.Name = "toolBtnAddNetWork";
            this.toolStripButton_14.Size = new Size(0x17, 0x16);
            this.toolStripButton_14.Text = "Добавить";
            this.toolStripButton_14.Click += new EventHandler(this.toolStripButton_14_Click);
            this.dataGridViewExcelFilter_3.AutoGenerateColumns = false;
            this.dataGridViewExcelFilter_3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray4 = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_40, this.dataGridViewTextBoxColumn_41, this.dataGridViewTextBoxColumn_42, this.dataGridViewTextBoxColumn_43, this.dataGridViewTextBoxColumn_44 };
            this.dataGridViewExcelFilter_3.Columns.AddRange(columnArray4);
            this.dataGridViewExcelFilter_3.DataSource = this.bindingSource_3;
            this.dataGridViewExcelFilter_3.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_3.Location = new Point(0, 0x19);
            this.dataGridViewExcelFilter_3.Name = "dgvClientWork";
            this.dataGridViewExcelFilter_3.RowHeadersWidth = 0x15;
            this.dataGridViewExcelFilter_3.Size = new Size(0x2d8, 0xe0);
            this.dataGridViewExcelFilter_3.TabIndex = 2;
            this.dataGridViewExcelFilter_3.CellValueChanged += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_3_CellValueChanged);
            this.dataGridViewExcelFilter_3.DefaultValuesNeeded += new DataGridViewRowEventHandler(this.dataGridViewExcelFilter_3_DefaultValuesNeeded);
            this.dataGridViewExcelFilter_3.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dataGridViewExcelFilter_3_RowPostPaint);
            this.dataGridViewTextBoxColumn_40.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_40.DataPropertyName = "Work";
            style7.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_40.DefaultCellStyle = style7;
            this.dataGridViewTextBoxColumn_40.HeaderText = "Работы";
            this.dataGridViewTextBoxColumn_40.Name = "clientWorkDgvColumn";
            this.dataGridViewTextBoxColumn_40.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_41.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_41.HeaderText = "id";
            this.dataGridViewTextBoxColumn_41.Name = "idClientWorkDgvColumn";
            this.dataGridViewTextBoxColumn_41.ReadOnly = true;
            this.dataGridViewTextBoxColumn_41.Visible = false;
            this.dataGridViewTextBoxColumn_42.DataPropertyName = "idTU";
            this.dataGridViewTextBoxColumn_42.HeaderText = "idTU";
            this.dataGridViewTextBoxColumn_42.Name = "idTUClientWorkDgvColumn";
            this.dataGridViewTextBoxColumn_42.Visible = false;
            this.dataGridViewTextBoxColumn_43.DataPropertyName = "num";
            this.dataGridViewTextBoxColumn_43.HeaderText = "num";
            this.dataGridViewTextBoxColumn_43.Name = "numClientWorkDgvColumn";
            this.dataGridViewTextBoxColumn_43.Visible = false;
            this.dataGridViewTextBoxColumn_44.DataPropertyName = "TypeWork";
            this.dataGridViewTextBoxColumn_44.HeaderText = "TypeWork";
            this.dataGridViewTextBoxColumn_44.Name = "typeWorkClientWorkDgvColumn";
            this.dataGridViewTextBoxColumn_44.Visible = false;
            this.bindingSource_3.DataMember = "tTC_TUTypeWork";
            this.bindingSource_3.DataSource = this.dataSetTechConnection_0;
            this.bindingSource_3.Filter = "TypeWork = 2";
            this.bindingSource_3.Sort = "num";
            this.toolStrip_3.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] itemArray3 = new ToolStripItem[] { this.toolStripLabel_1, this.toolStripButton_12, this.toolStripButton_13, this.toolStripSeparator_6, this.toolStripComboBox_1, this.toolStripButton_15, this.toolStripButton_17 };
            this.toolStrip_3.Items.AddRange(itemArray3);
            this.toolStrip_3.Location = new Point(0, 0);
            this.toolStrip_3.Name = "toolStripClientWork";
            this.toolStrip_3.Size = new Size(0x2d8, 0x19);
            this.toolStrip_3.TabIndex = 3;
            this.toolStrip_3.Text = "toolStrip1";
            this.toolStrip_3.Resize += new EventHandler(this.toolStrip_3_Resize);
            this.toolStripLabel_1.Name = "toolStripLabel2";
            this.toolStripLabel_1.Size = new Size(0x69, 0x16);
            this.toolStripLabel_1.Text = "Работы заказчика";
            this.toolStripButton_12.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_12.Image = Resources.arrow0012;
            this.toolStripButton_12.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_12.Name = "toolBtnUpClientWork";
            this.toolStripButton_12.Size = new Size(0x17, 0x16);
            this.toolStripButton_12.Text = "toolStripButton1";
            this.toolStripButton_12.Click += new EventHandler(this.toolStripButton_12_Click);
            this.toolStripButton_13.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_13.Image = Resources.arrow0030;
            this.toolStripButton_13.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_13.Name = "toolBtnDownClientWork";
            this.toolStripButton_13.Size = new Size(0x17, 0x16);
            this.toolStripButton_13.Text = "toolStripButton1";
            this.toolStripButton_13.Click += new EventHandler(this.toolStripButton_13_Click);
            this.toolStripSeparator_6.Name = "toolStripSeparator7";
            this.toolStripSeparator_6.Size = new Size(6, 0x19);
            this.toolStripComboBox_1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.toolStripComboBox_1.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.toolStripComboBox_1.AutoSize = false;
            object[] objArray2 = new object[] { "Строительство линии электропередач 0,4 кВ от   до ВРУ-0,4 кВ объекта; Тип ЛЭП, способ прокладки, марку и сечение проводников определить проектным решением;", "Монтаж ответвления от опоры ВЛ-0,4 кВ ТП-              к вводу объекта;                    ;", "Монтаж устройства, обеспечивающего контроль величины максимальной мощности;", manager.GetString("cmbClientWork.Items"), manager.GetString("cmbClientWork.Items1") };
            this.toolStripComboBox_1.Items.AddRange(objArray2);
            this.toolStripComboBox_1.Name = "cmbClientWork";
            this.toolStripComboBox_1.Size = new Size(300, 0x17);
            this.toolStripButton_15.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_15.Image = Resources.ElementAdd;
            this.toolStripButton_15.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_15.Name = "toolBtnAddClientWork";
            this.toolStripButton_15.Size = new Size(0x17, 0x16);
            this.toolStripButton_15.Text = "Добавить";
            this.toolStripButton_15.Click += new EventHandler(this.toolStripButton_15_Click);
            this.tabPage_1.Controls.Add(this.dataGridViewExcelFilter_0);
            this.tabPage_1.Controls.Add(this.toolStrip_1);
            this.tabPage_1.Location = new Point(4, 0x16);
            this.tabPage_1.Name = "tabPageFile";
            this.tabPage_1.Padding = new Padding(3);
            this.tabPage_1.Size = new Size(0x2d8, 0x1fd);
            this.tabPage_1.TabIndex = 1;
            this.tabPage_1.Text = "Файлы";
            this.tabPage_1.UseVisualStyleBackColor = true;
            this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToResizeColumns = false;
            this.dataGridViewExcelFilter_0.AllowUserToResizeRows = false;
            this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
            this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray5 = new DataGridViewColumn[] { this.dataGridViewImageColumnNotNull_0, this.dataGridViewFilterTextBoxColumn_0, this.dataGridViewTextBoxColumn_18, this.dataGridViewTextBoxColumn_19, this.dataGridViewTextBoxColumn_20, this.dataGridViewTextBoxColumn_21 };
            this.dataGridViewExcelFilter_0.Columns.AddRange(columnArray5);
            this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
            this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_0.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewExcelFilter_0.Location = new Point(3, 0x1c);
            this.dataGridViewExcelFilter_0.Name = "dgvFile";
            this.dataGridViewExcelFilter_0.ReadOnly = true;
            this.dataGridViewExcelFilter_0.RowHeadersVisible = false;
            this.dataGridViewExcelFilter_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExcelFilter_0.Size = new Size(0x2d2, 0x1de);
            this.dataGridViewExcelFilter_0.TabIndex = 6;
            this.dataGridViewExcelFilter_0.VirtualMode = true;
            this.dataGridViewExcelFilter_0.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_0_CellDoubleClick);
            this.dataGridViewExcelFilter_0.CellEndEdit += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_0_CellEndEdit);
            this.dataGridViewExcelFilter_0.CellMouseClick += new DataGridViewCellMouseEventHandler(this.dataGridViewExcelFilter_0_CellMouseClick);
            this.dataGridViewExcelFilter_0.CellValidating += new DataGridViewCellValidatingEventHandler(this.dataGridViewExcelFilter_0_CellValidating);
            this.dataGridViewExcelFilter_0.CellValueNeeded += new DataGridViewCellValueEventHandler(this.dataGridViewExcelFilter_0_CellValueNeeded);
            style8.NullValue = null;
            this.dataGridViewImageColumnNotNull_0.DefaultCellStyle = style8;
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
            this.dataGridViewTextBoxColumn_18.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_18.HeaderText = "id";
            this.dataGridViewTextBoxColumn_18.Name = "id";
            this.dataGridViewTextBoxColumn_18.ReadOnly = true;
            this.dataGridViewTextBoxColumn_18.Visible = false;
            this.dataGridViewTextBoxColumn_19.DataPropertyName = "idDoc";
            this.dataGridViewTextBoxColumn_19.HeaderText = "idDoc";
            this.dataGridViewTextBoxColumn_19.Name = "idDoc";
            this.dataGridViewTextBoxColumn_19.ReadOnly = true;
            this.dataGridViewTextBoxColumn_19.Visible = false;
            this.dataGridViewTextBoxColumn_20.DataPropertyName = "dateChange";
            this.dataGridViewTextBoxColumn_20.HeaderText = "dateChange";
            this.dataGridViewTextBoxColumn_20.Name = "dateChangeDgvColumn";
            this.dataGridViewTextBoxColumn_20.ReadOnly = true;
            this.dataGridViewTextBoxColumn_20.Visible = false;
            this.dataGridViewTextBoxColumn_21.DataPropertyName = "idTemplate";
            this.dataGridViewTextBoxColumn_21.HeaderText = "idTemplate";
            this.dataGridViewTextBoxColumn_21.Name = "idTemplateDgvColumn";
            this.dataGridViewTextBoxColumn_21.ReadOnly = true;
            this.dataGridViewTextBoxColumn_21.Visible = false;
            this.bindingSource_0.DataMember = "tTC_DocFile";
            this.bindingSource_0.DataSource = this.dataSetTechConnection_0;
            ToolStripItem[] itemArray4 = new ToolStripItem[] { this.toolStripDropDownButton_0, this.toolStripButton_5, this.toolStripButton_6, this.toolStripButton_7, this.toolStripSeparator_2, this.toolStripButton_8, this.toolStripButton_9 };
            this.toolStrip_1.Items.AddRange(itemArray4);
            this.toolStrip_1.Location = new Point(3, 3);
            this.toolStrip_1.Name = "toolStripFile";
            this.toolStrip_1.Size = new Size(0x2d2, 0x19);
            this.toolStrip_1.TabIndex = 0;
            this.toolStrip_1.Text = "toolStrip1";
            this.toolStripDropDownButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripItem[] itemArray5 = new ToolStripItem[] { this.toolStripMenuItem_0, this.toolStripSeparator_1 };
            this.toolStripDropDownButton_0.DropDownItems.AddRange(itemArray5);
            this.toolStripDropDownButton_0.Image = Resources.ElementAdd;
            this.toolStripDropDownButton_0.ImageTransparentColor = Color.Magenta;
            this.toolStripDropDownButton_0.Name = "toolBtnAddFile";
            this.toolStripDropDownButton_0.Size = new Size(0x1d, 0x16);
            this.toolStripDropDownButton_0.Text = "Добавить файл";
            this.toolStripMenuItem_0.Name = "toolItemAddExistFile";
            this.toolStripMenuItem_0.Size = new Size(190, 0x16);
            this.toolStripMenuItem_0.Text = "Сущесвующий файл";
            this.toolStripMenuItem_0.Click += new EventHandler(this.toolStripMenuItem_2_Click);
            this.toolStripSeparator_1.Name = "toolStripSeparator2";
            this.toolStripSeparator_1.Size = new Size(0xbb, 6);
            this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_5.Image = Resources.ElementEdit;
            this.toolStripButton_5.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_5.Name = "toolBtnEditFile";
            this.toolStripButton_5.Size = new Size(0x17, 0x16);
            this.toolStripButton_5.Text = "Редактировать файл";
            this.toolStripButton_5.Click += new EventHandler(this.toolStripMenuItem_3_Click);
            this.toolStripButton_6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_6.Image = Resources.ElementInformation;
            this.toolStripButton_6.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_6.Name = "toolBtnOpenFile";
            this.toolStripButton_6.Size = new Size(0x17, 0x16);
            this.toolStripButton_6.Text = "Открыть файл";
            this.toolStripButton_6.Click += new EventHandler(this.toolStripMenuItem_4_Click);
            this.toolStripButton_7.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_7.Image = Resources.ElementDel;
            this.toolStripButton_7.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_7.Name = "toolBtnDelFile";
            this.toolStripButton_7.Size = new Size(0x17, 0x16);
            this.toolStripButton_7.Text = "Удалить файл";
            this.toolStripButton_7.Click += new EventHandler(this.toolStripMenuItem_5_Click);
            this.toolStripSeparator_2.Name = "toolStripSeparator3";
            this.toolStripSeparator_2.Size = new Size(6, 0x19);
            this.toolStripButton_8.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_8.Image = Resources.rename;
            this.toolStripButton_8.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_8.Name = "toolBtnRenameFile";
            this.toolStripButton_8.Size = new Size(0x17, 0x16);
            this.toolStripButton_8.Text = "Переименовать";
            this.toolStripButton_8.Click += new EventHandler(this.toolStripMenuItem_6_Click);
            this.toolStripButton_9.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_9.Image = Resources.save;
            this.toolStripButton_9.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_9.Name = "toolBtnSaveFile";
            this.toolStripButton_9.Size = new Size(0x17, 0x16);
            this.toolStripButton_9.Text = "Сохранить файл на диск";
            this.toolStripButton_9.Click += new EventHandler(this.toolStripMenuItem_7_Click);
            this.dataGridViewTextBoxColumn_0.HeaderText = "id";
            this.dataGridViewTextBoxColumn_0.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_0.Visible = false;
            this.dataGridViewTextBoxColumn_1.HeaderText = "num";
            this.dataGridViewTextBoxColumn_1.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn_1.Visible = false;
            this.dataGridViewTextBoxColumn_2.HeaderText = "idSubPoint";
            this.dataGridViewTextBoxColumn_2.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn_2.Visible = false;
            this.dataGridViewTextBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_3.HeaderText = "ТП/РП";
            this.dataGridViewTextBoxColumn_3.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn_3.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_4.HeaderText = "idBusPoint";
            this.dataGridViewTextBoxColumn_4.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn_4.Visible = false;
            this.dataGridViewTextBoxColumn_5.HeaderText = "Шина";
            this.dataGridViewTextBoxColumn_5.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn_5.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_5.Width = 50;
            this.dataGridViewTextBoxColumn_6.HeaderText = "idCellPoint";
            this.dataGridViewTextBoxColumn_6.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn_6.Visible = false;
            this.dataGridViewTextBoxColumn_7.HeaderText = "Ячейка";
            this.dataGridViewTextBoxColumn_7.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn_7.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_7.Width = 50;
            this.dataGridViewTextBoxColumn_8.HeaderText = "idSubCP";
            this.dataGridViewTextBoxColumn_8.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn_8.Visible = false;
            this.dataGridViewTextBoxColumn_9.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_9.HeaderText = "ЦП";
            this.dataGridViewTextBoxColumn_9.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn_9.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_10.HeaderText = "idBusCP";
            this.dataGridViewTextBoxColumn_10.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn_10.Visible = false;
            this.dataGridViewTextBoxColumn_11.HeaderText = "Шина";
            this.dataGridViewTextBoxColumn_11.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn_11.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_11.Width = 50;
            this.dataGridViewTextBoxColumn_12.HeaderText = "idCellCP";
            this.dataGridViewTextBoxColumn_12.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn_12.Visible = false;
            this.dataGridViewTextBoxColumn_13.HeaderText = "Ячейка";
            this.dataGridViewTextBoxColumn_13.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn_13.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_13.Width = 50;
            this.dataGridViewTextBoxColumn_14.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_14.HeaderText = "id";
            this.dataGridViewTextBoxColumn_14.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn_14.ReadOnly = true;
            this.dataGridViewTextBoxColumn_14.Visible = false;
            this.dataGridViewTextBoxColumn_15.DataPropertyName = "idDoc";
            this.dataGridViewTextBoxColumn_15.HeaderText = "idDoc";
            this.dataGridViewTextBoxColumn_15.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn_15.Visible = false;
            this.dataGridViewTextBoxColumn_16.DataPropertyName = "dateChange";
            this.dataGridViewTextBoxColumn_16.HeaderText = "dateChange";
            this.dataGridViewTextBoxColumn_16.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn_16.Visible = false;
            this.dataGridViewTextBoxColumn_17.DataPropertyName = "idTemplate";
            this.dataGridViewTextBoxColumn_17.HeaderText = "idTemplate";
            this.dataGridViewTextBoxColumn_17.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn_17.Visible = false;
            ToolStripItem[] itemArray6 = new ToolStripItem[] { this.toolStripMenuItem_1, this.toolStripMenuItem_3, this.toolStripMenuItem_4, this.toolStripMenuItem_5, this.toolStripSeparator_4, this.toolStripMenuItem_6, this.toolStripMenuItem_7 };
            this.contextMenuStrip_0.Items.AddRange(itemArray6);
            this.contextMenuStrip_0.Name = "contextMenuFile";
            this.contextMenuStrip_0.Size = new Size(0xb1, 0x8e);
            ToolStripItem[] itemArray7 = new ToolStripItem[] { this.toolStripMenuItem_2, this.toolStripSeparator_3 };
            this.toolStripMenuItem_1.DropDownItems.AddRange(itemArray7);
            this.toolStripMenuItem_1.Image = Resources.ElementAdd;
            this.toolStripMenuItem_1.Name = "toolMenuItemAddFile";
            this.toolStripMenuItem_1.Size = new Size(0xb0, 0x16);
            this.toolStripMenuItem_1.Text = "Добавить";
            this.toolStripMenuItem_2.Name = "toolMenuItemAddExistsFile";
            this.toolStripMenuItem_2.Size = new Size(0xc3, 0x16);
            this.toolStripMenuItem_2.Text = "Существующий файл";
            this.toolStripMenuItem_2.Click += new EventHandler(this.toolStripMenuItem_2_Click);
            this.toolStripSeparator_3.Name = "toolStripSeparator5";
            this.toolStripSeparator_3.Size = new Size(0xc0, 6);
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
            this.toolStripSeparator_4.Name = "toolStripSeparator4";
            this.toolStripSeparator_4.Size = new Size(0xad, 6);
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
            this.toolStripButton_16.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_16.Image = Resources.report;
            this.toolStripButton_16.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_16.Name = "toolBtnReferenceTypeWork";
            this.toolStripButton_16.Size = new Size(0x17, 0x16);
            this.toolStripButton_16.Text = "Справочник типов работ";
            this.toolStripButton_16.Click += new EventHandler(this.toolStripButton_17_Click);
            this.toolStripButton_17.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_17.Image = Resources.report;
            this.toolStripButton_17.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_17.Name = "toolBtnReferenceTypeWork2";
            this.toolStripButton_17.Size = new Size(0x17, 0x16);
            this.toolStripButton_17.Text = "Справочник типов работ";
            this.toolStripButton_17.Click += new EventHandler(this.toolStripButton_17_Click);
            this.dataSet_0.DataSetName = "NewDataSet";
            DataTable[] tables = new DataTable[] { this.dataTable_0, this.dataTable_1 };
            this.dataSet_0.Tables.AddRange(tables);
            DataColumn[] columns = new DataColumn[] { this.dataColumn_0 };
            this.dataTable_0.Columns.AddRange(columns);
            this.dataTable_0.TableName = "netWork";
            this.dataColumn_0.ColumnName = "Name";
            DataColumn[] columnArray7 = new DataColumn[] { this.dataColumn_1 };
            this.dataTable_1.Columns.AddRange(columnArray7);
            this.dataTable_1.TableName = "clientWork";
            this.dataColumn_1.ColumnName = "Name";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x2de, 0x240);
            base.Controls.Add(this.tabControl_0);
            base.Controls.Add(this.button_1);
            base.Controls.Add(this.button_0);
            base.Name = "FormTUAddEdit";
            this.Text = "FormTUAddEdit";
            base.FormClosing += new FormClosingEventHandler(this.FormTUAddEdit_FormClosing);
            base.Load += new EventHandler(this.FormTUAddEdit_Load);
            this.dataSetTechConnection_0.EndInit();
            this.nullableNumericUpDown_0.EndInit();
            this.nullableNumericUpDown_1.EndInit();
            this.nullableNumericUpDown_2.EndInit();
            ((ISupportInitialize) this.dataGridView_0).EndInit();
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            this.tabControl_0.ResumeLayout(false);
            this.tabPage_0.ResumeLayout(false);
            this.tabPage_0.PerformLayout();
            this.tabControl_1.ResumeLayout(false);
            this.tabPage_2.ResumeLayout(false);
            this.tabPage_2.PerformLayout();
            this.tabPage_3.ResumeLayout(false);
            this.dataGridViewExcelFilter_1.EndInit();
            ((ISupportInitialize) this.bindingSource_1).EndInit();
            this.tabPage_4.ResumeLayout(false);
            this.splitContainer_0.Panel1.ResumeLayout(false);
            this.splitContainer_0.Panel1.PerformLayout();
            this.splitContainer_0.Panel2.ResumeLayout(false);
            this.splitContainer_0.Panel2.PerformLayout();
            this.splitContainer_0.ResumeLayout(false);
            this.dataGridViewExcelFilter_2.EndInit();
            ((ISupportInitialize) this.bindingSource_2).EndInit();
            this.toolStrip_2.ResumeLayout(false);
            this.toolStrip_2.PerformLayout();
            this.dataGridViewExcelFilter_3.EndInit();
            ((ISupportInitialize) this.bindingSource_3).EndInit();
            this.toolStrip_3.ResumeLayout(false);
            this.toolStrip_3.PerformLayout();
            this.tabPage_1.ResumeLayout(false);
            this.tabPage_1.PerformLayout();
            this.dataGridViewExcelFilter_0.EndInit();
            ((ISupportInitialize) this.bindingSource_0).EndInit();
            this.toolStrip_1.ResumeLayout(false);
            this.toolStrip_1.PerformLayout();
            this.contextMenuStrip_0.ResumeLayout(false);
            this.dataSet_0.EndInit();
            this.dataTable_0.EndInit();
            this.dataTable_1.EndInit();
            base.ResumeLayout(false);
        }

        [CompilerGenerated]
        private void method_32()
        {
            this.bindingSource_0.ResetBindings(false);
        }

        private void method_4(int int_5)
        {
            DataSetTechConnection.tTC_RequestDataTable table = new DataSetTechConnection.tTC_RequestDataTable();
            base.SelectSqlData(table, true, " where id = " + int_5.ToString(), false);
            if (table.Rows.Count > 0)
            {
                if (table.Rows[0]["idAbn"] != DBNull.Value)
                {
                    this.int_3 = Convert.ToInt32(table.Rows[0]["idAbn"]);
                    this.label_4.ForeColor = Color.FromKnownColor(KnownColor.WindowText);
                    DataSetTechConnection.tAbnDataTable table2 = new DataSetTechConnection.tAbnDataTable();
                    base.SelectSqlData(table2, true, "where id = " + this.int_3.ToString(), false);
                    if (table2.Rows.Count > 0)
                    {
                        this.textBox_1.Text = table2.Rows[0]["name"].ToString();
                        int num = Convert.ToInt32(table2.Rows[0]["typeAbn"]);
                        if (table.Rows[0]["idAbnObj"] != DBNull.Value)
                        {
                            this.int_4 = Convert.ToInt32(table.Rows[0]["idAbnObj"]);
                            DataSetTechConnection.vAbnObjAddressDataTable table3 = new DataSetTechConnection.vAbnObjAddressDataTable();
                            DataColumn column = new DataColumn("AddressFL") {
                                Expression = "street + ', д. ' + houseall + ', кв. ' + name"
                            };
                            table3.Columns.Add(column);
                            column = new DataColumn("AddressUL") {
                                Expression = "street + ', д. ' + houseall"
                            };
                            table3.Columns.Add(column);
                            base.SelectSqlData(table3, true, "where id = " + this.int_4.ToString() + " order by name", false);
                            if (table3.Rows.Count > 0)
                            {
                                if (((num != 0xce) && (num != 0xfd)) && (num != 0x40d))
                                {
                                    this.textBox_2.Text = table3.Rows[0]["name"].ToString();
                                }
                                else
                                {
                                    this.textBox_2.Text = table3.Rows[0]["AddressFL"].ToString();
                                }
                                this.label_3.ForeColor = Color.FromKnownColor(KnownColor.WindowText);
                            }
                            else
                            {
                                this.int_4 = -1;
                                this.textBox_2.Text = "";
                                this.label_3.ForeColor = Color.Red;
                            }
                        }
                        else
                        {
                            this.int_4 = -1;
                            this.textBox_2.Text = "";
                            this.label_3.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        this.int_3 = -1;
                        this.int_4 = -1;
                        this.textBox_1.Text = this.textBox_2.Text = "";
                        this.label_4.ForeColor = this.label_3.ForeColor = Color.Red;
                    }
                }
                else
                {
                    this.int_3 = -1;
                    this.int_4 = -1;
                    this.textBox_1.Text = this.textBox_2.Text = "";
                    this.label_4.ForeColor = this.label_3.ForeColor = Color.Red;
                }
                if ((table.Rows[0]["PowerCurrent"] != DBNull.Value) && !this.nullableNumericUpDown_0.get_Value().HasValue)
                {
                    this.nullableNumericUpDown_0.set_Value(new decimal?(Convert.ToDecimal(table.Rows[0]["PowerCurrent"])));
                }
                if ((table.Rows[0]["PowerAdd"] != DBNull.Value) && !this.nullableNumericUpDown_1.get_Value().HasValue)
                {
                    this.nullableNumericUpDown_1.set_Value(new decimal?(Convert.ToDecimal(table.Rows[0]["PowerAdd"])));
                }
                if ((table.Rows[0]["Power"] != DBNull.Value) && !this.nullableNumericUpDown_2.get_Value().HasValue)
                {
                    this.nullableNumericUpDown_2.set_Value(new decimal?(Convert.ToDecimal(table.Rows[0]["Power"])));
                }
                if ((table.Rows[0]["VoltageLevel"] != DBNull.Value) && (this.comboBox_3.SelectedIndex < 0))
                {
                    this.comboBox_3.SelectedValue = table.Rows[0]["VoltageLevel"];
                }
                DataSetTechConnection.tTC_DocDataTable table4 = new DataSetTechConnection.tTC_DocDataTable();
                base.SelectSqlData(table4, true, " where id = " + int_5.ToString(), false);
                int num2 = int_5;
                if ((table4.Rows.Count > 0) && (table4.Rows[0]["idParent"] != DBNull.Value))
                {
                    num2 = Convert.ToInt32(table4.Rows[0]["idParent"]);
                }
                base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vTC_RequestHistory, true, "where id = " + num2.ToString() + " or IdParent = " + num2.ToString() + " order by dateDoc");
            }
            else
            {
                this.dataSetTechConnection_0.vTC_RequestHistory.Clear();
                this.int_3 = -1;
                this.int_4 = -1;
                this.textBox_1.Text = this.textBox_2.Text = "";
                this.label_4.ForeColor = this.label_3.ForeColor = Color.Red;
            }
        }

        private void method_5()
        {
            DataSetTechConnection.tR_ClassifierDataTable table = new DataSetTechConnection.tR_ClassifierDataTable();
            base.SelectSqlData(table, true, " where ParentKey = ';SKUEE;Category;' and isGroup = 0 and deleted = 0 order by name", false);
            this.comboBox_1.DataSource = table;
            this.comboBox_1.DisplayMember = "name";
            this.comboBox_1.ValueMember = "id";
            this.comboBox_1.SelectedIndex = -1;
        }

        private void method_6()
        {
            DataTable table = new DataTable("vWorkerGroup");
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("fio", typeof(string));
            base.SelectSqlData(table, true, "where ParentKey = ';GroupWorker;PerformerTU;' and dateEnd is null order by fio", false);
            this.comboBox_2.DataSource = table;
            this.comboBox_2.DisplayMember = "fio";
            this.comboBox_2.ValueMember = "id";
            this.comboBox_2.SelectedIndex = -1;
        }

        private void method_7()
        {
            DataSetTechConnection.tR_ClassifierDataTable table = new DataSetTechConnection.tR_ClassifierDataTable();
            base.SelectSqlData(table, true, " where ParentKey like ';VoltageLevels;%' and isGroup = 0 and deleted = 0 order by value", false);
            this.comboBox_3.DisplayMember = "name";
            this.comboBox_3.ValueMember = "id";
            this.comboBox_3.DataSource = table;
            this.comboBox_3.SelectedIndex = -1;
        }

        private bool method_8()
        {
            if (string.IsNullOrEmpty(this.textBox_0.Text))
            {
                if (this.int_0 != -1)
                {
                    this.textBox_0.Text = this.string_0;
                }
            }
            else
            {
                DataTable table = new DataTable("ttc_doc");
                table.Columns.Add("id");
                if (this.int_0 == -1)
                {
                    string[] textArray1 = new string[6];
                    textArray1[0] = " where numdoc = '";
                    textArray1[1] = this.textBox_0.Text;
                    textArray1[2] = "' and TypeDoc = ";
                    int num = 0x463;
                    textArray1[3] = num.ToString();
                    textArray1[4] = " and year(dateDoc) = ";
                    textArray1[5] = this.dateTimePicker_0.Value.Year.ToString();
                    base.SelectSqlData(table, true, string.Concat(textArray1), false);
                }
                if ((this.int_0 != -1) && (this.string_0 != this.textBox_0.Text))
                {
                    string[] textArray2 = new string[] { " where numdoc = '", this.textBox_0.Text, "' and TypeDoc = ", 0x463.ToString(), " and year(dateDoc) = ", this.dateTimePicker_0.Value.Year.ToString(), " and id <> ", this.int_0.ToString() };
                    base.SelectSqlData(table, true, string.Concat(textArray2), false);
                }
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Техническое условие с данным номером уже существует");
                    return false;
                }
            }
            if (this.int_3 == -1)
            {
                MessageBox.Show("В заявке не тех. присоединение не указан контрагент.\r\nНеобходимо в заявке на тех присоединение выбрать контрагента", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (this.int_4 == -1)
            {
                MessageBox.Show("В заявке не тех. присоединение не указан объект.\r\nНеобходимо в заявке на тех присоединение выбрать объект контрагента", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (this.comboBox_2.SelectedIndex < 0)
            {
                MessageBox.Show("Не выбран исполнитель", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.label_8.ForeColor = Color.Red;
                return false;
            }
            return true;
        }

        private bool method_9()
        {
            if (!this.method_8())
            {
                return false;
            }
            if (this.int_0 == -1)
            {
                this.method_10();
                if (this.int_0 == -1)
                {
                    return false;
                }
            }
            else if (!this.method_11())
            {
                return false;
            }
            if ((this.dataSetTechConnection_0.tTC_Doc.Rows.Count > 0) && (this.dataSetTechConnection_0.tTC_Doc.Rows[0]["numDoc"] != DBNull.Value))
            {
                this.string_0 = this.dataSetTechConnection_0.tTC_Doc.Rows[0]["numDoc"].ToString();
            }
            if (!this.method_12())
            {
                return false;
            }
            if (!this.method_13())
            {
                return false;
            }
            if (!this.method_14())
            {
                return false;
            }
            if (!this.method_25())
            {
                return false;
            }
            if (!this.method_26())
            {
                return false;
            }
            this.bool_0 = false;
            MessageBox.Show("Данные успешно сохранены.");
            return true;
        }

        private void nullableNumericUpDown_0_ValueChanged(object sender, EventArgs e)
        {
            this.bool_0 = true;
        }

        private void nullableNumericUpDown_1_ValueChanged(object sender, EventArgs e)
        {
            this.bool_0 = true;
        }

        private void nullableNumericUpDown_2_ValueChanged(object sender, EventArgs e)
        {
            this.bool_0 = true;
        }

        private void textBox_0_TextChanged(object sender, EventArgs e)
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

        private void toolStrip_2_Resize(object sender, EventArgs e)
        {
            this.method_27();
        }

        private void toolStrip_3_Resize(object sender, EventArgs e)
        {
            this.method_28();
        }

        private void toolStripButton_0_Click(object sender, EventArgs e)
        {
            FormLinkTUAndSchmObj obj2 = new FormLinkTUAndSchmObj();
            obj2.set_SqlSettings(this.get_SqlSettings());
            if (obj2.ShowDialog() == DialogResult.OK)
            {
                object[] values = new object[] { 
                    -1, -1, obj2.idSubPoint, obj2.SubPoint, obj2.idBusPoint, obj2.BusPoint, obj2.idCellPoint, obj2.CellPoint, obj2.idSubCP, obj2.SubCP, obj2.idBusCP, obj2.BusCP, obj2.idCellCP, obj2.CellCP, obj2.idVoltagelevel, obj2.VoltageLevel,
                    obj2.PowerSum, obj2.DescriptionPoint
                };
                this.dataGridView_0.Rows.Add(values);
                this.bool_0 = true;
            }
        }

        private void toolStripButton_1_Click(object sender, EventArgs e)
        {
            if (this.dataGridView_0.CurrentRow != null)
            {
                FormLinkTUAndSchmObj obj2 = new FormLinkTUAndSchmObj(this.dataGridView_0.CurrentRow);
                obj2.set_SqlSettings(this.get_SqlSettings());
                if (obj2.ShowDialog() == DialogResult.OK)
                {
                    this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_52.Name].Value = obj2.idSubPoint;
                    this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_53.Name].Value = obj2.SubPoint;
                    this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_54.Name].Value = obj2.idBusPoint;
                    this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_55.Name].Value = obj2.BusPoint;
                    this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_56.Name].Value = obj2.idCellPoint;
                    this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_57.Name].Value = obj2.CellPoint;
                    this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_58.Name].Value = obj2.idSubCP;
                    this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_59.Name].Value = obj2.SubCP;
                    this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_60.Name].Value = obj2.idBusCP;
                    this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_61.Name].Value = obj2.BusCP;
                    this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_62.Name].Value = obj2.idCellCP;
                    this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_63.Name].Value = obj2.CellCP;
                    this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_64.Name].Value = obj2.idVoltagelevel;
                    this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_65.Name].Value = obj2.VoltageLevel;
                    this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_66.Name].Value = obj2.PowerSum;
                    this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_67.Name].Value = obj2.DescriptionPoint;
                    this.bool_0 = true;
                }
            }
        }

        private void toolStripButton_10_Click(object sender, EventArgs e)
        {
            if (((this.dataGridViewExcelFilter_2.CurrentRow != null) && (this.dataGridViewExcelFilter_2.CurrentRow.Index > 0)) && ((this.dataGridViewExcelFilter_2.CurrentRow.Cells[this.dataGridViewTextBoxColumn_46.Name].Value != null) && (this.dataGridViewExcelFilter_2.CurrentRow.Cells[this.dataGridViewTextBoxColumn_46.Name].Value != DBNull.Value)))
            {
                DataRow row = this.dataSetTechConnection_0.tTC_TUTypeWork.method_2(Convert.ToInt32(this.dataGridViewExcelFilter_2.CurrentRow.Cells[this.dataGridViewTextBoxColumn_46.Name].Value));
                DataSetTechConnection.Class255 class1 = this.dataSetTechConnection_0.tTC_TUTypeWork.method_2(Convert.ToInt32(this.dataGridViewExcelFilter_2.Rows[this.dataGridViewExcelFilter_2.CurrentRow.Index - 1].Cells[this.dataGridViewTextBoxColumn_46.Name].Value));
                int num = Convert.ToInt32(class1["num"]);
                row["num"] = num;
                class1["num"] = num + 1;
                row.EndEdit();
                class1.EndEdit();
                this.bool_0 = true;
            }
        }

        private void toolStripButton_11_Click(object sender, EventArgs e)
        {
            if (((this.dataGridViewExcelFilter_2.CurrentRow != null) && (this.dataGridViewExcelFilter_2.CurrentRow.Index < (this.dataGridViewExcelFilter_2.Rows.Count - 2))) && ((this.dataGridViewExcelFilter_2.CurrentRow.Cells[this.dataGridViewTextBoxColumn_46.Name].Value != null) && (this.dataGridViewExcelFilter_2.CurrentRow.Cells[this.dataGridViewTextBoxColumn_46.Name].Value != DBNull.Value)))
            {
                DataRow row = this.dataSetTechConnection_0.tTC_TUTypeWork.method_2(Convert.ToInt32(this.dataGridViewExcelFilter_2.CurrentRow.Cells[this.dataGridViewTextBoxColumn_46.Name].Value));
                DataRow row2 = this.dataSetTechConnection_0.tTC_TUTypeWork.method_2(Convert.ToInt32(this.dataGridViewExcelFilter_2.Rows[this.dataGridViewExcelFilter_2.CurrentRow.Index + 1].Cells[this.dataGridViewTextBoxColumn_46.Name].Value));
                int num = Convert.ToInt32(row["num"]);
                row2["num"] = num;
                row["num"] = num + 1;
                row2.EndEdit();
                row.EndEdit();
                this.bool_0 = true;
            }
        }

        private void toolStripButton_12_Click(object sender, EventArgs e)
        {
            if (((this.dataGridViewExcelFilter_3.CurrentRow != null) && (this.dataGridViewExcelFilter_3.CurrentRow.Index > 0)) && ((this.dataGridViewExcelFilter_3.CurrentRow.Cells[this.dataGridViewTextBoxColumn_41.Name].Value != null) && (this.dataGridViewExcelFilter_3.CurrentRow.Cells[this.dataGridViewTextBoxColumn_41.Name].Value != DBNull.Value)))
            {
                DataRow row = this.dataSetTechConnection_0.tTC_TUTypeWork.method_2(Convert.ToInt32(this.dataGridViewExcelFilter_3.CurrentRow.Cells[this.dataGridViewTextBoxColumn_41.Name].Value));
                DataSetTechConnection.Class255 class1 = this.dataSetTechConnection_0.tTC_TUTypeWork.method_2(Convert.ToInt32(this.dataGridViewExcelFilter_3.Rows[this.dataGridViewExcelFilter_3.CurrentRow.Index - 1].Cells[this.dataGridViewTextBoxColumn_41.Name].Value));
                int num = Convert.ToInt32(class1["num"]);
                row["num"] = num;
                class1["num"] = num + 1;
                row.EndEdit();
                class1.EndEdit();
                this.bool_0 = true;
            }
        }

        private void toolStripButton_13_Click(object sender, EventArgs e)
        {
            if (((this.dataGridViewExcelFilter_3.CurrentRow != null) && (this.dataGridViewExcelFilter_3.CurrentRow.Index < (this.dataGridViewExcelFilter_3.Rows.Count - 2))) && ((this.dataGridViewExcelFilter_3.CurrentRow.Cells[this.dataGridViewTextBoxColumn_41.Name].Value != null) && (this.dataGridViewExcelFilter_3.CurrentRow.Cells[this.dataGridViewTextBoxColumn_41.Name].Value != DBNull.Value)))
            {
                DataRow row = this.dataSetTechConnection_0.tTC_TUTypeWork.method_2(Convert.ToInt32(this.dataGridViewExcelFilter_3.CurrentRow.Cells[this.dataGridViewTextBoxColumn_41.Name].Value));
                DataRow row2 = this.dataSetTechConnection_0.tTC_TUTypeWork.method_2(Convert.ToInt32(this.dataGridViewExcelFilter_3.Rows[this.dataGridViewExcelFilter_3.CurrentRow.Index + 1].Cells[this.dataGridViewTextBoxColumn_41.Name].Value));
                int num = Convert.ToInt32(row["num"]);
                row2["num"] = num;
                row["num"] = num + 1;
                row2.EndEdit();
                row.EndEdit();
                this.bool_0 = true;
            }
        }

        private void toolStripButton_14_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.toolStripComboBox_0.Text))
            {
                DataRow row = this.dataSetTechConnection_0.tTC_TUTypeWork.NewRow();
                row["idTU"] = this.int_0;
                row["num"] = this.dataGridViewExcelFilter_2.Rows.Count;
                row["Work"] = this.toolStripComboBox_0.Text;
                row["typeWork"] = 1;
                this.dataSetTechConnection_0.tTC_TUTypeWork.Rows.Add(row);
                this.bool_0 = true;
            }
        }

        private void toolStripButton_15_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.toolStripComboBox_1.Text))
            {
                DataRow row = this.dataSetTechConnection_0.tTC_TUTypeWork.NewRow();
                row["idTU"] = this.int_0;
                row["num"] = this.dataGridViewExcelFilter_3.Rows.Count;
                row["Work"] = this.toolStripComboBox_1.Text;
                row["typeWork"] = 2;
                this.dataSetTechConnection_0.tTC_TUTypeWork.Rows.Add(row);
                this.bool_0 = true;
            }
        }

        private void toolStripButton_17_Click(object sender, EventArgs e)
        {
            Form7 form1 = new Form7();
            form1.set_SqlSettings(this.get_SqlSettings());
            if (form1.ShowDialog() == DialogResult.OK)
            {
                this.method_2();
            }
        }

        private void toolStripButton_2_Click(object sender, EventArgs e)
        {
            if (this.dataGridView_0.CurrentRow != null)
            {
                this.dataGridView_0.Rows.Remove(this.dataGridView_0.CurrentRow);
                this.bool_0 = true;
            }
        }

        private void toolStripButton_3_Click(object sender, EventArgs e)
        {
            if ((this.dataGridView_0.CurrentRow != null) && (this.dataGridView_0.CurrentRow.Index > 0))
            {
                int index = this.dataGridView_0.CurrentRow.Index;
                DataGridViewRow currentRow = this.dataGridView_0.CurrentRow;
                this.dataGridView_0.Rows.Remove(this.dataGridView_0.CurrentRow);
                this.dataGridView_0.Rows.Insert(index - 1, currentRow);
                this.dataGridView_0.FirstDisplayedScrollingRowIndex = index - 1;
                this.dataGridView_0[this.dataGridViewTextBoxColumn_53.Name, index - 1].Selected = true;
                this.dataGridView_0.CurrentCell = this.dataGridView_0[this.dataGridViewTextBoxColumn_53.Name, index - 1];
                this.bool_0 = true;
            }
        }

        private void toolStripButton_4_Click(object sender, EventArgs e)
        {
            if ((this.dataGridView_0.CurrentRow != null) && (this.dataGridView_0.CurrentRow.Index < (this.dataGridView_0.Rows.Count - 1)))
            {
                int index = this.dataGridView_0.CurrentRow.Index;
                DataGridViewRow currentRow = this.dataGridView_0.CurrentRow;
                this.dataGridView_0.Rows.Remove(this.dataGridView_0.CurrentRow);
                this.dataGridView_0.Rows.Insert(index + 1, currentRow);
                this.dataGridView_0.FirstDisplayedScrollingRowIndex = index + 1;
                this.dataGridView_0[this.dataGridViewTextBoxColumn_53.Name, index + 1].Selected = true;
                this.dataGridView_0.CurrentCell = this.dataGridView_0[this.dataGridViewTextBoxColumn_53.Name, index + 1];
                this.bool_0 = true;
            }
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
                    if (!string.IsNullOrEmpty(this.method_16(str, nullable, null)))
                    {
                        this.bool_0 = true;
                    }
                }
            }
        }

        private void toolStripMenuItem_3_Click(object sender, EventArgs e)
        {
            this.method_19(true);
        }

        private void toolStripMenuItem_4_Click(object sender, EventArgs e)
        {
            this.method_19(false);
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
                        this.dictionary_0[fileName].get_Watcher().remove_AnyChanged(new FileSystemEventHandler(this.method_20));
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
                this.string_1 = this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewFilterTextBoxColumn_0.Name].Value.ToString();
                this.dataGridViewExcelFilter_0.CurrentCell = this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewFilterTextBoxColumn_0.Name];
                this.dataGridViewExcelFilter_0.CurrentCell.Value = Path.GetFileNameWithoutExtension(this.string_1);
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

        public int IdTU
        {
            get
            {
                return this.int_0;
            }
        }

        [CompilerGenerated]
        private sealed class Class281
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
        private sealed class Class282
        {
            public string string_0;

            internal bool method_0(DataSetTechConnection.Class252 class252_0)
            {
                return (class252_0.FileName == this.string_0);
            }
        }
    }
}

