using ControlsLbr;
using ControlsLbr.DataGridViewExcelFilter;
using ControlsLbr.DataGridViewExcelFilter.DataGridViewColumsLibraty;
using DataSql;
using Documents.Forms.TechnologicalConnection;
using Documents.Properties;
using FormLbr;
using FormLbr.Classes;
using OfficeLB.Word;
using System;
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

internal class Form12 : FormBase
{
    private BindingSource bindingSource_0;
    private BindingSource bindingSource_1;
    private BindingSource bindingSource_2;
    private bool bool_0;
    private Button button_0;
    private Button button_1;
    private ComboBox comboBox_0;
    private ComboBox comboBox_1;
    private ContextMenuStrip contextMenuStrip_0;
    private DataGridView dataGridView_0;
    private DataGridView dataGridView_1;
    private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_0;
    private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_1;
    private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_0;
    private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_1;
    private DataGridViewFilterDateTimePickerColumn dataGridViewFilterDateTimePickerColumn_0;
    private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;
    private DataGridViewImageColumnNotNull dataGridViewImageColumnNotNull_0;
    private DataGridViewNumericColumn dataGridViewNumericColumn_0;
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
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;
    private DataSetTechConnection dataSetTechConnection_0;
    private DataSetTechConnection dataSetTechConnection_1;
    private DataSetTechConnection dataSetTechConnection_2;
    private DataTable dataTable_0;
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
    private NullableDateTimePicker nullableDateTimePicker_3;
    private NullableNumericUpDown nullableNumericUpDown_0;
    private NullableNumericUpDown nullableNumericUpDown_1;
    private string string_0;
    private const string string_1 = "TCContractWord";
    private TabControl tabControl_0;
    private TabPage tabPage_0;
    private TabPage tabPage_1;
    private TabPage tabPage_2;
    private TabPage tabPage_3;
    private TabPage tabPage_4;
    private TextBox textBox_0;
    private TextBox textBox_1;
    private TextBox textBox_2;
    private TextBox textBox_3;
    private ToolStrip toolStrip_0;
    private ToolStrip toolStrip_1;
    private ToolStrip toolStrip_2;
    private ToolStripButton toolStripButton_0;
    private ToolStripButton toolStripButton_1;
    private ToolStripButton toolStripButton_10;
    private ToolStripButton toolStripButton_2;
    private ToolStripButton toolStripButton_3;
    private ToolStripButton toolStripButton_4;
    private ToolStripButton toolStripButton_5;
    private ToolStripButton toolStripButton_6;
    private ToolStripButton toolStripButton_7;
    private ToolStripButton toolStripButton_8;
    private ToolStripButton toolStripButton_9;
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

    internal Form12()
    {
        this.int_0 = -1;
        this.int_1 = -1;
        this.int_2 = -1;
        this.int_3 = -1;
        this.int_4 = -1;
        this.dataSetTechConnection_0 = new DataSetTechConnection();
        this.dictionary_0 = new Dictionary<string, FileWatcherArgsAddl>();
        this.string_0 = "";
        this.dataSetTechConnection_1 = new DataSetTechConnection();
        this.dataTable_0 = new DataTable();
        this.method_25();
        this.method_1();
    }

    internal Form12(int int_5, int int_6 = -1, int int_7 = -1)
    {
        this.int_0 = -1;
        this.int_1 = -1;
        this.int_2 = -1;
        this.int_3 = -1;
        this.int_4 = -1;
        this.dataSetTechConnection_0 = new DataSetTechConnection();
        this.dictionary_0 = new Dictionary<string, FileWatcherArgsAddl>();
        this.string_0 = "";
        this.dataSetTechConnection_1 = new DataSetTechConnection();
        this.dataTable_0 = new DataTable();
        this.method_25();
        this.int_0 = int_5;
        this.int_1 = int_6;
        this.int_2 = int_7;
        this.method_1();
    }

    private void button_0_Click(object sender, EventArgs e)
    {
        if (this.method_6())
        {
            MessageBox.Show("Данные успешно сохранены");
        }
    }

