using FormLbr;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

internal class Form0 : FormBase
{
    private Button button_0;
    private Button button_1;
    private ComboBox comboBox_0;
    private IContainer icontainer_0;
    private int int_0;
    private Label label_0;
    private int? nullable_0;

    internal Form0()
    {
        this.method_1();
    }

    internal Form0(int int_1, int? nullable_1)
    {
        this.method_1();
        this.int_0 = int_1;
        this.nullable_0 = nullable_1;
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.icontainer_0 != null))
        {
            this.icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    private void Form0_FormClosing(object sender, FormClosingEventArgs e)
    {
        if ((base.DialogResult == DialogResult.OK) && (this.comboBox_0.SelectedIndex == -1))
        {
            base.DialogResult = DialogResult.Cancel;
        }
    }

    private void Form0_Load(object sender, EventArgs e)
    {
        DataTable table = new DataTable("vTC_Request");
        table.Columns.Add("id", typeof(int));
        table.Columns.Add("numdateIn", typeof(string));
        this.comboBox_0.DisplayMember = "numdatein";
        this.comboBox_0.ValueMember = "id";
        this.comboBox_0.DataSource = table;
        string str = "";
        if (!this.nullable_0.HasValue)
        {
            str = "where idAbn = " + this.int_0.ToString();
        }
        else
        {
            str = "where (idAbn = " + this.int_0.ToString() + " and idAbnObj is null) or idAbnObj = " + this.nullable_0.ToString();
        }
        base.SelectSqlData(table, true, str + " order by numdatein", false);
    }

    internal int? method_0()
    {
        if (this.comboBox_0.SelectedIndex == -1)
        {
            return null;
        }
        return new int?(Convert.ToInt32(this.comboBox_0.SelectedValue));
    }

    private void method_1()
    {
        this.comboBox_0 = new ComboBox();
        this.button_0 = new Button();
        this.button_1 = new Button();
        this.label_0 = new Label();
        base.SuspendLayout();
        this.comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
        this.comboBox_0.FormattingEnabled = true;
        this.comboBox_0.Location = new Point(12, 0x19);
        this.comboBox_0.Name = "comboBox1";
        this.comboBox_0.Size = new Size(0xe2, 0x15);
        this.comboBox_0.TabIndex = 0;
        this.button_0.DialogResult = DialogResult.OK;
        this.button_0.Location = new Point(12, 0x3f);
        this.button_0.Name = "buttonOK";
        this.button_0.Size = new Size(0x4b, 0x17);
        this.button_0.TabIndex = 1;
        this.button_0.Text = "ОК";
        this.button_0.UseVisualStyleBackColor = true;
        this.button_1.DialogResult = DialogResult.Cancel;
        this.button_1.Location = new Point(0xa3, 0x3f);
        this.button_1.Name = "buttonCancel";
        this.button_1.Size = new Size(0x4b, 0x17);
        this.button_1.TabIndex = 2;
        this.button_1.Text = "Отмена";
        this.button_1.UseVisualStyleBackColor = true;
        this.label_0.AutoSize = true;
        this.label_0.Location = new Point(12, 9);
        this.label_0.Name = "label1";
        this.label_0.Size = new Size(210, 13);
        this.label_0.TabIndex = 3;
        this.label_0.Text = "Выберите заявку на тех присоединение";
        base.AcceptButton = this.button_0;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.CancelButton = this.button_1;
        base.ClientSize = new Size(0xfe, 0x66);
        base.Controls.Add(this.label_0);
        base.Controls.Add(this.button_1);
        base.Controls.Add(this.button_0);
        base.Controls.Add(this.comboBox_0);
        base.FormBorderStyle = FormBorderStyle.FixedDialog;
        base.MaximizeBox = false;
        base.MinimizeBox = false;
        base.Name = "FormChoiceTechConnectionRequest";
        this.Text = "Выбор заявки на тех присоединение";
        base.FormClosing += new FormClosingEventHandler(this.Form0_FormClosing);
        base.Load += new EventHandler(this.Form0_Load);
        base.ResumeLayout(false);
        base.PerformLayout();
    }
}

