using ControlsLbr;
using Documents.Forms.JournalTechnologicalFailures;
using FormLbr;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

internal class Form37 : FormBase
{
    private Button button_0;
    private Button button_1;
    private DataSetFailure dataSetFailure_0;
    private DateTimePicker dateTimePicker_0;
    private IContainer icontainer_0;
    private int int_0;
    private Label label_0;
    private Label label_1;
    private Label label_2;
    private Label label_3;
    private Label label_4;
    private NullableDateTimePicker nullableDateTimePicker_0;
    private TextBox textBox_0;
    private TextBox textBox_1;
    private TextBox textBox_2;

    public Form37()
    {
        this.int_0 = -1;
        this.method_0();
    }

    public Form37(int int_1)
    {
        this.int_0 = -1;
        this.method_0();
        this.int_0 = int_1;
        this.Text = (int_1 == -1) ? "Новое нарушение" : "Редактирование";
        this.dateTimePicker_0.Value = DateTime.Now;
        this.nullableDateTimePicker_0.set_Value(DateTime.Now);
    }

    private void dateTimePicker_0_ValueChanged(object sender, EventArgs e)
    {
        this.nullableDateTimePicker_0.MinDate = this.dateTimePicker_0.Value;
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.icontainer_0 != null))
        {
            this.icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    private void Form37_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (base.DialogResult == DialogResult.OK)
        {
            this.dataSetFailure_0.tJ_TechnologicalFailures.Rows[0].EndEdit();
            if (this.int_0 == -1)
            {
                this.int_0 = base.InsertSqlDataOneRow(this.dataSetFailure_0, this.dataSetFailure_0.tJ_TechnologicalFailures);
            }
            else
            {
                base.UpdateSqlData(this.dataSetFailure_0, this.dataSetFailure_0.tJ_TechnologicalFailures);
            }
        }
    }

    private void Form37_Load(object sender, EventArgs e)
    {
        if (this.int_0 == -1)
        {
            DataRow row = this.dataSetFailure_0.tJ_TechnologicalFailures.NewRow();
            row["DateOff"] = DateTime.Now;
            this.dataSetFailure_0.tJ_TechnologicalFailures.Rows.Add(row);
        }
        else
        {
            base.SelectSqlData(this.dataSetFailure_0.tJ_TechnologicalFailures, true, "where id = " + this.int_0.ToString(), false);
        }
    }

    private void method_0()
    {
        this.label_0 = new Label();
        this.dateTimePicker_0 = new DateTimePicker();
        this.dataSetFailure_0 = new DataSetFailure();
        this.label_1 = new Label();
        this.textBox_0 = new TextBox();
        this.label_2 = new Label();
        this.textBox_1 = new TextBox();
        this.label_3 = new Label();
        this.textBox_2 = new TextBox();
        this.label_4 = new Label();
        this.button_0 = new Button();
        this.button_1 = new Button();
        this.nullableDateTimePicker_0 = new NullableDateTimePicker();
        this.dataSetFailure_0.BeginInit();
        base.SuspendLayout();
        this.label_0.AutoSize = true;
        this.label_0.Location = new Point(12, 9);
        this.label_0.Name = "label1";
        this.label_0.Size = new Size(140, 13);
        this.label_0.TabIndex = 0;
        this.label_0.Text = "Дата и время отключения";
        this.dateTimePicker_0.CustomFormat = "dd.MM.yyyy HH:mm";
        this.dateTimePicker_0.DataBindings.Add(new Binding("Value", this.dataSetFailure_0, "tJ_TechnologicalFailures.dateOff", true));
        this.dateTimePicker_0.Format = DateTimePickerFormat.Custom;
        this.dateTimePicker_0.Location = new Point(15, 0x19);
        this.dateTimePicker_0.Name = "dateTimePickerOff";
        this.dateTimePicker_0.Size = new Size(0x102, 20);
        this.dateTimePicker_0.TabIndex = 1;
        this.dateTimePicker_0.ValueChanged += new EventHandler(this.dateTimePicker_0_ValueChanged);
        this.dataSetFailure_0.DataSetName = "DataSetFailure";
        this.dataSetFailure_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        this.label_1.AutoSize = true;
        this.label_1.Location = new Point(12, 0x30);
        this.label_1.Name = "label2";
        this.label_1.Size = new Size(0xb3, 13);
        this.label_1.TabIndex = 2;
        this.label_1.Text = "Наименование электроустановки";
        this.textBox_0.AcceptsReturn = true;
        this.textBox_0.DataBindings.Add(new Binding("Text", this.dataSetFailure_0, "tJ_TechnologicalFailures.schmObj", true));
        this.textBox_0.Location = new Point(15, 0x40);
        this.textBox_0.Multiline = true;
        this.textBox_0.Name = "txtSchmObj";
        this.textBox_0.Size = new Size(0x102, 0x29);
        this.textBox_0.TabIndex = 3;
        this.label_2.AutoSize = true;
        this.label_2.Location = new Point(12, 0x6c);
        this.label_2.Name = "label3";
        this.label_2.Size = new Size(0xb3, 13);
        this.label_2.TabIndex = 4;
        this.label_2.Text = "Причина и характер повреждения";
        this.textBox_1.AcceptsReturn = true;
        this.textBox_1.DataBindings.Add(new Binding("Text", this.dataSetFailure_0, "tJ_TechnologicalFailures.text", true));
        this.textBox_1.Location = new Point(12, 0x7c);
        this.textBox_1.Multiline = true;
        this.textBox_1.Name = "txtText";
        this.textBox_1.Size = new Size(0x105, 0x3b);
        this.textBox_1.TabIndex = 5;
        this.label_3.AutoSize = true;
        this.label_3.Location = new Point(12, 0xba);
        this.label_3.Name = "label4";
        this.label_3.Size = new Size(0x49, 13);
        this.label_3.TabIndex = 6;
        this.label_3.Text = "Потребители";
        this.textBox_2.AcceptsReturn = true;
        this.textBox_2.DataBindings.Add(new Binding("Text", this.dataSetFailure_0, "tJ_TechnologicalFailures.abonents", true));
        this.textBox_2.Location = new Point(12, 0xca);
        this.textBox_2.Multiline = true;
        this.textBox_2.Name = "txtAbonents";
        this.textBox_2.Size = new Size(0x105, 0x3b);
        this.textBox_2.TabIndex = 7;
        this.label_4.AutoSize = true;
        this.label_4.Location = new Point(12, 0x108);
        this.label_4.Name = "label5";
        this.label_4.Size = new Size(0x87, 13);
        this.label_4.TabIndex = 8;
        this.label_4.Text = "Дата и время включения";
        this.button_0.DialogResult = DialogResult.OK;
        this.button_0.Location = new Point(10, 0x142);
        this.button_0.Name = "buttonOK";
        this.button_0.Size = new Size(0x4b, 0x17);
        this.button_0.TabIndex = 10;
        this.button_0.Text = "ОК";
        this.button_0.UseVisualStyleBackColor = true;
        this.button_1.DialogResult = DialogResult.Cancel;
        this.button_1.Location = new Point(0xc3, 0x142);
        this.button_1.Name = "buttonCancel";
        this.button_1.Size = new Size(0x4b, 0x17);
        this.button_1.TabIndex = 11;
        this.button_1.Text = "Отмена";
        this.button_1.UseVisualStyleBackColor = true;
        this.nullableDateTimePicker_0.set_CustomFormat("dd.MM.yyyy HH:mm");
        this.nullableDateTimePicker_0.DataBindings.Add(new Binding("Value", this.dataSetFailure_0, "tJ_TechnologicalFailures.dateOn", true));
        this.nullableDateTimePicker_0.set_Format(DateTimePickerFormat.Custom);
        this.nullableDateTimePicker_0.Location = new Point(12, 280);
        this.nullableDateTimePicker_0.Name = "dateTimePickerOn";
        this.nullableDateTimePicker_0.Size = new Size(0x105, 20);
        this.nullableDateTimePicker_0.TabIndex = 12;
        this.nullableDateTimePicker_0.set_Value(new DateTime(0x7dd, 4, 9, 15, 4, 0x1b, 0x219));
        this.nullableDateTimePicker_0.ValueChanged += new EventHandler(this.nullableDateTimePicker_0_ValueChanged);
        base.AcceptButton = this.button_0;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.CancelButton = this.button_1;
        base.ClientSize = new Size(280, 0x165);
        base.Controls.Add(this.nullableDateTimePicker_0);
        base.Controls.Add(this.button_1);
        base.Controls.Add(this.button_0);
        base.Controls.Add(this.label_4);
        base.Controls.Add(this.textBox_2);
        base.Controls.Add(this.label_3);
        base.Controls.Add(this.textBox_1);
        base.Controls.Add(this.label_2);
        base.Controls.Add(this.textBox_0);
        base.Controls.Add(this.label_1);
        base.Controls.Add(this.dateTimePicker_0);
        base.Controls.Add(this.label_0);
        base.FormBorderStyle = FormBorderStyle.FixedDialog;
        base.MaximizeBox = false;
        base.MinimizeBox = false;
        base.Name = "FormTechnologicalFailuresAddEdit";
        this.Text = "FormTechnologicalFailuresAddEdit";
        base.FormClosing += new FormClosingEventHandler(this.Form37_FormClosing);
        base.Load += new EventHandler(this.Form37_Load);
        this.dataSetFailure_0.EndInit();
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    private void nullableDateTimePicker_0_ValueChanged(object sender, EventArgs e)
    {
        if ((this.nullableDateTimePicker_0.get_Value() != null) && (this.nullableDateTimePicker_0.get_Value() != DBNull.Value))
        {
            this.dateTimePicker_0.MaxDate = Convert.ToDateTime(this.nullableDateTimePicker_0.get_Value());
        }
        else
        {
            this.dateTimePicker_0.MaxDate = DateTimePicker.MaximumDateTime;
        }
    }

    internal int Id
    {
        get
        {
            return this.int_0;
        }
        set
        {
            this.int_0 = value;
        }
    }
}

