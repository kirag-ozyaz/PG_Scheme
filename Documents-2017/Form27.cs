using Constants;
using DataSql;
using Documents.Classes;
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
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

internal class Form27 : FormBase
{
    private BackgroundWorker backgroundWorker_0;
    private BindingSource bindingSource_0;
    private BindingSource bindingSource_1;
    private BindingSource bindingSource_10;
    private BindingSource bindingSource_11;
    private BindingSource bindingSource_2;
    private BindingSource bindingSource_3;
    private BindingSource bindingSource_4;
    private BindingSource bindingSource_5;
    private BindingSource bindingSource_6;
    private BindingSource bindingSource_7;
    private BindingSource bindingSource_8;
    private BindingSource bindingSource_9;
    private Button button_0;
    private Button button_1;
    private Button button_2;
    private Button button_3;
    private Class222 class222_0;
    private Class223 class223_0;
    private DataGridView dataGridView_0;
    private DataGridView dataGridView_1;
    private DataGridView dataGridView_2;
    private DataGridView dataGridView_3;
    private DataGridView dataGridView_4;
    private DataGridView dataGridView_5;
    private DataGridView dataGridView_6;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_2;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_3;
    private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_0;
    private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_1;
    private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_2;
    private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_3;
    private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_4;
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
    [CompilerGenerated]
    private int int_1;
    [CompilerGenerated]
    private int int_2;
    private Label label_0;
    private Label label_1;
    private Label label_2;
    private Label label_3;
    private Label label_4;
    private Label label_5;
    private List<string> list_0;
    private OpenFileDialog openFileDialog_0;
    private ProgressBar progressBar_0;
    [CompilerGenerated]
    private StateFormCreate stateFormCreate_0;
    private Status status_0 = Status.D;
    [CompilerGenerated]
    private string string_0;
    private readonly string string_1 = "192.168.1.253";
    private readonly string string_2 = (Environment.GetFolderPath(Environment.SpecialFolder.Templates) + @"\LotusTemp\");
    private TabControl tabControl_0;
    private TabControl tabControl_1;
    private TableLayoutPanel tableLayoutPanel_0;
    private TableLayoutPanel tableLayoutPanel_1;
    private TableLayoutPanel tableLayoutPanel_2;
    private TableLayoutPanel tableLayoutPanel_3;
    private TabPage tabPage_0;
    private TabPage tabPage_1;
    private TabPage tabPage_2;
    private TabPage tabPage_3;
    private TabPage tabPage_4;
    private TabPage tabPage_5;
    private TextBox textBox_0;
    private TextBox textBox_1;
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
    private ToolStripSeparator toolStripSeparator_0;
    private ToolStripSeparator toolStripSeparator_1;

    public Form27()
    {
        this.method_34();
    }

    private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
    {
        this.method_31(true);
        string str = e.Argument.ToString();
        this.method_19(str);
    }

    private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
        this.method_31(false);
        this.method_14();
        this.method_17();
    }

    private void bindingSource_11_AddingNew(object sender, AddingNewEventArgs e)
    {
        if (e.NewObject != null)
        {
            ((DataRowView) e.NewObject)["idWorker"] = -1;
        }
    }

    private void bindingSource_6_CurrentChanged(object sender, EventArgs e)
    {
        this.method_17();
    }

    private void button_0_Click(object sender, EventArgs e)
    {
        base.DialogResult = DialogResult.OK;
        this.status_0 = Status.A;
        base.Close();
    }

    private void button_1_Click(object sender, EventArgs e)
    {
        base.DialogResult = DialogResult.Cancel;
        base.Close();
    }

    private void button_2_Click(object sender, EventArgs e)
    {
        base.DialogResult = DialogResult.OK;
        base.Close();
    }

    private void button_3_Click(object sender, EventArgs e)
    {
        this.method_32();
    }

