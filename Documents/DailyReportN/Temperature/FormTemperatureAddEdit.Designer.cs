using ControlsLbr;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

internal partial class FormTemperatureAddEdit : FormLbr.FormBase
{
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.components != null)
		{
			this.components.Dispose();
		}
		base.Dispose(disposing);
	}

	private System.ComponentModel.IContainer components=null;
    private void InitializeComponent()
    {
        this.dateTimePickerWeather = new DateTimePicker();
        this.dsDamage = new DailyReportN.DataSet.dsDamage();
        this.label1 = new Label();
        this.groupBox1 = new GroupBox();
        this.txtNightDo = new NullableNumericUpDown();
        this.labelNightDo = new Label();
        this.txtNightOt = new NullableNumericUpDown();
        this.labelNightOt = new Label();
        this.groupBox2 = new GroupBox();
        this.txtDayDo = new NullableNumericUpDown();
        this.labelDayDo = new Label();
        this.txtDayOt = new NullableNumericUpDown();
        this.labelDayOt = new Label();
        this.nullableNumericUpDown5 = new NullableNumericUpDown();
        this.label6 = new Label();
        this.groupBox3 = new GroupBox();
        this.nullableNumericUpDown7 = new NullableNumericUpDown();
        this.nullableNumericUpDown6 = new NullableNumericUpDown();
        this.label9 = new Label();
        this.label8 = new Label();
        this.cmbWindDirect = new ComboBox();
        this.labelWind = new Label();
        this.label10 = new Label();
        this.richTextBox1 = new RichTextBox();
        this.buttonOK = new Button();
        this.buttonCancel = new Button();
        ((ISupportInitialize)this.dsDamage).BeginInit();
        this.groupBox1.SuspendLayout();
        ((ISupportInitialize)this.txtNightDo).BeginInit();
        ((ISupportInitialize)this.txtNightOt).BeginInit();
        this.groupBox2.SuspendLayout();
        ((ISupportInitialize)this.txtDayDo).BeginInit();
        ((ISupportInitialize)this.txtDayOt).BeginInit();
        ((ISupportInitialize)this.nullableNumericUpDown5).BeginInit();
        this.groupBox3.SuspendLayout();
        ((ISupportInitialize)this.nullableNumericUpDown7).BeginInit();
        ((ISupportInitialize)this.nullableNumericUpDown6).BeginInit();
        base.SuspendLayout();
        this.dateTimePickerWeather.DataBindings.Add(new Binding("Value", this.dsDamage, "tJ_Temperature.DateTemp", true));
        this.dateTimePickerWeather.Location = new Point(91, 12);
        this.dateTimePickerWeather.Name = "datePogoda";
        this.dateTimePickerWeather.Size = new Size(195, 20);
        this.dateTimePickerWeather.TabIndex = 0;
        this.dateTimePickerWeather.ValueChanged +=new System.EventHandler( this.dateTimePickerWeather_ValueChanged);
        this.dsDamage.DataSetName = "dstDamage";
        this.dsDamage.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        this.label1.AutoSize = true;
        this.label1.Location = new Point(12, 18);
        this.label1.Name = "label1";
        this.label1.Size = new Size(73, 13);
        this.label1.TabIndex = 1;
        this.label1.Text = "Дата погоды";
        this.groupBox1.Controls.Add(this.txtNightDo);
        this.groupBox1.Controls.Add(this.labelNightDo);
        this.groupBox1.Controls.Add(this.txtNightOt);
        this.groupBox1.Controls.Add(this.labelNightOt);
        this.groupBox1.Location = new Point(15, 38);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new Size(271, 50);
        this.groupBox1.TabIndex = 2;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Температура ночью";
        this.txtNightDo.DataBindings.Add(new Binding("Value", this.dsDamage, "tJ_Temperature.NightUp", true));
        this.txtNightDo.Location = new Point(163, 19);
        this.txtNightDo.Minimum = new decimal(new int[]
        {
            100,
            0,
            0,
            int.MinValue
        });
        this.txtNightDo.Name = "txtNightDo";
        this.txtNightDo.Size = new Size(102, 20);
        this.txtNightDo.TabIndex = 3;
        this.txtNightDo.Value = null;
        this.txtNightDo.ValueChanged +=new System.EventHandler (this.txtNightDo_ValueChanged);
        this.labelNightDo.AutoSize = true;
        this.labelNightDo.Location = new Point(137, 25);
        this.labelNightDo.Name = "labelNightDo";
        this.labelNightDo.Size = new Size(22, 13);
        this.labelNightDo.TabIndex = 2;
        this.labelNightDo.Text = "До";
        this.txtNightOt.DataBindings.Add(new Binding("Value", this.dsDamage, "tJ_Temperature.NightDown", true));
        this.txtNightOt.Location = new Point(32, 19);
        this.txtNightOt.Minimum = new decimal(new int[]
        {
            100,
            0,
            0,
            int.MinValue
        });
        this.txtNightOt.Name = "txtNightOt";
        this.txtNightOt.Size = new Size(99, 20);
        this.txtNightOt.TabIndex = 1;
        this.txtNightOt.Value = null;
        this.txtNightOt.ValueChanged +=new System.EventHandler( this.txtNightOt_ValueChanged);
        this.labelNightOt.AutoSize = true;
        this.labelNightOt.Location = new Point(6, 25);
        this.labelNightOt.Name = "labelNightOt";
        this.labelNightOt.Size = new Size(20, 13);
        this.labelNightOt.TabIndex = 0;
        this.labelNightOt.Text = "От";
        this.groupBox2.Controls.Add(this.txtDayDo);
        this.groupBox2.Controls.Add(this.labelDayDo);
        this.groupBox2.Controls.Add(this.txtDayOt);
        this.groupBox2.Controls.Add(this.labelDayOt);
        this.groupBox2.Location = new Point(15, 94);
        this.groupBox2.Name = "groupBox2";
        this.groupBox2.Size = new Size(271, 50);
        this.groupBox2.TabIndex = 3;
        this.groupBox2.TabStop = false;
        this.groupBox2.Text = "Температура днем";
        this.txtDayDo.DataBindings.Add(new Binding("Value", this.dsDamage, "tJ_Temperature.DayUp", true));
        this.txtDayDo.Location = new Point(163, 19);
        this.txtDayDo.Minimum = new decimal(new int[]
        {
            100,
            0,
            0,
            int.MinValue
        });
        this.txtDayDo.Name = "txtDayDo";
        this.txtDayDo.Size = new Size(102, 20);
        this.txtDayDo.TabIndex = 3;
        this.txtDayDo.Value = null;
        this.txtDayDo.ValueChanged +=new System.EventHandler (this.txtDayDo_ValueChanged);
        this.labelDayDo.AutoSize = true;
        this.labelDayDo.Location = new Point(137, 25);
        this.labelDayDo.Name = "labelDayDo";
        this.labelDayDo.Size = new Size(22, 13);
        this.labelDayDo.TabIndex = 2;
        this.labelDayDo.Text = "До";
        this.txtDayOt.DataBindings.Add(new Binding("Value", this.dsDamage, "tJ_Temperature.DayDown", true));
        this.txtDayOt.Location = new Point(32, 19);
        this.txtDayOt.Minimum = new decimal(new int[]
        {
            100,
            0,
            0,
            int.MinValue
        });
        this.txtDayOt.Name = "txtDayOt";
        this.txtDayOt.Size = new Size(99, 20);
        this.txtDayOt.TabIndex = 1;
        this.txtDayOt.Value = null;
        this.txtDayOt.ValueChanged +=new System.EventHandler( this.txtDayOt_ValueChanged);
        this.labelDayOt.AutoSize = true;
        this.labelDayOt.Location = new Point(6, 25);
        this.labelDayOt.Name = "labelDayOt";
        this.labelDayOt.Size = new Size(20, 13);
        this.labelDayOt.TabIndex = 0;
        this.labelDayOt.Text = "От";
        this.nullableNumericUpDown5.DataBindings.Add(new Binding("Value", this.dsDamage, "tJ_Temperature.TempAverage", true));
        this.nullableNumericUpDown5.Location = new Point(178, 150);
        this.nullableNumericUpDown5.Minimum = new decimal(new int[]
        {
            100,
            0,
            0,
            int.MinValue
        });
        this.nullableNumericUpDown5.Name = "nullableNumericUpDown5";
        this.nullableNumericUpDown5.Size = new Size(108, 20);
        this.nullableNumericUpDown5.TabIndex = 5;
        this.nullableNumericUpDown5.Value = null;
        this.nullableNumericUpDown5.ValueChanged +=new System.EventHandler( this.nullableNumericUpDown5_ValueChanged);
        this.label6.AutoSize = true;
        this.label6.Location = new Point(12, 152);
        this.label6.Name = "label6";
        this.label6.Size = new Size(157, 13);
        this.label6.TabIndex = 6;
        this.label6.Text = "Среднесуточная температура";
        this.groupBox3.Controls.Add(this.nullableNumericUpDown7);
        this.groupBox3.Controls.Add(this.nullableNumericUpDown6);
        this.groupBox3.Controls.Add(this.label9);
        this.groupBox3.Controls.Add(this.label8);
        this.groupBox3.Controls.Add(this.cmbWindDirect);
        this.groupBox3.Controls.Add(this.labelWind);
        this.groupBox3.Location = new Point(15, 176);
        this.groupBox3.Name = "groupBox3";
        this.groupBox3.Size = new Size(271, 97);
        this.groupBox3.TabIndex = 7;
        this.groupBox3.TabStop = false;
        this.groupBox3.Text = "Ветер";
        this.nullableNumericUpDown7.DataBindings.Add(new Binding("Value", this.dsDamage, "tJ_Temperature.SpeedUp", true));
        this.nullableNumericUpDown7.Location = new Point(145, 65);
        this.nullableNumericUpDown7.Name = "nullableNumericUpDown7";
        this.nullableNumericUpDown7.Size = new Size(120, 20);
        this.nullableNumericUpDown7.TabIndex = 5;
        this.nullableNumericUpDown7.Value = null;
        this.nullableNumericUpDown7.ValueChanged +=new System.EventHandler( this.nullableNumericUpDown5_ValueChanged);
        this.nullableNumericUpDown6.DataBindings.Add(new Binding("Value", this.dsDamage, "tJ_Temperature.SpeedDown", true));
        this.nullableNumericUpDown6.Location = new Point(9, 65);
        this.nullableNumericUpDown6.Name = "nullableNumericUpDown6";
        this.nullableNumericUpDown6.Size = new Size(120, 20);
        this.nullableNumericUpDown6.TabIndex = 4;
        this.nullableNumericUpDown6.Value = null;
        this.nullableNumericUpDown6.ValueChanged +=new System.EventHandler( this.nullableNumericUpDown5_ValueChanged);
        this.label9.AutoSize = true;
        this.label9.Location = new Point(142, 49);
        this.label9.Name = "label9";
        this.label9.Size = new Size(98, 13);
        this.label9.TabIndex = 3;
        this.label9.Text = "Скорость до (м/с)";
        this.label8.AutoSize = true;
        this.label8.Location = new Point(6, 49);
        this.label8.Name = "label8";
        this.label8.Size = new Size(97, 13);
        this.label8.TabIndex = 2;
        this.label8.Text = "Скорость от (м/с)";
        this.cmbWindDirect.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        this.cmbWindDirect.AutoCompleteSource = AutoCompleteSource.ListItems;
        this.cmbWindDirect.DataBindings.Add(new Binding("SelectedValue", this.dsDamage, "tJ_Temperature.Wind", true));
        this.cmbWindDirect.FormattingEnabled = true;
        this.cmbWindDirect.Location = new Point(87, 19);
        this.cmbWindDirect.Name = "cmbWindDirect";
        this.cmbWindDirect.Size = new Size(178, 21);
        this.cmbWindDirect.TabIndex = 1;
        this.cmbWindDirect.SelectedIndexChanged +=new System.EventHandler( this.cmbWindDirect_SelectedIndexChanged);
        this.labelWind.AutoSize = true;
        this.labelWind.Location = new Point(6, 22);
        this.labelWind.Name = "labelWind";
        this.labelWind.Size = new Size(75, 13);
        this.labelWind.TabIndex = 0;
        this.labelWind.Text = "Направление";
        this.label10.AutoSize = true;
        this.label10.Location = new Point(21, 276);
        this.label10.Name = "label10";
        this.label10.Size = new Size(70, 13);
        this.label10.TabIndex = 8;
        this.label10.Text = "Примечание";
        this.richTextBox1.AcceptsTab = true;
        this.richTextBox1.DataBindings.Add(new Binding("Text", this.dsDamage, "tJ_Temperature.Comment", true));
        this.richTextBox1.Location = new Point(15, 292);
        this.richTextBox1.Name = "richTextBox1";
        this.richTextBox1.Size = new Size(271, 82);
        this.richTextBox1.TabIndex = 9;
        this.richTextBox1.Text = "";
        this.richTextBox1.TextChanged +=new System.EventHandler( this.richTextBox1_TextChanged);
        this.buttonOK.DialogResult = DialogResult.OK;
        this.buttonOK.Location = new Point(15, 383);
        this.buttonOK.Name = "buttonOK";
        this.buttonOK.Size = new Size(75, 23);
        this.buttonOK.TabIndex = 10;
        this.buttonOK.Text = "ОК";
        this.buttonOK.UseVisualStyleBackColor = true;
        this.buttonOK.Click +=new System.EventHandler( this.buttonOK_Click);
        this.buttonCancel.DialogResult = DialogResult.Cancel;
        this.buttonCancel.Location = new Point(211, 383);
        this.buttonCancel.Name = "buttonCancel";
        this.buttonCancel.Size = new Size(75, 23);
        this.buttonCancel.TabIndex = 11;
        this.buttonCancel.Text = "Отмена";
        this.buttonCancel.UseVisualStyleBackColor = true;
        this.buttonCancel.Click +=new  System.EventHandler (this.buttonCancel_Click);
        base.AcceptButton = this.buttonOK;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.CancelButton = this.buttonCancel;
        base.ClientSize = new Size(295, 415);
        base.Controls.Add(this.buttonCancel);
        base.Controls.Add(this.buttonOK);
        base.Controls.Add(this.richTextBox1);
        base.Controls.Add(this.label10);
        base.Controls.Add(this.groupBox3);
        base.Controls.Add(this.label6);
        base.Controls.Add(this.nullableNumericUpDown5);
        base.Controls.Add(this.groupBox2);
        base.Controls.Add(this.groupBox1);
        base.Controls.Add(this.label1);
        base.Controls.Add(this.dateTimePickerWeather);
        base.Name = "FormTemperatureAddEdit";
        this.Text = "FormTemperatureAddEDit";
        base.FormClosing +=new FormClosingEventHandler (this.FormTemperatureAddEDit_FormClosing);
        base.Load +=new System.EventHandler (this.FormTemperatureAddEDit_Load);
        ((ISupportInitialize)this.dsDamage).EndInit();
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        ((ISupportInitialize)this.txtNightDo).EndInit();
        ((ISupportInitialize)this.txtNightOt).EndInit();
        this.groupBox2.ResumeLayout(false);
        this.groupBox2.PerformLayout();
        ((ISupportInitialize)this.txtDayDo).EndInit();
        ((ISupportInitialize)this.txtDayOt).EndInit();
        ((ISupportInitialize)this.nullableNumericUpDown5).EndInit();
        this.groupBox3.ResumeLayout(false);
        this.groupBox3.PerformLayout();
        ((ISupportInitialize)this.nullableNumericUpDown7).EndInit();
        ((ISupportInitialize)this.nullableNumericUpDown6).EndInit();
        base.ResumeLayout(false);
        base.PerformLayout();
    }


    private DateTimePicker dateTimePickerWeather;

    private Label label1;

    private GroupBox groupBox1;

    private NullableNumericUpDown txtNightOt;

    private Label labelNightOt;

    private NullableNumericUpDown txtNightDo;

    private Label labelNightDo;

    private GroupBox groupBox2;

    private NullableNumericUpDown txtDayDo;

    private Label labelDayDo;

    private NullableNumericUpDown txtDayOt;

    private Label labelDayOt;

    private NullableNumericUpDown nullableNumericUpDown5;

    private Label label6;

    private GroupBox groupBox3;

    private NullableNumericUpDown nullableNumericUpDown7;

    private NullableNumericUpDown nullableNumericUpDown6;

    private Label label9;

    private Label label8;

    private ComboBox cmbWindDirect;

    private Label labelWind;

    private Label label10;

    private RichTextBox richTextBox1;

    private Button buttonOK;

    private Button buttonCancel;

    private DailyReportN.DataSet.dsDamage dsDamage;
}
