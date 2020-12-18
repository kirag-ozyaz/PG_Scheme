using DataSql;
using Documents.DataSets;
using FormLbr;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

internal class Form4 : FormBase
{
    public BindingSource bindingSource_0;
    private BindingSource bindingSource_1;
    private BindingSource bindingSource_2;
    private BindingSource bindingSource_3;
    private BindingSource bindingSource_4;
    private Button button_0;
    private Button button_1;
    private CheckBox checkBox_0;
    private CheckBox checkBox_1;
    private CheckBox checkBox_2;
    private CheckBox checkBox_3;
    private Class204 class204_0;
    private Class207 class207_0;
    private Class208 class208_0;
    private Class210 class210_0;
    private Class211 class211_0;
    private ComboBox comboBox_0;
    private ComboBox comboBox_1;
    private DateTimePicker dateTimePicker_0;
    private IContainer icontainer_0;
    private int int_0;
    private Label label_0;
    private Label label_1;
    private Label label_2;
    private Label label_3;
    private Label label_4;
    private Label label_5;
    private Label label_6;
    private MaskedTextBox maskedTextBox_0;
    private OrgDataSet orgDataSet_0;
    private TextBox textBox_0;
    private TextBox textBox_1;
    private TextBox textBox_2;

    public Form4(int int_1, SQLSettings sqlsettings_0)
    {
        this.method_0();
        this.set_SqlSettings(sqlsettings_0);
        this.int_0 = int_1;
        this.class210_0.method_1().ConnectionString = this.get_SqlSettings().GetConnectionString();
        this.class208_0.method_1().ConnectionString = this.get_SqlSettings().GetConnectionString();
        this.class211_0.method_1().ConnectionString = this.get_SqlSettings().GetConnectionString();
        this.class207_0.method_1().ConnectionString = this.get_SqlSettings().GetConnectionString();
        this.class204_0.method_1().ConnectionString = this.get_SqlSettings().GetConnectionString();
    }

