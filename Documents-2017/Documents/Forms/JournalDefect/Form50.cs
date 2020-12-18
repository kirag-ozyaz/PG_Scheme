using FormLbr;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

internal class Form50 : FormBase
{
    private Button button_0;
    private Button button_1;
    private DataColumn dataColumn_0;
    private DataColumn dataColumn_1;
    private DataColumn dataColumn_2;
    private DataColumn dataColumn_3;
    private DataColumn dataColumn_4;
    private DataColumn dataColumn_5;
    private DataSet dataSet_0;
    private DataTable dataTable_0;
    private DateTimePicker dateTimePicker_0;
    private IContainer icontainer_0;
    private int int_0;
    private Label label_0;
    private Label label_1;
    private Label label_2;
    private Label label_3;
    private TextBox textBox_0;
    private TextBox textBox_1;
    private TextBox textBox_2;

    public Form50()
    {
        this.int_0 = -1;
        this.method_0();
    }

    public Form50(int int_1)
    {
        this.int_0 = -1;
        this.method_0();
        this.int_0 = int_1;
        this.Text = (int_1 == -1) ? "Новый дефект" : "Редактирование";
        this.dateTimePicker_0.Value = DateTime.Now;
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.icontainer_0 != null))
        {
            this.icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    private void Form50_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (base.DialogResult == DialogResult.OK)
        {
            if (string.IsNullOrEmpty(this.textBox_0.Text))
            {
                MessageBox.Show("Не указано наименование дефекта");
                e.Cancel = true;
            }
            else
            {
                this.dataTable_0.Rows[0].EndEdit();
                if (this.int_0 == -1)
                {
                    this.int_0 = base.InsertSqlDataOneRow(this.dataSet_0, this.dataTable_0);
                }
                else
                {
                    base.UpdateSqlData(this.dataSet_0, this.dataTable_0);
                }
            }
        }
    }

    private void Form50_Load(object sender, EventArgs e)
    {
        if (this.int_0 == -1)
        {
            DataRow row = this.dataTable_0.NewRow();
            row["DateDefect"] = DateTime.Now;
            row["NameDefect"] = "";
            this.dataTable_0.Rows.Add(row);
        }
        else
        {
            base.SelectSqlData(this.dataTable_0, true, "where id = " + this.int_0.ToString(), false);
        }
    }

    private void method_0()
    {
        this.label_0 = new Label();
        this.dateTimePicker_0 = new DateTimePicker();
        this.dataSet_0 = new DataSet();
        this.dataTable_0 = new DataTable();
        this.dataColumn_0 = new DataColumn();
        this.dataColumn_1 = new DataColumn();
        this.dataColumn_2 = new DataColumn();
        this.dataColumn_3 = new DataColumn();
        this.dataColumn_4 = new DataColumn();
        this.dataColumn_5 = new DataColumn();
        this.label_1 = new Label();
        this.textBox_0 = new TextBox();
        this.label_2 = new Label();
        this.textBox_1 = new TextBox();
        this.label_3 = new Label();
        this.textBox_2 = new TextBox();
        this.button_0 = new Button();
        this.button_1 = new Button();
        this.dataSet_0.BeginInit();
        this.dataTable_0.BeginInit();
        base.SuspendLayout();
        this.label_0.AutoSize = true;
        this.label_0.Location = new Point(12, 9);
        this.label_0.Name = "label1";
        this.label_0.Size = new Size(0x95, 13);
        this.label_0.TabIndex = 0;
        this.label_0.Text = "Дата обнаружения дефекта";
        this.dateTimePicker_0.CustomFormat = "dd.MM.yyyy HH:mm";
        this.dateTimePicker_0.DataBindings.Add(new Binding("Value", this.dataSet_0, "tJ_Defect.dateDefect", true));
        this.dateTimePicker_0.Format = DateTimePickerFormat.Custom;
        this.dateTimePicker_0.Location = new Point(15, 0x19);
        this.dateTimePicker_0.Name = "dateTimePickerOff";
        this.dateTimePicker_0.Size = new Size(0x102, 20);
        this.dateTimePicker_0.TabIndex = 1;
        this.dataSet_0.DataSetName = "NewDataSet";
        DataTable[] tables = new DataTable[] { this.dataTable_0 };
        this.dataSet_0.Tables.AddRange(tables);
        DataColumn[] columns = new DataColumn[] { this.dataColumn_0, this.dataColumn_1, this.dataColumn_2, this.dataColumn_3, this.dataColumn_4, this.dataColumn_5 };
        this.dataTable_0.Columns.AddRange(columns);
        Constraint[] constraints = new Constraint[1];
        string[] columnNames = new string[] { "id" };
        constraints[0] = new UniqueConstraint("Constraint1", columnNames, true);
        this.dataTable_0.Constraints.AddRange(constraints);
        this.dataTable_0.PrimaryKey = new DataColumn[] { this.dataColumn_0 };
        this.dataTable_0.TableName = "tJ_Defect";
        this.dataColumn_0.AllowDBNull = false;
        this.dataColumn_0.AutoIncrement = true;
        this.dataColumn_0.AutoIncrementStep = -1L;
        this.dataColumn_0.ColumnName = "id";
        this.dataColumn_0.DataType = typeof(int);
        this.dataColumn_1.ColumnName = "num";
        this.dataColumn_1.DataType = typeof(int);
        this.dataColumn_2.ColumnName = "nameDefect";
        this.dataColumn_3.ColumnName = "dateDefect";
        this.dataColumn_3.DataType = typeof(DateTime);
        this.dataColumn_4.ColumnName = "Direct";
        this.dataColumn_5.ColumnName = "Mark";
        this.label_1.AutoSize = true;
        this.label_1.Location = new Point(12, 0x30);
        this.label_1.Name = "label2";
        this.label_1.Size = new Size(0x81, 13);
        this.label_1.TabIndex = 2;
        this.label_1.Text = "Наименование дефекта";
        this.textBox_0.AcceptsReturn = true;
        this.textBox_0.DataBindings.Add(new Binding("Text", this.dataSet_0, "tJ_Defect.nameDefect", true));
        this.textBox_0.Location = new Point(15, 0x40);
        this.textBox_0.Multiline = true;
        this.textBox_0.Name = "txtNameDefect";
        this.textBox_0.Size = new Size(0x102, 0x29);
        this.textBox_0.TabIndex = 3;
        this.label_2.AutoSize = true;
        this.label_2.Location = new Point(12, 0x6c);
        this.label_2.Name = "label3";
        this.label_2.Size = new Size(130, 13);
        this.label_2.TabIndex = 4;
        this.label_2.Text = "Указания руководителя";
        this.textBox_1.AcceptsReturn = true;
        this.textBox_1.DataBindings.Add(new Binding("Text", this.dataSet_0, "tJ_Defect.Direct", true));
        this.textBox_1.Location = new Point(12, 0x7c);
        this.textBox_1.Multiline = true;
        this.textBox_1.Name = "txtText";
        this.textBox_1.Size = new Size(0x105, 0x3b);
        this.textBox_1.TabIndex = 5;
        this.label_3.AutoSize = true;
        this.label_3.Location = new Point(12, 0xba);
        this.label_3.Name = "label4";
        this.label_3.Size = new Size(0x7f, 13);
        this.label_3.TabIndex = 6;
        this.label_3.Text = "Отметка об устранении";
        this.textBox_2.AcceptsReturn = true;
        this.textBox_2.DataBindings.Add(new Binding("Text", this.dataSet_0, "tJ_Defect.Mark", true));
        this.textBox_2.Location = new Point(12, 0xca);
        this.textBox_2.Multiline = true;
        this.textBox_2.Name = "txtAbonents";
        this.textBox_2.Size = new Size(0x105, 0x3b);
        this.textBox_2.TabIndex = 7;
        this.button_0.DialogResult = DialogResult.OK;
        this.button_0.Location = new Point(12, 0x10b);
        this.button_0.Name = "buttonOK";
        this.button_0.Size = new Size(0x4b, 0x17);
        this.button_0.TabIndex = 10;
        this.button_0.Text = "ОК";
        this.button_0.UseVisualStyleBackColor = true;
        this.button_1.DialogResult = DialogResult.Cancel;
        this.button_1.Location = new Point(0xc6, 0x10b);
        this.button_1.Name = "buttonCancel";
        this.button_1.Size = new Size(0x4b, 0x17);
        this.button_1.TabIndex = 11;
        this.button_1.Text = "Отмена";
        this.button_1.UseVisualStyleBackColor = true;
        base.AcceptButton = this.button_0;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.CancelButton = this.button_1;
        base.ClientSize = new Size(280, 300);
        base.Controls.Add(this.button_1);
        base.Controls.Add(this.button_0);
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
        base.Name = "FormDefectAddEdit";
        this.Text = "FormTechnologicalFailuresAddEdit";
        base.FormClosing += new FormClosingEventHandler(this.Form50_FormClosing);
        base.Load += new EventHandler(this.Form50_Load);
        this.dataSet_0.EndInit();
        this.dataTable_0.EndInit();
        base.ResumeLayout(false);
        base.PerformLayout();
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

