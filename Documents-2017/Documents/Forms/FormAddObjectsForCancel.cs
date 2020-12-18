namespace Documents.Forms
{
    using DataSql;
    using Documents.DataSets;
    using FormLbr;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;

    public class FormAddObjectsForCancel : FormBase
    {
        private BindingSource bindingSource_0;
        private BindingSource bindingSource_1;
        private BindingSource bindingSource_2;
        private BindingSource bindingSource_3;
        private BindingSource bindingSource_4;
        private bool bool_0;
        private Button button_0;
        private Button button_1;
        private Class203 class203_0;
        private Class204 class204_0;
        private Class205 class205_0;
        private Class206 class206_0;
        private Class207 class207_0;
        private Class212 class212_0;
        private Class213 class213_0;
        private ContextMenuStrip contextMenuStrip_0;
        private DataGridView dataGridView_0;
        private DataGridView dataGridView_1;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_0;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;
        private Dictionary<int, OrgDataSet.Class411> dictionary_0;
        private Dictionary<string, OrgDataSet.Class411> dictionary_1;
        private Dictionary<int, OrgDataSet.Class415> dictionary_2;
        private IContainer icontainer_0;
        private int int_0;
        private int int_1;
        private Label label_0;
        private MaskedTextBox maskedTextBox_0;
        private OrgDataSet orgDataSet_0;
        private string string_0;
        public BindingSource tblAbnAplForDisconIndividualUsersBindingSource;
        public BindingSource tblAbnAplForDisconObjectsBindingSource;
        private ToolStripMenuItem toolStripMenuItem_0;
        private ToolStripTextBox toolStripTextBox_0;

        public FormAddObjectsForCancel(int typeAplID, int code, bool legal, int numCurrentApplication, SQLSettings SqlSettings)
        {
            this.bool_0 = true;
            this.dictionary_0 = new Dictionary<int, OrgDataSet.Class411>();
            this.dictionary_1 = new Dictionary<string, OrgDataSet.Class411>();
            this.dictionary_2 = new Dictionary<int, OrgDataSet.Class415>();
            this.method_0();
            this.set_SqlSettings(SqlSettings);
            this.int_0 = typeAplID;
            string str = code.ToString();
            int num = 10 - str.Length;
            this.int_1 = numCurrentApplication;
            for (int i = 0; i < num; i++)
            {
                this.string_0 = this.string_0 + "0";
            }
            this.string_0 = this.string_0 + str;
            if (this.string_0 != "")
            {
                this.maskedTextBox_0.Enabled = false;
            }
            this.bool_0 = legal;
            this.class213_0.method_1().ConnectionString = this.get_SqlSettings().GetConnectionString();
            this.class207_0.method_1().ConnectionString = this.get_SqlSettings().GetConnectionString();
            this.class203_0.method_1().ConnectionString = this.get_SqlSettings().GetConnectionString();
            this.class204_0.method_1().ConnectionString = this.get_SqlSettings().GetConnectionString();
            this.class212_0.method_1().ConnectionString = this.get_SqlSettings().GetConnectionString();
            this.class205_0.method_1().ConnectionString = this.get_SqlSettings().GetConnectionString();
            this.class206_0.method_1().ConnectionString = this.get_SqlSettings().GetConnectionString();
        }

        public FormAddObjectsForCancel(int typeAplID, string code, bool legal, int numCurrentApplication, SQLSettings SqlSettings)
        {
            this.bool_0 = true;
            this.dictionary_0 = new Dictionary<int, OrgDataSet.Class411>();
            this.dictionary_1 = new Dictionary<string, OrgDataSet.Class411>();
            this.dictionary_2 = new Dictionary<int, OrgDataSet.Class415>();
            this.method_0();
            this.set_SqlSettings(SqlSettings);
            this.int_0 = typeAplID;
            this.string_0 = code;
            this.bool_0 = legal;
            this.int_1 = numCurrentApplication;
            if (code != "")
            {
                this.maskedTextBox_0.Enabled = false;
            }
            this.class213_0.method_1().ConnectionString = this.get_SqlSettings().GetConnectionString();
            this.class207_0.method_1().ConnectionString = this.get_SqlSettings().GetConnectionString();
            this.class204_0.method_1().ConnectionString = this.get_SqlSettings().GetConnectionString();
            this.class212_0.method_1().ConnectionString = this.get_SqlSettings().GetConnectionString();
            this.class205_0.method_1().ConnectionString = this.get_SqlSettings().GetConnectionString();
            this.class206_0.method_1().ConnectionString = this.get_SqlSettings().GetConnectionString();
        }

        private void dataGridView_0_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = e.RowIndex; i < (e.RowIndex + e.RowCount); i++)
            {
                OrgDataSet.Class420 row = (OrgDataSet.Class420) ((DataRowView) this.bindingSource_3[i]).Row;
                if (row.method_20())
                {
                    if (!row.method_32())
                    {
                        row.NameShort = row.NoDogAbn;
                    }
                    if (!row.method_34())
                    {
                        row.method_3(row.NoDogObj);
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

        private void FormAddObjectsForCancel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (base.DialogResult == DialogResult.OK)
            {
                IEnumerator enumerator;
                IEnumerator enumerator2;
                if (this.bool_0)
                {
                    using (enumerator = this.bindingSource_3.GetEnumerator())
                    {
                        while (enumerator.MoveNext())
                        {
                            OrgDataSet.Class420 row = (OrgDataSet.Class420) ((DataRowView) enumerator.Current).Row;
                            if (row.method_8())
                            {
                                OrgDataSet.Class411 class3;
                                if (!row.method_16() && this.dictionary_0.ContainsKey(row.method_4()))
                                {
                                    class3 = this.dictionary_0[row.method_4()];
                                }
                                else if (!row.method_34() && this.dictionary_1.ContainsKey(row.NoDogObj))
                                {
                                    class3 = this.dictionary_1[row.NoDogObj];
                                }
                                else
                                {
                                    this.tblAbnAplForDisconObjectsBindingSource.AddNew();
                                    class3 = (OrgDataSet.Class411) ((DataRowView) this.tblAbnAplForDisconObjectsBindingSource.Current).Row;
                                }
                                if (!row.method_12())
                                {
                                    class3.method_3(row.method_0());
                                }
                                if (!row.method_16())
                                {
                                    class3.method_5(row.method_4());
                                }
                                if (!row.method_30())
                                {
                                    class3.PlaceId = row.method_10();
                                }
                                if (!row.method_26())
                                {
                                    class3.Reason = row.Reason;
                                }
                                if (!row.method_28())
                                {
                                    class3.Comments = row.Comments;
                                }
                                if (!row.method_18())
                                {
                                    class3.DateDog = row.DateDog;
                                }
                                if (!row.method_20())
                                {
                                    class3.Code = row.Code;
                                }
                                if (!row.method_22())
                                {
                                    class3.NameShort = row.NameShort;
                                }
                                if (!row.method_14())
                                {
                                    class3.method_7(row.method_2());
                                }
                                if (row.method_20())
                                {
                                    if (!row.method_34())
                                    {
                                        class3.method_7(row.NoDogObj);
                                        class3.NoDogObj = row.NoDogObj;
                                    }
                                    if (!row.method_32())
                                    {
                                        class3.NameShort = row.NoDogAbn;
                                        class3.NoDogAbn = row.NoDogAbn;
                                    }
                                }
                                class3.method_9(row.method_6());
                                this.tblAbnAplForDisconObjectsBindingSource.EndEdit();
                            }
                            else
                            {
                                using (enumerator2 = this.tblAbnAplForDisconObjectsBindingSource.GetEnumerator())
                                {
                                    OrgDataSet.Class411 class4;
                                    while (enumerator2.MoveNext())
                                    {
                                        class4 = (OrgDataSet.Class411) ((DataRowView) enumerator2.Current).Row;
                                        if (row.method_16() && class4.method_36())
                                        {
                                            if (row.NoDogObj != class4.NoDogObj)
                                            {
                                                continue;
                                            }
                                            goto Label_0260;
                                        }
                                        if ((!row.method_16() && !class4.method_36()) && (row.method_4() == class4.method_4()))
                                        {
                                            goto Label_0292;
                                        }
                                    }
                                    continue;
                                Label_0260:
                                    this.class203_0.vmethod_20(class4.NoDogObj, new int?(this.int_1));
                                    class4.Delete();
                                    this.tblAbnAplForDisconObjectsBindingSource.EndEdit();
                                    continue;
                                Label_0292:
                                    this.class203_0.vmethod_19(new int?(class4.method_4()), new int?(this.int_1));
                                    class4.Delete();
                                    this.tblAbnAplForDisconObjectsBindingSource.EndEdit();
                                    continue;
                                }
                            }
                        }
                        goto Label_04D9;
                    }
                }
                using (enumerator = this.bindingSource_4.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        OrgDataSet.Class421 class5 = (OrgDataSet.Class421) ((DataRowView) enumerator.Current).Row;
                        if (class5.method_0())
                        {
                            OrgDataSet.Class415 class6;
                            if (this.dictionary_2.ContainsKey(class5.Id))
                            {
                                class6 = this.dictionary_2[class5.Id];
                            }
                            else
                            {
                                this.tblAbnAplForDisconIndividualUsersBindingSource.AddNew();
                                class6 = (OrgDataSet.Class415) ((DataRowView) this.tblAbnAplForDisconIndividualUsersBindingSource.Current).Row;
                            }
                            if (!class5.method_6())
                            {
                                class6.FIO = class5.FIO;
                            }
                            if (!class5.method_8())
                            {
                                class6.Address = class5.Address;
                            }
                            if (!class5.method_10())
                            {
                                class6.PlaceId = class5.PlaceId;
                            }
                            if (!class5.method_18())
                            {
                                class6.Reason = class5.Reason;
                            }
                            if (!class5.method_16())
                            {
                                class6.DateDog = class5.DateDog;
                            }
                            if (!class5.method_14())
                            {
                                class6.Code = class5.Code;
                            }
                            class6.method_5(class5.method_2());
                            this.tblAbnAplForDisconIndividualUsersBindingSource.EndEdit();
                        }
                        else
                        {
                            using (enumerator2 = this.tblAbnAplForDisconObjectsBindingSource.GetEnumerator())
                            {
                                OrgDataSet.Class415 class7;
                                while (enumerator2.MoveNext())
                                {
                                    class7 = (OrgDataSet.Class415) ((DataRowView) enumerator2.Current).Row;
                                    if (class5.Id == class7.Id)
                                    {
                                        goto Label_0472;
                                    }
                                }
                                continue;
                            Label_0472:
                                this.class207_0.vmethod_19(class7.FIO, new int?(this.int_1));
                                class7.Delete();
                                this.tblAbnAplForDisconIndividualUsersBindingSource.EndEdit();
                                continue;
                            }
                        }
                    }
                }
            }
        Label_04D9:
            this.tblAbnAplForDisconObjectsBindingSource.RemoveFilter();
        }

        private void FormAddObjectsForCancel_Load(object sender, EventArgs e)
        {
            IEnumerator enumerator;
            IEnumerator enumerator2;
            this.class204_0.vmethod_0(this.orgDataSet_0.tblAbnAplForDisconReason, new int?(this.int_0));
            if (this.string_0 != "")
            {
                this.maskedTextBox_0.Text = this.string_0;
            }
            if (this.bool_0)
            {
                using (enumerator = this.tblAbnAplForDisconObjectsBindingSource.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        OrgDataSet.Class411 row = (OrgDataSet.Class411) ((DataRowView) enumerator.Current).Row;
                        using (enumerator2 = this.bindingSource_3.GetEnumerator())
                        {
                            OrgDataSet.Class420 class3;
                            while (enumerator2.MoveNext())
                            {
                                class3 = (OrgDataSet.Class420) ((DataRowView) enumerator2.Current).Row;
                                if (class3.method_16() && row.method_36())
                                {
                                    if (class3.NoDogObj != row.NoDogObj)
                                    {
                                        continue;
                                    }
                                    goto Label_00EC;
                                }
                                if ((!class3.method_16() && !row.method_36()) && (class3.method_4() == row.method_4()))
                                {
                                    goto Label_011B;
                                }
                            }
                            continue;
                        Label_00EC:
                            class3.method_9(true);
                            if (!row.method_42())
                            {
                                class3.Reason = row.Reason;
                            }
                            this.dictionary_1.Add(class3.NoDogObj, row);
                            continue;
                        Label_011B:
                            class3.method_9(true);
                            if (!row.method_42())
                            {
                                class3.Reason = row.Reason;
                            }
                            if (!this.dictionary_0.ContainsKey(class3.method_4()))
                            {
                                this.dictionary_0.Add(class3.method_4(), row);
                            }
                            continue;
                        }
                    }
                    goto Label_0284;
                }
            }
            using (enumerator = this.tblAbnAplForDisconIndividualUsersBindingSource.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    OrgDataSet.Class415 class4 = (OrgDataSet.Class415) ((DataRowView) enumerator.Current).Row;
                    using (enumerator2 = this.bindingSource_4.GetEnumerator())
                    {
                        OrgDataSet.Class421 class5;
                        while (enumerator2.MoveNext())
                        {
                            class5 = (OrgDataSet.Class421) ((DataRowView) enumerator2.Current).Row;
                            if ((class5.FIO == class4.FIO) && (class5.Address == class4.Address))
                            {
                                goto Label_021A;
                            }
                        }
                        continue;
                    Label_021A:
                        class5.method_1(true);
                        if (!class4.method_36())
                        {
                            class5.Reason = class4.Reason;
                        }
                        this.dictionary_2.Add(class5.Id, class4);
                        continue;
                    }
                }
            }
        Label_0284:
            if (!this.bool_0)
            {
                this.dataGridView_0.Enabled = false;
                this.dataGridView_0.Visible = false;
                this.dataGridView_1.Enabled = true;
                this.dataGridView_1.Visible = true;
            }
        }

        private void maskedTextBox_0_TextChanged(object sender, EventArgs e)
        {
            if (this.maskedTextBox_0.Text.Length > 0)
            {
                if (this.bool_0)
                {
                    this.class212_0.vmethod_0(this.orgDataSet_0.tblAbnObj2, new int?(this.int_1), Convert.ToInt32(this.maskedTextBox_0.Text));
                }
                else
                {
                    this.class213_0.vmethod_0(this.orgDataSet_0.tblAbnAplForDisconIndividualUsersForCancel, new int?(this.int_1), Convert.ToInt32(this.maskedTextBox_0.Text));
                }
            }
            else if (this.bool_0)
            {
                this.class212_0.vmethod_0(this.orgDataSet_0.tblAbnObj2, new int?(this.int_1), -1);
            }
            else
            {
                this.class213_0.vmethod_0(this.orgDataSet_0.tblAbnAplForDisconIndividualUsersForCancel, new int?(this.int_1), -1);
            }
        }

        private void method_0()
        {
            this.icontainer_0 = new Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(FormAddObjectsForCancel));
            this.label_0 = new Label();
            this.orgDataSet_0 = new OrgDataSet();
            this.maskedTextBox_0 = new MaskedTextBox();
            this.dataGridView_0 = new DataGridView();
            this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn_0 = new DataGridViewComboBoxColumn();
            this.contextMenuStrip_0 = new ContextMenuStrip(this.icontainer_0);
            this.toolStripTextBox_0 = new ToolStripTextBox();
            this.toolStripMenuItem_0 = new ToolStripMenuItem();
            this.bindingSource_2 = new BindingSource(this.icontainer_0);
            this.bindingSource_3 = new BindingSource(this.icontainer_0);
            this.button_0 = new Button();
            this.button_1 = new Button();
            this.class204_0 = new Class204();
            this.dataGridView_1 = new DataGridView();
            this.dataGridViewCheckBoxColumn_1 = new DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn_1 = new DataGridViewComboBoxColumn();
            this.bindingSource_4 = new BindingSource(this.icontainer_0);
            this.class207_0 = new Class207();
            this.bindingSource_0 = new BindingSource(this.icontainer_0);
            this.bindingSource_1 = new BindingSource(this.icontainer_0);
            this.tblAbnAplForDisconObjectsBindingSource = new BindingSource(this.icontainer_0);
            this.tblAbnAplForDisconIndividualUsersBindingSource = new BindingSource(this.icontainer_0);
            this.class206_0 = new Class206();
            this.class205_0 = new Class205();
            this.class212_0 = new Class212();
            this.class213_0 = new Class213();
            this.class203_0 = new Class203();
            this.orgDataSet_0.BeginInit();
            ((ISupportInitialize) this.dataGridView_0).BeginInit();
            this.contextMenuStrip_0.SuspendLayout();
            ((ISupportInitialize) this.bindingSource_2).BeginInit();
            ((ISupportInitialize) this.bindingSource_3).BeginInit();
            ((ISupportInitialize) this.dataGridView_1).BeginInit();
            ((ISupportInitialize) this.bindingSource_4).BeginInit();
            ((ISupportInitialize) this.bindingSource_0).BeginInit();
            ((ISupportInitialize) this.bindingSource_1).BeginInit();
            ((ISupportInitialize) this.tblAbnAplForDisconObjectsBindingSource).BeginInit();
            ((ISupportInitialize) this.tblAbnAplForDisconIndividualUsersBindingSource).BeginInit();
            base.SuspendLayout();
            this.label_0.AutoSize = true;
            this.label_0.Location = new Point(12, 9);
            this.label_0.Name = "label1";
            this.label_0.Size = new Size(0x62, 13);
            this.label_0.TabIndex = 0;
            this.label_0.Text = "Номер заявления";
            this.orgDataSet_0.DataSetName = "OrgDataSet";
            this.orgDataSet_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.maskedTextBox_0.BeepOnError = true;
            this.maskedTextBox_0.Location = new Point(0x9b, 6);
            this.maskedTextBox_0.Mask = "0000000000";
            this.maskedTextBox_0.Name = "maskedTextBoxCode";
            this.maskedTextBox_0.Size = new Size(210, 20);
            this.maskedTextBox_0.TabIndex = 2;
            this.maskedTextBox_0.TextChanged += new EventHandler(this.maskedTextBox_0_TextChanged);
            this.dataGridView_0.AllowUserToAddRows = false;
            this.dataGridView_0.AllowUserToDeleteRows = false;
            this.dataGridView_0.AutoGenerateColumns = false;
            this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewCheckBoxColumn_0, this.dataGridViewTextBoxColumn_0, this.dataGridViewTextBoxColumn_1, this.dataGridViewTextBoxColumn_2, this.dataGridViewComboBoxColumn_0 };
            this.dataGridView_0.Columns.AddRange(dataGridViewColumns);
            this.dataGridView_0.DataSource = this.bindingSource_3;
            this.dataGridView_0.Location = new Point(12, 0x20);
            this.dataGridView_0.Name = "dataGridView1Legal";
            this.dataGridView_0.RowHeadersWidth = 0x19;
            this.dataGridView_0.Size = new Size(0x1ff, 0x132);
            this.dataGridView_0.TabIndex = 3;
            this.dataGridView_0.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dataGridView_0_RowsAdded);
            this.dataGridViewCheckBoxColumn_0.DataPropertyName = "Label";
            this.dataGridViewCheckBoxColumn_0.HeaderText = "";
            this.dataGridViewCheckBoxColumn_0.Name = "labelDataGridViewCheckBoxColumn";
            this.dataGridViewCheckBoxColumn_0.Width = 0x19;
            this.dataGridViewTextBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_0.DataPropertyName = "NameShort";
            this.dataGridViewTextBoxColumn_0.HeaderText = "Наименование абонента";
            this.dataGridViewTextBoxColumn_0.Name = "NameShort";
            this.dataGridViewTextBoxColumn_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_1.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn_1.HeaderText = "Наименование объекта";
            this.dataGridViewTextBoxColumn_1.Name = "pointDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_1.ReadOnly = true;
            this.dataGridViewTextBoxColumn_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_2.DataPropertyName = "idPoint";
            this.dataGridViewTextBoxColumn_2.FillWeight = 75f;
            this.dataGridViewTextBoxColumn_2.HeaderText = "Пункт ввода ограничения";
            this.dataGridViewTextBoxColumn_2.Name = "titleDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_2.ReadOnly = true;
            this.dataGridViewComboBoxColumn_0.ContextMenuStrip = this.contextMenuStrip_0;
            this.dataGridViewComboBoxColumn_0.DataPropertyName = "Reason";
            this.dataGridViewComboBoxColumn_0.DataSource = this.bindingSource_2;
            this.dataGridViewComboBoxColumn_0.DisplayMember = "Reason";
            this.dataGridViewComboBoxColumn_0.HeaderText = "Причина";
            this.dataGridViewComboBoxColumn_0.Name = "Reason";
            this.dataGridViewComboBoxColumn_0.Resizable = DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn_0.SortMode = DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewComboBoxColumn_0.ValueMember = "Id";
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripTextBox_0, this.toolStripMenuItem_0 };
            this.contextMenuStrip_0.Items.AddRange(toolStripItems);
            this.contextMenuStrip_0.Name = "contextMenuStripAddReason";
            this.contextMenuStrip_0.Size = new Size(0xa1, 0x33);
            this.toolStripTextBox_0.BackColor = Color.White;
            this.toolStripTextBox_0.Name = "toolStripTextBoxInputReason";
            this.toolStripTextBox_0.Size = new Size(100, 0x17);
            this.toolStripMenuItem_0.Name = "toolStripMenuItemAddReason";
            this.toolStripMenuItem_0.Size = new Size(160, 0x16);
            this.toolStripMenuItem_0.Text = "Добавить";
            this.toolStripMenuItem_0.Click += new EventHandler(this.toolStripMenuItem_0_Click);
            this.bindingSource_2.DataMember = "tblAbnAplForDisconReason";
            this.bindingSource_2.DataSource = this.orgDataSet_0;
            this.bindingSource_3.DataMember = "tblAbnObj2";
            this.bindingSource_3.DataSource = this.orgDataSet_0;
            this.button_0.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.button_0.DialogResult = DialogResult.OK;
            this.button_0.Location = new Point(0x16f, 0x160);
            this.button_0.Name = "buttonAdd";
            this.button_0.Size = new Size(0x4b, 0x17);
            this.button_0.TabIndex = 4;
            this.button_0.Text = "Добавить";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_1.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.button_1.DialogResult = DialogResult.Cancel;
            this.button_1.Location = new Point(0x1c0, 0x160);
            this.button_1.Name = "buttonCancel";
            this.button_1.Size = new Size(0x4b, 0x17);
            this.button_1.TabIndex = 4;
            this.button_1.Text = "Отмена";
            this.button_1.UseVisualStyleBackColor = true;
            this.class204_0.method_7(true);
            this.dataGridView_1.AllowUserToAddRows = false;
            this.dataGridView_1.AllowUserToDeleteRows = false;
            this.dataGridView_1.AutoGenerateColumns = false;
            this.dataGridView_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray2 = new DataGridViewColumn[] { this.dataGridViewCheckBoxColumn_1, this.dataGridViewTextBoxColumn_3, this.dataGridViewTextBoxColumn_4, this.dataGridViewTextBoxColumn_5, this.dataGridViewComboBoxColumn_1 };
            this.dataGridView_1.Columns.AddRange(columnArray2);
            this.dataGridView_1.DataSource = this.bindingSource_4;
            this.dataGridView_1.Enabled = false;
            this.dataGridView_1.Location = new Point(12, 0x20);
            this.dataGridView_1.Name = "dataGridView2Individual";
            this.dataGridView_1.RowHeadersWidth = 0x19;
            this.dataGridView_1.Size = new Size(0x1ff, 0x132);
            this.dataGridView_1.TabIndex = 5;
            this.dataGridView_1.Visible = false;
            this.dataGridViewCheckBoxColumn_1.DataPropertyName = "Label";
            this.dataGridViewCheckBoxColumn_1.HeaderText = "";
            this.dataGridViewCheckBoxColumn_1.Name = "Label";
            this.dataGridViewCheckBoxColumn_1.Width = 0x19;
            this.dataGridViewTextBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_3.DataPropertyName = "FIO";
            this.dataGridViewTextBoxColumn_3.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn_3.Name = "fIODataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_4.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn_4.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn_4.Name = "addressDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_5.DataPropertyName = "Place";
            this.dataGridViewTextBoxColumn_5.HeaderText = "Пункт ввода ограничения";
            this.dataGridViewTextBoxColumn_5.Name = "placeIdDataGridViewTextBoxColumn";
            this.dataGridViewComboBoxColumn_1.ContextMenuStrip = this.contextMenuStrip_0;
            this.dataGridViewComboBoxColumn_1.DataPropertyName = "Reason";
            this.dataGridViewComboBoxColumn_1.DataSource = this.bindingSource_2;
            this.dataGridViewComboBoxColumn_1.DisplayMember = "Reason";
            this.dataGridViewComboBoxColumn_1.HeaderText = "Причина";
            this.dataGridViewComboBoxColumn_1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn_1.Resizable = DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn_1.SortMode = DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn_1.ValueMember = "Id";
            this.bindingSource_4.DataMember = "tblAbnAplForDisconIndividualUsersForCancel";
            this.bindingSource_4.DataSource = this.orgDataSet_0;
            this.class207_0.method_7(true);
            this.bindingSource_0.DataMember = "tblAbn";
            this.bindingSource_0.DataSource = this.orgDataSet_0;
            this.bindingSource_1.DataMember = "tblAbnObj";
            this.bindingSource_1.DataSource = this.orgDataSet_0;
            this.tblAbnAplForDisconObjectsBindingSource.DataMember = "tblAbnAplForDisconObjects";
            this.tblAbnAplForDisconObjectsBindingSource.DataSource = this.orgDataSet_0;
            this.tblAbnAplForDisconIndividualUsersBindingSource.DataMember = "tblAbnAplForDisconIndividualUsers";
            this.tblAbnAplForDisconIndividualUsersBindingSource.DataSource = this.orgDataSet_0;
            this.class206_0.method_7(true);
            this.class205_0.method_7(true);
            this.class212_0.method_7(true);
            this.class213_0.method_7(true);
            this.class203_0.method_7(true);
            base.AcceptButton = this.button_0;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x217, 0x183);
            base.Controls.Add(this.button_1);
            base.Controls.Add(this.button_0);
            base.Controls.Add(this.maskedTextBox_0);
            base.Controls.Add(this.label_0);
            base.Controls.Add(this.dataGridView_0);
            base.Controls.Add(this.dataGridView_1);
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Name = "FormAddObjectsForCancel";
            this.Text = "Добавление объектов для отмены";
            base.FormClosing += new FormClosingEventHandler(this.FormAddObjectsForCancel_FormClosing);
            base.Load += new EventHandler(this.FormAddObjectsForCancel_Load);
            this.orgDataSet_0.EndInit();
            ((ISupportInitialize) this.dataGridView_0).EndInit();
            this.contextMenuStrip_0.ResumeLayout(false);
            this.contextMenuStrip_0.PerformLayout();
            ((ISupportInitialize) this.bindingSource_2).EndInit();
            ((ISupportInitialize) this.bindingSource_3).EndInit();
            ((ISupportInitialize) this.dataGridView_1).EndInit();
            ((ISupportInitialize) this.bindingSource_4).EndInit();
            ((ISupportInitialize) this.bindingSource_0).EndInit();
            ((ISupportInitialize) this.bindingSource_1).EndInit();
            ((ISupportInitialize) this.tblAbnAplForDisconObjectsBindingSource).EndInit();
            ((ISupportInitialize) this.tblAbnAplForDisconIndividualUsersBindingSource).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void toolStripMenuItem_0_Click(object sender, EventArgs e)
        {
            this.bindingSource_2.AddNew();
            OrgDataSet.Class412 row = (OrgDataSet.Class412) ((DataRowView) this.bindingSource_2.Current).Row;
            row.Reason = this.toolStripTextBox_0.Text;
            row.method_1(this.int_0);
            this.bindingSource_2.EndEdit();
            this.class204_0.vmethod_2(this.orgDataSet_0.tblAbnAplForDisconReason);
            this.toolStripTextBox_0.Text = string.Empty;
        }
    }
}