    private void checkBox_1_CheckedChanged(object sender, EventArgs e)
    {
        this.textBox_1.ReadOnly = this.checkBox_1.Checked;
        this.textBox_2.ReadOnly = this.checkBox_1.Checked;
        this.checkBox_2.Enabled = !this.checkBox_1.Checked;
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.icontainer_0 != null))
        {
            this.icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    private void Form4_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (base.DialogResult == DialogResult.OK)
        {
            if (this.comboBox_0.SelectedIndex == -1)
            {
                string text = this.comboBox_0.Text;
                this.bindingSource_4.AddNew();
                ((OrgDataSet.Class419) ((DataRowView) this.bindingSource_4.Current).Row).Point = text;
                this.bindingSource_4.EndEdit();
                this.class211_0.vmethod_2(this.orgDataSet_0.tblAbnAplConnectPointForIndividualUsers);
                ((OrgDataSet.Class415) ((DataRowView) this.bindingSource_0.Current).Row).PlaceId = ((OrgDataSet.Class419) ((DataRowView) this.bindingSource_4.Current).Row).Id;
            }
            if (this.comboBox_1.SelectedIndex == -1)
            {
                string str2 = this.comboBox_1.Text;
                this.bindingSource_1.AddNew();
                ((OrgDataSet.Class412) ((DataRowView) this.bindingSource_1.Current).Row).Reason = str2;
                ((OrgDataSet.Class412) ((DataRowView) this.bindingSource_1.Current).Row).method_1(this.int_0);
                this.bindingSource_1.EndEdit();
                this.class204_0.vmethod_2(this.orgDataSet_0.tblAbnAplForDisconReason);
                ((OrgDataSet.Class415) ((DataRowView) this.bindingSource_0.Current).Row).Reason = ((OrgDataSet.Class412) ((DataRowView) this.bindingSource_1.Current).Row).Id;
            }
            ((OrgDataSet.Class415) ((DataRowView) this.bindingSource_0.Current).Row).Point = this.comboBox_0.Text;
            this.bindingSource_0.EndEdit();
        }
        else
        {
            this.bindingSource_0.CancelEdit();
        }
    }

    private void Form4_Load(object sender, EventArgs e)
    {
        this.class211_0.vmethod_0(this.orgDataSet_0.tblAbnAplConnectPointForIndividualUsers);
        this.class204_0.vmethod_0(this.orgDataSet_0.tblAbnAplForDisconReason, new int?(this.int_0));
    }

    private void maskedTextBox_0_TextChanged(object sender, EventArgs e)
    {
        new Class216();
        if (this.checkBox_1.Checked)
        {
            if (this.maskedTextBox_0.Text.Length > 0)
            {
                this.class208_0.vmethod_0(this.orgDataSet_0.tAbonent, Convert.ToInt32(this.maskedTextBox_0.Text));
                if (this.bindingSource_2.Count > 0)
                {
                    OrgDataSet.Class416 row = (OrgDataSet.Class416) ((DataRowView) this.bindingSource_2[0]).Row;
                    this.dateTimePicker_0.Value = row.method_2();
                    this.textBox_1.Text = row.FIO;
                    this.textBox_2.Text = row.Address;
                }
                else
                {
                    this.dateTimePicker_0.Value = DateTime.Today;
                    this.textBox_1.Text = string.Empty;
                    this.textBox_2.Text = string.Empty;
                    this.checkBox_2.Checked = false;
                    this.checkBox_3.Checked = true;
                }
            }
            else
            {
                this.class208_0.vmethod_0(this.orgDataSet_0.tAbonent, -1);
            }
        }
    }

    private void method_0()
    {
        this.icontainer_0 = new Container();
        ComponentResourceManager manager = new ComponentResourceManager(typeof(Form4));
        this.label_0 = new Label();
        this.label_1 = new Label();
        this.label_2 = new Label();
        this.label_3 = new Label();
        this.label_4 = new Label();
        this.checkBox_0 = new CheckBox();
        this.bindingSource_0 = new BindingSource(this.icontainer_0);
        this.orgDataSet_0 = new OrgDataSet();
        this.textBox_0 = new TextBox();
        this.button_0 = new Button();
        this.button_1 = new Button();
        this.maskedTextBox_0 = new MaskedTextBox();
        this.textBox_1 = new TextBox();
        this.textBox_2 = new TextBox();
        this.comboBox_0 = new ComboBox();
        this.bindingSource_4 = new BindingSource(this.icontainer_0);
        this.comboBox_1 = new ComboBox();
        this.bindingSource_1 = new BindingSource(this.icontainer_0);
        this.label_5 = new Label();
        this.checkBox_1 = new CheckBox();
        this.label_6 = new Label();
        this.dateTimePicker_0 = new DateTimePicker();
        this.class207_0 = new Class207();
        this.class204_0 = new Class204();
        this.bindingSource_2 = new BindingSource(this.icontainer_0);
        this.class208_0 = new Class208();
        this.bindingSource_3 = new BindingSource(this.icontainer_0);
        this.class210_0 = new Class210();
        this.class211_0 = new Class211();
        this.checkBox_2 = new CheckBox();
        this.checkBox_3 = new CheckBox();
        ((ISupportInitialize) this.bindingSource_0).BeginInit();
        this.orgDataSet_0.BeginInit();
        ((ISupportInitialize) this.bindingSource_4).BeginInit();
        ((ISupportInitialize) this.bindingSource_1).BeginInit();
        ((ISupportInitialize) this.bindingSource_2).BeginInit();
        ((ISupportInitialize) this.bindingSource_3).BeginInit();
        base.SuspendLayout();
        this.label_0.AutoSize = true;
        this.label_0.Location = new Point(12, 9);
        this.label_0.Name = "label1";
        this.label_0.Size = new Size(0x1a, 13);
        this.label_0.TabIndex = 0;
        this.label_0.Text = "Код";
        this.label_1.AutoSize = true;
        this.label_1.Location = new Point(12, 60);
        this.label_1.Name = "label2";
        this.label_1.Size = new Size(0x22, 13);
        this.label_1.TabIndex = 0;
        this.label_1.Text = "ФИО";
        this.label_2.AutoSize = true;
        this.label_2.Location = new Point(12, 0x53);
        this.label_2.Name = "label3";
        this.label_2.Size = new Size(0x26, 13);
        this.label_2.TabIndex = 0;
        this.label_2.Text = "Адрес";
        this.label_3.AutoSize = true;
        this.label_3.Location = new Point(12, 0x84);
        this.label_3.Name = "label4";
        this.label_3.Size = new Size(100, 13);
        this.label_3.TabIndex = 0;
        this.label_3.Text = "Пункт отключения";
        this.label_4.AutoSize = true;
        this.label_4.Location = new Point(12, 0x9f);
        this.label_4.Name = "label5";
        this.label_4.Size = new Size(50, 13);
        this.label_4.TabIndex = 0;
        this.label_4.Text = "Причина";
        this.checkBox_0.AutoSize = true;
        this.checkBox_0.DataBindings.Add(new Binding("Checked", this.bindingSource_0, "IsNC", true));
        this.checkBox_0.Enabled = false;
        this.checkBox_0.Location = new Point(0x134, 0x22);
        this.checkBox_0.Name = "checkBox1";
        this.checkBox_0.Size = new Size(0x4d, 0x11);
        this.checkBox_0.TabIndex = 1;
        this.checkBox_0.Text = "Заволжье";
        this.checkBox_0.UseVisualStyleBackColor = true;
        this.checkBox_0.Visible = false;
        this.bindingSource_0.DataMember = "tblAbnAplForDisconIndividualUsers";
        this.bindingSource_0.DataSource = this.orgDataSet_0;
        this.orgDataSet_0.DataSetName = "OrgDataSet";
        this.orgDataSet_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        this.textBox_0.DataBindings.Add(new Binding("Text", this.bindingSource_0, "Comments", true));
        this.textBox_0.Location = new Point(15, 0xdb);
        this.textBox_0.MaxLength = 0xff;
        this.textBox_0.Multiline = true;
        this.textBox_0.Name = "textBoxComments";
        this.textBox_0.Size = new Size(0x189, 0x44);
        this.textBox_0.TabIndex = 2;
        this.button_0.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
        this.button_0.DialogResult = DialogResult.Cancel;
        this.button_0.Location = new Point(330, 0x128);
        this.button_0.Name = "buttonCancel";
        this.button_0.Size = new Size(0x4b, 0x17);
        this.button_0.TabIndex = 3;
        this.button_0.Text = "Отмена";
        this.button_0.UseVisualStyleBackColor = true;
        this.button_1.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
        this.button_1.DialogResult = DialogResult.OK;
        this.button_1.Location = new Point(0xf9, 0x128);
        this.button_1.Name = "buttonOk";
        this.button_1.Size = new Size(0x4b, 0x17);
        this.button_1.TabIndex = 3;
        this.button_1.Text = "Готово";
        this.button_1.UseVisualStyleBackColor = true;
        this.maskedTextBox_0.DataBindings.Add(new Binding("Text", this.bindingSource_0, "Code", true));
        this.maskedTextBox_0.Location = new Point(0x4f, 6);
        this.maskedTextBox_0.Mask = "999999999";
        this.maskedTextBox_0.Name = "maskedTextBox1";
        this.maskedTextBox_0.Size = new Size(0xdd, 20);
        this.maskedTextBox_0.TabIndex = 4;
        this.maskedTextBox_0.TextChanged += new EventHandler(this.maskedTextBox_0_TextChanged);
        this.textBox_1.DataBindings.Add(new Binding("Text", this.bindingSource_0, "FIO", true));
        this.textBox_1.Location = new Point(0x4f, 0x39);
        this.textBox_1.Name = "textBox1";
        this.textBox_1.Size = new Size(0xdd, 20);
        this.textBox_1.TabIndex = 5;
        this.textBox_2.DataBindings.Add(new Binding("Text", this.bindingSource_0, "Address", true));
        this.textBox_2.Location = new Point(0x4f, 80);
        this.textBox_2.Name = "textBox2";
        this.textBox_2.Size = new Size(0xdd, 20);
        this.textBox_2.TabIndex = 5;
        this.comboBox_0.DataBindings.Add(new Binding("SelectedValue", this.bindingSource_0, "PlaceId", true));
        this.comboBox_0.DataSource = this.bindingSource_4;
        this.comboBox_0.DisplayMember = "Point";
        this.comboBox_0.FormattingEnabled = true;
        this.comboBox_0.Location = new Point(0x76, 0x81);
        this.comboBox_0.Name = "comboBox1";
        this.comboBox_0.Size = new Size(0xb6, 0x15);
        this.comboBox_0.TabIndex = 6;
        this.comboBox_0.ValueMember = "Id";
        this.bindingSource_4.DataMember = "tblAbnAplConnectPointForIndividualUsers";
        this.bindingSource_4.DataSource = this.orgDataSet_0;
        this.comboBox_1.DataBindings.Add(new Binding("SelectedValue", this.bindingSource_0, "Reason", true));
        this.comboBox_1.DataSource = this.bindingSource_1;
        this.comboBox_1.DisplayMember = "Reason";
        this.comboBox_1.FormattingEnabled = true;
        this.comboBox_1.Location = new Point(0x76, 0x9c);
        this.comboBox_1.Name = "comboBox2";
        this.comboBox_1.Size = new Size(0xb6, 0x15);
        this.comboBox_1.TabIndex = 6;
        this.comboBox_1.ValueMember = "Id";
        this.bindingSource_1.DataMember = "tblAbnAplForDisconReason";
        this.bindingSource_1.DataSource = this.orgDataSet_0;
        this.label_5.AutoSize = true;
        this.label_5.Location = new Point(12, 0xcb);
        this.label_5.Name = "label6";
        this.label_5.Size = new Size(70, 13);
        this.label_5.TabIndex = 0;
        this.label_5.Text = "Примечание";
        this.checkBox_1.AutoSize = true;
        this.checkBox_1.Location = new Point(0x134, 8);
        this.checkBox_1.Name = "checkBox2";
        this.checkBox_1.Size = new Size(110, 0x11);
        this.checkBox_1.TabIndex = 7;
        this.checkBox_1.Text = "Автозаполнение";
        this.checkBox_1.UseVisualStyleBackColor = true;
        this.checkBox_1.CheckedChanged += new EventHandler(this.checkBox_1_CheckedChanged);
        this.label_6.AutoSize = true;
        this.label_6.Location = new Point(12, 0x23);
        this.label_6.Name = "label7";
        this.label_6.Size = new Size(0x21, 13);
        this.label_6.TabIndex = 0;
        this.label_6.Text = "Дата";
        this.dateTimePicker_0.DataBindings.Add(new Binding("Value", this.bindingSource_0, "DateDog", true));
        this.dateTimePicker_0.Location = new Point(0x4f, 0x1f);
        this.dateTimePicker_0.Name = "dateTimePicker1";
        this.dateTimePicker_0.Size = new Size(0xdd, 20);
        this.dateTimePicker_0.TabIndex = 8;
        this.class207_0.method_7(true);
        this.class204_0.method_7(true);
        this.bindingSource_2.DataMember = "tAbonent";
        this.bindingSource_2.DataSource = this.orgDataSet_0;
        this.class208_0.method_7(true);
        this.bindingSource_3.DataMember = "tAbonentNC";
        this.bindingSource_3.DataSource = this.orgDataSet_0;
        this.class210_0.method_7(true);
        this.class211_0.method_7(true);
        this.checkBox_2.AutoSize = true;
        this.checkBox_2.Location = new Point(15, 0x6a);
        this.checkBox_2.Name = "matrixСheckBox";
        this.checkBox_2.Size = new Size(0xb5, 0x11);
        this.checkBox_2.TabIndex = 9;
        this.checkBox_2.Text = "Абонент подключён к матрице";
        this.checkBox_2.UseVisualStyleBackColor = true;
        this.checkBox_3.AutoSize = true;
        this.checkBox_3.DataBindings.Add(new Binding("Checked", this.bindingSource_0, "IsFullRestriction", true));
        this.checkBox_3.Location = new Point(15, 0xb7);
        this.checkBox_3.Name = "cbFullRestriction";
        this.checkBox_3.Size = new Size(0x83, 0x11);
        this.checkBox_3.TabIndex = 9;
        this.checkBox_3.Text = "Полное ограничение";
        this.checkBox_3.UseVisualStyleBackColor = true;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(0x1a1, 0x14b);
        base.Controls.Add(this.checkBox_3);
        base.Controls.Add(this.checkBox_2);
        base.Controls.Add(this.dateTimePicker_0);
        base.Controls.Add(this.checkBox_1);
        base.Controls.Add(this.comboBox_1);
        base.Controls.Add(this.comboBox_0);
        base.Controls.Add(this.textBox_2);
        base.Controls.Add(this.textBox_1);
        base.Controls.Add(this.maskedTextBox_0);
        base.Controls.Add(this.button_1);
        base.Controls.Add(this.button_0);
        base.Controls.Add(this.textBox_0);
        base.Controls.Add(this.checkBox_0);
        base.Controls.Add(this.label_5);
        base.Controls.Add(this.label_4);
        base.Controls.Add(this.label_3);
        base.Controls.Add(this.label_6);
        base.Controls.Add(this.label_2);
        base.Controls.Add(this.label_1);
        base.Controls.Add(this.label_0);
        base.FormBorderStyle = FormBorderStyle.FixedDialog;
        base.Icon = (Icon) manager.GetObject("$this.Icon");
        base.MaximizeBox = false;
        base.MinimizeBox = false;
        base.Name = "FormIndividualUser";
        base.set_PermissionsSql(false);
        this.Text = "Физическое лицо";
        base.FormClosing += new FormClosingEventHandler(this.Form4_FormClosing);
        base.Load += new EventHandler(this.Form4_Load);
        ((ISupportInitialize) this.bindingSource_0).EndInit();
        this.orgDataSet_0.EndInit();
        ((ISupportInitialize) this.bindingSource_4).EndInit();
        ((ISupportInitialize) this.bindingSource_1).EndInit();
        ((ISupportInitialize) this.bindingSource_2).EndInit();
        ((ISupportInitialize) this.bindingSource_3).EndInit();
        base.ResumeLayout(false);
        base.PerformLayout();
    }
}

