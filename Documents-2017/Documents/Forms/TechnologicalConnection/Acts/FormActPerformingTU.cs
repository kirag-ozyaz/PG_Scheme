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

    public class FormActPerformingTU : FormBase
    {
        private BindingSource bindingSource_0;
        private bool bool_0;
        private Button button_0;
        private Button button_1;
        private ComboBox comboBox_0;
        private ContextMenuStrip contextMenuStrip_0;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_0;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;
        private DataGridViewImageColumnNotNull dataGridViewImageColumnNotNull_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;
        private DataSetTechConnection dataSetTechConnection_0;
        private Dictionary<string, FileWatcherArgsAddl> dictionary_0;
        private GroupBox groupBox_0;
        private GroupBox groupBox_1;
        private IContainer icontainer_0;
        private int int_0;
        private int int_1;
        private int int_2;
        private int int_3;
        private int int_4;
        private Label label_0;
        private Label label_1;
        private Label label_2;
        private Label label_3;
        private Label label_4;
        private Label label_5;
        private Label label_6;
        private Label label_7;
        private Label label_8;
        private Label label_9;
        private NullableDateTimePicker nullableDateTimePicker_0;
        private string string_0;
        private TabControl tabControl_0;
        private TabPage tabPage_0;
        private TabPage tabPage_1;
        private TextBox textBox_0;
        private TextBox textBox_1;
        private TextBox textBox_2;
        private TextBox textBox_3;
        private TextBox textBox_4;
        private TextBox textBox_5;
        private TextBox textBox_6;
        private TextBox textBox_7;
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

        public FormActPerformingTU()
        {
            this.int_0 = -1;
            this.int_1 = -1;
            this.int_2 = -1;
            this.int_3 = -1;
            this.int_4 = 0x4d7;
            this.dictionary_0 = new Dictionary<string, FileWatcherArgsAddl>();
            this.string_0 = "";
            this.method_17();
            this.method_0();
        }

        public FormActPerformingTU(int idAct, int idTU = -1, int typeAct = 0x4d7)
        {
            this.int_0 = -1;
            this.int_1 = -1;
            this.int_2 = -1;
            this.int_3 = -1;
            this.int_4 = 0x4d7;
            this.dictionary_0 = new Dictionary<string, FileWatcherArgsAddl>();
            this.string_0 = "";
            this.method_17();
            this.int_0 = idAct;
            this.int_1 = idTU;
            this.int_4 = typeAct;
            this.method_0();
        }

        protected override void ApplyConfig(XmlDocument xmlDocument_0)
        {
            XmlNode node = xmlDocument_0.SelectSingleNode(base.Name);
            if (node != null)
            {
                XmlNode node2 = node.SelectSingleNode("NetWork");
                if (node2 != null)
                {
                    XmlAttribute attribute = node2.Attributes["Face"];
                    if (attribute != null)
                    {
                        if (this.dataSetTechConnection_0.tTC_PerformingTU.Rows.Count > 0)
                        {
                            this.dataSetTechConnection_0.tTC_PerformingTU.Rows[0]["FaceNetWork"] = attribute.Value;
                        }
                        else
                        {
                            this.textBox_7.Text = attribute.Value;
                        }
                    }
                    attribute = node2.Attributes["Basis"];
                    if (attribute != null)
                    {
                        if (this.dataSetTechConnection_0.tTC_PerformingTU.Rows.Count > 0)
                        {
                            this.dataSetTechConnection_0.tTC_PerformingTU.Rows[0]["BasisNetWork"] = attribute.Value;
                        }
                        else
                        {
                            this.textBox_6.Text = attribute.Value;
                        }
                    }
                }
            }
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            if (this.method_5())
            {
                base.Close();
            }
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            if (this.bool_0)
            {
                DialogResult result1 = MessageBox.Show("Документ был изменен. Сохранить документ?", "Сохранение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if ((result1 == DialogResult.Yes) && this.method_5())
                {
                    base.Close();
                }
                if (result1 == DialogResult.No)
                {
                    base.Close();
                }
            }
            else
            {
                base.Close();
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

        protected override XmlDocument CreateXmlConfig()
        {
            XmlDocument document1 = new XmlDocument();
            XmlNode newChild = document1.CreateElement(base.Name);
            document1.AppendChild(newChild);
            XmlNode node2 = document1.CreateElement("NetWork");
            newChild.AppendChild(node2);
            XmlAttribute node = document1.CreateAttribute("Face");
            node.Value = this.textBox_7.Text;
            node2.Attributes.Append(node);
            node = document1.CreateAttribute("Basis");
            node.Value = this.textBox_6.Text;
            node2.Attributes.Append(node);
            return document1;
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

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormActPerformingTU_FormClosed(object sender, FormClosedEventArgs e)
        {
            base.SaveFormConfig(null);
        }

        private void FormActPerformingTU_Load(object sender, EventArgs e)
        {
            this.method_2();
            if (this.int_0 == -1)
            {
                DataRow row = this.dataSetTechConnection_0.tTC_Doc.NewRow();
                row["DateDoc"] = DateTime.Now.Date;
                row["TypeDoc"] = this.int_4;
                row["idParent"] = this.int_1;
                this.dataSetTechConnection_0.tTC_Doc.Rows.Add(row);
                this.method_1();
            }
            else
            {
                base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Doc, true, "where id = " + this.int_0.ToString());
                base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_PerformingTU, true, "where id = " + this.int_0.ToString());
                if (this.dataSetTechConnection_0.tTC_PerformingTU.Rows.Count == 0)
                {
                    this.method_1();
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
            this.Text = (this.int_0 == -1) ? "Добавление акта выполнения ТУ" : "Редактирование акта выполнения ТУ";
        }

        private void method_1()
        {
            DataRow row = this.dataSetTechConnection_0.tTC_PerformingTU.NewRow();
            row["id"] = this.int_0;
            this.dataSetTechConnection_0.tTC_PerformingTU.Rows.Add(row);
            base.LoadFormConfig(null);
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
            Class290 class2 = new Class290 {
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
            Class291 class2 = new Class291 {
                string_0 = string_1
            };
            return (this.dataSetTechConnection_0.tTC_DocFile.Where<DataSetTechConnection.Class252>(new Func<DataSetTechConnection.Class252, bool>(class2.method_0)).Count<DataSetTechConnection.Class252>() > 0);
        }

        private void method_13()
        {
            if (base.InvokeRequired)
            {
                base.Invoke(new Action(this.method_18));
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

        private void method_17()
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
            this.groupBox_0 = new GroupBox();
            this.textBox_4 = new TextBox();
            this.label_6 = new Label();
            this.textBox_5 = new TextBox();
            this.label_7 = new Label();
            this.groupBox_1 = new GroupBox();
            this.textBox_6 = new TextBox();
            this.label_8 = new Label();
            this.textBox_7 = new TextBox();
            this.label_9 = new Label();
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
            this.tabControl_0.SuspendLayout();
            this.tabPage_0.SuspendLayout();
            this.groupBox_0.SuspendLayout();
            this.groupBox_1.SuspendLayout();
            this.tabPage_1.SuspendLayout();
            this.dataGridViewExcelFilter_0.BeginInit();
            ((ISupportInitialize) this.bindingSource_0).BeginInit();
            this.toolStrip_0.SuspendLayout();
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
            this.label_2.Location = new Point(12, 0x65);
            this.label_2.Name = "label5";
            this.label_2.Size = new Size(0x2d, 13);
            this.label_2.TabIndex = 0x1a;
            this.label_2.Text = "Объект";
            this.textBox_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_1.BackColor = SystemColors.Window;
            this.textBox_1.Location = new Point(0x91, 0x62);
            this.textBox_1.Name = "txtAbnObj";
            this.textBox_1.ReadOnly = true;
            this.textBox_1.Size = new Size(0x1df, 20);
            this.textBox_1.TabIndex = 0x1b;
            this.label_3.AutoSize = true;
            this.label_3.Location = new Point(12, 0x33);
            this.label_3.Name = "labelNumDateIn";
            this.label_3.Size = new Size(0x5e, 13);
            this.label_3.TabIndex = 0x16;
            this.label_3.Text = "Номер и дата ТУ";
            this.comboBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.comboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox_0.DataBindings.Add(new Binding("SelectedValue", this.dataSetTechConnection_0, "tTC_Doc.IdParent", true));
            this.comboBox_0.FormattingEnabled = true;
            this.comboBox_0.Location = new Point(0x91, 0x30);
            this.comboBox_0.Name = "cmbNumDateIn";
            this.comboBox_0.Size = new Size(0x1df, 0x15);
            this.comboBox_0.TabIndex = 0x17;
            this.comboBox_0.SelectedValueChanged += new EventHandler(this.comboBox_0_SelectedValueChanged);
            this.textBox_2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_2.BackColor = SystemColors.Window;
            this.textBox_2.Location = new Point(0x91, 0x4a);
            this.textBox_2.Name = "txtAbn";
            this.textBox_2.ReadOnly = true;
            this.textBox_2.Size = new Size(0x1df, 20);
            this.textBox_2.TabIndex = 0x19;
            this.label_4.AutoSize = true;
            this.label_4.Location = new Point(12, 0x4d);
            this.label_4.Name = "label9";
            this.label_4.Size = new Size(0x31, 13);
            this.label_4.TabIndex = 0x18;
            this.label_4.Text = "Абонент";
            this.textBox_3.AcceptsReturn = true;
            this.textBox_3.AcceptsTab = true;
            this.textBox_3.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.textBox_3.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tTC_Doc.Comment", true));
            this.textBox_3.Location = new Point(8, 0x11d);
            this.textBox_3.Multiline = true;
            this.textBox_3.Name = "txtBody";
            this.textBox_3.Size = new Size(0x26b, 0x34);
            this.textBox_3.TabIndex = 0x1d;
            this.textBox_3.TextChanged += new EventHandler(this.textBox_3_TextChanged);
            this.label_5.AutoSize = true;
            this.label_5.Location = new Point(12, 0x10d);
            this.label_5.Name = "label7";
            this.label_5.Size = new Size(0x4d, 13);
            this.label_5.TabIndex = 0x1c;
            this.label_5.Text = "Комментарий";
            this.button_0.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.button_0.Location = new Point(9, 0x17e);
            this.button_0.Name = "buttonSave";
            this.button_0.Size = new Size(0x4b, 0x17);
            this.button_0.TabIndex = 30;
            this.button_0.Text = "Сохранить";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new EventHandler(this.button_0_Click);
            this.button_1.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.button_1.Location = new Point(550, 0x17e);
            this.button_1.Name = "buttonClose";
            this.button_1.Size = new Size(0x4b, 0x17);
            this.button_1.TabIndex = 0x1f;
            this.button_1.Text = "Закрыть";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new EventHandler(this.button_1_Click);
            this.tabControl_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.tabControl_0.Controls.Add(this.tabPage_0);
            this.tabControl_0.Controls.Add(this.tabPage_1);
            this.tabControl_0.Location = new Point(0, 0);
            this.tabControl_0.Name = "tabControl";
            this.tabControl_0.SelectedIndex = 0;
            this.tabControl_0.Size = new Size(0x27e, 0x171);
            this.tabControl_0.TabIndex = 0x20;
            this.tabPage_0.Controls.Add(this.groupBox_0);
            this.tabPage_0.Controls.Add(this.groupBox_1);
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
            this.tabPage_0.Size = new Size(630, 0x157);
            this.tabPage_0.TabIndex = 0;
            this.tabPage_0.Text = "Общие";
            this.tabPage_0.UseVisualStyleBackColor = true;
            this.groupBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.groupBox_0.Controls.Add(this.textBox_4);
            this.groupBox_0.Controls.Add(this.label_6);
            this.groupBox_0.Controls.Add(this.textBox_5);
            this.groupBox_0.Controls.Add(this.label_7);
            this.groupBox_0.Location = new Point(8, 0xbc);
            this.groupBox_0.Name = "groupBoxApplicant";
            this.groupBox_0.Size = new Size(0x268, 0x4e);
            this.groupBox_0.TabIndex = 0x1f;
            this.groupBox_0.TabStop = false;
            this.groupBox_0.Text = "Заявитель";
            this.textBox_4.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_4.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tTC_PerformingTU.BasisApplicant", true));
            this.textBox_4.Location = new Point(0xa5, 0x2d);
            this.textBox_4.Name = "txtBasisApplicant";
            this.textBox_4.Size = new Size(0x1bd, 20);
            this.textBox_4.TabIndex = 3;
            this.textBox_4.TextChanged += new EventHandler(this.textBox_4_TextChanged);
            this.label_6.AutoSize = true;
            this.label_6.Location = new Point(9, 0x30);
            this.label_6.Name = "label6";
            this.label_6.Size = new Size(0x99, 13);
            this.label_6.TabIndex = 2;
            this.label_6.Text = "действующего на основании";
            this.textBox_5.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_5.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tTC_PerformingTU.FaceApplicant", true));
            this.textBox_5.Location = new Point(0xa5, 0x13);
            this.textBox_5.Name = "txtFaceApplicant";
            this.textBox_5.Size = new Size(0x1bd, 20);
            this.textBox_5.TabIndex = 1;
            this.textBox_5.TextChanged += new EventHandler(this.textBox_5_TextChanged);
            this.label_7.AutoSize = true;
            this.label_7.Location = new Point(9, 0x16);
            this.label_7.Name = "label8";
            this.label_7.Size = new Size(40, 13);
            this.label_7.TabIndex = 0;
            this.label_7.Text = "в лице";
            this.groupBox_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.groupBox_1.Controls.Add(this.textBox_6);
            this.groupBox_1.Controls.Add(this.label_8);
            this.groupBox_1.Controls.Add(this.textBox_7);
            this.groupBox_1.Controls.Add(this.label_9);
            this.groupBox_1.Location = new Point(8, 0x75);
            this.groupBox_1.Name = "groupBoSet";
            this.groupBox_1.Size = new Size(0x268, 70);
            this.groupBox_1.TabIndex = 30;
            this.groupBox_1.TabStop = false;
            this.groupBox_1.Text = "Сетевая организация";
            this.textBox_6.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_6.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tTC_PerformingTU.BasisNetWork", true));
            this.textBox_6.Location = new Point(0xa5, 0x2d);
            this.textBox_6.Name = "txtBasisNetwork";
            this.textBox_6.Size = new Size(0x1bd, 20);
            this.textBox_6.TabIndex = 3;
            this.textBox_6.TextChanged += new EventHandler(this.textBox_6_TextChanged);
            this.label_8.AutoSize = true;
            this.label_8.Location = new Point(9, 0x30);
            this.label_8.Name = "label4";
            this.label_8.Size = new Size(0x99, 13);
            this.label_8.TabIndex = 2;
            this.label_8.Text = "действующего на основании";
            this.textBox_7.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_7.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tTC_PerformingTU.FaceNetWork", true));
            this.textBox_7.Location = new Point(0xa5, 0x13);
            this.textBox_7.Name = "txtFaceNetWork";
            this.textBox_7.Size = new Size(0x1bd, 20);
            this.textBox_7.TabIndex = 1;
            this.textBox_7.TextChanged += new EventHandler(this.textBox_7_TextChanged);
            this.label_9.AutoSize = true;
            this.label_9.Location = new Point(9, 0x16);
            this.label_9.Name = "label1";
            this.label_9.Size = new Size(40, 13);
            this.label_9.TabIndex = 0;
            this.label_9.Text = "в лице";
            this.tabPage_1.Controls.Add(this.dataGridViewExcelFilter_0);
            this.tabPage_1.Controls.Add(this.toolStrip_0);
            this.tabPage_1.Location = new Point(4, 0x16);
            this.tabPage_1.Name = "tabPageFile";
            this.tabPage_1.Padding = new Padding(3);
            this.tabPage_1.Size = new Size(630, 0x157);
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
            this.dataGridViewExcelFilter_0.Size = new Size(0x270, 0x138);
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
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x27d, 0x1a1);
            base.Controls.Add(this.tabControl_0);
            base.Controls.Add(this.button_1);
            base.Controls.Add(this.button_0);
            base.Name = "FormActPerformingTU";
            this.Text = "Добавление/редактирование акта вуполнения ТУ";
            base.FormClosed += new FormClosedEventHandler(this.FormActPerformingTU_FormClosed);
            base.Load += new EventHandler(this.FormActPerformingTU_Load);
            this.dataSetTechConnection_0.EndInit();
            this.tabControl_0.ResumeLayout(false);
            this.tabPage_0.ResumeLayout(false);
            this.tabPage_0.PerformLayout();
            this.groupBox_0.ResumeLayout(false);
            this.groupBox_0.PerformLayout();
            this.groupBox_1.ResumeLayout(false);
            this.groupBox_1.PerformLayout();
            this.tabPage_1.ResumeLayout(false);
            this.tabPage_1.PerformLayout();
            this.dataGridViewExcelFilter_0.EndInit();
            ((ISupportInitialize) this.bindingSource_0).EndInit();
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            this.contextMenuStrip_0.ResumeLayout(false);
            base.ResumeLayout(false);
        }

        [CompilerGenerated]
        private void method_18()
        {
            this.bindingSource_0.ResetBindings(false);
        }

        private void method_2()
        {
            string[] textArray1 = new string[] { "select  d.id, d.numdoc, d.datedoc,  isnull(d.numdoc, '') + ' от ' + isnull(convert( varchar(10),d.Datedoc, 104), '') as numDatedoc  from ttc_doc d  where typeDoc = ", 0x463.ToString(), " and (id not in (select idparent from ttc_doc where typedoc = ", 0x4d7.ToString(), " and idParent is not null) or id in (select idParent from ttc_doc where id = ", this.IdAct.ToString(), " and idParent is not null)) " };
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
            if (!this.method_6())
            {
                return false;
            }
            if (!this.method_16())
            {
                return false;
            }
            return true;
        }

        private bool method_6()
        {
            this.dataSetTechConnection_0.tTC_PerformingTU.Rows[0]["id"] = this.int_0;
            this.dataSetTechConnection_0.tTC_PerformingTU.Rows[0].EndEdit();
            if (!base.InsertSqlData(this.dataSetTechConnection_0.tTC_PerformingTU))
            {
                return false;
            }
            if (!base.UpdateSqlData(this.dataSetTechConnection_0.tTC_PerformingTU))
            {
                return false;
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

        private string method_8(string string_1, int? nullable_0 = new int?(), byte[] byte_0 = null)
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
        private sealed class Class290
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
        private sealed class Class291
        {
            public string string_0;

            internal bool method_0(DataSetTechConnection.Class252 class252_0)
            {
                return (class252_0.FileName == this.string_0);
            }
        }
    }
}

