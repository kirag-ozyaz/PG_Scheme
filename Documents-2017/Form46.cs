using ControlsLbr;
using Documents.Forms.JournalExcavation;
using FormLbr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

internal class Form46 : FormBase
{
    private Button button_0;
    private Button button_1;
    private ComboBox comboBox_0;
    private DataSetExcavation dataSetExcavation_0;
    private Dictionary<string, string> dictionary_0;
    private IContainer icontainer_0;
    private int int_0;
    private int int_1;
    private KladrStreetControl kladrStreetControl_0;
    private Label label_0;
    private Label label_1;
    private Label label_2;
    private int? nullable_0;
    private int? nullable_1;
    private RichTextBox richTextBox_0;
    private string string_0;
    private string string_1;
    private TextBox textBox_0;

    public Form46()
    {
        this.int_0 = -1;
        this.int_1 = -1;
        this.dictionary_0 = new Dictionary<string, string>();
        this.method_7();
        this.method_6();
    }

    public Form46(int int_2, int int_3)
    {
        this.int_0 = -1;
        this.int_1 = -1;
        this.dictionary_0 = new Dictionary<string, string>();
        this.method_7();
        this.int_1 = int_3;
        this.int_0 = int_2;
        this.method_6();
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.icontainer_0 != null))
        {
            this.icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    private void Form46_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (base.DialogResult == DialogResult.OK)
        {
            if ((this.kladrStreetControl_0.get_SelectedStreet().get_SelectedValue() == null) || (this.kladrStreetControl_0.get_SelectedStreet().get_SelectedValue() == DBNull.Value))
            {
                MessageBox.Show("Не выбрана улица");
                e.Cancel = true;
            }
            else if (this.comboBox_0.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран район");
                e.Cancel = true;
            }
            else
            {
                if (this.comboBox_0.SelectedIndex != -1)
                {
                    this.dataSetExcavation_0.tJ_ExcavationAddress.Rows[0]["idregion"] = this.comboBox_0.SelectedValue;
                }
                this.dataSetExcavation_0.tJ_ExcavationAddress.Rows[0]["idStreet"] = this.kladrStreetControl_0.get_SelectedStreet().get_SelectedValue();
                this.dataSetExcavation_0.tJ_ExcavationAddress.Rows[0].EndEdit();
                if (this.int_1 != -1)
                {
                    if (this.int_0 == -1)
                    {
                        this.int_0 = base.InsertSqlDataOneRow(this.dataSetExcavation_0, this.dataSetExcavation_0.tJ_ExcavationAddress);
                    }
                    else
                    {
                        base.UpdateSqlData(this.dataSetExcavation_0, this.dataSetExcavation_0.tJ_ExcavationAddress);
                    }
                }
            }
        }
    }

    private void Form46_Load(object sender, EventArgs e)
    {
        base.SelectSqlData(this.dataSetExcavation_0, this.dataSetExcavation_0.tR_Classifier, true, " where ParentKey = ';CityRaion;UlyanovskRaion;' and isGRoup = 0 and deleted = 0 order by name");
        this.comboBox_0.SelectedIndex = -1;
        this.kladrStreetControl_0.set_SqlSettings(this.get_SqlSettings());
        if (this.int_1 != -1)
        {
            if (this.int_0 == -1)
            {
                DataRow row = this.dataSetExcavation_0.tJ_ExcavationAddress.NewRow();
                row["idExcavation"] = this.int_1;
                this.dataSetExcavation_0.tJ_ExcavationAddress.Rows.Add(row);
            }
            else
            {
                base.SelectSqlData(this.dataSetExcavation_0, this.dataSetExcavation_0.tJ_ExcavationAddress, true, " where id = " + this.int_0.ToString());
                if (this.dataSetExcavation_0.tJ_ExcavationAddress.Rows.Count > 0)
                {
                    this.kladrStreetControl_0.SetStreetValue(Convert.ToInt32(this.dataSetExcavation_0.tJ_ExcavationAddress.Rows[0]["idStreet"]));
                }
                else
                {
                    this.button_0.Enabled = false;
                }
            }
        }
        else
        {
            DataRow row2 = this.dataSetExcavation_0.tJ_ExcavationAddress.NewRow();
            row2["idExcavation"] = this.int_1;
            if (this.nullable_1.HasValue)
            {
                row2["idStreet"] = this.nullable_1;
                this.kladrStreetControl_0.SetStreetValue(Convert.ToInt32(this.nullable_1));
            }
            if (this.nullable_0.HasValue)
            {
                row2["idRegion"] = this.nullable_0;
            }
            if (!string.IsNullOrEmpty(this.string_0))
            {
                row2["house"] = this.string_0;
            }
            if (!string.IsNullOrEmpty(this.string_1))
            {
                row2["comment"] = this.string_1;
            }
            this.dataSetExcavation_0.tJ_ExcavationAddress.Rows.Add(row2);
        }
        this.kladrStreetControl_0.add_ChangeStreetSelect(new EventHandler(this.kladrStreetControl_0_ChangeStreetSelect));
    }

    private void kladrStreetControl_0_ChangeStreetSelect(object sender, EventArgs e)
    {
        if ((this.kladrStreetControl_0.get_SelectedStreet().get_SelectedValue() != null) && (this.kladrStreetControl_0.get_SelectedStreet().get_SelectedValue() != DBNull.Value))
        {
            DataTable table = base.SelectSqlData("tr_KladrStreet", true, " where id = " + this.kladrStreetControl_0.get_SelectedStreet().get_SelectedValue().ToString());
            if ((table.Rows.Count > 0) && (table.Rows[0]["GNINMB"] != DBNull.Value))
            {
                this.comboBox_0.Text = this.dictionary_0[table.Rows[0]["GNINMB"].ToString()];
            }
        }
    }

    internal int? method_0()
    {
        if ((this.comboBox_0.SelectedValue != null) && (this.comboBox_0.SelectedValue != DBNull.Value))
        {
            return new int?(Convert.ToInt32(this.comboBox_0.SelectedValue));
        }
        return null;
    }

    internal void method_1(int? nullable_2)
    {
        this.nullable_0 = nullable_2;
    }

    internal int? method_2()
    {
        if ((this.kladrStreetControl_0.get_SelectedStreet().get_SelectedValue() != null) && (this.kladrStreetControl_0.get_SelectedStreet().get_SelectedValue() != DBNull.Value))
        {
            return new int?(Convert.ToInt32(this.kladrStreetControl_0.get_SelectedStreet().get_SelectedValue()));
        }
        return null;
    }

    internal void method_3(int? nullable_2)
    {
        this.nullable_1 = nullable_2;
    }

    internal string method_4()
    {
        return this.textBox_0.Text;
    }

    internal void method_5(string string_2)
    {
        this.string_0 = string_2;
    }

    private void method_6()
    {
        this.Text = (this.int_0 == -1) ? "Новый адрес" : "Редактирование адреса";
        this.dictionary_0.Add("7325", "Ленинский");
        this.dictionary_0.Add("7328", "Заволжский");
        this.dictionary_0.Add("7327", "Засвияжский");
        this.dictionary_0.Add("7326", "Железнодорожный");
        this.kladrStreetControl_0.get_CmbStreet().Focus();
        this.kladrStreetControl_0.get_CmbStreet().Select();
    }

    private void method_7()
    {
        this.kladrStreetControl_0 = new KladrStreetControl();
        this.label_0 = new Label();
        this.textBox_0 = new TextBox();
        this.dataSetExcavation_0 = new DataSetExcavation();
        this.label_1 = new Label();
        this.richTextBox_0 = new RichTextBox();
        this.button_0 = new Button();
        this.button_1 = new Button();
        this.label_2 = new Label();
        this.comboBox_0 = new ComboBox();
        this.dataSetExcavation_0.BeginInit();
        base.SuspendLayout();
        this.kladrStreetControl_0.Location = new Point(12, 12);
        this.kladrStreetControl_0.Name = "kladrStreetControl1";
        this.kladrStreetControl_0.Size = new Size(0xae, 0xa8);
        this.kladrStreetControl_0.set_SqlSettings(null);
        this.kladrStreetControl_0.TabIndex = 0;
        this.kladrStreetControl_0.set_VisibleCmbTypeHouse(false);
        this.label_0.AutoSize = true;
        this.label_0.Location = new Point(0xbd, 0x3a);
        this.label_0.Name = "label1";
        this.label_0.Size = new Size(70, 13);
        this.label_0.TabIndex = 3;
        this.label_0.Text = "Номер дома";
        this.textBox_0.DataBindings.Add(new Binding("Text", this.dataSetExcavation_0, "tJ_ExcavationAddress.House", true));
        this.textBox_0.Location = new Point(0xc0, 0x4a);
        this.textBox_0.Name = "textBoxHouse";
        this.textBox_0.Size = new Size(0xd3, 20);
        this.textBox_0.TabIndex = 4;
        this.dataSetExcavation_0.DataSetName = "DataSetExcavation";
        this.dataSetExcavation_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        this.label_1.AutoSize = true;
        this.label_1.Location = new Point(0xbd, 0x61);
        this.label_1.Name = "label2";
        this.label_1.Size = new Size(70, 13);
        this.label_1.TabIndex = 5;
        this.label_1.Text = "Примечание";
        this.richTextBox_0.DataBindings.Add(new Binding("Text", this.dataSetExcavation_0, "tJ_ExcavationAddress.Comment", true));
        this.richTextBox_0.Location = new Point(0xc0, 0x71);
        this.richTextBox_0.Name = "richTextBoxComment";
        this.richTextBox_0.Size = new Size(0xd3, 0x3a);
        this.richTextBox_0.TabIndex = 6;
        this.richTextBox_0.Text = "";
        this.button_0.DialogResult = DialogResult.OK;
        this.button_0.Location = new Point(12, 0xba);
        this.button_0.Name = "buttonOK";
        this.button_0.Size = new Size(0x4b, 0x17);
        this.button_0.TabIndex = 7;
        this.button_0.Text = "ОК";
        this.button_0.UseVisualStyleBackColor = true;
        this.button_1.DialogResult = DialogResult.Cancel;
        this.button_1.Location = new Point(0x148, 0xba);
        this.button_1.Name = "buttonCancel";
        this.button_1.Size = new Size(0x4b, 0x17);
        this.button_1.TabIndex = 8;
        this.button_1.Text = "Отмена";
        this.button_1.UseVisualStyleBackColor = true;
        this.label_2.AutoSize = true;
        this.label_2.Location = new Point(0xc0, 12);
        this.label_2.Name = "label3";
        this.label_2.Size = new Size(0x26, 13);
        this.label_2.TabIndex = 1;
        this.label_2.Text = "Район";
        this.comboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        this.comboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
        this.comboBox_0.DataBindings.Add(new Binding("SelectedValue", this.dataSetExcavation_0, "tJ_ExcavationAddress.idRegion", true));
        this.comboBox_0.DataSource = this.dataSetExcavation_0;
        this.comboBox_0.DisplayMember = "tR_Classifier.Name";
        this.comboBox_0.FormattingEnabled = true;
        this.comboBox_0.Location = new Point(0xc0, 0x1c);
        this.comboBox_0.Name = "comboBoxRegion";
        this.comboBox_0.Size = new Size(0xd3, 0x15);
        this.comboBox_0.TabIndex = 2;
        this.comboBox_0.ValueMember = "tR_Classifier.Id";
        base.AcceptButton = this.button_0;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.CancelButton = this.button_1;
        base.ClientSize = new Size(0x19f, 0xdb);
        base.Controls.Add(this.comboBox_0);
        base.Controls.Add(this.label_2);
        base.Controls.Add(this.button_1);
        base.Controls.Add(this.button_0);
        base.Controls.Add(this.richTextBox_0);
        base.Controls.Add(this.label_1);
        base.Controls.Add(this.textBox_0);
        base.Controls.Add(this.label_0);
        base.Controls.Add(this.kladrStreetControl_0);
        base.FormBorderStyle = FormBorderStyle.FixedDialog;
        base.MaximizeBox = false;
        base.MinimizeBox = false;
        base.Name = "FormExcavationAddressAddEdit";
        this.Text = "Новый адрес";
        base.FormClosing += new FormClosingEventHandler(this.Form46_FormClosing);
        base.Load += new EventHandler(this.Form46_Load);
        this.dataSetExcavation_0.EndInit();
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    internal string Comment
    {
        get
        {
            return this.richTextBox_0.Text;
        }
        set
        {
            this.string_1 = value;
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