    private void dataGridView_2_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
    }

    private void dataGridView_4_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
    }

    private void dataGridView_6_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

    private void Form27_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (base.DialogResult == DialogResult.OK)
        {
            try
            {
                if (!this.method_16())
                {
                    base.DialogResult = DialogResult.Cancel;
                    e.Cancel = true;
                }
            }
            catch (Exception)
            {
                base.DialogResult = DialogResult.Cancel;
                e.Cancel = true;
            }
        }
    }

    private void Form27_Load(object sender, EventArgs e)
    {
        this.method_12();
    }

    [CompilerGenerated]
    internal int method_0()
    {
        return this.int_0;
    }

    [CompilerGenerated]
    internal void method_1(int int_3)
    {
        this.int_0 = int_3;
    }

    private EISSettings method_10()
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

    private Class220 method_11()
    {
        Class220 class2;
        try
        {
            this.eissettings_0 = this.method_10();
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
            this.class223_0 = class2.method_6();
        }
        catch (Exception exception1)
        {
            MessageBox.Show(exception1.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            return null;
        }
        return class2;
    }

    private void method_12()
    {
        StateFormCreate create = this.method_8();
        if (create != null)
        {
            if (create != 1)
            {
                if (create == 7)
                {
                    this.dataGridView_1.AllowUserToAddRows = false;
                    this.dataGridView_0.AllowUserToAddRows = false;
                    this.dataGridView_2.AllowUserToAddRows = false;
                    this.dataGridView_1.ReadOnly = true;
                    this.dataGridView_0.ReadOnly = true;
                    this.dataGridView_2.ReadOnly = true;
                    this.button_2.Visible = false;
                    this.button_0.Visible = false;
                    this.toolStripButton_7.Enabled = false;
                    this.toolStripButton_5.Enabled = false;
                    this.toolStripButton_0.Enabled = false;
                    this.toolStripButton_1.Enabled = false;
                }
            }
            else
            {
                this.dataGridView_1.AllowUserToAddRows = true;
                this.dataGridView_0.AllowUserToAddRows = true;
                this.dataGridView_2.AllowUserToAddRows = true;
                this.dataGridView_1.AllowUserToDeleteRows = true;
                this.dataGridView_0.AllowUserToDeleteRows = true;
                this.dataGridView_2.AllowUserToDeleteRows = true;
                this.dataGridView_1.ReadOnly = false;
                this.dataGridView_0.ReadOnly = false;
                this.dataGridView_2.ReadOnly = false;
                this.button_2.Visible = true;
                this.button_0.Visible = true;
                this.toolStripButton_7.Enabled = true;
                this.toolStripButton_5.Enabled = true;
                this.toolStripButton_0.Enabled = true;
                this.toolStripButton_1.Enabled = true;
            }
        }
        else
        {
            this.tabPage_4.Parent = null;
            this.dataGridView_1.AllowUserToDeleteRows = true;
            this.dataGridView_0.AllowUserToDeleteRows = true;
            this.dataGridView_2.AllowUserToDeleteRows = true;
        }
        if (!Directory.Exists(this.string_2))
        {
            Directory.CreateDirectory(this.string_2);
        }
        base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.vJ_BossUser, true);
        if ((this.method_8() == 7) || (this.method_8() == 1))
        {
            base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_Memorandum, true, "WHERE id = " + this.method_4().ToString() + " AND Deleted = ((0))");
            base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_MemWorker, true, "WHERE idMemorandum = " + this.method_4().ToString() + " AND Deleted = ((0))");
            base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_MemCommission, true, "WHERE idMemorandum = " + this.method_4().ToString() + " AND Deleted = ((0))");
            base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.vJ_MemCommission, true, "WHERE idMemorandum = " + this.method_4().ToString() + " AND Deleted = ((0))");
            this.method_17();
            this.method_7((this.dataSetGES_0.tJ_Memorandum.First<DataSetGES.Class150>()["UniversalID"] != DBNull.Value) ? this.dataSetGES_0.tJ_Memorandum.First<DataSetGES.Class150>().UniversalID : "");
        }
        base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.vJ_BossUser, true, "");
        this.dataSetGES_0.tJ_MemWorker.TableNewRow += new DataTableNewRowEventHandler(this.method_13);
        if ((this.method_8() == 1) && !string.IsNullOrEmpty(this.method_6()))
        {
            this.backgroundWorker_0.RunWorkerAsync(this.method_6());
        }
    }

    private void method_13(object sender, DataTableNewRowEventArgs e)
    {
        e.Row["idMemorandum"] = -1;
        e.Row["Deleted"] = false;
        e.Row["typeWorker"] = (this.tabControl_0.SelectedTab == this.tabPage_0) ? 0x511 : ((this.tabControl_0.SelectedTab == this.tabPage_2) ? 0x512 : ((this.tabControl_0.SelectedTab == this.tabPage_1) ? 0x514 : -1));
    }

    private void method_14()
    {
        base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_Memorandum, true, string.Format("WHERE id = {0} AND Deleted = ((0))", this.method_4()));
        base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_MemCommission, true, string.Format("WHERE idMemorandum = {0} AND Deleted = ((0))", this.method_4()));
        this.method_17();
    }

    private string method_15(int int_3)
    {
        Class36 class2 = new Class36 {
            int_0 = int_3
        };
        class2.int_1 = this.dataSetGES_0.tJ_MemWorker.Where<DataSetGES.Class152>(new Func<DataSetGES.Class152, bool>(class2.method_0)).First<DataSetGES.Class152>().idWorker;
        return this.dataSetGES_0.vJ_BossUser.Where<DataSetGES.Class148>(new Func<DataSetGES.Class148, bool>(class2.method_1)).First<DataSetGES.Class148>().FIO;
    }

    private bool method_16()
    {
        int num = 1;
        try
        {
            EnumerableRowCollection<DataSetGES.Class148> source = this.dataSetGES_0.vJ_BossUser.Where<DataSetGES.Class148>(new Func<DataSetGES.Class148, bool>(this.method_35));
            if (source.Count<DataSetGES.Class148>() == 0)
            {
                MessageBox.Show("Не выбраны адресаты.", "Предупреждение.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            string[] strArray = source.Select<DataSetGES.Class148, string>((<>c.<>9__39_3 ?? (<>c.<>9__39_3 = new Func<DataSetGES.Class148, string>(<>c.<>9.method_2)))).ToArray<string>();
            EnumerableRowCollection<DataSetGES.Class148> rows2 = this.dataSetGES_0.vJ_BossUser.Where<DataSetGES.Class148>(new Func<DataSetGES.Class148, bool>(this.method_36));
            if (rows2.Count<DataSetGES.Class148>() == 0)
            {
                MessageBox.Show("Не выбраны подписанты.", "Предупреждение.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            string str = rows2.Select<DataSetGES.Class148, string>((<>c.<>9__39_7 ?? (<>c.<>9__39_7 = new Func<DataSetGES.Class148, string>(<>c.<>9.method_5)))).First<string>();
            EnumerableRowCollection<DataSetGES.Class148> rows3 = this.dataSetGES_0.vJ_BossUser.Where<DataSetGES.Class148>(new Func<DataSetGES.Class148, bool>(this.method_37));
            if (rows3.Count<DataSetGES.Class148>() == 0)
            {
                MessageBox.Show("Не выбраны визирующие.", "Предупреждение.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            string[] strArray2 = rows3.Select<DataSetGES.Class148, string>((<>c.<>9__39_11 ?? (<>c.<>9__39_11 = new Func<DataSetGES.Class148, string>(<>c.<>9.method_8)))).ToArray<string>();
            Class220 class2 = this.method_11();
            bool flag = false;
            if (class2 != null)
            {
                MessageBox.Show(++num.ToString());
                StateFormCreate create = this.method_8();
                if (create != null)
                {
                    if (create != 1)
                    {
                        return false;
                    }
                    flag = class2.method_10(this.method_6(), "Служебная записка (ТП)", this.textBox_0.Text, this.textBox_1.Text, this.status_0, strArray, str, strArray2, this.list_0);
                    this.method_7(class2.method_2());
                }
                else
                {
                    flag = class2.method_9("Служебная записка (ТП)", this.textBox_0.Text, this.textBox_1.Text, this.status_0, strArray, str, strArray2, this.list_0);
                    this.method_7(class2.method_2());
                }
            }
            MessageBox.Show("Saving lotus");
            if (flag)
            {
                if (this.method_8() == null)
                {
                    DataSetGES.Class150 class3 = this.dataSetGES_0.tJ_Memorandum.method_5();
                    class3.idTehConnect = this.method_0();
                    class3.idWorker = this.method_2();
                    class3.Status = (int) this.status_0;
                    class3.Subject = this.textBox_0.Text;
                    class3.Body_C = this.textBox_1.Text;
                    class3.ctbDateCreate = DateTime.Now;
                    if (class2 != null)
                    {
                        class3.UniversalID = class2.method_2();
                    }
                    class3.Deleted = false;
                    class3.EndEdit();
                    this.method_5(base.InsertSqlDataOneRow(class3));
                    if (this.method_4() != -1)
                    {
                        foreach (DataSetGES.Class152 local1 in this.dataSetGES_0.tJ_MemWorker)
                        {
                            local1.idMemorandum = this.method_4();
                            local1.EndEdit();
                        }
                        base.InsertSqlData(this.dataSetGES_0.tJ_MemWorker);
                        foreach (DataSetGES.Class149 local2 in this.dataSetGES_0.tJ_MemFiles)
                        {
                            local2.idDocument = this.method_4();
                            local2.TypeDoc = 1;
                            local2.EndEdit();
                        }
                        base.InsertSqlData(this.dataSetGES_0.tJ_MemFiles);
                    }
                }
                else
                {
                    this.dataSetGES_0.tJ_Memorandum.First<DataSetGES.Class150>().EndEdit();
                    base.UpdateSqlData(this.dataSetGES_0.tJ_Memorandum);
                    using (IEnumerator<DataSetGES.Class149> enumerator2 = this.dataSetGES_0.tJ_MemFiles.GetEnumerator())
                    {
                        while (enumerator2.MoveNext())
                        {
                            enumerator2.Current.EndEdit();
                        }
                    }
                    base.UpdateSqlData(this.dataSetGES_0.tJ_MemFiles);
                    base.DeleteSqlData(this.dataSetGES_0.tJ_MemFiles);
                    using (IEnumerator<DataSetGES.Class152> enumerator = this.dataSetGES_0.tJ_MemWorker.GetEnumerator())
                    {
                        while (enumerator.MoveNext())
                        {
                            enumerator.Current.EndEdit();
                        }
                    }
                    base.UpdateSqlData(this.dataSetGES_0.tJ_MemWorker);
                    base.DeleteSqlData(this.dataSetGES_0.tJ_MemWorker);
                }
            }
            return true;
        }
        catch (Exception exception1)
        {
            MessageBox.Show(exception1.ToString());
            return false;
        }
    }

    private void method_17()
    {
        using (SqlConnection connection = new SqlConnection(this.get_SqlSettings().GetConnectionString()))
        {
            string str = string.Format("WHERE (TypeDoc = 1 AND idDocument = {0})", this.method_4()) + ((this.bindingSource_6.Current != null) ? string.Format(" OR (TypeDoc = 2 AND idDocument = {0})", (int) ((DataRowView) this.bindingSource_6.Current)["id"]) : "");
            connection.Open();
            new SqlDataAdapter(new SqlCommand("SELECT [id],[idDocument],[TypeDoc],[Name],[Size],[LastChange],[Deleted] FROM tJ_MemFiles " + str, connection)).Fill(this.dataSetGES_0.tJ_MemFiles);
        }
    }

    private void method_18(BindingSource bindingSource_12, string string_3)
    {
        if (bindingSource_12.Current != null)
        {
            byte[] file;
            DataSetGES.Class149 row = (DataSetGES.Class149) ((DataRowView) bindingSource_12.Current).Row;
            string name = row.Name;
            string str2 = FileBinary.GetNewFileNameIsExists(string_3, name, false);
            if (row["LastChange"] != DBNull.Value)
            {
                DateTime lastChange = row.LastChange;
            }
            else
            {
                DateTime now = DateTime.Now;
            }
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
            binary.SaveToDisk(string_3);
            Process.Start(string_3 + @"\" + binary.get_Name());
        }
    }

    private void method_19(string string_3)
    {
        Class220 class2 = this.method_11();
        if (string.IsNullOrEmpty(string_3) && (class2 != null))
        {
            this.class222_0 = class2.method_15(string_3, true).First<Class222>();
            if (this.label_5.InvokeRequired)
            {
                Dispatcher.Invoke(this, new AsyncAction(this, (IntPtr) this.method_38));
            }
            else
            {
                this.label_5.Text = this.class222_0.SignDate + "/" + this.class222_0.RgNum;
            }
            this.method_22(this.class222_0);
            this.method_24(this.class222_0.Files, Enum18.const_0, this.method_4());
            this.method_23(string_3, class2.method_13(string_3, true), -1);
        }
    }

    [CompilerGenerated]
    internal int method_2()
    {
        return this.int_1;
    }

    private int method_20(string string_3)
    {
        DataTable table = base.SelectSqlData("tR_Classifier", true, "WHERE ParentKey = ';TechConnect;StatusMemorandum;' AND [Comment] LIKE '" + string_3 + "' AND Deleted = 0");
        if (table.Rows.Count > 0)
        {
            return (int) table.Rows[0]["Id"];
        }
        return -1;
    }

    private string method_21(string string_3)
    {
        if (string.IsNullOrEmpty(string_3) && (string_3.Length < 10))
        {
            return null;
        }
        char[] separator = new char[] { '.' };
        string[] source = string_3.Substring(0, 10).Split(separator);
        if (source.Count<string>() != 3)
        {
            return null;
        }
        string[] textArray1 = new string[] { source[1], "/", source[0], "/", source[2] };
        return string.Concat(textArray1);
    }

    private void method_22(Class222 class222_1)
    {
        string str = string.Format("update tJ_Memorandum set UniversalID = '{0}'", class222_1.UniversalID);
        if (class222_1.RespDate.Length >= 10)
        {
            str = str + string.Format(",[RespDate] = CONVERT(SMALLDATETIME,'{0}',101)", this.method_21(class222_1.RespDate));
        }
        if (class222_1.Status != "")
        {
            str = str + string.Format(",[Status] = '{0}'", this.method_20(class222_1.Status));
        }
        if (class222_1.Subject != "")
        {
            str = str + string.Format(",[Subject] = '{0}'", class222_1.Subject);
        }
        if (class222_1.Body_C != "")
        {
            str = str + string.Format(",[Body_C] = '{0}'", class222_1.Body_C);
        }
        if (class222_1.SignDate.Length >= 10)
        {
            str = str + string.Format(",[SignDate] = CONVERT(SMALLDATETIME,'{0}',101)", this.method_21(class222_1.SignDate));
        }
        if (class222_1.RgNum != "")
        {
            str = str + string.Format(",[RgNum] = '{0}'", class222_1.RgNum);
        }
        if (class222_1.RespNum != "")
        {
            str = str + string.Format(",[RespNum] = '{0}'", class222_1.RespNum);
        }
        if (class222_1.CorrName != "")
        {
            str = str + string.Format(",[CorrName] = '{0}'", class222_1.CorrName);
        }
        str = str + string.Format(" WHERE UniversalID = '{0}'", class222_1.UniversalID);
        this.method_25(this.get_SqlSettings(), str);
    }

    private void method_23(string string_3, List<Class221> list_1, int int_3)
    {
        Class37 class2 = new Class37 {
            string_0 = string_3
        };
        foreach (Class221 class3 in list_1)
        {
            int num = -1;
            if (this.dataSetGES_0.tJ_MemCommission.Where<DataSetGES.Class155>((class2.func_0 ?? (class2.func_0 = new Func<DataSetGES.Class155, bool>(class2.method_0)))).Count<DataSetGES.Class155>() > 0)
            {
                string str = string.Format("update tJ_MemCommission set UniversalID = '{0}'", class3.UniversalID);
                if (class3.ctbSubject != "")
                {
                    str = str + string.Format(",[Subject] = '{0}'", class3.ctbSubject);
                }
                if (class3.Body != "")
                {
                    str = str + string.Format(",[Body] = '{0}'", class3.Body);
                }
                if (class3.ctbDateFact.Length >= 10)
                {
                    str = str + string.Format(",[DateFact] = CONVERT(SMALLDATETIME,'{0}',101)", this.method_21(class3.ctbDateFact));
                }
                if (class3.ctbComment != "")
                {
                    str = str + string.Format(",[Comment] = '{0}'", class3.ctbComment);
                }
                if (class3.ctbExecutor != "")
                {
                    str = str + string.Format(",[Performer] = '{0}'", this.method_27(class3.ctbExecutor));
                }
                if (class3.ctbStatus != "")
                {
                    str = str + string.Format(",[Status] = '{0}'", this.method_30(class3));
                }
                str = str + string.Format(" WHERE UNID = '{0}'", class3.UniversalID);
                num = (int) base.SelectSqlData("tJ_MemCommission", 1, string.Format(" WHERE UNID = '{0}'", class3.UniversalID)).Rows[0]["id"];
                this.method_25(this.get_SqlSettings(), str);
            }
            else
            {
                string str2 = "idMemorandum, UNID, Deleted,Comment";
                string str3 = string.Format("{0},'{1}', 0, {2}", this.method_4(), class3.UniversalID, class3.ctbComment);
                if (class3.ctbDateFact.Length >= 10)
                {
                    str2 = str2 + ",[RespDate]";
                    str3 = str3 + string.Format(",CONVERT(SMALLDATETIME,'{0}',101)", class3.ctbDateFact);
                }
                if (class3.ctbExecutor != "")
                {
                    str2 = str2 + ",[Performer]";
                    str3 = str3 + string.Format(",{0}", this.method_27(class3.ctbExecutor));
                }
                if (class3.ctbStatus != "")
                {
                    str2 = str2 + ",[Status]";
                    str3 = str3 + string.Format(",{0}", this.method_30(class3));
                }
                string str4 = string.Format("insert into tJ_MemCommission ({0}) values ({1})", str2, str3);
                num = this.method_26(str4, "tJ_MemCommission");
            }
            this.method_24(class3.Files, Enum18.const_1, num);
        }
    }

    private void method_24(List<Class224> list_1, Enum18 enum18_0, int int_3)
    {
        Class38 class2 = new Class38 {
            enum18_0 = enum18_0,
            int_0 = int_3
        };
        using (List<Class224>.Enumerator enumerator = list_1.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                Class39 class3 = new Class39 {
                    class38_0 = class2,
                    class224_0 = enumerator.Current
                };
                EnumerableRowCollection<DataSetGES.Class149> source = this.dataSetGES_0.tJ_MemFiles.Where<DataSetGES.Class149>(new Func<DataSetGES.Class149, bool>(class3.method_0));
                if (source.Count<DataSetGES.Class149>() > 0)
                {
                    DataSetGES.Class149 local1 = source.First<DataSetGES.Class149>();
                    local1.Deleted = false;
                    local1.File = class3.class224_0.method_6();
                    local1.idDocument = class3.class38_0.int_0;
                    local1.LastChange = class3.class224_0.method_4();
                    local1.Name = class3.class224_0.Name;
                    local1.TypeDoc = (int) class3.class38_0.enum18_0;
                    base.UpdateSqlData(this.dataSetGES_0.tJ_MemFiles);
                }
                else
                {
                    DataSetGES.Class149 class4 = this.dataSetGES_0.tJ_MemFiles.method_5();
                    class4.Deleted = false;
                    class4.File = class3.class224_0.method_6();
                    class4.idDocument = class3.class38_0.int_0;
                    class4.LastChange = class3.class224_0.method_4();
                    class4.Name = class3.class224_0.Name;
                    class4.TypeDoc = (int) class3.class38_0.enum18_0;
                    base.InsertSqlDataOneRow(class4);
                }
            }
        }
    }

    private void method_25(SQLSettings sqlsettings_0, string string_3)
    {
        SqlDataConnect connect = new SqlDataConnect();
        try
        {
            connect.OpenConnection(sqlsettings_0);
            new SqlCommand(string_3, connect.get_Connection()).ExecuteNonQuery();
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

    private int method_26(string string_3, string string_4)
    {
        SqlDataConnect connect = new SqlDataConnect();
        int num = -1;
        try
        {
            connect.OpenConnection(this.get_SqlSettings());
            SqlTransaction transaction = connect.get_Connection().BeginTransaction();
            SqlCommand command1 = new SqlCommand(string_3, connect.get_Connection()) {
                Transaction = transaction
            };
            command1.ExecuteNonQuery();
            command1.CommandText = "select IDENT_CURRENT('" + string_4 + "')";
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

    private int method_27(string string_3)
    {
        DataTable table = base.SelectSqlData("tJ_BossUser", true, "WHERE F + ' ' + I + ' ' + O LIKE '" + string_3 + "'");
        if (table.Rows.Count > 0)
        {
            return (int) table.Rows[0]["ID"];
        }
        return -1;
    }

    private string method_28(int int_3)
    {
        DataTable table = base.SelectSqlData("tJ_BossUser", true, "WHERE id = " + int_3.ToString() + "'");
        if (table.Rows.Count > 0)
        {
            return table.Rows[0]["mail"].ToString();
        }
        return "";
    }

    private void method_29(int int_3, out string string_3, out string string_4)
    {
        string_3 = "";
        string_4 = "";
        DataTable table = base.SelectSqlData("tJ_BossUser", true, "WHERE id = " + int_3.ToString() + "'");
        if (table.Rows.Count > 0)
        {
            string_3 = (table.Rows[0]["mail"] != DBNull.Value) ? table.Rows[0]["mail"].ToString() : "";
            string_4 = (table.Rows[0]["password"] != DBNull.Value) ? table.Rows[0]["password"].ToString() : "";
        }
    }

    [CompilerGenerated]
    internal void method_3(int int_3)
    {
        this.int_1 = int_3;
    }

    private int method_30(Class221 class221_0)
    {
        DataTable table = base.SelectSqlData("tR_Classifier", true, "WHERE ParentKey = ';TechConnect;Commission;' AND [Comment] LIKE '" + class221_0.Header_Title + "' AND Deleted = 0");
        if (table.Rows.Count > 0)
        {
            return (int) table.Rows[0]["Id"];
        }
        return -1;
    }

    private void method_31(bool bool_0)
    {
        Class40 class2 = new Class40 {
            form27_0 = this,
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

    private void method_32()
    {
        if (this.dataSetGES_0.tJ_MemCommission.Rows.Count != 0)
        {
            foreach (DataGridViewRow row in (IEnumerable) this.dataGridView_6.Rows)
            {
                if ((row.Cells["Send"].Value != null) && (row.Cells["Send"].Value != DBNull.Value))
                {
                    using (IEnumerator<DataSetGES.Class155> enumerator2 = this.dataSetGES_0.tJ_MemCommission.GetEnumerator())
                    {
                        while (enumerator2.MoveNext())
                        {
                            DataSetGES.Class155 current = enumerator2.Current;
                            string str = "";
                            string str2 = "";
                            string str3 = (current["Subject"] != DBNull.Value) ? current["Subject"].ToString() : "";
                            string str4 = (current["Body"] != DBNull.Value) ? current["Body"].ToString() : "";
                            if (string.IsNullOrEmpty(this.class223_0.FIO))
                            {
                                this.method_11();
                            }
                            int num = this.method_27(this.class223_0.FIO);
                            this.method_29(num, out str, out str2);
                            if (string.IsNullOrEmpty(str))
                            {
                                goto Label_0198;
                            }
                            if (string.IsNullOrEmpty(str2))
                            {
                                goto Label_01AD;
                            }
                            if (string.IsNullOrEmpty(str3) && string.IsNullOrEmpty(str4))
                            {
                                goto Label_01C2;
                            }
                            string str5 = this.method_28((int) row.Cells["Send"].Value);
                            this.method_33(this.string_1, str, str2, str5, str3, str4, null);
                        }
                        continue;
                    Label_0198:
                        MessageBox.Show("Отсутствует адрес электронного почтового ящика в справочнике пользователей.", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        break;
                    Label_01AD:
                        MessageBox.Show("Отсутствует пароль к адресу почтового ящика в справочнике пользователей.", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        break;
                    Label_01C2:
                        MessageBox.Show("Отсутствуют заголовок и текст письма.", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        break;
                    }
                }
            }
        }
    }

    private void method_33(string string_3, string string_4, string string_5, string string_6, string string_7, string string_8, string string_9 = null)
    {
        try
        {
            MailMessage message = new MailMessage {
                From = new MailAddress(string_4)
            };
            message.To.Add(new MailAddress(string_6));
            message.Subject = string_7;
            message.Body = string_8;
            if (!string.IsNullOrEmpty(string_9))
            {
                message.Attachments.Add(new Attachment(string_9));
            }
            SmtpClient client = new SmtpClient {
                Host = string_3,
                Port = 0x19,
                EnableSsl = true
            };
            char[] separator = new char[] { '@' };
            client.Credentials = new NetworkCredential(string_4.Split(separator)[0], string_5);
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Send(message);
            message.Dispose();
        }
        catch (Exception exception)
        {
            throw new Exception("Mail.Send: " + exception.Message);
        }
    }

    private void method_34()
    {
        this.icontainer_0 = new Container();
        DataGridViewCellStyle style = new DataGridViewCellStyle();
        DataGridViewCellStyle style2 = new DataGridViewCellStyle();
        DataGridViewCellStyle style3 = new DataGridViewCellStyle();
        DataGridViewCellStyle style4 = new DataGridViewCellStyle();
        DataGridViewCellStyle style5 = new DataGridViewCellStyle();
        DataGridViewCellStyle style6 = new DataGridViewCellStyle();
        DataGridViewCellStyle style7 = new DataGridViewCellStyle();
        DataGridViewCellStyle style8 = new DataGridViewCellStyle();
        DataGridViewCellStyle style9 = new DataGridViewCellStyle();
        DataGridViewCellStyle style10 = new DataGridViewCellStyle();
        DataGridViewCellStyle style11 = new DataGridViewCellStyle();
        DataGridViewCellStyle style12 = new DataGridViewCellStyle();
        DataGridViewCellStyle style13 = new DataGridViewCellStyle();
        DataGridViewCellStyle style14 = new DataGridViewCellStyle();
        DataGridViewCellStyle style15 = new DataGridViewCellStyle();
        this.label_0 = new Label();
        this.textBox_0 = new TextBox();
        this.bindingSource_4 = new BindingSource(this.icontainer_0);
        this.dataSetGES_0 = new DataSetGES();
        this.label_1 = new Label();
        this.textBox_1 = new TextBox();
        this.tabControl_0 = new TabControl();
        this.tabPage_0 = new TabPage();
        this.dataGridView_0 = new DataGridView();
        this.dataGridViewComboBoxColumn_0 = new DataGridViewComboBoxColumn();
        this.bindingSource_0 = new BindingSource(this.icontainer_0);
        this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
        this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
        this.bindingSource_1 = new BindingSource(this.icontainer_0);
        this.tabPage_1 = new TabPage();
        this.dataGridView_1 = new DataGridView();
        this.dataGridViewComboBoxColumn_2 = new DataGridViewComboBoxColumn();
        this.bindingSource_8 = new BindingSource(this.icontainer_0);
        this.dataGridViewCheckBoxColumn_2 = new DataGridViewCheckBoxColumn();
        this.dataGridViewTextBoxColumn_27 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_28 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_29 = new DataGridViewTextBoxColumn();
        this.bindingSource_2 = new BindingSource(this.icontainer_0);
        this.tabPage_2 = new TabPage();
        this.dataGridView_2 = new DataGridView();
        this.dataGridViewComboBoxColumn_3 = new DataGridViewComboBoxColumn();
        this.bindingSource_9 = new BindingSource(this.icontainer_0);
        this.dataGridViewCheckBoxColumn_3 = new DataGridViewCheckBoxColumn();
        this.dataGridViewTextBoxColumn_30 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_31 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_32 = new DataGridViewTextBoxColumn();
        this.bindingSource_3 = new BindingSource(this.icontainer_0);
        this.tabPage_5 = new TabPage();
        this.tableLayoutPanel_3 = new TableLayoutPanel();
        this.button_3 = new Button();
        this.dataGridView_6 = new DataGridView();
        this.dataGridViewComboBoxColumn_4 = new DataGridViewComboBoxColumn();
        this.bindingSource_10 = new BindingSource(this.icontainer_0);
        this.bindingSource_11 = new BindingSource(this.icontainer_0);
        this.button_0 = new Button();
        this.button_1 = new Button();
        this.tabControl_1 = new TabControl();
        this.tabPage_3 = new TabPage();
        this.tableLayoutPanel_0 = new TableLayoutPanel();
        this.toolStrip_0 = new ToolStrip();
        this.toolStripButton_0 = new ToolStripButton();
        this.toolStripButton_4 = new ToolStripButton();
        this.toolStripSeparator_0 = new ToolStripSeparator();
        this.toolStripButton_1 = new ToolStripButton();
        this.toolStripButton_2 = new ToolStripButton();
        this.dataGridView_3 = new DataGridView();
        this.dataGridViewTextBoxColumn_12 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_13 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_14 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_15 = new DataGridViewTextBoxColumn();
        this.bindingSource_5 = new BindingSource(this.icontainer_0);
        this.label_2 = new Label();
        this.label_4 = new Label();
        this.label_3 = new Label();
        this.label_5 = new Label();
        this.tabPage_4 = new TabPage();
        this.tableLayoutPanel_2 = new TableLayoutPanel();
        this.dataGridView_5 = new DataGridView();
        this.dataGridViewTextBoxColumn_16 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_17 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_18 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_19 = new DataGridViewTextBoxColumn();
        this.bindingSource_7 = new BindingSource(this.icontainer_0);
        this.toolStrip_2 = new ToolStrip();
        this.toolStripButton_5 = new ToolStripButton();
        this.toolStripButton_6 = new ToolStripButton();
        this.toolStripSeparator_1 = new ToolStripSeparator();
        this.toolStripButton_7 = new ToolStripButton();
        this.toolStripButton_8 = new ToolStripButton();
        this.dataGridView_4 = new DataGridView();
        this.dataGridViewTextBoxColumn_20 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_21 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_22 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_23 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_24 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_25 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_26 = new DataGridViewTextBoxColumn();
        this.dataGridViewComboBoxColumn_1 = new DataGridViewComboBoxColumn();
        this.dataGridViewCheckBoxColumn_1 = new DataGridViewCheckBoxColumn();
        this.bindingSource_6 = new BindingSource(this.icontainer_0);
        this.tableLayoutPanel_1 = new TableLayoutPanel();
        this.progressBar_0 = new ProgressBar();
        this.toolStrip_1 = new ToolStrip();
        this.toolStripButton_3 = new ToolStripButton();
        this.button_2 = new Button();
        this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
        this.openFileDialog_0 = new OpenFileDialog();
        this.backgroundWorker_0 = new BackgroundWorker();
        ((ISupportInitialize) this.bindingSource_4).BeginInit();
        this.dataSetGES_0.BeginInit();
        this.tabControl_0.SuspendLayout();
        this.tabPage_0.SuspendLayout();
        ((ISupportInitialize) this.dataGridView_0).BeginInit();
        ((ISupportInitialize) this.bindingSource_0).BeginInit();
        ((ISupportInitialize) this.bindingSource_1).BeginInit();
        this.tabPage_1.SuspendLayout();
        ((ISupportInitialize) this.dataGridView_1).BeginInit();
        ((ISupportInitialize) this.bindingSource_8).BeginInit();
        ((ISupportInitialize) this.bindingSource_2).BeginInit();
        this.tabPage_2.SuspendLayout();
        ((ISupportInitialize) this.dataGridView_2).BeginInit();
        ((ISupportInitialize) this.bindingSource_9).BeginInit();
        ((ISupportInitialize) this.bindingSource_3).BeginInit();
        this.tabPage_5.SuspendLayout();
        this.tableLayoutPanel_3.SuspendLayout();
        ((ISupportInitialize) this.dataGridView_6).BeginInit();
        ((ISupportInitialize) this.bindingSource_10).BeginInit();
        ((ISupportInitialize) this.bindingSource_11).BeginInit();
        this.tabControl_1.SuspendLayout();
        this.tabPage_3.SuspendLayout();
        this.tableLayoutPanel_0.SuspendLayout();
        this.toolStrip_0.SuspendLayout();
        ((ISupportInitialize) this.dataGridView_3).BeginInit();
        ((ISupportInitialize) this.bindingSource_5).BeginInit();
        this.tabPage_4.SuspendLayout();
        this.tableLayoutPanel_2.SuspendLayout();
        ((ISupportInitialize) this.dataGridView_5).BeginInit();
        ((ISupportInitialize) this.bindingSource_7).BeginInit();
        this.toolStrip_2.SuspendLayout();
        ((ISupportInitialize) this.dataGridView_4).BeginInit();
        ((ISupportInitialize) this.bindingSource_6).BeginInit();
        this.tableLayoutPanel_1.SuspendLayout();
        this.toolStrip_1.SuspendLayout();
        base.SuspendLayout();
        this.label_0.AutoSize = true;
        this.label_0.Dock = DockStyle.Fill;
        this.label_0.Location = new Point(3, 0x1d);
        this.label_0.Name = "label1";
        this.label_0.Size = new Size(0x76, 0x1d);
        this.label_0.TabIndex = 0;
        this.label_0.Text = "Предмет поручения";
        this.label_0.TextAlign = ContentAlignment.MiddleRight;
        this.textBox_0.DataBindings.Add(new Binding("Text", this.bindingSource_4, "Subject", true));
        this.textBox_0.Dock = DockStyle.Fill;
        this.textBox_0.Location = new Point(0x7f, 0x22);
        this.textBox_0.Margin = new Padding(3, 5, 3, 3);
        this.textBox_0.Name = "tbSubject";
        this.textBox_0.Size = new Size(0x115, 20);
        this.textBox_0.TabIndex = 1;
        this.bindingSource_4.DataMember = "tJ_Memorandum";
        this.bindingSource_4.DataSource = this.dataSetGES_0;
        this.dataSetGES_0.DataSetName = "DataSetGES";
        this.dataSetGES_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        this.label_1.AutoSize = true;
        this.label_1.Dock = DockStyle.Fill;
        this.label_1.Location = new Point(3, 0x3a);
        this.label_1.Name = "label2";
        this.label_1.Size = new Size(0x76, 0x17);
        this.label_1.TabIndex = 2;
        this.label_1.Text = "Поручение:";
        this.label_1.TextAlign = ContentAlignment.MiddleRight;
        this.tableLayoutPanel_0.SetColumnSpan(this.textBox_1, 2);
        this.textBox_1.DataBindings.Add(new Binding("Text", this.bindingSource_4, "Body_C", true));
        this.textBox_1.Dock = DockStyle.Fill;
        this.textBox_1.Location = new Point(3, 0x54);
        this.textBox_1.Multiline = true;
        this.textBox_1.Name = "tbBody";
        this.textBox_1.Size = new Size(0x191, 0xa1);
        this.textBox_1.TabIndex = 3;
        this.tableLayoutPanel_0.SetColumnSpan(this.tabControl_0, 2);
        this.tabControl_0.Controls.Add(this.tabPage_0);
        this.tabControl_0.Controls.Add(this.tabPage_1);
        this.tabControl_0.Controls.Add(this.tabPage_2);
        this.tabControl_0.Controls.Add(this.tabPage_5);
        this.tabControl_0.Dock = DockStyle.Fill;
        this.tabControl_0.Location = new Point(410, 0x20);
        this.tabControl_0.Name = "tcGeneral";
        this.tableLayoutPanel_0.SetRowSpan(this.tabControl_0, 3);
        this.tabControl_0.SelectedIndex = 0;
        this.tabControl_0.Size = new Size(0x197, 0xd5);
        this.tabControl_0.TabIndex = 4;
        this.tabPage_0.Controls.Add(this.dataGridView_0);
        this.tabPage_0.Location = new Point(4, 0x16);
        this.tabPage_0.Name = "tpSignatory";
        this.tabPage_0.Padding = new Padding(3);
        this.tabPage_0.Size = new Size(0x18f, 0xbb);
        this.tabPage_0.TabIndex = 0;
        this.tabPage_0.Text = "Подписал";
        this.tabPage_0.UseVisualStyleBackColor = true;
        this.dataGridView_0.AllowUserToOrderColumns = true;
        this.dataGridView_0.AutoGenerateColumns = false;
        style.Alignment = DataGridViewContentAlignment.MiddleLeft;
        style.BackColor = SystemColors.Control;
        style.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        style.ForeColor = SystemColors.WindowText;
        style.SelectionBackColor = SystemColors.Highlight;
        style.SelectionForeColor = SystemColors.HighlightText;
        style.WrapMode = DataGridViewTriState.True;
        this.dataGridView_0.ColumnHeadersDefaultCellStyle = style;
        this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewComboBoxColumn_0, this.dataGridViewCheckBoxColumn_0, this.dataGridViewTextBoxColumn_0, this.dataGridViewTextBoxColumn_1, this.dataGridViewTextBoxColumn_2 };
        this.dataGridView_0.Columns.AddRange(dataGridViewColumns);
        this.dataGridView_0.DataSource = this.bindingSource_1;
        style2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        style2.BackColor = SystemColors.Window;
        style2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        style2.ForeColor = SystemColors.ControlText;
        style2.SelectionBackColor = SystemColors.Highlight;
        style2.SelectionForeColor = SystemColors.HighlightText;
        style2.WrapMode = DataGridViewTriState.False;
        this.dataGridView_0.DefaultCellStyle = style2;
        this.dataGridView_0.Dock = DockStyle.Fill;
        this.dataGridView_0.EditMode = DataGridViewEditMode.EditOnEnter;
        this.dataGridView_0.Location = new Point(3, 3);
        this.dataGridView_0.MultiSelect = false;
        this.dataGridView_0.Name = "dgvSignatory";
        style3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        style3.BackColor = SystemColors.Control;
        style3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        style3.ForeColor = SystemColors.WindowText;
        style3.SelectionBackColor = SystemColors.Highlight;
        style3.SelectionForeColor = SystemColors.HighlightText;
        style3.WrapMode = DataGridViewTriState.True;
        this.dataGridView_0.RowHeadersDefaultCellStyle = style3;
        this.dataGridView_0.RowHeadersVisible = false;
        this.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        this.dataGridView_0.Size = new Size(0x189, 0xb5);
        this.dataGridView_0.TabIndex = 1;
        this.dataGridView_0.DataError += new DataGridViewDataErrorEventHandler(this.dataGridView_2_DataError);
        this.dataGridViewComboBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.dataGridViewComboBoxColumn_0.DataPropertyName = "idWorker";
        this.dataGridViewComboBoxColumn_0.DataSource = this.bindingSource_0;
        this.dataGridViewComboBoxColumn_0.DisplayMember = "FIO";
        this.dataGridViewComboBoxColumn_0.HeaderText = "ФИО";
        this.dataGridViewComboBoxColumn_0.Name = "idWorkerDataGridViewTextBoxColumn3";
        this.dataGridViewComboBoxColumn_0.Resizable = DataGridViewTriState.True;
        this.dataGridViewComboBoxColumn_0.SortMode = DataGridViewColumnSortMode.Automatic;
        this.dataGridViewComboBoxColumn_0.ValueMember = "Id";
        this.bindingSource_0.DataMember = "vJ_BossUser";
        this.bindingSource_0.DataSource = this.dataSetGES_0;
        this.dataGridViewCheckBoxColumn_0.DataPropertyName = "Deleted";
        this.dataGridViewCheckBoxColumn_0.HeaderText = "Deleted";
        this.dataGridViewCheckBoxColumn_0.Name = "deletedDataGridViewCheckBoxColumn3";
        this.dataGridViewCheckBoxColumn_0.Visible = false;
        this.dataGridViewTextBoxColumn_0.DataPropertyName = "id";
        this.dataGridViewTextBoxColumn_0.HeaderText = "id";
        this.dataGridViewTextBoxColumn_0.Name = "idDataGridViewTextBoxColumn3";
        this.dataGridViewTextBoxColumn_0.ReadOnly = true;
        this.dataGridViewTextBoxColumn_0.Visible = false;
        this.dataGridViewTextBoxColumn_1.DataPropertyName = "idMemorandum";
        this.dataGridViewTextBoxColumn_1.HeaderText = "idMemorandum";
        this.dataGridViewTextBoxColumn_1.Name = "idMemorandumDataGridViewTextBoxColumn3";
        this.dataGridViewTextBoxColumn_1.Visible = false;
        this.dataGridViewTextBoxColumn_2.DataPropertyName = "typeWorker";
        this.dataGridViewTextBoxColumn_2.HeaderText = "typeWorker";
        this.dataGridViewTextBoxColumn_2.Name = "typeWorkerDataGridViewTextBoxColumn3";
        this.dataGridViewTextBoxColumn_2.Visible = false;
        this.bindingSource_1.DataMember = "tJ_MemWorker";
        this.bindingSource_1.DataSource = this.dataSetGES_0;
        this.bindingSource_1.Filter = "TypeWorker = 1297";
        this.tabPage_1.Controls.Add(this.dataGridView_1);
        this.tabPage_1.Location = new Point(4, 0x16);
        this.tabPage_1.Name = "tpAddressee";
        this.tabPage_1.Padding = new Padding(3);
        this.tabPage_1.Size = new Size(0x18f, 0xbb);
        this.tabPage_1.TabIndex = 1;
        this.tabPage_1.Text = "Адресат";
        this.tabPage_1.UseVisualStyleBackColor = true;
        this.dataGridView_1.AllowUserToOrderColumns = true;
        this.dataGridView_1.AutoGenerateColumns = false;
        style4.Alignment = DataGridViewContentAlignment.MiddleLeft;
        style4.BackColor = SystemColors.Control;
        style4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        style4.ForeColor = SystemColors.WindowText;
        style4.SelectionBackColor = SystemColors.Highlight;
        style4.SelectionForeColor = SystemColors.HighlightText;
        style4.WrapMode = DataGridViewTriState.True;
        this.dataGridView_1.ColumnHeadersDefaultCellStyle = style4;
        this.dataGridView_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DataGridViewColumn[] columnArray2 = new DataGridViewColumn[] { this.dataGridViewComboBoxColumn_2, this.dataGridViewCheckBoxColumn_2, this.dataGridViewTextBoxColumn_27, this.dataGridViewTextBoxColumn_28, this.dataGridViewTextBoxColumn_29 };
        this.dataGridView_1.Columns.AddRange(columnArray2);
        this.dataGridView_1.DataSource = this.bindingSource_2;
        style5.Alignment = DataGridViewContentAlignment.MiddleLeft;
        style5.BackColor = SystemColors.Window;
        style5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        style5.ForeColor = SystemColors.ControlText;
        style5.SelectionBackColor = SystemColors.Highlight;
        style5.SelectionForeColor = SystemColors.HighlightText;
        style5.WrapMode = DataGridViewTriState.False;
        this.dataGridView_1.DefaultCellStyle = style5;
        this.dataGridView_1.Dock = DockStyle.Fill;
        this.dataGridView_1.EditMode = DataGridViewEditMode.EditOnEnter;
        this.dataGridView_1.Location = new Point(3, 3);
        this.dataGridView_1.MultiSelect = false;
        this.dataGridView_1.Name = "dgvAddressee";
        style6.Alignment = DataGridViewContentAlignment.MiddleLeft;
        style6.BackColor = SystemColors.Control;
        style6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        style6.ForeColor = SystemColors.WindowText;
        style6.SelectionBackColor = SystemColors.Highlight;
        style6.SelectionForeColor = SystemColors.HighlightText;
        style6.WrapMode = DataGridViewTriState.True;
        this.dataGridView_1.RowHeadersDefaultCellStyle = style6;
        this.dataGridView_1.RowHeadersVisible = false;
        this.dataGridView_1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        this.dataGridView_1.Size = new Size(0x189, 0xb5);
        this.dataGridView_1.TabIndex = 2;
        this.dataGridView_1.DataError += new DataGridViewDataErrorEventHandler(this.dataGridView_2_DataError);
        this.dataGridViewComboBoxColumn_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.dataGridViewComboBoxColumn_2.DataPropertyName = "idWorker";
        this.dataGridViewComboBoxColumn_2.DataSource = this.bindingSource_8;
        this.dataGridViewComboBoxColumn_2.DisplayMember = "FIO";
        this.dataGridViewComboBoxColumn_2.HeaderText = "ФИО";
        this.dataGridViewComboBoxColumn_2.Name = "idWorkerDataGridViewTextBoxColumn2";
        this.dataGridViewComboBoxColumn_2.Resizable = DataGridViewTriState.True;
        this.dataGridViewComboBoxColumn_2.SortMode = DataGridViewColumnSortMode.Automatic;
        this.dataGridViewComboBoxColumn_2.ValueMember = "Id";
        this.bindingSource_8.DataMember = "vJ_BossUser";
        this.bindingSource_8.DataSource = this.dataSetGES_0;
        this.dataGridViewCheckBoxColumn_2.DataPropertyName = "Deleted";
        this.dataGridViewCheckBoxColumn_2.HeaderText = "Deleted";
        this.dataGridViewCheckBoxColumn_2.Name = "deletedDataGridViewCheckBoxColumn2";
        this.dataGridViewCheckBoxColumn_2.Visible = false;
        this.dataGridViewTextBoxColumn_27.DataPropertyName = "id";
        this.dataGridViewTextBoxColumn_27.HeaderText = "id";
        this.dataGridViewTextBoxColumn_27.Name = "idDataGridViewTextBoxColumn2";
        this.dataGridViewTextBoxColumn_27.ReadOnly = true;
        this.dataGridViewTextBoxColumn_27.Visible = false;
        this.dataGridViewTextBoxColumn_28.DataPropertyName = "idMemorandum";
        this.dataGridViewTextBoxColumn_28.HeaderText = "idMemorandum";
        this.dataGridViewTextBoxColumn_28.Name = "idMemorandumDataGridViewTextBoxColumn2";
        this.dataGridViewTextBoxColumn_28.Visible = false;
        this.dataGridViewTextBoxColumn_29.DataPropertyName = "typeWorker";
        this.dataGridViewTextBoxColumn_29.HeaderText = "typeWorker";
        this.dataGridViewTextBoxColumn_29.Name = "typeWorkerDataGridViewTextBoxColumn2";
        this.dataGridViewTextBoxColumn_29.Visible = false;
        this.bindingSource_2.DataMember = "tJ_MemWorker";
        this.bindingSource_2.DataSource = this.dataSetGES_0;
        this.bindingSource_2.Filter = "TypeWorker = 1300";
        this.tabPage_2.Controls.Add(this.dataGridView_2);
        this.tabPage_2.Location = new Point(4, 0x16);
        this.tabPage_2.Name = "tpVizier";
        this.tabPage_2.Padding = new Padding(3);
        this.tabPage_2.Size = new Size(0x18f, 0xbb);
        this.tabPage_2.TabIndex = 3;
        this.tabPage_2.Text = "Визирующие";
        this.tabPage_2.UseVisualStyleBackColor = true;
        this.dataGridView_2.AllowUserToOrderColumns = true;
        this.dataGridView_2.AutoGenerateColumns = false;
        style7.Alignment = DataGridViewContentAlignment.MiddleLeft;
        style7.BackColor = SystemColors.Control;
        style7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        style7.ForeColor = SystemColors.WindowText;
        style7.SelectionBackColor = SystemColors.Highlight;
        style7.SelectionForeColor = SystemColors.HighlightText;
        style7.WrapMode = DataGridViewTriState.True;
        this.dataGridView_2.ColumnHeadersDefaultCellStyle = style7;
        this.dataGridView_2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DataGridViewColumn[] columnArray3 = new DataGridViewColumn[] { this.dataGridViewComboBoxColumn_3, this.dataGridViewCheckBoxColumn_3, this.dataGridViewTextBoxColumn_30, this.dataGridViewTextBoxColumn_31, this.dataGridViewTextBoxColumn_32 };
        this.dataGridView_2.Columns.AddRange(columnArray3);
        this.dataGridView_2.DataSource = this.bindingSource_3;
        style8.Alignment = DataGridViewContentAlignment.MiddleLeft;
        style8.BackColor = SystemColors.Window;
        style8.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        style8.ForeColor = SystemColors.ControlText;
        style8.SelectionBackColor = SystemColors.Highlight;
        style8.SelectionForeColor = SystemColors.HighlightText;
        style8.WrapMode = DataGridViewTriState.False;
        this.dataGridView_2.DefaultCellStyle = style8;
        this.dataGridView_2.Dock = DockStyle.Fill;
        this.dataGridView_2.EditMode = DataGridViewEditMode.EditOnEnter;
        this.dataGridView_2.Location = new Point(3, 3);
        this.dataGridView_2.MultiSelect = false;
        this.dataGridView_2.Name = "dgvVizier";
        style9.Alignment = DataGridViewContentAlignment.MiddleLeft;
        style9.BackColor = SystemColors.Control;
        style9.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        style9.ForeColor = SystemColors.WindowText;
        style9.SelectionBackColor = SystemColors.Highlight;
        style9.SelectionForeColor = SystemColors.HighlightText;
        style9.WrapMode = DataGridViewTriState.True;
        this.dataGridView_2.RowHeadersDefaultCellStyle = style9;
        this.dataGridView_2.RowHeadersVisible = false;
        this.dataGridView_2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        this.dataGridView_2.Size = new Size(0x189, 0xb5);
        this.dataGridView_2.TabIndex = 3;
        this.dataGridView_2.DataError += new DataGridViewDataErrorEventHandler(this.dataGridView_2_DataError);
        this.dataGridViewComboBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.dataGridViewComboBoxColumn_3.DataPropertyName = "idWorker";
        this.dataGridViewComboBoxColumn_3.DataSource = this.bindingSource_9;
        this.dataGridViewComboBoxColumn_3.DisplayMember = "FIO";
        this.dataGridViewComboBoxColumn_3.HeaderText = "ФИО";
        this.dataGridViewComboBoxColumn_3.Name = "idWorkerDataGridViewTextBoxColumn";
        this.dataGridViewComboBoxColumn_3.Resizable = DataGridViewTriState.True;
        this.dataGridViewComboBoxColumn_3.SortMode = DataGridViewColumnSortMode.Automatic;
        this.dataGridViewComboBoxColumn_3.ValueMember = "Id";
        this.bindingSource_9.DataMember = "vJ_BossUser";
        this.bindingSource_9.DataSource = this.dataSetGES_0;
        this.dataGridViewCheckBoxColumn_3.DataPropertyName = "Deleted";
        this.dataGridViewCheckBoxColumn_3.HeaderText = "Deleted";
        this.dataGridViewCheckBoxColumn_3.Name = "deletedDataGridViewCheckBoxColumn";
        this.dataGridViewCheckBoxColumn_3.Visible = false;
        this.dataGridViewTextBoxColumn_30.DataPropertyName = "id";
        this.dataGridViewTextBoxColumn_30.HeaderText = "id";
        this.dataGridViewTextBoxColumn_30.Name = "idDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_30.ReadOnly = true;
        this.dataGridViewTextBoxColumn_30.Visible = false;
        this.dataGridViewTextBoxColumn_31.DataPropertyName = "idMemorandum";
        this.dataGridViewTextBoxColumn_31.HeaderText = "idMemorandum";
        this.dataGridViewTextBoxColumn_31.Name = "idMemorandumDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_31.Visible = false;
        this.dataGridViewTextBoxColumn_32.DataPropertyName = "typeWorker";
        this.dataGridViewTextBoxColumn_32.HeaderText = "typeWorker";
        this.dataGridViewTextBoxColumn_32.Name = "typeWorkerDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_32.Visible = false;
        this.bindingSource_3.DataMember = "tJ_MemWorker";
        this.bindingSource_3.DataSource = this.dataSetGES_0;
        this.bindingSource_3.Filter = "TypeWorker = 1298";
        this.tabPage_5.Controls.Add(this.tableLayoutPanel_3);
        this.tabPage_5.Location = new Point(4, 0x16);
        this.tabPage_5.Name = "tpSend";
        this.tabPage_5.Padding = new Padding(3);
        this.tabPage_5.Size = new Size(0x18f, 0xbb);
        this.tabPage_5.TabIndex = 4;
        this.tabPage_5.Text = "Уведомить";
        this.tabPage_5.UseVisualStyleBackColor = true;
        this.tableLayoutPanel_3.ColumnCount = 2;
        this.tableLayoutPanel_3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
        this.tableLayoutPanel_3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125f));
        this.tableLayoutPanel_3.Controls.Add(this.button_3, 1, 1);
        this.tableLayoutPanel_3.Controls.Add(this.dataGridView_6, 0, 0);
        this.tableLayoutPanel_3.Dock = DockStyle.Fill;
        this.tableLayoutPanel_3.Location = new Point(3, 3);
        this.tableLayoutPanel_3.Name = "tableLayoutPanel3";
        this.tableLayoutPanel_3.RowCount = 2;
        this.tableLayoutPanel_3.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
        this.tableLayoutPanel_3.RowStyles.Add(new RowStyle(SizeType.Absolute, 29f));
        this.tableLayoutPanel_3.Size = new Size(0x189, 0xb5);
        this.tableLayoutPanel_3.TabIndex = 0;
        this.button_3.Dock = DockStyle.Fill;
        this.button_3.Location = new Point(0x10f, 0x9b);
        this.button_3.Name = "btnSendMail";
        this.button_3.Size = new Size(0x77, 0x17);
        this.button_3.TabIndex = 0;
        this.button_3.Text = "Отправить письмо";
        this.button_3.UseVisualStyleBackColor = true;
        this.button_3.Click += new EventHandler(this.button_3_Click);
        this.dataGridView_6.AllowUserToOrderColumns = true;
        this.dataGridView_6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DataGridViewColumn[] columnArray4 = new DataGridViewColumn[] { this.dataGridViewComboBoxColumn_4 };
        this.dataGridView_6.Columns.AddRange(columnArray4);
        this.tableLayoutPanel_3.SetColumnSpan(this.dataGridView_6, 2);
        this.dataGridView_6.Dock = DockStyle.Fill;
        this.dataGridView_6.EditMode = DataGridViewEditMode.EditOnEnter;
        this.dataGridView_6.Location = new Point(3, 3);
        this.dataGridView_6.Name = "dgvSend";
        this.dataGridView_6.RowHeadersVisible = false;
        this.dataGridView_6.Size = new Size(0x183, 0x92);
        this.dataGridView_6.TabIndex = 1;
        this.dataGridView_6.CellContentClick += new DataGridViewCellEventHandler(this.dataGridView_6_CellContentClick);
        this.dataGridViewComboBoxColumn_4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.dataGridViewComboBoxColumn_4.DataSource = this.bindingSource_10;
        this.dataGridViewComboBoxColumn_4.DisplayMember = "FIO";
        this.dataGridViewComboBoxColumn_4.HeaderText = "ФИО";
        this.dataGridViewComboBoxColumn_4.Name = "Send";
        this.dataGridViewComboBoxColumn_4.Resizable = DataGridViewTriState.True;
        this.dataGridViewComboBoxColumn_4.SortMode = DataGridViewColumnSortMode.Automatic;
        this.dataGridViewComboBoxColumn_4.ValueMember = "Id";
        this.bindingSource_10.DataMember = "vJ_BossUser";
        this.bindingSource_10.DataSource = this.dataSetGES_0;
        this.bindingSource_11.DataMember = "tJ_MemWorker";
        this.bindingSource_11.DataSource = this.dataSetGES_0;
        this.bindingSource_11.Filter = "TypeWorker = 1312";
        this.bindingSource_11.AddingNew += new AddingNewEventHandler(this.bindingSource_11_AddingNew);
        this.button_0.Dock = DockStyle.Right;
        this.button_0.Location = new Point(0x282, 0x220);
        this.button_0.Margin = new Padding(3, 8, 3, 8);
        this.button_0.Name = "btnSend";
        this.button_0.Size = new Size(0x5c, 0x19);
        this.button_0.TabIndex = 5;
        this.button_0.Text = "Отправить";
        this.button_0.UseVisualStyleBackColor = true;
        this.button_0.Click += new EventHandler(this.button_0_Click);
        this.button_1.Dock = DockStyle.Left;
        this.button_1.Location = new Point(0x2f0, 0x220);
        this.button_1.Margin = new Padding(15, 8, 3, 8);
        this.button_1.Name = "btnCancel";
        this.button_1.Size = new Size(0x4b, 0x19);
        this.button_1.TabIndex = 6;
        this.button_1.Text = "Закрыть";
        this.button_1.UseVisualStyleBackColor = true;
        this.button_1.Click += new EventHandler(this.button_1_Click);
        this.tableLayoutPanel_1.SetColumnSpan(this.tabControl_1, 4);
        this.tabControl_1.Controls.Add(this.tabPage_3);
        this.tabControl_1.Controls.Add(this.tabPage_4);
        this.tabControl_1.Dock = DockStyle.Fill;
        this.tabControl_1.Location = new Point(3, 0x1d);
        this.tabControl_1.Name = "tabControl1";
        this.tabControl_1.SelectedIndex = 0;
        this.tabControl_1.Size = new Size(0x342, 0x1f8);
        this.tabControl_1.TabIndex = 7;
        this.tabPage_3.Controls.Add(this.tableLayoutPanel_0);
        this.tabPage_3.Location = new Point(4, 0x16);
        this.tabPage_3.Name = "tpGeneral";
        this.tabPage_3.Padding = new Padding(3);
        this.tabPage_3.Size = new Size(0x33a, 0x1de);
        this.tabPage_3.TabIndex = 0;
        this.tabPage_3.Text = "Общие";
        this.tabPage_3.UseVisualStyleBackColor = true;
        this.tableLayoutPanel_0.ColumnCount = 4;
        this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 124f));
        this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 283f));
        this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 214f));
        this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
        this.tableLayoutPanel_0.Controls.Add(this.toolStrip_0, 0, 4);
        this.tableLayoutPanel_0.Controls.Add(this.dataGridView_3, 0, 5);
        this.tableLayoutPanel_0.Controls.Add(this.label_2, 1, 6);
        this.tableLayoutPanel_0.Controls.Add(this.label_4, 0, 0);
        this.tableLayoutPanel_0.Controls.Add(this.label_0, 0, 1);
        this.tableLayoutPanel_0.Controls.Add(this.label_3, 0, 6);
        this.tableLayoutPanel_0.Controls.Add(this.label_1, 0, 2);
        this.tableLayoutPanel_0.Controls.Add(this.textBox_0, 1, 1);
        this.tableLayoutPanel_0.Controls.Add(this.textBox_1, 0, 3);
        this.tableLayoutPanel_0.Controls.Add(this.tabControl_0, 2, 1);
        this.tableLayoutPanel_0.Controls.Add(this.label_5, 1, 0);
        this.tableLayoutPanel_0.Dock = DockStyle.Fill;
        this.tableLayoutPanel_0.Location = new Point(3, 3);
        this.tableLayoutPanel_0.Name = "tableLayoutPanel1";
        this.tableLayoutPanel_0.RowCount = 7;
        this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 29f));
        this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 29f));
        this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 23f));
        this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
        this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 24f));
        this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
        this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 33f));
        this.tableLayoutPanel_0.Size = new Size(820, 0x1d8);
        this.tableLayoutPanel_0.TabIndex = 0;
        this.tableLayoutPanel_0.SetColumnSpan(this.toolStrip_0, 4);
        this.toolStrip_0.Dock = DockStyle.Fill;
        ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripButton_0, this.toolStripButton_4, this.toolStripSeparator_0, this.toolStripButton_1, this.toolStripButton_2 };
        this.toolStrip_0.Items.AddRange(toolStripItems);
        this.toolStrip_0.Location = new Point(0, 0xf8);
        this.toolStrip_0.Name = "tsFiles";
        this.toolStrip_0.Size = new Size(820, 0x18);
        this.toolStrip_0.TabIndex = 8;
        this.toolStrip_0.Text = "toolStrip1";
        this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_0.Image = Resources.ElementAdd;
        this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
        this.toolStripButton_0.Name = "tsbAddFiles";
        this.toolStripButton_0.Size = new Size(0x17, 0x15);
        this.toolStripButton_0.Text = "Добавить файл";
        this.toolStripButton_0.Click += new EventHandler(this.toolStripButton_0_Click);
        this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_4.Image = Resources.ElementInformation;
        this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
        this.toolStripButton_4.Name = "tsbViewFiles";
        this.toolStripButton_4.Size = new Size(0x17, 0x15);
        this.toolStripButton_4.Text = "Открыть файл";
        this.toolStripButton_4.Click += new EventHandler(this.toolStripButton_4_Click);
        this.toolStripSeparator_0.Name = "toolStripSeparator1";
        this.toolStripSeparator_0.Size = new Size(6, 0x18);
        this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_1.Image = Resources.ElementDel;
        this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
        this.toolStripButton_1.Name = "tsbDeleteFiles";
        this.toolStripButton_1.Size = new Size(0x17, 0x15);
        this.toolStripButton_1.Text = "Удалить файл";
        this.toolStripButton_1.Click += new EventHandler(this.toolStripButton_1_Click);
        this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_2.Image = Resources.refresh_16;
        this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
        this.toolStripButton_2.Name = "tsbRefreshFiles";
        this.toolStripButton_2.Size = new Size(0x17, 0x15);
        this.toolStripButton_2.Text = "Обновить";
        this.toolStripButton_2.Visible = false;
        this.toolStripButton_2.Click += new EventHandler(this.toolStripButton_2_Click);
        this.dataGridView_3.AllowUserToAddRows = false;
        this.dataGridView_3.AllowUserToDeleteRows = false;
        this.dataGridView_3.AutoGenerateColumns = false;
        style10.Alignment = DataGridViewContentAlignment.MiddleLeft;
        style10.BackColor = SystemColors.Control;
        style10.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        style10.ForeColor = SystemColors.WindowText;
        style10.SelectionBackColor = SystemColors.Highlight;
        style10.SelectionForeColor = SystemColors.HighlightText;
        style10.WrapMode = DataGridViewTriState.True;
        this.dataGridView_3.ColumnHeadersDefaultCellStyle = style10;
        this.dataGridView_3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DataGridViewColumn[] columnArray5 = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_12, this.dataGridViewTextBoxColumn_13, this.dataGridViewTextBoxColumn_14, this.dataGridViewTextBoxColumn_15 };
        this.dataGridView_3.Columns.AddRange(columnArray5);
        this.tableLayoutPanel_0.SetColumnSpan(this.dataGridView_3, 4);
        this.dataGridView_3.DataSource = this.bindingSource_5;
        style11.Alignment = DataGridViewContentAlignment.MiddleLeft;
        style11.BackColor = SystemColors.Window;
        style11.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        style11.ForeColor = SystemColors.ControlText;
        style11.SelectionBackColor = SystemColors.Highlight;
        style11.SelectionForeColor = SystemColors.HighlightText;
        style11.WrapMode = DataGridViewTriState.False;
        this.dataGridView_3.DefaultCellStyle = style11;
        this.dataGridView_3.Dock = DockStyle.Fill;
        this.dataGridView_3.Location = new Point(3, 0x113);
        this.dataGridView_3.Name = "dgvFiles";
        this.dataGridView_3.ReadOnly = true;
        style12.Alignment = DataGridViewContentAlignment.MiddleLeft;
        style12.BackColor = SystemColors.Control;
        style12.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        style12.ForeColor = SystemColors.WindowText;
        style12.SelectionBackColor = SystemColors.Highlight;
        style12.SelectionForeColor = SystemColors.HighlightText;
        style12.WrapMode = DataGridViewTriState.True;
        this.dataGridView_3.RowHeadersDefaultCellStyle = style12;
        this.dataGridView_3.RowHeadersVisible = false;
        this.dataGridView_3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        this.dataGridView_3.Size = new Size(0x32e, 0xa1);
        this.dataGridView_3.TabIndex = 8;
        this.dataGridViewTextBoxColumn_12.DataPropertyName = "id";
        this.dataGridViewTextBoxColumn_12.HeaderText = "id";
        this.dataGridViewTextBoxColumn_12.Name = "idDataGridViewTextBoxColumn1";
        this.dataGridViewTextBoxColumn_12.ReadOnly = true;
        this.dataGridViewTextBoxColumn_12.Visible = false;
        this.dataGridViewTextBoxColumn_13.DataPropertyName = "idDocument";
        this.dataGridViewTextBoxColumn_13.HeaderText = "idDocument";
        this.dataGridViewTextBoxColumn_13.Name = "idDocumentDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_13.ReadOnly = true;
        this.dataGridViewTextBoxColumn_13.Visible = false;
        this.dataGridViewTextBoxColumn_14.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.dataGridViewTextBoxColumn_14.DataPropertyName = "Name";
        this.dataGridViewTextBoxColumn_14.HeaderText = "Файл";
        this.dataGridViewTextBoxColumn_14.Name = "nameDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_14.ReadOnly = true;
        this.dataGridViewTextBoxColumn_15.DataPropertyName = "Size";
        this.dataGridViewTextBoxColumn_15.HeaderText = "Size";
        this.dataGridViewTextBoxColumn_15.Name = "sizeDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_15.ReadOnly = true;
        this.dataGridViewTextBoxColumn_15.Visible = false;
        this.bindingSource_5.DataMember = "tJ_MemFiles";
        this.bindingSource_5.DataSource = this.dataSetGES_0;
        this.bindingSource_5.Filter = "TypeDoc = 1";
        this.label_2.AutoSize = true;
        this.tableLayoutPanel_0.SetColumnSpan(this.label_2, 3);
        this.label_2.Dock = DockStyle.Fill;
        this.label_2.Location = new Point(0x7f, 0x1b7);
        this.label_2.Name = "lb";
        this.label_2.Size = new Size(690, 0x21);
        this.label_2.TabIndex = 6;
        this.label_2.TextAlign = ContentAlignment.MiddleLeft;
        this.label_4.AutoSize = true;
        this.label_4.Dock = DockStyle.Fill;
        this.label_4.Location = new Point(3, 0);
        this.label_4.Name = "label5";
        this.label_4.Size = new Size(0x76, 0x1d);
        this.label_4.TabIndex = 7;
        this.label_4.Text = "Документ:";
        this.label_4.TextAlign = ContentAlignment.MiddleRight;
        this.label_3.AutoSize = true;
        this.label_3.Dock = DockStyle.Fill;
        this.label_3.Location = new Point(3, 0x1b7);
        this.label_3.Name = "label3";
        this.label_3.Size = new Size(0x76, 0x21);
        this.label_3.TabIndex = 5;
        this.label_3.Text = "Исполнитель";
        this.label_3.TextAlign = ContentAlignment.MiddleRight;
        this.label_5.AutoSize = true;
        this.tableLayoutPanel_0.SetColumnSpan(this.label_5, 3);
        this.label_5.DataBindings.Add(new Binding("Text", this.bindingSource_4, "RgNum", true));
        this.label_5.Dock = DockStyle.Fill;
        this.label_5.Location = new Point(0x7f, 0);
        this.label_5.Name = "lbDocument";
        this.label_5.Size = new Size(690, 0x1d);
        this.label_5.TabIndex = 9;
        this.label_5.TextAlign = ContentAlignment.MiddleLeft;
        this.tabPage_4.Controls.Add(this.tableLayoutPanel_2);
        this.tabPage_4.Location = new Point(4, 0x16);
        this.tabPage_4.Name = "tbProcess";
        this.tabPage_4.Padding = new Padding(3);
        this.tabPage_4.Size = new Size(0x33a, 0x1de);
        this.tabPage_4.TabIndex = 1;
        this.tabPage_4.Text = "Процесс";
        this.tabPage_4.UseVisualStyleBackColor = true;
        this.tableLayoutPanel_2.ColumnCount = 2;
        this.tableLayoutPanel_2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
        this.tableLayoutPanel_2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
        this.tableLayoutPanel_2.Controls.Add(this.dataGridView_5, 0, 2);
        this.tableLayoutPanel_2.Controls.Add(this.toolStrip_2, 0, 1);
        this.tableLayoutPanel_2.Controls.Add(this.dataGridView_4, 0, 0);
        this.tableLayoutPanel_2.Dock = DockStyle.Fill;
        this.tableLayoutPanel_2.Location = new Point(3, 3);
        this.tableLayoutPanel_2.Name = "tlpProcess";
        this.tableLayoutPanel_2.RowCount = 3;
        this.tableLayoutPanel_2.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
        this.tableLayoutPanel_2.RowStyles.Add(new RowStyle(SizeType.Absolute, 26f));
        this.tableLayoutPanel_2.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
        this.tableLayoutPanel_2.Size = new Size(820, 0x1d8);
        this.tableLayoutPanel_2.TabIndex = 0;
        this.dataGridView_5.AllowUserToAddRows = false;
        this.dataGridView_5.AllowUserToDeleteRows = false;
        this.dataGridView_5.AutoGenerateColumns = false;
        style13.Alignment = DataGridViewContentAlignment.MiddleLeft;
        style13.BackColor = SystemColors.Control;
        style13.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        style13.ForeColor = SystemColors.WindowText;
        style13.SelectionBackColor = SystemColors.Highlight;
        style13.SelectionForeColor = SystemColors.HighlightText;
        style13.WrapMode = DataGridViewTriState.True;
        this.dataGridView_5.ColumnHeadersDefaultCellStyle = style13;
        this.dataGridView_5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DataGridViewColumn[] columnArray6 = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_16, this.dataGridViewTextBoxColumn_17, this.dataGridViewTextBoxColumn_18, this.dataGridViewTextBoxColumn_19 };
        this.dataGridView_5.Columns.AddRange(columnArray6);
        this.tableLayoutPanel_2.SetColumnSpan(this.dataGridView_5, 4);
        this.dataGridView_5.DataSource = this.bindingSource_7;
        style14.Alignment = DataGridViewContentAlignment.MiddleLeft;
        style14.BackColor = SystemColors.Window;
        style14.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        style14.ForeColor = SystemColors.ControlText;
        style14.SelectionBackColor = SystemColors.Highlight;
        style14.SelectionForeColor = SystemColors.HighlightText;
        style14.WrapMode = DataGridViewTriState.False;
        this.dataGridView_5.DefaultCellStyle = style14;
        this.dataGridView_5.Dock = DockStyle.Fill;
        this.dataGridView_5.Location = new Point(3, 0xfc);
        this.dataGridView_5.Name = "dgvFileCommission";
        this.dataGridView_5.ReadOnly = true;
        style15.Alignment = DataGridViewContentAlignment.MiddleLeft;
        style15.BackColor = SystemColors.Control;
        style15.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        style15.ForeColor = SystemColors.WindowText;
        style15.SelectionBackColor = SystemColors.Highlight;
        style15.SelectionForeColor = SystemColors.HighlightText;
        style15.WrapMode = DataGridViewTriState.True;
        this.dataGridView_5.RowHeadersDefaultCellStyle = style15;
        this.dataGridView_5.RowHeadersVisible = false;
        this.dataGridView_5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        this.dataGridView_5.Size = new Size(0x32e, 0xd9);
        this.dataGridView_5.TabIndex = 10;
        this.dataGridViewTextBoxColumn_16.DataPropertyName = "id";
        this.dataGridViewTextBoxColumn_16.HeaderText = "id";
        this.dataGridViewTextBoxColumn_16.Name = "dataGridViewTextBoxColumn10";
        this.dataGridViewTextBoxColumn_16.ReadOnly = true;
        this.dataGridViewTextBoxColumn_16.Visible = false;
        this.dataGridViewTextBoxColumn_17.DataPropertyName = "idDocument";
        this.dataGridViewTextBoxColumn_17.HeaderText = "idDocument";
        this.dataGridViewTextBoxColumn_17.Name = "dataGridViewTextBoxColumn11";
        this.dataGridViewTextBoxColumn_17.ReadOnly = true;
        this.dataGridViewTextBoxColumn_17.Visible = false;
        this.dataGridViewTextBoxColumn_18.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.dataGridViewTextBoxColumn_18.DataPropertyName = "Name";
        this.dataGridViewTextBoxColumn_18.HeaderText = "Файл";
        this.dataGridViewTextBoxColumn_18.Name = "dataGridViewTextBoxColumn12";
        this.dataGridViewTextBoxColumn_18.ReadOnly = true;
        this.dataGridViewTextBoxColumn_19.DataPropertyName = "Size";
        this.dataGridViewTextBoxColumn_19.HeaderText = "Size";
        this.dataGridViewTextBoxColumn_19.Name = "dataGridViewTextBoxColumn13";
        this.dataGridViewTextBoxColumn_19.ReadOnly = true;
        this.dataGridViewTextBoxColumn_19.Visible = false;
        this.bindingSource_7.DataMember = "tJ_MemFiles";
        this.bindingSource_7.DataSource = this.dataSetGES_0;
        this.bindingSource_7.Filter = "TypeDoc = 2";
        this.tableLayoutPanel_2.SetColumnSpan(this.toolStrip_2, 4);
        this.toolStrip_2.Dock = DockStyle.Fill;
        ToolStripItem[] itemArray2 = new ToolStripItem[] { this.toolStripButton_5, this.toolStripButton_6, this.toolStripSeparator_1, this.toolStripButton_7, this.toolStripButton_8 };
        this.toolStrip_2.Items.AddRange(itemArray2);
        this.toolStrip_2.Location = new Point(0, 0xdf);
        this.toolStrip_2.Name = "tsFileCommission";
        this.toolStrip_2.Size = new Size(820, 0x1a);
        this.toolStrip_2.TabIndex = 9;
        this.toolStrip_2.Text = "toolStrip1";
        this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_5.Image = Resources.ElementAdd;
        this.toolStripButton_5.ImageTransparentColor = Color.Magenta;
        this.toolStripButton_5.Name = "tsbAddFileCommission";
        this.toolStripButton_5.Size = new Size(0x17, 0x17);
        this.toolStripButton_5.Text = "Добавить файл";
        this.toolStripButton_5.Click += new EventHandler(this.toolStripButton_5_Click);
        this.toolStripButton_6.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_6.Image = Resources.ElementInformation;
        this.toolStripButton_6.ImageTransparentColor = Color.Magenta;
        this.toolStripButton_6.Name = "tsbViewFileCommission";
        this.toolStripButton_6.Size = new Size(0x17, 0x17);
        this.toolStripButton_6.Text = "Открыть файл";
        this.toolStripButton_6.Click += new EventHandler(this.toolStripButton_6_Click);
        this.toolStripSeparator_1.Name = "toolStripSeparator2";
        this.toolStripSeparator_1.Size = new Size(6, 0x1a);
        this.toolStripButton_7.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_7.Image = Resources.ElementDel;
        this.toolStripButton_7.ImageTransparentColor = Color.Magenta;
        this.toolStripButton_7.Name = "tsbDeleteFileCommission";
        this.toolStripButton_7.Size = new Size(0x17, 0x17);
        this.toolStripButton_7.Text = "Удалить файл";
        this.toolStripButton_7.Click += new EventHandler(this.toolStripButton_7_Click);
        this.toolStripButton_8.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_8.Image = Resources.refresh_16;
        this.toolStripButton_8.ImageTransparentColor = Color.Magenta;
        this.toolStripButton_8.Name = "tsbRefreshFileCommission";
        this.toolStripButton_8.Size = new Size(0x17, 0x17);
        this.toolStripButton_8.Text = "Обновить";
        this.toolStripButton_8.Visible = false;
        this.toolStripButton_8.Click += new EventHandler(this.toolStripButton_8_Click);
        this.dataGridView_4.AllowUserToAddRows = false;
        this.dataGridView_4.AllowUserToDeleteRows = false;
        this.dataGridView_4.AllowUserToOrderColumns = true;
        this.dataGridView_4.AutoGenerateColumns = false;
        this.dataGridView_4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DataGridViewColumn[] columnArray7 = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_20, this.dataGridViewTextBoxColumn_21, this.dataGridViewTextBoxColumn_22, this.dataGridViewTextBoxColumn_23, this.dataGridViewTextBoxColumn_24, this.dataGridViewTextBoxColumn_25, this.dataGridViewTextBoxColumn_26, this.dataGridViewComboBoxColumn_1, this.dataGridViewCheckBoxColumn_1 };
        this.dataGridView_4.Columns.AddRange(columnArray7);
        this.tableLayoutPanel_2.SetColumnSpan(this.dataGridView_4, 2);
        this.dataGridView_4.DataSource = this.bindingSource_6;
        this.dataGridView_4.Dock = DockStyle.Fill;
        this.dataGridView_4.Location = new Point(3, 3);
        this.dataGridView_4.Name = "dgvCommission";
        this.dataGridView_4.ReadOnly = true;
        this.dataGridView_4.RowHeadersVisible = false;
        this.dataGridView_4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        this.dataGridView_4.Size = new Size(0x32e, 0xd9);
        this.dataGridView_4.TabIndex = 0;
        this.dataGridView_4.DataError += new DataGridViewDataErrorEventHandler(this.dataGridView_4_DataError);
        this.dataGridViewTextBoxColumn_20.DataPropertyName = "id";
        this.dataGridViewTextBoxColumn_20.HeaderText = "Column1";
        this.dataGridViewTextBoxColumn_20.Name = "id";
        this.dataGridViewTextBoxColumn_20.ReadOnly = true;
        this.dataGridViewTextBoxColumn_20.Visible = false;
        this.dataGridViewTextBoxColumn_21.DataPropertyName = "UNID";
        this.dataGridViewTextBoxColumn_21.HeaderText = "UNID";
        this.dataGridViewTextBoxColumn_21.Name = "uNIDDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_21.ReadOnly = true;
        this.dataGridViewTextBoxColumn_21.Visible = false;
        this.dataGridViewTextBoxColumn_22.DataPropertyName = "DateFact";
        this.dataGridViewTextBoxColumn_22.HeaderText = "Дата факт. выполнения";
        this.dataGridViewTextBoxColumn_22.Name = "dateFactDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_22.ReadOnly = true;
        this.dataGridViewTextBoxColumn_23.DataPropertyName = "Status";
        this.dataGridViewTextBoxColumn_23.HeaderText = "Отметка о выполнении";
        this.dataGridViewTextBoxColumn_23.Name = "statusDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_23.ReadOnly = true;
        this.dataGridViewTextBoxColumn_23.Width = 150;
        this.dataGridViewTextBoxColumn_24.DataPropertyName = "Subject";
        this.dataGridViewTextBoxColumn_24.HeaderText = "Тема";
        this.dataGridViewTextBoxColumn_24.Name = "Subject";
        this.dataGridViewTextBoxColumn_24.ReadOnly = true;
        this.dataGridViewTextBoxColumn_24.Width = 150;
        this.dataGridViewTextBoxColumn_25.DataPropertyName = "Body";
        this.dataGridViewTextBoxColumn_25.HeaderText = "Текст письма";
        this.dataGridViewTextBoxColumn_25.Name = "Body";
        this.dataGridViewTextBoxColumn_25.ReadOnly = true;
        this.dataGridViewTextBoxColumn_25.Width = 150;
        this.dataGridViewTextBoxColumn_26.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.dataGridViewTextBoxColumn_26.DataPropertyName = "Comment";
        this.dataGridViewTextBoxColumn_26.HeaderText = "Комментарий к исполнению";
        this.dataGridViewTextBoxColumn_26.Name = "commentDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_26.ReadOnly = true;
        this.dataGridViewComboBoxColumn_1.DataPropertyName = "Performer";
        this.dataGridViewComboBoxColumn_1.DataSource = this.bindingSource_0;
        this.dataGridViewComboBoxColumn_1.DisplayMember = "FIO";
        this.dataGridViewComboBoxColumn_1.FlatStyle = FlatStyle.Popup;
        this.dataGridViewComboBoxColumn_1.HeaderText = "Выполнил";
        this.dataGridViewComboBoxColumn_1.Name = "performerDataGridViewTextBoxColumn";
        this.dataGridViewComboBoxColumn_1.ReadOnly = true;
        this.dataGridViewComboBoxColumn_1.Resizable = DataGridViewTriState.True;
        this.dataGridViewComboBoxColumn_1.SortMode = DataGridViewColumnSortMode.Automatic;
        this.dataGridViewComboBoxColumn_1.ValueMember = "Id";
        this.dataGridViewComboBoxColumn_1.Width = 130;
        this.dataGridViewCheckBoxColumn_1.DataPropertyName = "Deleted";
        this.dataGridViewCheckBoxColumn_1.HeaderText = "Deleted";
        this.dataGridViewCheckBoxColumn_1.Name = "deletedDataGridViewCheckBoxColumn1";
        this.dataGridViewCheckBoxColumn_1.ReadOnly = true;
        this.dataGridViewCheckBoxColumn_1.Visible = false;
        this.bindingSource_6.DataMember = "vJ_MemCommission";
        this.bindingSource_6.DataSource = this.dataSetGES_0;
        this.bindingSource_6.CurrentChanged += new EventHandler(this.bindingSource_6_CurrentChanged);
        this.tableLayoutPanel_1.ColumnCount = 4;
        this.tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
        this.tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 382f));
        this.tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110f));
        this.tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 103f));
        this.tableLayoutPanel_1.Controls.Add(this.progressBar_0, 0, 2);
        this.tableLayoutPanel_1.Controls.Add(this.button_1, 3, 2);
        this.tableLayoutPanel_1.Controls.Add(this.tabControl_1, 0, 1);
        this.tableLayoutPanel_1.Controls.Add(this.button_0, 2, 2);
        this.tableLayoutPanel_1.Controls.Add(this.toolStrip_1, 0, 0);
        this.tableLayoutPanel_1.Controls.Add(this.button_2, 1, 2);
        this.tableLayoutPanel_1.Dock = DockStyle.Fill;
        this.tableLayoutPanel_1.Location = new Point(0, 0);
        this.tableLayoutPanel_1.Name = "tableLayoutPanel2";
        this.tableLayoutPanel_1.RowCount = 3;
        this.tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26f));
        this.tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
        this.tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41f));
        this.tableLayoutPanel_1.Size = new Size(840, 0x241);
        this.tableLayoutPanel_1.TabIndex = 8;
        this.tableLayoutPanel_1.TabIndexChanged += new EventHandler(this.tableLayoutPanel_1_TabIndexChanged);
        this.progressBar_0.Dock = DockStyle.Fill;
        this.progressBar_0.Location = new Point(8, 0x220);
        this.progressBar_0.Margin = new Padding(8, 8, 3, 10);
        this.progressBar_0.Name = "psbMemorandum";
        this.progressBar_0.Size = new Size(0xea, 0x17);
        this.progressBar_0.TabIndex = 9;
        this.tableLayoutPanel_1.SetColumnSpan(this.toolStrip_1, 4);
        this.toolStrip_1.Dock = DockStyle.Fill;
        ToolStripItem[] itemArray3 = new ToolStripItem[] { this.toolStripButton_3 };
        this.toolStrip_1.Items.AddRange(itemArray3);
        this.toolStrip_1.Location = new Point(0, 0);
        this.toolStrip_1.Name = "tsMemorandum";
        this.toolStrip_1.Size = new Size(840, 0x1a);
        this.toolStrip_1.TabIndex = 8;
        this.toolStrip_1.Text = "toolStrip2";
        this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_3.Image = Resources.refresh_16;
        this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
        this.toolStripButton_3.Name = "tsbUpdate";
        this.toolStripButton_3.Size = new Size(0x17, 0x17);
        this.toolStripButton_3.Text = "Синхронизировать данные";
        this.toolStripButton_3.Click += new EventHandler(this.toolStripButton_3_Click);
        this.button_2.Dock = DockStyle.Right;
        this.button_2.Location = new Point(0x219, 0x220);
        this.button_2.Margin = new Padding(3, 8, 3, 8);
        this.button_2.Name = "btnSave";
        this.button_2.Size = new Size(0x57, 0x19);
        this.button_2.TabIndex = 10;
        this.button_2.Text = "Сохранить";
        this.button_2.UseVisualStyleBackColor = true;
        this.button_2.Click += new EventHandler(this.button_2_Click);
        this.dataGridViewTextBoxColumn_3.DataPropertyName = "id";
        this.dataGridViewTextBoxColumn_3.HeaderText = "id";
        this.dataGridViewTextBoxColumn_3.Name = "dataGridViewTextBoxColumn1";
        this.dataGridViewTextBoxColumn_3.ReadOnly = true;
        this.dataGridViewTextBoxColumn_3.Visible = false;
        this.dataGridViewTextBoxColumn_4.DataPropertyName = "idMemorandum";
        this.dataGridViewTextBoxColumn_4.HeaderText = "idMemorandum";
        this.dataGridViewTextBoxColumn_4.Name = "dataGridViewTextBoxColumn2";
        this.dataGridViewTextBoxColumn_4.Visible = false;
        this.dataGridViewTextBoxColumn_5.DataPropertyName = "typeWorker";
        this.dataGridViewTextBoxColumn_5.HeaderText = "typeWorker";
        this.dataGridViewTextBoxColumn_5.Name = "dataGridViewTextBoxColumn3";
        this.dataGridViewTextBoxColumn_5.Visible = false;
        this.dataGridViewTextBoxColumn_6.DataPropertyName = "id";
        this.dataGridViewTextBoxColumn_6.HeaderText = "id";
        this.dataGridViewTextBoxColumn_6.Name = "dataGridViewTextBoxColumn4";
        this.dataGridViewTextBoxColumn_6.ReadOnly = true;
        this.dataGridViewTextBoxColumn_6.Visible = false;
        this.dataGridViewTextBoxColumn_7.DataPropertyName = "idMemorandum";
        this.dataGridViewTextBoxColumn_7.HeaderText = "idMemorandum";
        this.dataGridViewTextBoxColumn_7.Name = "dataGridViewTextBoxColumn5";
        this.dataGridViewTextBoxColumn_7.Visible = false;
        this.dataGridViewTextBoxColumn_8.DataPropertyName = "typeWorker";
        this.dataGridViewTextBoxColumn_8.HeaderText = "typeWorker";
        this.dataGridViewTextBoxColumn_8.Name = "dataGridViewTextBoxColumn6";
        this.dataGridViewTextBoxColumn_8.Visible = false;
        this.dataGridViewTextBoxColumn_9.DataPropertyName = "id";
        this.dataGridViewTextBoxColumn_9.HeaderText = "id";
        this.dataGridViewTextBoxColumn_9.Name = "dataGridViewTextBoxColumn7";
        this.dataGridViewTextBoxColumn_9.ReadOnly = true;
        this.dataGridViewTextBoxColumn_9.Visible = false;
        this.dataGridViewTextBoxColumn_10.DataPropertyName = "idMemorandum";
        this.dataGridViewTextBoxColumn_10.HeaderText = "idMemorandum";
        this.dataGridViewTextBoxColumn_10.Name = "dataGridViewTextBoxColumn8";
        this.dataGridViewTextBoxColumn_10.Visible = false;
        this.dataGridViewTextBoxColumn_11.DataPropertyName = "typeWorker";
        this.dataGridViewTextBoxColumn_11.HeaderText = "typeWorker";
        this.dataGridViewTextBoxColumn_11.Name = "dataGridViewTextBoxColumn9";
        this.dataGridViewTextBoxColumn_11.Visible = false;
        this.openFileDialog_0.Multiselect = true;
        this.backgroundWorker_0.DoWork += new DoWorkEventHandler(this.backgroundWorker_0_DoWork);
        this.backgroundWorker_0.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.backgroundWorker_0_RunWorkerCompleted);
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(840, 0x241);
        base.Controls.Add(this.tableLayoutPanel_1);
        base.Name = "FormSendMemorandum";
        base.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Отправка документа";
        base.FormClosing += new FormClosingEventHandler(this.Form27_FormClosing);
        base.Load += new EventHandler(this.Form27_Load);
        ((ISupportInitialize) this.bindingSource_4).EndInit();
        this.dataSetGES_0.EndInit();
        this.tabControl_0.ResumeLayout(false);
        this.tabPage_0.ResumeLayout(false);
        ((ISupportInitialize) this.dataGridView_0).EndInit();
        ((ISupportInitialize) this.bindingSource_0).EndInit();
        ((ISupportInitialize) this.bindingSource_1).EndInit();
        this.tabPage_1.ResumeLayout(false);
        ((ISupportInitialize) this.dataGridView_1).EndInit();
        ((ISupportInitialize) this.bindingSource_8).EndInit();
        ((ISupportInitialize) this.bindingSource_2).EndInit();
        this.tabPage_2.ResumeLayout(false);
        ((ISupportInitialize) this.dataGridView_2).EndInit();
        ((ISupportInitialize) this.bindingSource_9).EndInit();
        ((ISupportInitialize) this.bindingSource_3).EndInit();
        this.tabPage_5.ResumeLayout(false);
        this.tableLayoutPanel_3.ResumeLayout(false);
        ((ISupportInitialize) this.dataGridView_6).EndInit();
        ((ISupportInitialize) this.bindingSource_10).EndInit();
        ((ISupportInitialize) this.bindingSource_11).EndInit();
        this.tabControl_1.ResumeLayout(false);
        this.tabPage_3.ResumeLayout(false);
        this.tableLayoutPanel_0.ResumeLayout(false);
        this.tableLayoutPanel_0.PerformLayout();
        this.toolStrip_0.ResumeLayout(false);
        this.toolStrip_0.PerformLayout();
        ((ISupportInitialize) this.dataGridView_3).EndInit();
        ((ISupportInitialize) this.bindingSource_5).EndInit();
        this.tabPage_4.ResumeLayout(false);
        this.tableLayoutPanel_2.ResumeLayout(false);
        this.tableLayoutPanel_2.PerformLayout();
        ((ISupportInitialize) this.dataGridView_5).EndInit();
        ((ISupportInitialize) this.bindingSource_7).EndInit();
        this.toolStrip_2.ResumeLayout(false);
        this.toolStrip_2.PerformLayout();
        ((ISupportInitialize) this.dataGridView_4).EndInit();
        ((ISupportInitialize) this.bindingSource_6).EndInit();
        this.tableLayoutPanel_1.ResumeLayout(false);
        this.tableLayoutPanel_1.PerformLayout();
        this.toolStrip_1.ResumeLayout(false);
        this.toolStrip_1.PerformLayout();
        base.ResumeLayout(false);
    }

    [CompilerGenerated]
    private bool method_35(DataSetGES.Class148 class148_0)
    {
        return this.dataSetGES_0.tJ_MemWorker.Where<DataSetGES.Class152>((<>c.<>9__39_1 ?? (<>c.<>9__39_1 = new Func<DataSetGES.Class152, bool>(<>c.<>9.method_0)))).Select<DataSetGES.Class152, int>((<>c.<>9__39_2 ?? (<>c.<>9__39_2 = new Func<DataSetGES.Class152, int>(<>c.<>9.method_1)))).Contains<int>(class148_0.Id);
    }

    [CompilerGenerated]
    private bool method_36(DataSetGES.Class148 class148_0)
    {
        return this.dataSetGES_0.tJ_MemWorker.Where<DataSetGES.Class152>((<>c.<>9__39_5 ?? (<>c.<>9__39_5 = new Func<DataSetGES.Class152, bool>(<>c.<>9.method_3)))).Select<DataSetGES.Class152, int>((<>c.<>9__39_6 ?? (<>c.<>9__39_6 = new Func<DataSetGES.Class152, int>(<>c.<>9.method_4)))).Contains<int>(class148_0.Id);
    }

    [CompilerGenerated]
    private bool method_37(DataSetGES.Class148 class148_0)
    {
        return this.dataSetGES_0.tJ_MemWorker.Where<DataSetGES.Class152>((<>c.<>9__39_9 ?? (<>c.<>9__39_9 = new Func<DataSetGES.Class152, bool>(<>c.<>9.method_6)))).Select<DataSetGES.Class152, int>((<>c.<>9__39_10 ?? (<>c.<>9__39_10 = new Func<DataSetGES.Class152, int>(<>c.<>9.method_7)))).Contains<int>(class148_0.Id);
    }

    [CompilerGenerated]
    private void method_38()
    {
        this.label_5.Text = this.class222_0.SignDate + "/" + this.class222_0.RgNum;
    }

    [CompilerGenerated]
    internal int method_4()
    {
        return this.int_2;
    }

    [CompilerGenerated]
    internal void method_5(int int_3)
    {
        this.int_2 = int_3;
    }

    [CompilerGenerated]
    internal string method_6()
    {
        return this.string_0;
    }

    [CompilerGenerated]
    internal void method_7(string string_3)
    {
        this.string_0 = string_3;
    }

    [CompilerGenerated]
    internal StateFormCreate method_8()
    {
        return this.stateFormCreate_0;
    }

    [CompilerGenerated]
    internal void method_9(StateFormCreate stateFormCreate_1)
    {
        this.stateFormCreate_0 = stateFormCreate_1;
    }

    private void tableLayoutPanel_1_TabIndexChanged(object sender, EventArgs e)
    {
        this.method_17();
    }

    private void toolStripButton_0_Click(object sender, EventArgs e)
    {
        if (this.openFileDialog_0.ShowDialog() == DialogResult.OK)
        {
            if (this.list_0 == null)
            {
                this.list_0 = new List<string>();
            }
            foreach (string str in this.openFileDialog_0.FileNames)
            {
                if (!this.list_0.Contains(str))
                {
                    this.list_0.Add(str);
                }
                FileBinary binary = new FileBinary(str);
                DataSetGES.Class149 class2 = this.dataSetGES_0.tJ_MemFiles.method_5();
                class2.Deleted = false;
                class2.File = binary.get_ByteArray();
                class2.idDocument = -1;
                class2.Name = binary.get_Name();
                class2.Size = binary.get_KbSize();
                class2.TypeDoc = 1;
                class2.LastChange = binary.get_LastChanged();
                class2.EndEdit();
                this.dataSetGES_0.tJ_MemFiles.method_0(class2);
            }
        }
    }

    private void toolStripButton_1_Click(object sender, EventArgs e)
    {
        if ((this.bindingSource_5.Current != null) && (MessageBox.Show("Вы действительно хотите удалить выбранный файл?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
        {
            ((DataSetGES.Class149) ((DataRowView) this.bindingSource_5.Current).Row).Delete();
        }
    }

    private void toolStripButton_2_Click(object sender, EventArgs e)
    {
        this.method_17();
    }

    private void toolStripButton_3_Click(object sender, EventArgs e)
    {
        if ((this.method_8() == 1) && !string.IsNullOrEmpty(this.method_6()))
        {
            this.backgroundWorker_0.RunWorkerAsync(this.method_6());
        }
    }

    private void toolStripButton_4_Click(object sender, EventArgs e)
    {
        this.method_18(this.bindingSource_5, this.string_2);
    }

    private void toolStripButton_5_Click(object sender, EventArgs e)
    {
        if (this.openFileDialog_0.ShowDialog() == DialogResult.OK)
        {
            string[] fileNames = this.openFileDialog_0.FileNames;
            for (int i = 0; i < fileNames.Length; i++)
            {
                FileBinary binary = new FileBinary(fileNames[i]);
                DataSetGES.Class149 class2 = this.dataSetGES_0.tJ_MemFiles.method_5();
                class2.Deleted = false;
                class2.File = binary.get_ByteArray();
                class2.idDocument = -1;
                class2.Name = binary.get_Name();
                class2.Size = binary.get_KbSize();
                class2.TypeDoc = 2;
                class2.LastChange = binary.get_LastChanged();
                class2.EndEdit();
                this.dataSetGES_0.tJ_MemFiles.method_0(class2);
            }
        }
    }

    private void toolStripButton_6_Click(object sender, EventArgs e)
    {
        this.method_18(this.bindingSource_7, this.string_2);
    }

    private void toolStripButton_7_Click(object sender, EventArgs e)
    {
        if ((this.bindingSource_5.Current != null) && (MessageBox.Show("Вы действительно хотите удалить выбранный файл?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
        {
            ((DataSetGES.Class149) ((DataRowView) this.bindingSource_5.Current).Row).Delete();
        }
    }

    private void toolStripButton_8_Click(object sender, EventArgs e)
    {
        this.method_17();
    }

    [Serializable, CompilerGenerated]
    private sealed class <>c
    {
        public static readonly Form27.<>c <>9 = new Form27.<>c();
        public static Func<DataSetGES.Class152, bool> <>9__39_1;
        public static Func<DataSetGES.Class152, int> <>9__39_10;
        public static Func<DataSetGES.Class148, string> <>9__39_11;
        public static Func<DataSetGES.Class152, int> <>9__39_2;
        public static Func<DataSetGES.Class148, string> <>9__39_3;
        public static Func<DataSetGES.Class152, bool> <>9__39_5;
        public static Func<DataSetGES.Class152, int> <>9__39_6;
        public static Func<DataSetGES.Class148, string> <>9__39_7;
        public static Func<DataSetGES.Class152, bool> <>9__39_9;

        internal bool method_0(DataSetGES.Class152 class152_0)
        {
            return (class152_0.typeWorker == 0x514);
        }

        internal int method_1(DataSetGES.Class152 class152_0)
        {
            return class152_0.idWorker;
        }

        internal string method_2(DataSetGES.Class148 class148_0)
        {
            string[] textArray1 = new string[] { class148_0.FirstName, " ", class148_0.LastName, " ", class148_0.MiddleInitial };
            return string.Concat(textArray1);
        }

        internal bool method_3(DataSetGES.Class152 class152_0)
        {
            return (class152_0.typeWorker == 0x511);
        }

        internal int method_4(DataSetGES.Class152 class152_0)
        {
            return class152_0.idWorker;
        }

        internal string method_5(DataSetGES.Class148 class148_0)
        {
            string[] textArray1 = new string[] { class148_0.FirstName, " ", class148_0.LastName, " ", class148_0.MiddleInitial };
            return string.Concat(textArray1);
        }

        internal bool method_6(DataSetGES.Class152 class152_0)
        {
            return (class152_0.typeWorker == 0x512);
        }

        internal int method_7(DataSetGES.Class152 class152_0)
        {
            return class152_0.idWorker;
        }

        internal string method_8(DataSetGES.Class148 class148_0)
        {
            string[] textArray1 = new string[] { class148_0.FirstName, " ", class148_0.LastName, " ", class148_0.MiddleInitial };
            return string.Concat(textArray1);
        }
    }

    [CompilerGenerated]
    private sealed class Class36
    {
        public int int_0;
        public int int_1;

        internal bool method_0(DataSetGES.Class152 class152_0)
        {
            return ((class152_0.idMemorandum == this.int_0) && (class152_0.typeWorker == 0x513));
        }

        internal bool method_1(DataSetGES.Class148 class148_0)
        {
            return (class148_0.Id == this.int_1);
        }
    }

    [CompilerGenerated]
    private sealed class Class37
    {
        public Func<DataSetGES.Class155, bool> func_0;
        public string string_0;

        internal bool method_0(DataSetGES.Class155 class155_0)
        {
            return (class155_0.UNID == this.string_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class38
    {
        public Enum18 enum18_0;
        public int int_0;
    }

    [CompilerGenerated]
    private sealed class Class39
    {
        public Class224 class224_0;
        public Form27.Class38 class38_0;

        internal bool method_0(DataSetGES.Class149 class149_0)
        {
            return (((class149_0.TypeDoc == this.class38_0.enum18_0) && (class149_0.idDocument == this.class38_0.int_0)) && (class149_0.Name == this.class224_0.Name));
        }
    }

    [CompilerGenerated]
    private sealed class Class40
    {
        public bool bool_0;
        public Form27 form27_0;

        internal void method_0()
        {
            this.form27_0.progressBar_0.Style = this.bool_0 ? ProgressBarStyle.Marquee : ProgressBarStyle.Blocks;
        }
    }
}

