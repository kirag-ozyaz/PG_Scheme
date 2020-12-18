namespace Documents.Forms.TechnologicalConnection.RBP
{
    using ControlsLbr.DataGridViewExcelFilter;
    using ControlsLbr.Scheme;
    using DataSql;
    using Documents.DataSets;
    using Documents.Properties;
    using FormLbr;
    using FormLbr.Classes;
    using RikTheVeggie;
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

    public class FormJournalActRBP : FormBase
    {
        public int ABNSELECT;
        private BindingSource bindingSource_0;
        private BindingSource bindingSource_1;
        private CheckBox checkBox_0;
        private DataGridView dataGridView_0;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_0;
        private DataGridViewFilterCheckBoxColumn dataGridViewFilterCheckBoxColumn_0;
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
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_2;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_3;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_4;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_5;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_6;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_7;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_8;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_9;
        private DataGridViewImageColumn dataGridViewImageColumn_0;
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
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;
        private DataSetAbnObjAct dataSetAbnObjAct_0;
        private DateTimePicker dateTimePicker_0;
        private DateTimePicker dateTimePicker_1;
        private Dictionary<string, FileWatcherArgsAddl> dictionary_0;
        private IContainer icontainer_0;
        public int IDLIST;
        public static FormJournalActRBP instance;
        private Label label_0;
        private Label label_1;
        private Label label_2;
        private List<int> list_0;
        public int OBJSELECT;
        private SplitContainer splitContainer_0;
        private SplitContainer splitContainer_1;
        private ToolStrip toolStrip_0;
        private ToolStrip toolStrip_1;
        private ToolStrip toolStrip_2;
        private ToolStrip toolStrip_3;
        private ToolStrip toolStrip_4;
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
        private ToolStripButton toolStripButton_18;
        private ToolStripButton toolStripButton_2;
        private ToolStripButton toolStripButton_3;
        private ToolStripButton toolStripButton_4;
        private ToolStripButton toolStripButton_5;
        private ToolStripButton toolStripButton_6;
        private ToolStripButton toolStripButton_7;
        private ToolStripButton toolStripButton_8;
        private ToolStripButton toolStripButton_9;
        private ToolStripMenuItem toolStripMenuItem_0;
        private ToolStripMenuItem toolStripMenuItem_1;
        private ToolStripMenuItem toolStripMenuItem_2;
        private ToolStripMenuItem toolStripMenuItem_3;
        private ToolStripSeparator toolStripSeparator_0;
        private ToolStripSeparator toolStripSeparator_1;
        private ToolStripSeparator toolStripSeparator_2;
        private ToolStripSplitButton toolStripSplitButton_0;
        private ToolStripSplitButton toolStripSplitButton_1;
        private ToolStripTextBox toolStripTextBox_0;
        private ToolStripTextBox toolStripTextBox_1;
        private TreeViewSchmObjects treeViewSchmObjects_0;
        private TriStateTreeView triStateTreeView_0;

        public FormJournalActRBP()
        {
            this.IDLIST = -1;
            this.ABNSELECT = -1;
            this.OBJSELECT = -1;
            this.dictionary_0 = new Dictionary<string, FileWatcherArgsAddl>();
            this.method_15();
            instance = this;
        }

        public FormJournalActRBP(List<int> checkedSubstation)
        {
            this.IDLIST = -1;
            this.ABNSELECT = -1;
            this.OBJSELECT = -1;
            this.dictionary_0 = new Dictionary<string, FileWatcherArgsAddl>();
            this.method_15();
            instance = this;
            this.list_0 = checkedSubstation;
        }

        private void bindingSource_0_CurrentChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_0.CurrentRow != null)
            {
                this.IDLIST = Convert.ToInt32(((DataRowView) this.bindingSource_0.Current)["id"]);
                this.method_10(this.IDLIST);
            }
            else
            {
                this.IDLIST = -1;
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

        private void dataGridView_0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.method_13(false);
        }

        private void dataGridViewExcelFilter_0_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new FormAbnAktRBP(this.get_SqlSettings(), 1, this.IDLIST, true) { MdiParent = base.MdiParent }.Show();
        }

        private void dataGridViewExcelFilter_0_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (Convert.ToInt32(this.dataGridViewExcelFilter_0[this.dataGridViewFilterCheckBoxColumn_0.Name, e.RowIndex].Value) == 0)
                {
                    e.CellStyle.Font = new Font(this.dataGridViewExcelFilter_0.Font, FontStyle.Italic);
                }
                if (Convert.ToInt32(this.dataGridViewExcelFilter_0[this.dataGridViewTextBoxColumn_20.Name, e.RowIndex].Value) == 1)
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
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

        private void FormJournalActRBP_Load(object sender, EventArgs e)
        {
            this.dateTimePicker_1.Value = new DateTime(DateTime.Now.Year, 1, 1);
            this.dateTimePicker_0.Value = new DateTime(DateTime.Now.Year + 1, 1, 1).AddSeconds(-1.0);
            this.method_1();
            this.treeViewSchmObjects_0.set_SqlSettings(this.get_SqlSettings());
            this.treeViewSchmObjects_0.Load(this.list_0);
            this.method_0();
        }

        private void FormJournalActRBP_SizeChanged(object sender, EventArgs e)
        {
            this.toolStrip_3.Location = new Point((this.splitContainer_0.SplitterDistance + this.splitContainer_0.SplitterWidth) + 0x15, this.toolStrip_3.Location.Y);
        }

        private void method_0()
        {
            string str = string.Empty;
            string str2 = this.method_2(this.triStateTreeView_0.Nodes);
            string str3 = string.Empty;
            string str4 = string.Empty;
            if (this.checkBox_0.Checked)
            {
                foreach (int num in this.method_4())
                {
                    if (string.IsNullOrEmpty(str3))
                    {
                        str3 = str3 + num.ToString();
                    }
                    else
                    {
                        str3 = str3 + ", " + num.ToString();
                    }
                }
                if (!string.IsNullOrEmpty(str3))
                {
                    str4 = str4 + string.Format(" and tc.idSubPoint in ({0}) ", str3);
                }
            }
            else
            {
                foreach (int num2 in this.treeViewSchmObjects_0.GetListChecked())
                {
                    if (string.IsNullOrEmpty(str3))
                    {
                        str3 = str3 + num2.ToString();
                    }
                    else
                    {
                        str3 = str3 + ", " + num2.ToString();
                    }
                }
                if (!string.IsNullOrEmpty(str3))
                {
                    str4 = str4 + string.Format(" and (tc.idSubPoint in ({0}) or tc.idBusPoint in ({0})  or tc.idCellPoint in ({0})) ", str3);
                }
            }
            if (!string.IsNullOrEmpty(str2))
            {
                str = str + string.Format(" and doc.idDocType in ({0}) ", str2);
            }
            if (!this.toolStripButton_9.Checked)
            {
                str = str + " and doc.deleted = 0 ";
            }
            string str5 = " order by tAbn.CodeAbonent, tAbnObj.Name ";
            string str6 = string.Format("select distinct doc.id, doc.idAbn, doc.idAbnObj, cd.name as typeDoc,  tAbn.CodeAbonent, tAbn.Name, tAbnObj.Name as objName, rbp.Data,  doc.DocNumber as actNumber, doc.DocDate as actDate,  fullPointName.SBC AS StationList, doc.idDocType,  cr.Name as actRegion, doc.isActive, doc.Deleted  from tAbnObjDoc_List as doc left join  (\tselect d.id, SBC = (select (ISNULL(schmS.typeCodeSocr + '-' + schmS.Name, '') +  ISNULL('\\'+ schmB.typeCodeSocr + '-' + schmB.Name, '')  + ISNULL('\\' + schmC.typeCodeSocr + '-' + schmC.Name, '') + char(10) + char(13))  from tTC_TUPointAttach as tc left join  vSchm_ObjList as schmS on schmS.Id = tc.idSubPoint left join  vSchm_ObjList as schmB on schmB.Id = tc.idBusPoint left join  vSchm_ObjList as schmC on schmC.Id = tc.idCellPoint  where tc.idTU = d.id and tc.TypeDoc = d.idDocType {2} for xml path(''), type).value('.', 'varchar(max)')  from tAbnObjDoc_List as d) as fullPointName on fullPointName.id = doc.id left join  tTC_TUPointAttach as tc on tc.idTU = doc.id left join  tR_Classifier as cd on cd.Id = doc.idDocType left join  tAbnObjDoc_AktRBP as rbp on rbp.idList = doc.id left join  tR_Classifier as cr on cr.Id = rbp.NetRegion left join  tAbn on tabn.id = doc.idAbn left join  tAbnObj on tAbnObj.id = doc.idAbnObj  where doc.DocDate >= '{0}' and doc.DocDate <= '{1}' {2} ", this.dateTimePicker_1.Value.Date.ToString("yyyyMMdd"), this.dateTimePicker_0.Value.Date.ToString("yyyyMMdd"), str4) + str + str5;
            DataTable table = new DataTable();
            table = new SqlDataCommand(this.get_SqlSettings()).SelectSqlData(str6);
            this.bindingSource_0.DataSource = table;
        }

        private void method_1()
        {
            DataTable table = new DataTable("tR_Classifier");
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("name", typeof(string));
            base.SelectSqlData(table, true, " where ParentKey = ';TypeDoc;tAbnobj;' and Value in (1, 4) order by Name ", false);
            foreach (DataRow row in table.Rows)
            {
                TreeNode node = new TreeNode(row["name"].ToString()) {
                    Tag = row["id"],
                    Checked = true
                };
                this.triStateTreeView_0.Nodes.Add(node);
            }
            this.triStateTreeView_0.LoadStates();
        }

        private void method_10(int int_0)
        {
            base.SelectSqlData(this.dataSetAbnObjAct_0.tAbnObjDoc_File, true, " where idList = " + int_0, false);
            this.method_11();
        }

        private void method_11()
        {
            if (base.InvokeRequired)
            {
                base.Invoke(new Action(this.method_16));
            }
            else
            {
                this.bindingSource_1.ResetBindings(false);
            }
        }

        private string method_12()
        {
            string str = (!(((DataRowView) this.bindingSource_0.Current)["idAbn"] is string) || !string.IsNullOrEmpty(((DataRowView) this.bindingSource_0.Current)["idAbn"].ToString())) ? "tmp" : ((DataRowView) this.bindingSource_0.Current)["idAbn"].ToString();
            string path = Path.GetTempPath() + @"\" + str + @"\";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return path;
        }

        private void method_13(bool bool_0 = false)
        {
            if (this.bindingSource_1.Current != null)
            {
                byte[] file;
                DataSetAbnObjAct.tAbnObjDoc_FileRow row = (DataSetAbnObjAct.tAbnObjDoc_FileRow) ((DataRowView) this.bindingSource_1.Current).Row;
                string fileName = row.FileName;
                string str2 = this.method_12();
                string str3 = FileBinary.GetNewFileNameIsExists(str2, fileName, false);
                int? nullable = null;
                if (row["idTemplate"] != DBNull.Value)
                {
                    nullable = new int?(row.idTemplate);
                }
                DateTime dateChange = row.dateChange;
                if (row["file"] == DBNull.Value)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(this.get_SqlSettings().GetConnectionString()))
                        {
                            connection.Open();
                            SqlDataReader reader = new SqlCommand("select [file] from tDocAct_File where id = " + row["id"].ToString(), connection).ExecuteReader();
                            while (reader.Read())
                            {
                                row["file"] = reader["file"];
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
                if (bool_0)
                {
                    if (this.dictionary_0.ContainsKey(fileName))
                    {
                        if (this.dictionary_0[fileName].get_Watcher() == null)
                        {
                            FileWatcher watcher = new FileWatcher(str2, str3);
                            watcher.add_AnyChanged(new FileSystemEventHandler(this.method_14));
                            watcher.Start();
                            this.dictionary_0[fileName].set_Watcher(watcher);
                        }
                        else
                        {
                            this.dictionary_0[fileName].get_Watcher().remove_AnyChanged(new FileSystemEventHandler(this.method_14));
                            this.dictionary_0[fileName].get_Watcher().Stop();
                            FileWatcher watcher2 = new FileWatcher(str2, str3);
                            watcher2.add_AnyChanged(new FileSystemEventHandler(this.method_14));
                            watcher2.Start();
                            this.dictionary_0[fileName].set_Watcher(watcher2);
                        }
                        this.dictionary_0[fileName].set_TempName(str3);
                        this.dictionary_0[fileName].set_OpenState(1);
                    }
                    else
                    {
                        FileWatcher watcher3 = new FileWatcher(str2, str3);
                        watcher3.add_AnyChanged(new FileSystemEventHandler(this.method_14));
                        watcher3.Start();
                        FileWatcherArgsAddl addl = new FileWatcherArgsAddl(nullable, fileName, str3, watcher3, 1);
                        this.dictionary_0.Add(fileName, addl);
                    }
                }
            }
        }

        private void method_14(object sender, FileSystemEventArgs e)
        {
            Class286 class2 = new Class286 {
                fileSystemEventArgs_0 = e
            };
            class2.ienumerable_0 = this.dictionary_0.Where<KeyValuePair<string, FileWatcherArgsAddl>>(new Func<KeyValuePair<string, FileWatcherArgsAddl>, bool>(class2.method_0));
            if (class2.ienumerable_0.Count<KeyValuePair<string, FileWatcherArgsAddl>>() > 0)
            {
                FileBinary binary = new FileBinary(class2.fileSystemEventArgs_0.FullPath);
                EnumerableRowCollection<DataSetAbnObjAct.tAbnObjDoc_FileRow> source = this.dataSetAbnObjAct_0.tAbnObjDoc_File.Where<DataSetAbnObjAct.tAbnObjDoc_FileRow>(new Func<DataSetAbnObjAct.tAbnObjDoc_FileRow, bool>(class2.method_1));
                if (source.Count<DataSetAbnObjAct.tAbnObjDoc_FileRow>() == 0)
                {
                    DataSetAbnObjAct.tAbnObjDoc_FileRow row = this.dataSetAbnObjAct_0.tAbnObjDoc_File.NewtAbnObjDoc_FileRow();
                    row.Int32_0 = (this.dataSetAbnObjAct_0.tAbnObjDoc_File.Min<DataSetAbnObjAct.tAbnObjDoc_FileRow>((<>c.<>9__59_2 ?? (<>c.<>9__59_2 = new Func<DataSetAbnObjAct.tAbnObjDoc_FileRow, int>(<>c.<>9.method_0)))) < 0) ? (this.dataSetAbnObjAct_0.tAbnObjDoc_File.Min<DataSetAbnObjAct.tAbnObjDoc_FileRow>((<>c.<>9__59_3 ?? (<>c.<>9__59_3 = new Func<DataSetAbnObjAct.tAbnObjDoc_FileRow, int>(<>c.<>9.method_1)))) - 1) : -1;
                    row.idList = this.IDLIST;
                    row.FileName = class2.ienumerable_0.First<KeyValuePair<string, FileWatcherArgsAddl>>().Value.get_OriginalName();
                    row.File = binary.get_ByteArray();
                    row.dateChange = binary.get_LastChanged();
                    row.idTemplate = class2.ienumerable_0.First<KeyValuePair<string, FileWatcherArgsAddl>>().Value.get_IdTemplate().Value;
                    this.dataSetAbnObjAct_0.tAbnObjDoc_File.AddtAbnObjDoc_FileRow(row);
                }
                else
                {
                    source.First<DataSetAbnObjAct.tAbnObjDoc_FileRow>().File = binary.get_ByteArray();
                    source.First<DataSetAbnObjAct.tAbnObjDoc_FileRow>().dateChange = binary.get_LastChanged();
                    source.First<DataSetAbnObjAct.tAbnObjDoc_FileRow>().EndEdit();
                }
            }
            if (base.InvokeRequired)
            {
                base.Invoke(new Action(this.method_17));
            }
            else
            {
                this.bindingSource_1.ResetBindings(false);
            }
        }

        private void method_15()
        {
            this.icontainer_0 = new Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(FormJournalActRBP));
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            this.toolStrip_0 = new ToolStrip();
            this.toolStripSplitButton_0 = new ToolStripSplitButton();
            this.toolStripMenuItem_0 = new ToolStripMenuItem();
            this.toolStripMenuItem_1 = new ToolStripMenuItem();
            this.toolStripButton_6 = new ToolStripButton();
            this.toolStripButton_7 = new ToolStripButton();
            this.toolStripButton_8 = new ToolStripButton();
            this.toolStripButton_16 = new ToolStripButton();
            this.toolStripButton_17 = new ToolStripButton();
            this.toolStripSeparator_1 = new ToolStripSeparator();
            this.toolStripSplitButton_1 = new ToolStripSplitButton();
            this.toolStripMenuItem_2 = new ToolStripMenuItem();
            this.toolStripMenuItem_3 = new ToolStripMenuItem();
            this.splitContainer_0 = new SplitContainer();
            this.toolStrip_4 = new ToolStrip();
            this.toolStripButton_13 = new ToolStripButton();
            this.toolStripTextBox_1 = new ToolStripTextBox();
            this.toolStripButton_14 = new ToolStripButton();
            this.toolStripButton_15 = new ToolStripButton();
            this.treeViewSchmObjects_0 = new TreeViewSchmObjects();
            this.triStateTreeView_0 = new TriStateTreeView();
            this.label_2 = new Label();
            this.checkBox_0 = new CheckBox();
            this.label_0 = new Label();
            this.label_1 = new Label();
            this.dateTimePicker_0 = new DateTimePicker();
            this.dateTimePicker_1 = new DateTimePicker();
            this.toolStrip_1 = new ToolStrip();
            this.toolStripButton_0 = new ToolStripButton();
            this.toolStripButton_1 = new ToolStripButton();
            this.toolStripButton_2 = new ToolStripButton();
            this.toolStripButton_3 = new ToolStripButton();
            this.toolStripSeparator_0 = new ToolStripSeparator();
            this.toolStripButton_9 = new ToolStripButton();
            this.splitContainer_1 = new SplitContainer();
            this.dataGridViewExcelFilter_0 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewTextBoxColumn_15 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_16 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_17 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_18 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_19 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_20 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_10 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_11 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_12 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_13 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_14 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_15 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_16 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_17 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterCheckBoxColumn_0 = new DataGridViewFilterCheckBoxColumn();
            this.bindingSource_0 = new BindingSource(this.icontainer_0);
            this.dataSetAbnObjAct_0 = new DataSetAbnObjAct();
            this.dataGridView_0 = new DataGridView();
            this.dataGridViewImageColumnNotNull_0 = new DataGridViewImageColumnNotNull();
            this.dataGridViewFilterTextBoxColumn_9 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_12 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_13 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_14 = new DataGridViewTextBoxColumn();
            this.bindingSource_1 = new BindingSource(this.icontainer_0);
            this.toolStrip_2 = new ToolStrip();
            this.toolStripButton_4 = new ToolStripButton();
            this.toolStripButton_5 = new ToolStripButton();
            this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_1 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_2 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_3 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_4 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_5 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_6 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_7 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_8 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewImageColumn_0 = new DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
            this.toolStrip_3 = new ToolStrip();
            this.toolStripButton_10 = new ToolStripButton();
            this.toolStripTextBox_0 = new ToolStripTextBox();
            this.toolStripButton_11 = new ToolStripButton();
            this.toolStripButton_12 = new ToolStripButton();
            this.toolStripSeparator_2 = new ToolStripSeparator();
            this.toolStripButton_18 = new ToolStripButton();
            this.toolStrip_0.SuspendLayout();
            this.splitContainer_0.Panel1.SuspendLayout();
            this.splitContainer_0.Panel2.SuspendLayout();
            this.splitContainer_0.SuspendLayout();
            this.toolStrip_4.SuspendLayout();
            this.toolStrip_1.SuspendLayout();
            this.splitContainer_1.Panel1.SuspendLayout();
            this.splitContainer_1.Panel2.SuspendLayout();
            this.splitContainer_1.SuspendLayout();
            this.dataGridViewExcelFilter_0.BeginInit();
            ((ISupportInitialize) this.bindingSource_0).BeginInit();
            this.dataSetAbnObjAct_0.BeginInit();
            ((ISupportInitialize) this.dataGridView_0).BeginInit();
            ((ISupportInitialize) this.bindingSource_1).BeginInit();
            this.toolStrip_2.SuspendLayout();
            this.toolStrip_3.SuspendLayout();
            base.SuspendLayout();
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripSplitButton_0, this.toolStripButton_6, this.toolStripButton_7, this.toolStripButton_8, this.toolStripSeparator_1, this.toolStripSplitButton_1, this.toolStripSeparator_2, this.toolStripButton_17, this.toolStripButton_16 };
            this.toolStrip_0.Items.AddRange(toolStripItems);
            this.toolStrip_0.Location = new Point(0, 0);
            this.toolStrip_0.Name = "toolStripAct";
            this.toolStrip_0.Size = new Size(0x3d3, 0x19);
            this.toolStrip_0.TabIndex = 1;
            this.toolStripSplitButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.toolStripMenuItem_0, this.toolStripMenuItem_1 };
            this.toolStripSplitButton_0.DropDownItems.AddRange(itemArray2);
            this.toolStripSplitButton_0.Image = Resources.ElementAdd;
            this.toolStripSplitButton_0.ImageTransparentColor = Color.Magenta;
            this.toolStripSplitButton_0.Name = "toolSBtnAdd";
            this.toolStripSplitButton_0.Size = new Size(0x20, 0x16);
            this.toolStripSplitButton_0.Text = "Добавить акт";
            this.toolStripMenuItem_0.Name = "toolSBtnAddActBalance";
            this.toolStripMenuItem_0.Size = new Size(0x1a6, 0x16);
            this.toolStripMenuItem_0.Text = "Акт разграничения балансовой принадлежности сторон";
            this.toolStripMenuItem_0.Click += new EventHandler(this.toolStripMenuItem_0_Click);
            this.toolStripMenuItem_1.Name = "toolSBtnAddActLiability";
            this.toolStripMenuItem_1.Size = new Size(0x1a6, 0x16);
            this.toolStripMenuItem_1.Text = "Акт разграничения эксплуатационной ответственности сторон";
            this.toolStripMenuItem_1.Click += new EventHandler(this.toolStripMenuItem_1_Click);
            this.toolStripButton_6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_6.Image = Resources.ElementEdit;
            this.toolStripButton_6.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_6.Name = "toolBtnEditAct";
            this.toolStripButton_6.Size = new Size(0x17, 0x16);
            this.toolStripButton_6.Text = "Редактировать акт";
            this.toolStripButton_6.Click += new EventHandler(this.toolStripButton_6_Click);
            this.toolStripButton_7.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_7.Image = Resources.ElementInformation;
            this.toolStripButton_7.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_7.Name = "toolBtnViewAct";
            this.toolStripButton_7.Size = new Size(0x17, 0x16);
            this.toolStripButton_7.Text = "Просмотр акта";
            this.toolStripButton_7.Click += new EventHandler(this.toolStripButton_7_Click);
            this.toolStripButton_8.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_8.Image = Resources.ElementDel;
            this.toolStripButton_8.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_8.Name = "toolBtnDelAct";
            this.toolStripButton_8.Size = new Size(0x17, 0x16);
            this.toolStripButton_8.Text = "Удалить акт";
            this.toolStripButton_8.Click += new EventHandler(this.toolStripButton_8_Click);
            this.toolStripButton_16.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_16.Image = (Image) manager.GetObject("toolBtnMoveAct.Image");
            this.toolStripButton_16.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_16.Name = "toolBtnMoveAct";
            this.toolStripButton_16.Size = new Size(0x17, 0x16);
            this.toolStripButton_16.Text = "Переместить акт";
            this.toolStripButton_16.Click += new EventHandler(this.toolStripButton_16_Click);
            this.toolStripButton_17.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_17.Image = Resources.CopyBuffer;
            this.toolStripButton_17.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_17.Name = "toolBtnCopyAct";
            this.toolStripButton_17.Size = new Size(0x17, 0x16);
            this.toolStripButton_17.Text = "Скопировать акт";
            this.toolStripButton_17.Click += new EventHandler(this.toolStripButton_17_Click);
            this.toolStripSeparator_1.Name = "toolStripSeparator1";
            this.toolStripSeparator_1.Size = new Size(6, 0x19);
            this.toolStripSplitButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripItem[] itemArray3 = new ToolStripItem[] { this.toolStripMenuItem_2, this.toolStripMenuItem_3 };
            this.toolStripSplitButton_1.DropDownItems.AddRange(itemArray3);
            this.toolStripSplitButton_1.Image = (Image) manager.GetObject("toolBtnAddActWithoutObj.Image");
            this.toolStripSplitButton_1.ImageTransparentColor = Color.Magenta;
            this.toolStripSplitButton_1.Name = "toolBtnAddActWithoutObj";
            this.toolStripSplitButton_1.Size = new Size(0x20, 0x16);
            this.toolStripSplitButton_1.Text = "Акт разграничения балансовой принадлежности сторон";
            this.toolStripMenuItem_2.Name = "toolBtnAddActBalanceWithoutObj";
            this.toolStripMenuItem_2.Size = new Size(0x1a6, 0x16);
            this.toolStripMenuItem_2.Text = "Акт разграничения балансовой принадлежности сторон";
            this.toolStripMenuItem_2.Click += new EventHandler(this.toolStripMenuItem_2_Click);
            this.toolStripMenuItem_3.Name = "toolBtnAddActLiabilityWithoutObj";
            this.toolStripMenuItem_3.Size = new Size(0x1a6, 0x16);
            this.toolStripMenuItem_3.Text = "Акт разграничения эксплуатационной ответственности сторон";
            this.toolStripMenuItem_3.Click += new EventHandler(this.toolStripMenuItem_3_Click);
            this.splitContainer_0.Dock = DockStyle.Fill;
            this.splitContainer_0.Location = new Point(0, 0x19);
            this.splitContainer_0.Name = "splitContainer1";
            this.splitContainer_0.Panel1.Controls.Add(this.toolStrip_4);
            this.splitContainer_0.Panel1.Controls.Add(this.treeViewSchmObjects_0);
            this.splitContainer_0.Panel1.Controls.Add(this.triStateTreeView_0);
            this.splitContainer_0.Panel1.Controls.Add(this.label_2);
            this.splitContainer_0.Panel1.Controls.Add(this.checkBox_0);
            this.splitContainer_0.Panel1.Controls.Add(this.label_0);
            this.splitContainer_0.Panel1.Controls.Add(this.label_1);
            this.splitContainer_0.Panel1.Controls.Add(this.dateTimePicker_0);
            this.splitContainer_0.Panel1.Controls.Add(this.dateTimePicker_1);
            this.splitContainer_0.Panel1.Controls.Add(this.toolStrip_1);
            this.splitContainer_0.Panel1MinSize = 0xbc;
            this.splitContainer_0.Panel2.Controls.Add(this.splitContainer_1);
            this.splitContainer_0.Size = new Size(0x3d3, 0x1f1);
            this.splitContainer_0.SplitterDistance = 0xbc;
            this.splitContainer_0.TabIndex = 2;
            this.splitContainer_0.SplitterMoved += new SplitterEventHandler(this.splitContainer_0_SplitterMoved);
            this.toolStrip_4.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.toolStrip_4.AutoSize = false;
            this.toolStrip_4.Dock = DockStyle.None;
            ToolStripItem[] itemArray4 = new ToolStripItem[] { this.toolStripButton_13, this.toolStripTextBox_1, this.toolStripButton_14, this.toolStripButton_15 };
            this.toolStrip_4.Items.AddRange(itemArray4);
            this.toolStrip_4.Location = new Point(0, 0xfe);
            this.toolStrip_4.Name = "toolStripFindSubs";
            this.toolStrip_4.Size = new Size(0xbb, 0x19);
            this.toolStrip_4.TabIndex = 15;
            this.toolStripButton_13.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_13.Image = Resources.Find;
            this.toolStripButton_13.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_13.Name = "toolSubsBtnFind";
            this.toolStripButton_13.Size = new Size(0x17, 0x16);
            this.toolStripButton_13.Text = "Поиск";
            this.toolStripButton_13.Click += new EventHandler(this.toolStripButton_13_Click);
            this.toolStripTextBox_1.BorderStyle = BorderStyle.FixedSingle;
            this.toolStripTextBox_1.Name = "toolSubsTxtFind";
            this.toolStripTextBox_1.Size = new Size(0x55, 0x19);
            this.toolStripTextBox_1.KeyPress += new KeyPressEventHandler(this.treeViewSchmObjects_0_KeyPress);
            this.toolStripButton_14.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_14.Image = Resources.FindPrev;
            this.toolStripButton_14.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_14.Name = "toolSubsBtnFindBack";
            this.toolStripButton_14.Size = new Size(0x17, 0x16);
            this.toolStripButton_14.Text = "Поиск назад";
            this.toolStripButton_14.Click += new EventHandler(this.toolStripButton_14_Click);
            this.toolStripButton_15.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_15.Image = Resources.FindNext;
            this.toolStripButton_15.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_15.Name = "toolSubsFindNext";
            this.toolStripButton_15.Size = new Size(0x17, 0x16);
            this.toolStripButton_15.Text = "Поиск вперед";
            this.toolStripButton_15.Click += new EventHandler(this.toolStripButton_15_Click);
            this.treeViewSchmObjects_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.treeViewSchmObjects_0.CheckBoxes = true;
            this.treeViewSchmObjects_0.HideSelection = false;
            this.treeViewSchmObjects_0.Location = new Point(7, 0x11a);
            this.treeViewSchmObjects_0.Name = "treeViewSchmObj";
            this.treeViewSchmObjects_0.Size = new Size(0xaf, 0xbb);
            this.treeViewSchmObjects_0.set_SqlSettings(null);
            this.treeViewSchmObjects_0.TabIndex = 14;
            this.treeViewSchmObjects_0.BeforeExpand += new TreeViewCancelEventHandler(this.treeViewSchmObjects_0_BeforeExpand);
            this.treeViewSchmObjects_0.KeyPress += new KeyPressEventHandler(this.treeViewSchmObjects_0_KeyPress);
            this.triStateTreeView_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.triStateTreeView_0.Location = new Point(7, 0x83);
            this.triStateTreeView_0.Name = "treeViewAct";
            this.triStateTreeView_0.Size = new Size(0xaf, 120);
            this.triStateTreeView_0.TabIndex = 13;
            this.label_2.AutoSize = true;
            this.label_2.Location = new Point(12, 0x73);
            this.label_2.Name = "label3";
            this.label_2.Size = new Size(0x21, 13);
            this.label_2.TabIndex = 11;
            this.label_2.Text = "Акты";
            this.checkBox_0.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.checkBox_0.AutoSize = true;
            this.checkBox_0.Location = new Point(7, 0x1db);
            this.checkBox_0.Name = "chBoxFilterSub";
            this.checkBox_0.Size = new Size(180, 0x11);
            this.checkBox_0.TabIndex = 10;
            this.checkBox_0.Text = "Фильтровать по подстанциям";
            this.checkBox_0.UseVisualStyleBackColor = true;
            this.label_0.AutoSize = true;
            this.label_0.Location = new Point(12, 0x48);
            this.label_0.Name = "label2";
            this.label_0.Size = new Size(0x59, 13);
            this.label_0.TabIndex = 6;
            this.label_0.Text = "Дата окончания";
            this.label_1.AutoSize = true;
            this.label_1.Location = new Point(12, 30);
            this.label_1.Name = "label1";
            this.label_1.Size = new Size(0x47, 13);
            this.label_1.TabIndex = 5;
            this.label_1.Text = "Дата начала";
            this.dateTimePicker_0.Location = new Point(7, 0x58);
            this.dateTimePicker_0.Name = "dtpEnd";
            this.dateTimePicker_0.Size = new Size(0xaf, 20);
            this.dateTimePicker_0.TabIndex = 2;
            this.dateTimePicker_0.ValueChanged += new EventHandler(this.dateTimePicker_0_ValueChanged);
            this.dateTimePicker_1.Location = new Point(7, 0x2e);
            this.dateTimePicker_1.Margin = new Padding(7, 3, 7, 3);
            this.dateTimePicker_1.Name = "dtpBegin";
            this.dateTimePicker_1.Size = new Size(0xaf, 20);
            this.dateTimePicker_1.TabIndex = 1;
            this.dateTimePicker_1.ValueChanged += new EventHandler(this.dateTimePicker_1_ValueChanged);
            ToolStripItem[] itemArray5 = new ToolStripItem[] { this.toolStripButton_0, this.toolStripButton_1, this.toolStripButton_2, this.toolStripButton_3, this.toolStripSeparator_0, this.toolStripButton_9 };
            this.toolStrip_1.Items.AddRange(itemArray5);
            this.toolStrip_1.Location = new Point(0, 0);
            this.toolStrip_1.Name = "toolStripFilter";
            this.toolStrip_1.Size = new Size(0xbc, 0x19);
            this.toolStrip_1.TabIndex = 0;
            this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_0.Image = Resources.filter;
            this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_0.Name = "toolBtnAddFilter";
            this.toolStripButton_0.Size = new Size(0x17, 0x16);
            this.toolStripButton_0.Text = "Применить фильтр";
            this.toolStripButton_0.Click += new EventHandler(this.toolStripButton_0_Click);
            this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_1.Image = Resources.filter_delete;
            this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_1.Name = "toolBtnDelFilter";
            this.toolStripButton_1.Size = new Size(0x17, 0x16);
            this.toolStripButton_1.Text = "Сбросить фильтр";
            this.toolStripButton_1.Click += new EventHandler(this.toolStripButton_1_Click);
            this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_2.Image = Resources.arrow0021;
            this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_2.Name = "toolBtnPreviousYear";
            this.toolStripButton_2.Size = new Size(0x17, 0x16);
            this.toolStripButton_2.Text = "Предыдущий год";
            this.toolStripButton_2.Click += new EventHandler(this.toolStripButton_2_Click);
            this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_3.Image = Resources.arrow0015;
            this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_3.Name = "toolBtnNextYear";
            this.toolStripButton_3.Size = new Size(0x17, 0x16);
            this.toolStripButton_3.Text = "Следующий год";
            this.toolStripButton_3.Click += new EventHandler(this.toolStripButton_3_Click);
            this.toolStripSeparator_0.Name = "toolStripSeparator2";
            this.toolStripSeparator_0.Size = new Size(6, 0x19);
            this.toolStripButton_9.CheckOnClick = true;
            this.toolStripButton_9.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_9.Image = Resources.Trash;
            this.toolStripButton_9.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_9.Name = "toolBtnShowDelAct";
            this.toolStripButton_9.Size = new Size(0x17, 0x16);
            this.toolStripButton_9.Text = "Показать удаленные документы";
            this.toolStripButton_9.CheckedChanged += new EventHandler(this.toolStripButton_9_CheckedChanged);
            this.splitContainer_1.Dock = DockStyle.Fill;
            this.splitContainer_1.Location = new Point(0, 0);
            this.splitContainer_1.Name = "splitContainer2";
            this.splitContainer_1.Orientation = Orientation.Horizontal;
            this.splitContainer_1.Panel1.Controls.Add(this.dataGridViewExcelFilter_0);
            this.splitContainer_1.Panel2.Controls.Add(this.dataGridView_0);
            this.splitContainer_1.Panel2.Controls.Add(this.toolStrip_2);
            this.splitContainer_1.Size = new Size(0x313, 0x1f1);
            this.splitContainer_1.SplitterDistance = 0x151;
            this.splitContainer_1.TabIndex = 0;
            this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
            this.dataGridViewExcelFilter_0.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_15, this.dataGridViewTextBoxColumn_16, this.dataGridViewTextBoxColumn_17, this.dataGridViewTextBoxColumn_18, this.dataGridViewTextBoxColumn_19, this.dataGridViewTextBoxColumn_20, this.dataGridViewFilterTextBoxColumn_10, this.dataGridViewFilterTextBoxColumn_11, this.dataGridViewFilterTextBoxColumn_12, this.dataGridViewFilterTextBoxColumn_13, this.dataGridViewFilterTextBoxColumn_14, this.dataGridViewFilterTextBoxColumn_15, this.dataGridViewFilterTextBoxColumn_16, this.dataGridViewFilterTextBoxColumn_17, this.dataGridViewFilterCheckBoxColumn_0 };
            this.dataGridViewExcelFilter_0.Columns.AddRange(dataGridViewColumns);
            this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
            this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_0.Location = new Point(0, 0);
            this.dataGridViewExcelFilter_0.Name = "dgvAct";
            this.dataGridViewExcelFilter_0.ReadOnly = true;
            this.dataGridViewExcelFilter_0.RowHeadersWidth = 0x15;
            this.dataGridViewExcelFilter_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExcelFilter_0.Size = new Size(0x313, 0x151);
            this.dataGridViewExcelFilter_0.TabIndex = 0;
            this.dataGridViewExcelFilter_0.CellContentDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_0_CellContentDoubleClick);
            this.dataGridViewExcelFilter_0.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridViewExcelFilter_0_CellFormatting);
            this.dataGridViewTextBoxColumn_15.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_15.HeaderText = "id";
            this.dataGridViewTextBoxColumn_15.Name = "idDgvColumn";
            this.dataGridViewTextBoxColumn_15.ReadOnly = true;
            this.dataGridViewTextBoxColumn_15.Visible = false;
            this.dataGridViewTextBoxColumn_16.DataPropertyName = "idList";
            this.dataGridViewTextBoxColumn_16.HeaderText = "idList";
            this.dataGridViewTextBoxColumn_16.Name = "idListDgvColumn";
            this.dataGridViewTextBoxColumn_16.ReadOnly = true;
            this.dataGridViewTextBoxColumn_16.Visible = false;
            this.dataGridViewTextBoxColumn_17.DataPropertyName = "idAbn";
            this.dataGridViewTextBoxColumn_17.HeaderText = "idAbn";
            this.dataGridViewTextBoxColumn_17.Name = "idAbnDgvColumn";
            this.dataGridViewTextBoxColumn_17.ReadOnly = true;
            this.dataGridViewTextBoxColumn_17.Visible = false;
            this.dataGridViewTextBoxColumn_18.DataPropertyName = "idAbnObj";
            this.dataGridViewTextBoxColumn_18.HeaderText = "idAbnObj";
            this.dataGridViewTextBoxColumn_18.Name = "idAbnObjDgvColumn";
            this.dataGridViewTextBoxColumn_18.ReadOnly = true;
            this.dataGridViewTextBoxColumn_18.Visible = false;
            this.dataGridViewTextBoxColumn_19.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn_19.HeaderText = "Data";
            this.dataGridViewTextBoxColumn_19.Name = "dataDgvColumn";
            this.dataGridViewTextBoxColumn_19.ReadOnly = true;
            this.dataGridViewTextBoxColumn_19.Visible = false;
            this.dataGridViewTextBoxColumn_20.DataPropertyName = "deleted";
            this.dataGridViewTextBoxColumn_20.HeaderText = "deleted";
            this.dataGridViewTextBoxColumn_20.Name = "deletedDgvColumn";
            this.dataGridViewTextBoxColumn_20.ReadOnly = true;
            this.dataGridViewTextBoxColumn_20.Visible = false;
            this.dataGridViewFilterTextBoxColumn_10.DataPropertyName = "TypeDoc";
            this.dataGridViewFilterTextBoxColumn_10.HeaderText = "Тип документа";
            this.dataGridViewFilterTextBoxColumn_10.Name = "typeDocDgvColumn";
            this.dataGridViewFilterTextBoxColumn_10.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_10.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_10.Width = 150;
            this.dataGridViewFilterTextBoxColumn_11.DataPropertyName = "StationList";
            style.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_11.DefaultCellStyle = style;
            this.dataGridViewFilterTextBoxColumn_11.HeaderText = "Электроустановки";
            this.dataGridViewFilterTextBoxColumn_11.Name = "stationListDgvColumn";
            this.dataGridViewFilterTextBoxColumn_11.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_11.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_11.Width = 150;
            this.dataGridViewFilterTextBoxColumn_12.DataPropertyName = "CodeAbonent";
            this.dataGridViewFilterTextBoxColumn_12.HeaderText = "Код";
            this.dataGridViewFilterTextBoxColumn_12.Name = "codeAbonentDgvColumn";
            this.dataGridViewFilterTextBoxColumn_12.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_12.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_12.Width = 60;
            this.dataGridViewFilterTextBoxColumn_13.DataPropertyName = "Name";
            this.dataGridViewFilterTextBoxColumn_13.HeaderText = "Потребитель";
            this.dataGridViewFilterTextBoxColumn_13.Name = "nameDgvColumn";
            this.dataGridViewFilterTextBoxColumn_13.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_13.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_13.Width = 260;
            this.dataGridViewFilterTextBoxColumn_14.DataPropertyName = "ObjName";
            this.dataGridViewFilterTextBoxColumn_14.HeaderText = "Объект";
            this.dataGridViewFilterTextBoxColumn_14.Name = "objNameDgvColumn";
            this.dataGridViewFilterTextBoxColumn_14.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_14.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_14.Width = 250;
            this.dataGridViewFilterTextBoxColumn_15.DataPropertyName = "ActNumber";
            this.dataGridViewFilterTextBoxColumn_15.HeaderText = "Номер";
            this.dataGridViewFilterTextBoxColumn_15.Name = "actNumberDgvColumn";
            this.dataGridViewFilterTextBoxColumn_15.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_15.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_15.Width = 0x41;
            this.dataGridViewFilterTextBoxColumn_16.DataPropertyName = "ActDate";
            this.dataGridViewFilterTextBoxColumn_16.HeaderText = "Дата";
            this.dataGridViewFilterTextBoxColumn_16.Name = "actDateDgvColumn";
            this.dataGridViewFilterTextBoxColumn_16.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_16.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_16.Width = 0x55;
            this.dataGridViewFilterTextBoxColumn_17.DataPropertyName = "ActRegion";
            this.dataGridViewFilterTextBoxColumn_17.HeaderText = "Район";
            this.dataGridViewFilterTextBoxColumn_17.Name = "actRegionDgvColumn";
            this.dataGridViewFilterTextBoxColumn_17.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_17.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_17.Width = 120;
            this.dataGridViewFilterCheckBoxColumn_0.DataPropertyName = "isActive";
            this.dataGridViewFilterCheckBoxColumn_0.HeaderText = "Активный";
            this.dataGridViewFilterCheckBoxColumn_0.Name = "isActiveDgvColumn";
            this.dataGridViewFilterCheckBoxColumn_0.ReadOnly = true;
            this.dataGridViewFilterCheckBoxColumn_0.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterCheckBoxColumn_0.Width = 0x4b;
            this.bindingSource_0.DataMember = "vActBalance";
            this.bindingSource_0.DataSource = this.dataSetAbnObjAct_0;
            this.bindingSource_0.CurrentChanged += new EventHandler(this.bindingSource_0_CurrentChanged);
            this.dataSetAbnObjAct_0.DataSetName = "DataSetAbnObjAct";
            this.dataSetAbnObjAct_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.dataGridView_0.AllowUserToAddRows = false;
            this.dataGridView_0.AllowUserToDeleteRows = false;
            this.dataGridView_0.AllowUserToResizeRows = false;
            this.dataGridView_0.AutoGenerateColumns = false;
            this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray2 = new DataGridViewColumn[] { this.dataGridViewImageColumnNotNull_0, this.dataGridViewFilterTextBoxColumn_9, this.dataGridViewTextBoxColumn_11, this.dataGridViewTextBoxColumn_12, this.dataGridViewTextBoxColumn_13, this.dataGridViewTextBoxColumn_14 };
            this.dataGridView_0.Columns.AddRange(columnArray2);
            this.dataGridView_0.DataSource = this.bindingSource_1;
            this.dataGridView_0.Dock = DockStyle.Fill;
            this.dataGridView_0.Location = new Point(0, 0x19);
            this.dataGridView_0.Name = "dgvFile";
            this.dataGridView_0.ReadOnly = true;
            this.dataGridView_0.RowHeadersWidth = 0x15;
            this.dataGridView_0.Size = new Size(0x313, 0x83);
            this.dataGridView_0.TabIndex = 1;
            this.dataGridView_0.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView_0_CellDoubleClick);
            style2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewImageColumnNotNull_0.DefaultCellStyle = style2;
            this.dataGridViewImageColumnNotNull_0.HeaderText = "";
            this.dataGridViewImageColumnNotNull_0.ImageLayout = DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumnNotNull_0.Name = "fileDataGridViewImageColumn";
            this.dataGridViewImageColumnNotNull_0.ReadOnly = true;
            this.dataGridViewImageColumnNotNull_0.Visible = false;
            this.dataGridViewImageColumnNotNull_0.Width = 30;
            this.dataGridViewFilterTextBoxColumn_9.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewFilterTextBoxColumn_9.DataPropertyName = "FileName";
            this.dataGridViewFilterTextBoxColumn_9.HeaderText = "Файл";
            this.dataGridViewFilterTextBoxColumn_9.Name = "fileNameDgvColumn";
            this.dataGridViewFilterTextBoxColumn_9.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_9.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_11.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_11.HeaderText = "id";
            this.dataGridViewTextBoxColumn_11.Name = "idDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_11.ReadOnly = true;
            this.dataGridViewTextBoxColumn_11.Visible = false;
            this.dataGridViewTextBoxColumn_12.DataPropertyName = "idList";
            this.dataGridViewTextBoxColumn_12.HeaderText = "idList";
            this.dataGridViewTextBoxColumn_12.Name = "idListDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_12.ReadOnly = true;
            this.dataGridViewTextBoxColumn_12.Visible = false;
            this.dataGridViewTextBoxColumn_13.DataPropertyName = "dateChange";
            this.dataGridViewTextBoxColumn_13.HeaderText = "dateChange";
            this.dataGridViewTextBoxColumn_13.Name = "dateChangeDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_13.ReadOnly = true;
            this.dataGridViewTextBoxColumn_13.Visible = false;
            this.dataGridViewTextBoxColumn_14.DataPropertyName = "idTemplate";
            this.dataGridViewTextBoxColumn_14.HeaderText = "idTemplate";
            this.dataGridViewTextBoxColumn_14.Name = "idTemplateDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_14.ReadOnly = true;
            this.dataGridViewTextBoxColumn_14.Visible = false;
            this.bindingSource_1.DataMember = "tAbnObjDoc_File";
            this.bindingSource_1.DataSource = this.dataSetAbnObjAct_0;
            ToolStripItem[] itemArray6 = new ToolStripItem[] { this.toolStripButton_4, this.toolStripButton_5 };
            this.toolStrip_2.Items.AddRange(itemArray6);
            this.toolStrip_2.Location = new Point(0, 0);
            this.toolStrip_2.Name = "toolStripFile";
            this.toolStrip_2.Size = new Size(0x313, 0x19);
            this.toolStrip_2.TabIndex = 0;
            this.toolStrip_2.Text = "toolStrip2";
            this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_4.Image = Resources.ElementInformation;
            this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_4.Name = "toolBtnViewFile";
            this.toolStripButton_4.Size = new Size(0x17, 0x16);
            this.toolStripButton_4.Text = "Просмотр файла";
            this.toolStripButton_4.Click += new EventHandler(this.toolStripButton_4_Click);
            this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_5.Image = Resources.floppy_black;
            this.toolStripButton_5.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_5.Name = "toolBtnSaveToDisk";
            this.toolStripButton_5.Size = new Size(0x17, 0x16);
            this.toolStripButton_5.Text = "Сохранить файл на диск";
            this.toolStripButton_5.Click += new EventHandler(this.toolStripButton_5_Click);
            this.dataGridViewTextBoxColumn_0.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_0.HeaderText = "id";
            this.dataGridViewTextBoxColumn_0.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_0.Visible = false;
            this.dataGridViewTextBoxColumn_1.DataPropertyName = "idList";
            this.dataGridViewTextBoxColumn_1.HeaderText = "idList";
            this.dataGridViewTextBoxColumn_1.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn_1.Visible = false;
            this.dataGridViewTextBoxColumn_2.DataPropertyName = "idAbn";
            this.dataGridViewTextBoxColumn_2.HeaderText = "idAbn";
            this.dataGridViewTextBoxColumn_2.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn_2.Visible = false;
            this.dataGridViewTextBoxColumn_3.DataPropertyName = "idAbnObj";
            this.dataGridViewTextBoxColumn_3.HeaderText = "idAbnObj";
            this.dataGridViewTextBoxColumn_3.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn_3.Visible = false;
            this.dataGridViewTextBoxColumn_4.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn_4.HeaderText = "Data";
            this.dataGridViewTextBoxColumn_4.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn_4.Visible = false;
            this.dataGridViewTextBoxColumn_5.DataPropertyName = "isActive";
            this.dataGridViewTextBoxColumn_5.HeaderText = "isActive";
            this.dataGridViewTextBoxColumn_5.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn_5.Visible = false;
            this.dataGridViewTextBoxColumn_6.DataPropertyName = "deleted";
            this.dataGridViewTextBoxColumn_6.HeaderText = "deleted";
            this.dataGridViewTextBoxColumn_6.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn_6.Visible = false;
            this.dataGridViewFilterTextBoxColumn_0.DataPropertyName = "TypeDoc";
            this.dataGridViewFilterTextBoxColumn_0.HeaderText = "Тип документа";
            this.dataGridViewFilterTextBoxColumn_0.Name = "dataGridViewFilterTextBoxColumn1";
            this.dataGridViewFilterTextBoxColumn_0.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_0.Width = 130;
            this.dataGridViewFilterTextBoxColumn_1.DataPropertyName = "StationList";
            this.dataGridViewFilterTextBoxColumn_1.HeaderText = "Подстанция";
            this.dataGridViewFilterTextBoxColumn_1.Name = "dataGridViewFilterTextBoxColumn2";
            this.dataGridViewFilterTextBoxColumn_1.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_2.DataPropertyName = "CodeAbonent";
            this.dataGridViewFilterTextBoxColumn_2.HeaderText = "Код";
            this.dataGridViewFilterTextBoxColumn_2.Name = "dataGridViewFilterTextBoxColumn3";
            this.dataGridViewFilterTextBoxColumn_2.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_2.Width = 60;
            this.dataGridViewFilterTextBoxColumn_3.DataPropertyName = "Name";
            this.dataGridViewFilterTextBoxColumn_3.HeaderText = "Потребитель";
            this.dataGridViewFilterTextBoxColumn_3.Name = "dataGridViewFilterTextBoxColumn4";
            this.dataGridViewFilterTextBoxColumn_3.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_3.Width = 260;
            this.dataGridViewFilterTextBoxColumn_4.DataPropertyName = "ObjName";
            this.dataGridViewFilterTextBoxColumn_4.HeaderText = "Объект";
            this.dataGridViewFilterTextBoxColumn_4.Name = "dataGridViewFilterTextBoxColumn5";
            this.dataGridViewFilterTextBoxColumn_4.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_4.Width = 320;
            this.dataGridViewFilterTextBoxColumn_5.DataPropertyName = "ActNumber";
            this.dataGridViewFilterTextBoxColumn_5.HeaderText = "Номер";
            this.dataGridViewFilterTextBoxColumn_5.Name = "dataGridViewFilterTextBoxColumn6";
            this.dataGridViewFilterTextBoxColumn_5.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_5.Width = 0x41;
            this.dataGridViewFilterTextBoxColumn_6.DataPropertyName = "ActDate";
            this.dataGridViewFilterTextBoxColumn_6.HeaderText = "Дата";
            this.dataGridViewFilterTextBoxColumn_6.Name = "dataGridViewFilterTextBoxColumn7";
            this.dataGridViewFilterTextBoxColumn_6.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_6.Width = 0x55;
            this.dataGridViewFilterTextBoxColumn_7.DataPropertyName = "ActRegion";
            this.dataGridViewFilterTextBoxColumn_7.HeaderText = "Район";
            this.dataGridViewFilterTextBoxColumn_7.Name = "dataGridViewFilterTextBoxColumn8";
            this.dataGridViewFilterTextBoxColumn_7.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_7.Width = 0x4b;
            this.dataGridViewTextBoxColumn_7.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_7.HeaderText = "id";
            this.dataGridViewTextBoxColumn_7.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn_7.Visible = false;
            this.dataGridViewTextBoxColumn_8.DataPropertyName = "idList";
            this.dataGridViewTextBoxColumn_8.HeaderText = "idList";
            this.dataGridViewTextBoxColumn_8.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn_8.Visible = false;
            this.dataGridViewFilterTextBoxColumn_8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewFilterTextBoxColumn_8.DataPropertyName = "FileName";
            this.dataGridViewFilterTextBoxColumn_8.HeaderText = "Файл";
            this.dataGridViewFilterTextBoxColumn_8.Name = "dataGridViewFilterTextBoxColumn9";
            this.dataGridViewFilterTextBoxColumn_8.Resizable = DataGridViewTriState.True;
            this.dataGridViewImageColumn_0.DataPropertyName = "File";
            this.dataGridViewImageColumn_0.HeaderText = "File";
            this.dataGridViewImageColumn_0.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn_0.Visible = false;
            this.dataGridViewTextBoxColumn_9.DataPropertyName = "dateChange";
            this.dataGridViewTextBoxColumn_9.HeaderText = "dateChange";
            this.dataGridViewTextBoxColumn_9.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn_9.Visible = false;
            this.dataGridViewTextBoxColumn_10.DataPropertyName = "idTemplate";
            this.dataGridViewTextBoxColumn_10.HeaderText = "idTemplate";
            this.dataGridViewTextBoxColumn_10.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn_10.Visible = false;
            this.toolStrip_3.Dock = DockStyle.None;
            ToolStripItem[] itemArray7 = new ToolStripItem[] { this.toolStripButton_10, this.toolStripTextBox_0, this.toolStripButton_11, this.toolStripButton_12, this.toolStripButton_18 };
            this.toolStrip_3.Items.AddRange(itemArray7);
            this.toolStrip_3.Location = new Point(0xd5, 0);
            this.toolStrip_3.Name = "toolStripFind";
            this.toolStrip_3.Size = new Size(0x100, 0x19);
            this.toolStrip_3.TabIndex = 3;
            this.toolStripButton_10.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_10.Image = Resources.Find;
            this.toolStripButton_10.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_10.Name = "toolBtnFind";
            this.toolStripButton_10.Size = new Size(0x17, 0x16);
            this.toolStripButton_10.Text = "Поиск";
            this.toolStripButton_10.Click += new EventHandler(this.toolStripButton_10_Click);
            this.toolStripTextBox_0.BorderStyle = BorderStyle.FixedSingle;
            this.toolStripTextBox_0.Name = "toolTxtFind";
            this.toolStripTextBox_0.Size = new Size(150, 0x19);
            this.toolStripTextBox_0.KeyPress += new KeyPressEventHandler(this.toolStripTextBox_0_KeyPress);
            this.toolStripButton_11.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_11.Image = Resources.FindPrev;
            this.toolStripButton_11.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_11.Name = "toolBtnFindBack";
            this.toolStripButton_11.Size = new Size(0x17, 0x16);
            this.toolStripButton_11.Text = "Поиск назад";
            this.toolStripButton_11.Click += new EventHandler(this.toolStripButton_11_Click);
            this.toolStripButton_12.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_12.Image = Resources.FindNext;
            this.toolStripButton_12.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_12.Name = "toolBtnFindNext";
            this.toolStripButton_12.Size = new Size(0x17, 0x16);
            this.toolStripButton_12.Text = "Поиск вперед";
            this.toolStripButton_12.Click += new EventHandler(this.toolStripButton_12_Click);
            this.toolStripSeparator_2.Name = "toolStripSeparator3";
            this.toolStripSeparator_2.Size = new Size(6, 0x19);
            this.toolStripButton_18.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_18.Image = Resources.microsoftoffice2007excel_7581;
            this.toolStripButton_18.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_18.Name = "toolBtnExpExcel";
            this.toolStripButton_18.Size = new Size(0x17, 0x16);
            this.toolStripButton_18.Text = "Экспорт в Excel";
            this.toolStripButton_18.Click += new EventHandler(this.toolStripButton_18_Click);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x3d3, 0x20a);
            base.Controls.Add(this.toolStrip_3);
            base.Controls.Add(this.splitContainer_0);
            base.Controls.Add(this.toolStrip_0);
            this.MinimumSize = new Size(450, 280);
            base.Name = "FormJournalActRBP";
            this.Text = "Реестр актов разграничения балансовой принадлежности";
            base.Load += new EventHandler(this.FormJournalActRBP_Load);
            base.SizeChanged += new EventHandler(this.FormJournalActRBP_SizeChanged);
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            this.splitContainer_0.Panel1.ResumeLayout(false);
            this.splitContainer_0.Panel1.PerformLayout();
            this.splitContainer_0.Panel2.ResumeLayout(false);
            this.splitContainer_0.ResumeLayout(false);
            this.toolStrip_4.ResumeLayout(false);
            this.toolStrip_4.PerformLayout();
            this.toolStrip_1.ResumeLayout(false);
            this.toolStrip_1.PerformLayout();
            this.splitContainer_1.Panel1.ResumeLayout(false);
            this.splitContainer_1.Panel2.ResumeLayout(false);
            this.splitContainer_1.Panel2.PerformLayout();
            this.splitContainer_1.ResumeLayout(false);
            this.dataGridViewExcelFilter_0.EndInit();
            ((ISupportInitialize) this.bindingSource_0).EndInit();
            this.dataSetAbnObjAct_0.EndInit();
            ((ISupportInitialize) this.dataGridView_0).EndInit();
            ((ISupportInitialize) this.bindingSource_1).EndInit();
            this.toolStrip_2.ResumeLayout(false);
            this.toolStrip_2.PerformLayout();
            this.toolStrip_3.ResumeLayout(false);
            this.toolStrip_3.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        [CompilerGenerated]
        private void method_16()
        {
            this.bindingSource_1.ResetBindings(false);
        }

        [CompilerGenerated]
        private void method_17()
        {
            this.bindingSource_1.ResetBindings(false);
        }

        private string method_2(TreeNodeCollection treeNodeCollection_0)
        {
            string str = string.Empty;
            List<int> list = new List<int>();
            foreach (TreeNode node in treeNodeCollection_0)
            {
                this.method_3(node, list);
            }
            foreach (int num in list)
            {
                if (string.IsNullOrEmpty(str))
                {
                    str = str + num.ToString();
                }
                else
                {
                    str = str + ", " + num.ToString();
                }
            }
            return str;
        }

        private void method_3(TreeNode treeNode_0, List<int> list_1)
        {
            if (treeNode_0.Checked && (treeNode_0.Tag != null))
            {
                list_1.Add(Convert.ToInt32(treeNode_0.Tag));
            }
            foreach (TreeNode node in treeNode_0.Nodes)
            {
                this.method_3(node, list_1);
            }
        }

        private List<int> method_4()
        {
            List<int> list = new List<int>();
            foreach (TreeNode node in this.treeViewSchmObjects_0.Nodes)
            {
                this.method_5(node.Nodes, list);
            }
            return list;
        }

        private void method_5(TreeNodeCollection treeNodeCollection_0, List<int> list_1)
        {
            int count = list_1.Count;
            foreach (TreeNode node in treeNodeCollection_0)
            {
                if (node.Checked)
                {
                    switch (node.Level)
                    {
                        case 1:
                            list_1.Add((int) node.Tag);
                            break;

                        case 2:
                            list_1.Add((int) node.Parent.Tag);
                            break;

                        case 3:
                            list_1.Add((int) node.Parent.Parent.Tag);
                            break;
                    }
                }
                else
                {
                    this.method_5(node.Nodes, list_1);
                    if (list_1.Count > count)
                    {
                        break;
                    }
                }
            }
        }

        private void method_6(TreeNodeCollection treeNodeCollection_0, bool bool_0 = false)
        {
            foreach (TreeNode node in treeNodeCollection_0)
            {
                node.Checked = bool_0;
                this.method_6(node.Nodes, bool_0);
            }
        }

        private void method_7(object sender, FormClosedEventArgs e)
        {
            if (((Form) sender).DialogResult == DialogResult.OK)
            {
                this.method_0();
                this.method_8((sender is FormAbnAktRBP) ? ((FormAbnAktRBP) sender).IdList : -1);
            }
        }

        private void method_8(int int_0)
        {
            this.bindingSource_0.Position = this.bindingSource_0.Find("id", int_0);
            this.method_9(int_0);
        }

        private void method_9(int int_0)
        {
            base.SelectSqlData(this.dataSetAbnObjAct_0.tAbnObjDoc_File, true, " where idList = " + int_0.ToString(), false);
            this.method_11();
        }

        private void splitContainer_0_SplitterMoved(object sender, SplitterEventArgs e)
        {
            this.toolStrip_3.Location = new Point((this.splitContainer_0.SplitterDistance + this.splitContainer_0.SplitterWidth) + 0x15, this.toolStrip_3.Location.Y);
        }

        private void toolStripButton_0_Click(object sender, EventArgs e)
        {
            this.method_0();
        }

        private void toolStripButton_1_Click(object sender, EventArgs e)
        {
            this.toolStripButton_9.Checked = false;
            this.checkBox_0.Checked = false;
            this.method_6(this.triStateTreeView_0.Nodes, true);
            this.treeViewSchmObjects_0.ClearTreeChecked();
            this.treeViewSchmObjects_0.CollapseAll();
            this.dateTimePicker_1.Value = new DateTime(DateTime.Now.Year, 1, 1);
            this.dateTimePicker_0.Value = new DateTime(DateTime.Now.Year + 1, 1, 1).AddSeconds(-1.0);
            this.method_0();
        }

        private void toolStripButton_10_Click(object sender, EventArgs e)
        {
            this.dataGridViewExcelFilter_0.SearchGrid(1, this.toolStripTextBox_0.Text);
        }

        private void toolStripButton_11_Click(object sender, EventArgs e)
        {
            this.dataGridViewExcelFilter_0.SearchGrid(3, this.toolStripTextBox_0.Text);
        }

        private void toolStripButton_12_Click(object sender, EventArgs e)
        {
            this.dataGridViewExcelFilter_0.SearchGrid(2, this.toolStripTextBox_0.Text);
        }

        private void toolStripButton_13_Click(object sender, EventArgs e)
        {
            if (this.toolStripTextBox_1.Text.Length > 0)
            {
                this.treeViewSchmObjects_0.Find(this.toolStripTextBox_1.Text);
                this.treeViewSchmObjects_0.Focus();
            }
        }

        private void toolStripButton_14_Click(object sender, EventArgs e)
        {
            if (this.toolStripTextBox_1.Text.Length > 0)
            {
                this.treeViewSchmObjects_0.FindPrev(this.toolStripTextBox_1.Text);
                this.treeViewSchmObjects_0.Focus();
            }
        }

        private void toolStripButton_15_Click(object sender, EventArgs e)
        {
            if (this.toolStripTextBox_1.Text.Length > 0)
            {
                this.treeViewSchmObjects_0.FindNext(this.toolStripTextBox_1.Text);
                this.treeViewSchmObjects_0.Focus();
            }
        }

        private void toolStripButton_16_Click(object sender, EventArgs e)
        {
            if ((this.dataGridViewExcelFilter_0.SelectedRows != null) && (this.dataGridViewExcelFilter_0.SelectedRows.Count > 0))
            {
                FormObjFind find1 = new FormObjFind {
                    Owner = this
                };
                find1.set_SqlSettings(this.get_SqlSettings());
                if (find1.ShowDialog() == DialogResult.OK)
                {
                    base.SelectSqlData(this.dataSetAbnObjAct_0, this.dataSetAbnObjAct_0.tAbnObjDoc_List, true, " where id = " + this.IDLIST);
                    this.dataSetAbnObjAct_0.tAbnObjDoc_List.First<DataSetAbnObjAct.tAbnObjDoc_ListRow>().idAbn = this.ABNSELECT;
                    this.dataSetAbnObjAct_0.tAbnObjDoc_List.First<DataSetAbnObjAct.tAbnObjDoc_ListRow>().idAbnObj = this.OBJSELECT;
                    base.UpdateSqlData(this.dataSetAbnObjAct_0, this.dataSetAbnObjAct_0.tAbnObjDoc_List);
                    FormAbnAktRBP trbp1 = new FormAbnAktRBP(this.get_SqlSettings(), this.OBJSELECT, this.IDLIST, this.ABNSELECT) {
                        Owner = this,
                        MdiParent = base.MdiParent
                    };
                    trbp1.FormClosed += new FormClosedEventHandler(this.method_7);
                    trbp1.Show();
                }
            }
        }

        private void toolStripButton_17_Click(object sender, EventArgs e)
        {
            if ((this.dataGridViewExcelFilter_0.SelectedRows != null) && (this.dataGridViewExcelFilter_0.SelectedRows.Count > 0))
            {
                FormObjFind find1 = new FormObjFind {
                    Owner = this
                };
                find1.set_SqlSettings(this.get_SqlSettings());
                if (find1.ShowDialog() == DialogResult.OK)
                {
                    FormAbnAktRBP trbp1 = new FormAbnAktRBP(this.get_SqlSettings(), this.OBJSELECT, this.IDLIST, this.ABNSELECT) {
                        Owner = this,
                        MdiParent = base.MdiParent
                    };
                    trbp1.FormClosed += new FormClosedEventHandler(this.method_7);
                    trbp1.Show();
                }
            }
        }

        private void toolStripButton_18_Click(object sender, EventArgs e)
        {
            this.dataGridViewExcelFilter_0.ExportToExcel();
        }

        private void toolStripButton_2_Click(object sender, EventArgs e)
        {
            this.dateTimePicker_1.Value = this.dateTimePicker_1.Value.AddYears(-1);
            this.dateTimePicker_0.Value = this.dateTimePicker_0.Value.AddYears(-1);
        }

        private void toolStripButton_3_Click(object sender, EventArgs e)
        {
            this.dateTimePicker_0.Value = this.dateTimePicker_0.Value.AddYears(1);
            this.dateTimePicker_1.Value = this.dateTimePicker_1.Value.AddYears(1);
        }

        private void toolStripButton_4_Click(object sender, EventArgs e)
        {
            this.method_13(false);
        }

        private void toolStripButton_5_Click(object sender, EventArgs e)
        {
            if (this.bindingSource_1.Current != null)
            {
                DataSetAbnObjAct.tAbnObjDoc_FileRow row = (DataSetAbnObjAct.tAbnObjDoc_FileRow) ((DataRowView) this.bindingSource_1.Current).Row;
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

        private void toolStripButton_6_Click(object sender, EventArgs e)
        {
            if (((this.dataGridViewExcelFilter_0.SelectedRows != null) && (this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)) && (this.IDLIST != -1))
            {
                int idAbnObj = 0;
                if (((DataRowView) this.bindingSource_0.Current)["idAbnObj"] != DBNull.Value)
                {
                    idAbnObj = Convert.ToInt32(((DataRowView) this.bindingSource_0.Current)["idAbnObj"]);
                }
                FormAbnAktRBP trbp1 = new FormAbnAktRBP(this.get_SqlSettings(), idAbnObj, this.IDLIST) {
                    MdiParent = base.MdiParent
                };
                trbp1.FormClosed += new FormClosedEventHandler(this.method_7);
                trbp1.Show();
            }
        }

        private void toolStripButton_7_Click(object sender, EventArgs e)
        {
            new FormAbnAktRBP(this.get_SqlSettings(), 1, this.IDLIST, true) { MdiParent = base.MdiParent }.Show();
        }

        private void toolStripButton_8_Click(object sender, EventArgs e)
        {
            if (((this.dataGridViewExcelFilter_0.SelectedRows != null) && (this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)) && (MessageBox.Show("Вы действительно хотите удалить текущий документ?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                int index = this.dataGridViewExcelFilter_0.CurrentRow.Index;
                DataSetAbnObjAct act = new DataSetAbnObjAct();
                base.SelectSqlData(act, act.tAbnObjDoc_List, true, "where id = " + this.IDLIST);
                act.tAbnObjDoc_List.First<DataSetAbnObjAct.tAbnObjDoc_ListRow>().Deleted = !act.tAbnObjDoc_List.First<DataSetAbnObjAct.tAbnObjDoc_ListRow>().Deleted;
                act.tAbnObjDoc_List.Rows[0].EndEdit();
                if (base.UpdateSqlData(act, act.tAbnObjDoc_List))
                {
                    if (act.tAbnObjDoc_List.First<DataSetAbnObjAct.tAbnObjDoc_ListRow>().Deleted)
                    {
                        this.method_0();
                        MessageBox.Show("Документ успешно удален");
                    }
                    else
                    {
                        this.method_0();
                        MessageBox.Show("Документ успешно восстановлен");
                    }
                    this.method_0();
                }
            }
        }

        private void toolStripButton_9_CheckedChanged(object sender, EventArgs e)
        {
            this.toolStripButton_9.Text = this.toolStripButton_9.Checked ? "Скрыть удаленные документы" : "Показать удаленные документы";
            this.method_0();
        }

        private void toolStripMenuItem_0_Click(object sender, EventArgs e)
        {
            FormObjFind find1 = new FormObjFind {
                Owner = this
            };
            find1.set_SqlSettings(this.get_SqlSettings());
            if (find1.ShowDialog() == DialogResult.OK)
            {
                FormAbnAktRBP trbp1 = new FormAbnAktRBP(this.get_SqlSettings(), true, true, this.ABNSELECT, this.OBJSELECT, 1) {
                    Owner = this
                };
                trbp1.FormClosed += new FormClosedEventHandler(this.method_7);
                trbp1.MdiParent = base.MdiParent;
                trbp1.Show();
            }
        }

        private void toolStripMenuItem_1_Click(object sender, EventArgs e)
        {
            FormObjFind find1 = new FormObjFind {
                Owner = this
            };
            find1.set_SqlSettings(this.get_SqlSettings());
            if (find1.ShowDialog() == DialogResult.OK)
            {
                FormAbnAktRBP trbp1 = new FormAbnAktRBP(this.get_SqlSettings(), true, true, this.ABNSELECT, this.OBJSELECT, 4) {
                    Owner = this
                };
                trbp1.FormClosed += new FormClosedEventHandler(this.method_7);
                trbp1.MdiParent = base.MdiParent;
                trbp1.Show();
            }
        }

        private void toolStripMenuItem_2_Click(object sender, EventArgs e)
        {
            FormObjFind find1 = new FormObjFind {
                Owner = this
            };
            find1.set_SqlSettings(this.get_SqlSettings());
            if (find1.ShowDialog() == DialogResult.OK)
            {
                FormAbnAktRBP trbp1 = new FormAbnAktRBP(this.get_SqlSettings(), true, this.ABNSELECT, 1) {
                    Owner = this,
                    MdiParent = base.MdiParent
                };
                trbp1.FormClosed += new FormClosedEventHandler(this.method_7);
                trbp1.Show();
            }
        }

        private void toolStripMenuItem_3_Click(object sender, EventArgs e)
        {
            FormObjFind find1 = new FormObjFind {
                Owner = this
            };
            find1.set_SqlSettings(this.get_SqlSettings());
            if (find1.ShowDialog() == DialogResult.OK)
            {
                FormAbnAktRBP trbp1 = new FormAbnAktRBP(this.get_SqlSettings(), true, this.ABNSELECT, 4) {
                    Owner = this,
                    MdiParent = base.MdiParent
                };
                trbp1.FormClosed += new FormClosedEventHandler(this.method_7);
                trbp1.Show();
            }
        }

        private void toolStripTextBox_0_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) && (this.toolStripTextBox_0.Text.Length > 0))
            {
                if ((e.KeyChar == '\r') && ((Control.ModifierKeys & Keys.Shift) == Keys.Shift))
                {
                    e.Handled = true;
                    this.dataGridViewExcelFilter_0.SearchGrid(3, this.toolStripTextBox_0.Text);
                }
                else if (e.KeyChar == '\r')
                {
                    e.Handled = true;
                    this.dataGridViewExcelFilter_0.SearchGrid(2, this.toolStripTextBox_0.Text);
                }
            }
        }

        private void treeViewSchmObjects_0_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Level == 2)
            {
                using (IEnumerator enumerator = e.Node.Nodes.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        using (IEnumerator enumerator2 = ((TreeNode) enumerator.Current).Nodes.GetEnumerator())
                        {
                            while (enumerator2.MoveNext())
                            {
                                ((TreeNode) enumerator2.Current).Remove();
                            }
                            continue;
                        }
                    }
                }
            }
        }

        private void treeViewSchmObjects_0_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) && (this.toolStripTextBox_1.Text.Length > 0))
            {
                if ((e.KeyChar == '\r') && ((Control.ModifierKeys & Keys.Shift) == Keys.Shift))
                {
                    e.Handled = true;
                    this.treeViewSchmObjects_0.FindPrev(this.toolStripTextBox_1.Text);
                    this.treeViewSchmObjects_0.Focus();
                }
                else if (e.KeyChar == '\r')
                {
                    e.Handled = true;
                    this.treeViewSchmObjects_0.FindNext(this.toolStripTextBox_1.Text);
                    this.treeViewSchmObjects_0.Focus();
                }
            }
        }

        [Serializable, CompilerGenerated]
        private sealed class <>c
        {
            public static readonly FormJournalActRBP.<>c <>9 = new FormJournalActRBP.<>c();
            public static Func<DataSetAbnObjAct.tAbnObjDoc_FileRow, int> <>9__59_2;
            public static Func<DataSetAbnObjAct.tAbnObjDoc_FileRow, int> <>9__59_3;

            internal int method_0(DataSetAbnObjAct.tAbnObjDoc_FileRow tAbnObjDoc_FileRow_0)
            {
                return tAbnObjDoc_FileRow_0.Int32_0;
            }

            internal int method_1(DataSetAbnObjAct.tAbnObjDoc_FileRow tAbnObjDoc_FileRow_0)
            {
                return tAbnObjDoc_FileRow_0.Int32_0;
            }
        }

        [CompilerGenerated]
        private sealed class Class286
        {
            public FileSystemEventArgs fileSystemEventArgs_0;
            public IEnumerable<KeyValuePair<string, FileWatcherArgsAddl>> ienumerable_0;

            internal bool method_0(KeyValuePair<string, FileWatcherArgsAddl> keyValuePair_0)
            {
                return (keyValuePair_0.Value.get_TempName() == this.fileSystemEventArgs_0.Name);
            }

            internal bool method_1(DataSetAbnObjAct.tAbnObjDoc_FileRow tAbnObjDoc_FileRow_0)
            {
                return ((tAbnObjDoc_FileRow_0.RowState != DataRowState.Deleted) && (tAbnObjDoc_FileRow_0.FileName == this.ienumerable_0.First<KeyValuePair<string, FileWatcherArgsAddl>>().Value.get_OriginalName()));
            }
        }

        private enum Enum21
        {
            const_0 = 1,
            const_1 = 2,
            const_2 = 3
        }
    }
}

