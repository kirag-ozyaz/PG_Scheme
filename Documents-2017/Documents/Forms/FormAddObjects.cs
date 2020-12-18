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

    public class FormAddObjects : FormBase
    {
        private BindingSource bindingSource_0;
        private BindingSource bindingSource_1;
        private BindingSource bindingSource_2;
        private Button button_0;
        private Button button_1;
        private CheckBox checkBox_0;
        private CheckBox checkBox_1;
        private Class204 class204_0;
        private Class205 class205_0;
        private Class206 class206_0;
        private ComboBox comboBox_0;
        private ContextMenuStrip contextMenuStrip_0;
        private DataGridView dataGridView_0;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;
        private Dictionary<int, OrgDataSet.Class411> dictionary_0;
        private IContainer icontainer_0;
        private int int_0;
        private int int_1;
        private Label label_0;
        private Label label_1;
        private Label label_2;
        private Label label_3;
        private Label label_4;
        private Label label_5;
        private Label label_6;
        private Label label_7;
        private Label label_8;
        private MaskedTextBox maskedTextBox_0;
        private OrgDataSet orgDataSet_0;
        private Panel panel_0;
        public BindingSource tblAbnAplForDisconObjectsBindingSource;
        private TextBox textBox_0;
        private TextBox textBox_1;
        private TextBox textBox_2;
        private TextBox textBox_3;
        private ToolStripMenuItem toolStripMenuItem_0;
        private ToolStripTextBox toolStripTextBox_0;

        public FormAddObjects()
        {
            this.dictionary_0 = new Dictionary<int, OrgDataSet.Class411>();
            this.method_0();
        }

        public FormAddObjects(int typeAplID, SQLSettings SqlSettings)
        {
            this.dictionary_0 = new Dictionary<int, OrgDataSet.Class411>();
            this.method_0();
            base.set_PermissionsSql(false);
            this.set_SqlSettings(SqlSettings);
            this.int_0 = typeAplID;
            this.checkBox_0.Checked = true;
            if (this.int_1 != 0)
            {
                this.maskedTextBox_0.Enabled = false;
            }
            this.checkBox_1.Visible = this.label_8.Visible = this.dataGridViewCheckBoxColumn_1.Visible = typeAplID == 0;
        }

        public FormAddObjects(int typeAplID, int code, SQLSettings SqlSettings)
        {
            this.dictionary_0 = new Dictionary<int, OrgDataSet.Class411>();
            this.method_0();
            base.set_PermissionsSql(false);
            this.set_SqlSettings(SqlSettings);
            this.int_0 = typeAplID;
            this.int_1 = code;
            if (code != 0)
            {
                this.maskedTextBox_0.Enabled = false;
            }
            this.checkBox_1.Visible = this.label_8.Visible = this.dataGridViewCheckBoxColumn_1.Visible = typeAplID == 0;
        }

        private void checkBox_0_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_0.Checked)
            {
                this.maskedTextBox_0.Enabled = false;
                this.panel_0.Visible = true;
                this.tblAbnAplForDisconObjectsBindingSource.AddNew();
            }
            else
            {
                this.maskedTextBox_0.Enabled = true;
                this.panel_0.Visible = false;
                this.tblAbnAplForDisconObjectsBindingSource.RemoveCurrent();
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

        private void FormAddObjects_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (base.DialogResult == DialogResult.OK)
            {
                using (IEnumerator enumerator = this.bindingSource_1.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        OrgDataSet.Class413 row = (OrgDataSet.Class413) ((DataRowView) enumerator.Current).Row;
                        if (row.method_6())
                        {
                            OrgDataSet.Class411 class3;
                            if (this.dictionary_0.ContainsKey(row.method_2()))
                            {
                                class3 = this.dictionary_0[row.method_2()];
                            }
                            else
                            {
                                this.tblAbnAplForDisconObjectsBindingSource.AddNew();
                                class3 = (OrgDataSet.Class411) ((DataRowView) this.tblAbnAplForDisconObjectsBindingSource.Current).Row;
                            }
                            class3.method_3(this.int_1);
                            class3.method_5(row.method_2());
                            if (!row.method_12())
                            {
                                class3.PlaceId = row.Point;
                            }
                            if (!row.method_18())
                            {
                                class3.Reason = row.Reason;
                            }
                            if (!row.method_20())
                            {
                                class3.Comments = row.Comments;
                            }
                            if (!((OrgDataSet.Class414) ((DataRowView) this.bindingSource_0[0]).Row).method_6())
                            {
                                class3.DateDog = ((OrgDataSet.Class414) ((DataRowView) this.bindingSource_0[0]).Row).DateDog;
                            }
                            if (!((OrgDataSet.Class414) ((DataRowView) this.bindingSource_0[0]).Row).method_8())
                            {
                                class3.Code = ((OrgDataSet.Class414) ((DataRowView) this.bindingSource_0[0]).Row).Code;
                            }
                            if (!((OrgDataSet.Class414) ((DataRowView) this.bindingSource_0[0]).Row).method_4())
                            {
                                class3.NameShort = ((OrgDataSet.Class414) ((DataRowView) this.bindingSource_0[0]).Row).NameShort;
                            }
                            if (!row.method_8())
                            {
                                class3.method_7(row.method_0());
                            }
                            if ((this.int_0 == 0) && !row.method_22())
                            {
                                class3.IsFullRestriction = row.IsFullRestriction;
                            }
                            this.tblAbnAplForDisconObjectsBindingSource.EndEdit();
                        }
                        else if (!this.checkBox_0.Checked)
                        {
                            using (IEnumerator enumerator2 = this.tblAbnAplForDisconObjectsBindingSource.GetEnumerator())
                            {
                                OrgDataSet.Class411 class4;
                                while (enumerator2.MoveNext())
                                {
                                    class4 = (OrgDataSet.Class411) ((DataRowView) enumerator2.Current).Row;
                                    if (!class4.method_38() && (row.method_2() == class4.method_4()))
                                    {
                                        goto Label_024D;
                                    }
                                }
                                continue;
                            Label_024D:
                                class4.Delete();
                                this.tblAbnAplForDisconObjectsBindingSource.EndEdit();
                                continue;
                            }
                        }
                    }
                }
                if (this.checkBox_0.Checked)
                {
                    ((OrgDataSet.Class411) ((DataRowView) this.tblAbnAplForDisconObjectsBindingSource.Current).Row).NameShort = ((OrgDataSet.Class411) ((DataRowView) this.tblAbnAplForDisconObjectsBindingSource.Current).Row).NoDogAbn;
                    ((OrgDataSet.Class411) ((DataRowView) this.tblAbnAplForDisconObjectsBindingSource.Current).Row).method_7(((OrgDataSet.Class411) ((DataRowView) this.tblAbnAplForDisconObjectsBindingSource.Current).Row).NoDogObj);
                    if (this.comboBox_0.SelectedIndex == -1)
                    {
                        string text = this.comboBox_0.Text;
                        this.bindingSource_2.AddNew();
                        ((OrgDataSet.Class412) ((DataRowView) this.bindingSource_2.Current).Row).Reason = text;
                        ((OrgDataSet.Class412) ((DataRowView) this.bindingSource_2.Current).Row).method_1(this.int_0);
                        this.bindingSource_2.EndEdit();
                        this.class204_0.vmethod_2(this.orgDataSet_0.tblAbnAplForDisconReason);
                        ((OrgDataSet.Class411) ((DataRowView) this.tblAbnAplForDisconObjectsBindingSource.Current).Row).Reason = ((OrgDataSet.Class412) ((DataRowView) this.bindingSource_2.Current).Row).Id;
                    }
                    this.tblAbnAplForDisconObjectsBindingSource.EndEdit();
                }
            }
            else
            {
                this.tblAbnAplForDisconObjectsBindingSource.CancelEdit();
            }
            this.tblAbnAplForDisconObjectsBindingSource.RemoveFilter();
        }

        private void FormAddObjects_Load(object sender, EventArgs e)
        {
            this.class204_0.vmethod_0(this.orgDataSet_0.tblAbnAplForDisconReason, new int?(this.int_0));
            if (this.int_1 != 0)
            {
                this.maskedTextBox_0.Text = this.int_1.ToString();
            }
            using (IEnumerator enumerator = this.tblAbnAplForDisconObjectsBindingSource.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    OrgDataSet.Class411 row = (OrgDataSet.Class411) ((DataRowView) enumerator.Current).Row;
                    using (IEnumerator enumerator2 = this.bindingSource_1.GetEnumerator())
                    {
                        OrgDataSet.Class413 class3;
                        while (enumerator2.MoveNext())
                        {
                            class3 = (OrgDataSet.Class413) ((DataRowView) enumerator2.Current).Row;
                            if (class3.method_2() == row.method_4())
                            {
                                goto Label_00A7;
                            }
                        }
                        continue;
                    Label_00A7:
                        class3.method_7(true);
                        if (!row.method_42())
                        {
                            class3.Reason = row.Reason;
                        }
                        if (!row.method_40())
                        {
                            class3.Point = row.PlaceId;
                        }
                        if (!row.method_44())
                        {
                            class3.Comments = row.Comments;
                        }
                        this.dictionary_0.Add(class3.method_2(), row);
                        continue;
                    }
                }
            }
        }

        private void maskedTextBox_0_TextChanged(object sender, EventArgs e)
        {
            if (this.maskedTextBox_0.Text.Length > 0)
            {
                this.class206_0.vmethod_0(this.orgDataSet_0.tblAbn, new int?(Convert.ToInt32(this.maskedTextBox_0.Text)));
            }
            else
            {
                this.class206_0.vmethod_0(this.orgDataSet_0.tblAbn, 0);
            }
            this.int_1 = -5;
            if (this.bindingSource_0.Count > 0)
            {
                this.int_1 = ((OrgDataSet.Class414) ((DataRowView) this.bindingSource_0[0]).Row).method_0();
            }
            this.class205_0.vmethod_0(this.orgDataSet_0.tblAbnObj, new int?(this.int_1));
            this.tblAbnAplForDisconObjectsBindingSource.Filter = "AbnId=" + this.int_1.ToString();
        }

        private void method_0()
        {
            this.icontainer_0 = new Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(FormAddObjects));
            this.label_0 = new Label();
            this.label_1 = new Label();
            this.bindingSource_0 = new BindingSource(this.icontainer_0);
            this.orgDataSet_0 = new OrgDataSet();
            this.class206_0 = new Class206();
            this.maskedTextBox_0 = new MaskedTextBox();
            this.label_2 = new Label();
            this.dataGridView_0 = new DataGridView();
            this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn_0 = new DataGridViewComboBoxColumn();
            this.contextMenuStrip_0 = new ContextMenuStrip(this.icontainer_0);
            this.toolStripTextBox_0 = new ToolStripTextBox();
            this.toolStripMenuItem_0 = new ToolStripMenuItem();
            this.bindingSource_2 = new BindingSource(this.icontainer_0);
            this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn_1 = new DataGridViewCheckBoxColumn();
            this.bindingSource_1 = new BindingSource(this.icontainer_0);
            this.class205_0 = new Class205();
            this.button_0 = new Button();
            this.button_1 = new Button();
            this.class204_0 = new Class204();
            this.tblAbnAplForDisconObjectsBindingSource = new BindingSource(this.icontainer_0);
            this.checkBox_0 = new CheckBox();
            this.panel_0 = new Panel();
            this.checkBox_1 = new CheckBox();
            this.comboBox_0 = new ComboBox();
            this.textBox_3 = new TextBox();
            this.textBox_0 = new TextBox();
            this.textBox_1 = new TextBox();
            this.textBox_2 = new TextBox();
            this.label_8 = new Label();
            this.label_7 = new Label();
            this.label_3 = new Label();
            this.label_4 = new Label();
            this.label_5 = new Label();
            this.label_6 = new Label();
            ((ISupportInitialize) this.bindingSource_0).BeginInit();
            this.orgDataSet_0.BeginInit();
            ((ISupportInitialize) this.dataGridView_0).BeginInit();
            this.contextMenuStrip_0.SuspendLayout();
            ((ISupportInitialize) this.bindingSource_2).BeginInit();
            ((ISupportInitialize) this.bindingSource_1).BeginInit();
            ((ISupportInitialize) this.tblAbnAplForDisconObjectsBindingSource).BeginInit();
            this.panel_0.SuspendLayout();
            base.SuspendLayout();
            this.label_0.AutoSize = true;
            this.label_0.Location = new Point(12, 9);
            this.label_0.Name = "label1";
            this.label_0.Size = new Size(0x4c, 13);
            this.label_0.TabIndex = 0;
            this.label_0.Text = "Код абонента";
            this.label_1.AutoSize = true;
            this.label_1.DataBindings.Add(new Binding("Text", this.bindingSource_0, "NameShort", true));
            this.label_1.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.label_1.Location = new Point(12, 0x3e);
            this.label_1.Name = "label2";
            this.label_1.Size = new Size(0, 0x18);
            this.label_1.TabIndex = 0;
            this.bindingSource_0.DataMember = "tblAbn";
            this.bindingSource_0.DataSource = this.orgDataSet_0;
            this.orgDataSet_0.DataSetName = "OrgDataSet";
            this.orgDataSet_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.class206_0.method_7(true);
            this.maskedTextBox_0.Location = new Point(0x9b, 6);
            this.maskedTextBox_0.Mask = "9999999999";
            this.maskedTextBox_0.Name = "maskedTextBoxCode";
            this.maskedTextBox_0.Size = new Size(210, 20);
            this.maskedTextBox_0.TabIndex = 2;
            this.maskedTextBox_0.TextChanged += new EventHandler(this.maskedTextBox_0_TextChanged);
            this.label_2.AutoSize = true;
            this.label_2.Location = new Point(12, 0x22);
            this.label_2.Name = "label3";
            this.label_2.Size = new Size(0x34, 13);
            this.label_2.TabIndex = 0;
            this.label_2.Text = "Абонент:";
            this.dataGridView_0.AllowUserToAddRows = false;
            this.dataGridView_0.AllowUserToDeleteRows = false;
            this.dataGridView_0.AutoGenerateColumns = false;
            this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewCheckBoxColumn_0, this.dataGridViewTextBoxColumn_0, this.dataGridViewTextBoxColumn_1, this.dataGridViewComboBoxColumn_0, this.dataGridViewTextBoxColumn_2, this.dataGridViewCheckBoxColumn_1 };
            this.dataGridView_0.Columns.AddRange(dataGridViewColumns);
            this.dataGridView_0.DataSource = this.bindingSource_1;
            this.dataGridView_0.Location = new Point(12, 0x71);
            this.dataGridView_0.Name = "dataGridView1";
            this.dataGridView_0.RowHeadersWidth = 20;
            this.dataGridView_0.Size = new Size(0x1ff, 0xe1);
            this.dataGridView_0.TabIndex = 3;
            this.dataGridViewCheckBoxColumn_0.DataPropertyName = "Label";
            this.dataGridViewCheckBoxColumn_0.HeaderText = "";
            this.dataGridViewCheckBoxColumn_0.Name = "labelDataGridViewCheckBoxColumn";
            this.dataGridViewCheckBoxColumn_0.Width = 20;
            this.dataGridViewTextBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_0.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn_0.HeaderText = "Наименование объекта";
            this.dataGridViewTextBoxColumn_0.Name = "pointDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewTextBoxColumn_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_1.DataPropertyName = "Point";
            this.dataGridViewTextBoxColumn_1.FillWeight = 75f;
            this.dataGridViewTextBoxColumn_1.HeaderText = "Пункт ввода ограничения";
            this.dataGridViewTextBoxColumn_1.Name = "titleDataGridViewTextBoxColumn";
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
            this.dataGridViewTextBoxColumn_2.DataPropertyName = "Comments";
            this.dataGridViewTextBoxColumn_2.HeaderText = "Примечание";
            this.dataGridViewTextBoxColumn_2.Name = "Comments";
            this.dataGridViewCheckBoxColumn_1.DataPropertyName = "IsFullRestriction";
            this.dataGridViewCheckBoxColumn_1.HeaderText = "Полное отключение";
            this.dataGridViewCheckBoxColumn_1.Name = "IsFullRestriction";
            this.dataGridViewCheckBoxColumn_1.Width = 70;
            this.bindingSource_1.DataMember = "tblAbnObj";
            this.bindingSource_1.DataSource = this.orgDataSet_0;
            this.class205_0.method_7(true);
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
            this.tblAbnAplForDisconObjectsBindingSource.DataMember = "tblAbnAplForDisconObjects";
            this.tblAbnAplForDisconObjectsBindingSource.DataSource = this.orgDataSet_0;
            this.checkBox_0.AutoSize = true;
            this.checkBox_0.Location = new Point(0x185, 8);
            this.checkBox_0.Name = "checkBox1";
            this.checkBox_0.Size = new Size(0x5e, 0x11);
            this.checkBox_0.TabIndex = 5;
            this.checkBox_0.Text = "без договора";
            this.checkBox_0.UseVisualStyleBackColor = true;
            this.checkBox_0.CheckedChanged += new EventHandler(this.checkBox_0_CheckedChanged);
            this.panel_0.Controls.Add(this.checkBox_1);
            this.panel_0.Controls.Add(this.comboBox_0);
            this.panel_0.Controls.Add(this.textBox_3);
            this.panel_0.Controls.Add(this.textBox_0);
            this.panel_0.Controls.Add(this.textBox_1);
            this.panel_0.Controls.Add(this.textBox_2);
            this.panel_0.Controls.Add(this.label_8);
            this.panel_0.Controls.Add(this.label_7);
            this.panel_0.Controls.Add(this.label_3);
            this.panel_0.Controls.Add(this.label_4);
            this.panel_0.Controls.Add(this.label_5);
            this.panel_0.Controls.Add(this.label_6);
            this.panel_0.Location = new Point(0, 0x21);
            this.panel_0.Name = "panelNoDog";
            this.panel_0.Size = new Size(0x215, 0x132);
            this.panel_0.TabIndex = 6;
            this.panel_0.Visible = false;
            this.checkBox_1.AutoSize = true;
            this.checkBox_1.DataBindings.Add(new Binding("Checked", this.tblAbnAplForDisconObjectsBindingSource, "IsFullRestriction", true));
            this.checkBox_1.Location = new Point(0x9a, 0x9e);
            this.checkBox_1.Name = "checkBox2";
            this.checkBox_1.Size = new Size(15, 14);
            this.checkBox_1.TabIndex = 7;
            this.checkBox_1.UseVisualStyleBackColor = true;
            this.comboBox_0.DataBindings.Add(new Binding("SelectedValue", this.tblAbnAplForDisconObjectsBindingSource, "Reason", true));
            this.comboBox_0.DataSource = this.bindingSource_2;
            this.comboBox_0.DisplayMember = "Reason";
            this.comboBox_0.FormattingEnabled = true;
            this.comboBox_0.Location = new Point(0x99, 0x83);
            this.comboBox_0.Name = "comboBox1";
            this.comboBox_0.Size = new Size(0x170, 0x15);
            this.comboBox_0.TabIndex = 2;
            this.comboBox_0.ValueMember = "Id";
            this.textBox_3.DataBindings.Add(new Binding("Text", this.tblAbnAplForDisconObjectsBindingSource, "Comments", true));
            this.textBox_3.Location = new Point(0x9a, 0xb2);
            this.textBox_3.Multiline = true;
            this.textBox_3.Name = "textBox4";
            this.textBox_3.Size = new Size(0x16f, 0x71);
            this.textBox_3.TabIndex = 1;
            this.textBox_0.DataBindings.Add(new Binding("Text", this.tblAbnAplForDisconObjectsBindingSource, "PlaceId", true));
            this.textBox_0.Location = new Point(0x9a, 0x58);
            this.textBox_0.Name = "textBox3";
            this.textBox_0.Size = new Size(0x16f, 20);
            this.textBox_0.TabIndex = 1;
            this.textBox_1.DataBindings.Add(new Binding("Text", this.tblAbnAplForDisconObjectsBindingSource, "NoDogObj", true));
            this.textBox_1.Location = new Point(0x9a, 0x30);
            this.textBox_1.Name = "textBox2";
            this.textBox_1.Size = new Size(0x16f, 20);
            this.textBox_1.TabIndex = 1;
            this.textBox_2.DataBindings.Add(new Binding("Text", this.tblAbnAplForDisconObjectsBindingSource, "NoDogAbn", true));
            this.textBox_2.Location = new Point(0x9a, 8);
            this.textBox_2.Name = "textBox1";
            this.textBox_2.Size = new Size(0x16f, 20);
            this.textBox_2.TabIndex = 1;
            this.label_8.AutoSize = true;
            this.label_8.Location = new Point(12, 0x9e);
            this.label_8.Name = "label9";
            this.label_8.Size = new Size(0x73, 13);
            this.label_8.TabIndex = 0;
            this.label_8.Text = "Полное ограничение:";
            this.label_7.AutoSize = true;
            this.label_7.Location = new Point(12, 0xb5);
            this.label_7.Name = "label8";
            this.label_7.Size = new Size(0x49, 13);
            this.label_7.TabIndex = 0;
            this.label_7.Text = "Примечание:";
            this.label_3.AutoSize = true;
            this.label_3.Location = new Point(12, 0x86);
            this.label_3.Name = "label7";
            this.label_3.Size = new Size(0x35, 13);
            this.label_3.TabIndex = 0;
            this.label_3.Text = "Причина:";
            this.label_4.AutoSize = true;
            this.label_4.Location = new Point(11, 0x5b);
            this.label_4.Name = "label6";
            this.label_4.Size = new Size(140, 13);
            this.label_4.TabIndex = 0;
            this.label_4.Text = "Пункт ввода ограничения:";
            this.label_5.AutoSize = true;
            this.label_5.Location = new Point(11, 0x33);
            this.label_5.Name = "label5";
            this.label_5.Size = new Size(0x30, 13);
            this.label_5.TabIndex = 0;
            this.label_5.Text = "Объект:";
            this.label_6.AutoSize = true;
            this.label_6.Location = new Point(11, 15);
            this.label_6.Name = "label4";
            this.label_6.Size = new Size(0x34, 13);
            this.label_6.TabIndex = 0;
            this.label_6.Text = "Абонент:";
            base.AcceptButton = this.button_0;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x217, 0x183);
            base.Controls.Add(this.panel_0);
            base.Controls.Add(this.checkBox_0);
            base.Controls.Add(this.button_1);
            base.Controls.Add(this.button_0);
            base.Controls.Add(this.dataGridView_0);
            base.Controls.Add(this.maskedTextBox_0);
            base.Controls.Add(this.label_1);
            base.Controls.Add(this.label_2);
            base.Controls.Add(this.label_0);
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Name = "FormAddObjects";
            this.Text = "Форма добавления объекта";
            base.FormClosing += new FormClosingEventHandler(this.FormAddObjects_FormClosing);
            base.Load += new EventHandler(this.FormAddObjects_Load);
            ((ISupportInitialize) this.bindingSource_0).EndInit();
            this.orgDataSet_0.EndInit();
            ((ISupportInitialize) this.dataGridView_0).EndInit();
            this.contextMenuStrip_0.ResumeLayout(false);
            this.contextMenuStrip_0.PerformLayout();
            ((ISupportInitialize) this.bindingSource_2).EndInit();
            ((ISupportInitialize) this.bindingSource_1).EndInit();
            ((ISupportInitialize) this.tblAbnAplForDisconObjectsBindingSource).EndInit();
            this.panel_0.ResumeLayout(false);
            this.panel_0.PerformLayout();
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

        public override SQLSettings SqlSettings
        {
            get
            {
                return base.get_SqlSettings();
            }
            set
            {
                base.set_SqlSettings(value);
                this.class204_0.method_1().ConnectionString = this.get_SqlSettings().GetConnectionString();
                this.class205_0.method_1().ConnectionString = this.get_SqlSettings().GetConnectionString();
                this.class206_0.method_1().ConnectionString = this.get_SqlSettings().GetConnectionString();
            }
        }
    }
}

