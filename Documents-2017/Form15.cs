using ControlsLbr;
using Documents.Forms.TechnologicalConnection;
using FormLbr;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

internal class Form15 : FormBase
{
    private Button button_0;
    private Button button_1;
    private DataSetTechConnection dataSetTechConnection_0;
    private DataSetTechConnection dataSetTechConnection_1;
    private IContainer icontainer_0;
    private int int_0;
    private int int_1;
    private int int_2;
    private Label label_0;
    private Label label_1;
    private Label label_2;
    private Label label_3;
    private NullableDateTimePicker nullableDateTimePicker_0;
    private TextBox textBox_0;
    private TextBox textBox_1;
    private TextBox textBox_2;

    internal Form15()
    {
        this.int_0 = -1;
        this.int_1 = -1;
        this.int_2 = -1;
        this.dataSetTechConnection_0 = new DataSetTechConnection();
        this.method_2();
    }

    internal Form15(int int_3, int int_4 = -1, int int_5 = -1)
    {
        this.int_0 = -1;
        this.int_1 = -1;
        this.int_2 = -1;
        this.dataSetTechConnection_0 = new DataSetTechConnection();
        this.method_2();
        this.int_0 = int_3;
        this.int_1 = int_4;
        this.int_2 = int_5;
        this.Text = (int_3 == -1) ? "Новый договор" : "Редактирование договор";
        this.nullableDateTimePicker_0.set_Value(DateTime.Now.Date);
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.icontainer_0 != null))
        {
            this.icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    private void Form15_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (base.DialogResult == DialogResult.OK)
        {
            if (string.IsNullOrEmpty(this.textBox_0.Text))
            {
                MessageBox.Show("Не введен номер договора");
                e.Cancel = true;
            }
            else if (this.int_0 == -1)
            {
                this.dataSetTechConnection_1.tTC_Doc.Rows[0].EndEdit();
                int num = base.InsertSqlDataOneRow(this.dataSetTechConnection_1, this.dataSetTechConnection_1.tTC_Doc);
                this.dataSetTechConnection_1.tTC_DocOut.Rows[0]["idDocOut"] = num;
                this.dataSetTechConnection_1.tTC_DocOut.Rows[0].EndEdit();
                this.int_0 = base.InsertSqlDataOneRow(this.dataSetTechConnection_1, this.dataSetTechConnection_1.tTC_DocOut);
                this.dataSetTechConnection_0.tTC_Doc.Rows[0]["idParent"] = num;
                this.dataSetTechConnection_0.tTC_Doc.Rows[0].EndEdit();
                base.UpdateSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Doc);
            }
            else
            {
                this.dataSetTechConnection_1.tTC_Doc.Rows[0].EndEdit();
                base.UpdateSqlData(this.dataSetTechConnection_1, this.dataSetTechConnection_1.tTC_Doc);
                this.dataSetTechConnection_1.tTC_DocOut.Rows[0].EndEdit();
                base.UpdateSqlData(this.dataSetTechConnection_1, this.dataSetTechConnection_1.tTC_DocOut);
                this.dataSetTechConnection_0.tTC_Doc.Rows[0].EndEdit();
                base.UpdateSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Doc);
            }
        }
    }

    private void Form15_Load(object sender, EventArgs e)
    {
        if (this.int_0 == -1)
        {
            this.method_1();
            if (this.int_1 == -1)
            {
                string[] textArray1 = new string[7];
                textArray1[0] = "where idDocOut = ";
                textArray1[1] = this.int_2.ToString();
                textArray1[2] = " and typeDoc in (";
                int num = 0x459;
                textArray1[3] = num.ToString();
                textArray1[4] = ",";
                num = 0x4b3;
                textArray1[5] = num.ToString();
                textArray1[6] = ")";
                base.SelectSqlData(this.dataSetTechConnection_1, this.dataSetTechConnection_1.vTC_DocOut, true, string.Concat(textArray1));
                if (this.dataSetTechConnection_1.vTC_DocOut.Rows.Count > 0)
                {
                    this.int_1 = Convert.ToInt32(this.dataSetTechConnection_1.vTC_DocOut.Rows[0]["idDoc"]);
                }
                else
                {
                    MessageBox.Show("Ошибка");
                    this.button_0.Enabled = false;
                }
            }
            DataRow row = this.dataSetTechConnection_1.tTC_DocOut.NewRow();
            row["idDoc"] = this.int_1;
            row["idDocOut"] = this.dataSetTechConnection_1.tTC_Doc.Rows[0]["id"];
            this.dataSetTechConnection_1.tTC_DocOut.Rows.Add(row);
            if (this.int_2 == -1)
            {
                base.SelectSqlData(this.dataSetTechConnection_1, this.dataSetTechConnection_1.vTC_DocOut, true, "where idDoc = " + this.int_1.ToString() + " and typeDocOut = " + 0x463.ToString());
                if (this.dataSetTechConnection_1.vTC_DocOut.Rows.Count > 0)
                {
                    this.int_2 = Convert.ToInt32(this.dataSetTechConnection_1.vTC_DocOut.Rows[0]["idDocOut"]);
                }
                else
                {
                    MessageBox.Show("Ошибка");
                    this.button_0.Enabled = false;
                }
            }
            base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Doc, true, "where id = " + this.int_2.ToString());
        }
        else
        {
            base.SelectSqlData(this.dataSetTechConnection_1, this.dataSetTechConnection_1.tTC_Doc, true, "where id = " + this.int_0.ToString());
            base.SelectSqlData(this.dataSetTechConnection_1, this.dataSetTechConnection_1.tTC_DocOut, true, "where idDocOut = " + this.int_0.ToString());
            base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Doc, true, "where idParent = " + this.int_0.ToString());
        }
    }

    internal int method_0()
    {
        return this.int_0;
    }

    private void method_1()
    {
        DataRow row = this.dataSetTechConnection_1.tTC_Doc.NewRow();
        row["TypeDoc"] = 0x4c4;
        row["DateDoc"] = DateTime.Now.Date;
        this.dataSetTechConnection_1.tTC_Doc.Rows.Add(row);
    }

    private void method_2()
    {
        this.dataSetTechConnection_1 = new DataSetTechConnection();
        this.label_0 = new Label();
        this.textBox_0 = new TextBox();
        this.nullableDateTimePicker_0 = new NullableDateTimePicker();
        this.button_0 = new Button();
        this.button_1 = new Button();
        this.label_1 = new Label();
        this.textBox_1 = new TextBox();
        this.label_2 = new Label();
        this.textBox_2 = new TextBox();
        this.label_3 = new Label();
        this.dataSetTechConnection_1.BeginInit();
        base.SuspendLayout();
        this.dataSetTechConnection_1.DataSetName = "DataSetTechConnection";
        this.dataSetTechConnection_1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        this.label_0.AutoSize = true;
        this.label_0.Location = new Point(9, 9);
        this.label_0.Name = "label2";
        this.label_0.Size = new Size(0x7c, 13);
        this.label_0.TabIndex = 2;
        this.label_0.Text = "Номер договора на ТП";
        this.textBox_0.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_1, "tTC_Doc.numDoc", true));
        this.textBox_0.Location = new Point(12, 0x19);
        this.textBox_0.Name = "txtNumDocOut";
        this.textBox_0.Size = new Size(0x125, 20);
        this.textBox_0.TabIndex = 3;
        this.nullableDateTimePicker_0.DataBindings.Add(new Binding("Value", this.dataSetTechConnection_1, "tTC_Doc.dateDoc", true));
        this.nullableDateTimePicker_0.Location = new Point(12, 0x40);
        this.nullableDateTimePicker_0.Name = "dateTimePickerDocOut";
        this.nullableDateTimePicker_0.Size = new Size(0x125, 20);
        this.nullableDateTimePicker_0.TabIndex = 4;
        this.nullableDateTimePicker_0.set_Value(new DateTime(0x7dd, 4, 0x1d, 14, 0x26, 3, 750));
        this.button_0.DialogResult = DialogResult.OK;
        this.button_0.Location = new Point(12, 0x127);
        this.button_0.Name = "buttonOK";
        this.button_0.Size = new Size(0x4b, 0x17);
        this.button_0.TabIndex = 11;
        this.button_0.Text = "ОК";
        this.button_0.UseVisualStyleBackColor = true;
        this.button_1.DialogResult = DialogResult.Cancel;
        this.button_1.Location = new Point(230, 0x127);
        this.button_1.Name = "buttonCancel";
        this.button_1.Size = new Size(0x4b, 0x17);
        this.button_1.TabIndex = 12;
        this.button_1.Text = "Отмена";
        this.button_1.UseVisualStyleBackColor = true;
        this.label_1.AutoSize = true;
        this.label_1.Location = new Point(12, 0xab);
        this.label_1.Name = "label6";
        this.label_1.Size = new Size(0x4d, 13);
        this.label_1.TabIndex = 9;
        this.label_1.Text = "Комментарий";
        this.textBox_1.AcceptsReturn = true;
        this.textBox_1.AcceptsTab = true;
        this.textBox_1.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_1, "tTC_Doc.Comment", true));
        this.textBox_1.Location = new Point(12, 0xbb);
        this.textBox_1.Multiline = true;
        this.textBox_1.Name = "txtComment";
        this.textBox_1.Size = new Size(0x125, 0x67);
        this.textBox_1.TabIndex = 10;
        this.label_2.AutoSize = true;
        this.label_2.Location = new Point(12, 0x57);
        this.label_2.Name = "label7";
        this.label_2.Size = new Size(70, 13);
        this.label_2.TabIndex = 5;
        this.label_2.Text = "Содержание";
        this.textBox_2.AcceptsReturn = true;
        this.textBox_2.AcceptsTab = true;
        this.textBox_2.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_1, "tTC_Doc.Body", true));
        this.textBox_2.Location = new Point(12, 0x67);
        this.textBox_2.Multiline = true;
        this.textBox_2.Name = "txtBody";
        this.textBox_2.Size = new Size(0x125, 0x41);
        this.textBox_2.TabIndex = 6;
        this.label_3.AutoSize = true;
        this.label_3.Location = new Point(12, 0x30);
        this.label_3.Name = "label1";
        this.label_3.Size = new Size(0x74, 13);
        this.label_3.TabIndex = 0x11;
        this.label_3.Text = "Дата договора на ТП";
        base.AcceptButton = this.button_0;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.CancelButton = this.button_1;
        base.ClientSize = new Size(0x135, 330);
        base.Controls.Add(this.label_3);
        base.Controls.Add(this.textBox_2);
        base.Controls.Add(this.label_2);
        base.Controls.Add(this.textBox_1);
        base.Controls.Add(this.label_1);
        base.Controls.Add(this.button_1);
        base.Controls.Add(this.button_0);
        base.Controls.Add(this.nullableDateTimePicker_0);
        base.Controls.Add(this.textBox_0);
        base.Controls.Add(this.label_0);
        base.FormBorderStyle = FormBorderStyle.FixedDialog;
        base.MaximizeBox = false;
        base.MinimizeBox = false;
        base.Name = "FormSmallContractAddEdit";
        this.Text = "FormTechConnectionDocOutAddEdit";
        base.FormClosing += new FormClosingEventHandler(this.Form15_FormClosing);
        base.Load += new EventHandler(this.Form15_Load);
        this.dataSetTechConnection_1.EndInit();
        base.ResumeLayout(false);
        base.PerformLayout();
    }
}

