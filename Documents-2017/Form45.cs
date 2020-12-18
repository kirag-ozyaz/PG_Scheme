using Documents.DataSets;
using FormLbr;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

internal class Form45 : FormBase
{
    private BindingSource bindingSource_0;
    private Button button_0;
    private Button button_1;
    private CheckBox checkBox_0;
    private CheckBox checkBox_1;
    private CheckBox checkBox_2;
    private ComboBox comboBox_0;
    private ComboBox comboBox_1;
    private ComboBox comboBox_2;
    private ComboBox comboBox_3;
    private ComboBox comboBox_4;
    private ComboBox comboBox_5;
    private ComboBox comboBox_6;
    private ComboBox comboBox_7;
    private ComboBox comboBox_8;
    private DataSetGES dataSetGES_0;
    private DataTable dataTable_0;
    private DataTable dataTable_1;
    private DataTable dataTable_2;
    private DateTimePicker dateTimePicker_0;
    private GroupBox groupBox_0;
    private GroupBox groupBox_1;
    private GroupBox groupBox_2;
    private GroupBox groupBox_3;
    private GroupBox groupBox_4;
    private GroupBox groupBox_5;
    private GroupBox groupBox_6;
    private GroupBox groupBox_7;
    private IContainer icontainer_0;
    private int int_0;
    private int int_1;
    private int int_2;
    private int int_3;
    private int int_4;
    private int int_5;
    private Label label_0;
    private Label label_1;
    private Label label_10;
    private Label label_11;
    private Label label_12;
    private Label label_13;
    private Label label_14;
    private Label label_15;
    private Label label_16;
    private Label label_17;
    private Label label_18;
    private Label label_19;
    private Label label_2;
    private Label label_20;
    private Label label_3;
    private Label label_4;
    private Label label_5;
    private Label label_6;
    private Label label_7;
    private Label label_8;
    private Label label_9;
    private RichTextBox richTextBox_0;
    private TextBox textBox_0;
    private TextBox textBox_1;
    private TextBox textBox_10;
    private TextBox textBox_11;
    private TextBox textBox_12;
    private TextBox textBox_2;
    private TextBox textBox_3;
    private TextBox textBox_4;
    private TextBox textBox_5;
    private TextBox textBox_6;
    private TextBox textBox_7;
    private TextBox textBox_8;
    private TextBox textBox_9;

    internal Form45()
    {
        this.int_0 = -1;
        this.int_1 = -1;
        this.int_2 = -1;
        this.int_3 = -1;
        this.int_4 = -1;
        this.int_5 = -1;
        this.method_3();
    }

    internal Form45(int int_6, int int_7, int int_8, int int_9, int int_10, int int_11)
    {
        this.int_0 = -1;
        this.int_1 = -1;
        this.int_2 = -1;
        this.int_3 = -1;
        this.int_4 = -1;
        this.int_5 = -1;
        this.method_3();
        this.method_0(int_6, int_7, int_8, int_9, int_10, int_11);
    }

    internal Form45(int int_6, int int_7, int int_8, int int_9, int int_10, int int_11, bool bool_0)
    {
        this.int_0 = -1;
        this.int_1 = -1;
        this.int_2 = -1;
        this.int_3 = -1;
        this.int_4 = -1;
        this.int_5 = -1;
        this.method_3();
        this.method_0(int_6, int_7, int_8, int_9, int_10, int_11);
        if (bool_0)
        {
            this.dateTimePicker_0.Enabled = false;
            this.textBox_1.ReadOnly = true;
            this.textBox_0.ReadOnly = true;
            this.comboBox_4.Enabled = false;
            this.textBox_4.ReadOnly = true;
            this.textBox_3.ReadOnly = true;
            this.textBox_2.ReadOnly = true;
            this.textBox_6.ReadOnly = true;
            this.textBox_5.ReadOnly = true;
            this.textBox_8.ReadOnly = true;
            this.textBox_7.ReadOnly = true;
            this.textBox_10.ReadOnly = true;
            this.textBox_9.ReadOnly = true;
            this.comboBox_6.Enabled = false;
            this.comboBox_5.Enabled = false;
            this.textBox_12.ReadOnly = true;
            this.textBox_11.ReadOnly = true;
            this.richTextBox_0.ReadOnly = true;
            this.comboBox_7.Enabled = false;
            this.checkBox_0.Enabled = false;
            this.checkBox_1.Enabled = false;
            this.checkBox_2.Enabled = false;
        }
    }

    private void button_0_Click(object sender, EventArgs e)
    {
        base.DialogResult = DialogResult.OK;
        base.Close();
    }

    private void button_1_Click(object sender, EventArgs e)
    {
        base.DialogResult = DialogResult.Cancel;
        base.Close();
    }

