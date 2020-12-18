using ControlsLbr;
using ControlsLbr.DataGridViewExcelFilter;
using DataSql;
using Documents.Forms.TechnologicalConnection;
using Documents.Properties;
using FormLbr;
using FormLbr.Classes;
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

internal class Form11 : FormBase
{
    private BindingSource bindingSource_0;
    private BindingSource bindingSource_1;
    private bool bool_0;
    private Button button_0;
    private Button button_1;
    private ComboBox comboBox_0;
    private ComboBox comboBox_1;
    private ComboBox comboBox_2;
    private ContextMenuStrip contextMenuStrip_0;
    private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_0;
    private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_1;
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
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;
    private DataSetTechConnection dataSetTechConnection_0;
    private Dictionary<string, FileWatcherArgsAddl> dictionary_0;
    private GroupBox groupBox_0;
    private IContainer icontainer_0;
    private int int_0;
    private int int_1;
    private int int_2;
    private int int_3;
    private Label label_0;
    private Label label_1;
    private Label label_2;
    private Label label_3;
    private Label label_4;
    private Label label_5;
    private Label label_6;
    private Label label_7;
    private NullableDateTimePicker nullableDateTimePicker_0;
    private RadioButton radioButton_0;
    private RadioButton radioButton_1;
    private RadioButton radioButton_2;
    private string string_0;
    private TabControl tabControl_0;
    private TabControl tabControl_1;
    private TabPage tabPage_0;
    private TabPage tabPage_1;
    private TabPage tabPage_2;
    private TabPage tabPage_3;
    private TextBox textBox_0;
    private TextBox textBox_1;
    private TextBox textBox_2;
    private TextBox textBox_3;
    private ToolStrip toolStrip_0;
    private ToolStrip toolStrip_1;
    private ToolStripButton toolStripButton_0;
    private ToolStripButton toolStripButton_1;
    private ToolStripButton toolStripButton_2;
    private ToolStripButton toolStripButton_3;
    private ToolStripButton toolStripButton_4;
    private ToolStripButton toolStripButton_5;
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

    internal Form11()
    {
        this.int_0 = -1;
        this.int_1 = -1;
        this.int_2 = -1;
        this.int_3 = -1;
        this.dictionary_0 = new Dictionary<string, FileWatcherArgsAddl>();
        this.string_0 = "";
        this.method_24();
        this.nullableDateTimePicker_0.set_Value(DateTime.Now.Date);
    }

    internal Form11(int int_4, int int_5 = -1)
    {
        this.int_0 = -1;
        this.int_1 = -1;
        this.int_2 = -1;
        this.int_3 = -1;
        this.dictionary_0 = new Dictionary<string, FileWatcherArgsAddl>();
        this.string_0 = "";
        this.method_24();
        this.nullableDateTimePicker_0.set_Value(DateTime.Now.Date);
        this.int_0 = int_4;
        this.int_1 = int_5;
        this.Text = (int_4 == -1) ? "Новое письмо" : "Редактирование письма";
    }

    private void button_0_Click(object sender, EventArgs e)
    {
        if (this.method_8())
        {
            base.Close();
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

    private void comboBox_1_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.bool_0 = true;
    }

    private void comboBox_2_SelectedValueChanged(object sender, EventArgs e)
    {
        if ((this.comboBox_2.SelectedValue != null) && (this.comboBox_2.SelectedIndex != -1))
        {
            this.int_1 = Convert.ToInt32(this.comboBox_2.SelectedValue);
            this.method_4(this.int_1);
        }
        else
        {
            this.textBox_2.Text = this.textBox_3.Text = "";
            this.int_1 = -1;
        }
    }

    private void dataGridViewExcelFilter_0_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        if ((e.RowIndex >= 0) && (Convert.ToInt32(this.dataGridViewExcelFilter_0[this.dataGridViewTextBoxColumn_4.Name, e.RowIndex].Value) == 0x459))
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

    private void Form11_FormClosing(object sender, FormClosingEventArgs e)
    {
        if ((this.bool_0 && (MessageBox.Show("Сохранить внесенные изменения?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)) && !this.method_8())
        {
            e.Cancel = true;
        }
    }

    private void Form11_Load(object sender, EventArgs e)
    {
        this.method_1();
        this.method_2();
        this.method_16();
        if (this.int_0 == -1)
        {
            this.method_6();
            DataRow row = this.dataSetTechConnection_0.tTC_DocOut.NewRow();
            row["idDoc"] = this.int_1;
            row["idDocOut"] = this.dataSetTechConnection_0.tTC_Doc.Rows[0]["id"];
            this.dataSetTechConnection_0.tTC_DocOut.Rows.Add(row);
        }
        else
        {
            base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Doc, true, "where id = " + this.int_0.ToString());
            base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Mail, true, "where id = " + this.int_0.ToString());
            if (this.dataSetTechConnection_0.tTC_Mail.Rows.Count == 0)
            {
                DataRow row2 = this.dataSetTechConnection_0.tTC_Mail.NewRow();
                row2["id"] = this.int_0;
                this.dataSetTechConnection_0.tTC_Mail.Rows.Add(row2);
            }
            base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_DocOut, true, "where idDocOut = " + this.int_0.ToString());
            if (this.dataSetTechConnection_0.tTC_DocOut.Rows.Count > 0)
            {
                DataSetTechConnection.tTC_DocDataTable table = new DataSetTechConnection.tTC_DocDataTable();
                base.SelectSqlData(table, true, "where id = " + this.dataSetTechConnection_0.tTC_DocOut.Rows[0]["idDoc"].ToString(), false);
                if (table.Rows.Count > 0)
                {
                    switch (Convert.ToInt32(table.Rows[0]["typeDoc"]))
                    {
                        case 0x459:
                            this.radioButton_2.Checked = true;
                            this.comboBox_2.SelectedValue = Convert.ToInt32(table.Rows[0]["id"]);
                            break;

                        case 0x463:
                            this.radioButton_1.Checked = true;
                            this.comboBox_2.SelectedValue = Convert.ToInt32(table.Rows[0]["id"]);
                            break;
                    }
                }
            }
            else
            {
                this.radioButton_0.Checked = true;
                this.method_5(this.dataSetTechConnection_0.tTC_Mail.Rows[0]["idAbn"], this.dataSetTechConnection_0.tTC_Mail.Rows[0]["idAbnObj"]);
            }
            this.method_22(this.int_0);
        }
        this.bool_0 = false;
    }

    internal int method_0()
    {
        return this.int_0;
    }

    private void method_1()
    {
        DataSetTechConnection.tR_ClassifierDataTable table = new DataSetTechConnection.tR_ClassifierDataTable();
        string[] textArray1 = new string[] { " where id in (", 0x465.ToString(), ",", 0x4c2.ToString(), ") order by name" };
        base.SelectSqlData(table, true, string.Concat(textArray1), false);
        this.comboBox_0.DataSource = table;
        this.comboBox_0.DisplayMember = "Name";
        this.comboBox_0.ValueMember = "id";
        DataTable table2 = new DataTable("vWorkerGroup");
        table2.Columns.Add("id", typeof(int));
        table2.Columns.Add("fio", typeof(string));
        base.SelectSqlData(table2, true, "where ParentKey = ';GroupWorker;PerformerTU;' and dateEnd is null order by fio", false);
        this.comboBox_1.DataSource = table2;
        this.comboBox_1.DisplayMember = "fio";
        this.comboBox_1.ValueMember = "id";
        this.comboBox_1.SelectedIndex = -1;
    }

    private bool method_10()
    {
        if (this.radioButton_0.Checked && (this.int_2 != -1))
        {
            this.dataSetTechConnection_0.tTC_Mail.Rows[0]["idAbn"] = this.int_2;
            if (this.int_3 == -1)
            {
                this.dataSetTechConnection_0.tTC_Mail.Rows[0]["idAbnObj"] = DBNull.Value;
            }
            else
            {
                this.dataSetTechConnection_0.tTC_Mail.Rows[0]["idAbnObj"] = this.int_3;
            }
        }
        else
        {
            this.dataSetTechConnection_0.tTC_Mail.Rows[0]["idAbn"] = DBNull.Value;
            this.dataSetTechConnection_0.tTC_Mail.Rows[0]["idAbnObj"] = DBNull.Value;
        }
        this.dataSetTechConnection_0.tTC_Mail.Rows[0]["id"] = this.int_0;
        this.dataSetTechConnection_0.tTC_Mail.Rows[0].EndEdit();
        if (!base.InsertSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Mail))
        {
            return false;
        }
        if (!base.UpdateSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Mail))
        {
            return false;
        }
        return true;
    }

