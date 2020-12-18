using Documents.Forms.JournalExcavation;
using FormLbr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

internal class Form48 : FormBase
{
    private Button button_0;
    private Button button_1;
    private ComboBox comboBox_0;
    private DataSetExcavation dataSetExcavation_0;
    private Dictionary<string, string> dictionary_0;
    private Enum13 enum13_0;
    private IContainer icontainer_0;
    private int int_0;
    private int int_1;
    private Label label_0;
    private Label label_1;
    private Label label_2;
    private Label label_3;
    private TextBox textBox_0;
    private TextBox textBox_1;
    private TextBox textBox_2;

    public Form48()
    {
        this.int_0 = -1;
        this.int_1 = -1;
        this.dictionary_0 = new Dictionary<string, string>();
        this.method_3();
        this.method_2();
    }

    internal Form48(int int_2, int int_3, Enum13 enum13_1)
    {
        this.int_0 = -1;
        this.int_1 = -1;
        this.dictionary_0 = new Dictionary<string, string>();
        this.method_3();
        this.int_0 = int_2;
        this.int_1 = int_3;
        this.enum13_0 = enum13_1;
        this.method_2();
    }

    private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (((this.comboBox_0.SelectedIndex >= 0) && !string.IsNullOrEmpty(this.comboBox_0.Text)) && this.dictionary_0.ContainsKey(this.comboBox_0.Text))
        {
            this.dataSetExcavation_0.tJ_ExcavationSurface.Rows[0]["unit"] = this.dictionary_0[this.comboBox_0.Text];
            this.textBox_1.Text = this.dictionary_0[this.comboBox_0.Text];
        }
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.icontainer_0 != null))
        {
            this.icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    private void Form48_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (base.DialogResult == DialogResult.OK)
        {
            if (this.comboBox_0.SelectedIndex < 0)
            {
                MessageBox.Show("не введены обязательные поля");
                e.Cancel = true;
            }
            else
            {
                if (this.enum13_0 == Enum13.const_0)
                {
                    this.dataSetExcavation_0.tJ_ExcavationSurface.Rows[0]["Value"] = DBNull.Value;
                    this.dataSetExcavation_0.tJ_ExcavationSurface.Rows[0]["Unit"] = DBNull.Value;
                }
                if (this.int_0 == -1)
                {
                    this.dataSetExcavation_0.tJ_ExcavationSurface.Rows[0].EndEdit();
                    this.int_0 = base.InsertSqlDataOneRow(this.dataSetExcavation_0, this.dataSetExcavation_0.tJ_ExcavationSurface);
                }
                else
                {
                    this.dataSetExcavation_0.tJ_ExcavationSurface.Rows[0].EndEdit();
                    base.UpdateSqlData(this.dataSetExcavation_0, this.dataSetExcavation_0.tJ_ExcavationSurface);
                }
            }
        }
    }

    private void Form48_Load(object sender, EventArgs e)
    {
        switch (this.enum13_0)
        {
            case Enum13.const_0:
            case Enum13.const_1:
                base.SelectSqlData(this.dataSetExcavation_0, this.dataSetExcavation_0.tR_Classifier, true, " where ParentKey = ';Excavation;Surface;' and isGroup = 0 and deleted = 0 order by name");
                break;

            case Enum13.const_2:
                base.SelectSqlData(this.dataSetExcavation_0, this.dataSetExcavation_0.tR_Classifier, true, " where ParentKey = ';Excavation;Materials;' and isGroup = 0 and deleted = 0 order by name");
                break;
        }
        if (this.int_0 == -1)
        {
            DataRow row = this.dataSetExcavation_0.tJ_ExcavationSurface.NewRow();
            row["idExcavation"] = this.int_1;
            row["idType"] = (int) this.enum13_0;
            row["idSurface"] = -1;
            this.dataSetExcavation_0.tJ_ExcavationSurface.Rows.Add(row);
        }
        else
        {
            base.SelectSqlData(this.dataSetExcavation_0, this.dataSetExcavation_0.tJ_ExcavationSurface, true, "where id = " + this.int_0.ToString());
        }
        this.dataSetExcavation_0.tJ_ExcavationSurface.Rows[0].BeginEdit();
    }

    internal int method_0()
    {
        return this.int_0;
    }

    internal void method_1(int int_2)
    {
        this.int_0 = int_2;
    }

    private void method_2()
    {
        this.Text = (this.int_0 == -1) ? "Добавление " : "Редактирование ";
        switch (this.enum13_0)
        {
            case Enum13.const_0:
                this.Text = this.Text + "повреждения";
                this.textBox_0.Visible = false;
                this.textBox_1.Visible = false;
                this.label_1.Visible = false;
                this.label_2.Visible = false;
                base.Height = 0x9b;
                break;

            case Enum13.const_1:
                this.Text = this.Text + "площади восстановления";
                break;

            case Enum13.const_2:
                this.Text = this.Text + "материала";
                break;
        }
        this.dictionary_0.Add("песок", "тонн");
        this.dictionary_0.Add("семена", "кг");
        this.dictionary_0.Add("щебень", "тонн");
        this.dictionary_0.Add(@"бордюрный камень (б\у)", "м");
        this.dictionary_0.Add("тротуар", "кв.м");
        this.dictionary_0.Add("местный проезд", "кв.м");
        this.dictionary_0.Add("дорога", "кв.м");
        this.dictionary_0.Add("бордюрный камень", "м");
        this.dictionary_0.Add("грунт-зеленая зона", "кв.м");
        this.dictionary_0.Add("плитка", "кв.м");
    }

    private void method_3()
    {
        this.label_0 = new Label();
        this.comboBox_0 = new ComboBox();
        this.label_1 = new Label();
        this.textBox_0 = new TextBox();
        this.label_2 = new Label();
        this.textBox_1 = new TextBox();
        this.label_3 = new Label();
        this.textBox_2 = new TextBox();
        this.button_0 = new Button();
        this.button_1 = new Button();
        this.dataSetExcavation_0 = new DataSetExcavation();
        this.dataSetExcavation_0.BeginInit();
        base.SuspendLayout();
        this.label_0.AutoSize = true;
        this.label_0.Location = new Point(12, 0x12);
        this.label_0.Name = "label1";
        this.label_0.Size = new Size(0x39, 13);
        this.label_0.TabIndex = 0;
        this.label_0.Text = "Материал";
        this.comboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        this.comboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
        this.comboBox_0.DataBindings.Add(new Binding("SelectedValue", this.dataSetExcavation_0, "tJ_ExcavationSurface.idSurface", true));
        this.comboBox_0.DataSource = this.dataSetExcavation_0;
        this.comboBox_0.DisplayMember = "tR_Classifier.Name";
        this.comboBox_0.FormattingEnabled = true;
        this.comboBox_0.Location = new Point(0x5e, 15);
        this.comboBox_0.Name = "cmbSurface";
        this.comboBox_0.Size = new Size(0xf9, 0x15);
        this.comboBox_0.TabIndex = 1;
        this.comboBox_0.ValueMember = "tR_Classifier.Id";
        this.comboBox_0.SelectedIndexChanged += new EventHandler(this.comboBox_0_SelectedIndexChanged);
        this.label_1.AutoSize = true;
        this.label_1.Location = new Point(12, 0x2d);
        this.label_1.Name = "labelValue";
        this.label_1.Size = new Size(0x37, 13);
        this.label_1.TabIndex = 2;
        this.label_1.Text = "Значение";
        this.textBox_0.DataBindings.Add(new Binding("Text", this.dataSetExcavation_0, "tJ_ExcavationSurface.Value", true));
        this.textBox_0.Location = new Point(0x5e, 0x2a);
        this.textBox_0.Name = "txtValue";
        this.textBox_0.Size = new Size(0xf9, 20);
        this.textBox_0.TabIndex = 3;
        this.label_2.AutoSize = true;
        this.label_2.Location = new Point(12, 0x47);
        this.label_2.Name = "labelUnit";
        this.label_2.Size = new Size(0x4c, 13);
        this.label_2.TabIndex = 4;
        this.label_2.Text = "Единица изм.";
        this.textBox_1.DataBindings.Add(new Binding("Text", this.dataSetExcavation_0, "tJ_ExcavationSurface.unit", true));
        this.textBox_1.Location = new Point(0x5e, 0x44);
        this.textBox_1.Name = "txtUnit";
        this.textBox_1.Size = new Size(0xf9, 20);
        this.textBox_1.TabIndex = 5;
        this.label_3.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
        this.label_3.AutoSize = true;
        this.label_3.Location = new Point(12, 0x61);
        this.label_3.Name = "label4";
        this.label_3.Size = new Size(70, 13);
        this.label_3.TabIndex = 6;
        this.label_3.Text = "Примечание";
        this.textBox_2.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
        this.textBox_2.DataBindings.Add(new Binding("Text", this.dataSetExcavation_0, "tJ_ExcavationSurface.comment", true));
        this.textBox_2.Location = new Point(0x5e, 0x5e);
        this.textBox_2.Name = "txtComment";
        this.textBox_2.Size = new Size(0xf9, 20);
        this.textBox_2.TabIndex = 7;
        this.button_0.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
        this.button_0.DialogResult = DialogResult.OK;
        this.button_0.Location = new Point(15, 0x81);
        this.button_0.Name = "buttonOK";
        this.button_0.Size = new Size(0x4b, 0x17);
        this.button_0.TabIndex = 8;
        this.button_0.Text = "ОК";
        this.button_0.UseVisualStyleBackColor = true;
        this.button_1.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
        this.button_1.DialogResult = DialogResult.Cancel;
        this.button_1.Location = new Point(0x10c, 0x81);
        this.button_1.Name = "buttonCancel";
        this.button_1.Size = new Size(0x4b, 0x17);
        this.button_1.TabIndex = 9;
        this.button_1.Text = "Отмена";
        this.button_1.UseVisualStyleBackColor = true;
        this.dataSetExcavation_0.DataSetName = "DataSetExcavation";
        this.dataSetExcavation_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        base.AcceptButton = this.button_0;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.CancelButton = this.button_1;
        base.ClientSize = new Size(350, 0xa3);
        base.Controls.Add(this.button_1);
        base.Controls.Add(this.button_0);
        base.Controls.Add(this.textBox_2);
        base.Controls.Add(this.label_3);
        base.Controls.Add(this.textBox_1);
        base.Controls.Add(this.label_2);
        base.Controls.Add(this.textBox_0);
        base.Controls.Add(this.label_1);
        base.Controls.Add(this.comboBox_0);
        base.Controls.Add(this.label_0);
        base.Name = "FormExcavationSurfaceAddEdit";
        this.Text = "FormExcavationSurfaceAddEdit";
        base.FormClosing += new FormClosingEventHandler(this.Form48_FormClosing);
        base.Load += new EventHandler(this.Form48_Load);
        this.dataSetExcavation_0.EndInit();
        base.ResumeLayout(false);
        base.PerformLayout();
    }
}