    private void button_1_Click(object sender, EventArgs e)
    {
        base.Close();
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
            this.textBox_2.Text = this.textBox_3.Text = "";
            this.int_2 = -1;
        }
    }

    private void dataGridView_0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (this.toolStripButton_6.Visible && this.toolStripButton_6.Enabled)
        {
            this.toolStripButton_6_Click(sender, e);
        }
    }

    private void dataGridView_0_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
        if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
        {
            object obj2 = this.dataGridView_0.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            if (!((DataGridViewComboBoxColumn) this.dataGridView_0.Columns[e.ColumnIndex]).Items.Contains(obj2))
            {
                ((DataGridViewComboBoxColumn) this.dataGridView_0.Columns[e.ColumnIndex]).Items.Add(obj2);
                e.ThrowException = false;
            }
        }
    }

    private void dataGridView_1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
        if ((e.RowIndex >= 0) && ((this.dataGridView_1[this.dataGridViewTextBoxColumn_27.Name, e.RowIndex].Value == DBNull.Value) || (Convert.ToInt32(this.dataGridView_1[this.dataGridViewTextBoxColumn_27.Name, e.RowIndex].Value) != this.int_0)))
        {
            this.dataGridView_1[this.dataGridViewTextBoxColumn_27.Name, e.RowIndex].Value = this.int_0;
        }
    }

    private void dataGridViewExcelFilter_0_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        if (((e.RowIndex >= 0) && this.dataGridViewExcelFilter_0.Columns.Contains(this.dataGridViewTextBoxColumn_4)) && (Convert.ToInt32(this.dataGridViewExcelFilter_0[this.dataGridViewTextBoxColumn_4.Name, e.RowIndex].Value) == 0x459))
        {
            e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
            e.CellStyle.BackColor = Color.LightGray;
        }
    }

    private void dataGridViewExcelFilter_0_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
    {
        this.dataGridViewExcelFilter_0.AutoResizeRow(e.RowIndex);
    }

    private void dataGridViewExcelFilter_1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        this.toolStripMenuItem_4_Click(sender, e);
    }

    private void dataGridViewExcelFilter_1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
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

    private void dataGridViewExcelFilter_1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        if (((e.RowIndex >= 0) && (e.ColumnIndex >= 0)) && (e.Button == MouseButtons.Right))
        {
            this.dataGridViewExcelFilter_1.ClearSelection();
            this.dataGridViewExcelFilter_1.Rows[e.RowIndex].Selected = true;
            this.dataGridViewExcelFilter_1.CurrentCell = this.dataGridViewExcelFilter_1[e.ColumnIndex, e.RowIndex];
            Rectangle rectangle = this.dataGridViewExcelFilter_1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
            this.contextMenuStrip_0.Show((Control) sender, (int) (rectangle.Left + e.X), (int) (rectangle.Top + e.Y));
        }
    }

    private void dataGridViewExcelFilter_1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
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

    private void dataGridViewExcelFilter_1_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
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

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.icontainer_0 != null))
        {
            this.icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    private void Form12_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (this.bool_0)
        {
            DialogResult result = MessageBox.Show("Данные были изменены. Сохранить изменения", "Сохранение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else if ((result == DialogResult.Yes) && !this.method_6())
            {
                e.Cancel = true;
            }
        }
    }

    private void Form12_Load(object sender, EventArgs e)
    {
        this.method_20();
        this.method_24();
        this.method_3();
        this.method_8();
        if (this.int_0 == -1)
        {
            DataRow row = this.dataSetTechConnection_2.tTC_Doc.NewRow();
            row["TypeDoc"] = 0x4c4;
            row["DateDoc"] = DateTime.Now.Date;
            this.dataSetTechConnection_2.tTC_Doc.Rows.Add(row);
            this.method_2();
        }
        else
        {
            base.SelectSqlData(this.dataSetTechConnection_2, this.dataSetTechConnection_2.tTC_Doc, true, "where id = " + this.int_0.ToString());
            this.nullableNumericUpDown_0.ValueChanged -= new EventHandler(this.nullableNumericUpDown_0_ValueChanged);
            base.SelectSqlData(this.dataSetTechConnection_2, this.dataSetTechConnection_2.tTC_Contract, true, "where id = " + this.int_0.ToString());
            this.nullableNumericUpDown_0.ValueChanged += new EventHandler(this.nullableNumericUpDown_0_ValueChanged);
            if (this.dataSetTechConnection_2.tTC_Contract.Rows.Count == 0)
            {
                this.method_2();
            }
            base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Doc, true, "where idParent = " + this.int_0.ToString() + " and typeDoc = " + 0x463.ToString());
            if (this.dataSetTechConnection_0.tTC_Doc.Rows.Count > 0)
            {
                this.comboBox_0.SelectedValue = this.dataSetTechConnection_0.tTC_Doc.Rows[0]["id"];
            }
            base.SelectSqlData(this.dataSetTechConnection_2, this.dataSetTechConnection_2.tTC_DocOut, true, "where idDocOut = " + this.int_0.ToString());
            this.method_14(this.int_0);
            this.method_21();
            base.SelectSqlData(this.dataSetTechConnection_2.tTC_PaymentShedule, true, " where idDoc = " + this.int_0.ToString() + " order by DateShedule", false);
        }
        if (this.int_2 != -1)
        {
            this.comboBox_0.SelectedValue = this.int_2;
        }
        this.bool_0 = false;
    }

    internal int method_0()
    {
        return this.int_0;
    }

    private void method_1()
    {
        this.Text = (this.int_0 == -1) ? "Новый договор" : "Редактирование договор";
        this.nullableDateTimePicker_0.set_Value(DateTime.Now.Date);
        this.nullableDateTimePicker_1.set_Value(DateTime.Now.Date);
        this.nullableDateTimePicker_3.set_Value(DateTime.Now.Date);
        this.nullableDateTimePicker_2.set_Value(DateTime.Now.Date);
    }

    private string method_10()
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

    private void method_11(object sender, FileSystemEventArgs e)
    {
        Class31 class2 = new Class31 {
            fileSystemEventArgs_0 = e
        };
        class2.ienumerable_0 = this.dictionary_0.Where<KeyValuePair<string, FileWatcherArgsAddl>>(new Func<KeyValuePair<string, FileWatcherArgsAddl>, bool>(class2.method_0));
        if (class2.ienumerable_0.Count<KeyValuePair<string, FileWatcherArgsAddl>>() > 0)
        {
            FileBinary binary = new FileBinary(class2.fileSystemEventArgs_0.FullPath);
            EnumerableRowCollection<DataSetTechConnection.Class252> source = this.dataSetTechConnection_2.tTC_DocFile.Where<DataSetTechConnection.Class252>(new Func<DataSetTechConnection.Class252, bool>(class2.method_1));
            if (source.Count<DataSetTechConnection.Class252>() == 0)
            {
                DataSetTechConnection.Class252 row = this.dataSetTechConnection_2.tTC_DocFile.method_5();
                row.idDoc = this.int_0;
                row.FileName = class2.ienumerable_0.First<KeyValuePair<string, FileWatcherArgsAddl>>().Value.get_OriginalName();
                row.File = binary.get_ByteArray();
                row.dateChange = binary.get_LastChanged();
                row.idTemplate = class2.ienumerable_0.First<KeyValuePair<string, FileWatcherArgsAddl>>().Value.get_IdTemplate().Value;
                this.dataSetTechConnection_2.tTC_DocFile.Rows.Add(row);
            }
            else
            {
                source.First<DataSetTechConnection.Class252>().File = binary.get_ByteArray();
                source.First<DataSetTechConnection.Class252>().dateChange = binary.get_LastChanged();
                source.First<DataSetTechConnection.Class252>().EndEdit();
                this.bool_0 = true;
            }
        }
        this.method_12();
    }

    private void method_12()
    {
        if (base.InvokeRequired)
        {
            base.Invoke(new Action(this.method_26));
        }
        else
        {
            this.bindingSource_1.ResetBindings(false);
        }
    }

    private void method_13(bool bool_1 = false)
    {
        if (this.bindingSource_1.Current != null)
        {
            byte[] file;
            DataSetTechConnection.Class252 row = (DataSetTechConnection.Class252) ((DataRowView) this.bindingSource_1.Current).Row;
            string fileName = row.FileName;
            string str2 = this.method_10();
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

    private void method_14(int int_5)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(this.get_SqlSettings().GetConnectionString()))
            {
                connection.Open();
                SqlDataReader reader = new SqlCommand("SELECT id, idDoc, FileName, dateChange, idTemplate FROM tTC_DocFile WHERE idDoc = " + int_5.ToString(), connection).ExecuteReader();
                while (reader.Read())
                {
                    DataSetTechConnection.Class252 row = this.dataSetTechConnection_2.tTC_DocFile.method_5();
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
                    this.dataSetTechConnection_2.tTC_DocFile.Rows.Add(row);
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

    private bool method_15()
    {
        foreach (DataRow row in this.dataSetTechConnection_2.tTC_DocFile)
        {
            if (((row.RowState != DataRowState.Deleted) && (row.RowState != DataRowState.Detached)) && (Convert.ToInt32(row["idDoc"]) != this.int_0))
            {
                row["idDoc"] = this.int_0;
                row.EndEdit();
            }
        }
        if ((base.InsertSqlData(this.dataSetTechConnection_2, this.dataSetTechConnection_2.tTC_DocFile) && base.UpdateSqlDataOnlyChange(this.dataSetTechConnection_2.tTC_DocFile)) && base.DeleteSqlData(this.dataSetTechConnection_2, this.dataSetTechConnection_2.tTC_DocFile))
        {
            this.dataSetTechConnection_2.tTC_DocFile.AcceptChanges();
            return true;
        }
        return false;
    }

    private void method_16(object sender, EventArgs e)
    {
        string str;
        byte[] buffer;
        string str3;
        int tag = (int) ((ToolStripMenuItem) sender).Tag;
        this.method_9(tag, out str, out buffer);
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
        str3 = this.method_10();
        string str4 = FileBinary.GetNewFileNameIsExists(str3, str, false);
        string str5 = this.method_7(str, new int?(tag), buffer);
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
            else if (!this.method_17(str3 + @"\" + binary.get_Name()))
            {
                Process.Start(str3 + @"\" + binary.get_Name());
            }
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

    private bool method_17(string string_2)
    {
        bool flag;
        try
        {
            DataRow[] rowArray;
            DataTable table2;
            Application application1 = new Application();
            Documents documents = application1.get_Documents();
            documents.Open(string_2);
            application1.set_Visible(true);
            Bookmarks bookmarks = documents.get_Item(1).get_Range().get_Bookmarks();
            if (bookmarks.Exists("NumDoc"))
            {
                bookmarks.get_Item("NumDoc").get_Range().set_Text(this.textBox_0.Text);
            }
            if ((bookmarks.Exists("DateDoc") && (this.nullableDateTimePicker_0.get_Value() != null)) && (this.nullableDateTimePicker_0.get_Value() != DBNull.Value))
            {
                bookmarks.get_Item("DateDoc").get_Range().set_Text(Convert.ToDateTime(this.nullableDateTimePicker_0.get_Value()).ToString("dd MMMM yyyy") + " г.");
            }
            if (this.comboBox_1.SelectedValue != null)
            {
                rowArray = this.dataTable_0.Select("id = " + this.comboBox_1.SelectedValue.ToString());
            }
            else
            {
                rowArray = null;
            }
            if ((bookmarks.Exists("Face") && (rowArray != null)) && (rowArray.Length != 0))
            {
                bookmarks.get_Item("Face").get_Range().set_Text(rowArray[0]["Face"].ToString());
            }
            if ((bookmarks.Exists("SetDir_R") && (rowArray != null)) && (rowArray.Length != 0))
            {
                string[] textArray1 = new string[] { rowArray[0]["F_R"].ToString(), " ", rowArray[0]["I_R"].ToString(), " ", rowArray[0]["o_R"].ToString() };
                bookmarks.get_Item("SetDir_R").get_Range().set_Text(string.Concat(textArray1));
            }
            if ((bookmarks.Exists("SetDir_I1") && (rowArray != null)) && (rowArray.Length != 0))
            {
                string[] textArray2 = new string[] { rowArray[0]["F_I"].ToString(), " ", rowArray[0]["I_I"].ToString(), " ", rowArray[0]["o_I"].ToString() };
                bookmarks.get_Item("SetDir_I1").get_Range().set_Text(string.Concat(textArray2));
            }
            if ((bookmarks.Exists("SetDirUse") && (rowArray != null)) && (rowArray.Length != 0))
            {
                bookmarks.get_Item("SetDirUse").get_Range().set_Text(rowArray[0]["use"].ToString());
            }
            DataSetTechConnection.tAbnDataTable table = new DataSetTechConnection.tAbnDataTable();
            base.SelectSqlData(table, true, " where id  = " + this.int_3.ToString(), false);
            if (table.Rows.Count <= 0)
            {
                goto Label_05C3;
            }
            int num = Convert.ToInt32(table.Rows[0]["typeAbn"]);
            string str = table.Rows[0]["name"].ToString();
            switch (num)
            {
                case 0xce:
                case 0xfd:
                case 0x40d:
                    str = "Гражданин(ка) РФ " + str;
                    break;
            }
            if (bookmarks.Exists("AbnName"))
            {
                bookmarks.get_Item("AbnName").get_Range().set_Text(str);
            }
            if (bookmarks.Exists("AbnNameEnd"))
            {
                bookmarks.get_Item("AbnNameEnd").get_Range().set_Text(str);
            }
            string str2 = "";
            switch (num)
            {
                case 0xce:
                case 0xfd:
                case 0x40d:
                    break;

                default:
                {
                    DataTable table4 = base.SelectSqlData("tG_AbnChief", true, " where idAbn = " + this.int_3.ToString() + " order by datechange desc");
                    if ((str.IndexOf("Индивидуальный предприниматель") < 0) && (str.ToUpper().IndexOf("ИП ") != 0))
                    {
                        string str3 = "";
                        string str4 = "";
                        if (table4.Rows.Count > 0)
                        {
                            str3 = table4.Rows[0]["r_post"].ToString();
                            string[] textArray3 = new string[] { table4.Rows[0]["r_f"].ToString(), " ", table4.Rows[0]["r_i"].ToString(), " ", table4.Rows[0]["r_o"].ToString() };
                            str4 = string.Concat(textArray3);
                        }
                        string[] textArray4 = new string[] { ", в лице ", str3, " ", str4, " действующий на основании ___________" };
                        str2 = string.Concat(textArray4);
                    }
                    else
                    {
                        str2 = ", действующий(ая) на основании Свидетельства о государственной регисктрации физического лица в качестве индивидуального препринимателя №_______________ выданное _______________";
                    }
                    if ((table4.Rows.Count > 0) && bookmarks.Exists("AbnNameChief"))
                    {
                        string[] textArray5 = new string[] { table4.Rows[0]["i_f"].ToString(), " ", table4.Rows[0]["i_i"].ToString(), " ", table4.Rows[0]["i_o"].ToString() };
                        bookmarks.get_Item("AbnNameChief").get_Range().set_Text(string.Concat(textArray5));
                    }
                    goto Label_059F;
                }
            }
            str2 = "(паспорт ______ выдан ______________________________________)";
            if (bookmarks.Exists("AbnNameChief"))
            {
                bookmarks.get_Item("AbnNameChief").get_Range().set_Text(str);
            }
        Label_059F:
            if (bookmarks.Exists("AbnInfo"))
            {
                bookmarks.get_Item("AbnInfo").get_Range().set_Text(str2);
            }
        Label_05C3:
            table2 = base.SelectSqlData("ttc_tu", true, "where id  = " + this.int_2.ToString());
            DataTable table3 = base.SelectSqlData("vtc_tu", true, "where id  = " + this.int_2.ToString());
            if (table2.Rows.Count > 0)
            {
                if (bookmarks.Exists("VRU"))
                {
                    if (table2.Rows[0]["devicename"] != DBNull.Value)
                    {
                        bookmarks.get_Item("VRU").get_Range().set_Text(table2.Rows[0]["devicename"].ToString());
                    }
                    else if (table3.Rows[0]["Voltagelevel"] != DBNull.Value)
                    {
                        bookmarks.get_Item("VRU").get_Range().set_Text("ВРУ" + table3.Rows[0]["voltagelevel"].ToString() + "кВт");
                    }
                    else
                    {
                        bookmarks.get_Item("VRU").get_Range().set_Text("ВРУ");
                    }
                }
                if (bookmarks.Exists("PowerAdd"))
                {
                    if (table2.Rows[0]["PowerAdd"] != DBNull.Value)
                    {
                        bookmarks.get_Item("PowerAdd").get_Range().set_Text(table2.Rows[0]["PowerAdd"].ToString());
                    }
                    else
                    {
                        bookmarks.get_Item("PowerAdd").get_Range().set_Text("0");
                    }
                }
                if (bookmarks.Exists("PowerCurrent"))
                {
                    if (table2.Rows[0]["Power"] != DBNull.Value)
                    {
                        bookmarks.get_Item("PowerCurrent").get_Range().set_Text(table2.Rows[0]["Power"].ToString());
                    }
                    else
                    {
                        bookmarks.get_Item("PowerCurrent").get_Range().set_Text("0");
                    }
                }
                if (bookmarks.Exists("VoltageLevel"))
                {
                    if (table3.Rows[0]["VoltageLevel"] != DBNull.Value)
                    {
                        bookmarks.get_Item("VoltageLevel").get_Range().set_Text(table3.Rows[0]["VoltageLevel"].ToString());
                    }
                    else
                    {
                        bookmarks.get_Item("VoltageLevel").get_Range().set_Text("0");
                    }
                }
                if (bookmarks.Exists("CategoryName"))
                {
                    if (table3.Rows[0]["CategoryName"] != DBNull.Value)
                    {
                        bookmarks.get_Item("CategoryName").get_Range().set_Text(table3.Rows[0]["CategoryName"].ToString());
                    }
                    else
                    {
                        bookmarks.get_Item("CategoryName").get_Range().set_Text("0");
                    }
                }
            }
            if (bookmarks.Exists("SumContract") && this.nullableNumericUpDown_0.get_Value().HasValue)
            {
                bookmarks.get_Item("SumContract").get_Range().set_Text(this.nullableNumericUpDown_0.get_Value().ToString());
            }
            if (bookmarks.Exists("SumContractFull") && this.nullableNumericUpDown_0.get_Value().HasValue)
            {
                bookmarks.get_Item("SumContractFull").get_Range().set_Text("(" + RuDateAndMoneyConverter.CurrencyToTxt(Convert.ToDouble(this.nullableNumericUpDown_0.get_Value()), false) + ")");
            }
            if (bookmarks.Exists("SumNDS") && this.nullableNumericUpDown_1.get_Value().HasValue)
            {
                bookmarks.get_Item("SumNDS").get_Range().set_Text(this.nullableNumericUpDown_1.get_Value().ToString());
            }
            if (bookmarks.Exists("SumNDSFull") && this.nullableNumericUpDown_1.get_Value().HasValue)
            {
                bookmarks.get_Item("SumNDSFull").get_Range().set_Text("(" + RuDateAndMoneyConverter.CurrencyToTxt(Convert.ToDouble(this.nullableNumericUpDown_1.get_Value()), false) + ")");
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

    public bool method_18(string string_2, byte[] byte_0)
    {
        try
        {
            FileStream stream1 = new FileStream(string_2, FileMode.Create, FileAccess.Write);
            stream1.Write(byte_0, 0, byte_0.Length);
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

    private void method_19()
    {
        this.dataGridView_0.Rows.Clear();
        this.dataSetTechConnection_1.tTC_Doc.DefaultView.Sort = "dateDoc desc";
        foreach (DataRow row in this.dataSetTechConnection_1.tTC_Doc.DefaultView.ToTable(true, new string[0]).Rows)
        {
            DataRow[] rowArray = this.dataSetTechConnection_1.tTC_Payment.Select("id = " + row["id"].ToString());
            if (rowArray.Length != 0)
            {
                object[] values = new object[] { row["typeDoc"], row["id"], row["NumDoc"], row["datedoc"], rowArray[0]["summa"], row["comment"], rowArray[0]["iddog"] };
                this.dataGridView_0.Rows.Add(values);
            }
            else
            {
                object[] objArray2 = new object[7];
                objArray2[0] = row["typeDoc"];
                objArray2[1] = row["id"];
                objArray2[2] = row["NumDoc"];
                objArray2[3] = row["datedoc"];
                objArray2[5] = row["comment"];
                this.dataGridView_0.Rows.Add(objArray2);
            }
        }
    }

    private void method_2()
    {
        DataRow row = this.dataSetTechConnection_2.tTC_Contract.NewRow();
        row["id"] = this.int_0;
        this.dataSetTechConnection_2.tTC_Contract.Rows.Add(row);
    }

    private void method_20()
    {
        DataSetTechConnection.tR_ClassifierDataTable table = new DataSetTechConnection.tR_ClassifierDataTable();
        base.SelectSqlData(table, true, " where ParentKey = ';TechConnect;TypeDoc;Payment;' and isGroup = 0 and deleted = 0 order by name", false);
        this.dataGridViewComboBoxColumn_0.ValueMember = "id";
        this.dataGridViewComboBoxColumn_0.DisplayMember = "name";
        this.dataGridViewComboBoxColumn_0.DataSource = table;
        DataTable table2 = new DataTable("tTC_Doc");
        table2.Columns.Add(new DataColumn("id", typeof(int)));
        table2.Columns.Add(new DataColumn("numDoc", typeof(string)));
        table2.Columns.Add(new DataColumn("dateDoc", typeof(DateTime)));
        table2.Columns.Add(new DataColumn("numdate", typeof(string), "isnull(numDoc, '') + ' от ' + substring(isnull(Convert(dateDoc, 'System.String'), '          '), 1, 10)"));
        base.SelectSqlData(table2, true, " where typeDoc = " + 0x4c4.ToString() + " order by numDoc, dateDoc", false);
        this.dataGridViewComboBoxColumn_1.ValueMember = "id";
        this.dataGridViewComboBoxColumn_1.DisplayMember = "numdate";
        this.dataGridViewComboBoxColumn_1.DataSource = table2;
    }

    private void method_21()
    {
        string str = "";
        foreach (Enum4 enum2 in Enum.GetValues(typeof(Enum4)))
        {
            if (string.IsNullOrEmpty(str))
            {
                int num = (int) enum2;
                str = num.ToString();
            }
            else
            {
                str = str + "," + ((int) enum2).ToString();
            }
        }
        base.SelectSqlData(this.dataSetTechConnection_1, this.dataSetTechConnection_1.tTC_Doc, true, " where idParent = " + this.int_0.ToString() + " and typeDoc in (" + str + ")");
        base.SelectSqlData(this.dataSetTechConnection_1, this.dataSetTechConnection_1.tTC_Payment, true, " where id in (select id from ttc_doc where idParent= " + this.int_0.ToString() + " and typeDoc in (" + str + "))");
        this.method_19();
    }

    private bool method_22()
    {
        foreach (DataRow row in this.dataSetTechConnection_1.tTC_Doc)
        {
            if (row.RowState != DataRowState.Deleted)
            {
                row["idParent"] = this.int_0;
                row.EndEdit();
            }
        }
        DataTable changes = this.dataSetTechConnection_1.tTC_Doc.GetChanges(DataRowState.Added);
        if ((changes != null) && (changes.Rows.Count > 0))
        {
            foreach (DataRow row2 in changes.Rows)
            {
                int num = Convert.ToInt32(row2["id"]);
                int num2 = base.InsertSqlDataOneRow(row2);
                DataRow[] rowArray = this.dataSetTechConnection_1.tTC_Payment.Select("id =" + num.ToString());
                if (rowArray.Length != 0)
                {
                    rowArray[0]["id"] = num2;
                    rowArray[0].EndEdit();
                }
            }
        }
        if (!base.InsertSqlData(this.dataSetTechConnection_1, this.dataSetTechConnection_1.tTC_Payment))
        {
            return false;
        }
        if (!base.UpdateSqlData(this.dataSetTechConnection_1, this.dataSetTechConnection_1.tTC_Doc))
        {
            return false;
        }
        if (!base.UpdateSqlData(this.dataSetTechConnection_1, this.dataSetTechConnection_1.tTC_Payment))
        {
            return false;
        }
        if (!base.DeleteSqlData(this.dataSetTechConnection_1, this.dataSetTechConnection_1.tTC_Doc))
        {
            return false;
        }
        if (!base.DeleteSqlData(this.dataSetTechConnection_1, this.dataSetTechConnection_1.tTC_Payment))
        {
            return false;
        }
        this.method_21();
        return true;
    }

    private bool method_23()
    {
        foreach (DataRow row in this.dataSetTechConnection_2.tTC_PaymentShedule)
        {
            if (row.RowState != DataRowState.Deleted)
            {
                row["idDoc"] = this.int_0;
                row.EndEdit();
            }
        }
        if (!base.InsertSqlData(this.dataSetTechConnection_2, this.dataSetTechConnection_2.tTC_PaymentShedule))
        {
            return false;
        }
        if (!base.UpdateSqlData(this.dataSetTechConnection_2, this.dataSetTechConnection_2.tTC_PaymentShedule))
        {
            return false;
        }
        if (!base.DeleteSqlData(this.dataSetTechConnection_2, this.dataSetTechConnection_2.tTC_PaymentShedule))
        {
            return false;
        }
        base.SelectSqlData(this.dataSetTechConnection_2.tTC_PaymentShedule, true, " where idDoc = " + this.int_0.ToString() + " order by DateShedule", false);
        return true;
    }

    private void method_24()
    {
        DataTable table = base.SelectSqlData("tSettings", true, " where module = 'TCContractWord'");
        this.dataTable_0.Columns.Add("id", typeof(int));
        this.dataTable_0.Columns.Add("name", typeof(string));
        this.dataTable_0.Columns.Add("face", typeof(string));
        this.dataTable_0.Columns.Add("f_r", typeof(string));
        this.dataTable_0.Columns.Add("i_r", typeof(string));
        this.dataTable_0.Columns.Add("o_r", typeof(string));
        this.dataTable_0.Columns.Add("f_i", typeof(string));
        this.dataTable_0.Columns.Add("i_i", typeof(string));
        this.dataTable_0.Columns.Add("o_i", typeof(string));
        this.dataTable_0.Columns.Add("use", typeof(string));
        if ((table.Rows.Count > 0) && (table.Rows[0]["Settings"] != DBNull.Value))
        {
            try
            {
                XmlDocument document1 = new XmlDocument();
                document1.LoadXml(table.Rows[0]["Settings"].ToString());
                XmlNode node = document1.SelectSingleNode("document");
                if (node != null)
                {
                    foreach (XmlNode node2 in node.SelectNodes("Row"))
                    {
                        object[] values = new object[10];
                        values[0] = Convert.ToInt32(node2.Attributes["Id"].Value);
                        string[] textArray1 = new string[] { node2.Attributes["Face"].Value, " ", node2.Attributes["F_R"].Value, " ", node2.Attributes["I_R"].Value, " ", node2.Attributes["O_R"].Value };
                        values[1] = string.Concat(textArray1);
                        values[2] = node2.Attributes["Face"].Value;
                        values[3] = node2.Attributes["F_R"].Value;
                        values[4] = node2.Attributes["I_R"].Value;
                        values[5] = node2.Attributes["O_R"].Value;
                        values[6] = node2.Attributes["F_I"].Value;
                        values[7] = node2.Attributes["I_I"].Value;
                        values[8] = node2.Attributes["O_I"].Value;
                        values[9] = node2.Attributes["use"].Value;
                        this.dataTable_0.Rows.Add(values);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source);
            }
        }
        this.comboBox_1.DisplayMember = "name";
        this.comboBox_1.ValueMember = "id";
        this.comboBox_1.DataSource = this.dataTable_0;
    }

    private void method_25()
    {
        this.icontainer_0 = new Container();
        DataGridViewCellStyle style = new DataGridViewCellStyle();
        DataGridViewCellStyle style2 = new DataGridViewCellStyle();
        DataGridViewCellStyle style3 = new DataGridViewCellStyle();
        DataGridViewCellStyle style4 = new DataGridViewCellStyle();
        DataGridViewCellStyle style5 = new DataGridViewCellStyle();
        this.label_0 = new Label();
        this.textBox_0 = new TextBox();
        this.dataSetTechConnection_2 = new DataSetTechConnection();
        this.nullableDateTimePicker_0 = new NullableDateTimePicker();
        this.button_0 = new Button();
        this.button_1 = new Button();
        this.label_1 = new Label();
        this.textBox_1 = new TextBox();
        this.label_2 = new Label();
        this.tabControl_0 = new TabControl();
        this.tabPage_0 = new TabPage();
        this.comboBox_1 = new ComboBox();
        this.label_11 = new Label();
        this.nullableNumericUpDown_1 = new NullableNumericUpDown();
        this.label_10 = new Label();
        this.nullableDateTimePicker_2 = new NullableDateTimePicker();
        this.label_8 = new Label();
        this.nullableDateTimePicker_3 = new NullableDateTimePicker();
        this.label_9 = new Label();
        this.nullableDateTimePicker_1 = new NullableDateTimePicker();
        this.label_6 = new Label();
        this.nullableNumericUpDown_0 = new NullableNumericUpDown();
        this.label_7 = new Label();
        this.label_3 = new Label();
        this.textBox_2 = new TextBox();
        this.label_4 = new Label();
        this.comboBox_0 = new ComboBox();
        this.textBox_3 = new TextBox();
        this.label_5 = new Label();
        this.tabPage_1 = new TabPage();
        this.dataGridViewExcelFilter_0 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
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
        this.bindingSource_0 = new BindingSource(this.icontainer_0);
        this.tabPage_2 = new TabPage();
        this.dataGridViewExcelFilter_1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
        this.dataGridViewImageColumnNotNull_0 = new DataGridViewImageColumnNotNull();
        this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
        this.dataGridViewTextBoxColumn_18 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_19 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_20 = new DataGridViewTextBoxColumn();
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
        this.tabPage_3 = new TabPage();
        this.dataGridView_0 = new DataGridView();
        this.dataGridViewComboBoxColumn_0 = new DataGridViewComboBoxColumn();
        this.dataGridViewTextBoxColumn_21 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_22 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_23 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_24 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_25 = new DataGridViewTextBoxColumn();
        this.dataGridViewComboBoxColumn_1 = new DataGridViewComboBoxColumn();
        this.toolStrip_1 = new ToolStrip();
        this.toolStripButton_5 = new ToolStripButton();
        this.toolStripButton_6 = new ToolStripButton();
        this.toolStripButton_7 = new ToolStripButton();
        this.tabPage_4 = new TabPage();
        this.dataGridView_1 = new DataGridView();
        this.dataGridViewFilterDateTimePickerColumn_0 = new DataGridViewFilterDateTimePickerColumn();
        this.dataGridViewTextBoxColumn_26 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_27 = new DataGridViewTextBoxColumn();
        this.dataGridViewNumericColumn_0 = new DataGridViewNumericColumn();
        this.dataGridViewTextBoxColumn_28 = new DataGridViewTextBoxColumn();
        this.bindingSource_2 = new BindingSource(this.icontainer_0);
        this.toolStrip_2 = new ToolStrip();
        this.toolStripButton_8 = new ToolStripButton();
        this.toolStripButton_9 = new ToolStripButton();
        this.toolStripButton_10 = new ToolStripButton();
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
        this.dataSetTechConnection_2.BeginInit();
        this.tabControl_0.SuspendLayout();
        this.tabPage_0.SuspendLayout();
        this.nullableNumericUpDown_1.BeginInit();
        this.nullableNumericUpDown_0.BeginInit();
        this.tabPage_1.SuspendLayout();
        this.dataGridViewExcelFilter_0.BeginInit();
        ((ISupportInitialize) this.bindingSource_0).BeginInit();
        this.tabPage_2.SuspendLayout();
        this.dataGridViewExcelFilter_1.BeginInit();
        ((ISupportInitialize) this.bindingSource_1).BeginInit();
        this.toolStrip_0.SuspendLayout();
        this.tabPage_3.SuspendLayout();
        ((ISupportInitialize) this.dataGridView_0).BeginInit();
        this.toolStrip_1.SuspendLayout();
        this.tabPage_4.SuspendLayout();
        ((ISupportInitialize) this.dataGridView_1).BeginInit();
        ((ISupportInitialize) this.bindingSource_2).BeginInit();
        this.toolStrip_2.SuspendLayout();
        this.contextMenuStrip_0.SuspendLayout();
        base.SuspendLayout();
        this.label_0.AutoSize = true;
        this.label_0.Location = new Point(9, 9);
        this.label_0.Name = "label2";
        this.label_0.Size = new Size(0x7c, 13);
        this.label_0.TabIndex = 2;
        this.label_0.Text = "Номер договора на ТП";
        this.textBox_0.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_2, "tTC_Doc.numDoc", true));
        this.textBox_0.Location = new Point(12, 0x19);
        this.textBox_0.Name = "txtNumDocOut";
        this.textBox_0.Size = new Size(0xc6, 20);
        this.textBox_0.TabIndex = 3;
        this.textBox_0.TextChanged += new EventHandler(this.textBox_0_TextChanged);
        this.dataSetTechConnection_2.DataSetName = "DataSetTechConnection";
        this.dataSetTechConnection_2.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        this.nullableDateTimePicker_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.nullableDateTimePicker_0.DataBindings.Add(new Binding("Value", this.dataSetTechConnection_2, "tTC_Doc.dateDoc", true));
        this.nullableDateTimePicker_0.Location = new Point(230, 0x19);
        this.nullableDateTimePicker_0.Name = "dateTimePickerDocOut";
        this.nullableDateTimePicker_0.Size = new Size(0xe0, 20);
        this.nullableDateTimePicker_0.TabIndex = 4;
        this.nullableDateTimePicker_0.set_Value(new DateTime(0x7dd, 4, 0x1d, 14, 0x26, 3, 750));
        this.nullableDateTimePicker_0.ValueChanged += new EventHandler(this.nullableDateTimePicker_0_ValueChanged);
        this.button_0.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
        this.button_0.Location = new Point(12, 0x19e);
        this.button_0.Name = "buttonSave";
        this.button_0.Size = new Size(0x4b, 0x17);
        this.button_0.TabIndex = 11;
        this.button_0.Text = "Сохранить";
        this.button_0.UseVisualStyleBackColor = true;
        this.button_0.Click += new EventHandler(this.button_0_Click);
        this.button_1.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
        this.button_1.DialogResult = DialogResult.Cancel;
        this.button_1.Location = new Point(0x17b, 0x19e);
        this.button_1.Name = "buttonCancel";
        this.button_1.Size = new Size(0x4b, 0x17);
        this.button_1.TabIndex = 12;
        this.button_1.Text = "Закрыть";
        this.button_1.UseVisualStyleBackColor = true;
        this.button_1.Click += new EventHandler(this.button_1_Click);
        this.label_1.AutoSize = true;
        this.label_1.Location = new Point(7, 250);
        this.label_1.Name = "label6";
        this.label_1.Size = new Size(0x4d, 13);
        this.label_1.TabIndex = 9;
        this.label_1.Text = "Комментарий";
        this.textBox_1.AcceptsReturn = true;
        this.textBox_1.AcceptsTab = true;
        this.textBox_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
        this.textBox_1.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_2, "tTC_Doc.Comment", true));
        this.textBox_1.Location = new Point(10, 0x10a);
        this.textBox_1.Multiline = true;
        this.textBox_1.Name = "txtComment";
        this.textBox_1.Size = new Size(0x1b7, 0x3b);
        this.textBox_1.TabIndex = 10;
        this.textBox_1.TextChanged += new EventHandler(this.textBox_1_TextChanged);
        this.label_2.AutoSize = true;
        this.label_2.Location = new Point(0xe3, 9);
        this.label_2.Name = "label1";
        this.label_2.Size = new Size(0x74, 13);
        this.label_2.TabIndex = 0x11;
        this.label_2.Text = "Дата договора на ТП";
        this.tabControl_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
        this.tabControl_0.Controls.Add(this.tabPage_0);
        this.tabControl_0.Controls.Add(this.tabPage_1);
        this.tabControl_0.Controls.Add(this.tabPage_2);
        this.tabControl_0.Controls.Add(this.tabPage_3);
        this.tabControl_0.Controls.Add(this.tabPage_4);
        this.tabControl_0.Location = new Point(1, 0x33);
        this.tabControl_0.Name = "tabControl1";
        this.tabControl_0.SelectedIndex = 0;
        this.tabControl_0.Size = new Size(0x1cf, 0x165);
        this.tabControl_0.TabIndex = 0x12;
        this.tabPage_0.Controls.Add(this.comboBox_1);
        this.tabPage_0.Controls.Add(this.label_11);
        this.tabPage_0.Controls.Add(this.nullableNumericUpDown_1);
        this.tabPage_0.Controls.Add(this.label_10);
        this.tabPage_0.Controls.Add(this.nullableDateTimePicker_2);
        this.tabPage_0.Controls.Add(this.label_8);
        this.tabPage_0.Controls.Add(this.nullableDateTimePicker_3);
        this.tabPage_0.Controls.Add(this.label_9);
        this.tabPage_0.Controls.Add(this.nullableDateTimePicker_1);
        this.tabPage_0.Controls.Add(this.label_6);
        this.tabPage_0.Controls.Add(this.textBox_1);
        this.tabPage_0.Controls.Add(this.nullableNumericUpDown_0);
        this.tabPage_0.Controls.Add(this.label_1);
        this.tabPage_0.Controls.Add(this.label_7);
        this.tabPage_0.Controls.Add(this.label_3);
        this.tabPage_0.Controls.Add(this.textBox_2);
        this.tabPage_0.Controls.Add(this.label_4);
        this.tabPage_0.Controls.Add(this.comboBox_0);
        this.tabPage_0.Controls.Add(this.textBox_3);
        this.tabPage_0.Controls.Add(this.label_5);
        this.tabPage_0.Location = new Point(4, 0x16);
        this.tabPage_0.Name = "tabPageGeneral";
        this.tabPage_0.Padding = new Padding(3);
        this.tabPage_0.Size = new Size(0x1c7, 0x14b);
        this.tabPage_0.TabIndex = 0;
        this.tabPage_0.Text = "Общие";
        this.tabPage_0.UseVisualStyleBackColor = true;
        this.comboBox_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.comboBox_1.DataBindings.Add(new Binding("SelectedValue", this.dataSetTechConnection_2, "tTC_Contract.idSettingWord", true));
        this.comboBox_1.FormattingEnabled = true;
        this.comboBox_1.Location = new Point(10, 0xda);
        this.comboBox_1.Name = "cmbSetFace";
        this.comboBox_1.Size = new Size(0x1b7, 0x15);
        this.comboBox_1.TabIndex = 0x17;
        this.label_11.AutoSize = true;
        this.label_11.Location = new Point(7, 0xca);
        this.label_11.Name = "label11";
        this.label_11.Size = new Size(0x93, 13);
        this.label_11.TabIndex = 0x16;
        this.label_11.Text = "Сетевая оргнизация в лице";
        this.nullableNumericUpDown_1.Anchor = AnchorStyles.Right | AnchorStyles.Top;
        this.nullableNumericUpDown_1.DataBindings.Add(new Binding("Value", this.dataSetTechConnection_2, "tTC_Contract.SumNDS", true));
        this.nullableNumericUpDown_1.DecimalPlaces = 2;
        this.nullableNumericUpDown_1.Location = new Point(0x163, 90);
        int[] bits = new int[4];
        bits[0] = 0x3b9ac9ff;
        this.nullableNumericUpDown_1.Maximum = new decimal(bits);
        this.nullableNumericUpDown_1.Name = "numSumNDS";
        this.nullableNumericUpDown_1.Size = new Size(0x5e, 20);
        this.nullableNumericUpDown_1.TabIndex = 0x15;
        decimal? nullable = null;
        this.nullableNumericUpDown_1.set_Value(nullable);
        this.label_10.Anchor = AnchorStyles.Right | AnchorStyles.Top;
        this.label_10.AutoSize = true;
        this.label_10.Location = new Point(0xff, 0x61);
        this.label_10.Name = "label10";
        this.label_10.Size = new Size(0x5e, 13);
        this.label_10.TabIndex = 20;
        this.label_10.Text = "в том числе НДС";
        this.nullableDateTimePicker_2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.nullableDateTimePicker_2.DataBindings.Add(new Binding("Value", this.dataSetTechConnection_2, "tTC_Contract.DateImplFact", true));
        this.nullableDateTimePicker_2.Location = new Point(0xdf, 0xa8);
        this.nullableDateTimePicker_2.Name = "dtpImplFact";
        this.nullableDateTimePicker_2.Size = new Size(0xe2, 20);
        this.nullableDateTimePicker_2.TabIndex = 0x13;
        this.nullableDateTimePicker_2.set_Value(new DateTime(0x7de, 2, 10, 13, 0x3b, 0x36, 0x80));
        this.label_8.AutoSize = true;
        this.label_8.Location = new Point(7, 0xae);
        this.label_8.Name = "label8";
        this.label_8.Size = new Size(210, 13);
        this.label_8.TabIndex = 0x12;
        this.label_8.Text = "Дата фактического выполнения мер-ий";
        this.nullableDateTimePicker_3.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.nullableDateTimePicker_3.DataBindings.Add(new Binding("Value", this.dataSetTechConnection_2, "tTC_Contract.DateBegFact", true));
        this.nullableDateTimePicker_3.Location = new Point(0xdf, 0x8e);
        this.nullableDateTimePicker_3.Name = "dtpBegFact";
        this.nullableDateTimePicker_3.Size = new Size(0xe2, 20);
        this.nullableDateTimePicker_3.TabIndex = 0x11;
        this.nullableDateTimePicker_3.set_Value(new DateTime(0x7de, 2, 10, 13, 0x3b, 0x36, 0x80));
        this.label_9.AutoSize = true;
        this.label_9.Location = new Point(7, 0x94);
        this.label_9.Name = "label7";
        this.label_9.Size = new Size(0xb1, 13);
        this.label_9.TabIndex = 0x10;
        this.label_9.Text = "Дата начала действия (возврата)";
        this.nullableDateTimePicker_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.nullableDateTimePicker_1.DataBindings.Add(new Binding("Value", this.dataSetTechConnection_2, "tTC_Contract.DatePerfomance", true));
        this.nullableDateTimePicker_1.Location = new Point(0x6b, 0x74);
        this.nullableDateTimePicker_1.Name = "nullableDateTimePicker1";
        this.nullableDateTimePicker_1.Size = new Size(0x156, 20);
        this.nullableDateTimePicker_1.TabIndex = 15;
        this.nullableDateTimePicker_1.set_Value(new DateTime(0x7de, 2, 10, 13, 0x3b, 0x36, 0x80));
        this.nullableDateTimePicker_1.ValueChanged += new EventHandler(this.nullableDateTimePicker_1_ValueChanged);
        this.label_6.AutoSize = true;
        this.label_6.Location = new Point(7, 0x7a);
        this.label_6.Name = "label4";
        this.label_6.Size = new Size(0x5f, 13);
        this.label_6.TabIndex = 14;
        this.label_6.Text = "Срок исполнения";
        this.nullableNumericUpDown_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.nullableNumericUpDown_0.DataBindings.Add(new Binding("Value", this.dataSetTechConnection_2, "tTC_Contract.SumContract", true));
        this.nullableNumericUpDown_0.DecimalPlaces = 2;
        this.nullableNumericUpDown_0.Location = new Point(0x6b, 90);
        int[] numArray2 = new int[4];
        numArray2[0] = 0x3b9ac9ff;
        this.nullableNumericUpDown_0.Maximum = new decimal(numArray2);
        this.nullableNumericUpDown_0.Name = "numSumContract";
        this.nullableNumericUpDown_0.Size = new Size(0x8e, 20);
        this.nullableNumericUpDown_0.TabIndex = 13;
        this.nullableNumericUpDown_0.set_Value(null);
        this.nullableNumericUpDown_0.ValueChanged += new EventHandler(this.nullableNumericUpDown_0_ValueChanged);
        this.label_7.AutoSize = true;
        this.label_7.Location = new Point(7, 0x61);
        this.label_7.Name = "label3";
        this.label_7.Size = new Size(0x53, 13);
        this.label_7.TabIndex = 12;
        this.label_7.Text = "Цена договора";
        this.label_3.AutoSize = true;
        this.label_3.Location = new Point(7, 0x3b);
        this.label_3.Name = "label5";
        this.label_3.Size = new Size(0x2d, 13);
        this.label_3.TabIndex = 10;
        this.label_3.Text = "Объект";
        this.textBox_2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.textBox_2.BackColor = SystemColors.Window;
        this.textBox_2.Location = new Point(0x6b, 0x38);
        this.textBox_2.Name = "txtAbnObj";
        this.textBox_2.ReadOnly = true;
        this.textBox_2.Size = new Size(0x156, 20);
        this.textBox_2.TabIndex = 11;
        this.label_4.AutoSize = true;
        this.label_4.Location = new Point(7, 9);
        this.label_4.Name = "labelNumDateIn";
        this.label_4.Size = new Size(0x5e, 13);
        this.label_4.TabIndex = 6;
        this.label_4.Text = "Номер и дата ТУ";
        this.comboBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.comboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        this.comboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
        this.comboBox_0.FormattingEnabled = true;
        this.comboBox_0.Location = new Point(0x6b, 6);
        this.comboBox_0.Name = "cmbNumDateIn";
        this.comboBox_0.Size = new Size(0x156, 0x15);
        this.comboBox_0.TabIndex = 7;
        this.comboBox_0.SelectedIndexChanged += new EventHandler(this.comboBox_0_SelectedIndexChanged);
        this.comboBox_0.SelectedValueChanged += new EventHandler(this.comboBox_0_SelectedValueChanged);
        this.textBox_3.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.textBox_3.BackColor = SystemColors.Window;
        this.textBox_3.Location = new Point(0x6b, 0x20);
        this.textBox_3.Name = "txtAbn";
        this.textBox_3.ReadOnly = true;
        this.textBox_3.Size = new Size(0x156, 20);
        this.textBox_3.TabIndex = 9;
        this.label_5.AutoSize = true;
        this.label_5.Location = new Point(7, 0x23);
        this.label_5.Name = "label9";
        this.label_5.Size = new Size(0x31, 13);
        this.label_5.TabIndex = 8;
        this.label_5.Text = "Абонент";
        this.tabPage_1.Controls.Add(this.dataGridViewExcelFilter_0);
        this.tabPage_1.Location = new Point(4, 0x16);
        this.tabPage_1.Name = "tabPageHistoryRequest";
        this.tabPage_1.Padding = new Padding(3);
        this.tabPage_1.Size = new Size(0x1c7, 0x14b);
        this.tabPage_1.TabIndex = 1;
        this.tabPage_1.Text = "История заявок";
        this.tabPage_1.UseVisualStyleBackColor = true;
        this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
        this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
        this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
        this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { 
            this.dataGridViewTextBoxColumn_0, this.dataGridViewTextBoxColumn_1, this.dataGridViewTextBoxColumn_2, this.dataGridViewTextBoxColumn_3, this.dataGridViewTextBoxColumn_4, this.dataGridViewTextBoxColumn_5, this.dataGridViewTextBoxColumn_6, this.dataGridViewTextBoxColumn_7, this.dataGridViewTextBoxColumn_8, this.dataGridViewTextBoxColumn_9, this.dataGridViewTextBoxColumn_10, this.dataGridViewTextBoxColumn_11, this.dataGridViewTextBoxColumn_12, this.dataGridViewTextBoxColumn_13, this.dataGridViewTextBoxColumn_14, this.dataGridViewTextBoxColumn_15,
            this.dataGridViewTextBoxColumn_16, this.dataGridViewTextBoxColumn_17
        };
        this.dataGridViewExcelFilter_0.Columns.AddRange(dataGridViewColumns);
        this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
        this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
        this.dataGridViewExcelFilter_0.Location = new Point(3, 3);
        this.dataGridViewExcelFilter_0.MultiSelect = false;
        this.dataGridViewExcelFilter_0.Name = "dgvRequestHistory";
        this.dataGridViewExcelFilter_0.ReadOnly = true;
        this.dataGridViewExcelFilter_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        this.dataGridViewExcelFilter_0.Size = new Size(0x1c1, 0x145);
        this.dataGridViewExcelFilter_0.TabIndex = 6;
        this.dataGridViewExcelFilter_0.VirtualMode = true;
        this.dataGridViewExcelFilter_0.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridViewExcelFilter_0_CellFormatting);
        this.dataGridViewExcelFilter_0.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dataGridViewExcelFilter_0_RowPostPaint);
        this.dataGridViewTextBoxColumn_0.DataPropertyName = "numDateIn";
        style.WrapMode = DataGridViewTriState.True;
        this.dataGridViewTextBoxColumn_0.DefaultCellStyle = style;
        this.dataGridViewTextBoxColumn_0.HeaderText = "№, дата вход.";
        this.dataGridViewTextBoxColumn_0.Name = "numDateInDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_0.ReadOnly = true;
        this.dataGridViewTextBoxColumn_0.Width = 80;
        this.dataGridViewTextBoxColumn_1.DataPropertyName = "numDoc";
        this.dataGridViewTextBoxColumn_1.HeaderText = "numDoc";
        this.dataGridViewTextBoxColumn_1.Name = "numDocDataGridViewTextBoxColumn1";
        this.dataGridViewTextBoxColumn_1.ReadOnly = true;
        this.dataGridViewTextBoxColumn_1.Visible = false;
        this.dataGridViewTextBoxColumn_2.DataPropertyName = "id";
        this.dataGridViewTextBoxColumn_2.HeaderText = "id";
        this.dataGridViewTextBoxColumn_2.Name = "idRequestHistoryDgvColumn";
        this.dataGridViewTextBoxColumn_2.ReadOnly = true;
        this.dataGridViewTextBoxColumn_2.Visible = false;
        this.dataGridViewTextBoxColumn_3.DataPropertyName = "dateDoc";
        this.dataGridViewTextBoxColumn_3.HeaderText = "Дата получения";
        this.dataGridViewTextBoxColumn_3.Name = "dateDocDataGridViewTextBoxColumn1";
        this.dataGridViewTextBoxColumn_3.ReadOnly = true;
        this.dataGridViewTextBoxColumn_3.Width = 80;
        this.dataGridViewTextBoxColumn_4.DataPropertyName = "TypeDoc";
        this.dataGridViewTextBoxColumn_4.HeaderText = "TypeDoc";
        this.dataGridViewTextBoxColumn_4.Name = "typeDocRequestHistoryDgvColumn";
        this.dataGridViewTextBoxColumn_4.ReadOnly = true;
        this.dataGridViewTextBoxColumn_4.Visible = false;
        this.dataGridViewTextBoxColumn_5.DataPropertyName = "numIn";
        this.dataGridViewTextBoxColumn_5.HeaderText = "numIn";
        this.dataGridViewTextBoxColumn_5.Name = "numInDataGridViewTextBoxColumn1";
        this.dataGridViewTextBoxColumn_5.ReadOnly = true;
        this.dataGridViewTextBoxColumn_5.Visible = false;
        this.dataGridViewTextBoxColumn_6.DataPropertyName = "dateIn";
        this.dataGridViewTextBoxColumn_6.HeaderText = "dateIn";
        this.dataGridViewTextBoxColumn_6.Name = "dateInDataGridViewTextBoxColumn1";
        this.dataGridViewTextBoxColumn_6.ReadOnly = true;
        this.dataGridViewTextBoxColumn_6.Visible = false;
        this.dataGridViewTextBoxColumn_7.DataPropertyName = "idAbn";
        this.dataGridViewTextBoxColumn_7.HeaderText = "idAbn";
        this.dataGridViewTextBoxColumn_7.Name = "idAbnDataGridViewTextBoxColumn1";
        this.dataGridViewTextBoxColumn_7.ReadOnly = true;
        this.dataGridViewTextBoxColumn_7.Visible = false;
        this.dataGridViewTextBoxColumn_8.DataPropertyName = "idAbnObj";
        this.dataGridViewTextBoxColumn_8.HeaderText = "idAbnObj";
        this.dataGridViewTextBoxColumn_8.Name = "idAbnObjDataGridViewTextBoxColumn1";
        this.dataGridViewTextBoxColumn_8.ReadOnly = true;
        this.dataGridViewTextBoxColumn_8.Visible = false;
        this.dataGridViewTextBoxColumn_9.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.dataGridViewTextBoxColumn_9.DataPropertyName = "body";
        style2.WrapMode = DataGridViewTriState.True;
        this.dataGridViewTextBoxColumn_9.DefaultCellStyle = style2;
        this.dataGridViewTextBoxColumn_9.HeaderText = "Тело письма";
        this.dataGridViewTextBoxColumn_9.Name = "bodyDataGridViewTextBoxColumn1";
        this.dataGridViewTextBoxColumn_9.ReadOnly = true;
        this.dataGridViewTextBoxColumn_10.DataPropertyName = "PowerCurrent";
        this.dataGridViewTextBoxColumn_10.HeaderText = "Текущая мощность";
        this.dataGridViewTextBoxColumn_10.Name = "powerCurrentDgvColumn";
        this.dataGridViewTextBoxColumn_10.ReadOnly = true;
        this.dataGridViewTextBoxColumn_10.Width = 70;
        this.dataGridViewTextBoxColumn_11.DataPropertyName = "PowerAdd";
        this.dataGridViewTextBoxColumn_11.HeaderText = "Доп мощность";
        this.dataGridViewTextBoxColumn_11.Name = "PowerAddDgvColumn";
        this.dataGridViewTextBoxColumn_11.ReadOnly = true;
        this.dataGridViewTextBoxColumn_11.Width = 70;
        this.dataGridViewTextBoxColumn_12.DataPropertyName = "Power";
        this.dataGridViewTextBoxColumn_12.HeaderText = "Суммарная мощность";
        this.dataGridViewTextBoxColumn_12.Name = "powerDataGridViewTextBoxColumn1";
        this.dataGridViewTextBoxColumn_12.ReadOnly = true;
        this.dataGridViewTextBoxColumn_12.Width = 70;
        this.dataGridViewTextBoxColumn_13.DataPropertyName = "VoltageName";
        this.dataGridViewTextBoxColumn_13.HeaderText = "Напряжение";
        this.dataGridViewTextBoxColumn_13.Name = "voltageNameDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_13.ReadOnly = true;
        this.dataGridViewTextBoxColumn_13.Width = 70;
        this.dataGridViewTextBoxColumn_14.DataPropertyName = "Comment";
        this.dataGridViewTextBoxColumn_14.HeaderText = "Комментарий";
        this.dataGridViewTextBoxColumn_14.Name = "commentDataGridViewTextBoxColumn1";
        this.dataGridViewTextBoxColumn_14.ReadOnly = true;
        this.dataGridViewTextBoxColumn_14.Width = 70;
        this.dataGridViewTextBoxColumn_15.DataPropertyName = "VoltageLevel";
        this.dataGridViewTextBoxColumn_15.HeaderText = "VoltageLevel";
        this.dataGridViewTextBoxColumn_15.Name = "voltageLevelDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_15.ReadOnly = true;
        this.dataGridViewTextBoxColumn_15.Visible = false;
        this.dataGridViewTextBoxColumn_16.DataPropertyName = "VoltageValue";
        this.dataGridViewTextBoxColumn_16.HeaderText = "VoltageValue";
        this.dataGridViewTextBoxColumn_16.Name = "voltageValueDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_16.ReadOnly = true;
        this.dataGridViewTextBoxColumn_16.Visible = false;
        this.dataGridViewTextBoxColumn_17.DataPropertyName = "IdParent";
        this.dataGridViewTextBoxColumn_17.HeaderText = "IdParent";
        this.dataGridViewTextBoxColumn_17.Name = "idParentDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_17.ReadOnly = true;
        this.dataGridViewTextBoxColumn_17.Visible = false;
        this.bindingSource_0.DataMember = "vTC_RequestHistory";
        this.bindingSource_0.DataSource = this.dataSetTechConnection_2;
        this.tabPage_2.Controls.Add(this.dataGridViewExcelFilter_1);
        this.tabPage_2.Controls.Add(this.toolStrip_0);
        this.tabPage_2.Location = new Point(4, 0x16);
        this.tabPage_2.Name = "tabPageFiles";
        this.tabPage_2.Padding = new Padding(3);
        this.tabPage_2.Size = new Size(0x1c7, 0x14b);
        this.tabPage_2.TabIndex = 2;
        this.tabPage_2.Text = "Файлы";
        this.tabPage_2.UseVisualStyleBackColor = true;
        this.dataGridViewExcelFilter_1.AllowUserToAddRows = false;
        this.dataGridViewExcelFilter_1.AllowUserToDeleteRows = false;
        this.dataGridViewExcelFilter_1.AllowUserToResizeColumns = false;
        this.dataGridViewExcelFilter_1.AllowUserToResizeRows = false;
        this.dataGridViewExcelFilter_1.AutoGenerateColumns = false;
        this.dataGridViewExcelFilter_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DataGridViewColumn[] columnArray2 = new DataGridViewColumn[] { this.dataGridViewImageColumnNotNull_0, this.dataGridViewFilterTextBoxColumn_0, this.dataGridViewTextBoxColumn_18, this.dataGridViewTextBoxColumn_19, this.dataGridViewTextBoxColumn_20 };
        this.dataGridViewExcelFilter_1.Columns.AddRange(columnArray2);
        this.dataGridViewExcelFilter_1.DataSource = this.bindingSource_1;
        this.dataGridViewExcelFilter_1.Dock = DockStyle.Fill;
        this.dataGridViewExcelFilter_1.EditMode = DataGridViewEditMode.EditProgrammatically;
        this.dataGridViewExcelFilter_1.Location = new Point(3, 0x1c);
        this.dataGridViewExcelFilter_1.Name = "dgvFile";
        this.dataGridViewExcelFilter_1.ReadOnly = true;
        this.dataGridViewExcelFilter_1.RowHeadersVisible = false;
        this.dataGridViewExcelFilter_1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        this.dataGridViewExcelFilter_1.Size = new Size(0x1c1, 300);
        this.dataGridViewExcelFilter_1.TabIndex = 8;
        this.dataGridViewExcelFilter_1.VirtualMode = true;
        this.dataGridViewExcelFilter_1.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_1_CellDoubleClick);
        this.dataGridViewExcelFilter_1.CellEndEdit += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_1_CellEndEdit);
        this.dataGridViewExcelFilter_1.CellMouseClick += new DataGridViewCellMouseEventHandler(this.dataGridViewExcelFilter_1_CellMouseClick);
        this.dataGridViewExcelFilter_1.CellValidating += new DataGridViewCellValidatingEventHandler(this.dataGridViewExcelFilter_1_CellValidating);
        this.dataGridViewExcelFilter_1.CellValueNeeded += new DataGridViewCellValueEventHandler(this.dataGridViewExcelFilter_1_CellValueNeeded);
        style3.NullValue = null;
        this.dataGridViewImageColumnNotNull_0.DefaultCellStyle = style3;
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
        this.dataGridViewTextBoxColumn_18.DataPropertyName = "idDoc";
        this.dataGridViewTextBoxColumn_18.HeaderText = "idDoc";
        this.dataGridViewTextBoxColumn_18.Name = "idDoc";
        this.dataGridViewTextBoxColumn_18.ReadOnly = true;
        this.dataGridViewTextBoxColumn_18.Visible = false;
        this.dataGridViewTextBoxColumn_19.DataPropertyName = "dateChange";
        this.dataGridViewTextBoxColumn_19.HeaderText = "dateChange";
        this.dataGridViewTextBoxColumn_19.Name = "dateChangeDgvColumn";
        this.dataGridViewTextBoxColumn_19.ReadOnly = true;
        this.dataGridViewTextBoxColumn_19.Visible = false;
        this.dataGridViewTextBoxColumn_20.DataPropertyName = "idTemplate";
        this.dataGridViewTextBoxColumn_20.HeaderText = "idTemplate";
        this.dataGridViewTextBoxColumn_20.Name = "idTemplateDgvColumn";
        this.dataGridViewTextBoxColumn_20.ReadOnly = true;
        this.dataGridViewTextBoxColumn_20.Visible = false;
        this.bindingSource_1.DataMember = "tTC_DocFile";
        this.bindingSource_1.DataSource = this.dataSetTechConnection_2;
        ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripDropDownButton_0, this.toolStripButton_0, this.toolStripButton_1, this.toolStripButton_2, this.toolStripSeparator_1, this.toolStripButton_3, this.toolStripButton_4 };
        this.toolStrip_0.Items.AddRange(toolStripItems);
        this.toolStrip_0.Location = new Point(3, 3);
        this.toolStrip_0.Name = "toolStripFile";
        this.toolStrip_0.Size = new Size(0x1c1, 0x19);
        this.toolStrip_0.TabIndex = 2;
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
        this.tabPage_3.Controls.Add(this.dataGridView_0);
        this.tabPage_3.Controls.Add(this.toolStrip_1);
        this.tabPage_3.Location = new Point(4, 0x16);
        this.tabPage_3.Name = "tabPagePayment";
        this.tabPage_3.Padding = new Padding(3);
        this.tabPage_3.Size = new Size(0x1c7, 0x14b);
        this.tabPage_3.TabIndex = 3;
        this.tabPage_3.Text = "Платежи";
        this.tabPage_3.UseVisualStyleBackColor = true;
        this.dataGridView_0.AllowUserToAddRows = false;
        this.dataGridView_0.AllowUserToDeleteRows = false;
        this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DataGridViewColumn[] columnArray3 = new DataGridViewColumn[] { this.dataGridViewComboBoxColumn_0, this.dataGridViewTextBoxColumn_21, this.dataGridViewTextBoxColumn_22, this.dataGridViewTextBoxColumn_23, this.dataGridViewTextBoxColumn_24, this.dataGridViewTextBoxColumn_25, this.dataGridViewComboBoxColumn_1 };
        this.dataGridView_0.Columns.AddRange(columnArray3);
        this.dataGridView_0.Dock = DockStyle.Fill;
        this.dataGridView_0.Location = new Point(3, 0x1c);
        this.dataGridView_0.Name = "dgvPayment";
        this.dataGridView_0.ReadOnly = true;
        this.dataGridView_0.Size = new Size(0x1c1, 300);
        this.dataGridView_0.TabIndex = 1;
        this.dataGridView_0.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView_0_CellDoubleClick);
        this.dataGridView_0.DataError += new DataGridViewDataErrorEventHandler(this.dataGridView_0_DataError);
        this.dataGridViewComboBoxColumn_0.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
        this.dataGridViewComboBoxColumn_0.HeaderText = "Тип документа";
        this.dataGridViewComboBoxColumn_0.Name = "typeDocDgvColumn";
        this.dataGridViewComboBoxColumn_0.ReadOnly = true;
        this.dataGridViewTextBoxColumn_21.HeaderText = "id";
        this.dataGridViewTextBoxColumn_21.Name = "idDocDgvColumn";
        this.dataGridViewTextBoxColumn_21.ReadOnly = true;
        this.dataGridViewTextBoxColumn_21.Visible = false;
        this.dataGridViewTextBoxColumn_22.HeaderText = "Номер";
        this.dataGridViewTextBoxColumn_22.Name = "numDgvColumn";
        this.dataGridViewTextBoxColumn_22.ReadOnly = true;
        this.dataGridViewTextBoxColumn_23.HeaderText = "Дата";
        this.dataGridViewTextBoxColumn_23.Name = "dateDgvColumn";
        this.dataGridViewTextBoxColumn_23.ReadOnly = true;
        this.dataGridViewTextBoxColumn_24.HeaderText = "Сумма";
        this.dataGridViewTextBoxColumn_24.Name = "sumDgvColumn";
        this.dataGridViewTextBoxColumn_24.ReadOnly = true;
        this.dataGridViewTextBoxColumn_25.HeaderText = "Комментарий";
        this.dataGridViewTextBoxColumn_25.Name = "commentDgvColumn";
        this.dataGridViewTextBoxColumn_25.ReadOnly = true;
        this.dataGridViewComboBoxColumn_1.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
        this.dataGridViewComboBoxColumn_1.HeaderText = "Договор";
        this.dataGridViewComboBoxColumn_1.Name = "dogDgvColumn";
        this.dataGridViewComboBoxColumn_1.ReadOnly = true;
        ToolStripItem[] itemArray3 = new ToolStripItem[] { this.toolStripButton_5, this.toolStripButton_6, this.toolStripButton_7 };
        this.toolStrip_1.Items.AddRange(itemArray3);
        this.toolStrip_1.Location = new Point(3, 3);
        this.toolStrip_1.Name = "toolStripPayment";
        this.toolStrip_1.Size = new Size(0x1c1, 0x19);
        this.toolStrip_1.TabIndex = 0;
        this.toolStrip_1.Text = "toolStrip1";
        this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_5.Image = Resources.ElementAdd;
        this.toolStripButton_5.ImageTransparentColor = Color.Magenta;
        this.toolStripButton_5.Name = "toolBtnAddPayment";
        this.toolStripButton_5.Size = new Size(0x17, 0x16);
        this.toolStripButton_5.Text = "Добавить платеж";
        this.toolStripButton_5.Click += new EventHandler(this.toolStripButton_5_Click);
        this.toolStripButton_6.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_6.Image = Resources.ElementEdit;
        this.toolStripButton_6.ImageTransparentColor = Color.Magenta;
        this.toolStripButton_6.Name = "toolBtnEditPayment";
        this.toolStripButton_6.Size = new Size(0x17, 0x16);
        this.toolStripButton_6.Text = "Редактировать платеж";
        this.toolStripButton_6.Click += new EventHandler(this.toolStripButton_6_Click);
        this.toolStripButton_7.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_7.Image = Resources.ElementDel;
        this.toolStripButton_7.ImageTransparentColor = Color.Magenta;
        this.toolStripButton_7.Name = "toolBtnDelPayment";
        this.toolStripButton_7.Size = new Size(0x17, 0x16);
        this.toolStripButton_7.Text = "Удалить платеж";
        this.toolStripButton_7.Click += new EventHandler(this.toolStripButton_7_Click);
        this.tabPage_4.Controls.Add(this.dataGridView_1);
        this.tabPage_4.Controls.Add(this.toolStrip_2);
        this.tabPage_4.Location = new Point(4, 0x16);
        this.tabPage_4.Name = "tabPagePaymentShedule";
        this.tabPage_4.Padding = new Padding(3);
        this.tabPage_4.Size = new Size(0x1c7, 0x14b);
        this.tabPage_4.TabIndex = 4;
        this.tabPage_4.Text = "График платежей";
        this.tabPage_4.UseVisualStyleBackColor = true;
        this.dataGridView_1.AutoGenerateColumns = false;
        this.dataGridView_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DataGridViewColumn[] columnArray4 = new DataGridViewColumn[] { this.dataGridViewFilterDateTimePickerColumn_0, this.dataGridViewTextBoxColumn_26, this.dataGridViewTextBoxColumn_27, this.dataGridViewNumericColumn_0, this.dataGridViewTextBoxColumn_28 };
        this.dataGridView_1.Columns.AddRange(columnArray4);
        this.dataGridView_1.DataSource = this.bindingSource_2;
        this.dataGridView_1.Dock = DockStyle.Fill;
        this.dataGridView_1.Location = new Point(3, 3);
        this.dataGridView_1.Name = "dgvPaymentShedule";
        this.dataGridView_1.Size = new Size(0x1c1, 0x145);
        this.dataGridView_1.TabIndex = 2;
        this.dataGridView_1.CellValueChanged += new DataGridViewCellEventHandler(this.dataGridView_1_CellValueChanged);
        this.dataGridViewFilterDateTimePickerColumn_0.DataPropertyName = "DateShedule";
        style4.Format = "dd MM yyyy";
        style4.NullValue = null;
        this.dataGridViewFilterDateTimePickerColumn_0.DefaultCellStyle = style4;
        this.dataGridViewFilterDateTimePickerColumn_0.HeaderText = "Дата";
        this.dataGridViewFilterDateTimePickerColumn_0.Name = "dateSheduleDataGridViewTextBoxColumn";
        this.dataGridViewFilterDateTimePickerColumn_0.Resizable = DataGridViewTriState.True;
        this.dataGridViewFilterDateTimePickerColumn_0.SortMode = DataGridViewColumnSortMode.Automatic;
        this.dataGridViewTextBoxColumn_26.DataPropertyName = "id";
        this.dataGridViewTextBoxColumn_26.HeaderText = "id";
        this.dataGridViewTextBoxColumn_26.Name = "idDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_26.ReadOnly = true;
        this.dataGridViewTextBoxColumn_26.Visible = false;
        this.dataGridViewTextBoxColumn_27.DataPropertyName = "idDoc";
        this.dataGridViewTextBoxColumn_27.HeaderText = "idDoc";
        this.dataGridViewTextBoxColumn_27.Name = "idDocPSDgvColumn";
        this.dataGridViewTextBoxColumn_27.Visible = false;
        this.dataGridViewNumericColumn_0.DataPropertyName = "Summa";
        this.dataGridViewNumericColumn_0.set_DecimalLength(2);
        style5.Format = "F2";
        this.dataGridViewNumericColumn_0.DefaultCellStyle = style5;
        this.dataGridViewNumericColumn_0.HeaderText = "Сумма";
        this.dataGridViewNumericColumn_0.Name = "summaDataGridViewTextBoxColumn";
        this.dataGridViewNumericColumn_0.Resizable = DataGridViewTriState.True;
        this.dataGridViewNumericColumn_0.set_ShowNullWhenZero(true);
        this.dataGridViewTextBoxColumn_28.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.dataGridViewTextBoxColumn_28.DataPropertyName = "Comment";
        this.dataGridViewTextBoxColumn_28.HeaderText = "Коментарий";
        this.dataGridViewTextBoxColumn_28.Name = "commentDataGridViewTextBoxColumn";
        this.bindingSource_2.DataMember = "tTC_PaymentShedule";
        this.bindingSource_2.DataSource = this.dataSetTechConnection_2;
        ToolStripItem[] itemArray4 = new ToolStripItem[] { this.toolStripButton_8, this.toolStripButton_9, this.toolStripButton_10 };
        this.toolStrip_2.Items.AddRange(itemArray4);
        this.toolStrip_2.Location = new Point(3, 3);
        this.toolStrip_2.Name = "toolStrip1";
        this.toolStrip_2.Size = new Size(0x1d4, 0x19);
        this.toolStrip_2.TabIndex = 1;
        this.toolStrip_2.Text = "toolStrip1";
        this.toolStrip_2.Visible = false;
        this.toolStripButton_8.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_8.Image = Resources.ElementAdd;
        this.toolStripButton_8.ImageTransparentColor = Color.Magenta;
        this.toolStripButton_8.Name = "toolBtnAddPaymentShedule";
        this.toolStripButton_8.Size = new Size(0x17, 0x16);
        this.toolStripButton_8.Text = "Добавить";
        this.toolStripButton_9.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_9.Image = Resources.ElementEdit;
        this.toolStripButton_9.ImageTransparentColor = Color.Magenta;
        this.toolStripButton_9.Name = "toolBtnEditPaymentShedule";
        this.toolStripButton_9.Size = new Size(0x17, 0x16);
        this.toolStripButton_9.Text = "Редактировать";
        this.toolStripButton_10.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_10.Image = Resources.ElementDel;
        this.toolStripButton_10.ImageTransparentColor = Color.Magenta;
        this.toolStripButton_10.Name = "toolBtnDelPaymentShedule";
        this.toolStripButton_10.Size = new Size(0x17, 0x16);
        this.toolStripButton_10.Text = "Удалить";
        ToolStripItem[] itemArray5 = new ToolStripItem[] { this.toolStripMenuItem_1, this.toolStripMenuItem_3, this.toolStripMenuItem_4, this.toolStripMenuItem_5, this.toolStripSeparator_3, this.toolStripMenuItem_6, this.toolStripMenuItem_7 };
        this.contextMenuStrip_0.Items.AddRange(itemArray5);
        this.contextMenuStrip_0.Name = "contextMenuFile";
        this.contextMenuStrip_0.Size = new Size(0xb1, 0x8e);
        ToolStripItem[] itemArray6 = new ToolStripItem[] { this.toolStripMenuItem_2, this.toolStripSeparator_2 };
        this.toolStripMenuItem_1.DropDownItems.AddRange(itemArray6);
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
        base.AcceptButton = this.button_0;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.CancelButton = this.button_1;
        base.ClientSize = new Size(0x1cd, 0x1c1);
        base.Controls.Add(this.tabControl_0);
        base.Controls.Add(this.label_2);
        base.Controls.Add(this.button_1);
        base.Controls.Add(this.button_0);
        base.Controls.Add(this.nullableDateTimePicker_0);
        base.Controls.Add(this.textBox_0);
        base.Controls.Add(this.label_0);
        base.MaximizeBox = false;
        base.MinimizeBox = false;
        base.Name = "FormContractAddEdit";
        this.Text = "FormTechConnectionDocOutAddEdit";
        base.FormClosing += new FormClosingEventHandler(this.Form12_FormClosing);
        base.Load += new EventHandler(this.Form12_Load);
        this.dataSetTechConnection_2.EndInit();
        this.tabControl_0.ResumeLayout(false);
        this.tabPage_0.ResumeLayout(false);
        this.tabPage_0.PerformLayout();
        this.nullableNumericUpDown_1.EndInit();
        this.nullableNumericUpDown_0.EndInit();
        this.tabPage_1.ResumeLayout(false);
        this.dataGridViewExcelFilter_0.EndInit();
        ((ISupportInitialize) this.bindingSource_0).EndInit();
        this.tabPage_2.ResumeLayout(false);
        this.tabPage_2.PerformLayout();
        this.dataGridViewExcelFilter_1.EndInit();
        ((ISupportInitialize) this.bindingSource_1).EndInit();
        this.toolStrip_0.ResumeLayout(false);
        this.toolStrip_0.PerformLayout();
        this.tabPage_3.ResumeLayout(false);
        this.tabPage_3.PerformLayout();
        ((ISupportInitialize) this.dataGridView_0).EndInit();
        this.toolStrip_1.ResumeLayout(false);
        this.toolStrip_1.PerformLayout();
        this.tabPage_4.ResumeLayout(false);
        this.tabPage_4.PerformLayout();
        ((ISupportInitialize) this.dataGridView_1).EndInit();
        ((ISupportInitialize) this.bindingSource_2).EndInit();
        this.toolStrip_2.ResumeLayout(false);
        this.toolStrip_2.PerformLayout();
        this.contextMenuStrip_0.ResumeLayout(false);
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    [CompilerGenerated]
    private void method_26()
    {
        this.bindingSource_1.ResetBindings(false);
    }

    private void method_3()
    {
        string[] textArray1 = new string[7];
        textArray1[0] = "select  d.id, d.numdoc, d.datedoc,  isnull(d.numdoc, '') + ' от ' + isnull(convert( varchar(10),d.Datedoc, 104), '') as numDateDoc from ttc_doc d  where d.typeDoc = ";
        textArray1[1] = 0x463.ToString();
        textArray1[2] = " and d.id not in (select doc.id  from ttc_doc doc  inner join ttc_doc dog on dog.id = doc.idParent  where doc.typeDoc = ";
        textArray1[3] = 0x463.ToString();
        textArray1[4] = " and dog.typeDoc = ";
        int num = 0x4c4;
        textArray1[5] = num.ToString();
        textArray1[6] = ")";
        string selectCommandText = string.Concat(textArray1);
        if (this.int_2 != -1)
        {
            string[] textArray2 = new string[5];
            textArray2[0] = selectCommandText;
            textArray2[1] = " union select  d.id, d.numdoc, d.datedoc,  isnull(d.numdoc, '') + ' от ' + isnull(convert( varchar(10),d.Datedoc, 104), '') as numDateDoc  from ttc_doc d  where d.id = ";
            textArray2[2] = this.int_2.ToString();
            textArray2[3] = " and d.typeDoc = ";
            num = 0x463;
            textArray2[4] = num.ToString();
            selectCommandText = string.Concat(textArray2);
        }
        if (this.method_0() != -1)
        {
            string[] textArray3 = new string[] { selectCommandText, " union select  d.id, d.numdoc, d.datedoc,  isnull(d.numdoc, '') + ' от ' + isnull(convert( varchar(10),d.Datedoc, 104), '') as numDateDoc  from ttc_doc dog  inner join ttc_doc d on d.idParent = dog.id and d.typeDoc = ", 0x463.ToString(), " where dog.id = ", this.method_0().ToString() };
            selectCommandText = string.Concat(textArray3);
        }
        selectCommandText = selectCommandText + " order by numdoc, datedoc ";
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
        if (this.int_2 != -1)
        {
            this.comboBox_0.SelectedValue = this.int_2;
        }
        else
        {
            this.comboBox_0.SelectedIndex = -1;
        }
    }

    private void method_4(int int_5)
    {
        DataSetTechConnection.tTC_DocDataTable table = new DataSetTechConnection.tTC_DocDataTable();
        base.SelectSqlData(table, true, " where id = " + int_5.ToString(), false);
        if (table.Rows.Count <= 0)
        {
            this.int_4 = -1;
            this.int_3 = -1;
            this.textBox_3.Text = this.textBox_2.Text = "";
            this.dataSetTechConnection_2.vTC_RequestHistory.Clear();
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
                    this.int_3 = Convert.ToInt32(table4.Rows[0]["idAbn"]);
                    DataSetTechConnection.tAbnDataTable table5 = new DataSetTechConnection.tAbnDataTable();
                    base.SelectSqlData(table5, true, "where id = " + this.int_3.ToString(), false);
                    if (table5.Rows.Count > 0)
                    {
                        this.textBox_3.Text = table5.Rows[0]["name"].ToString();
                        int num3 = Convert.ToInt32(table5.Rows[0]["typeAbn"]);
                        if (table4.Rows[0]["idAbnObj"] != DBNull.Value)
                        {
                            this.int_4 = Convert.ToInt32(table4.Rows[0]["idAbnObj"]);
                            DataSetTechConnection.vAbnObjAddressDataTable table6 = new DataSetTechConnection.vAbnObjAddressDataTable();
                            DataColumn column = new DataColumn("AddressFL") {
                                Expression = "street + ', д. ' + houseall + ', кв. ' + name"
                            };
                            table6.Columns.Add(column);
                            column = new DataColumn("AddressUL") {
                                Expression = "street + ', д. ' + houseall"
                            };
                            table6.Columns.Add(column);
                            base.SelectSqlData(table6, true, "where id = " + this.int_4.ToString() + " order by name", false);
                            if (table6.Rows.Count > 0)
                            {
                                if (((num3 != 0xce) && (num3 != 0xfd)) && (num3 != 0x40d))
                                {
                                    this.textBox_2.Text = table6.Rows[0]["name"].ToString();
                                }
                                else
                                {
                                    this.textBox_2.Text = table6.Rows[0]["AddressFL"].ToString();
                                }
                            }
                            else
                            {
                                this.textBox_2.Text = "";
                            }
                        }
                        else
                        {
                            this.textBox_2.Text = "";
                        }
                    }
                    else
                    {
                        this.textBox_3.Text = this.textBox_2.Text = "";
                    }
                }
                base.SelectSqlData(this.dataSetTechConnection_2, this.dataSetTechConnection_2.vTC_RequestHistory, true, "where id = " + num2.ToString() + " or IdParent = " + num2.ToString() + " order by dateDoc");
            }
            else
            {
                this.int_4 = -1;
                this.int_3 = -1;
                this.textBox_3.Text = this.textBox_2.Text = "";
                this.dataSetTechConnection_2.vTC_RequestHistory.Clear();
            }
        }
    }

    private bool method_5()
    {
        if (string.IsNullOrEmpty(this.textBox_0.Text))
        {
            MessageBox.Show("Не введен номер договора");
            return false;
        }
        if (this.comboBox_0.SelectedIndex < 0)
        {
            MessageBox.Show("Не выбрано тех условие");
            return false;
        }
        return true;
    }

    private bool method_6()
    {
        if (!this.method_5())
        {
            return false;
        }
        this.dataSetTechConnection_2.tTC_Doc.Rows[0].EndEdit();
        if (this.int_0 == -1)
        {
            this.int_0 = base.InsertSqlDataOneRow(this.dataSetTechConnection_2, this.dataSetTechConnection_2.tTC_Doc);
            if (this.int_0 == -1)
            {
                return false;
            }
        }
        else if (!base.UpdateSqlData(this.dataSetTechConnection_2, this.dataSetTechConnection_2.tTC_Doc))
        {
            return false;
        }
        base.SelectSqlData(this.dataSetTechConnection_2.tTC_Doc, true, " where id = " + this.int_0.ToString(), false);
        this.dataSetTechConnection_2.tTC_Contract.Rows[0]["id"] = this.int_0;
        this.dataSetTechConnection_2.tTC_Contract.Rows[0].EndEdit();
        if (!base.InsertSqlData(this.dataSetTechConnection_2, this.dataSetTechConnection_2.tTC_Contract))
        {
            return false;
        }
        if (!base.UpdateSqlData(this.dataSetTechConnection_2, this.dataSetTechConnection_2.tTC_Contract))
        {
            return false;
        }
        this.nullableNumericUpDown_0.ValueChanged -= new EventHandler(this.nullableNumericUpDown_0_ValueChanged);
        base.SelectSqlData(this.dataSetTechConnection_2.tTC_Contract, true, " where id = " + this.int_0.ToString(), false);
        this.nullableNumericUpDown_0.ValueChanged += new EventHandler(this.nullableNumericUpDown_0_ValueChanged);
        base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_DocOut, true, " where iddocout = " + this.int_2.ToString());
        if (this.dataSetTechConnection_0.tTC_DocOut.Rows.Count > 0)
        {
            this.int_1 = Convert.ToInt32(this.dataSetTechConnection_0.tTC_DocOut.Rows[0]["idDoc"]);
            if (this.dataSetTechConnection_2.tTC_DocOut.Rows.Count > 0)
            {
                if (Convert.ToInt32(this.dataSetTechConnection_2.tTC_DocOut.Rows[0]["idDoc"]) != this.int_1)
                {
                    this.dataSetTechConnection_2.tTC_DocOut.Rows[0]["idDoc"] = this.int_1;
                    this.dataSetTechConnection_2.tTC_DocOut.Rows[0].EndEdit();
                    if (!base.UpdateSqlData(this.dataSetTechConnection_2, this.dataSetTechConnection_2.tTC_DocOut))
                    {
                        return false;
                    }
                }
            }
            else if (this.dataSetTechConnection_0.tTC_DocOut.Rows.Count > 0)
            {
                DataRow row = this.dataSetTechConnection_2.tTC_DocOut.NewRow();
                row["idDoc"] = this.int_1;
                row["idDocOut"] = this.int_0;
                this.dataSetTechConnection_2.tTC_DocOut.Rows.Add(row);
                if (!base.InsertSqlData(this.dataSetTechConnection_2, this.dataSetTechConnection_2.tTC_DocOut))
                {
                    return false;
                }
            }
        }
        if (this.dataSetTechConnection_0.tTC_Doc.Rows.Count > 0)
        {
            if (Convert.ToInt32(this.dataSetTechConnection_0.tTC_Doc.Rows[0]["id"]) != this.int_2)
            {
                this.dataSetTechConnection_0.tTC_Doc.Rows[0]["idParent"] = DBNull.Value;
                this.dataSetTechConnection_0.tTC_Doc.Rows[0].EndEdit();
                if (!base.UpdateSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Doc))
                {
                    return false;
                }
                base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Doc, true, " where id = " + this.int_2.ToString());
                this.dataSetTechConnection_0.tTC_Doc.Rows[0]["idParent"] = this.int_0;
                this.dataSetTechConnection_0.tTC_Doc.Rows[0].EndEdit();
                if (!base.UpdateSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Doc))
                {
                    return false;
                }
            }
            else
            {
                this.dataSetTechConnection_0.tTC_Doc.Rows[0]["idParent"] = this.int_0;
                this.dataSetTechConnection_0.tTC_Doc.Rows[0].EndEdit();
                if (!base.UpdateSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Doc))
                {
                    return false;
                }
            }
        }
        else
        {
            base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Doc, true, " where id = " + this.int_2.ToString());
            if (this.dataSetTechConnection_0.tTC_Doc.Rows.Count > 0)
            {
                this.dataSetTechConnection_0.tTC_Doc.Rows[0]["idParent"] = this.int_0;
                this.dataSetTechConnection_0.tTC_Doc.Rows[0].EndEdit();
                if (!base.UpdateSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Doc))
                {
                    return false;
                }
            }
        }
        base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Doc, true, " where id = " + this.int_2.ToString());
        if (!this.method_15())
        {
            return false;
        }
        if (!this.method_22())
        {
            return false;
        }
        if (!this.method_23())
        {
            return false;
        }
        this.bool_0 = false;
        return true;
    }

    private string method_7(string string_2, int? nullable_0 = new int?(), byte[] byte_0 = null)
    {
        string fileName = Path.GetFileName(string_2);
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
        DataSetTechConnection.Class252 class2 = this.dataSetTechConnection_2.tTC_DocFile.method_5();
        class2.idDoc = -1;
        class2.FileName = fileName;
        if (byte_0 == null)
        {
            FileBinary binary = new FileBinary(string_2);
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
        this.dataSetTechConnection_2.tTC_DocFile.method_0(class2);
        return fileName;
    }

    private void method_8()
    {
        foreach (DataRow row in new SqlDataCommand(this.get_SqlSettings()).SelectSqlData(" SELECT doc.id, doc.FileName  FROM tR_DocTemplate AS doc  INNER JOIN [tR_Classifier] AS c ON doc.idTypeDoc = c.id  WHERE c.ParentKey = ';TypeDoc;tR_DocTemplate;' AND c.Deleted = ((0)) AND c.isGroup = ((0)) AND c.Value = 4 and doc.deleted = 0").Rows)
        {
            ToolStripMenuItem item = new ToolStripMenuItem {
                Text = row["FileName"].ToString(),
                Tag = row["id"]
            };
            item.Click += new EventHandler(this.method_16);
            this.toolStripDropDownButton_0.DropDownItems.Add(item);
            ToolStripMenuItem item2 = new ToolStripMenuItem {
                Text = row["FileName"].ToString(),
                Tag = row["id"]
            };
            item2.Click += new EventHandler(this.method_16);
            this.toolStripMenuItem_1.DropDownItems.Add(item2);
        }
    }

    public void method_9(int int_5, out string string_2, out byte[] byte_0)
    {
        string_2 = "";
        byte_0 = null;
        string cmdText = "SELECT FileName, FileData FROM tR_DocTemplate WHERE id = @idTemplate";
        using (SqlConnection connection = new SqlConnection(this.get_SqlSettings().GetConnectionString()))
        {
            SqlCommand command = new SqlCommand(cmdText, connection);
            command.Parameters.Add("@idTemplate", SqlDbType.Int);
            command.Parameters["@idTemplate"].Value = int_5;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string_2 = (string) reader.GetValue(0);
                    byte_0 = (byte[]) reader.GetValue(1);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source);
            }
        }
    }

    private void nullableDateTimePicker_0_ValueChanged(object sender, EventArgs e)
    {
        this.bool_0 = true;
    }

    private void nullableDateTimePicker_1_ValueChanged(object sender, EventArgs e)
    {
        this.bool_0 = true;
    }

    private void nullableNumericUpDown_0_ValueChanged(object sender, EventArgs e)
    {
        this.bool_0 = true;
        decimal? nullable = this.nullableNumericUpDown_0.get_Value();
        if (!nullable.HasValue)
        {
            if (this.dataSetTechConnection_2.tTC_Contract.Rows.Count > 0)
            {
                this.dataSetTechConnection_2.tTC_Contract.Rows[0]["sumContract"] = DBNull.Value;
                this.nullableNumericUpDown_1.set_Value(null);
                this.dataSetTechConnection_2.tTC_Contract.Rows[0]["sumnds"] = DBNull.Value;
            }
        }
        else if (this.dataSetTechConnection_2.tTC_Contract.Rows.Count > 0)
        {
            this.dataSetTechConnection_2.tTC_Contract.Rows[0]["sumContract"] = this.nullableNumericUpDown_0.get_Value().Value;
            this.nullableNumericUpDown_1.set_Value(new decimal?((this.nullableNumericUpDown_0.get_Value().Value * 18M) / 118M));
            this.dataSetTechConnection_2.tTC_Contract.Rows[0]["sumnds"] = (this.nullableNumericUpDown_0.get_Value().Value * 18M) / 118M;
        }
    }

    private void textBox_0_TextChanged(object sender, EventArgs e)
    {
        this.bool_0 = true;
    }

    private void textBox_1_TextChanged(object sender, EventArgs e)
    {
        this.bool_0 = true;
    }

    private void toolStripButton_5_Click(object sender, EventArgs e)
    {
        Form14 form = new Form14();
        form.set_SqlSettings(this.get_SqlSettings());
        if (form.ShowDialog() == DialogResult.OK)
        {
            if ((form.method_0() != null) && (form.method_1() != null))
            {
                DataRow row = this.dataSetTechConnection_1.tTC_Doc.NewRow();
                row["typeDoc"] = form.method_0()["typeDoc"];
                row["numDoc"] = form.method_0()["numdoc"];
                row["dateDoc"] = form.method_0()["datedoc"];
                row["comment"] = form.method_0()["comment"];
                this.dataSetTechConnection_1.tTC_Doc.Rows.Add(row);
                DataRow row2 = this.dataSetTechConnection_1.tTC_Payment.NewRow();
                row2["id"] = row["id"];
                row2["summa"] = form.method_1()["summa"];
                row2["idDog"] = form.method_1()["iddog"];
                this.dataSetTechConnection_1.tTC_Payment.Rows.Add(row2);
                this.method_19();
            }
            this.bool_0 = true;
        }
    }

    private void toolStripButton_6_Click(object sender, EventArgs e)
    {
        if (this.dataGridView_0.CurrentRow != null)
        {
            int num = Convert.ToInt32(this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_21.Name].Value);
            DataRow[] rowArray = this.dataSetTechConnection_1.tTC_Doc.Select("id = " + num.ToString());
            if (rowArray.Length != 0)
            {
                DataRow[] rowArray2 = this.dataSetTechConnection_1.tTC_Payment.Select("id = " + num.ToString());
                Form14 form = new Form14(rowArray[0], (rowArray2.Length != 0) ? rowArray2[0] : null);
                form.set_SqlSettings(this.get_SqlSettings());
                if (form.ShowDialog() == DialogResult.OK)
                {
                    if ((form.method_0() != null) && (form.method_1() != null))
                    {
                        rowArray[0]["typeDoc"] = form.method_0()["typeDoc"];
                        rowArray[0]["numDoc"] = form.method_0()["numdoc"];
                        rowArray[0]["dateDoc"] = form.method_0()["datedoc"];
                        rowArray[0]["comment"] = form.method_0()["comment"];
                        if (rowArray2.Length == 0)
                        {
                            DataRow row = this.dataSetTechConnection_1.tTC_Payment.NewRow();
                            row["id"] = rowArray[0]["id"];
                            row["summa"] = form.method_1()["summa"];
                            row["idDog"] = form.method_1()["iddog"];
                            this.dataSetTechConnection_1.tTC_Payment.Rows.Add(row);
                        }
                        else
                        {
                            rowArray2[0]["id"] = rowArray[0]["id"];
                            rowArray2[0]["summa"] = form.method_1()["summa"];
                            rowArray2[0]["idDog"] = form.method_1()["iddog"];
                        }
                        this.method_19();
                    }
                    this.bool_0 = true;
                }
            }
        }
    }

    private void toolStripButton_7_Click(object sender, EventArgs e)
    {
        if ((this.dataGridView_0.CurrentRow != null) && (MessageBox.Show("Вы действительно хотите удалить текущий документ", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
        {
            int num = Convert.ToInt32(this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_21.Name].Value);
            DataRow[] rowArray = this.dataSetTechConnection_1.tTC_Doc.Select("id = " + num.ToString());
            if (rowArray.Length != 0)
            {
                rowArray[0].Delete();
            }
            DataRow[] rowArray2 = this.dataSetTechConnection_1.tTC_Payment.Select("id = " + num.ToString());
            if (rowArray2.Length != 0)
            {
                rowArray2[0].Delete();
            }
            this.bool_0 = true;
            this.method_19();
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
                if (!string.IsNullOrEmpty(this.method_7(str, nullable, null)))
                {
                    this.bool_0 = true;
                }
            }
        }
    }

    private void toolStripMenuItem_3_Click(object sender, EventArgs e)
    {
        this.method_13(true);
    }

    private void toolStripMenuItem_4_Click(object sender, EventArgs e)
    {
        this.method_13(false);
    }

    private void toolStripMenuItem_5_Click(object sender, EventArgs e)
    {
        if ((this.bindingSource_1.Current != null) && (MessageBox.Show("Вы действительно хотите удалить выбранный файл?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
        {
            DataSetTechConnection.Class252 row = (DataSetTechConnection.Class252) ((DataRowView) this.bindingSource_1.Current).Row;
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

    private void toolStripMenuItem_7_Click(object sender, EventArgs e)
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
                this.method_18(dialog.FileName, file);
            }
        }
    }

    [CompilerGenerated]
    private sealed class Class31
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
}

