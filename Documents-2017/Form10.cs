using ControlsLbr;
using FormLbr;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

internal class Form10 : FormBase
{
    private Button button_0;
    private Button button_1;
    private ComboBox comboBox_0;
    private DataRow dataRow_0;
    private IContainer icontainer_0;
    private Label label_0;
    private Label label_1;
    private Label label_2;
    private Label label_3;
    private NullableDateTimePicker nullableDateTimePicker_0;
    private RichTextBox richTextBox_0;
    private TextBox textBox_0;

    internal Form10(DataRow dataRow_1)
    {
        this.method_2();
        this.dataRow_0 = dataRow_1;
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.icontainer_0 != null))
        {
            this.icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    private void Form10_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (base.DialogResult == DialogResult.OK)
        {
            if ((string.IsNullOrEmpty(this.textBox_0.Text) && (this.nullableDateTimePicker_0.get_Value() == null)) && (this.comboBox_0.SelectedIndex < 0))
            {
                MessageBox.Show("Не введены рексвизиты документа");
                e.Cancel = true;
            }
            else
            {
                if (string.IsNullOrEmpty(this.textBox_0.Text))
                {
                    this.dataRow_0["numDoc"] = DBNull.Value;
                }
                else
                {
                    this.dataRow_0["numdoc"] = this.textBox_0.Text;
                }
                if (this.nullableDateTimePicker_0.get_Value() == null)
                {
                    this.dataRow_0["datedoc"] = DBNull.Value;
                }
                else
                {
                    this.dataRow_0["datedoc"] = this.nullableDateTimePicker_0.get_Value();
                }
                if (this.comboBox_0.SelectedIndex < 0)
                {
                    this.dataRow_0["typeDoc"] = DBNull.Value;
                }
                else
                {
                    this.dataRow_0["typeDoc"] = this.comboBox_0.SelectedValue;
                }
                if (string.IsNullOrEmpty(this.richTextBox_0.Text))
                {
                    this.dataRow_0["Comment"] = DBNull.Value;
                }
                else
                {
                    this.dataRow_0["Comment"] = this.richTextBox_0.Text;
                }
            }
        }
    }

    private void Form10_Load(object sender, EventArgs e)
    {
        this.method_1();
        if (this.dataRow_0["numDoc"] != DBNull.Value)
        {
            this.textBox_0.Text = this.dataRow_0["numDoc"].ToString();
        }
        if (this.dataRow_0["dateDoc"] != DBNull.Value)
        {
            this.nullableDateTimePicker_0.set_Value(Convert.ToDateTime(this.dataRow_0["datedoc"]));
        }
        if (this.dataRow_0["typeDoc"] != DBNull.Value)
        {
            this.comboBox_0.SelectedValue = this.dataRow_0["typedoc"];
        }
        if (this.dataRow_0["comment"] != DBNull.Value)
        {
            this.richTextBox_0.Text = this.dataRow_0["comment"].ToString();
        }
    }

    internal DataRow method_0()
    {
        return this.dataRow_0;
    }

    private void method_1()
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

    private void method_2()
    {
        this.label_0 = new Label();
        this.textBox_0 = new TextBox();
        this.label_1 = new Label();
        this.nullableDateTimePicker_0 = new NullableDateTimePicker();
        this.label_2 = new Label();
        this.comboBox_0 = new ComboBox();
        this.label_3 = new Label();
        this.richTextBox_0 = new RichTextBox();
        this.button_0 = new Button();
        this.button_1 = new Button();
        base.SuspendLayout();
        this.label_0.AutoSize = true;
        this.label_0.Location = new Point(12, 9);
        this.label_0.Name = "label1";
        this.label_0.Size = new Size(0x4b, 13);
        this.label_0.TabIndex = 0;
        this.label_0.Text = "№ документа";
        this.textBox_0.Location = new Point(0x5d, 6);
        this.textBox_0.Name = "txtNumDoc";
        this.textBox_0.Size = new Size(0x56, 20);
        this.textBox_0.TabIndex = 1;
        this.label_1.AutoSize = true;
        this.label_1.Location = new Point(0xb9, 9);
        this.label_1.Name = "label2";
        this.label_1.Size = new Size(90, 13);
        this.label_1.TabIndex = 2;
        this.label_1.Text = "Дата документа";
        this.nullableDateTimePicker_0.Location = new Point(0x119, 6);
        this.nullableDateTimePicker_0.Name = "dtpDate";
        this.nullableDateTimePicker_0.Size = new Size(0x8f, 20);
        this.nullableDateTimePicker_0.TabIndex = 3;
        this.nullableDateTimePicker_0.set_Value(new DateTime(0x7df, 4, 0x1c, 9, 0x10, 0x35, 420));
        this.label_2.AutoSize = true;
        this.label_2.Location = new Point(12, 0x23);
        this.label_2.Name = "label3";
        this.label_2.Size = new Size(0x53, 13);
        this.label_2.TabIndex = 4;
        this.label_2.Text = "Тип документа";
        this.comboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        this.comboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
        this.comboBox_0.FormattingEnabled = true;
        this.comboBox_0.Location = new Point(0x5d, 0x20);
        this.comboBox_0.Name = "cmbTypeDoc";
        this.comboBox_0.Size = new Size(0x14b, 0x15);
        this.comboBox_0.TabIndex = 5;
        this.label_3.AutoSize = true;
        this.label_3.Location = new Point(12, 0x3d);
        this.label_3.Name = "label4";
        this.label_3.Size = new Size(0x4d, 13);
        this.label_3.TabIndex = 6;
        this.label_3.Text = "Комментарий";
        this.richTextBox_0.AcceptsTab = true;
        this.richTextBox_0.Location = new Point(15, 0x4d);
        this.richTextBox_0.Name = "txtComment";
        this.richTextBox_0.Size = new Size(0x199, 0x60);
        this.richTextBox_0.TabIndex = 7;
        this.richTextBox_0.Text = "";
        this.button_0.DialogResult = DialogResult.OK;
        this.button_0.Location = new Point(15, 180);
        this.button_0.Name = "buttonOK";
        this.button_0.Size = new Size(0x4b, 0x17);
        this.button_0.TabIndex = 8;
        this.button_0.Text = "ОК";
        this.button_0.UseVisualStyleBackColor = true;
        this.button_1.DialogResult = DialogResult.Cancel;
        this.button_1.Location = new Point(0x15d, 180);
        this.button_1.Name = "buutonCancel";
        this.button_1.Size = new Size(0x4b, 0x17);
        this.button_1.TabIndex = 9;
        this.button_1.Text = "Отмена";
        this.button_1.UseVisualStyleBackColor = true;
        base.AcceptButton = this.button_0;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.CancelButton = this.button_1;
        base.ClientSize = new Size(0x1af, 0xd7);
        base.Controls.Add(this.button_1);
        base.Controls.Add(this.button_0);
        base.Controls.Add(this.richTextBox_0);
        base.Controls.Add(this.label_3);
        base.Controls.Add(this.comboBox_0);
        base.Controls.Add(this.label_2);
        base.Controls.Add(this.nullableDateTimePicker_0);
        base.Controls.Add(this.label_1);
        base.Controls.Add(this.textBox_0);
        base.Controls.Add(this.label_0);
        base.FormBorderStyle = FormBorderStyle.FixedDialog;
        base.MaximizeBox = false;
        base.MinimizeBox = false;
        base.Name = "FormDocInAddEdit";
        this.Text = "Регламентирующий документ";
        base.FormClosing += new FormClosingEventHandler(this.Form10_FormClosing);
        base.Load += new EventHandler(this.Form10_Load);
        base.ResumeLayout(false);
        base.PerformLayout();
    }
}