    private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (this.comboBox_0.SelectedIndex < 0)
        {
            this.dataTable_0.Clear();
        }
        else
        {
            base.SelectSqlData(this.dataTable_0, true, " where typeCodeId = " + this.comboBox_0.SelectedValue.ToString() + " and deleted = 0 order by name", false);
            this.comboBox_1.SelectedIndex = -1;
        }
    }

    private void comboBox_1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (this.comboBox_1.SelectedIndex < 0)
        {
            this.dataTable_1.Clear();
        }
        else
        {
            DataSetOrder order = new DataSetOrder();
            base.SelectSqlData(order, order.tR_Classifier, true, " where ParentKey in (';SCM;BUS;BUSHV;', ';SCM;BUS;BUSMV;') and deleted = 0 and isgroup = 0 ");
            string str = "";
            foreach (DataRow row in order.tR_Classifier.Rows)
            {
                str = str + row["id"].ToString() + ",";
            }
            str = str.Remove(str.Length - 1);
            base.SelectSqlData(this.dataTable_1, true, " where idParent = " + this.comboBox_1.SelectedValue.ToString() + " and typecodeId in (" + str + ") and deleted = 0 order by name", false);
            this.comboBox_2.SelectedIndex = -1;
        }
    }

    private void comboBox_2_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (this.comboBox_2.SelectedIndex < 0)
        {
            this.dataTable_2.Clear();
        }
        else
        {
            base.SelectSqlData(this.dataTable_2, true, " where ParentLink = " + this.comboBox_2.SelectedValue.ToString() + " order by name", false);
            this.comboBox_3.SelectedIndex = -1;
        }
    }

    private void comboBox_5_TextUpdate(object sender, EventArgs e)
    {
        this.dataSetGES_0.tJ_RelayProtectionAutomationValue.Rows[0]["type_proc"] = this.comboBox_5.Text;
    }

    private void comboBox_6_TextUpdate(object sender, EventArgs e)
    {
        this.dataSetGES_0.tJ_RelayProtectionAutomationValue.Rows[0]["type_relay"] = this.comboBox_6.Text;
    }

    private void comboBox_7_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Delete)
        {
            this.comboBox_7.SelectedIndex = -1;
        }
    }

    private void comboBox_8_KeyDown(object sender, KeyEventArgs e)
    {
        if ((e.KeyCode == Keys.Delete) || (e.KeyCode == Keys.Back))
        {
            this.comboBox_8.SelectedIndex = -1;
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

    private void Form45_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (base.DialogResult == DialogResult.OK)
        {
            if (this.comboBox_3.SelectedValue == null)
            {
                MessageBox.Show("Выберите ячейку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                e.Cancel = true;
            }
            else
            {
                this.dataSetGES_0.tJ_RelayProtectionAutomation.Rows[0].EndEdit();
                if (this.int_4 < 0)
                {
                    try
                    {
                        this.int_4 = base.InsertSqlDataOneRow(this.dataSetGES_0, this.dataSetGES_0.tJ_RelayProtectionAutomation);
                        if (this.int_4 > 0)
                        {
                            this.dataSetGES_0.tJ_RelayProtectionAutomationValue.Rows[0]["idRelay"] = this.int_4;
                            this.dataSetGES_0.tJ_RelayProtectionAutomationValue.Rows[0].EndEdit();
                            base.InsertSqlDataOneRow(this.dataSetGES_0, this.dataSetGES_0.tJ_RelayProtectionAutomationValue);
                        }
                        else
                        {
                            e.Cancel = true;
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, exception.Source);
                    }
                }
                else
                {
                    this.dataSetGES_0.tJ_RelayProtectionAutomation.Rows[0].EndEdit();
                    base.UpdateSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_RelayProtectionAutomation);
                    if (this.int_5 < 0)
                    {
                        this.dataSetGES_0.tJ_RelayProtectionAutomationValue.Rows[0].EndEdit();
                        base.InsertSqlDataOneRow(this.dataSetGES_0, this.dataSetGES_0.tJ_RelayProtectionAutomationValue);
                    }
                    else
                    {
                        this.dataSetGES_0.tJ_RelayProtectionAutomationValue.Rows[0].EndEdit();
                        base.UpdateSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_RelayProtectionAutomationValue);
                    }
                }
            }
        }
    }

    private void Form45_Load(object sender, EventArgs e)
    {
        this.dataTable_0 = this.method_1();
        this.dataTable_1 = this.method_1();
        this.dataTable_2 = new DataTable("vSChm_treeCellLine");
        DataColumn column = new DataColumn("id", Type.GetType("System.Int32"));
        this.dataTable_2.Columns.Add(column);
        DataColumn column2 = new DataColumn("Name", Type.GetType("System.String"));
        this.dataTable_2.Columns.Add(column2);
        this.method_2();
        this.comboBox_0.SelectedValue = this.int_0;
        this.comboBox_1.SelectedValue = this.int_1;
        this.comboBox_2.SelectedValue = this.int_2;
        this.comboBox_3.SelectedValue = this.int_3;
        if (this.int_4 < 0)
        {
            DataRow row = this.dataSetGES_0.tJ_RelayProtectionAutomation.NewRow();
            if (this.comboBox_3.SelectedIndex >= 0)
            {
                row["IdSchmObj"] = this.comboBox_3.SelectedValue;
            }
            else
            {
                row["IdSchmObj"] = -1;
            }
            row["deleted"] = false;
            this.dataSetGES_0.tJ_RelayProtectionAutomation.Rows.Add(row);
            row = this.dataSetGES_0.tJ_RelayProtectionAutomationValue.NewRow();
            row["IdRelay"] = -1;
            row["DateIn"] = DateTime.Now.Date;
            row["Datecreate"] = DateTime.Now;
            row["deleted"] = false;
            this.dataSetGES_0.tJ_RelayProtectionAutomationValue.Rows.Add(row);
        }
        else
        {
            this.comboBox_1.Enabled = false;
            this.comboBox_2.Enabled = false;
            this.comboBox_0.Enabled = false;
            this.comboBox_3.Enabled = false;
            base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_RelayProtectionAutomation, true, "where id = " + this.int_4.ToString());
            if (this.int_5 < 0)
            {
                base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_RelayProtectionAutomationValue, true, " where idRelay = " + this.int_4.ToString() + " order by dateIn desc");
                if (this.dataSetGES_0.tJ_RelayProtectionAutomationValue.Rows.Count > 0)
                {
                    this.dateTimePicker_0.MinDate = Convert.ToDateTime(this.dataSetGES_0.tJ_RelayProtectionAutomationValue.Rows[0]["DateIn"]).AddDays(1.0);
                    this.dataSetGES_0.tJ_RelayProtectionAutomationValue.Clear();
                }
                DataRow row2 = this.dataSetGES_0.tJ_RelayProtectionAutomationValue.NewRow();
                row2["IdRelay"] = this.int_4;
                if (this.dateTimePicker_0.MinDate > DateTime.Now.Date)
                {
                    row2["DateIn"] = this.dateTimePicker_0.MinDate;
                }
                else
                {
                    row2["DateIn"] = DateTime.Now.Date;
                }
                row2["Datecreate"] = DateTime.Now;
                row2["deleted"] = false;
                this.dataSetGES_0.tJ_RelayProtectionAutomationValue.Rows.Add(row2);
            }
            else
            {
                base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_RelayProtectionAutomationValue, true, " where id = " + this.int_5.ToString());
            }
        }
    }

    private void method_0(int int_6, int int_7, int int_8, int int_9, int int_10, int int_11)
    {
        this.int_0 = int_6;
        this.int_1 = int_7;
        this.int_2 = int_8;
        this.int_3 = int_9;
        this.int_4 = int_10;
        this.int_5 = int_11;
        this.dateTimePicker_0.Value = DateTime.Now.Date;
        if (this.int_4 == -1)
        {
            this.Text = "Новая уставка";
        }
        else if (this.int_5 < 0)
        {
            this.Text = "Новые значения";
        }
        else
        {
            this.Text = "Редактирование";
        }
    }

    private DataTable method_1()
    {
        Type dataType = Type.GetType("System.Int32");
        DataTable table = new DataTable("tSchm_ObjList");
        DataColumn column = new DataColumn("id", dataType);
        table.Columns.Add(column);
        DataColumn column2 = new DataColumn("Name", Type.GetType("System.String"));
        table.Columns.Add(column2);
        table.PrimaryKey = new DataColumn[] { column };
        return table;
    }

    private void method_2()
    {
        DataSetGES tges = new DataSetGES();
        base.SelectSqlData(tges, tges.tR_Classifier, true, " where ParentKey = ';SCM;PS;' and isgroup = 0 and deleted = 0 order by name");
        this.comboBox_0.DisplayMember = "Name";
        this.comboBox_0.ValueMember = "id";
        this.comboBox_0.DataSource = tges.tR_Classifier;
        this.comboBox_1.DisplayMember = "Name";
        this.comboBox_1.ValueMember = "Id";
        this.comboBox_1.DataSource = this.dataTable_0;
        this.comboBox_2.DisplayMember = "Name";
        this.comboBox_2.ValueMember = "Id";
        this.comboBox_2.DataSource = this.dataTable_1;
        this.comboBox_3.DisplayMember = "Name";
        this.comboBox_3.ValueMember = "Id";
        this.comboBox_3.DataSource = this.dataTable_2;
        DataSetGES tges2 = new DataSetGES();
        base.SelectSqlData(tges2, tges2.tR_Classifier, true, " where ParentKey = ';TypeTransformatorAmperage;' and isgroup = 0 and deleted = 0 order by name");
        this.comboBox_4.DisplayMember = "Name";
        this.comboBox_4.ValueMember = "id";
        this.comboBox_4.DataSource = tges2.tR_Classifier;
        DataTable table = new DataTable("tJ_RelayProtectionAutomationValue");
        DataColumn column = new DataColumn("type_relay");
        table.Columns.Add(column);
        base.SelectSqlData(table, true, " group by type_relay order by type_relay", false);
        foreach (DataRow row in table.Rows)
        {
            this.comboBox_6.Items.Add(row["type_relay"].ToString());
        }
        table = new DataTable("tJ_RelayProtectionAutomationValue");
        DataColumn column2 = new DataColumn("type_proc");
        table.Columns.Add(column2);
        base.SelectSqlData(table, true, " group by type_proc order by type_proc", false);
        foreach (DataRow row2 in table.Rows)
        {
            this.comboBox_5.Items.Add(row2["type_proc"].ToString());
        }
    }

    private void method_3()
    {
        this.icontainer_0 = new Container();
        this.dataSetGES_0 = new DataSetGES();
        this.label_0 = new Label();
        this.dateTimePicker_0 = new DateTimePicker();
        this.label_1 = new Label();
        this.comboBox_0 = new ComboBox();
        this.label_2 = new Label();
        this.comboBox_1 = new ComboBox();
        this.label_3 = new Label();
        this.comboBox_2 = new ComboBox();
        this.label_4 = new Label();
        this.comboBox_3 = new ComboBox();
        this.button_0 = new Button();
        this.button_1 = new Button();
        this.groupBox_0 = new GroupBox();
        this.comboBox_4 = new ComboBox();
        this.label_5 = new Label();
        this.textBox_0 = new TextBox();
        this.textBox_1 = new TextBox();
        this.label_6 = new Label();
        this.label_7 = new Label();
        this.groupBox_1 = new GroupBox();
        this.textBox_2 = new TextBox();
        this.label_9 = new Label();
        this.textBox_3 = new TextBox();
        this.label_10 = new Label();
        this.textBox_4 = new TextBox();
        this.label_8 = new Label();
        this.groupBox_2 = new GroupBox();
        this.comboBox_7 = new ComboBox();
        this.label_20 = new Label();
        this.textBox_5 = new TextBox();
        this.label_11 = new Label();
        this.textBox_6 = new TextBox();
        this.label_12 = new Label();
        this.groupBox_3 = new GroupBox();
        this.textBox_7 = new TextBox();
        this.label_13 = new Label();
        this.textBox_8 = new TextBox();
        this.label_14 = new Label();
        this.groupBox_4 = new GroupBox();
        this.textBox_9 = new TextBox();
        this.label_15 = new Label();
        this.textBox_10 = new TextBox();
        this.label_16 = new Label();
        this.groupBox_5 = new GroupBox();
        this.comboBox_5 = new ComboBox();
        this.comboBox_6 = new ComboBox();
        this.groupBox_6 = new GroupBox();
        this.textBox_11 = new TextBox();
        this.label_17 = new Label();
        this.textBox_12 = new TextBox();
        this.label_18 = new Label();
        this.label_19 = new Label();
        this.richTextBox_0 = new RichTextBox();
        this.groupBox_7 = new GroupBox();
        this.comboBox_8 = new ComboBox();
        this.bindingSource_0 = new BindingSource(this.icontainer_0);
        this.checkBox_0 = new CheckBox();
        this.checkBox_1 = new CheckBox();
        this.checkBox_2 = new CheckBox();
        this.dataSetGES_0.BeginInit();
        this.groupBox_0.SuspendLayout();
        this.groupBox_1.SuspendLayout();
        this.groupBox_2.SuspendLayout();
        this.groupBox_3.SuspendLayout();
        this.groupBox_4.SuspendLayout();
        this.groupBox_5.SuspendLayout();
        this.groupBox_6.SuspendLayout();
        this.groupBox_7.SuspendLayout();
        ((ISupportInitialize) this.bindingSource_0).BeginInit();
        base.SuspendLayout();
        this.dataSetGES_0.DataSetName = "DataSetGES";
        this.dataSetGES_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        this.label_0.AutoSize = true;
        this.label_0.Location = new Point(12, 0x12);
        this.label_0.Name = "label1";
        this.label_0.Size = new Size(0x21, 13);
        this.label_0.TabIndex = 0;
        this.label_0.Text = "Дата";
        this.dateTimePicker_0.DataBindings.Add(new Binding("Value", this.dataSetGES_0, "tJ_RelayProtectionAutomationValue.dateIn", true));
        this.dateTimePicker_0.Location = new Point(0x33, 12);
        this.dateTimePicker_0.Name = "dateTimePickerIn";
        this.dateTimePicker_0.Size = new Size(0x9e, 20);
        this.dateTimePicker_0.TabIndex = 1;
        this.label_1.AutoSize = true;
        this.label_1.Location = new Point(6, 0x15);
        this.label_1.Name = "label2";
        this.label_1.Size = new Size(0x58, 13);
        this.label_1.TabIndex = 2;
        this.label_1.Text = "Тип подстанции";
        this.comboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        this.comboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
        this.comboBox_0.FormattingEnabled = true;
        this.comboBox_0.Location = new Point(100, 0x12);
        this.comboBox_0.Name = "cmbTypeSub";
        this.comboBox_0.Size = new Size(0x67, 0x15);
        this.comboBox_0.TabIndex = 3;
        this.comboBox_0.SelectedIndexChanged += new EventHandler(this.comboBox_0_SelectedIndexChanged);
        this.label_2.AutoSize = true;
        this.label_2.Location = new Point(0xd1, 0x15);
        this.label_2.Name = "label3";
        this.label_2.Size = new Size(0x44, 13);
        this.label_2.TabIndex = 4;
        this.label_2.Text = "Подстанция";
        this.comboBox_1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        this.comboBox_1.AutoCompleteSource = AutoCompleteSource.ListItems;
        this.comboBox_1.FormattingEnabled = true;
        this.comboBox_1.Location = new Point(0x11b, 0x12);
        this.comboBox_1.Name = "cmbSub";
        this.comboBox_1.Size = new Size(0x7b, 0x15);
        this.comboBox_1.TabIndex = 5;
        this.comboBox_1.SelectedIndexChanged += new EventHandler(this.comboBox_1_SelectedIndexChanged);
        this.label_3.AutoSize = true;
        this.label_3.Location = new Point(7, 0x33);
        this.label_3.Name = "label4";
        this.label_3.Size = new Size(0x22, 13);
        this.label_3.TabIndex = 6;
        this.label_3.Text = "Шина";
        this.comboBox_2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        this.comboBox_2.AutoCompleteSource = AutoCompleteSource.ListItems;
        this.comboBox_2.FormattingEnabled = true;
        this.comboBox_2.Location = new Point(0x2e, 0x30);
        this.comboBox_2.Name = "cmbBus";
        this.comboBox_2.Size = new Size(0x30, 0x15);
        this.comboBox_2.TabIndex = 7;
        this.comboBox_2.SelectedIndexChanged += new EventHandler(this.comboBox_2_SelectedIndexChanged);
        this.label_4.AutoSize = true;
        this.label_4.Location = new Point(0x66, 0x33);
        this.label_4.Name = "label5";
        this.label_4.Size = new Size(0x2c, 13);
        this.label_4.TabIndex = 8;
        this.label_4.Text = "Ячейка";
        this.comboBox_3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        this.comboBox_3.AutoCompleteSource = AutoCompleteSource.ListItems;
        this.comboBox_3.DataBindings.Add(new Binding("SelectedValue", this.dataSetGES_0, "tJ_RelayProtectionAutomation.idSchmObj", true));
        this.comboBox_3.FormattingEnabled = true;
        this.comboBox_3.Location = new Point(150, 0x30);
        this.comboBox_3.Name = "cmbCell";
        this.comboBox_3.Size = new Size(0x35, 0x15);
        this.comboBox_3.TabIndex = 9;
        this.button_0.DialogResult = DialogResult.OK;
        this.button_0.Location = new Point(4, 0x228);
        this.button_0.Name = "buttonOK";
        this.button_0.Size = new Size(0x4b, 0x17);
        this.button_0.TabIndex = 10;
        this.button_0.Text = "ОК";
        this.button_0.UseVisualStyleBackColor = true;
        this.button_0.Click += new EventHandler(this.button_0_Click);
        this.button_1.DialogResult = DialogResult.Cancel;
        this.button_1.Location = new Point(0x158, 0x228);
        this.button_1.Name = "buttonCancel";
        this.button_1.Size = new Size(0x4b, 0x17);
        this.button_1.TabIndex = 11;
        this.button_1.Text = "Отмена";
        this.button_1.UseVisualStyleBackColor = true;
        this.button_1.Click += new EventHandler(this.button_1_Click);
        this.groupBox_0.Controls.Add(this.comboBox_4);
        this.groupBox_0.Controls.Add(this.label_5);
        this.groupBox_0.Controls.Add(this.textBox_0);
        this.groupBox_0.Controls.Add(this.textBox_1);
        this.groupBox_0.Controls.Add(this.label_6);
        this.groupBox_0.Controls.Add(this.label_7);
        this.groupBox_0.Location = new Point(4, 0x7b);
        this.groupBox_0.Name = "groupBoxTransformator";
        this.groupBox_0.Size = new Size(0x19f, 0x37);
        this.groupBox_0.TabIndex = 13;
        this.groupBox_0.TabStop = false;
        this.groupBox_0.Text = "Трансформатор";
        this.comboBox_4.DataBindings.Add(new Binding("SelectedValue", this.dataSetGES_0, "tJ_RelayProtectionAutomationValue.idTypeTr", true));
        this.comboBox_4.FormattingEnabled = true;
        this.comboBox_4.Location = new Point(0xe4, 0x18);
        this.comboBox_4.Name = "cmbTypeTr";
        this.comboBox_4.Size = new Size(0xb2, 0x15);
        this.comboBox_4.TabIndex = 5;
        this.label_5.AutoSize = true;
        this.label_5.Location = new Point(0xc4, 0x1b);
        this.label_5.Name = "label8";
        this.label_5.Size = new Size(0x1a, 13);
        this.label_5.TabIndex = 4;
        this.label_5.Text = "Тип";
        this.textBox_0.DataBindings.Add(new Binding("Text", this.dataSetGES_0, "tJ_RelayProtectionAutomationValue.amp_secondary", true, DataSourceUpdateMode.OnPropertyChanged, ""));
        this.textBox_0.Location = new Point(0x80, 0x18);
        this.textBox_0.Name = "txtT2";
        this.textBox_0.Size = new Size(0x3e, 20);
        this.textBox_0.TabIndex = 3;
        this.textBox_1.DataBindings.Add(new Binding("Text", this.dataSetGES_0, "tJ_RelayProtectionAutomationValue.amp_primary", true, DataSourceUpdateMode.OnPropertyChanged, ""));
        this.textBox_1.Location = new Point(0x22, 0x18);
        this.textBox_1.Name = "txtT1";
        this.textBox_1.Size = new Size(0x3e, 20);
        this.textBox_1.TabIndex = 2;
        this.label_6.AutoSize = true;
        this.label_6.Location = new Point(0x66, 0x1b);
        this.label_6.Name = "label7";
        this.label_6.Size = new Size(20, 13);
        this.label_6.TabIndex = 1;
        this.label_6.Text = "Т2";
        this.label_7.AutoSize = true;
        this.label_7.Location = new Point(8, 0x1b);
        this.label_7.Name = "label6";
        this.label_7.Size = new Size(20, 13);
        this.label_7.TabIndex = 0;
        this.label_7.Text = "Т1";
        this.groupBox_1.Controls.Add(this.textBox_2);
        this.groupBox_1.Controls.Add(this.label_9);
        this.groupBox_1.Controls.Add(this.textBox_3);
        this.groupBox_1.Controls.Add(this.label_10);
        this.groupBox_1.Controls.Add(this.textBox_4);
        this.groupBox_1.Controls.Add(this.label_8);
        this.groupBox_1.Location = new Point(4, 0xb8);
        this.groupBox_1.Name = "groupBoxMTZ";
        this.groupBox_1.Size = new Size(0x19f, 0x3a);
        this.groupBox_1.TabIndex = 14;
        this.groupBox_1.TabStop = false;
        this.groupBox_1.Text = "МТЗ";
        this.textBox_2.DataBindings.Add(new Binding("Text", this.dataSetGES_0, "tJ_RelayProtectionAutomationValue.speed_mtz", true, DataSourceUpdateMode.OnPropertyChanged, ""));
        this.textBox_2.Location = new Point(0x129, 0x16);
        this.textBox_2.Name = "txtSpeedMTZ";
        this.textBox_2.Size = new Size(0x6d, 20);
        this.textBox_2.TabIndex = 5;
        this.label_9.AutoSize = true;
        this.label_9.Location = new Point(0xe4, 0x19);
        this.label_9.Name = "label11";
        this.label_9.Size = new Size(0x3f, 13);
        this.label_9.TabIndex = 4;
        this.label_9.Text = "Ускорение";
        this.textBox_3.DataBindings.Add(new Binding("Text", this.dataSetGES_0, "tJ_RelayProtectionAutomationValue.time_mtz", true, DataSourceUpdateMode.OnPropertyChanged, ""));
        this.textBox_3.Location = new Point(0x94, 0x16);
        this.textBox_3.Name = "txtTimeMTZ";
        this.textBox_3.Size = new Size(0x4a, 20);
        this.textBox_3.TabIndex = 3;
        this.label_10.AutoSize = true;
        this.label_10.Location = new Point(0x66, 0x19);
        this.label_10.Name = "label10";
        this.label_10.Size = new Size(40, 13);
        this.label_10.TabIndex = 2;
        this.label_10.Text = "Время";
        this.textBox_4.DataBindings.Add(new Binding("Text", this.dataSetGES_0, "tJ_RelayProtectionAutomationValue.amp_mtz", true, DataSourceUpdateMode.OnPropertyChanged, ""));
        this.textBox_4.Location = new Point(0x22, 0x16);
        this.textBox_4.Name = "txtAmpMTZ";
        this.textBox_4.Size = new Size(0x3e, 20);
        this.textBox_4.TabIndex = 1;
        this.label_8.AutoSize = true;
        this.label_8.Location = new Point(6, 0x19);
        this.label_8.Name = "label9";
        this.label_8.Size = new Size(0x1a, 13);
        this.label_8.TabIndex = 0;
        this.label_8.Text = "Ток";
        this.groupBox_2.Controls.Add(this.comboBox_7);
        this.groupBox_2.Controls.Add(this.label_20);
        this.groupBox_2.Controls.Add(this.textBox_5);
        this.groupBox_2.Controls.Add(this.label_11);
        this.groupBox_2.Controls.Add(this.textBox_6);
        this.groupBox_2.Controls.Add(this.label_12);
        this.groupBox_2.Location = new Point(0xda, 0xf8);
        this.groupBox_2.Name = "groupBoxOZZ";
        this.groupBox_2.Size = new Size(200, 0x7a);
        this.groupBox_2.TabIndex = 15;
        this.groupBox_2.TabStop = false;
        this.groupBox_2.Text = "ОЗЗ";
        this.comboBox_7.DataBindings.Add(new Binding("Text", this.dataSetGES_0, "tJ_RelayProtectionAutomationValue.act_ozz", true));
        this.comboBox_7.DropDownStyle = ComboBoxStyle.DropDownList;
        this.comboBox_7.FormattingEnabled = true;
        object[] items = new object[] { "на отключение", "на сигнал" };
        this.comboBox_7.Items.AddRange(items);
        this.comboBox_7.Location = new Point(9, 0x59);
        this.comboBox_7.Name = "comboBoxAct_OZZ";
        this.comboBox_7.Size = new Size(0xb7, 0x15);
        this.comboBox_7.TabIndex = 5;
        this.comboBox_7.KeyDown += new KeyEventHandler(this.comboBox_7_KeyDown);
        this.label_20.AutoSize = true;
        this.label_20.Location = new Point(6, 0x49);
        this.label_20.Name = "label16";
        this.label_20.Size = new Size(0x39, 13);
        this.label_20.TabIndex = 4;
        this.label_20.Text = "Действие";
        this.textBox_5.DataBindings.Add(new Binding("Text", this.dataSetGES_0, "tJ_RelayProtectionAutomationValue.time_ozz", true, DataSourceUpdateMode.OnPropertyChanged, ""));
        this.textBox_5.Location = new Point(0x8a, 0x16);
        this.textBox_5.Name = "txtTimeOZZ";
        this.textBox_5.Size = new Size(0x36, 20);
        this.textBox_5.TabIndex = 3;
        this.label_11.AutoSize = true;
        this.label_11.Location = new Point(0x5c, 0x19);
        this.label_11.Name = "label13";
        this.label_11.Size = new Size(40, 13);
        this.label_11.TabIndex = 2;
        this.label_11.Text = "Время";
        this.textBox_6.DataBindings.Add(new Binding("Text", this.dataSetGES_0, "tJ_RelayProtectionAutomationValue.amp_ozz", true, DataSourceUpdateMode.OnPropertyChanged, ""));
        this.textBox_6.Location = new Point(0x22, 0x16);
        this.textBox_6.Name = "txtAmpOzz";
        this.textBox_6.Size = new Size(0x34, 20);
        this.textBox_6.TabIndex = 1;
        this.label_12.AutoSize = true;
        this.label_12.Location = new Point(6, 0x19);
        this.label_12.Name = "label14";
        this.label_12.Size = new Size(0x1a, 13);
        this.label_12.TabIndex = 0;
        this.label_12.Text = "Ток";
        this.groupBox_3.Controls.Add(this.textBox_7);
        this.groupBox_3.Controls.Add(this.label_13);
        this.groupBox_3.Controls.Add(this.textBox_8);
        this.groupBox_3.Controls.Add(this.label_14);
        this.groupBox_3.Location = new Point(4, 0xf8);
        this.groupBox_3.Name = "groupBoxTO";
        this.groupBox_3.Size = new Size(0xd1, 0x3a);
        this.groupBox_3.TabIndex = 0x10;
        this.groupBox_3.TabStop = false;
        this.groupBox_3.Text = "ТО";
        this.textBox_7.DataBindings.Add(new Binding("Text", this.dataSetGES_0, "tJ_RelayProtectionAutomationValue.time_to", true, DataSourceUpdateMode.OnPropertyChanged, ""));
        this.textBox_7.Location = new Point(0x94, 0x16);
        this.textBox_7.Name = "txtTimeTO";
        this.textBox_7.Size = new Size(0x39, 20);
        this.textBox_7.TabIndex = 3;
        this.label_13.AutoSize = true;
        this.label_13.Location = new Point(0x66, 0x1d);
        this.label_13.Name = "label12";
        this.label_13.Size = new Size(40, 13);
        this.label_13.TabIndex = 2;
        this.label_13.Text = "Время";
        this.textBox_8.DataBindings.Add(new Binding("Text", this.dataSetGES_0, "tJ_RelayProtectionAutomationValue.amp_to", true, DataSourceUpdateMode.OnPropertyChanged, ""));
        this.textBox_8.Location = new Point(0x22, 0x16);
        this.textBox_8.Name = "txtAmpTO";
        this.textBox_8.Size = new Size(0x3e, 20);
        this.textBox_8.TabIndex = 1;
        this.label_14.AutoSize = true;
        this.label_14.Location = new Point(6, 0x19);
        this.label_14.Name = "label15";
        this.label_14.Size = new Size(0x1a, 13);
        this.label_14.TabIndex = 0;
        this.label_14.Text = "Ток";
        this.groupBox_4.Controls.Add(this.textBox_9);
        this.groupBox_4.Controls.Add(this.label_15);
        this.groupBox_4.Controls.Add(this.textBox_10);
        this.groupBox_4.Controls.Add(this.label_16);
        this.groupBox_4.Location = new Point(4, 0x138);
        this.groupBox_4.Name = "groupBoxUROV";
        this.groupBox_4.Size = new Size(0xd1, 0x3a);
        this.groupBox_4.TabIndex = 0x12;
        this.groupBox_4.TabStop = false;
        this.groupBox_4.Text = "УРОВ";
        this.textBox_9.DataBindings.Add(new Binding("Text", this.dataSetGES_0, "tJ_RelayProtectionAutomationValue.time_urov", true, DataSourceUpdateMode.OnPropertyChanged, ""));
        this.textBox_9.Location = new Point(0x94, 0x16);
        this.textBox_9.Name = "txtTimeUrov";
        this.textBox_9.Size = new Size(0x39, 20);
        this.textBox_9.TabIndex = 3;
        this.label_15.AutoSize = true;
        this.label_15.Location = new Point(0x66, 0x19);
        this.label_15.Name = "label18";
        this.label_15.Size = new Size(40, 13);
        this.label_15.TabIndex = 2;
        this.label_15.Text = "Время";
        this.textBox_10.DataBindings.Add(new Binding("Text", this.dataSetGES_0, "tJ_RelayProtectionAutomationValue.amp_urov", true, DataSourceUpdateMode.OnPropertyChanged, ""));
        this.textBox_10.Location = new Point(0x22, 0x16);
        this.textBox_10.Name = "txtAmpUrov";
        this.textBox_10.Size = new Size(0x3e, 20);
        this.textBox_10.TabIndex = 1;
        this.label_16.AutoSize = true;
        this.label_16.Location = new Point(6, 0x19);
        this.label_16.Name = "label19";
        this.label_16.Size = new Size(0x1a, 13);
        this.label_16.TabIndex = 0;
        this.label_16.Text = "Ток";
        this.groupBox_5.Controls.Add(this.comboBox_5);
        this.groupBox_5.Controls.Add(this.comboBox_6);
        this.groupBox_5.Location = new Point(4, 0x178);
        this.groupBox_5.Name = "groupBox3";
        this.groupBox_5.Size = new Size(0xd1, 0x36);
        this.groupBox_5.TabIndex = 0x13;
        this.groupBox_5.TabStop = false;
        this.groupBox_5.Text = "Тип реле и микропроц. устр-ва";
        this.comboBox_5.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        this.comboBox_5.AutoCompleteSource = AutoCompleteSource.ListItems;
        this.comboBox_5.DataBindings.Add(new Binding("SelectedItem", this.dataSetGES_0, "tJ_RelayProtectionAutomationValue.type_proc", true));
        this.comboBox_5.DataBindings.Add(new Binding("Text", this.dataSetGES_0, "tJ_RelayProtectionAutomationValue.type_proc", true));
        this.comboBox_5.FormattingEnabled = true;
        this.comboBox_5.Location = new Point(0xab, 0x13);
        this.comboBox_5.Name = "cmbMicroProc";
        this.comboBox_5.Size = new Size(0x26, 0x15);
        this.comboBox_5.Sorted = true;
        this.comboBox_5.TabIndex = 1;
        this.comboBox_5.Visible = false;
        this.comboBox_5.TextUpdate += new EventHandler(this.comboBox_5_TextUpdate);
        this.comboBox_6.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        this.comboBox_6.AutoCompleteSource = AutoCompleteSource.ListItems;
        this.comboBox_6.DataBindings.Add(new Binding("SelectedItem", this.dataSetGES_0, "tJ_RelayProtectionAutomationValue.type_relay", true));
        this.comboBox_6.DataBindings.Add(new Binding("Text", this.dataSetGES_0, "tJ_RelayProtectionAutomationValue.type_relay", true));
        this.comboBox_6.FormattingEnabled = true;
        this.comboBox_6.Location = new Point(8, 0x13);
        this.comboBox_6.Name = "cmbRele";
        this.comboBox_6.Size = new Size(0x9d, 0x15);
        this.comboBox_6.Sorted = true;
        this.comboBox_6.TabIndex = 0;
        this.comboBox_6.TextUpdate += new EventHandler(this.comboBox_6_TextUpdate);
        this.groupBox_6.Controls.Add(this.textBox_11);
        this.groupBox_6.Controls.Add(this.label_17);
        this.groupBox_6.Controls.Add(this.textBox_12);
        this.groupBox_6.Controls.Add(this.label_18);
        this.groupBox_6.Location = new Point(4, 0x1b2);
        this.groupBox_6.Name = "groupBox4";
        this.groupBox_6.Size = new Size(0x19f, 50);
        this.groupBox_6.TabIndex = 20;
        this.groupBox_6.TabStop = false;
        this.groupBox_6.Text = "Наименование присоединения";
        this.textBox_11.DataBindings.Add(new Binding("Text", this.dataSetGES_0, "tJ_RelayProtectionAutomationValue.cp_cell", true));
        this.textBox_11.Location = new Point(0xf9, 0x16);
        this.textBox_11.Name = "txtcp_cell";
        this.textBox_11.Size = new Size(0x9d, 20);
        this.textBox_11.TabIndex = 3;
        this.label_17.AutoSize = true;
        this.label_17.Location = new Point(0xc4, 0x19);
        this.label_17.Name = "label21";
        this.label_17.Size = new Size(0x2c, 13);
        this.label_17.TabIndex = 2;
        this.label_17.Text = "Ячейка";
        this.textBox_12.DataBindings.Add(new Binding("Text", this.dataSetGES_0, "tJ_RelayProtectionAutomationValue.cp", true));
        this.textBox_12.Location = new Point(0x27, 0x16);
        this.textBox_12.Name = "txtcp_name";
        this.textBox_12.Size = new Size(0x97, 20);
        this.textBox_12.TabIndex = 1;
        this.label_18.AutoSize = true;
        this.label_18.Location = new Point(8, 0x19);
        this.label_18.Name = "label20";
        this.label_18.Size = new Size(0x1d, 13);
        this.label_18.TabIndex = 0;
        this.label_18.Text = "Имя";
        this.label_19.AutoSize = true;
        this.label_19.Location = new Point(12, 0x1e7);
        this.label_19.Name = "label22";
        this.label_19.Size = new Size(70, 13);
        this.label_19.TabIndex = 0x15;
        this.label_19.Text = "Примечание";
        this.richTextBox_0.DataBindings.Add(new Binding("Text", this.dataSetGES_0, "tJ_RelayProtectionAutomationValue.comment", true));
        this.richTextBox_0.Location = new Point(4, 0x1f7);
        this.richTextBox_0.Name = "txtComment";
        this.richTextBox_0.Size = new Size(0x19f, 0x2b);
        this.richTextBox_0.TabIndex = 0x16;
        this.richTextBox_0.Text = "";
        this.groupBox_7.Controls.Add(this.comboBox_8);
        this.groupBox_7.Controls.Add(this.label_1);
        this.groupBox_7.Controls.Add(this.comboBox_0);
        this.groupBox_7.Controls.Add(this.label_2);
        this.groupBox_7.Controls.Add(this.comboBox_1);
        this.groupBox_7.Controls.Add(this.label_3);
        this.groupBox_7.Controls.Add(this.comboBox_2);
        this.groupBox_7.Controls.Add(this.label_4);
        this.groupBox_7.Controls.Add(this.comboBox_3);
        this.groupBox_7.Location = new Point(4, 0x26);
        this.groupBox_7.Name = "groupBoxSchmObj";
        this.groupBox_7.Size = new Size(0x19f, 0x4f);
        this.groupBox_7.TabIndex = 0x17;
        this.groupBox_7.TabStop = false;
        this.groupBox_7.Text = "Объект";
        this.comboBox_8.DataBindings.Add(new Binding("Text", this.dataSetGES_0, "tJ_RelayProtectionAutomation.name", true));
        this.comboBox_8.DropDownStyle = ComboBoxStyle.DropDownList;
        this.comboBox_8.FormattingEnabled = true;
        object[] objArray2 = new object[] { "1 уст.", "2 уст." };
        this.comboBox_8.Items.AddRange(objArray2);
        this.comboBox_8.Location = new Point(0xd4, 0x30);
        this.comboBox_8.Name = "txtNote";
        this.comboBox_8.Size = new Size(0xc2, 0x15);
        this.comboBox_8.TabIndex = 13;
        this.comboBox_8.KeyDown += new KeyEventHandler(this.comboBox_8_KeyDown);
        this.bindingSource_0.DataMember = "tJ_RelayProtectionAutomationValue";
        this.bindingSource_0.DataSource = this.dataSetGES_0;
        this.checkBox_0.AutoSize = true;
        this.checkBox_0.DataBindings.Add(new Binding("Checked", this.dataSetGES_0, "tJ_RelayProtectionAutomationValue.lzsh", true));
        this.checkBox_0.Location = new Point(280, 0x18f);
        this.checkBox_0.Name = "checkBoxLZSH";
        this.checkBox_0.Size = new Size(50, 0x11);
        this.checkBox_0.TabIndex = 0x18;
        this.checkBox_0.Text = "ЛЗШ";
        this.checkBox_0.UseVisualStyleBackColor = true;
        this.checkBox_1.AutoSize = true;
        this.checkBox_1.DataBindings.Add(new Binding("Checked", this.dataSetGES_0, "tJ_RelayProtectionAutomationValue.avr", true));
        this.checkBox_1.Location = new Point(0xe3, 0x18f);
        this.checkBox_1.Name = "checkBoxAVR";
        this.checkBox_1.Size = new Size(0x2f, 0x11);
        this.checkBox_1.TabIndex = 0x19;
        this.checkBox_1.Text = "АВР";
        this.checkBox_1.UseVisualStyleBackColor = true;
        this.checkBox_2.DataBindings.Add(new Binding("Checked", this.dataSetGES_0, "tJ_RelayProtectionAutomationValue.ArcProtection", true));
        this.checkBox_2.Location = new Point(0x150, 390);
        this.checkBox_2.Name = "chbArcProtection";
        this.checkBox_2.Size = new Size(0x53, 0x1f);
        this.checkBox_2.TabIndex = 0x1a;
        this.checkBox_2.Text = "Дуговая защита";
        this.checkBox_2.UseVisualStyleBackColor = true;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.CancelButton = this.button_1;
        base.ClientSize = new Size(0x1aa, 0x241);
        base.Controls.Add(this.checkBox_2);
        base.Controls.Add(this.checkBox_1);
        base.Controls.Add(this.checkBox_0);
        base.Controls.Add(this.groupBox_7);
        base.Controls.Add(this.richTextBox_0);
        base.Controls.Add(this.label_19);
        base.Controls.Add(this.groupBox_6);
        base.Controls.Add(this.groupBox_5);
        base.Controls.Add(this.groupBox_4);
        base.Controls.Add(this.groupBox_3);
        base.Controls.Add(this.groupBox_2);
        base.Controls.Add(this.groupBox_1);
        base.Controls.Add(this.groupBox_0);
        base.Controls.Add(this.button_1);
        base.Controls.Add(this.button_0);
        base.Controls.Add(this.dateTimePicker_0);
        base.Controls.Add(this.label_0);
        base.Name = "FormJRelayProtectionAutomationAddEdit";
        this.Text = "FormJRelayProtectionAutomationAddEdit";
        base.FormClosing += new FormClosingEventHandler(this.Form45_FormClosing);
        base.Load += new EventHandler(this.Form45_Load);
        this.dataSetGES_0.EndInit();
        this.groupBox_0.ResumeLayout(false);
        this.groupBox_0.PerformLayout();
        this.groupBox_1.ResumeLayout(false);
        this.groupBox_1.PerformLayout();
        this.groupBox_2.ResumeLayout(false);
        this.groupBox_2.PerformLayout();
        this.groupBox_3.ResumeLayout(false);
        this.groupBox_3.PerformLayout();
        this.groupBox_4.ResumeLayout(false);
        this.groupBox_4.PerformLayout();
        this.groupBox_5.ResumeLayout(false);
        this.groupBox_6.ResumeLayout(false);
        this.groupBox_6.PerformLayout();
        this.groupBox_7.ResumeLayout(false);
        this.groupBox_7.PerformLayout();
        ((ISupportInitialize) this.bindingSource_0).EndInit();
        base.ResumeLayout(false);
        base.PerformLayout();
    }
}

