using ControlsLbr;
using Documents.Forms.DailyReport.DataSets;
using FormLbr;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

internal class FormTemperatureAddEdit : FormBase
{
    private bool bool_0;
    private Button button_0;
    private Button button_1;
    private ComboBox comboBox_0;
    private DataSetDamage dataSetDamage_0;
    private DateTimePicker dateTimePicker_0;
    private GroupBox groupBox_0;
    private GroupBox groupBox_1;
    private GroupBox groupBox_2;
    private IContainer components = null;
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
    private DateTime? nullable_0;
    [CompilerGenerated]
    private int? nullable_1;
    private NullableNumericUpDown nullableNumericUpDown_0;
    private NullableNumericUpDown nullableNumericUpDown_1;
    private NullableNumericUpDown nullableNumericUpDown_2;
    private NullableNumericUpDown nullableNumericUpDown_3;
    private NullableNumericUpDown nullableNumericUpDown_4;
    private NullableNumericUpDown nullableNumericUpDown_5;
    private NullableNumericUpDown nullableNumericUpDown_6;
    private RichTextBox richTextBox_0;

    internal FormTemperatureAddEdit(DateTime dateTime_0)
    {
        this.InitializeComponent();
        this.nullable_0 = new DateTime?(dateTime_0.Date);
        this.dateTimePicker_0.Enabled = false;
        this.Text = !this.method_0().HasValue ? "Добавить погоду" : "Редактирование погоды";
    }

    internal FormTemperatureAddEdit(int? nullable_2 = new int?())
    {
        this.InitializeComponent();
        this.method_1(nullable_2);
        this.Text = !this.method_0().HasValue ? "Добавить погоду" : "Редактирование погоды";
    }

    private void button_0_Click(object sender, EventArgs e)
    {
        base.Close();
    }

    private void button_1_Click(object sender, EventArgs e)
    {
        base.Close();
    }

