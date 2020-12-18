using Documents.Forms.TechnologicalConnection;
using FormLbr;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

internal class Form14 : FormBase
{
    private Button button_0;
    private Button button_1;
    private ComboBox comboBox_0;
    private ComboBox comboBox_1;
    private DataRow dataRow_0;
    private DataRow dataRow_1;
    private DataSetTechConnection dataSetTechConnection_0;
    private DateTimePicker dateTimePicker_0;
    private IContainer icontainer_0;
    private int int_0;
    private Label label_0;
    private Label label_1;
    private Label label_2;
    private Label label_3;
    private Label label_4;
    private Label label_5;
    private NumericUpDown numericUpDown_0;
    private RichTextBox richTextBox_0;
    private TextBox textBox_0;

    internal Form14()
    {
        this.int_0 = -1;
        this.method_3();
    }

    internal Form14(DataRow dataRow_2, DataRow dataRow_3)
    {
        this.int_0 = -1;
        this.method_3();
        this.dataRow_0 = dataRow_2;
        this.dataRow_1 = dataRow_3;
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.icontainer_0 != null))
        {
            this.icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    private void Form14_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (base.DialogResult == DialogResult.OK)
        {
            if (this.comboBox_0.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран тип документа");
                e.Cancel = true;
            }
            else if (this.numericUpDown_0.Value == decimal.Zero)
            {
                MessageBox.Show("Сумма должна отличаться от нуля");
                e.Cancel = true;
            }
        }
    }

    private void Form14_Load(object sender, EventArgs e)
    {
        this.method_2();
        if (((this.int_0 == -1) && (this.dataRow_0 == null)) && (this.dataRow_1 == null))
        {
            this.Text = "Новый документ";
            DataRow row = this.dataSetTechConnection_0.tTC_Doc.NewRow();
            row["TypeDoc"] = -1;
            row["dateDoc"] = DateTime.Now.Date;
            this.dataSetTechConnection_0.tTC_Doc.Rows.Add(row);
            DataRow row2 = this.dataSetTechConnection_0.tTC_Payment.NewRow();
            row2["id"] = this.int_0;
            row2["summa"] = 0;
            this.dataSetTechConnection_0.tTC_Payment.Rows.Add(row2);
        }
        else
        {
            this.Text = "Редактировать документ";
            if (this.dataRow_0 != null)
            {
                DataRow row3 = this.dataSetTechConnection_0.tTC_Doc.NewRow();
                row3["typeDoc"] = this.dataRow_0["typeDoc"];
                row3["numDoc"] = this.dataRow_0["numdoc"];
                row3["dateDoc"] = this.dataRow_0["datedoc"];
                row3["comment"] = this.dataRow_0["comment"];
                this.dataSetTechConnection_0.tTC_Doc.Rows.Add(row3);
                if (this.dataRow_1 != null)
                {
                    DataRow row4 = this.dataSetTechConnection_0.tTC_Payment.NewRow();
                    row4["id"] = row3["id"];
                    row4["summa"] = this.dataRow_1["summa"];
                    row4["idDog"] = this.dataRow_1["iddog"];
                    this.dataSetTechConnection_0.tTC_Payment.Rows.Add(row4);
                }
                else
                {
                    DataRow row5 = this.dataSetTechConnection_0.tTC_Payment.NewRow();
                    row5["id"] = row3["id"];
                    row5["summa"] = 0;
                    this.dataSetTechConnection_0.tTC_Payment.Rows.Add(row5);
                }
            }
        }
    }

    internal DataRow method_0()
    {
        if (this.dataSetTechConnection_0.tTC_Doc.Rows.Count > 0)
        {
            return this.dataSetTechConnection_0.tTC_Doc.Rows[0];
        }
        return null;
    }

    internal DataRow method_1()
    {
        if (this.dataSetTechConnection_0.tTC_Payment.Rows.Count > 0)
        {
            return this.dataSetTechConnection_0.tTC_Payment.Rows[0];
        }
        return null;
    }

    private void method_2()
    {
        DataSetTechConnection connection = new DataSetTechConnection();
        base.SelectSqlData(connection.tR_Classifier, true, " where ParentKey = ';TechConnect;TypeDoc;Payment;' and isGroup = 0 and deleted = 0 order by name", false);
        this.comboBox_0.ValueMember = "id";
        this.comboBox_0.DisplayMember = "name";
        this.comboBox_0.DataSource = connection.tR_Classifier;
        this.comboBox_0.SelectedIndex = -1;
        DataTable table = new DataTable("tTC_Doc");
        table.Columns.Add(new DataColumn("id", typeof(int)));
        table.Columns.Add(new DataColumn("numDoc", typeof(string)));
        table.Columns.Add(new DataColumn("dateDoc", typeof(DateTime)));
        table.Columns.Add(new DataColumn("numdate", typeof(string), "isnull(numDoc, '') + ' от ' + substring(isnull(Convert(dateDoc, 'System.String'), '          '), 1, 10)"));
        base.SelectSqlData(table, true, " where typeDoc = " + 0x4c4.ToString() + " order by numDoc, dateDoc", false);
        this.comboBox_1.ValueMember = "id";
        this.comboBox_1.DisplayMember = "numdate";
        this.comboBox_1.DataSource = table;
        this.comboBox_0.SelectedIndex = -1;
    }

    private void method_3()
    {
        this.label_0 = new Label();
        this.comboBox_0 = new ComboBox();
        this.dataSetTechConnection_0 = new DataSetTechConnection();
        this.label_1 = new Label();
        this.textBox_0 = new TextBox();
        this.label_2 = new Label();
        this.dateTimePicker_0 = new DateTimePicker();
        this.label_3 = new Label();
        this.numericUpDown_0 = new NumericUpDown();
        this.label_4 = new Label();
        this.comboBox_1 = new ComboBox();
        this.label_5 = new Label();
        this.richTextBox_0 = new RichTextBox();
        this.button_0 = new Button();
        this.button_1 = new Button();
        this.dataSetTechConnection_0.BeginInit();
        this.numericUpDown_0.BeginInit();
        base.SuspendLayout();
        this.label_0.AutoSize = true;
        this.label_0.Location = new Point(12, 9);
        this.label_0.Name = "label1";
        this.label_0.Size = new Size(0x48, 13);
        this.label_0.TabIndex = 0;
        this.label_0.Text = "Вид платежа";
        this.comboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        this.comboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
        this.comboBox_0.DataBindings.Add(new Binding("SelectedValue", this.dataSetTechConnection_0, "tTC_Doc.TypeDoc", true));
        this.comboBox_0.FormattingEnabled = true;
        this.comboBox_0.Location = new Point(15, 0x19);
        this.comboBox_0.Name = "cmbTypePayment";
        this.comboBox_0.Size = new Size(0x17a, 0x15);
        this.comboBox_0.TabIndex = 1;
        this.dataSetTechConnection_0.DataSetName = "DataSetTechConnection";
        this.dataSetTechConnection_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        this.label_1.AutoSize = true;
        this.label_1.Location = new Point(12, 0x31);
        this.label_1.Name = "label2";
        this.label_1.Size = new Size(0x29, 13);
        this.label_1.TabIndex = 2;
        this.label_1.Text = "Номер";
        this.textBox_0.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tTC_Doc.numDoc", true));
        this.textBox_0.Location = new Point(15, 0x41);
        this.textBox_0.Name = "txtNum";
        this.textBox_0.Size = new Size(0xc5, 20);
        this.textBox_0.TabIndex = 3;
        this.label_2.AutoSize = true;
        this.label_2.Location = new Point(0xda, 0x31);
        this.label_2.Name = "label3";
        this.label_2.Size = new Size(0x21, 13);
        this.label_2.TabIndex = 4;
        this.label_2.Text = "Дата";
        this.dateTimePicker_0.DataBindings.Add(new Binding("Value", this.dataSetTechConnection_0, "tTC_Doc.dateDoc", true));
        this.dateTimePicker_0.Location = new Point(0xdd, 0x41);
        this.dateTimePicker_0.Name = "dateTimePickerPayment";
        this.dateTimePicker_0.Size = new Size(0xac, 20);
        this.dateTimePicker_0.TabIndex = 5;
        this.label_3.AutoSize = true;
        this.label_3.Location = new Point(12, 0x58);
        this.label_3.Name = "label4";
        this.label_3.Size = new Size(0x29, 13);
        this.label_3.TabIndex = 6;
        this.label_3.Text = "Сумма";
        this.numericUpDown_0.DataBindings.Add(new Binding("Value", this.dataSetTechConnection_0, "tTC_Payment.summa", true));
        this.numericUpDown_0.DecimalPlaces = 2;
        this.numericUpDown_0.Location = new Point(15, 0x68);
        int[] bits = new int[4];
        bits[0] = 0x3b9ac9ff;
        this.numericUpDown_0.Maximum = new decimal(bits);
        int[] numArray2 = new int[4];
        numArray2[0] = 0x3b9ac9ff;
        numArray2[3] = -2147483648;
        this.numericUpDown_0.Minimum = new decimal(numArray2);
        this.numericUpDown_0.Name = "numericUpDownSumma";
        this.numericUpDown_0.Size = new Size(0x17a, 20);
        this.numericUpDown_0.TabIndex = 7;
        this.label_4.AutoSize = true;
        this.label_4.Location = new Point(12, 0x7f);
        this.label_4.Name = "label5";
        this.label_4.Size = new Size(0x74, 13);
        this.label_4.TabIndex = 8;
        this.label_4.Text = "Договор откуда/куда";
        this.comboBox_1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        this.comboBox_1.AutoCompleteSource = AutoCompleteSource.ListItems;
        this.comboBox_1.DataBindings.Add(new Binding("SelectedValue", this.dataSetTechConnection_0, "tTC_Payment.idDog", true));
        this.comboBox_1.FormattingEnabled = true;
        this.comboBox_1.Location = new Point(15, 0x8f);
        this.comboBox_1.Name = "cmbDog";
        this.comboBox_1.Size = new Size(0x17a, 0x15);
        this.comboBox_1.TabIndex = 9;
        this.label_5.AutoSize = true;
        this.label_5.Location = new Point(12, 0xa7);
        this.label_5.Name = "label6";
        this.label_5.Size = new Size(0x4d, 13);
        this.label_5.TabIndex = 10;
        this.label_5.Text = "Комментарий";
        this.richTextBox_0.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tTC_Doc.Comment", true));
        this.richTextBox_0.Location = new Point(15, 0xb7);
        this.richTextBox_0.Name = "txtComment";
        this.richTextBox_0.Size = new Size(0x17a, 0x60);
        this.richTextBox_0.TabIndex = 11;
        this.richTextBox_0.Text = "";
        this.button_0.DialogResult = DialogResult.OK;
        this.button_0.Location = new Point(15, 0x12a);
        this.button_0.Name = "buttonOK";
        this.button_0.Size = new Size(0x4b, 0x17);
        this.button_0.TabIndex = 12;
        this.button_0.Text = "ОК";
        this.button_0.UseVisualStyleBackColor = true;
        this.button_1.DialogResult = DialogResult.Cancel;
        this.button_1.Location = new Point(0x13e, 0x12a);
        this.button_1.Name = "buttonCancel";
        this.button_1.Size = new Size(0x4b, 0x17);
        this.button_1.TabIndex = 13;
        this.button_1.Text = "Отмена";
        this.button_1.UseVisualStyleBackColor = true;
        base.AcceptButton = this.button_0;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.CancelButton = this.button_1;
        base.ClientSize = new Size(0x195, 0x145);
        base.Controls.Add(this.button_1);
        base.Controls.Add(this.button_0);
        base.Controls.Add(this.richTextBox_0);
        base.Controls.Add(this.label_5);
        base.Controls.Add(this.comboBox_1);
        base.Controls.Add(this.label_4);
        base.Controls.Add(this.numericUpDown_0);
        base.Controls.Add(this.label_3);
        base.Controls.Add(this.dateTimePicker_0);
        base.Controls.Add(this.label_2);
        base.Controls.Add(this.textBox_0);
        base.Controls.Add(this.label_1);
        base.Controls.Add(this.comboBox_0);
        base.Controls.Add(this.label_0);
        base.FormBorderStyle = FormBorderStyle.FixedDialog;
        base.MaximizeBox = false;
        base.MinimizeBox = false;
        base.Name = "FormPaymentAddEdit";
        this.Text = "FormPaymentAddEdit";
        base.FormClosing += new FormClosingEventHandler(this.Form14_FormClosing);
        base.Load += new EventHandler(this.Form14_Load);
        this.dataSetTechConnection_0.EndInit();
        this.numericUpDown_0.EndInit();
        base.ResumeLayout(false);
        base.PerformLayout();
    }
}

