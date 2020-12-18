using ControlsLbr;
using ControlsLbr.DataGridViewExcelFilter;
using Documents.Forms.TechnologicalConnection;
using Documents.Properties;
using FormLbr;
using FormLbr.Classes;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

internal class Form9 : FormBase
{
    private BindingSource bindingSource_0;
    private bool bool_0;
    private Button button_0;
    private Button button_1;
    private CheckBox checkBox_0;
    private ComboBox comboBox_0;
    private ComboBox comboBox_1;
    private ComboBox comboBox_2;
    private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_0;
    private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;
    private DataGridViewImageColumnNotNull dataGridViewImageColumnNotNull_0;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;
    private DataSetTechConnection dataSetTechConnection_0;
    private DateTimePicker dateTimePicker_0;
    private GroupBox groupBox_0;
    private GroupBox groupBox_1;
    private GroupBox groupBox_2;
    private IContainer icontainer_0;
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
    private int? nullable_0;
    private int? nullable_1;
    private int? nullable_2;
    private int? nullable_3;
    private int? nullable_4;
    private NullableDateTimePicker nullableDateTimePicker_0;
    private RichTextBox richTextBox_0;
    private TabControl tabControl_0;
    private TabPage tabPage_0;
    private TabPage tabPage_1;
    private TextBox textBox_0;
    private TextBox textBox_1;
    private TextBox textBox_2;
    private TextBox textBox_3;
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
    private ToolStripDropDownButton toolStripDropDownButton_0;
    private ToolStripMenuItem toolStripMenuItem_0;
    private ToolStripSeparator toolStripSeparator_0;
    private ToolStripSeparator toolStripSeparator_1;

    internal Form9(int? nullable_5 = new int?())
    {
        this.method_13();
        this.nullable_0 = nullable_5;
    }

    private void button_0_Click(object sender, EventArgs e)
    {
        base.Close();
    }

    private void button_1_Click(object sender, EventArgs e)
    {
        base.Close();
    }

    private void checkBox_0_CheckedChanged(object sender, EventArgs e)
    {
        if (this.checkBox_0.Checked)
        {
            this.groupBox_2.Enabled = false;
            this.groupBox_1.Enabled = false;
        }
        else
        {
            this.groupBox_1.Enabled = true;
            this.groupBox_2.Enabled = true;
        }
        this.bool_0 = true;
    }

    private void comboBox_0_SelectedValueChanged(object sender, EventArgs e)
    {
        this.bool_0 = true;
    }