    private void method_11(object sender, FormClosedEventArgs e)
    {
        FormTechConnectionAddAbn abn = (FormTechConnectionAddAbn) sender;
        if (abn.DialogResult == DialogResult.OK)
        {
            this.textBox_3.Text = abn.AbnName;
            this.textBox_2.Text = abn.AbnObjName;
            this.int_2 = abn.IdAbn;
            this.int_3 = abn.IdAbnObj;
            this.bool_0 = true;
        }
    }

    private FormBase method_12(object object_0, ShowFormEventArgs showFormEventArgs_0)
    {
        return this.OnShowForm(showFormEventArgs_0);
    }

    private void method_13(object sender, EventArgs e)
    {
        string str;
        byte[] buffer;
        string str3;
        int tag = (int) ((ToolStripMenuItem) sender).Tag;
        this.method_17(tag, out str, out buffer);
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
        str3 = this.method_18();
        string str4 = FileBinary.GetNewFileNameIsExists(str3, str, false);
        string str5 = this.method_15(str, new int?(tag), buffer);
        if (!string.IsNullOrEmpty(str5))
        {
            this.bool_0 = true;
            FileBinary binary = new FileBinary(buffer, str4, DateTime.Now);
            binary.SaveToDisk(str3);
            Process.Start(str3 + @"\" + binary.get_Name());
            if (this.dictionary_0.ContainsKey(str5))
            {
                FileWatcher watcher = new FileWatcher(str3, binary.get_Name());
                watcher.add_AnyChanged(new FileSystemEventHandler(this.method_19));
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

    public bool method_14(string string_1, byte[] byte_0)
    {
        try
        {
            FileStream stream1 = new FileStream(string_1, FileMode.Create, FileAccess.Write);
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

    private string method_15(string string_1, int? nullable_0 = new int?(), byte[] byte_0 = null)
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
        if (nullable_0.HasValue)
        {
            class2.idTemplate = nullable_0.Value;
        }
        this.dataSetTechConnection_0.tTC_DocFile.method_0(class2);
        return fileName;
    }

    private void method_16()
    {
        foreach (DataRow row in new SqlDataCommand(this.get_SqlSettings()).SelectSqlData(" SELECT doc.id, doc.FileName  FROM tR_DocTemplate AS doc  INNER JOIN [tR_Classifier] AS c ON doc.idTypeDoc = c.id  WHERE c.ParentKey = ';TypeDoc;tR_DocTemplate;' AND c.Deleted = ((0)) AND c.isGroup = ((0)) AND c.Value = 2 and doc.deleted = 0").Rows)
        {
            ToolStripMenuItem item = new ToolStripMenuItem {
                Text = row["FileName"].ToString(),
                Tag = row["id"]
            };
            item.Click += new EventHandler(this.method_13);
            this.toolStripDropDownButton_0.DropDownItems.Add(item);
            ToolStripMenuItem item2 = new ToolStripMenuItem {
                Text = row["FileName"].ToString(),
                Tag = row["id"]
            };
            item2.Click += new EventHandler(this.method_13);
            this.toolStripMenuItem_1.DropDownItems.Add(item2);
        }
    }

    public void method_17(int int_4, out string string_1, out byte[] byte_0)
    {
        string_1 = "";
        byte_0 = null;
        string cmdText = "SELECT FileName, FileData FROM tR_DocTemplate WHERE id = @idTemplate";
        using (SqlConnection connection = new SqlConnection(this.get_SqlSettings().GetConnectionString()))
        {
            SqlCommand command = new SqlCommand(cmdText, connection);
            command.Parameters.Add("@idTemplate", SqlDbType.Int);
            command.Parameters["@idTemplate"].Value = int_4;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string_1 = (string) reader.GetValue(0);
                    byte_0 = (byte[]) reader.GetValue(1);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source);
            }
        }
    }

    private string method_18()
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

    private void method_19(object sender, FileSystemEventArgs e)
    {
        Class30 class2 = new Class30 {
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
        this.method_20();
    }

    private void method_2()
    {
        string selectCommandText = "select  r.id, r.numin, r.datein,  isnull(r.numIn, '') + ' от ' + isnull(convert( varchar(10),r.DateIn, 104), '') as numDateIn from ttc_request r ";
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
        this.comboBox_2.SelectedValueChanged -= new EventHandler(this.comboBox_2_SelectedValueChanged);
        BindingSource source = new BindingSource {
            DataSource = dataTable,
            Sort = "numIn, dateIn"
        };
        this.comboBox_2.DataSource = source;
        this.comboBox_2.DisplayMember = "numDateIn";
        this.comboBox_2.ValueMember = "id";
        this.comboBox_2.SelectedValueChanged += new EventHandler(this.comboBox_2_SelectedValueChanged);
        if (this.int_1 != -1)
        {
            this.comboBox_2.SelectedValue = this.int_1;
        }
        else
        {
            this.comboBox_2.SelectedIndex = -1;
        }
    }

    private void method_20()
    {
        if (base.InvokeRequired)
        {
            base.Invoke(new Action(this.method_25));
        }
        else
        {
            this.bindingSource_1.ResetBindings(false);
        }
    }

    private void method_21(bool bool_1 = false)
    {
        if (this.bindingSource_1.Current != null)
        {
            byte[] file;
            DataSetTechConnection.Class252 row = (DataSetTechConnection.Class252) ((DataRowView) this.bindingSource_1.Current).Row;
            string fileName = row.FileName;
            string str2 = this.method_18();
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
                        watcher.add_AnyChanged(new FileSystemEventHandler(this.method_19));
                        watcher.Start();
                        this.dictionary_0[fileName].set_Watcher(watcher);
                    }
                    else
                    {
                        this.dictionary_0[fileName].get_Watcher().remove_AnyChanged(new FileSystemEventHandler(this.method_19));
                        this.dictionary_0[fileName].get_Watcher().Stop();
                        FileWatcher watcher2 = new FileWatcher(str2, str3);
                        watcher2.add_AnyChanged(new FileSystemEventHandler(this.method_19));
                        watcher2.Start();
                        this.dictionary_0[fileName].set_Watcher(watcher2);
                    }
                    this.dictionary_0[fileName].set_TempName(str3);
                    this.dictionary_0[fileName].set_OpenState(1);
                }
                else
                {
                    FileWatcher watcher3 = new FileWatcher(str2, str3);
                    watcher3.add_AnyChanged(new FileSystemEventHandler(this.method_19));
                    watcher3.Start();
                    FileWatcherArgsAddl addl = new FileWatcherArgsAddl(nullable, fileName, str3, watcher3, 1);
                    this.dictionary_0.Add(fileName, addl);
                }
            }
        }
    }

    private void method_22(int int_4)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(this.get_SqlSettings().GetConnectionString()))
            {
                connection.Open();
                SqlDataReader reader = new SqlCommand("SELECT id, idDoc, FileName, dateChange, idTemplate FROM tTC_DocFile WHERE idDoc = " + int_4.ToString(), connection).ExecuteReader();
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

    private bool method_23()
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

    private void method_24()
    {
        this.icontainer_0 = new Container();
        DataGridViewCellStyle style = new DataGridViewCellStyle();
        DataGridViewCellStyle style2 = new DataGridViewCellStyle();
        DataGridViewCellStyle style3 = new DataGridViewCellStyle();
        this.label_0 = new Label();
        this.comboBox_0 = new ComboBox();
        this.dataSetTechConnection_0 = new DataSetTechConnection();
        this.label_1 = new Label();
        this.textBox_0 = new TextBox();
        this.nullableDateTimePicker_0 = new NullableDateTimePicker();
        this.button_0 = new Button();
        this.button_1 = new Button();
        this.label_2 = new Label();
        this.textBox_1 = new TextBox();
        this.label_3 = new Label();
        this.label_4 = new Label();
        this.comboBox_1 = new ComboBox();
        this.groupBox_0 = new GroupBox();
        this.tabControl_1 = new TabControl();
        this.tabPage_2 = new TabPage();
        this.toolStrip_0 = new ToolStrip();
        this.toolStripButton_0 = new ToolStripButton();
        this.label_5 = new Label();
        this.textBox_2 = new TextBox();
        this.label_6 = new Label();
        this.comboBox_2 = new ComboBox();
        this.textBox_3 = new TextBox();
        this.label_7 = new Label();
        this.tabPage_3 = new TabPage();
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
        this.radioButton_0 = new RadioButton();
        this.radioButton_1 = new RadioButton();
        this.radioButton_2 = new RadioButton();
        this.tabControl_0 = new TabControl();
        this.tabPage_0 = new TabPage();
        this.tabPage_1 = new TabPage();
        this.dataGridViewExcelFilter_1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
        this.dataGridViewImageColumnNotNull_0 = new DataGridViewImageColumnNotNull();
        this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
        this.dataGridViewTextBoxColumn_18 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_19 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_20 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_21 = new DataGridViewTextBoxColumn();
        this.bindingSource_1 = new BindingSource(this.icontainer_0);
        this.toolStrip_1 = new ToolStrip();
        this.toolStripDropDownButton_0 = new ToolStripDropDownButton();
        this.toolStripMenuItem_0 = new ToolStripMenuItem();
        this.toolStripSeparator_0 = new ToolStripSeparator();
        this.toolStripButton_1 = new ToolStripButton();
        this.toolStripButton_2 = new ToolStripButton();
        this.toolStripButton_3 = new ToolStripButton();
        this.toolStripSeparator_1 = new ToolStripSeparator();
        this.toolStripButton_4 = new ToolStripButton();
        this.toolStripButton_5 = new ToolStripButton();
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
        this.dataSetTechConnection_0.BeginInit();
        this.groupBox_0.SuspendLayout();
        this.tabControl_1.SuspendLayout();
        this.tabPage_2.SuspendLayout();
        this.toolStrip_0.SuspendLayout();
        this.tabPage_3.SuspendLayout();
        this.dataGridViewExcelFilter_0.BeginInit();
        ((ISupportInitialize) this.bindingSource_0).BeginInit();
        this.tabControl_0.SuspendLayout();
        this.tabPage_0.SuspendLayout();
        this.tabPage_1.SuspendLayout();
        this.dataGridViewExcelFilter_1.BeginInit();
        ((ISupportInitialize) this.bindingSource_1).BeginInit();
        this.toolStrip_1.SuspendLayout();
        this.contextMenuStrip_0.SuspendLayout();
        base.SuspendLayout();
        this.label_0.AutoSize = true;
        this.label_0.Location = new Point(6, 0x2a);
        this.label_0.Name = "label1";
        this.label_0.Size = new Size(0x43, 13);
        this.label_0.TabIndex = 0;
        this.label_0.Text = "Тип письма";
        this.comboBox_0.DataBindings.Add(new Binding("SelectedValue", this.dataSetTechConnection_0, "tTC_Doc.TypeDoc", true));
        this.comboBox_0.FormattingEnabled = true;
        this.comboBox_0.Location = new Point(6, 0x3a);
        this.comboBox_0.Name = "cmbTypeMail";
        this.comboBox_0.Size = new Size(0x125, 0x15);
        this.comboBox_0.TabIndex = 1;
        this.comboBox_0.SelectedIndexChanged += new EventHandler(this.comboBox_0_SelectedIndexChanged);
        this.dataSetTechConnection_0.DataSetName = "DataSetTechConnection";
        this.dataSetTechConnection_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        this.label_1.AutoSize = true;
        this.label_1.Location = new Point(6, 3);
        this.label_1.Name = "label2";
        this.label_1.Size = new Size(0x52, 13);
        this.label_1.TabIndex = 2;
        this.label_1.Text = "Номер письма";
        this.textBox_0.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tTC_Doc.numDoc", true));
        this.textBox_0.Location = new Point(6, 0x13);
        this.textBox_0.Name = "txtNumMail";
        this.textBox_0.Size = new Size(0x80, 20);
        this.textBox_0.TabIndex = 3;
        this.textBox_0.TextChanged += new EventHandler(this.textBox_0_TextChanged);
        this.nullableDateTimePicker_0.DataBindings.Add(new Binding("Value", this.dataSetTechConnection_0, "tTC_Doc.dateDoc", true));
        this.nullableDateTimePicker_0.Location = new Point(140, 0x13);
        this.nullableDateTimePicker_0.Name = "dateTimePickerDocOut";
        this.nullableDateTimePicker_0.Size = new Size(0x9f, 20);
        this.nullableDateTimePicker_0.TabIndex = 4;
        this.nullableDateTimePicker_0.set_Value(new DateTime(0x7dd, 4, 0x1d, 14, 0x26, 3, 750));
        this.nullableDateTimePicker_0.ValueChanged += new EventHandler(this.nullableDateTimePicker_0_ValueChanged);
        this.button_0.DialogResult = DialogResult.OK;
        this.button_0.Location = new Point(14, 0x174);
        this.button_0.Name = "buttonOK";
        this.button_0.Size = new Size(0x4b, 0x17);
        this.button_0.TabIndex = 11;
        this.button_0.Text = "Сохранить";
        this.button_0.UseVisualStyleBackColor = true;
        this.button_0.Click += new EventHandler(this.button_0_Click);
        this.button_1.DialogResult = DialogResult.Cancel;
        this.button_1.Location = new Point(0x2df, 0x174);
        this.button_1.Name = "buttonCancel";
        this.button_1.Size = new Size(0x4b, 0x17);
        this.button_1.TabIndex = 12;
        this.button_1.Text = "Закрыть";
        this.button_1.UseVisualStyleBackColor = true;
        this.button_1.Click += new EventHandler(this.button_1_Click);
        this.label_2.AutoSize = true;
        this.label_2.Location = new Point(13, 0xea);
        this.label_2.Name = "label7";
        this.label_2.Size = new Size(70, 13);
        this.label_2.TabIndex = 5;
        this.label_2.Text = "Содержание";
        this.textBox_1.AcceptsReturn = true;
        this.textBox_1.AcceptsTab = true;
        this.textBox_1.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tTC_Doc.Body", true));
        this.textBox_1.Location = new Point(9, 250);
        this.textBox_1.Multiline = true;
        this.textBox_1.Name = "txtBody";
        this.textBox_1.Size = new Size(0x319, 0x54);
        this.textBox_1.TabIndex = 6;
        this.textBox_1.TextChanged += new EventHandler(this.textBox_1_TextChanged);
        this.label_3.AutoSize = true;
        this.label_3.Location = new Point(0x89, 3);
        this.label_3.Name = "label3";
        this.label_3.Size = new Size(0x4a, 13);
        this.label_3.TabIndex = 0x11;
        this.label_3.Text = "Дата письма";
        this.label_4.AutoSize = true;
        this.label_4.Location = new Point(0x131, 3);
        this.label_4.Name = "label8";
        this.label_4.Size = new Size(0x4a, 13);
        this.label_4.TabIndex = 0x12;
        this.label_4.Text = "Исполнитель";
        this.comboBox_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.comboBox_1.DataBindings.Add(new Binding("SelectedValue", this.dataSetTechConnection_0, "tTC_Mail.Performer", true));
        this.comboBox_1.FormattingEnabled = true;
        this.comboBox_1.Location = new Point(0x131, 0x12);
        this.comboBox_1.Name = "cmbPerformer";
        this.comboBox_1.Size = new Size(0x1f5, 0x15);
        this.comboBox_1.TabIndex = 0x13;
        this.comboBox_1.SelectedIndexChanged += new EventHandler(this.comboBox_1_SelectedIndexChanged);
        this.groupBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.groupBox_0.Controls.Add(this.tabControl_1);
        this.groupBox_0.Controls.Add(this.radioButton_0);
        this.groupBox_0.Controls.Add(this.radioButton_1);
        this.groupBox_0.Controls.Add(this.radioButton_2);
        this.groupBox_0.Location = new Point(6, 0x4e);
        this.groupBox_0.Name = "groupBoxLinkDoc";
        this.groupBox_0.Size = new Size(800, 0x99);
        this.groupBox_0.TabIndex = 20;
        this.groupBox_0.TabStop = false;
        this.groupBox_0.Text = "Привязка к документу";
        this.tabControl_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.tabControl_1.Controls.Add(this.tabPage_2);
        this.tabControl_1.Controls.Add(this.tabPage_3);
        this.tabControl_1.Location = new Point(0, 0x2a);
        this.tabControl_1.Name = "tabControlRequest";
        this.tabControl_1.SelectedIndex = 0;
        this.tabControl_1.Size = new Size(800, 0x6f);
        this.tabControl_1.TabIndex = 0x17;
        this.tabPage_2.Controls.Add(this.toolStrip_0);
        this.tabPage_2.Controls.Add(this.label_5);
        this.tabPage_2.Controls.Add(this.textBox_2);
        this.tabPage_2.Controls.Add(this.label_6);
        this.tabPage_2.Controls.Add(this.comboBox_2);
        this.tabPage_2.Controls.Add(this.textBox_3);
        this.tabPage_2.Controls.Add(this.label_7);
        this.tabPage_2.Location = new Point(4, 0x16);
        this.tabPage_2.Name = "tabPage1";
        this.tabPage_2.Padding = new Padding(3);
        this.tabPage_2.Size = new Size(0x318, 0x55);
        this.tabPage_2.TabIndex = 0;
        this.tabPage_2.Text = "Выбор документа";
        this.tabPage_2.UseVisualStyleBackColor = true;
        this.toolStrip_0.Anchor = AnchorStyles.Right | AnchorStyles.Top;
        this.toolStrip_0.Dock = DockStyle.None;
        this.toolStrip_0.GripStyle = ToolStripGripStyle.Hidden;
        ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripButton_0 };
        this.toolStrip_0.Items.AddRange(toolStripItems);
        this.toolStrip_0.Location = new Point(0x93, 10);
        this.toolStrip_0.Name = "toolStrip1";
        this.toolStrip_0.Size = new Size(0x1a, 0x19);
        this.toolStrip_0.TabIndex = 10;
        this.toolStrip_0.Text = "toolStrip1";
        this.toolStrip_0.Visible = false;
        this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_0.Image = Resources.partners;
        this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
        this.toolStripButton_0.Name = "toolBtnContractor";
        this.toolStripButton_0.Size = new Size(0x17, 0x16);
        this.toolStripButton_0.Text = "Выбрать контрагента";
        this.toolStripButton_0.Click += new EventHandler(this.toolStripButton_0_Click);
        this.label_5.AutoSize = true;
        this.label_5.Location = new Point(6, 0x3f);
        this.label_5.Name = "label5";
        this.label_5.Size = new Size(0x2d, 13);
        this.label_5.TabIndex = 4;
        this.label_5.Text = "Объект";
        this.textBox_2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.textBox_2.BackColor = SystemColors.Window;
        this.textBox_2.Location = new Point(0x92, 60);
        this.textBox_2.Name = "txtAbnObj";
        this.textBox_2.ReadOnly = true;
        this.textBox_2.Size = new Size(640, 20);
        this.textBox_2.TabIndex = 5;
        this.label_6.AutoSize = true;
        this.label_6.Location = new Point(6, 13);
        this.label_6.Name = "labelNumDateIn";
        this.label_6.Size = new Size(0x86, 13);
        this.label_6.TabIndex = 0;
        this.label_6.Text = "Номер и дата входящего";
        this.comboBox_2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.comboBox_2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        this.comboBox_2.AutoCompleteSource = AutoCompleteSource.ListItems;
        this.comboBox_2.DataBindings.Add(new Binding("SelectedValue", this.dataSetTechConnection_0, "tTC_DocOut.idDoc", true));
        this.comboBox_2.FormattingEnabled = true;
        this.comboBox_2.Location = new Point(0x92, 10);
        this.comboBox_2.Name = "cmbNumDateIn";
        this.comboBox_2.Size = new Size(640, 0x15);
        this.comboBox_2.TabIndex = 1;
        this.comboBox_2.SelectedValueChanged += new EventHandler(this.comboBox_2_SelectedValueChanged);
        this.textBox_3.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.textBox_3.BackColor = SystemColors.Window;
        this.textBox_3.Location = new Point(0x92, 0x24);
        this.textBox_3.Name = "txtAbn";
        this.textBox_3.ReadOnly = true;
        this.textBox_3.Size = new Size(640, 20);
        this.textBox_3.TabIndex = 3;
        this.label_7.AutoSize = true;
        this.label_7.Location = new Point(6, 0x27);
        this.label_7.Name = "label9";
        this.label_7.Size = new Size(0x31, 13);
        this.label_7.TabIndex = 2;
        this.label_7.Text = "Абонент";
        this.tabPage_3.Controls.Add(this.dataGridViewExcelFilter_0);
        this.tabPage_3.Location = new Point(4, 0x16);
        this.tabPage_3.Name = "tabPagerequestHistory";
        this.tabPage_3.Padding = new Padding(3);
        this.tabPage_3.Size = new Size(0x318, 0x55);
        this.tabPage_3.TabIndex = 1;
        this.tabPage_3.Text = "История заявок";
        this.tabPage_3.UseVisualStyleBackColor = true;
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
        this.dataGridViewExcelFilter_0.Size = new Size(0x312, 0x4f);
        this.dataGridViewExcelFilter_0.TabIndex = 5;
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
        this.bindingSource_0.DataSource = this.dataSetTechConnection_0;
        this.radioButton_0.AutoSize = true;
        this.radioButton_0.Location = new Point(0x120, 0x13);
        this.radioButton_0.Name = "radioButtonNoDoc";
        this.radioButton_0.Size = new Size(0x5f, 0x11);
        this.radioButton_0.TabIndex = 2;
        this.radioButton_0.Text = "Без привязки";
        this.radioButton_0.UseVisualStyleBackColor = true;
        this.radioButton_0.CheckedChanged += new EventHandler(this.radioButton_0_CheckedChanged);
        this.radioButton_1.AutoSize = true;
        this.radioButton_1.Location = new Point(0xc1, 0x13);
        this.radioButton_1.Name = "radioButtonTU";
        this.radioButton_1.Size = new Size(0x57, 0x11);
        this.radioButton_1.TabIndex = 1;
        this.radioButton_1.Text = "Тех условие";
        this.radioButton_1.UseVisualStyleBackColor = true;
        this.radioButton_1.CheckedChanged += new EventHandler(this.radioButton_1_CheckedChanged);
        this.radioButton_2.AutoSize = true;
        this.radioButton_2.Checked = true;
        this.radioButton_2.Location = new Point(10, 0x13);
        this.radioButton_2.Name = "radioButtonRequest";
        this.radioButton_2.Size = new Size(0xb1, 0x11);
        this.radioButton_2.TabIndex = 0;
        this.radioButton_2.TabStop = true;
        this.radioButton_2.Text = "Заявка на тех присоединение";
        this.radioButton_2.UseVisualStyleBackColor = true;
        this.radioButton_2.CheckedChanged += new EventHandler(this.radioButton_2_CheckedChanged);
        this.tabControl_0.Controls.Add(this.tabPage_0);
        this.tabControl_0.Controls.Add(this.tabPage_1);
        this.tabControl_0.Location = new Point(0, 0);
        this.tabControl_0.Name = "tabControl";
        this.tabControl_0.SelectedIndex = 0;
        this.tabControl_0.Size = new Size(820, 0x16e);
        this.tabControl_0.TabIndex = 0x15;
        this.tabPage_0.Controls.Add(this.label_1);
        this.tabPage_0.Controls.Add(this.textBox_1);
        this.tabPage_0.Controls.Add(this.groupBox_0);
        this.tabPage_0.Controls.Add(this.label_2);
        this.tabPage_0.Controls.Add(this.label_0);
        this.tabPage_0.Controls.Add(this.comboBox_1);
        this.tabPage_0.Controls.Add(this.comboBox_0);
        this.tabPage_0.Controls.Add(this.label_4);
        this.tabPage_0.Controls.Add(this.textBox_0);
        this.tabPage_0.Controls.Add(this.label_3);
        this.tabPage_0.Controls.Add(this.nullableDateTimePicker_0);
        this.tabPage_0.Location = new Point(4, 0x16);
        this.tabPage_0.Name = "tabPageGeneral";
        this.tabPage_0.Padding = new Padding(3);
        this.tabPage_0.Size = new Size(0x32c, 340);
        this.tabPage_0.TabIndex = 0;
        this.tabPage_0.Text = "Общие";
        this.tabPage_0.UseVisualStyleBackColor = true;
        this.tabPage_1.Controls.Add(this.dataGridViewExcelFilter_1);
        this.tabPage_1.Controls.Add(this.toolStrip_1);
        this.tabPage_1.Location = new Point(4, 0x16);
        this.tabPage_1.Name = "tabPageFiles";
        this.tabPage_1.Padding = new Padding(3);
        this.tabPage_1.Size = new Size(0x32c, 340);
        this.tabPage_1.TabIndex = 1;
        this.tabPage_1.Text = "Файлы";
        this.tabPage_1.UseVisualStyleBackColor = true;
        this.dataGridViewExcelFilter_1.AllowUserToAddRows = false;
        this.dataGridViewExcelFilter_1.AllowUserToDeleteRows = false;
        this.dataGridViewExcelFilter_1.AllowUserToResizeColumns = false;
        this.dataGridViewExcelFilter_1.AllowUserToResizeRows = false;
        this.dataGridViewExcelFilter_1.AutoGenerateColumns = false;
        this.dataGridViewExcelFilter_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DataGridViewColumn[] columnArray2 = new DataGridViewColumn[] { this.dataGridViewImageColumnNotNull_0, this.dataGridViewFilterTextBoxColumn_0, this.dataGridViewTextBoxColumn_18, this.dataGridViewTextBoxColumn_19, this.dataGridViewTextBoxColumn_20, this.dataGridViewTextBoxColumn_21 };
        this.dataGridViewExcelFilter_1.Columns.AddRange(columnArray2);
        this.dataGridViewExcelFilter_1.DataSource = this.bindingSource_1;
        this.dataGridViewExcelFilter_1.Dock = DockStyle.Fill;
        this.dataGridViewExcelFilter_1.EditMode = DataGridViewEditMode.EditProgrammatically;
        this.dataGridViewExcelFilter_1.Location = new Point(3, 0x1c);
        this.dataGridViewExcelFilter_1.Name = "dgvFile";
        this.dataGridViewExcelFilter_1.ReadOnly = true;
        this.dataGridViewExcelFilter_1.RowHeadersVisible = false;
        this.dataGridViewExcelFilter_1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        this.dataGridViewExcelFilter_1.Size = new Size(0x326, 0x135);
        this.dataGridViewExcelFilter_1.TabIndex = 7;
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
        this.bindingSource_1.DataMember = "tTC_DocFile";
        this.bindingSource_1.DataSource = this.dataSetTechConnection_0;
        ToolStripItem[] itemArray2 = new ToolStripItem[] { this.toolStripDropDownButton_0, this.toolStripButton_1, this.toolStripButton_2, this.toolStripButton_3, this.toolStripSeparator_1, this.toolStripButton_4, this.toolStripButton_5 };
        this.toolStrip_1.Items.AddRange(itemArray2);
        this.toolStrip_1.Location = new Point(3, 3);
        this.toolStrip_1.Name = "toolStripFile";
        this.toolStrip_1.Size = new Size(0x326, 0x19);
        this.toolStrip_1.TabIndex = 1;
        this.toolStrip_1.Text = "toolStrip1";
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
        this.toolStripMenuItem_0.Click += new EventHandler(this.toolStripMenuItem_2_Click);
        this.toolStripSeparator_0.Name = "toolStripSeparator2";
        this.toolStripSeparator_0.Size = new Size(0xbb, 6);
        this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_1.Image = Resources.ElementEdit;
        this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
        this.toolStripButton_1.Name = "toolBtnEditFile";
        this.toolStripButton_1.Size = new Size(0x17, 0x16);
        this.toolStripButton_1.Text = "Редактировать файл";
        this.toolStripButton_1.Click += new EventHandler(this.toolStripMenuItem_3_Click);
        this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_2.Image = Resources.ElementInformation;
        this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
        this.toolStripButton_2.Name = "toolBtnOpenFile";
        this.toolStripButton_2.Size = new Size(0x17, 0x16);
        this.toolStripButton_2.Text = "Открыть файл";
        this.toolStripButton_2.Click += new EventHandler(this.toolStripMenuItem_4_Click);
        this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_3.Image = Resources.ElementDel;
        this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
        this.toolStripButton_3.Name = "toolBtnDelFile";
        this.toolStripButton_3.Size = new Size(0x17, 0x16);
        this.toolStripButton_3.Text = "Удалить файл";
        this.toolStripButton_3.Click += new EventHandler(this.toolStripMenuItem_5_Click);
        this.toolStripSeparator_1.Name = "toolStripSeparator3";
        this.toolStripSeparator_1.Size = new Size(6, 0x19);
        this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_4.Image = Resources.rename;
        this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
        this.toolStripButton_4.Name = "toolBtnRenameFile";
        this.toolStripButton_4.Size = new Size(0x17, 0x16);
        this.toolStripButton_4.Text = "Переименовать";
        this.toolStripButton_4.Click += new EventHandler(this.toolStripMenuItem_6_Click);
        this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_5.Image = Resources.save;
        this.toolStripButton_5.ImageTransparentColor = Color.Magenta;
        this.toolStripButton_5.Name = "toolBtnSaveFile";
        this.toolStripButton_5.Size = new Size(0x17, 0x16);
        this.toolStripButton_5.Text = "Сохранить файл на диск";
        this.toolStripButton_5.Click += new EventHandler(this.toolStripMenuItem_7_Click);
        ToolStripItem[] itemArray4 = new ToolStripItem[] { this.toolStripMenuItem_1, this.toolStripMenuItem_3, this.toolStripMenuItem_4, this.toolStripMenuItem_5, this.toolStripSeparator_3, this.toolStripMenuItem_6, this.toolStripMenuItem_7 };
        this.contextMenuStrip_0.Items.AddRange(itemArray4);
        this.contextMenuStrip_0.Name = "contextMenuFile";
        this.contextMenuStrip_0.Size = new Size(0xb1, 0xa4);
        ToolStripItem[] itemArray5 = new ToolStripItem[] { this.toolStripMenuItem_2, this.toolStripSeparator_2 };
        this.toolStripMenuItem_1.DropDownItems.AddRange(itemArray5);
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
        base.ClientSize = new Size(0x335, 0x192);
        base.Controls.Add(this.tabControl_0);
        base.Controls.Add(this.button_1);
        base.Controls.Add(this.button_0);
        base.Name = "FormMailTUAddEdit";
        this.Text = "FormTechConnectionDocOutAddEdit";
        base.FormClosing += new FormClosingEventHandler(this.Form11_FormClosing);
        base.Load += new EventHandler(this.Form11_Load);
        this.dataSetTechConnection_0.EndInit();
        this.groupBox_0.ResumeLayout(false);
        this.groupBox_0.PerformLayout();
        this.tabControl_1.ResumeLayout(false);
        this.tabPage_2.ResumeLayout(false);
        this.tabPage_2.PerformLayout();
        this.toolStrip_0.ResumeLayout(false);
        this.toolStrip_0.PerformLayout();
        this.tabPage_3.ResumeLayout(false);
        this.dataGridViewExcelFilter_0.EndInit();
        ((ISupportInitialize) this.bindingSource_0).EndInit();
        this.tabControl_0.ResumeLayout(false);
        this.tabPage_0.ResumeLayout(false);
        this.tabPage_0.PerformLayout();
        this.tabPage_1.ResumeLayout(false);
        this.tabPage_1.PerformLayout();
        this.dataGridViewExcelFilter_1.EndInit();
        ((ISupportInitialize) this.bindingSource_1).EndInit();
        this.toolStrip_1.ResumeLayout(false);
        this.toolStrip_1.PerformLayout();
        this.contextMenuStrip_0.ResumeLayout(false);
        base.ResumeLayout(false);
    }

