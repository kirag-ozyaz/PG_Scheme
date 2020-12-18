using ControlsLbr;
using DailyReport.DataSets;
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
    private bool flgChange;
    private Button buttonOK;
    private Button buttonCancel;
    private ComboBox cmbWindDirect;
    private dsDamage dataSetDamage;
    private DateTimePicker dateTimePicker1;
    private GroupBox groupBox_0;
    private GroupBox groupBox_1;
    private GroupBox groupBox_2;
    private IContainer components = null;
    private Label label_0;
    private Label labelNightOt;
    private Label labelNightDo;
    private Label labelDayDo;
    private Label labelDayOt;
    private Label label_5;
    private Label label_6;
    private Label label_7;
    private Label labelWind;
    private Label label_9;
    private DateTime? dateTemp;
    //[CompilerGenerated]
    //private int? IdTemperature;
    private NullableNumericUpDown txtNightOt;
    private NullableNumericUpDown txtNightDo;
    private NullableNumericUpDown txtDayDo;
    private NullableNumericUpDown txtDayOt;
    private NullableNumericUpDown nullableNumericUpDown5;
    private NullableNumericUpDown nullableNumericUpDown7;
    private NullableNumericUpDown nullableNumericUpDown6;
    private RichTextBox richTextBox1;

    internal FormTemperatureAddEdit(DateTime dateTime)
    {
        this.InitializeComponent();
        this.dateTemp = new DateTime?(dateTime.Date);
        this.dateTimePicker1.Enabled = false;
        this.Text = !this.IdTemperature.HasValue ? "Добавить погоду" : "Редактирование погоды";
    }

    internal FormTemperatureAddEdit(int? idTemperature = new int?())
    {
        this.InitializeComponent();
        this.IdTemperature=(idTemperature);
        this.Text = !this.IdTemperature.HasValue ? "Добавить погоду" : "Редактирование погоды";
    }

    private void buttonOK_Click(object sender, EventArgs e)
    {
        base.Close();
    }

    private void buttonCancel_Click(object sender, EventArgs e)
    {
        base.Close();
    }

    private void cmbWindDirect_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (this.cmbWindDirect.SelectedIndex >= 0)
        {
            this.labelWind.ForeColor = Color.Black;
        }
        this.flgChange = true;
    }

    private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
    {
        this.flgChange = true;
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.components != null))
        {
            this.components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void FormTemperatureAddEdit_FormClosing(object sender, FormClosingEventArgs e)
    {
        if ((base.DialogResult == DialogResult.OK) || (this.flgChange && (MessageBox.Show("Были внесены изменения. Сохранить?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)))
        {
            if (!this.method_3())
            {
                MessageBox.Show("Не заполнены обязательные поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                base.DialogResult = DialogResult.None;
                e.Cancel = true;
            }
            else
            {
                this.dataSetDamage.tJ_Temperature.Rows[0].EndEdit();
                if (!this.IdTemperature.HasValue)
                {
                    this.IdTemperature = (new int?(base.InsertSqlDataOneRow(this.dataSetDamage.tJ_Temperature.Rows[0])));
                    int? id = this.IdTemperature;
                    if (id.HasValue)
                    {
                        id = this.IdTemperature;
                        if (!((id.GetValueOrDefault() < 0) ? id.HasValue : false))
                        {
                            return;
                        }
                    }
                    this.IdTemperature = (null);
                    base.DialogResult = DialogResult.None;
                    e.Cancel = true;
                }
                else if (!base.UpdateSqlData(this.dataSetDamage.tJ_Temperature))
                {
                    base.DialogResult = DialogResult.None;
                    e.Cancel = true;
                }
            }
        }
    }

    private void FormTemperatureAddEdit_Load(object sender, EventArgs e)
    {
        this.getTableClassifier();
        if (!this.IdTemperature.HasValue)
        {
            DataRow row = this.dataSetDamage.tJ_Temperature.NewRow();
            if (this.dateTemp.HasValue)
            {
                row["DateTemp"] = this.dateTemp;
            }
            else
            {
                row["DateTemp"] = DateTime.Now.Date;
            }
            this.dataSetDamage.tJ_Temperature.Rows.Add(row);
        }
        else
        {
            base.SelectSqlData(this.dataSetDamage.tJ_Temperature, true, "where id = " + this.IdTemperature.ToString(), null, false, 0);
        }
        this.flgChange = false;
    }

    public int? IdTemperature { get; set; }

    //[CompilerGenerated]
    //private int? IdTemperature;

    //[CompilerGenerated]
    //internal int? method_0()
    //{
    //    return this.IdTemperature;
    //}

    ////[CompilerGenerated]
    //internal void method_1(int? id)
    //{
    //    this.IdTemperature = id;
    //}


    private void getTableClassifier()
    {
        DataTable table = new DataTable("tR_Classifier");
        table.Columns.Add("id", typeof(int));
        table.Columns.Add("name", typeof(string));
        base.SelectSqlData(table, true, "where ParentKey = ';ReportDaily;WindDirect;' and isGroup = 0 and deleted = 0 order by name", null, false, 0);
        this.cmbWindDirect.DisplayMember = "name";
        this.cmbWindDirect.ValueMember = "id";
        this.cmbWindDirect.DataSource = table;
        this.cmbWindDirect.SelectedIndex = -1;
    }

    private bool method_3()
    {
        bool flag = true;
        if (!this.txtNightOt.Value.HasValue)
        {
            this.labelNightOt.ForeColor = Color.Red;
            flag = false;
        }
        if (!this.txtNightDo.Value.HasValue)
        {
            this.labelNightDo.ForeColor = Color.Red;
            flag = false;
        }
        if (!this.txtDayOt.Value.HasValue)
        {
            this.labelDayOt.ForeColor = Color.Red;
            flag = false;
        }
        if (!this.txtDayDo.Value.HasValue)
        {
            this.labelDayDo.ForeColor = Color.Red;
            flag = false;
        }
        if (this.cmbWindDirect.SelectedIndex == -1)
        {
            this.labelWind.ForeColor = Color.Red;
            flag = false;
        }
        return flag;
    }

    private void InitializeComponent()
    {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataSetDamage = new DailyReport.DataSets.dsDamage();
            this.label_0 = new System.Windows.Forms.Label();
            this.groupBox_0 = new System.Windows.Forms.GroupBox();
            this.txtNightDo = new ControlsLbr.NullableNumericUpDown();
            this.labelNightDo = new System.Windows.Forms.Label();
            this.txtNightOt = new ControlsLbr.NullableNumericUpDown();
            this.labelNightOt = new System.Windows.Forms.Label();
            this.groupBox_1 = new System.Windows.Forms.GroupBox();
            this.txtDayDo = new ControlsLbr.NullableNumericUpDown();
            this.labelDayDo = new System.Windows.Forms.Label();
            this.txtDayOt = new ControlsLbr.NullableNumericUpDown();
            this.labelDayOt = new System.Windows.Forms.Label();
            this.nullableNumericUpDown5 = new ControlsLbr.NullableNumericUpDown();
            this.label_5 = new System.Windows.Forms.Label();
            this.groupBox_2 = new System.Windows.Forms.GroupBox();
            this.nullableNumericUpDown7 = new ControlsLbr.NullableNumericUpDown();
            this.nullableNumericUpDown6 = new ControlsLbr.NullableNumericUpDown();
            this.label_6 = new System.Windows.Forms.Label();
            this.label_7 = new System.Windows.Forms.Label();
            this.cmbWindDirect = new System.Windows.Forms.ComboBox();
            this.labelWind = new System.Windows.Forms.Label();
            this.label_9 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDamage)).BeginInit();
            this.groupBox_0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNightDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNightOt)).BeginInit();
            this.groupBox_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDayDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDayOt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nullableNumericUpDown5)).BeginInit();
            this.groupBox_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nullableNumericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nullableNumericUpDown6)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataSetDamage, "tJ_Temperature.DateTemp", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(91, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(195, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dataSetDamage
            // 
            this.dataSetDamage.DataSetName = "DataSetDamage";
            this.dataSetDamage.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label_0
            // 
            this.label_0.AutoSize = true;
            this.label_0.Location = new System.Drawing.Point(12, 18);
            this.label_0.Name = "label_0";
            this.label_0.Size = new System.Drawing.Size(73, 13);
            this.label_0.TabIndex = 1;
            this.label_0.Text = "Дата погоды";
            // 
            // groupBox_0
            // 
            this.groupBox_0.Controls.Add(this.txtNightDo);
            this.groupBox_0.Controls.Add(this.labelNightDo);
            this.groupBox_0.Controls.Add(this.txtNightOt);
            this.groupBox_0.Controls.Add(this.labelNightOt);
            this.groupBox_0.Location = new System.Drawing.Point(15, 38);
            this.groupBox_0.Name = "groupBox_0";
            this.groupBox_0.Size = new System.Drawing.Size(271, 50);
            this.groupBox_0.TabIndex = 2;
            this.groupBox_0.TabStop = false;
            this.groupBox_0.Text = "Температура ночью";
            // 
            // txtNightDo
            // 
            this.txtNightDo.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataSetDamage, "tJ_Temperature.NightUp", true));
            this.txtNightDo.Location = new System.Drawing.Point(163, 19);
            this.txtNightDo.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.txtNightDo.Name = "txtNightDo";
            this.txtNightDo.Size = new System.Drawing.Size(102, 20);
            this.txtNightDo.TabIndex = 3;
            this.txtNightDo.Value = null;
            this.txtNightDo.ValueChanged += new System.EventHandler(this.nullableNumericUpDown_1_ValueChanged);
            // 
            // labelNightDo
            // 
            this.labelNightDo.AutoSize = true;
            this.labelNightDo.Location = new System.Drawing.Point(137, 25);
            this.labelNightDo.Name = "labelNightDo";
            this.labelNightDo.Size = new System.Drawing.Size(22, 13);
            this.labelNightDo.TabIndex = 2;
            this.labelNightDo.Text = "До";
            // 
            // txtNightOt
            // 
            this.txtNightOt.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataSetDamage, "tJ_Temperature.NightDown", true));
            this.txtNightOt.Location = new System.Drawing.Point(32, 19);
            this.txtNightOt.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.txtNightOt.Name = "txtNightOt";
            this.txtNightOt.Size = new System.Drawing.Size(99, 20);
            this.txtNightOt.TabIndex = 1;
            this.txtNightOt.Value = null;
            this.txtNightOt.ValueChanged += new System.EventHandler(this.txtNightOt_ValueChanged);
            // 
            // labelNightOt
            // 
            this.labelNightOt.AutoSize = true;
            this.labelNightOt.Location = new System.Drawing.Point(6, 25);
            this.labelNightOt.Name = "labelNightOt";
            this.labelNightOt.Size = new System.Drawing.Size(20, 13);
            this.labelNightOt.TabIndex = 0;
            this.labelNightOt.Text = "От";
            // 
            // groupBox_1
            // 
            this.groupBox_1.Controls.Add(this.txtDayDo);
            this.groupBox_1.Controls.Add(this.labelDayDo);
            this.groupBox_1.Controls.Add(this.txtDayOt);
            this.groupBox_1.Controls.Add(this.labelDayOt);
            this.groupBox_1.Location = new System.Drawing.Point(15, 94);
            this.groupBox_1.Name = "groupBox_1";
            this.groupBox_1.Size = new System.Drawing.Size(271, 50);
            this.groupBox_1.TabIndex = 3;
            this.groupBox_1.TabStop = false;
            this.groupBox_1.Text = "Температура днем";
            // 
            // txtDayDo
            // 
            this.txtDayDo.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataSetDamage, "tJ_Temperature.DayUp", true));
            this.txtDayDo.Location = new System.Drawing.Point(163, 19);
            this.txtDayDo.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.txtDayDo.Name = "txtDayDo";
            this.txtDayDo.Size = new System.Drawing.Size(102, 20);
            this.txtDayDo.TabIndex = 3;
            this.txtDayDo.Value = null;
            this.txtDayDo.ValueChanged += new System.EventHandler(this.txtDayDo_ValueChanged);
            // 
            // labelDayDo
            // 
            this.labelDayDo.AutoSize = true;
            this.labelDayDo.Location = new System.Drawing.Point(137, 25);
            this.labelDayDo.Name = "labelDayDo";
            this.labelDayDo.Size = new System.Drawing.Size(22, 13);
            this.labelDayDo.TabIndex = 2;
            this.labelDayDo.Text = "До";
            // 
            // txtDayOt
            // 
            this.txtDayOt.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataSetDamage, "tJ_Temperature.DayDown", true));
            this.txtDayOt.Location = new System.Drawing.Point(32, 19);
            this.txtDayOt.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.txtDayOt.Name = "txtDayOt";
            this.txtDayOt.Size = new System.Drawing.Size(99, 20);
            this.txtDayOt.TabIndex = 1;
            this.txtDayOt.Value = null;
            this.txtDayOt.ValueChanged += new System.EventHandler(this.txtDayOt_ValueChanged);
            // 
            // labelDayOt
            // 
            this.labelDayOt.AutoSize = true;
            this.labelDayOt.Location = new System.Drawing.Point(6, 25);
            this.labelDayOt.Name = "labelDayOt";
            this.labelDayOt.Size = new System.Drawing.Size(20, 13);
            this.labelDayOt.TabIndex = 0;
            this.labelDayOt.Text = "От";
            // 
            // nullableNumericUpDown5
            // 
            this.nullableNumericUpDown5.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataSetDamage, "tJ_Temperature.TempAverage", true));
            this.nullableNumericUpDown5.Location = new System.Drawing.Point(178, 150);
            this.nullableNumericUpDown5.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nullableNumericUpDown5.Name = "nullableNumericUpDown5";
            this.nullableNumericUpDown5.Size = new System.Drawing.Size(108, 20);
            this.nullableNumericUpDown5.TabIndex = 5;
            this.nullableNumericUpDown5.Value = null;
            this.nullableNumericUpDown5.ValueChanged += new System.EventHandler(this.nullableNumericUpDown6_ValueChanged);
            // 
            // label_5
            // 
            this.label_5.AutoSize = true;
            this.label_5.Location = new System.Drawing.Point(12, 152);
            this.label_5.Name = "label_5";
            this.label_5.Size = new System.Drawing.Size(157, 13);
            this.label_5.TabIndex = 6;
            this.label_5.Text = "Среднесуточная температура";
            // 
            // groupBox_2
            // 
            this.groupBox_2.Controls.Add(this.nullableNumericUpDown7);
            this.groupBox_2.Controls.Add(this.nullableNumericUpDown6);
            this.groupBox_2.Controls.Add(this.label_6);
            this.groupBox_2.Controls.Add(this.label_7);
            this.groupBox_2.Controls.Add(this.cmbWindDirect);
            this.groupBox_2.Controls.Add(this.labelWind);
            this.groupBox_2.Location = new System.Drawing.Point(15, 176);
            this.groupBox_2.Name = "groupBox_2";
            this.groupBox_2.Size = new System.Drawing.Size(271, 97);
            this.groupBox_2.TabIndex = 7;
            this.groupBox_2.TabStop = false;
            this.groupBox_2.Text = "Ветер";
            // 
            // nullableNumericUpDown7
            // 
            this.nullableNumericUpDown7.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataSetDamage, "tJ_Temperature.SpeedUp", true));
            this.nullableNumericUpDown7.Location = new System.Drawing.Point(145, 65);
            this.nullableNumericUpDown7.Name = "nullableNumericUpDown7";
            this.nullableNumericUpDown7.Size = new System.Drawing.Size(120, 20);
            this.nullableNumericUpDown7.TabIndex = 5;
            this.nullableNumericUpDown7.Value = null;
            this.nullableNumericUpDown7.ValueChanged += new System.EventHandler(this.nullableNumericUpDown6_ValueChanged);
            // 
            // nullableNumericUpDown6
            // 
            this.nullableNumericUpDown6.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataSetDamage, "tJ_Temperature.SpeedDown", true));
            this.nullableNumericUpDown6.Location = new System.Drawing.Point(9, 65);
            this.nullableNumericUpDown6.Name = "nullableNumericUpDown6";
            this.nullableNumericUpDown6.Size = new System.Drawing.Size(120, 20);
            this.nullableNumericUpDown6.TabIndex = 4;
            this.nullableNumericUpDown6.Value = null;
            this.nullableNumericUpDown6.ValueChanged += new System.EventHandler(this.nullableNumericUpDown6_ValueChanged);
            // 
            // label_6
            // 
            this.label_6.AutoSize = true;
            this.label_6.Location = new System.Drawing.Point(142, 49);
            this.label_6.Name = "label_6";
            this.label_6.Size = new System.Drawing.Size(98, 13);
            this.label_6.TabIndex = 3;
            this.label_6.Text = "Скорость до (м/с)";
            // 
            // label_7
            // 
            this.label_7.AutoSize = true;
            this.label_7.Location = new System.Drawing.Point(6, 49);
            this.label_7.Name = "label_7";
            this.label_7.Size = new System.Drawing.Size(97, 13);
            this.label_7.TabIndex = 2;
            this.label_7.Text = "Скорость от (м/с)";
            // 
            // cmbWindDirect
            // 
            this.cmbWindDirect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbWindDirect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbWindDirect.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetDamage, "tJ_Temperature.Wind", true));
            this.cmbWindDirect.FormattingEnabled = true;
            this.cmbWindDirect.Location = new System.Drawing.Point(87, 19);
            this.cmbWindDirect.Name = "cmbWindDirect";
            this.cmbWindDirect.Size = new System.Drawing.Size(178, 21);
            this.cmbWindDirect.TabIndex = 1;
            this.cmbWindDirect.SelectedIndexChanged += new System.EventHandler(this.cmbWindDirect_SelectedIndexChanged);
            // 
            // labelWind
            // 
            this.labelWind.AutoSize = true;
            this.labelWind.Location = new System.Drawing.Point(6, 22);
            this.labelWind.Name = "labelWind";
            this.labelWind.Size = new System.Drawing.Size(75, 13);
            this.labelWind.TabIndex = 0;
            this.labelWind.Text = "Направление";
            // 
            // label_9
            // 
            this.label_9.AutoSize = true;
            this.label_9.Location = new System.Drawing.Point(21, 276);
            this.label_9.Name = "label_9";
            this.label_9.Size = new System.Drawing.Size(70, 13);
            this.label_9.TabIndex = 8;
            this.label_9.Text = "Примечание";
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetDamage, "tJ_Temperature.Comment", true));
            this.richTextBox1.Location = new System.Drawing.Point(15, 292);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(271, 82);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Tag = "";
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox_0_TextChanged);
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(15, 383);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(211, 383);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormTemperatureAddEdit
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(295, 415);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label_9);
            this.Controls.Add(this.groupBox_2);
            this.Controls.Add(this.label_5);
            this.Controls.Add(this.nullableNumericUpDown5);
            this.Controls.Add(this.groupBox_1);
            this.Controls.Add(this.groupBox_0);
            this.Controls.Add(this.label_0);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "FormTemperatureAddEdit";
            this.Text = "FormTemperatureAddEDit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTemperatureAddEdit_FormClosing);
            this.Load += new System.EventHandler(this.FormTemperatureAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDamage)).EndInit();
            this.groupBox_0.ResumeLayout(false);
            this.groupBox_0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNightDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNightOt)).EndInit();
            this.groupBox_1.ResumeLayout(false);
            this.groupBox_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDayDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDayOt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nullableNumericUpDown5)).EndInit();
            this.groupBox_2.ResumeLayout(false);
            this.groupBox_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nullableNumericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nullableNumericUpDown6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void txtNightOt_ValueChanged(object sender, EventArgs e)
    {
        this.flgChange = true;
        if (this.txtNightOt.Value.HasValue)
        {
            this.labelNightOt.ForeColor = Color.Black;
        }
    }

    private void nullableNumericUpDown_1_ValueChanged(object sender, EventArgs e)
    {
        this.flgChange = true;
        if (this.txtNightDo.Value.HasValue)
        {
            this.labelNightDo.ForeColor = Color.Black;
        }
    }

    private void txtDayDo_ValueChanged(object sender, EventArgs e)
    {
        this.flgChange = true;
        if (this.txtDayDo.Value.HasValue)
        {
            this.labelDayDo.ForeColor = Color.Black;
        }
    }

    private void txtDayOt_ValueChanged(object sender, EventArgs e)
    {
        this.flgChange = true;
        if (this.txtDayOt.Value.HasValue)
        {
            this.labelDayOt.ForeColor = Color.Black;
        }
    }

    private void nullableNumericUpDown6_ValueChanged(object sender, EventArgs e)
    {
        this.flgChange = true;
    }

    private void richTextBox_0_TextChanged(object sender, EventArgs e)
    {
        this.flgChange = true;
    }
}