    private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (this.comboBox_0.SelectedIndex >= 0)
        {
            this.label_8.ForeColor = Color.Black;
        }
        this.bool_0 = true;
    }

    private void dateTimePicker_0_ValueChanged(object sender, EventArgs e)
    {
        this.bool_0 = true;
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.components != null))
        {
            this.components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void Form51_FormClosing(object sender, FormClosingEventArgs e)
    {
        if ((base.DialogResult == DialogResult.OK) || (this.bool_0 && (MessageBox.Show("Были внесены изменения. Сохранить?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)))
        {
            if (!this.method_3())
            {
                MessageBox.Show("Не заполнены обязательные поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                base.DialogResult = DialogResult.None;
                e.Cancel = true;
            }
            else
            {
                this.dataSetDamage_0.tJ_Temperature.Rows[0].EndEdit();
                if (!this.method_0().HasValue)
                {
                    this.method_1(new int?(base.InsertSqlDataOneRow(this.dataSetDamage_0.tJ_Temperature.Rows[0])));
                    int? nullable = this.method_0();
                    if (nullable.HasValue)
                    {
                        nullable = this.method_0();
                        if (!((nullable.GetValueOrDefault() < 0) ? nullable.HasValue : false))
                        {
                            return;
                        }
                    }
                    this.method_1(null);
                    base.DialogResult = DialogResult.None;
                    e.Cancel = true;
                }
                else if (!base.UpdateSqlData(this.dataSetDamage_0.tJ_Temperature))
                {
                    base.DialogResult = DialogResult.None;
                    e.Cancel = true;
                }
            }
        }
    }

    private void Form51_Load(object sender, EventArgs e)
    {
        this.method_2();
        if (!this.method_0().HasValue)
        {
            DataRow row = this.dataSetDamage_0.tJ_Temperature.NewRow();
            if (this.nullable_0.HasValue)
            {
                row["DateTemp"] = this.nullable_0;
            }
            else
            {
                row["DateTemp"] = DateTime.Now.Date;
            }
            this.dataSetDamage_0.tJ_Temperature.Rows.Add(row);
        }
        else
        {
            base.SelectSqlData(this.dataSetDamage_0.tJ_Temperature, true, "where id = " + this.method_0().ToString(), null, false, 0);
        }
        this.bool_0 = false;
    }

    [CompilerGenerated]
    internal int? method_0()
    {
        return this.nullable_1;
    }

    [CompilerGenerated]
    internal void method_1(int? nullable_2)
    {
        this.nullable_1 = nullable_2;
    }

    private void method_2()
    {
        DataTable table = new DataTable("tR_Classifier");
        table.Columns.Add("id", typeof(int));
        table.Columns.Add("name", typeof(string));
        base.SelectSqlData(table, true, "where ParentKey = ';ReportDaily;WindDirect;' and isGroup = 0 and deleted = 0 order by name", null, false, 0);
        this.comboBox_0.DisplayMember = "name";
        this.comboBox_0.ValueMember = "id";
        this.comboBox_0.DataSource = table;
        this.comboBox_0.SelectedIndex = -1;
    }

    private bool method_3()
    {
        bool flag = true;
        if (!this.nullableNumericUpDown_0.Value.HasValue)
        {
            this.label_1.ForeColor = Color.Red;
            flag = false;
        }
        if (!this.nullableNumericUpDown_1.Value.HasValue)
        {
            this.label_2.ForeColor = Color.Red;
            flag = false;
        }
        if (!this.nullableNumericUpDown_3.Value.HasValue)
        {
            this.label_4.ForeColor = Color.Red;
            flag = false;
        }
        if (!this.nullableNumericUpDown_2.Value.HasValue)
        {
            this.label_3.ForeColor = Color.Red;
            flag = false;
        }
        if (this.comboBox_0.SelectedIndex == -1)
        {
            this.label_8.ForeColor = Color.Red;
            flag = false;
        }
        return flag;
    }

    private void InitializeComponent()
    {
        this.dateTimePicker_0 = new DateTimePicker();
        this.dataSetDamage_0 = new DataSetDamage();
        this.label_0 = new Label();
        this.groupBox_0 = new GroupBox();
        this.nullableNumericUpDown_1 = new NullableNumericUpDown();
        this.label_2 = new Label();
        this.nullableNumericUpDown_0 = new NullableNumericUpDown();
        this.label_1 = new Label();
        this.groupBox_1 = new GroupBox();
        this.nullableNumericUpDown_2 = new NullableNumericUpDown();
        this.label_3 = new Label();
        this.nullableNumericUpDown_3 = new NullableNumericUpDown();
        this.label_4 = new Label();
        this.nullableNumericUpDown_4 = new NullableNumericUpDown();
        this.label_5 = new Label();
        this.groupBox_2 = new GroupBox();
        this.nullableNumericUpDown_5 = new NullableNumericUpDown();
        this.nullableNumericUpDown_6 = new NullableNumericUpDown();
        this.label_6 = new Label();
        this.label_7 = new Label();
        this.comboBox_0 = new ComboBox();
        this.label_8 = new Label();
        this.label_9 = new Label();
        this.richTextBox_0 = new RichTextBox();
        this.button_0 = new Button();
        this.button_1 = new Button();
        this.dataSetDamage_0.BeginInit();
        this.groupBox_0.SuspendLayout();
        this.nullableNumericUpDown_1.BeginInit();
        this.nullableNumericUpDown_0.BeginInit();
        this.groupBox_1.SuspendLayout();
        this.nullableNumericUpDown_2.BeginInit();
        this.nullableNumericUpDown_3.BeginInit();
        this.nullableNumericUpDown_4.BeginInit();
        this.groupBox_2.SuspendLayout();
        this.nullableNumericUpDown_5.BeginInit();
        this.nullableNumericUpDown_6.BeginInit();
        base.SuspendLayout();
        this.dateTimePicker_0.DataBindings.Add(new Binding("Value", this.dataSetDamage_0, "tJ_Temperature.DateTemp", true));
        this.dateTimePicker_0.Location = new Point(0x5b, 12);
        this.dateTimePicker_0.Name = "dateTimePicker1";
        this.dateTimePicker_0.Size = new Size(0xc3, 20);
        this.dateTimePicker_0.TabIndex = 0;
        this.dateTimePicker_0.ValueChanged += new EventHandler(this.dateTimePicker_0_ValueChanged);
        this.dataSetDamage_0.DataSetName = "DataSetDamage";
        this.dataSetDamage_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        this.label_0.AutoSize = true;
        this.label_0.Location = new Point(12, 0x12);
        this.label_0.Name = "label1";
        this.label_0.Size = new Size(0x49, 13);
        this.label_0.TabIndex = 1;
        this.label_0.Text = "Дата погоды";
        this.groupBox_0.Controls.Add(this.nullableNumericUpDown_1);
        this.groupBox_0.Controls.Add(this.label_2);
        this.groupBox_0.Controls.Add(this.nullableNumericUpDown_0);
        this.groupBox_0.Controls.Add(this.label_1);
        this.groupBox_0.Location = new Point(15, 0x26);
        this.groupBox_0.Name = "groupBox1";
        this.groupBox_0.Size = new Size(0x10f, 50);
        this.groupBox_0.TabIndex = 2;
        this.groupBox_0.TabStop = false;
        this.groupBox_0.Text = "Температура ночью";
        this.nullableNumericUpDown_1.DataBindings.Add(new Binding("Value", this.dataSetDamage_0, "tJ_Temperature.NightUp", true));
        this.nullableNumericUpDown_1.Location = new Point(0xa3, 0x13);
        int[] bits = new int[4];
        bits[0] = 100;
        bits[3] = -2147483648;
        this.nullableNumericUpDown_1.Minimum = new decimal(bits);
        this.nullableNumericUpDown_1.Name = "txtNightDo";
        this.nullableNumericUpDown_1.Size = new Size(0x66, 20);
        this.nullableNumericUpDown_1.TabIndex = 3;
        //decimal? nullable = null;
        this.nullableNumericUpDown_1.Value = null;
        this.nullableNumericUpDown_1.ValueChanged += new EventHandler(this.nullableNumericUpDown_1_ValueChanged);
        this.label_2.AutoSize = true;
        this.label_2.Location = new Point(0x89, 0x19);
        this.label_2.Name = "labelNightDo";
        this.label_2.Size = new Size(0x16, 13);
        this.label_2.TabIndex = 2;
        this.label_2.Text = "До";
        this.nullableNumericUpDown_0.DataBindings.Add(new Binding("Value", this.dataSetDamage_0, "tJ_Temperature.NightDown", true));
        this.nullableNumericUpDown_0.Location = new Point(0x20, 0x13);
        int[] numArray2 = new int[4];
        numArray2[0] = 100;
        numArray2[3] = -2147483648;
        this.nullableNumericUpDown_0.Minimum = new decimal(numArray2);
        this.nullableNumericUpDown_0.Name = "txtNightOt";
        this.nullableNumericUpDown_0.Size = new Size(0x63, 20);
        this.nullableNumericUpDown_0.TabIndex = 1;
        //nullable = null;
        this.nullableNumericUpDown_0.Value = null;
        this.nullableNumericUpDown_0.ValueChanged += new EventHandler(this.nullableNumericUpDown_0_ValueChanged);
        this.label_1.AutoSize = true;
        this.label_1.Location = new Point(6, 0x19);
        this.label_1.Name = "labelNightOt";
        this.label_1.Size = new Size(20, 13);
        this.label_1.TabIndex = 0;
        this.label_1.Text = "От";
        this.groupBox_1.Controls.Add(this.nullableNumericUpDown_2);
        this.groupBox_1.Controls.Add(this.label_3);
        this.groupBox_1.Controls.Add(this.nullableNumericUpDown_3);
        this.groupBox_1.Controls.Add(this.label_4);
        this.groupBox_1.Location = new Point(15, 0x5e);
        this.groupBox_1.Name = "groupBox2";
        this.groupBox_1.Size = new Size(0x10f, 50);
        this.groupBox_1.TabIndex = 3;
        this.groupBox_1.TabStop = false;
        this.groupBox_1.Text = "Температура днем";
        this.nullableNumericUpDown_2.DataBindings.Add(new Binding("Value", this.dataSetDamage_0, "tJ_Temperature.DayUp", true));
        this.nullableNumericUpDown_2.Location = new Point(0xa3, 0x13);
        int[] numArray3 = new int[4];
        numArray3[0] = 100;
        numArray3[3] = -2147483648;
        this.nullableNumericUpDown_2.Minimum = new decimal(numArray3);
        this.nullableNumericUpDown_2.Name = "txtDayDo";
        this.nullableNumericUpDown_2.Size = new Size(0x66, 20);
        this.nullableNumericUpDown_2.TabIndex = 3;
        //nullable = null;
        this.nullableNumericUpDown_2.Value = null;
        this.nullableNumericUpDown_2.ValueChanged += new EventHandler(this.nullableNumericUpDown_2_ValueChanged);
        this.label_3.AutoSize = true;
        this.label_3.Location = new Point(0x89, 0x19);
        this.label_3.Name = "labelDayDo";
        this.label_3.Size = new Size(0x16, 13);
        this.label_3.TabIndex = 2;
        this.label_3.Text = "До";
        this.nullableNumericUpDown_3.DataBindings.Add(new Binding("Value", this.dataSetDamage_0, "tJ_Temperature.DayDown", true));
        this.nullableNumericUpDown_3.Location = new Point(0x20, 0x13);
        int[] numArray4 = new int[4];
        numArray4[0] = 100;
        numArray4[3] = -2147483648;
        this.nullableNumericUpDown_3.Minimum = new decimal(numArray4);
        this.nullableNumericUpDown_3.Name = "txtDayOt";
        this.nullableNumericUpDown_3.Size = new Size(0x63, 20);
        this.nullableNumericUpDown_3.TabIndex = 1;
        //nullable = null;
        this.nullableNumericUpDown_3.Value = null;
        this.nullableNumericUpDown_3.ValueChanged += new EventHandler(this.nullableNumericUpDown_3_ValueChanged);
        this.label_4.AutoSize = true;
        this.label_4.Location = new Point(6, 0x19);
        this.label_4.Name = "labelDayOt";
        this.label_4.Size = new Size(20, 13);
        this.label_4.TabIndex = 0;
        this.label_4.Text = "От";
        this.nullableNumericUpDown_4.DataBindings.Add(new Binding("Value", this.dataSetDamage_0, "tJ_Temperature.TempAverage", true));
        this.nullableNumericUpDown_4.Location = new Point(0xb2, 150);
        int[] numArray5 = new int[4];
        numArray5[0] = 100;
        numArray5[3] = -2147483648;
        this.nullableNumericUpDown_4.Minimum = new decimal(numArray5);
        this.nullableNumericUpDown_4.Name = "nullableNumericUpDown5";
        this.nullableNumericUpDown_4.Size = new Size(0x6c, 20);
        this.nullableNumericUpDown_4.TabIndex = 5;
        //nullable = null;
        this.nullableNumericUpDown_4.Value = null;
        this.nullableNumericUpDown_4.ValueChanged += new EventHandler(this.nullableNumericUpDown_6_ValueChanged);
        this.label_5.AutoSize = true;
        this.label_5.Location = new Point(12, 0x98);
        this.label_5.Name = "label6";
        this.label_5.Size = new Size(0x9d, 13);
        this.label_5.TabIndex = 6;
        this.label_5.Text = "Среднесуточная температура";
        this.groupBox_2.Controls.Add(this.nullableNumericUpDown_5);
        this.groupBox_2.Controls.Add(this.nullableNumericUpDown_6);
        this.groupBox_2.Controls.Add(this.label_6);
        this.groupBox_2.Controls.Add(this.label_7);
        this.groupBox_2.Controls.Add(this.comboBox_0);
        this.groupBox_2.Controls.Add(this.label_8);
        this.groupBox_2.Location = new Point(15, 0xb0);
        this.groupBox_2.Name = "groupBox3";
        this.groupBox_2.Size = new Size(0x10f, 0x61);
        this.groupBox_2.TabIndex = 7;
        this.groupBox_2.TabStop = false;
        this.groupBox_2.Text = "Ветер";
        this.nullableNumericUpDown_5.DataBindings.Add(new Binding("Value", this.dataSetDamage_0, "tJ_Temperature.SpeedUp", true));
        this.nullableNumericUpDown_5.Location = new Point(0x91, 0x41);
        this.nullableNumericUpDown_5.Name = "nullableNumericUpDown7";
        this.nullableNumericUpDown_5.Size = new Size(120, 20);
        this.nullableNumericUpDown_5.TabIndex = 5;
        //nullable = null;
        this.nullableNumericUpDown_5.Value = null;
        this.nullableNumericUpDown_5.ValueChanged += new EventHandler(this.nullableNumericUpDown_6_ValueChanged);
        this.nullableNumericUpDown_6.DataBindings.Add(new Binding("Value", this.dataSetDamage_0, "tJ_Temperature.SpeedDown", true));
        this.nullableNumericUpDown_6.Location = new Point(9, 0x41);
        this.nullableNumericUpDown_6.Name = "nullableNumericUpDown6";
        this.nullableNumericUpDown_6.Size = new Size(120, 20);
        this.nullableNumericUpDown_6.TabIndex = 4;
        this.nullableNumericUpDown_6.Value = null;
        this.nullableNumericUpDown_6.ValueChanged += new EventHandler(this.nullableNumericUpDown_6_ValueChanged);
        this.label_6.AutoSize = true;
        this.label_6.Location = new Point(0x8e, 0x31);
        this.label_6.Name = "label9";
        this.label_6.Size = new Size(0x62, 13);
        this.label_6.TabIndex = 3;
        this.label_6.Text = "Скорость до (м/с)";
        this.label_7.AutoSize = true;
        this.label_7.Location = new Point(6, 0x31);
        this.label_7.Name = "label8";
        this.label_7.Size = new Size(0x61, 13);
        this.label_7.TabIndex = 2;
        this.label_7.Text = "Скорость от (м/с)";
        this.comboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        this.comboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
        this.comboBox_0.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage_0, "tJ_Temperature.Wind", true));
        this.comboBox_0.FormattingEnabled = true;
        this.comboBox_0.Location = new Point(0x57, 0x13);
        this.comboBox_0.Name = "cmbWindDirect";
        this.comboBox_0.Size = new Size(0xb2, 0x15);
        this.comboBox_0.TabIndex = 1;
        this.comboBox_0.SelectedIndexChanged += new EventHandler(this.comboBox_0_SelectedIndexChanged);
        this.label_8.AutoSize = true;
        this.label_8.Location = new Point(6, 0x16);
        this.label_8.Name = "labelWind";
        this.label_8.Size = new Size(0x4b, 13);
        this.label_8.TabIndex = 0;
        this.label_8.Text = "Направление";
        this.label_9.AutoSize = true;
        this.label_9.Location = new Point(0x15, 0x114);
        this.label_9.Name = "label10";
        this.label_9.Size = new Size(70, 13);
        this.label_9.TabIndex = 8;
        this.label_9.Text = "Примечание";
        this.richTextBox_0.AcceptsTab = true;
        this.richTextBox_0.DataBindings.Add(new Binding("Text", this.dataSetDamage_0, "tJ_Temperature.Comment", true));
        this.richTextBox_0.Location = new Point(15, 0x124);
        this.richTextBox_0.Name = "richTextBox1";
        this.richTextBox_0.Size = new Size(0x10f, 0x52);
        this.richTextBox_0.TabIndex = 9;
        this.richTextBox_0.Text = "";
        this.richTextBox_0.TextChanged += new EventHandler(this.richTextBox_0_TextChanged);
        this.button_0.DialogResult = DialogResult.OK;
        this.button_0.Location = new Point(15, 0x17f);
        this.button_0.Name = "buttonOK";
        this.button_0.Size = new Size(0x4b, 0x17);
        this.button_0.TabIndex = 10;
        this.button_0.Text = "ОК";
        this.button_0.UseVisualStyleBackColor = true;
        this.button_0.Click += new EventHandler(this.button_0_Click);
        this.button_1.DialogResult = DialogResult.Cancel;
        this.button_1.Location = new Point(0xd3, 0x17f);
        this.button_1.Name = "buttonCancel";
        this.button_1.Size = new Size(0x4b, 0x17);
        this.button_1.TabIndex = 11;
        this.button_1.Text = "Отмена";
        this.button_1.UseVisualStyleBackColor = true;
        this.button_1.Click += new EventHandler(this.button_1_Click);
        base.AcceptButton = this.button_0;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.CancelButton = this.button_1;
        base.ClientSize = new Size(0x127, 0x19f);
        base.Controls.Add(this.button_1);
        base.Controls.Add(this.button_0);
        base.Controls.Add(this.richTextBox_0);
        base.Controls.Add(this.label_9);
        base.Controls.Add(this.groupBox_2);
        base.Controls.Add(this.label_5);
        base.Controls.Add(this.nullableNumericUpDown_4);
        base.Controls.Add(this.groupBox_1);
        base.Controls.Add(this.groupBox_0);
        base.Controls.Add(this.label_0);
        base.Controls.Add(this.dateTimePicker_0);
        base.Name = "FormTemperatureAddEdit";
        this.Text = "FormTemperatureAddEDit";
        base.FormClosing += new FormClosingEventHandler(this.Form51_FormClosing);
        base.Load += new EventHandler(this.Form51_Load);
        this.dataSetDamage_0.EndInit();
        this.groupBox_0.ResumeLayout(false);
        this.groupBox_0.PerformLayout();
        this.nullableNumericUpDown_1.EndInit();
        this.nullableNumericUpDown_0.EndInit();
        this.groupBox_1.ResumeLayout(false);
        this.groupBox_1.PerformLayout();
        this.nullableNumericUpDown_2.EndInit();
        this.nullableNumericUpDown_3.EndInit();
        this.nullableNumericUpDown_4.EndInit();
        this.groupBox_2.ResumeLayout(false);
        this.groupBox_2.PerformLayout();
        this.nullableNumericUpDown_5.EndInit();
        this.nullableNumericUpDown_6.EndInit();
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    private void nullableNumericUpDown_0_ValueChanged(object sender, EventArgs e)
    {
        this.bool_0 = true;
        if (this.nullableNumericUpDown_0.Value.HasValue)
        {
            this.label_1.ForeColor = Color.Black;
        }
    }

    private void nullableNumericUpDown_1_ValueChanged(object sender, EventArgs e)
    {
        this.bool_0 = true;
        if (this.nullableNumericUpDown_1.Value.HasValue)
        {
            this.label_2.ForeColor = Color.Black;
        }
    }

    private void nullableNumericUpDown_2_ValueChanged(object sender, EventArgs e)
    {
        this.bool_0 = true;
        if (this.nullableNumericUpDown_2.Value.HasValue)
        {
            this.label_3.ForeColor = Color.Black;
        }
    }

    private void nullableNumericUpDown_3_ValueChanged(object sender, EventArgs e)
    {
        this.bool_0 = true;
        if (this.nullableNumericUpDown_3.Value.HasValue)
        {
            this.label_4.ForeColor = Color.Black;
        }
    }

    private void nullableNumericUpDown_6_ValueChanged(object sender, EventArgs e)
    {
        this.bool_0 = true;
    }

    private void richTextBox_0_TextChanged(object sender, EventArgs e)
    {
        this.bool_0 = true;
    }
}