    [CompilerGenerated]
    private void method_25()
    {
        this.bindingSource_1.ResetBindings(false);
    }

    private void method_3()
    {
        string selectCommandText = "select  d.id, d.numdoc, d.datedoc,  isnull(d.numdoc, '') + ' от ' + isnull(convert( varchar(10),d.Datedoc, 104), '') as numDatedoc  from ttc_doc d  where typeDoc = " + 0x463.ToString() + " order by numDoc, dateDoc ";
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
        this.comboBox_2.SelectedValueChanged -= new EventHandler(this.comboBox_2_SelectedValueChanged);
        BindingSource source = new BindingSource {
            DataSource = dataTable,
            Sort = "numDoc, dateDoc"
        };
        this.comboBox_2.DataSource = source;
        this.comboBox_2.DisplayMember = "numDateDoc";
        this.comboBox_2.ValueMember = "id";
        this.comboBox_2.SelectedValueChanged += new EventHandler(this.comboBox_2_SelectedValueChanged);
        if (this.int_1 != -1)
        {
            this.comboBox_2.SelectedValue = this.int_1;
        }
        else
        {
            this.comboBox_2.SelectedIndex = -1;
        }
    }

    private void method_4(int int_4)
    {
        DataSetTechConnection.tTC_DocDataTable table = new DataSetTechConnection.tTC_DocDataTable();
        base.SelectSqlData(table, true, " where id = " + int_4.ToString(), false);
        if (table.Rows.Count <= 0)
        {
            this.int_3 = -1;
            this.int_2 = -1;
            this.textBox_3.Text = this.textBox_2.Text = "";
            this.dataSetTechConnection_0.vTC_RequestHistory.Clear();
        }
        else
        {
            int num = Convert.ToInt32(table.Rows[0]["TypeDoc"]);
            int num2 = -1;
            switch (num)
            {
                case 0x459:
                case 0x4b3:
                    num2 = int_4;
                    break;

                case 0x463:
                {
                    DataSetTechConnection.vTC_TUDataTable table2 = new DataSetTechConnection.vTC_TUDataTable();
                    base.SelectSqlData(table2, true, " where id = " + int_4.ToString(), false);
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
                        this.textBox_3.Text = table5.Rows[0]["name"].ToString();
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
                base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vTC_RequestHistory, true, "where id = " + num2.ToString() + " or IdParent = " + num2.ToString() + " order by dateDoc");
            }
            else
            {
                this.int_3 = -1;
                this.int_2 = -1;
                this.textBox_3.Text = this.textBox_2.Text = "";
                this.dataSetTechConnection_0.vTC_RequestHistory.Clear();
            }
        }
    }

