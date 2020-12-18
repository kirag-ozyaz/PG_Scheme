namespace Documents.Forms.Memorandums
{
    using Constants;
    using ControlsLbr.DataGridViewExcelFilter;
    using DataSql;
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
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    public class FormMemorandumJournal : FormBase
    {
        private BackgroundWorker backgroundWorker_0;
        private BindingSource bindingSource_0;
        private BindingSource bindingSource_1;
        private BindingSource bindingSource_2;
        private BindingSource bindingSource_3;
        private Button button_0;
        private Button button_1;
        private Class220 class220_0;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_0;
        private DataGridViewFilterCheckBoxColumn dataGridViewFilterCheckBoxColumn_0;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_1;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_2;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_3;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_4;
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
        private DataSetGES dataSetGES_0;
        private EISSettings eissettings_0;
        private IContainer icontainer_0;
        [CompilerGenerated]
        private int int_0;
        private Label label_0;
        private ProgressBar progressBar_0;
        private StateFormCreate stateFormCreate_0;
        private string string_0;
        private TableLayoutPanel tableLayoutPanel_0;
        private ToolStrip toolStrip_0;
        private ToolStripButton toolStripButton_0;
        private ToolStripButton toolStripButton_1;
        private ToolStripButton toolStripButton_2;
        private ToolStripButton toolStripButton_3;
        private ToolStripButton toolStripButton_4;
        private ToolStripButton toolStripButton_5;
        private ToolStripSeparator toolStripSeparator_0;
        private ToolStripSeparator toolStripSeparator_1;
        private ToolStripSeparator toolStripSeparator_2;
        private ToolStripTextBox toolStripTextBox_0;

        public FormMemorandumJournal()
        {
            this.string_0 = Environment.GetFolderPath(Environment.SpecialFolder.Templates) + @"\LotusTemp\";
            this.method_27();
            this.stateFormCreate_0 = 7;
        }

        public FormMemorandumJournal(StateFormCreate state)
        {
            this.string_0 = Environment.GetFolderPath(Environment.SpecialFolder.Templates) + @"\LotusTemp\";
            this.method_27();
            this.stateFormCreate_0 = state;
        }

        private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
        {
            this.method_17(true);
            this.method_7("Загружаются данные из \"Босс референт\".");
            try
            {
                this.method_0();
            }
            catch (SqlException exception1)
            {
                MessageBox.Show(exception1.StackTrace);
            }
            catch (Exception exception2)
            {
                MessageBox.Show(exception2.StackTrace);
            }
            this.method_7("Загрузка успешно завершена.");
        }

        private void backgroundWorker_0_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            RowsLoading userState = (RowsLoading) e.UserState;
            this.method_7(string.Concat(new object[] { "Всего: ", userState.Count, "; Добавлено: ", userState.Loaded.ToString(), "Обновлено: ", userState.Exists.ToString() }));
        }

        private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.toolStripButton_0.Enabled = true;
            this.method_17(false);
            this.method_24(true);
        }

        private void bindingSource_0_CurrentChanged(object sender, EventArgs e)
        {
            if (this.bindingSource_0.Current != null)
            {
                this.toolStripButton_2.Enabled = (((DataRowView) this.bindingSource_0.Current)["Status"].ToString() == "Черновик") && (((int) ((DataRowView) this.bindingSource_0.Current)["idWorker"]) == this.method_9());
            }
        }

        private void bindingSource_3_CurrentChanged(object sender, EventArgs e)
        {
            this.method_18();
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.OK;
            base.Close();
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void dataGridViewExcelFilter_0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((e.ColumnIndex != -1) && (e.RowIndex != -1)) && (this.bindingSource_0.Current != null))
            {
                if (this.toolStripButton_2.Enabled)
                {
                    this.method_19();
                }
                else
                {
                    this.method_21();
                }
            }
        }

        private void dataGridViewExcelFilter_0_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormMemorandumJournal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((this.stateFormCreate_0 != 7) && (base.DialogResult == DialogResult.OK))
            {
                if (!this.method_14())
                {
                    MessageBox.Show("Не выбрано ни одной строки.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Cancel = true;
                    return;
                }
                string str = "";
                foreach (DataGridViewRow row in (IEnumerable) this.dataGridViewExcelFilter_0.Rows)
                {
                    if ((row.Cells["isSelected"].Value != null) && ((bool) row.Cells["isSelected"].Value))
                    {
                        str = str + row.Cells["idDataGridViewTextBoxColumn"].Value.ToString() + ",";
                    }
                }
                if (str.Length > 0)
                {
                    base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_Memorandum, true, "WHERE id IN (" + str.Remove(str.LastIndexOf(',')) + ") AND Deleted = 0");
                    foreach (DataSetGES.Class150 local1 in this.dataSetGES_0.tJ_Memorandum)
                    {
                        local1.idTehConnect = this.IdTU;
                        local1.EndEdit();
                    }
                    base.UpdateSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_Memorandum);
                }
            }
            if (this.class220_0 != null)
            {
                this.class220_0.method_31();
            }
        }

        private void FormMemorandumJournal_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(this.string_0))
            {
                Directory.CreateDirectory(this.string_0);
            }
            this.method_24(false);
            if (this.stateFormCreate_0 == 7)
            {
                this.toolStripButton_1.Visible = false;
                this.dataGridViewFilterCheckBoxColumn_0.Visible = false;
                this.dataGridViewExcelFilter_0.Refresh();
                this.button_0.Visible = false;
            }
            else
            {
                this.toolStripButton_1.Visible = false;
                this.toolStripButton_2.Visible = false;
                this.toolStripSeparator_0.Visible = false;
                this.toolStripButton_4.Visible = false;
                this.toolStripSeparator_1.Visible = false;
            }
        }

        private bool method_0()
        {
            Class220 class2 = this.method_12();
            this.method_7("Загружаем служебные записки...");
            List<Class222> source = class2.method_15("", true);
            if (source.Count<Class222>() == 0)
            {
                return false;
            }
            this.method_7("Загружаем поручения...");
            List<Class221> list2 = class2.method_13("", true);
            this.method_7("Обновляем данные...");
            this.method_7("Загружаем пользователей Босс Референт...");
            DataTable table = base.SelectSqlData("vJ_BossUser", true, "");
            using (List<Class222>.Enumerator enumerator = source.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    Class297 class3 = new Class297 {
                        class222_0 = enumerator.Current
                    };
                    int num = -1;
                    if (!this.dataSetGES_0.tJ_Memorandum.Select<DataSetGES.Class150, string>((<>c.<>9__17_0 ?? (<>c.<>9__17_0 = new Func<DataSetGES.Class150, string>(<>c.<>9.method_0)))).Contains<string>(class3.class222_0.UniversalID))
                    {
                        num = this.method_1(class3.class222_0, num);
                    }
                    else
                    {
                        num = this.dataSetGES_0.tJ_Memorandum.Where<DataSetGES.Class150>(new Func<DataSetGES.Class150, bool>(class3.method_0)).First<DataSetGES.Class150>().Int32_0;
                        this.method_2(class3.class222_0);
                    }
                    if (num == -1)
                    {
                        return false;
                    }
                    this.method_5(num, Enum19.const_0, table, class3.class222_0.CorrName);
                    this.method_5(num, Enum19.const_2, table, class3.class222_0.IO_InP);
                    this.method_5(num, Enum19.const_3, table, class3.class222_0.Reviewers);
                    this.method_4(class3.class222_0.Files, Enum18.const_0, num);
                    this.method_3(class3.class222_0.UniversalID, num, list2.Where<Class221>(new Func<Class221, bool>(class3.method_1)).ToList<Class221>(), -1, table);
                }
            }
            return true;
        }

        private int method_1(Class222 class222_0, int int_1)
        {
            this.method_7("Вставляем данные в таблицу разрешений...");
            string str = "idWorker, Deleted, UniversalID";
            string str2 = string.Format("{0}, 0,'{1}'", this.method_9(), class222_0.UniversalID);
            if (class222_0.Status != "")
            {
                str = str + ",[Status]";
                str2 = str2 + string.Format(",{0}", this.method_11(class222_0.Status));
            }
            if (class222_0.Body_C != "")
            {
                str = str + ",[Body_C]";
                str2 = str2 + string.Format(",'{0}'", class222_0.Body_C);
            }
            if (class222_0.Subject != "")
            {
                str = str + ",[Subject]";
                str2 = str2 + string.Format(",'{0}'", class222_0.Subject);
            }
            if (class222_0.RespDate.Length >= 10)
            {
                str = str + ",[RespDate]";
                str2 = str2 + string.Format(",CONVERT(SMALLDATETIME,'{0}',101)", this.method_8(class222_0.RespDate));
            }
            if (class222_0.SignDate.Length >= 10)
            {
                str = str + ",[SignDate]";
                str2 = str2 + string.Format(",CONVERT(SMALLDATETIME,'{0}',101)", this.method_8(class222_0.SignDate));
            }
            if (class222_0.RgNum != "")
            {
                str = str + ",[RgNum]";
                str2 = str2 + string.Format(",'{0}'", class222_0.RgNum);
            }
            if (class222_0.RespNum != "")
            {
                str = str + ",[RespNum]";
                str2 = str2 + string.Format(",'{0}'", class222_0.RespNum);
            }
            if (class222_0.CorrName != "")
            {
                str = str + ",[CorrName]";
                str2 = str2 + string.Format(",'{0}'", class222_0.CorrName);
            }
            if (class222_0.ctbDateCreate.Length >= 10)
            {
                str = str + string.Format(",[ctbDateCreate]", new object[0]);
                str2 = str2 + string.Format(",CONVERT(SMALLDATETIME,'{0}',101)", this.method_8(class222_0.ctbDateCreate));
            }
            string str3 = string.Format("insert into tJ_Memorandum ({0}) values ({1})", str, str2);
            this.toolStripTextBox_0.Text = str3;
            int_1 = this.method_13(str3, "tJ_Memorandum");
            return int_1;
        }

        private int method_10(Class221 class221_0)
        {
            DataTable table = base.SelectSqlData("tR_Classifier", true, "WHERE ParentKey = ';TechConnect;Commission;' AND [Comment] LIKE '" + class221_0.Header_Title + "' AND Deleted = 0");
            if (table.Rows.Count > 0)
            {
                return (int) table.Rows[0]["Id"];
            }
            return -1;
        }

        private int method_11(string string_1)
        {
            DataTable table = base.SelectSqlData("tR_Classifier", true, "WHERE ParentKey = ';TechConnect;StatusMemorandum;' AND [Comment] LIKE '" + string_1 + "' AND Deleted = 0");
            if (table.Rows.Count > 0)
            {
                return (int) table.Rows[0]["Id"];
            }
            return -1;
        }

        private Class220 method_12()
        {
            Class220 class2;
            try
            {
                this.eissettings_0 = this.method_15();
                if (!this.eissettings_0.get_FrmTUSettings().get_IsSavePassport() || (this.eissettings_0.get_FrmTUSettings().get_Password() == ""))
                {
                    Form26 form = new Form26();
                    form.set_SqlSettings(this.get_SqlSettings());
                    form.method_1(this.eissettings_0.get_FrmTUSettings().get_IsSavePassport());
                    form.Password = this.eissettings_0.get_FrmTUSettings().get_Password();
                    if (form.ShowDialog() != DialogResult.OK)
                    {
                        return null;
                    }
                    this.eissettings_0.get_FrmTUSettings().set_IsSavePassport(form.method_0());
                    this.eissettings_0.get_FrmTUSettings().set_Password(form.Password);
                    new AppConfig().SaveAppConfig(this.eissettings_0);
                }
                class2 = new Class220(this.eissettings_0.get_FrmTUSettings().get_Password());
            }
            catch (Exception)
            {
                return null;
            }
            return class2;
        }

        private int method_13(string string_1, string string_2)
        {
            SqlDataConnect connect = new SqlDataConnect();
            int num = -1;
            try
            {
                connect.OpenConnection(this.get_SqlSettings());
                SqlTransaction transaction = connect.get_Connection().BeginTransaction();
                SqlCommand command1 = new SqlCommand(string_1, connect.get_Connection()) {
                    Transaction = transaction
                };
                command1.ExecuteNonQuery();
                command1.CommandText = "select IDENT_CURRENT('" + string_2 + "')";
                num = Convert.ToInt32(command1.ExecuteScalar());
                transaction.Commit();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source);
            }
            finally
            {
                connect.CloseConnection();
            }
            return num;
        }

        private bool method_14()
        {
            foreach (DataGridViewRow row in (IEnumerable) this.dataGridViewExcelFilter_0.Rows)
            {
                if ((row.Cells["isSelected"].Value != null) && ((bool) row.Cells["isSelected"].Value))
                {
                    return true;
                }
            }
            return false;
        }

        private EISSettings method_15()
        {
            AppConfig config = new AppConfig();
            this.eissettings_0 = config.OpenAppConfig();
            if (this.eissettings_0.get_FrmTUSettings() == null)
            {
                FormTUSettings settings = new FormTUSettings();
                settings.set_IsSavePassport(false);
                settings.set_Password("");
                this.eissettings_0.set_FrmTUSettings(settings);
                config.SaveAppConfig(this.eissettings_0);
            }
            return this.eissettings_0;
        }

        private void method_16(SQLSettings sqlsettings_0, string string_1)
        {
            SqlDataConnect connect = new SqlDataConnect();
            try
            {
                connect.OpenConnection(sqlsettings_0);
                new SqlCommand(string_1, connect.get_Connection()).ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source);
            }
            finally
            {
                connect.CloseConnection();
            }
        }

        private void method_17(bool bool_0)
        {
            Class302 class2 = new Class302 {
                formMemorandumJournal_0 = this,
                bool_0 = bool_0
            };
            if (this.progressBar_0.InvokeRequired)
            {
                Dispatcher.Invoke(this, new AsyncAction(class2, (IntPtr) this.method_0));
            }
            else
            {
                this.progressBar_0.Style = class2.bool_0 ? ProgressBarStyle.Marquee : ProgressBarStyle.Blocks;
            }
        }

        private void method_18()
        {
            using (SqlConnection connection = new SqlConnection(this.get_SqlSettings().GetConnectionString()))
            {
                if (this.bindingSource_0.Current != null)
                {
                    this.dataSetGES_0.tJ_MemFiles.Clear();
                    string str = string.Format("WHERE (TypeDoc = 1 AND idDocument = {0})", (int) ((DataRowView) this.bindingSource_0.Current)["id"]) + ((this.bindingSource_3.Current != null) ? string.Format(" OR (TypeDoc = 2 AND idDocument = {0})", (int) ((DataRowView) this.bindingSource_3.Current)["id"]) : "");
                    connection.Open();
                    new SqlDataAdapter(new SqlCommand("SELECT [id],[idDocument],[TypeDoc],[Name],[Size],[LastChange],[Deleted] FROM tJ_MemFiles " + str, connection)).Fill(this.dataSetGES_0.tJ_MemFiles);
                }
                else
                {
                    this.dataSetGES_0.tJ_MemFiles.Clear();
                }
            }
        }

        private void method_19()
        {
            if (this.bindingSource_0.Current != null)
            {
                Form27 form1 = new Form27();
                form1.set_SqlSettings(this.get_SqlSettings());
                form1.MdiParent = base.MdiParent;
                form1.method_3(this.method_9());
                form1.method_5((int) ((DataRowView) this.bindingSource_0.Current)["id"]);
                form1.method_9(1);
                form1.FormClosed += new FormClosedEventHandler(this.method_20);
                form1.Show();
            }
        }

        private void method_2(Class222 class222_0)
        {
            this.method_7("Обновляем данные в таблице разрешений...");
            string str = string.Format("update tJ_Memorandum set UniversalID = '{0}'", class222_0.UniversalID);
            if (class222_0.RespDate.Length >= 10)
            {
                str = str + string.Format(",[RespDate] = CONVERT(SMALLDATETIME,'{0}',101)", this.method_8(class222_0.RespDate));
            }
            if (class222_0.Status != "")
            {
                str = str + string.Format(",[Status] = '{0}'", this.method_11(class222_0.Status));
            }
            if (class222_0.Subject != "")
            {
                str = str + string.Format(",[Subject] = '{0}'", class222_0.Subject);
            }
            if (class222_0.Body_C != "")
            {
                str = str + string.Format(",[Body_C] = '{0}'", class222_0.Body_C);
            }
            if (class222_0.SignDate.Length >= 10)
            {
                str = str + string.Format(",[SignDate] = CONVERT(SMALLDATETIME,'{0}',101)", this.method_8(class222_0.SignDate));
            }
            if (class222_0.RgNum != "")
            {
                str = str + string.Format(",[RgNum] = '{0}'", class222_0.RgNum);
            }
            if (class222_0.RespNum != "")
            {
                str = str + string.Format(",[RespNum] = '{0}'", class222_0.RespNum);
            }
            if (class222_0.CorrName != "")
            {
                str = str + string.Format(",[CorrName] = '{0}'", class222_0.CorrName);
            }
            str = str + string.Format(" WHERE UniversalID = '{0}'", class222_0.UniversalID);
            this.method_16(this.get_SqlSettings(), str);
        }

        private void method_20(object sender, FormClosedEventArgs e)
        {
            this.method_23(((Form27) sender).method_4());
        }

        private void method_21()
        {
            if (this.bindingSource_0.Current != null)
            {
                Form27 form1 = new Form27();
                form1.set_SqlSettings(this.get_SqlSettings());
                form1.MdiParent = base.MdiParent;
                form1.method_3(this.method_9());
                form1.method_5((int) ((DataRowView) this.bindingSource_0.Current)["id"]);
                form1.method_9(7);
                form1.Show();
            }
        }

        private void method_22()
        {
            if ((this.bindingSource_0.Current != null) && (MessageBox.Show("Вы действительно хотите удалить текущую запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                EnumerableRowCollection<DataSetGES.Class150> source = this.dataSetGES_0.tJ_Memorandum.Where<DataSetGES.Class150>(new Func<DataSetGES.Class150, bool>(this.method_28));
                if (source.Count<DataSetGES.Class150>() > 0)
                {
                    source.First<DataSetGES.Class150>().Deleted = true;
                    if (base.UpdateSqlData(this.dataSetGES_0.tJ_Memorandum))
                    {
                        this.dataSetGES_0.tJ_Memorandum.AcceptChanges();
                        MessageBox.Show("Запись успешно удалена.");
                        this.method_24(false);
                    }
                }
            }
        }

        private void method_23(int int_1)
        {
            this.method_24(false);
            this.bindingSource_0.Position = this.bindingSource_0.Find("id", int_1);
        }

        private void method_24(bool bool_0)
        {
            try
            {
                bool_0 = bool_0 ? (this.bindingSource_0.Current > null) : bool_0;
                int key = -1;
                if (bool_0)
                {
                    key = (int) ((DataRowView) this.bindingSource_0.Current)["id"];
                }
                this.bindingSource_0.RaiseListChangedEvents = true;
                this.bindingSource_0.CurrentChanged -= new EventHandler(this.bindingSource_0_CurrentChanged);
                base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_Memorandum, true, string.Format("WHERE idTehConnect IS NULL AND Deleted = 0", this.method_9()));
                base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.vJ_Memorandum, true, string.Format("WHERE idTehConnect IS NULL AND Deleted = 0", this.method_9()));
                this.bindingSource_0.CurrentChanged += new EventHandler(this.bindingSource_0_CurrentChanged);
                this.bindingSource_0.RaiseListChangedEvents = false;
                this.bindingSource_0_CurrentChanged(this.bindingSource_0, new EventArgs());
                if (bool_0)
                {
                    this.bindingSource_0.Position = this.bindingSource_0.Find("id", key);
                }
            }
            catch (Exception)
            {
            }
        }

        private void method_25(BindingSource bindingSource_4, string string_1)
        {
            if (bindingSource_4.Current != null)
            {
                byte[] file;
                DataSetGES.Class149 row = (DataSetGES.Class149) ((DataRowView) bindingSource_4.Current).Row;
                string name = row.Name;
                string str2 = FileBinary.GetNewFileNameIsExists(string_1, name, false);
                DateTime lastChange = row.LastChange;
                if (row["File"] == DBNull.Value)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(this.get_SqlSettings().GetConnectionString()))
                        {
                            connection.Open();
                            SqlDataReader reader = new SqlCommand("SELECT [File] FROM tJ_MemFiles WHERE id = " + row["id"].ToString(), connection).ExecuteReader();
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
                FileBinary binary = new FileBinary(file, str2, DateTime.Now);
                binary.SaveToDisk(string_1);
                Process.Start(string_1 + @"\" + binary.get_Name());
            }
        }

        private void method_26(object sender, DataGridViewCellEventArgs e)
        {
            if (((DataGridView) sender).Name == "dgvFileMemorandum")
            {
                this.method_25(this.bindingSource_2, this.string_0);
            }
            if (((DataGridView) sender).Name == "dgvFileCommission")
            {
                this.method_25(this.bindingSource_1, this.string_0);
            }
        }

        private void method_27()
        {
            this.icontainer_0 = new Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(FormMemorandumJournal));
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            DataGridViewCellStyle style3 = new DataGridViewCellStyle();
            this.tableLayoutPanel_0 = new TableLayoutPanel();
            this.toolStrip_0 = new ToolStrip();
            this.toolStripButton_1 = new ToolStripButton();
            this.toolStripButton_2 = new ToolStripButton();
            this.toolStripButton_3 = new ToolStripButton();
            this.toolStripSeparator_0 = new ToolStripSeparator();
            this.toolStripButton_4 = new ToolStripButton();
            this.toolStripSeparator_1 = new ToolStripSeparator();
            this.toolStripButton_5 = new ToolStripButton();
            this.toolStripSeparator_2 = new ToolStripSeparator();
            this.toolStripButton_0 = new ToolStripButton();
            this.toolStripTextBox_0 = new ToolStripTextBox();
            this.button_0 = new Button();
            this.button_1 = new Button();
            this.dataGridViewExcelFilter_0 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewFilterCheckBoxColumn_0 = new DataGridViewFilterCheckBoxColumn();
            this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_1 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_2 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_3 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_4 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
            this.bindingSource_0 = new BindingSource(this.icontainer_0);
            this.dataSetGES_0 = new DataSetGES();
            this.progressBar_0 = new ProgressBar();
            this.bindingSource_2 = new BindingSource(this.icontainer_0);
            this.bindingSource_1 = new BindingSource(this.icontainer_0);
            this.bindingSource_3 = new BindingSource(this.icontainer_0);
            this.backgroundWorker_0 = new BackgroundWorker();
            this.label_0 = new Label();
            this.tableLayoutPanel_0.SuspendLayout();
            this.toolStrip_0.SuspendLayout();
            this.dataGridViewExcelFilter_0.BeginInit();
            ((ISupportInitialize) this.bindingSource_0).BeginInit();
            this.dataSetGES_0.BeginInit();
            ((ISupportInitialize) this.bindingSource_2).BeginInit();
            ((ISupportInitialize) this.bindingSource_1).BeginInit();
            ((ISupportInitialize) this.bindingSource_3).BeginInit();
            base.SuspendLayout();
            this.tableLayoutPanel_0.ColumnCount = 4;
            this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 268f));
            this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125f));
            this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 117f));
            this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20f));
            this.tableLayoutPanel_0.Controls.Add(this.toolStrip_0, 0, 0);
            this.tableLayoutPanel_0.Controls.Add(this.button_0, 2, 3);
            this.tableLayoutPanel_0.Controls.Add(this.button_1, 3, 3);
            this.tableLayoutPanel_0.Controls.Add(this.dataGridViewExcelFilter_0, 0, 1);
            this.tableLayoutPanel_0.Controls.Add(this.progressBar_0, 0, 3);
            this.tableLayoutPanel_0.Controls.Add(this.label_0, 1, 3);
            this.tableLayoutPanel_0.Dock = DockStyle.Fill;
            this.tableLayoutPanel_0.Location = new Point(0, 0);
            this.tableLayoutPanel_0.Name = "tlpGeneral";
            this.tableLayoutPanel_0.RowCount = 4;
            this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 26f));
            this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 70.43189f));
            this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 29.56811f));
            this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 41f));
            this.tableLayoutPanel_0.Size = new Size(0x34b, 440);
            this.tableLayoutPanel_0.TabIndex = 0;
            this.tableLayoutPanel_0.SetColumnSpan(this.toolStrip_0, 4);
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripButton_1, this.toolStripButton_2, this.toolStripButton_3, this.toolStripSeparator_0, this.toolStripButton_4, this.toolStripSeparator_1, this.toolStripButton_5, this.toolStripSeparator_2, this.toolStripButton_0, this.toolStripTextBox_0 };
            this.toolStrip_0.Items.AddRange(toolStripItems);
            this.toolStrip_0.Location = new Point(0, 0);
            this.toolStrip_0.Name = "tsGeneral";
            this.toolStrip_0.Size = new Size(0x34b, 0x19);
            this.toolStrip_0.TabIndex = 1;
            this.toolStrip_0.Text = "toolStrip1";
            this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_1.Image = Resources.ElementAdd;
            this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_1.Name = "tsbMemorandumAdd";
            this.toolStripButton_1.Size = new Size(0x17, 0x16);
            this.toolStripButton_1.Text = "Добавить";
            this.toolStripButton_1.Click += new EventHandler(this.toolStripButton_1_Click);
            this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_2.Image = Resources.ElementEdit;
            this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_2.Name = "tsbMemorandumEdit";
            this.toolStripButton_2.Size = new Size(0x17, 0x16);
            this.toolStripButton_2.Text = "Редактировать";
            this.toolStripButton_2.Click += new EventHandler(this.toolStripButton_2_Click);
            this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_3.Image = Resources.ElementInformation;
            this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_3.Name = "tsbMemorandumView";
            this.toolStripButton_3.Size = new Size(0x17, 0x16);
            this.toolStripButton_3.Text = "Открыть";
            this.toolStripButton_3.Click += new EventHandler(this.toolStripButton_3_Click);
            this.toolStripSeparator_0.Name = "tssMemorandumDelete";
            this.toolStripSeparator_0.Size = new Size(6, 0x19);
            this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_4.Image = Resources.ElementDel;
            this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_4.Name = "tsbMemorandumDelete";
            this.toolStripButton_4.Size = new Size(0x17, 0x16);
            this.toolStripButton_4.Text = "Удалить";
            this.toolStripButton_4.Click += new EventHandler(this.toolStripButton_4_Click);
            this.toolStripSeparator_1.Name = "tssLoadFromBoss";
            this.toolStripSeparator_1.Size = new Size(6, 0x19);
            this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_5.Image = Resources.refresh_16;
            this.toolStripButton_5.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_5.Name = "tsbMemorandumRefresh";
            this.toolStripButton_5.Size = new Size(0x17, 0x16);
            this.toolStripButton_5.Text = "Обновить";
            this.toolStripButton_5.Click += new EventHandler(this.toolStripButton_5_Click);
            this.toolStripSeparator_2.Name = "toolStripSeparator1";
            this.toolStripSeparator_2.Size = new Size(6, 0x19);
            this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_0.Image = (Image) manager.GetObject("tsbLoadFromBoss.Image");
            this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_0.Name = "tsbLoadFromBoss";
            this.toolStripButton_0.Size = new Size(0x17, 0x16);
            this.toolStripButton_0.Text = "Загрузка данных из \"Босс Референт\"";
            this.toolStripButton_0.Click += new EventHandler(this.toolStripButton_0_Click);
            this.toolStripTextBox_0.Name = "toolStripTextBox1";
            this.toolStripTextBox_0.Size = new Size(800, 0x17);
            this.toolStripTextBox_0.Visible = false;
            this.button_0.Dock = DockStyle.Right;
            this.button_0.Location = new Point(0x268, 0x196);
            this.button_0.Margin = new Padding(3, 8, 15, 10);
            this.button_0.Name = "btnComplite";
            this.button_0.Size = new Size(0x5f, 0x18);
            this.button_0.TabIndex = 2;
            this.button_0.Text = "Применить";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new EventHandler(this.button_0_Click);
            this.button_1.Dock = DockStyle.Left;
            this.button_1.Location = new Point(0x2de, 0x196);
            this.button_1.Margin = new Padding(8, 8, 3, 10);
            this.button_1.Name = "btnCancel";
            this.button_1.Size = new Size(90, 0x18);
            this.button_1.TabIndex = 3;
            this.button_1.Text = "Отмена";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new EventHandler(this.button_1_Click);
            this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToOrderColumns = true;
            this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
            style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style.BackColor = SystemColors.Control;
            style.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style.ForeColor = SystemColors.WindowText;
            style.SelectionBackColor = SystemColors.Highlight;
            style.SelectionForeColor = SystemColors.HighlightText;
            style.WrapMode = DataGridViewTriState.True;
            this.dataGridViewExcelFilter_0.ColumnHeadersDefaultCellStyle = style;
            this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { 
                this.dataGridViewFilterCheckBoxColumn_0, this.dataGridViewTextBoxColumn_0, this.dataGridViewTextBoxColumn_1, this.dataGridViewTextBoxColumn_2, this.dataGridViewTextBoxColumn_3, this.dataGridViewTextBoxColumn_4, this.dataGridViewFilterTextBoxColumn_0, this.dataGridViewFilterTextBoxColumn_1, this.dataGridViewFilterTextBoxColumn_2, this.dataGridViewFilterTextBoxColumn_3, this.dataGridViewTextBoxColumn_5, this.dataGridViewTextBoxColumn_6, this.dataGridViewFilterTextBoxColumn_4, this.dataGridViewTextBoxColumn_7, this.dataGridViewTextBoxColumn_8, this.dataGridViewTextBoxColumn_9,
                this.dataGridViewCheckBoxColumn_0
            };
            this.dataGridViewExcelFilter_0.Columns.AddRange(dataGridViewColumns);
            this.tableLayoutPanel_0.SetColumnSpan(this.dataGridViewExcelFilter_0, 4);
            this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
            style2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style2.BackColor = SystemColors.Window;
            style2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style2.ForeColor = SystemColors.ControlText;
            style2.SelectionBackColor = SystemColors.Highlight;
            style2.SelectionForeColor = SystemColors.HighlightText;
            style2.WrapMode = DataGridViewTriState.False;
            this.dataGridViewExcelFilter_0.DefaultCellStyle = style2;
            this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_0.Location = new Point(3, 0x1d);
            this.dataGridViewExcelFilter_0.Name = "dgvMemorandums";
            style3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style3.BackColor = SystemColors.Control;
            style3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style3.ForeColor = SystemColors.WindowText;
            style3.SelectionBackColor = SystemColors.Highlight;
            style3.SelectionForeColor = SystemColors.HighlightText;
            style3.WrapMode = DataGridViewTriState.True;
            this.dataGridViewExcelFilter_0.RowHeadersDefaultCellStyle = style3;
            this.dataGridViewExcelFilter_0.RowHeadersVisible = false;
            this.dataGridViewExcelFilter_0.RowHeadersWidth = 0x15;
            this.tableLayoutPanel_0.SetRowSpan(this.dataGridViewExcelFilter_0, 2);
            this.dataGridViewExcelFilter_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExcelFilter_0.Size = new Size(0x345, 0x16e);
            this.dataGridViewExcelFilter_0.TabIndex = 4;
            this.dataGridViewExcelFilter_0.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_0_CellDoubleClick);
            this.dataGridViewExcelFilter_0.DataError += new DataGridViewDataErrorEventHandler(this.dataGridViewExcelFilter_0_DataError);
            this.dataGridViewFilterCheckBoxColumn_0.HeaderText = "";
            this.dataGridViewFilterCheckBoxColumn_0.Name = "isSelected";
            this.dataGridViewFilterCheckBoxColumn_0.Width = 30;
            this.dataGridViewTextBoxColumn_0.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_0.HeaderText = "id";
            this.dataGridViewTextBoxColumn_0.Name = "idDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_0.Visible = false;
            this.dataGridViewTextBoxColumn_1.DataPropertyName = "idTehConnect";
            this.dataGridViewTextBoxColumn_1.HeaderText = "idTehConnect";
            this.dataGridViewTextBoxColumn_1.Name = "idTehConnectDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_1.Visible = false;
            this.dataGridViewTextBoxColumn_2.DataPropertyName = "idWorker";
            this.dataGridViewTextBoxColumn_2.HeaderText = "idWorker";
            this.dataGridViewTextBoxColumn_2.Name = "idWorkerDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_2.Visible = false;
            this.dataGridViewTextBoxColumn_3.DataPropertyName = "UniversalID";
            this.dataGridViewTextBoxColumn_3.HeaderText = "UniversalID";
            this.dataGridViewTextBoxColumn_3.Name = "universalIDDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_3.Visible = false;
            this.dataGridViewTextBoxColumn_4.DataPropertyName = "ctb_InheritedID";
            this.dataGridViewTextBoxColumn_4.HeaderText = "ctb_InheritedID";
            this.dataGridViewTextBoxColumn_4.Name = "ctbInheritedIDDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_4.Visible = false;
            this.dataGridViewFilterTextBoxColumn_0.DataPropertyName = "Status";
            this.dataGridViewFilterTextBoxColumn_0.HeaderText = "Статус";
            this.dataGridViewFilterTextBoxColumn_0.Name = "statusDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_0.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_1.DataPropertyName = "StatusOrder";
            this.dataGridViewFilterTextBoxColumn_1.HeaderText = "Статус поручения";
            this.dataGridViewFilterTextBoxColumn_1.Name = "statusOrderDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_1.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_1.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_1.Visible = false;
            this.dataGridViewFilterTextBoxColumn_2.DataPropertyName = "RgNum";
            this.dataGridViewFilterTextBoxColumn_2.HeaderText = "Рег. номер";
            this.dataGridViewFilterTextBoxColumn_2.Name = "rgNumDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_2.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_2.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_2.Width = 150;
            this.dataGridViewFilterTextBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewFilterTextBoxColumn_3.DataPropertyName = "Subject";
            this.dataGridViewFilterTextBoxColumn_3.HeaderText = "По вопросу";
            this.dataGridViewFilterTextBoxColumn_3.Name = "subjectDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_3.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_3.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_5.DataPropertyName = "Body_C";
            this.dataGridViewTextBoxColumn_5.HeaderText = "Body_C";
            this.dataGridViewTextBoxColumn_5.Name = "bodyCDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_5.Visible = false;
            this.dataGridViewTextBoxColumn_6.DataPropertyName = "RespDate";
            this.dataGridViewTextBoxColumn_6.HeaderText = "RespDate";
            this.dataGridViewTextBoxColumn_6.Name = "respDateDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_6.Visible = false;
            this.dataGridViewFilterTextBoxColumn_4.DataPropertyName = "SignDate";
            this.dataGridViewFilterTextBoxColumn_4.HeaderText = "Дата подписи";
            this.dataGridViewFilterTextBoxColumn_4.Name = "signDateDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_4.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_4.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_7.DataPropertyName = "RespNum";
            this.dataGridViewTextBoxColumn_7.HeaderText = "RespNum";
            this.dataGridViewTextBoxColumn_7.Name = "respNumDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_7.Visible = false;
            this.dataGridViewTextBoxColumn_8.DataPropertyName = "CorrName";
            this.dataGridViewTextBoxColumn_8.HeaderText = "CorrName";
            this.dataGridViewTextBoxColumn_8.Name = "corrNameDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_8.Visible = false;
            this.dataGridViewTextBoxColumn_9.DataPropertyName = "ctbDateCreate";
            this.dataGridViewTextBoxColumn_9.HeaderText = "ctbDateCreate";
            this.dataGridViewTextBoxColumn_9.Name = "ctbDateCreateDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_9.Visible = false;
            this.dataGridViewCheckBoxColumn_0.DataPropertyName = "Deleted";
            this.dataGridViewCheckBoxColumn_0.HeaderText = "Deleted";
            this.dataGridViewCheckBoxColumn_0.Name = "deletedDataGridViewCheckBoxColumn";
            this.dataGridViewCheckBoxColumn_0.Visible = false;
            this.bindingSource_0.DataMember = "vJ_Memorandum";
            this.bindingSource_0.DataSource = this.dataSetGES_0;
            this.bindingSource_0.CurrentChanged += new EventHandler(this.bindingSource_0_CurrentChanged);
            this.dataSetGES_0.DataSetName = "DataSetGES";
            this.dataSetGES_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.progressBar_0.Dock = DockStyle.Fill;
            this.progressBar_0.Location = new Point(8, 0x196);
            this.progressBar_0.Margin = new Padding(8, 8, 3, 10);
            this.progressBar_0.Name = "psbMemorandum";
            this.progressBar_0.Size = new Size(0x142, 0x18);
            this.progressBar_0.TabIndex = 5;
            this.bindingSource_2.DataMember = "tJ_MemFiles";
            this.bindingSource_2.DataSource = this.dataSetGES_0;
            this.bindingSource_2.Filter = "TypeDoc = 1";
            this.bindingSource_1.DataMember = "tJ_MemFiles";
            this.bindingSource_1.DataSource = this.dataSetGES_0;
            this.bindingSource_1.Filter = "TypeDoc = 2";
            this.bindingSource_3.DataMember = "vJ_MemCommission";
            this.bindingSource_3.DataSource = this.dataSetGES_0;
            this.bindingSource_3.CurrentChanged += new EventHandler(this.bindingSource_3_CurrentChanged);
            this.backgroundWorker_0.WorkerReportsProgress = true;
            this.backgroundWorker_0.WorkerSupportsCancellation = true;
            this.backgroundWorker_0.DoWork += new DoWorkEventHandler(this.backgroundWorker_0_DoWork);
            this.backgroundWorker_0.ProgressChanged += new ProgressChangedEventHandler(this.backgroundWorker_0_ProgressChanged);
            this.backgroundWorker_0.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.backgroundWorker_0_RunWorkerCompleted);
            this.label_0.AutoSize = true;
            this.label_0.Dock = DockStyle.Fill;
            this.label_0.Location = new Point(0x150, 0x18e);
            this.label_0.Name = "lbStatus";
            this.label_0.Size = new Size(0x106, 0x2a);
            this.label_0.TabIndex = 6;
            this.label_0.TextAlign = ContentAlignment.MiddleLeft;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x34b, 440);
            base.Controls.Add(this.tableLayoutPanel_0);
            base.Name = "FormMemorandumJournal";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Разрешения на тех. присоединение";
            base.FormClosing += new FormClosingEventHandler(this.FormMemorandumJournal_FormClosing);
            base.Load += new EventHandler(this.FormMemorandumJournal_Load);
            this.tableLayoutPanel_0.ResumeLayout(false);
            this.tableLayoutPanel_0.PerformLayout();
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            this.dataGridViewExcelFilter_0.EndInit();
            ((ISupportInitialize) this.bindingSource_0).EndInit();
            this.dataSetGES_0.EndInit();
            ((ISupportInitialize) this.bindingSource_2).EndInit();
            ((ISupportInitialize) this.bindingSource_1).EndInit();
            ((ISupportInitialize) this.bindingSource_3).EndInit();
            base.ResumeLayout(false);
        }

        [CompilerGenerated]
        private bool method_28(DataSetGES.Class150 class150_0)
        {
            return ((class150_0.RowState == DataRowState.Unchanged) && (class150_0.Int32_0 == ((int) ((DataRowView) this.bindingSource_0.Current)["id"])));
        }

        private void method_3(string string_1, int int_1, List<Class221> list_0, int int_2, DataTable dataTable_0)
        {
            foreach (Class221 class2 in list_0)
            {
                int num = -1;
                this.dataSetGES_0.tJ_MemCommission.Rows.Clear();
                base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_MemCommission, true, string.Format("WHERE UNID = '{0}' AND Deleted = 0", class2.UniversalID));
                if (this.dataSetGES_0.tJ_MemCommission.Count<DataSetGES.Class155>() > 0)
                {
                    this.method_7("Обновляем данные в таблице поручений...");
                    string str = string.Format("update tJ_MemCommission set UNID = '{0}'", class2.UniversalID);
                    if (class2.ctbSubject != "")
                    {
                        str = str + string.Format(",[Subject] = '{0}'", class2.ctbSubject);
                    }
                    if (class2.Body != "")
                    {
                        str = str + string.Format(",[Body] = '{0}'", class2.Body);
                    }
                    if (class2.ctbDateFact.Length >= 10)
                    {
                        str = str + string.Format(",[DateFact] = CONVERT(SMALLDATETIME,'{0}',101)", this.method_8(class2.ctbDateFact));
                    }
                    if (class2.ctbComment != "")
                    {
                        str = str + string.Format(",[Comment] = '{0}'", class2.ctbComment);
                    }
                    if (class2.ctbExecutor != "")
                    {
                        str = str + string.Format(",[Performer] = '{0}'", this.method_6(class2.ctbExecutor, dataTable_0));
                    }
                    if (class2.ctbStatus != "")
                    {
                        str = str + string.Format(",[Status] = '{0}'", this.method_10(class2));
                    }
                    str = str + string.Format(" WHERE UNID = '{0}'", class2.UniversalID);
                    num = (int) base.SelectSqlData("tJ_MemCommission", 1, string.Format(" WHERE UNID = '{0}'", class2.UniversalID)).Rows[0]["id"];
                    this.method_16(this.get_SqlSettings(), str);
                }
                else
                {
                    this.method_7("Вставляем данные в таблицу поручений...");
                    string str2 = "idMemorandum, UNID, Deleted,Comment";
                    string str3 = string.Format("{0},'{1}', 0, '{2}'", int_1, class2.UniversalID, class2.ctbComment);
                    if (class2.ctbDateFact.Length >= 10)
                    {
                        str2 = str2 + ",[DateFact]";
                        str3 = str3 + string.Format(",CONVERT(SMALLDATETIME,'{0}',101)", this.method_8(class2.ctbDateFact));
                    }
                    if (class2.ctbExecutor != "")
                    {
                        str2 = str2 + ",[Performer]";
                        str3 = str3 + string.Format(",{0}", this.method_6(class2.ctbExecutor, dataTable_0));
                    }
                    if (class2.ctbStatus != "")
                    {
                        str2 = str2 + ",[Status]";
                        str3 = str3 + string.Format(",{0}", this.method_10(class2));
                    }
                    string str4 = string.Format("insert into tJ_MemCommission ({0}) values ({1})", str2, str3);
                    num = this.method_13(str4, "tJ_MemCommission");
                }
                this.method_4(class2.Files, Enum18.const_1, num);
            }
        }

        private void method_4(List<Class224> list_0, Enum18 enum18_0, int int_1)
        {
            if (list_0 != null)
            {
                DataSetGES tges = new DataSetGES();
                base.SelectSqlData(tges, tges.tJ_MemFiles, true, string.Format("WHERE TypeDoc = {0} AND idDocument = {1} AND Deleted = 0", (int) enum18_0, int_1));
                using (List<Class224>.Enumerator enumerator = list_0.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        Class298 class2 = new Class298 {
                            class224_0 = enumerator.Current
                        };
                        EnumerableRowCollection<DataSetGES.Class149> source = tges.tJ_MemFiles.Where<DataSetGES.Class149>(new Func<DataSetGES.Class149, bool>(class2.method_0));
                        if (source.Count<DataSetGES.Class149>() > 0)
                        {
                            this.method_7("Обновляем данные в таблице файлов...");
                            DataSetGES.Class149 class3 = source.First<DataSetGES.Class149>();
                            class3.Deleted = false;
                            class3.File = class2.class224_0.method_6();
                            class3.idDocument = int_1;
                            if (class2.class224_0.method_4() > new DateTime(0x7b2, 1, 1))
                            {
                                class3.LastChange = class2.class224_0.method_4();
                            }
                            class3.Name = class2.class224_0.Name;
                            class3.TypeDoc = (int) enum18_0;
                            class3.EndEdit();
                        }
                        else
                        {
                            this.method_7("Вставляем данные в таблицу файлов...");
                            DataSetGES.Class149 class4 = tges.tJ_MemFiles.method_5();
                            class4.Deleted = false;
                            class4.File = class2.class224_0.method_6();
                            class4.idDocument = int_1;
                            if (class2.class224_0.method_4() > new DateTime(0x7b2, 1, 1))
                            {
                                class4.LastChange = class2.class224_0.method_4();
                            }
                            class4.Name = class2.class224_0.Name;
                            class4.TypeDoc = (int) enum18_0;
                            class4.EndEdit();
                            tges.tJ_MemFiles.method_0(class4);
                        }
                        base.InsertSqlData(tges.tJ_MemFiles);
                        base.UpdateSqlData(tges.tJ_MemFiles);
                    }
                }
            }
        }

        private void method_5(int int_1, Enum19 enum19_0, DataTable dataTable_0, string string_1)
        {
            Class299 class2 = new Class299();
            this.method_7("Вставляем данные в таблицу пользователей...");
            DataSetGES tges = new DataSetGES();
            base.SelectSqlData(tges, tges.tJ_MemWorker, true, string.Format("WHERE Deleted = 0 AND idMemorandum = {0} AND typeWorker = {1}", int_1, (int) enum19_0));
            char[] separator = new char[] { ';' };
            class2.list_0 = string_1.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
            class2.enumerableRowCollection_0 = dataTable_0.AsEnumerable().Where<DataRow>(new Func<DataRow, bool>(class2.method_0)).Select<DataRow, int>(<>c.<>9__22_1 ?? (<>c.<>9__22_1 = new Func<DataRow, int>(<>c.<>9.method_1)));
            tges.tJ_MemWorker.Where<DataSetGES.Class152>(new Func<DataSetGES.Class152, bool>(class2.method_1)).ToList<DataSetGES.Class152>().ForEach(<>c.<>9__22_3 ?? (<>c.<>9__22_3 = new Action<DataSetGES.Class152>(<>c.<>9.method_2)));
            foreach (int num in class2.enumerableRowCollection_0)
            {
                if (!tges.tJ_MemWorker.Select<DataSetGES.Class152, int>((<>c.<>9__22_4 ?? (<>c.<>9__22_4 = new Func<DataSetGES.Class152, int>(<>c.<>9.method_3)))).Contains<int>(num))
                {
                    DataSetGES.Class152 class3 = tges.tJ_MemWorker.method_5();
                    class3.idMemorandum = int_1;
                    class3.idWorker = num;
                    class3.typeWorker = (int) enum19_0;
                    class3.Deleted = false;
                    class3.EndEdit();
                    tges.tJ_MemWorker.method_0(class3);
                }
            }
            base.InsertSqlData(tges.tJ_MemWorker);
        }

        private int method_6(string string_1, DataTable dataTable_0)
        {
            Class300 class2 = new Class300 {
                string_0 = string_1
            };
            EnumerableRowCollection<int> source = dataTable_0.AsEnumerable().Where<DataRow>(new Func<DataRow, bool>(class2.method_0)).Select<DataRow, int>(<>c.<>9__23_1 ?? (<>c.<>9__23_1 = new Func<DataRow, int>(<>c.<>9.method_4)));
            if (source.Count<int>() > 0)
            {
                return source.First<int>();
            }
            return -1;
        }

        private void method_7(string string_1)
        {
            Class301 class2 = new Class301 {
                formMemorandumJournal_0 = this,
                string_0 = string_1
            };
            if (this.label_0.InvokeRequired)
            {
                Dispatcher.Invoke(this, new AsyncAction(class2, (IntPtr) this.method_0));
            }
            else
            {
                this.label_0.Text = class2.string_0;
            }
        }

        private string method_8(string string_1)
        {
            if (string.IsNullOrEmpty(string_1) && (string_1.Length < 10))
            {
                return null;
            }
            char[] separator = new char[] { '.' };
            string[] source = string_1.Substring(0, 10).Split(separator);
            if (source.Count<string>() != 3)
            {
                return null;
            }
            string[] textArray1 = new string[] { source[1], "/", source[0], "/", source[2] };
            return string.Concat(textArray1);
        }

        private int method_9()
        {
            DataTable table = base.SelectSqlData("tUser", true, "WHERE [Login] LIKE SYSTEM_USER");
            if (table.Rows.Count > 0)
            {
                return (int) table.Rows[0]["IDUser"];
            }
            return -1;
        }

        private void toolStripButton_0_Click(object sender, EventArgs e)
        {
            this.toolStripButton_0.Enabled = false;
            this.class220_0 = this.method_12();
            if (this.class220_0 == null)
            {
                this.toolStripButton_0.Enabled = true;
            }
            else
            {
                this.backgroundWorker_0.RunWorkerAsync();
            }
        }

        private void toolStripButton_1_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButton_2_Click(object sender, EventArgs e)
        {
            this.method_19();
        }

        private void toolStripButton_3_Click(object sender, EventArgs e)
        {
            this.method_21();
        }

        private void toolStripButton_4_Click(object sender, EventArgs e)
        {
            this.method_22();
        }

        private void toolStripButton_5_Click(object sender, EventArgs e)
        {
            this.method_24(true);
        }

        public StateFormCreate CreateState
        {
            get
            {
                return this.stateFormCreate_0;
            }
            set
            {
                this.stateFormCreate_0 = value;
            }
        }

        public int IdTU
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

        [Serializable, CompilerGenerated]
        private sealed class <>c
        {
            public static readonly FormMemorandumJournal.<>c <>9 = new FormMemorandumJournal.<>c();
            public static Func<DataSetGES.Class150, string> <>9__17_0;
            public static Func<DataRow, int> <>9__22_1;
            public static Action<DataSetGES.Class152> <>9__22_3;
            public static Func<DataSetGES.Class152, int> <>9__22_4;
            public static Func<DataRow, int> <>9__23_1;

            internal string method_0(DataSetGES.Class150 class150_0)
            {
                return class150_0.UniversalID;
            }

            internal int method_1(DataRow dataRow_0)
            {
                return dataRow_0.Field<int>("id");
            }

            internal void method_2(DataSetGES.Class152 class152_0)
            {
                class152_0.Deleted = true;
            }

            internal int method_3(DataSetGES.Class152 class152_0)
            {
                return class152_0.idWorker;
            }

            internal int method_4(DataRow dataRow_0)
            {
                return dataRow_0.Field<int>("id");
            }
        }

        [CompilerGenerated]
        private sealed class Class297
        {
            public Class222 class222_0;

            internal bool method_0(DataSetGES.Class150 class150_0)
            {
                return (class150_0.UniversalID == this.class222_0.UniversalID);
            }

            internal bool method_1(Class221 class221_0)
            {
                return (class221_0.ctb_InheritedID == this.class222_0.UniversalID);
            }
        }

        [CompilerGenerated]
        private sealed class Class298
        {
            public Class224 class224_0;

            internal bool method_0(DataSetGES.Class149 class149_0)
            {
                return (class149_0.Name == this.class224_0.Name);
            }
        }

        [CompilerGenerated]
        private sealed class Class299
        {
            public EnumerableRowCollection<int> enumerableRowCollection_0;
            public List<string> list_0;

            internal bool method_0(DataRow dataRow_0)
            {
                return ((dataRow_0["FullFIO"] != DBNull.Value) && this.list_0.Contains(dataRow_0.Field<string>("FullFIO")));
            }

            internal bool method_1(DataSetGES.Class152 class152_0)
            {
                return !this.enumerableRowCollection_0.Contains<int>(class152_0.idWorker);
            }
        }

        [CompilerGenerated]
        private sealed class Class300
        {
            public string string_0;

            internal bool method_0(DataRow dataRow_0)
            {
                return ((dataRow_0["FullFIO"] != DBNull.Value) && this.string_0.Contains(dataRow_0.Field<string>("FullFIO")));
            }
        }

        [CompilerGenerated]
        private sealed class Class301
        {
            public FormMemorandumJournal formMemorandumJournal_0;
            public string string_0;

            internal void method_0()
            {
                this.formMemorandumJournal_0.label_0.Text = this.string_0;
            }
        }

        [CompilerGenerated]
        private sealed class Class302
        {
            public bool bool_0;
            public FormMemorandumJournal formMemorandumJournal_0;

            internal void method_0()
            {
                this.formMemorandumJournal_0.progressBar_0.Style = this.bool_0 ? ProgressBarStyle.Marquee : ProgressBarStyle.Blocks;
            }
        }
    }
}