    private void comboBox_2_SelectedValueChanged(object sender, EventArgs e)
    {
        ComboBox box = (ComboBox) sender;
        if ((box.SelectedValue != null) || (box.SelectedValue != DBNull.Value))
        {
            if (box == this.comboBox_2)
            {
                this.nullable_4 = new int?(Convert.ToInt32(box.SelectedValue));
            }
            if (box == this.comboBox_1)
            {
                this.nullable_2 = new int?(Convert.ToInt32(box.SelectedValue));
            }
            this.bool_0 = true;
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

    private void Form9_FormClosing(object sender, FormClosingEventArgs e)
    {
        if ((base.DialogResult != DialogResult.OK) && (!this.bool_0 || (MessageBox.Show("Сохранить внесенные изменения", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)))
        {
            base.DialogResult = DialogResult.Cancel;
        }
        else if (this.method_9())
        {
            if ((this.checkBox_0.Enabled && this.checkBox_0.Checked) && (MessageBox.Show("Все документы и привязки от старого объекта перейдут к новому. Провести документ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No))
            {
                base.DialogResult = DialogResult.Cancel;
            }
            if (this.method_10())
            {
                base.DialogResult = DialogResult.OK;
            }
            else
            {
                base.DialogResult = DialogResult.None;
                e.Cancel = true;
            }
        }
        else
        {
            base.DialogResult = DialogResult.None;
            e.Cancel = true;
        }
    }

    private void Form9_Load(object sender, EventArgs e)
    {
        this.dateTimePicker_0.Value = DateTime.Now.Date;
        this.method_4();
        if (!this.nullable_0.HasValue)
        {
            this.method_1();
            this.method_2();
        }
        else
        {
            base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Doc, true, "where id = " + this.nullable_0.ToString());
            if (this.dataSetTechConnection_0.tTC_Doc.Rows.Count > 0)
            {
                this.method_5(Convert.ToInt32(this.nullable_0));
                base.SelectSqlData(this.dataSetTechConnection_0.tTC_ChangeOwnership, true, "where id = " + this.nullable_0.ToString(), false);
                if (this.dataSetTechConnection_0.tTC_ChangeOwnership.Rows.Count == 0)
                {
                    this.method_2();
                }
            }
            else
            {
                this.method_1();
                this.method_2();
            }
        }
        if ((this.dataSetTechConnection_0.tTC_ChangeOwnership.Rows[0]["isApply"] != DBNull.Value) && Convert.ToBoolean(this.dataSetTechConnection_0.tTC_ChangeOwnership.Rows[0]["isApply"]))
        {
            this.checkBox_0.Enabled = false;
        }
        this.bool_0 = false;
    }

    internal int? method_0()
    {
        return this.nullable_0;
    }

    private void method_1()
    {
        DataRow row = this.dataSetTechConnection_0.tTC_Doc.NewRow();
        row["dateDoc"] = DateTime.Now.Date;
        row["typeDoc"] = 0x541;
        this.dataSetTechConnection_0.tTC_Doc.Rows.Add(row);
    }

    private bool method_10()
    {
        if (!this.method_11())
        {
            return false;
        }
        if (!this.method_12())
        {
            return false;
        }
        return true;
    }

    private bool method_11()
    {
        this.dataSetTechConnection_0.tTC_Doc.Rows[0].EndEdit();
        if (!this.nullable_0.HasValue)
        {
            this.nullable_0 = new int?(base.InsertSqlDataOneRow(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Doc));
            int? nullable = this.nullable_0;
            if ((nullable.GetValueOrDefault() == -1) ? nullable.HasValue : false)
            {
                return false;
            }
        }
        else if (!base.UpdateSqlData(this.dataSetTechConnection_0.tTC_Doc))
        {
            return false;
        }
        return true;
    }

    private bool method_12()
    {
        this.dataSetTechConnection_0.tTC_ChangeOwnership.Rows[0]["id"] = this.nullable_0;
        this.dataSetTechConnection_0.tTC_ChangeOwnership.Rows[0]["idAbnOld"] = this.nullable_1;
        this.dataSetTechConnection_0.tTC_ChangeOwnership.Rows[0]["idAbnObjOld"] = this.nullable_2;
        this.dataSetTechConnection_0.tTC_ChangeOwnership.Rows[0]["idAbnNew"] = this.nullable_3;
        this.dataSetTechConnection_0.tTC_ChangeOwnership.Rows[0]["idAbnObjNew"] = this.nullable_4;
        this.dataSetTechConnection_0.tTC_ChangeOwnership.Rows[0].EndEdit();
        if (!base.InsertSqlData(this.dataSetTechConnection_0.tTC_ChangeOwnership))
        {
            return false;
        }
        if (!base.UpdateSqlData(this.dataSetTechConnection_0.tTC_ChangeOwnership))
        {
            return false;
        }
        return true;
    }

    private void method_13()
    {
        this.icontainer_0 = new Container();
        DataGridViewCellStyle style = new DataGridViewCellStyle();
        this.label_0 = new Label();
        this.textBox_0 = new TextBox();
        this.dataSetTechConnection_0 = new DataSetTechConnection();
        this.label_1 = new Label();
        this.dateTimePicker_0 = new DateTimePicker();
        this.groupBox_0 = new GroupBox();
        this.comboBox_0 = new ComboBox();
        this.label_2 = new Label();
        this.nullableDateTimePicker_0 = new NullableDateTimePicker();
        this.label_3 = new Label();
        this.textBox_1 = new TextBox();
        this.label_4 = new Label();
        this.comboBox_1 = new ComboBox();
        this.toolStrip_0 = new ToolStrip();
        this.toolStripButton_0 = new ToolStripButton();
        this.label_5 = new Label();
        this.textBox_2 = new TextBox();
        this.label_6 = new Label();
        this.groupBox_1 = new GroupBox();
        this.groupBox_2 = new GroupBox();
        this.label_7 = new Label();
        this.comboBox_2 = new ComboBox();
        this.textBox_3 = new TextBox();
        this.toolStrip_1 = new ToolStrip();
        this.toolStripButton_1 = new ToolStripButton();
        this.label_8 = new Label();
        this.tabControl_0 = new TabControl();
        this.tabPage_0 = new TabPage();
        this.checkBox_0 = new CheckBox();
        this.richTextBox_0 = new RichTextBox();
        this.label_9 = new Label();
        this.tabPage_1 = new TabPage();
        this.dataGridViewExcelFilter_0 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
        this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
        this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
        this.dataGridViewImageColumnNotNull_0 = new DataGridViewImageColumnNotNull();
        this.bindingSource_0 = new BindingSource(this.icontainer_0);
        this.toolStrip_2 = new ToolStrip();
        this.toolStripDropDownButton_0 = new ToolStripDropDownButton();
        this.toolStripMenuItem_0 = new ToolStripMenuItem();
        this.toolStripSeparator_0 = new ToolStripSeparator();
        this.toolStripButton_2 = new ToolStripButton();
        this.toolStripButton_3 = new ToolStripButton();
        this.toolStripButton_4 = new ToolStripButton();
        this.toolStripSeparator_1 = new ToolStripSeparator();
        this.toolStripButton_5 = new ToolStripButton();
        this.toolStripButton_6 = new ToolStripButton();
        this.button_0 = new Button();
        this.button_1 = new Button();
        this.dataSetTechConnection_0.BeginInit();
        this.groupBox_0.SuspendLayout();
        this.toolStrip_0.SuspendLayout();
        this.groupBox_1.SuspendLayout();
        this.groupBox_2.SuspendLayout();
        this.toolStrip_1.SuspendLayout();
        this.tabControl_0.SuspendLayout();
        this.tabPage_0.SuspendLayout();
        this.tabPage_1.SuspendLayout();
        this.dataGridViewExcelFilter_0.BeginInit();
        ((ISupportInitialize) this.bindingSource_0).BeginInit();
        this.toolStrip_2.SuspendLayout();
        base.SuspendLayout();
        this.label_0.AutoSize = true;
        this.label_0.Location = new Point(6, 7);
        this.label_0.Name = "label1";
        this.label_0.Size = new Size(0x4b, 13);
        this.label_0.TabIndex = 0;
        this.label_0.Text = "№ документа";
        this.textBox_0.BackColor = SystemColors.Window;
        this.textBox_0.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tTC_Doc.numDoc", true));
        this.textBox_0.Location = new Point(0x57, 4);
        this.textBox_0.Name = "txtDocNum";
        this.textBox_0.ReadOnly = true;
        this.textBox_0.Size = new Size(0x52, 20);
        this.textBox_0.TabIndex = 1;
        this.dataSetTechConnection_0.DataSetName = "DataSetTechConnection";
        this.dataSetTechConnection_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        this.label_1.AutoSize = true;
        this.label_1.Location = new Point(0xaf, 7);
        this.label_1.Name = "label2";
        this.label_1.Size = new Size(90, 13);
        this.label_1.TabIndex = 2;
        this.label_1.Text = "Дата документа";
        this.dateTimePicker_0.DataBindings.Add(new Binding("Value", this.dataSetTechConnection_0, "tTC_Doc.dateDoc", true));
        this.dateTimePicker_0.Location = new Point(0x10f, 4);
        this.dateTimePicker_0.Name = "dtpDateDoc";
        this.dateTimePicker_0.Size = new Size(0x92, 20);
        this.dateTimePicker_0.TabIndex = 3;
        this.dateTimePicker_0.ValueChanged += new EventHandler(this.nullableDateTimePicker_0_ValueChanged);
        this.groupBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.groupBox_0.Controls.Add(this.comboBox_0);
        this.groupBox_0.Controls.Add(this.label_2);
        this.groupBox_0.Controls.Add(this.nullableDateTimePicker_0);
        this.groupBox_0.Controls.Add(this.label_3);
        this.groupBox_0.Controls.Add(this.textBox_1);
        this.groupBox_0.Controls.Add(this.label_4);
        this.groupBox_0.Location = new Point(6, 0x22);
        this.groupBox_0.Name = "groupBoxDocIn";
        this.groupBox_0.Size = new Size(530, 0x38);
        this.groupBox_0.TabIndex = 4;
        this.groupBox_0.TabStop = false;
        this.groupBox_0.Text = "Регламентирующий документ";
        this.comboBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.comboBox_0.DataBindings.Add(new Binding("SelectedValue", this.dataSetTechConnection_0, "tTC_ChangeOwnership.TypeDocIn", true));
        this.comboBox_0.FormattingEnabled = true;
        this.comboBox_0.Location = new Point(0xac, 0x17);
        this.comboBox_0.Name = "cmbTypeDocIn";
        this.comboBox_0.Size = new Size(0xc0, 0x15);
        this.comboBox_0.TabIndex = 5;
        this.comboBox_0.SelectedValueChanged += new EventHandler(this.comboBox_0_SelectedValueChanged);
        this.label_2.AutoSize = true;
        this.label_2.Location = new Point(0xb2, 7);
        this.label_2.Name = "label5";
        this.label_2.Size = new Size(0x53, 13);
        this.label_2.TabIndex = 4;
        this.label_2.Text = "Тип документа";
        this.nullableDateTimePicker_0.Anchor = AnchorStyles.Right | AnchorStyles.Top;
        this.nullableDateTimePicker_0.set_CustomFormat("dd.MM.yyyy");
        this.nullableDateTimePicker_0.DataBindings.Add(new Binding("Value", this.dataSetTechConnection_0, "tTC_ChangeOwnership.dateDocIn", true));
        this.nullableDateTimePicker_0.set_Format(DateTimePickerFormat.Custom);
        this.nullableDateTimePicker_0.Location = new Point(0x199, 0x15);
        this.nullableDateTimePicker_0.Name = "dtpDateDocIn";
        this.nullableDateTimePicker_0.Size = new Size(0x73, 20);
        this.nullableDateTimePicker_0.TabIndex = 3;
        this.nullableDateTimePicker_0.set_Value(new DateTime(0x7dd, 4, 15, 13, 0x1c, 0x35, 0x324));
        this.nullableDateTimePicker_0.ValueChanged += new EventHandler(this.nullableDateTimePicker_0_ValueChanged);
        this.label_3.Anchor = AnchorStyles.Right | AnchorStyles.Top;
        this.label_3.AutoSize = true;
        this.label_3.Location = new Point(370, 0x1a);
        this.label_3.Name = "label3";
        this.label_3.Size = new Size(0x21, 13);
        this.label_3.TabIndex = 2;
        this.label_3.Text = "Дата";
        this.textBox_1.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tTC_ChangeOwnership.numDocIn", true));
        this.textBox_1.Location = new Point(0x39, 0x18);
        this.textBox_1.Name = "txtNumDocIn";
        this.textBox_1.Size = new Size(0x6a, 20);
        this.textBox_1.TabIndex = 1;
        this.textBox_1.TextChanged += new EventHandler(this.richTextBox_0_TextChanged);
        this.label_4.AutoSize = true;
        this.label_4.Location = new Point(10, 0x1b);
        this.label_4.Name = "label4";
        this.label_4.Size = new Size(0x29, 13);
        this.label_4.TabIndex = 0;
        this.label_4.Text = "Номер";
        this.comboBox_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.comboBox_1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        this.comboBox_1.AutoCompleteSource = AutoCompleteSource.ListItems;
        this.comboBox_1.FormattingEnabled = true;
        this.comboBox_1.Location = new Point(13, 70);
        this.comboBox_1.Name = "cmbAbnObjOld";
        this.comboBox_1.Size = new Size(0x200, 0x15);
        this.comboBox_1.TabIndex = 12;
        this.comboBox_1.SelectedValueChanged += new EventHandler(this.comboBox_2_SelectedValueChanged);
        this.toolStrip_0.Anchor = AnchorStyles.Right | AnchorStyles.Top;
        this.toolStrip_0.Dock = DockStyle.None;
        this.toolStrip_0.GripStyle = ToolStripGripStyle.Hidden;
        ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripButton_0 };
        this.toolStrip_0.Items.AddRange(toolStripItems);
        this.toolStrip_0.Location = new Point(0x1f8, 0x31);
        this.toolStrip_0.Name = "toolStripAbnOld";
        this.toolStrip_0.Size = new Size(0x1a, 0x19);
        this.toolStrip_0.TabIndex = 14;
        this.toolStrip_0.Text = "toolStrip1";
        this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_0.Image = Resources.partners;
        this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
        this.toolStripButton_0.Name = "toolBtnAbnOld";
        this.toolStripButton_0.Size = new Size(0x17, 0x16);
        this.toolStripButton_0.Text = "Выбрать контрагента";
        this.toolStripButton_0.Click += new EventHandler(this.toolStripButton_0_Click);
        this.label_5.AutoSize = true;
        this.label_5.Location = new Point(13, 0x37);
        this.label_5.Name = "label6";
        this.label_5.Size = new Size(0x2d, 13);
        this.label_5.TabIndex = 11;
        this.label_5.Text = "Объект";
        this.textBox_2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.textBox_2.BackColor = SystemColors.Window;
        this.textBox_2.Location = new Point(13, 0x20);
        this.textBox_2.Name = "txtAbnOld";
        this.textBox_2.ReadOnly = true;
        this.textBox_2.Size = new Size(0x200, 20);
        this.textBox_2.TabIndex = 10;
        this.label_6.AutoSize = true;
        this.label_6.Location = new Point(10, 0x10);
        this.label_6.Name = "label7";
        this.label_6.Size = new Size(0x31, 13);
        this.label_6.TabIndex = 9;
        this.label_6.Text = "Абонент";
        this.groupBox_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.groupBox_1.Controls.Add(this.label_6);
        this.groupBox_1.Controls.Add(this.comboBox_1);
        this.groupBox_1.Controls.Add(this.textBox_2);
        this.groupBox_1.Controls.Add(this.toolStrip_0);
        this.groupBox_1.Controls.Add(this.label_5);
        this.groupBox_1.Location = new Point(6, 0x54);
        this.groupBox_1.Name = "groupBoxAbnOld";
        this.groupBox_1.Size = new Size(0x213, 100);
        this.groupBox_1.TabIndex = 15;
        this.groupBox_1.TabStop = false;
        this.groupBox_1.Text = "Старый собственник";
        this.groupBox_2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.groupBox_2.Controls.Add(this.label_7);
        this.groupBox_2.Controls.Add(this.comboBox_2);
        this.groupBox_2.Controls.Add(this.textBox_3);
        this.groupBox_2.Controls.Add(this.toolStrip_1);
        this.groupBox_2.Controls.Add(this.label_8);
        this.groupBox_2.Location = new Point(6, 0xb5);
        this.groupBox_2.Name = "groupBoxAbnNew";
        this.groupBox_2.Size = new Size(0x213, 100);
        this.groupBox_2.TabIndex = 0x10;
        this.groupBox_2.TabStop = false;
        this.groupBox_2.Text = "Новый собственник";
        this.label_7.AutoSize = true;
        this.label_7.Location = new Point(10, 0x10);
        this.label_7.Name = "label8";
        this.label_7.Size = new Size(0x31, 13);
        this.label_7.TabIndex = 9;
        this.label_7.Text = "Абонент";
        this.comboBox_2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.comboBox_2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        this.comboBox_2.AutoCompleteSource = AutoCompleteSource.ListItems;
        this.comboBox_2.FormattingEnabled = true;
        this.comboBox_2.Location = new Point(13, 70);
        this.comboBox_2.Name = "cmbAbnObjNew";
        this.comboBox_2.Size = new Size(0x200, 0x15);
        this.comboBox_2.TabIndex = 12;
        this.comboBox_2.SelectedValueChanged += new EventHandler(this.comboBox_2_SelectedValueChanged);
        this.textBox_3.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.textBox_3.BackColor = SystemColors.Window;
        this.textBox_3.Location = new Point(13, 0x20);
        this.textBox_3.Name = "txtAbnNew";
        this.textBox_3.ReadOnly = true;
        this.textBox_3.Size = new Size(0x200, 20);
        this.textBox_3.TabIndex = 10;
        this.toolStrip_1.Anchor = AnchorStyles.Right | AnchorStyles.Top;
        this.toolStrip_1.Dock = DockStyle.None;
        this.toolStrip_1.GripStyle = ToolStripGripStyle.Hidden;
        ToolStripItem[] itemArray2 = new ToolStripItem[] { this.toolStripButton_1 };
        this.toolStrip_1.Items.AddRange(itemArray2);
        this.toolStrip_1.Location = new Point(0x1f8, 0x31);
        this.toolStrip_1.Name = "toolStripAbnNew";
        this.toolStrip_1.Size = new Size(0x1a, 0x19);
        this.toolStrip_1.TabIndex = 14;
        this.toolStrip_1.Text = "toolStrip1";
        this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_1.Image = Resources.partners;
        this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
        this.toolStripButton_1.Name = "toolStripButton1";
        this.toolStripButton_1.Size = new Size(0x17, 0x16);
        this.toolStripButton_1.Text = "Выбрать контрагента";
        this.toolStripButton_1.Click += new EventHandler(this.toolStripButton_1_Click);
        this.label_8.AutoSize = true;
        this.label_8.Location = new Point(13, 0x37);
        this.label_8.Name = "label9";
        this.label_8.Size = new Size(0x2d, 13);
        this.label_8.TabIndex = 11;
        this.label_8.Text = "Объект";
        this.tabControl_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
        this.tabControl_0.Controls.Add(this.tabPage_0);
        this.tabControl_0.Controls.Add(this.tabPage_1);
        this.tabControl_0.Location = new Point(0, 0);
        this.tabControl_0.Name = "tabControl";
        this.tabControl_0.SelectedIndex = 0;
        this.tabControl_0.Size = new Size(0x228, 0x1b6);
        this.tabControl_0.TabIndex = 0x11;
        this.tabPage_0.Controls.Add(this.checkBox_0);
        this.tabPage_0.Controls.Add(this.richTextBox_0);
        this.tabPage_0.Controls.Add(this.label_9);
        this.tabPage_0.Controls.Add(this.label_0);
        this.tabPage_0.Controls.Add(this.groupBox_2);
        this.tabPage_0.Controls.Add(this.textBox_0);
        this.tabPage_0.Controls.Add(this.groupBox_1);
        this.tabPage_0.Controls.Add(this.label_1);
        this.tabPage_0.Controls.Add(this.groupBox_0);
        this.tabPage_0.Controls.Add(this.dateTimePicker_0);
        this.tabPage_0.Location = new Point(4, 0x16);
        this.tabPage_0.Name = "tabPageGeneral";
        this.tabPage_0.Padding = new Padding(3);
        this.tabPage_0.Size = new Size(0x220, 0x19c);
        this.tabPage_0.TabIndex = 0;
        this.tabPage_0.Text = "Общие";
        this.tabPage_0.UseVisualStyleBackColor = true;
        this.checkBox_0.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
        this.checkBox_0.AutoSize = true;
        this.checkBox_0.DataBindings.Add(new Binding("Checked", this.dataSetTechConnection_0, "tTC_ChangeOwnership.isApply", true));
        this.checkBox_0.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
        this.checkBox_0.Location = new Point(0x13, 0x181);
        this.checkBox_0.Name = "checkBoxApply";
        this.checkBox_0.Size = new Size(0x67, 0x11);
        this.checkBox_0.TabIndex = 0x13;
        this.checkBox_0.Text = "Согласовано";
        this.checkBox_0.TextAlign = ContentAlignment.MiddleCenter;
        this.checkBox_0.UseVisualStyleBackColor = true;
        this.checkBox_0.CheckedChanged += new EventHandler(this.checkBox_0_CheckedChanged);
        this.richTextBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
        this.richTextBox_0.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tTC_Doc.Comment", true));
        this.richTextBox_0.Location = new Point(6, 0x12e);
        this.richTextBox_0.Name = "txtComment";
        this.richTextBox_0.Size = new Size(530, 0x4d);
        this.richTextBox_0.TabIndex = 0x12;
        this.richTextBox_0.Text = "";
        this.richTextBox_0.TextChanged += new EventHandler(this.richTextBox_0_TextChanged);
        this.label_9.AutoSize = true;
        this.label_9.Location = new Point(0x10, 0x11e);
        this.label_9.Name = "label10";
        this.label_9.Size = new Size(0x4d, 13);
        this.label_9.TabIndex = 0x11;
        this.label_9.Text = "Комментарий";
        this.tabPage_1.Controls.Add(this.dataGridViewExcelFilter_0);
        this.tabPage_1.Controls.Add(this.toolStrip_2);
        this.tabPage_1.Location = new Point(4, 0x16);
        this.tabPage_1.Name = "tabPageFile";
        this.tabPage_1.Padding = new Padding(3);
        this.tabPage_1.Size = new Size(0x220, 0x19c);
        this.tabPage_1.TabIndex = 1;
        this.tabPage_1.Text = "Файлы";
        this.tabPage_1.UseVisualStyleBackColor = true;
        this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
        this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
        this.dataGridViewExcelFilter_0.AllowUserToResizeColumns = false;
        this.dataGridViewExcelFilter_0.AllowUserToResizeRows = false;
        this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
        this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewFilterTextBoxColumn_0, this.dataGridViewTextBoxColumn_0, this.dataGridViewTextBoxColumn_1, this.dataGridViewTextBoxColumn_2, this.dataGridViewTextBoxColumn_3, this.dataGridViewImageColumnNotNull_0 };
        this.dataGridViewExcelFilter_0.Columns.AddRange(dataGridViewColumns);
        this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
        this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
        this.dataGridViewExcelFilter_0.EditMode = DataGridViewEditMode.EditProgrammatically;
        this.dataGridViewExcelFilter_0.Location = new Point(3, 0x1c);
        this.dataGridViewExcelFilter_0.Name = "dgvFile";
        this.dataGridViewExcelFilter_0.ReadOnly = true;
        this.dataGridViewExcelFilter_0.RowHeadersVisible = false;
        this.dataGridViewExcelFilter_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        this.dataGridViewExcelFilter_0.Size = new Size(0x21a, 0x17d);
        this.dataGridViewExcelFilter_0.TabIndex = 7;
        this.dataGridViewExcelFilter_0.VirtualMode = true;
        this.dataGridViewFilterTextBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.dataGridViewFilterTextBoxColumn_0.DataPropertyName = "FileName";
        this.dataGridViewFilterTextBoxColumn_0.HeaderText = "Файл";
        this.dataGridViewFilterTextBoxColumn_0.Name = "fileNameDgvColumn";
        this.dataGridViewFilterTextBoxColumn_0.ReadOnly = true;
        this.dataGridViewFilterTextBoxColumn_0.Resizable = DataGridViewTriState.True;
        this.dataGridViewTextBoxColumn_0.DataPropertyName = "id";
        this.dataGridViewTextBoxColumn_0.HeaderText = "id";
        this.dataGridViewTextBoxColumn_0.Name = "idFileDgvColumn";
        this.dataGridViewTextBoxColumn_0.ReadOnly = true;
        this.dataGridViewTextBoxColumn_0.Visible = false;
        this.dataGridViewTextBoxColumn_1.DataPropertyName = "idDoc";
        this.dataGridViewTextBoxColumn_1.HeaderText = "idDoc";
        this.dataGridViewTextBoxColumn_1.Name = "idDocDgvColumn";
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
        style.NullValue = null;
        this.dataGridViewImageColumnNotNull_0.DefaultCellStyle = style;
        this.dataGridViewImageColumnNotNull_0.HeaderText = "";
        this.dataGridViewImageColumnNotNull_0.ImageLayout = DataGridViewImageCellLayout.Zoom;
        this.dataGridViewImageColumnNotNull_0.Name = "imageDgvColumn";
        this.dataGridViewImageColumnNotNull_0.ReadOnly = true;
        this.dataGridViewImageColumnNotNull_0.Width = 30;
        this.bindingSource_0.DataMember = "tTC_DocFile";
        this.bindingSource_0.DataSource = this.dataSetTechConnection_0;
        ToolStripItem[] itemArray3 = new ToolStripItem[] { this.toolStripDropDownButton_0, this.toolStripButton_2, this.toolStripButton_3, this.toolStripButton_4, this.toolStripSeparator_1, this.toolStripButton_5, this.toolStripButton_6 };
        this.toolStrip_2.Items.AddRange(itemArray3);
        this.toolStrip_2.Location = new Point(3, 3);
        this.toolStrip_2.Name = "toolStripFile";
        this.toolStrip_2.Size = new Size(0x21a, 0x19);
        this.toolStrip_2.TabIndex = 1;
        this.toolStrip_2.Text = "toolStrip1";
        this.toolStripDropDownButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
        ToolStripItem[] itemArray4 = new ToolStripItem[] { this.toolStripMenuItem_0, this.toolStripSeparator_0 };
        this.toolStripDropDownButton_0.DropDownItems.AddRange(itemArray4);
        this.toolStripDropDownButton_0.Image = Resources.ElementAdd;
        this.toolStripDropDownButton_0.ImageTransparentColor = Color.Magenta;
        this.toolStripDropDownButton_0.Name = "toolBtnAddFile";
        this.toolStripDropDownButton_0.Size = new Size(0x1d, 0x16);
        this.toolStripDropDownButton_0.Text = "Добавить файл";
        this.toolStripMenuItem_0.Name = "toolItemAddExistFile";
        this.toolStripMenuItem_0.Size = new Size(190, 0x16);
        this.toolStripMenuItem_0.Text = "Сущесвующий файл";
        this.toolStripSeparator_0.Name = "toolStripSeparator2";
        this.toolStripSeparator_0.Size = new Size(0xbb, 6);
        this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_2.Image = Resources.ElementEdit;
        this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
        this.toolStripButton_2.Name = "toolBtnEditFile";
        this.toolStripButton_2.Size = new Size(0x17, 0x16);
        this.toolStripButton_2.Text = "Редактировать файл";
        this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_3.Image = Resources.ElementInformation;
        this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
        this.toolStripButton_3.Name = "toolBtnOpenFile";
        this.toolStripButton_3.Size = new Size(0x17, 0x16);
        this.toolStripButton_3.Text = "Открыть файл";
        this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_4.Image = Resources.ElementDel;
        this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
        this.toolStripButton_4.Name = "toolBtnDelFile";
        this.toolStripButton_4.Size = new Size(0x17, 0x16);
        this.toolStripButton_4.Text = "Удалить файл";
        this.toolStripSeparator_1.Name = "toolStripSeparator3";
        this.toolStripSeparator_1.Size = new Size(6, 0x19);
        this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_5.Image = Resources.rename;
        this.toolStripButton_5.ImageTransparentColor = Color.Magenta;
        this.toolStripButton_5.Name = "toolBtnRenameFile";
        this.toolStripButton_5.Size = new Size(0x17, 0x16);
        this.toolStripButton_5.Text = "Переименовать";
        this.toolStripButton_6.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_6.Image = Resources.save;
        this.toolStripButton_6.ImageTransparentColor = Color.Magenta;
        this.toolStripButton_6.Name = "toolBtnSaveFile";
        this.toolStripButton_6.Size = new Size(0x17, 0x16);
        this.toolStripButton_6.Text = "Сохранить файл на диск";
        this.button_0.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
        this.button_0.DialogResult = DialogResult.Cancel;
        this.button_0.Location = new Point(0x1d2, 0x1bc);
        this.button_0.Name = "buttonClose";
        this.button_0.Size = new Size(0x4b, 0x17);
        this.button_0.TabIndex = 0x12;
        this.button_0.Text = "Закрыть";
        this.button_0.UseVisualStyleBackColor = true;
        this.button_0.Click += new EventHandler(this.button_0_Click);
        this.button_1.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
        this.button_1.DialogResult = DialogResult.OK;
        this.button_1.Location = new Point(0x148, 0x1bc);
        this.button_1.Name = "buttonSaveAndClose";
        this.button_1.Size = new Size(0x84, 0x17);
        this.button_1.TabIndex = 0x13;
        this.button_1.Text = "Сохранить и закрыть";
        this.button_1.UseVisualStyleBackColor = true;
        this.button_1.Click += new EventHandler(this.button_1_Click);
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(550, 0x1d9);
        base.Controls.Add(this.button_1);
        base.Controls.Add(this.button_0);
        base.Controls.Add(this.tabControl_0);
        base.Name = "FormDocChangeOwnerShipAddEdit";
        this.Text = "Смена собственника";
        base.FormClosing += new FormClosingEventHandler(this.Form9_FormClosing);
        base.Load += new EventHandler(this.Form9_Load);
        this.dataSetTechConnection_0.EndInit();
        this.groupBox_0.ResumeLayout(false);
        this.groupBox_0.PerformLayout();
        this.toolStrip_0.ResumeLayout(false);
        this.toolStrip_0.PerformLayout();
        this.groupBox_1.ResumeLayout(false);
        this.groupBox_1.PerformLayout();
        this.groupBox_2.ResumeLayout(false);
        this.groupBox_2.PerformLayout();
        this.toolStrip_1.ResumeLayout(false);
        this.toolStrip_1.PerformLayout();
        this.tabControl_0.ResumeLayout(false);
        this.tabPage_0.ResumeLayout(false);
        this.tabPage_0.PerformLayout();
        this.tabPage_1.ResumeLayout(false);
        this.tabPage_1.PerformLayout();
        this.dataGridViewExcelFilter_0.EndInit();
        ((ISupportInitialize) this.bindingSource_0).EndInit();
        this.toolStrip_2.ResumeLayout(false);
        this.toolStrip_2.PerformLayout();
        base.ResumeLayout(false);
    }

    private void method_2()
    {
        DataRow row = this.dataSetTechConnection_0.tTC_ChangeOwnership.NewRow();
        row["id"] = this.dataSetTechConnection_0.tTC_Doc.Rows[0]["id"];
        row["isApply"] = false;
        this.dataSetTechConnection_0.tTC_ChangeOwnership.Rows.Add(row);
    }

    private void method_3(ComboBox comboBox_3, int? nullable_5)
    {
        if (!nullable_5.HasValue)
        {
            comboBox_3.Items.Clear();
            if (comboBox_3 == this.comboBox_2)
            {
                this.nullable_4 = null;
            }
            if (comboBox_3 == this.comboBox_1)
            {
                this.nullable_2 = null;
            }
        }
        DataSetTechConnection.tAbnDataTable table = new DataSetTechConnection.tAbnDataTable();
        base.SelectSqlData(table, true, " where id = " + nullable_5.ToString(), false);
        if (table.Rows.Count > 0)
        {
            comboBox_3.SelectedValueChanged -= new EventHandler(this.comboBox_2_SelectedValueChanged);
            int num = Convert.ToInt32(table.Rows[0]["typeAbn"]);
            DataSetTechConnection.vAbnObjAddressDataTable table2 = new DataSetTechConnection.vAbnObjAddressDataTable();
            DataColumn column = new DataColumn("AddressFL") {
                Expression = "street + ', д. ' + houseall + isnull(', кв. ' + name, '')"
            };
            table2.Columns.Add(column);
            column = new DataColumn("AddressUL") {
                Expression = "street + ', д. ' + houseall"
            };
            table2.Columns.Add(column);
            base.SelectSqlData(table2, true, "where idAbn = " + nullable_5.ToString() + " order by name", false);
            comboBox_3.ValueMember = "id";
            comboBox_3.DataSource = table2;
            if (((num != 0xce) && (num != 0xfd)) && (num != 0x40d))
            {
                comboBox_3.DisplayMember = "name";
            }
            else
            {
                comboBox_3.DisplayMember = "AddressFL";
            }
            if (comboBox_3 == this.comboBox_2)
            {
                comboBox_3.SelectedValue = this.nullable_4;
            }
            if (comboBox_3 == this.comboBox_1)
            {
                comboBox_3.SelectedValue = this.nullable_2;
            }
            if (comboBox_3.SelectedValue == null)
            {
                if (comboBox_3 == this.comboBox_2)
                {
                    this.nullable_4 = null;
                }
                if (comboBox_3 == this.comboBox_1)
                {
                    this.nullable_2 = null;
                }
            }
            comboBox_3.SelectedValueChanged += new EventHandler(this.comboBox_2_SelectedValueChanged);
        }
        else
        {
            comboBox_3.Items.Clear();
            if (comboBox_3 == this.comboBox_2)
            {
                this.nullable_4 = null;
            }
            if (comboBox_3 == this.comboBox_1)
            {
                this.nullable_2 = null;
            }
        }
    }

    private void method_4()
    {
        DataTable table = new DataTable("tR_Classifier");
        table.Columns.Add("id", typeof(int));
        table.Columns.Add("name", typeof(string));
        base.SelectSqlData(table, true, "where ParentKey = ';TechConnect;TypeDoc;Rebinding;TypeDocInRebinding;' and isGroup = 0 and deleted = 0 order by name", false);
        this.comboBox_0.DisplayMember = "name";
        this.comboBox_0.ValueMember = "id";
        this.comboBox_0.DataSource = table;
        this.comboBox_0.SelectedIndex = -1;
    }

    private void method_5(int int_0)
    {
        DataSetTechConnection.tTC_ChangeOwnershipDataTable table = new DataSetTechConnection.tTC_ChangeOwnershipDataTable();
        base.SelectSqlData(table, true, " where id = " + int_0.ToString(), false);
        if (table.Rows.Count > 0)
        {
            if (table.Rows[0]["idAbnOld"] != DBNull.Value)
            {
                this.nullable_1 = new int?(Convert.ToInt32(table.Rows[0]["idAbnOld"]));
                DataSetTechConnection.tAbnDataTable table2 = new DataSetTechConnection.tAbnDataTable();
                base.SelectSqlData(table2, true, "where id = " + this.nullable_1.ToString(), false);
                if (table2.Rows.Count > 0)
                {
                    this.textBox_2.Text = table2.Rows[0]["name"].ToString();
                }
            }
            if (table.Rows[0]["idAbnObjOld"] != DBNull.Value)
            {
                this.nullable_2 = new int?(Convert.ToInt32(table.Rows[0]["idAbnObjOld"]));
            }
            this.method_3(this.comboBox_1, this.nullable_1);
            if (table.Rows[0]["idAbnNew"] != DBNull.Value)
            {
                this.nullable_3 = new int?(Convert.ToInt32(table.Rows[0]["idAbnNew"]));
                DataSetTechConnection.tAbnDataTable table3 = new DataSetTechConnection.tAbnDataTable();
                base.SelectSqlData(table3, true, "where id = " + this.nullable_3.ToString(), false);
                if (table3.Rows.Count > 0)
                {
                    this.textBox_3.Text = table3.Rows[0]["name"].ToString();
                }
            }
            if (table.Rows[0]["idAbnObjNew"] != DBNull.Value)
            {
                this.nullable_4 = new int?(Convert.ToInt32(table.Rows[0]["idAbnObjNEw"]));
            }
            this.method_3(this.comboBox_2, this.nullable_3);
        }
    }

    private FormBase method_6(object object_0, ShowFormEventArgs showFormEventArgs_0)
    {
        return this.OnShowForm(showFormEventArgs_0);
    }

    private void method_7(object sender, FormClosedEventArgs e)
    {
        FormTechConnectionAddAbn abn = (FormTechConnectionAddAbn) sender;
        if (abn.DialogResult == DialogResult.OK)
        {
            this.textBox_2.Text = abn.AbnName;
            this.nullable_1 = new int?(abn.IdAbn);
            this.nullable_2 = new int?(abn.IdAbnObj);
            this.method_3(this.comboBox_1, this.nullable_1);
            this.bool_0 = true;
        }
    }

    private void method_8(object sender, FormClosedEventArgs e)
    {
        FormTechConnectionAddAbn abn = (FormTechConnectionAddAbn) sender;
        if (abn.DialogResult == DialogResult.OK)
        {
            this.textBox_3.Text = abn.AbnName;
            this.nullable_3 = new int?(abn.IdAbn);
            this.nullable_4 = new int?(abn.IdAbnObj);
            this.method_3(this.comboBox_2, this.nullable_3);
            this.bool_0 = true;
        }
    }

    private bool method_9()
    {
        if (!this.nullable_1.HasValue)
        {
            MessageBox.Show("Не выбран старый абонент");
            return false;
        }
        if (!this.nullable_2.HasValue)
        {
            MessageBox.Show("Не выбран старый объект абонента");
            return false;
        }
        if (!this.nullable_3.HasValue)
        {
            MessageBox.Show("Не выбран новый абонент");
            return false;
        }
        if (!this.nullable_3.HasValue)
        {
            MessageBox.Show("Не выбран новый объект абонента");
            return false;
        }
        return true;
    }

    private void nullableDateTimePicker_0_ValueChanged(object sender, EventArgs e)
    {
        this.bool_0 = true;
    }

    private void richTextBox_0_TextChanged(object sender, EventArgs e)
    {
        this.bool_0 = true;
    }

    private void toolStripButton_0_Click(object sender, EventArgs e)
    {
        FormTechConnectionAddAbn abn1 = new FormTechConnectionAddAbn(!this.nullable_1.HasValue ? -1 : Convert.ToInt32(this.nullable_1), !this.nullable_2.HasValue ? -1 : Convert.ToInt32(this.nullable_2), true);
        abn1.add_ShowForm(new ShowFormEventHandler(this, this.method_6));
        abn1.set_SqlSettings(this.get_SqlSettings());
        abn1.MdiParent = base.MdiParent;
        abn1.FormClosed += new FormClosedEventHandler(this.method_7);
        abn1.Show();
    }

    private void toolStripButton_1_Click(object sender, EventArgs e)
    {
        FormTechConnectionAddAbn abn1 = new FormTechConnectionAddAbn(!this.nullable_3.HasValue ? -1 : Convert.ToInt32(this.nullable_3), !this.nullable_4.HasValue ? -1 : Convert.ToInt32(this.nullable_4), true);
        abn1.add_ShowForm(new ShowFormEventHandler(this, this.method_6));
        abn1.set_SqlSettings(this.get_SqlSettings());
        abn1.MdiParent = base.MdiParent;
        abn1.FormClosed += new FormClosedEventHandler(this.method_8);
        abn1.Show();
    }
}