    private void method_5(object object_0, object object_1)
    {
        if (object_0 != DBNull.Value)
        {
            object_0 = Convert.ToInt32(object_0);
            DataSetTechConnection.tAbnDataTable table = new DataSetTechConnection.tAbnDataTable();
            base.SelectSqlData(table, true, "where id = " + object_0.ToString(), false);
            if (table.Rows.Count > 0)
            {
                this.textBox_3.Text = table.Rows[0]["name"].ToString();
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
                            this.textBox_2.Text = table2.Rows[0]["name"].ToString();
                        }
                        else
                        {
                            this.textBox_2.Text = table2.Rows[0]["AddressFL"].ToString();
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
    }

    private void method_6()
    {
        DataRow row = this.dataSetTechConnection_0.tTC_Doc.NewRow();
        row["TypeDoc"] = 0x4c2;
        this.dataSetTechConnection_0.tTC_Doc.Rows.Add(row);
        DataRow row2 = this.dataSetTechConnection_0.tTC_Mail.NewRow();
        row2["id"] = this.int_0;
        this.dataSetTechConnection_0.tTC_Mail.Rows.Add(row2);
    }

    private bool method_7()
    {
        if (string.IsNullOrEmpty(this.textBox_0.Text))
        {
            MessageBox.Show("Не заполнен номер письма");
            return false;
        }
        if (this.comboBox_0.SelectedIndex < 0)
        {
            MessageBox.Show("Не выбран тип документа");
            return false;
        }
        if (this.comboBox_1.SelectedIndex < 0)
        {
            MessageBox.Show("Не выбран исполнитель");
            return false;
        }
        if (this.comboBox_2.SelectedIndex < 0)
        {
            if (this.radioButton_2.Checked)
            {
                MessageBox.Show("Не выбрана заявка");
                return false;
            }
            if (this.radioButton_2.Checked)
            {
                MessageBox.Show("Не выбрано тех условие");
                return false;
            }
        }
        return true;
    }

    private bool method_8()
    {
        if (!this.method_7())
        {
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
            base.SelectSqlData(this.dataSetTechConnection_0.tTC_Doc, true, " where id = " + this.int_0.ToString(), false);
        }
        else if (!base.UpdateSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Doc))
        {
            return false;
        }
        if (!this.method_9())
        {
            return false;
        }
        if (!this.method_10())
        {
            return false;
        }
        if (!this.method_23())
        {
            return false;
        }
        this.bool_0 = false;
        MessageBox.Show("Данные успешно сохранены.");
        return true;
    }

    private bool method_9()
    {
        if (this.radioButton_0.Checked)
        {
            if (this.dataSetTechConnection_0.tTC_DocOut.Rows.Count > 0)
            {
                this.dataSetTechConnection_0.tTC_DocOut.Rows[0].Delete();
                if (!base.DeleteSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_DocOut))
                {
                    return false;
                }
                this.dataSetTechConnection_0.tTC_DocOut.Clear();
            }
        }
        else if (this.dataSetTechConnection_0.tTC_DocOut.Rows.Count > 0)
        {
            this.dataSetTechConnection_0.tTC_DocOut.Rows[0]["idDoc"] = this.int_1;
            this.dataSetTechConnection_0.tTC_DocOut.Rows[0]["idDocOut"] = this.int_0;
            this.dataSetTechConnection_0.tTC_DocOut.Rows[0].EndEdit();
            if (this.dataSetTechConnection_0.tTC_DocOut.Rows[0].RowState != DataRowState.Added)
            {
                if (!base.UpdateSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_DocOut))
                {
                    return false;
                }
            }
            else
            {
                int num = base.InsertSqlDataOneRow(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_DocOut);
                if (num == -1)
                {
                    return false;
                }
                base.SelectSqlData(this.dataSetTechConnection_0.tTC_DocOut, true, "where id = " + num.ToString(), false);
            }
        }
        else
        {
            DataRow row = this.dataSetTechConnection_0.tTC_DocOut.NewRow();
            row["idDoc"] = this.int_1;
            row["idDocOut"] = this.int_0;
            this.dataSetTechConnection_0.tTC_DocOut.Rows.Add(row);
            int num2 = base.InsertSqlDataOneRow(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_DocOut);
            if (num2 == -1)
            {
                return false;
            }
            base.SelectSqlData(this.dataSetTechConnection_0.tTC_DocOut, true, "where id = " + num2.ToString(), false);
        }
        return true;
    }

    private void nullableDateTimePicker_0_ValueChanged(object sender, EventArgs e)
    {
        this.bool_0 = true;
    }

    private void radioButton_0_CheckedChanged(object sender, EventArgs e)
    {
        if (this.radioButton_0.Checked)
        {
            this.label_6.Text = "Выбор контрагента";
            this.comboBox_2.Visible = false;
            this.toolStrip_0.Visible = true;
            this.bool_0 = true;
        }
    }

    private void radioButton_1_CheckedChanged(object sender, EventArgs e)
    {
        if (this.radioButton_1.Checked)
        {
            this.label_6.Text = "Номер и дата ТУ";
            this.comboBox_2.Visible = true;
            this.toolStrip_0.Visible = false;
            this.method_3();
            this.bool_0 = true;
        }
    }

    private void radioButton_2_CheckedChanged(object sender, EventArgs e)
    {
        if (this.radioButton_2.Checked)
        {
            this.label_6.Text = "Номер и дата входящего";
            this.comboBox_2.Visible = true;
            this.toolStrip_0.Visible = false;
            this.method_2();
            this.bool_0 = true;
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

    private void toolStripButton_0_Click(object sender, EventArgs e)
    {
        FormTechConnectionAddAbn abn1 = new FormTechConnectionAddAbn(this.int_2, this.int_3, true);
        abn1.add_ShowForm(new ShowFormEventHandler(this, this.method_12));
        abn1.set_SqlSettings(this.get_SqlSettings());
        abn1.MdiParent = base.MdiParent;
        abn1.FormClosed += new FormClosedEventHandler(this.method_11);
        abn1.Show();
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
                if (!string.IsNullOrEmpty(this.method_15(str, nullable, null)))
                {
                    this.bool_0 = true;
                }
            }
        }
    }

    private void toolStripMenuItem_3_Click(object sender, EventArgs e)
    {
        this.method_21(true);
    }

    private void toolStripMenuItem_4_Click(object sender, EventArgs e)
    {
        this.method_21(false);
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
                    this.dictionary_0[fileName].get_Watcher().remove_AnyChanged(new FileSystemEventHandler(this.method_19));
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
                this.method_14(dialog.FileName, file);
            }
        }
    }

    [CompilerGenerated]
    private sealed class Class30
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

