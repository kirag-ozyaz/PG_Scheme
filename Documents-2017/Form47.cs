using ControlsLbr;
using Documents.Forms.JournalExcavation;
using FormLbr;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

internal class Form47 : FormBase
{
    private Button button_0;
    private Button button_1;
    private ComboBox comboBox_0;
    private DataSetExcavation dataSetExcavation_0;
    private DateTimePicker dateTimePicker_0;
    private Enum12 enum12_0;
    private IContainer icontainer_0;
    private int int_0;
    private int int_1;
    private Label label_0;
    private Label label_1;
    private Label label_2;
    private Label label_3;
    private float? nullable_0;
    private DateTime? nullable_1;
    private NullableDateTimePicker nullableDateTimePicker_0;
    private RichTextBox richTextBox_0;
    private TableLayoutPanel tableLayoutPanel_0;

    public Form47()
    {
        this.int_0 = -1;
        this.int_1 = -1;
        this.method_3();
        this.method_2();
    }

    internal Form47(int int_2, int int_3, Enum12 enum12_1)
    {
        this.int_0 = -1;
        this.int_1 = -1;
        this.method_3();
        this.int_0 = int_3;
        this.int_1 = int_2;
        this.enum12_0 = enum12_1;
        this.method_2();
    }

    private void comboBox_0_SelectedValueChanged(object sender, EventArgs e)
    {
        if ((this.comboBox_0.SelectedValue != null) && (this.comboBox_0.SelectedValue != DBNull.Value))
        {
            DataRow[] rowArray = this.dataSetExcavation_0.tR_Classifier.Select("id = " + this.comboBox_0.SelectedValue.ToString());
            if (rowArray.Length != 0)
            {
                if (rowArray[0]["Value"] != DBNull.Value)
                {
                    this.nullable_0 = new float?(Convert.ToSingle(rowArray[0]["Value"]));
                }
                else
                {
                    this.nullable_0 = 0f;
                }
            }
            else
            {
                this.nullable_0 = null;
            }
        }
        else
        {
            this.nullable_0 = null;
        }
        float? nullable = this.nullable_0;
        float num = 4f;
        if (((nullable.GetValueOrDefault() == num) ? nullable.HasValue : false) && (this.enum12_0 == Enum12.const_0))
        {
            this.label_1.Visible = true;
            this.nullableDateTimePicker_0.Visible = true;
            this.nullableDateTimePicker_0.set_Value(this.nullable_1);
        }
        else
        {
            this.label_1.Visible = false;
            this.nullableDateTimePicker_0.Visible = false;
            if (this.nullableDateTimePicker_0.get_Value() == null)
            {
                this.nullable_1 = null;
            }
            else
            {
                this.nullable_1 = new DateTime?(Convert.ToDateTime(this.nullableDateTimePicker_0.get_Value()));
            }
            if (this.dataSetExcavation_0.tJ_ExcavationStatus.Rows.Count > 0)
            {
                this.dataSetExcavation_0.tJ_ExcavationStatus.Rows[0]["dateElongation"] = DBNull.Value;
            }
            this.nullableDateTimePicker_0.set_Value(null);
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

    private void Form47_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (base.DialogResult == DialogResult.OK)
        {
            if (this.comboBox_0.SelectedIndex < 0)
            {
                MessageBox.Show("Не выбран статус");
                e.Cancel = true;
            }
            else
            {
                if (this.enum12_0 == Enum12.const_0)
                {
                    float? nullable = this.nullable_0;
                    float num = 4f;
                    if (((nullable.GetValueOrDefault() == num) ? nullable.HasValue : false) && ((this.nullableDateTimePicker_0.get_Value() == null) || (this.nullableDateTimePicker_0.get_Value() == DBNull.Value)))
                    {
                        MessageBox.Show("Не указана дата продления");
                        e.Cancel = true;
                        return;
                    }
                }
                this.dataSetExcavation_0.tJ_ExcavationStatus.Rows[0].EndEdit();
                if (this.int_1 == -1)
                {
                    this.int_1 = base.InsertSqlDataOneRow(this.dataSetExcavation_0, this.dataSetExcavation_0.tJ_ExcavationStatus);
                }
                else
                {
                    base.UpdateSqlData(this.dataSetExcavation_0, this.dataSetExcavation_0.tJ_ExcavationStatus);
                }
            }
        }
    }

    private void Form47_Load(object sender, EventArgs e)
    {
        if (this.enum12_0 == Enum12.const_0)
        {
            base.SelectSqlData(this.dataSetExcavation_0, this.dataSetExcavation_0.tR_Classifier, true, " where ParentKey like ';Excavation;StatusOrder;%' and isGRoup = 0 and deleted = 0 order by name");
        }
        if (this.enum12_0 == Enum12.const_1)
        {
            base.SelectSqlData(this.dataSetExcavation_0, this.dataSetExcavation_0.tR_Classifier, true, " where ParentKey like ';Excavation;StatusWork;%' and isGRoup = 0 and deleted = 0 order by name");
        }
        this.comboBox_0.SelectedIndex = -1;
        if (this.int_1 == -1)
        {
            DataRow row = this.dataSetExcavation_0.tJ_ExcavationStatus.NewRow();
            row["idExcavation"] = this.int_0;
            row["idType"] = (int) this.enum12_0;
            row["idStatus"] = -1;
            if (this.enum12_0 == Enum12.const_0)
            {
                row["dateChange"] = DateTime.Now.Date;
            }
            else
            {
                row["dateChange"] = DateTime.Now;
            }
            this.dataSetExcavation_0.tJ_ExcavationStatus.Rows.Add(row);
        }
        else
        {
            base.SelectSqlData(this.dataSetExcavation_0, this.dataSetExcavation_0.tJ_ExcavationStatus, true, "where id = " + this.int_1.ToString());
        }
        if (this.dataSetExcavation_0.tJ_ExcavationStatus.Rows.Count > 0)
        {
            this.dataSetExcavation_0.tJ_ExcavationStatus.Rows[0].BeginEdit();
        }
    }

    internal int method_0()
    {
        return this.int_1;
    }

    internal void method_1(int int_2)
    {
        this.int_1 = int_2;
    }

    private void method_2()
    {
        if (this.enum12_0 == Enum12.const_1)
        {
            this.Text = (this.int_1 == -1) ? "Новое состояние" : "Редактирование состояния";
            this.dateTimePicker_0.Value = DateTime.Now;
            this.dateTimePicker_0.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker_0.CustomFormat = "dd.MM.yyyy HH.mm";
        }
        else if (this.enum12_0 == Enum12.const_0)
        {
            this.Text = (this.int_1 == -1) ? "Новый статус" : "Редактирование статуса";
        }
        this.nullableDateTimePicker_0.set_Value(this.dateTimePicker_0.Value = DateTime.Now.Date);
    }

    private void method_3()
    {
        this.label_0 = new Label();
        this.comboBox_0 = new ComboBox();
        this.dataSetExcavation_0 = new DataSetExcavation();
        this.label_1 = new Label();
        this.nullableDateTimePicker_0 = new NullableDateTimePicker();
        this.label_2 = new Label();
        this.dateTimePicker_0 = new DateTimePicker();
        this.button_0 = new Button();
        this.button_1 = new Button();
        this.label_3 = new Label();
        this.richTextBox_0 = new RichTextBox();
        this.tableLayoutPanel_0 = new TableLayoutPanel();
        this.dataSetExcavation_0.BeginInit();
        this.tableLayoutPanel_0.SuspendLayout();
        base.SuspendLayout();
        this.label_0.AutoSize = true;
        this.label_0.Dock = DockStyle.Fill;
        this.label_0.Location = new Point(3, 0);
        this.label_0.Name = "labelStatus";
        this.label_0.Size = new Size(0x5c, 0x1b);
        this.label_0.TabIndex = 0;
        this.label_0.Text = "Статус";
        this.label_0.TextAlign = ContentAlignment.MiddleLeft;
        this.tableLayoutPanel_0.SetColumnSpan(this.comboBox_0, 2);
        this.comboBox_0.DataBindings.Add(new Binding("SelectedValue", this.dataSetExcavation_0, "tJ_ExcavationStatus.idStatus", true));
        this.comboBox_0.DataSource = this.dataSetExcavation_0;
        this.comboBox_0.DisplayMember = "tR_Classifier.Name";
        this.comboBox_0.Dock = DockStyle.Fill;
        this.comboBox_0.FormattingEnabled = true;
        this.comboBox_0.Location = new Point(0x65, 3);
        this.comboBox_0.Name = "cmStatus";
        this.comboBox_0.Size = new Size(0xd5, 0x15);
        this.comboBox_0.TabIndex = 1;
        this.comboBox_0.ValueMember = "tR_Classifier.Id";
        this.comboBox_0.SelectedValueChanged += new EventHandler(this.comboBox_0_SelectedValueChanged);
        this.dataSetExcavation_0.DataSetName = "DataSetExcavation";
        this.dataSetExcavation_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        this.label_1.AutoSize = true;
        this.label_1.Dock = DockStyle.Fill;
        this.label_1.Location = new Point(3, 0x1b);
        this.label_1.Name = "labelElongation";
        this.label_1.Size = new Size(0x5c, 0x1a);
        this.label_1.TabIndex = 2;
        this.label_1.Text = "Продлен до";
        this.label_1.TextAlign = ContentAlignment.MiddleLeft;
        this.tableLayoutPanel_0.SetColumnSpan(this.nullableDateTimePicker_0, 2);
        this.nullableDateTimePicker_0.DataBindings.Add(new Binding("Value", this.dataSetExcavation_0, "tJ_ExcavationStatus.dateElongation", true));
        this.nullableDateTimePicker_0.Dock = DockStyle.Fill;
        this.nullableDateTimePicker_0.Location = new Point(0x65, 30);
        this.nullableDateTimePicker_0.Name = "dateTimePickerElonagation";
        this.nullableDateTimePicker_0.Size = new Size(0xd5, 20);
        this.nullableDateTimePicker_0.TabIndex = 3;
        this.nullableDateTimePicker_0.set_Value(new DateTime(0x7e0, 6, 0x15, 15, 7, 0x26, 0x35d));
        this.nullableDateTimePicker_0.VisibleChanged += new EventHandler(this.nullableDateTimePicker_0_VisibleChanged);
        this.label_2.AutoSize = true;
        this.label_2.Dock = DockStyle.Fill;
        this.label_2.Location = new Point(3, 0x35);
        this.label_2.Name = "labelChange";
        this.label_2.Size = new Size(0x5c, 0x1a);
        this.label_2.TabIndex = 4;
        this.label_2.Text = "Дата изменения";
        this.label_2.TextAlign = ContentAlignment.MiddleLeft;
        this.tableLayoutPanel_0.SetColumnSpan(this.dateTimePicker_0, 2);
        this.dateTimePicker_0.CustomFormat = "dd.MM.yyyy HH:mm";
        this.dateTimePicker_0.DataBindings.Add(new Binding("Value", this.dataSetExcavation_0, "tJ_ExcavationStatus.dateChange", true));
        this.dateTimePicker_0.Dock = DockStyle.Fill;
        this.dateTimePicker_0.Location = new Point(0x65, 0x38);
        this.dateTimePicker_0.Name = "dateTimePickerChange";
        this.dateTimePicker_0.Size = new Size(0xd5, 20);
        this.dateTimePicker_0.TabIndex = 5;
        this.button_0.Anchor = AnchorStyles.Bottom;
        this.button_0.DialogResult = DialogResult.OK;
        this.button_0.Location = new Point(11, 140);
        this.button_0.Margin = new Padding(3, 3, 3, 7);
        this.button_0.Name = "buttonОК";
        this.button_0.Size = new Size(0x4b, 0x19);
        this.button_0.TabIndex = 6;
        this.button_0.Text = "ОК";
        this.button_0.UseVisualStyleBackColor = true;
        this.button_1.Anchor = AnchorStyles.Bottom;
        this.button_1.DialogResult = DialogResult.Cancel;
        this.button_1.Location = new Point(0xef, 140);
        this.button_1.Margin = new Padding(3, 3, 3, 7);
        this.button_1.Name = "buttonCancel";
        this.button_1.Size = new Size(0x4b, 0x19);
        this.button_1.TabIndex = 7;
        this.button_1.Text = "Отмена";
        this.button_1.UseVisualStyleBackColor = true;
        this.label_3.AutoSize = true;
        this.label_3.Dock = DockStyle.Fill;
        this.label_3.Location = new Point(3, 0x4f);
        this.label_3.Name = "lblComment";
        this.label_3.Size = new Size(0x5c, 0x1a);
        this.label_3.TabIndex = 8;
        this.label_3.Text = "Описание";
        this.label_3.TextAlign = ContentAlignment.MiddleLeft;
        this.tableLayoutPanel_0.SetColumnSpan(this.richTextBox_0, 2);
        this.richTextBox_0.DataBindings.Add(new Binding("Text", this.dataSetExcavation_0, "tJ_ExcavationStatus.Comment", true));
        this.richTextBox_0.Dock = DockStyle.Fill;
        this.richTextBox_0.Location = new Point(0x65, 0x52);
        this.richTextBox_0.Name = "rtxtComment";
        this.tableLayoutPanel_0.SetRowSpan(this.richTextBox_0, 2);
        this.richTextBox_0.Size = new Size(0xd5, 0x26);
        this.richTextBox_0.TabIndex = 9;
        this.richTextBox_0.Text = "";
        this.tableLayoutPanel_0.ColumnCount = 3;
        this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle());
        this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
        this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle());
        this.tableLayoutPanel_0.Controls.Add(this.label_0, 0, 0);
        this.tableLayoutPanel_0.Controls.Add(this.comboBox_0, 1, 0);
        this.tableLayoutPanel_0.Controls.Add(this.nullableDateTimePicker_0, 1, 1);
        this.tableLayoutPanel_0.Controls.Add(this.button_1, 2, 6);
        this.tableLayoutPanel_0.Controls.Add(this.label_1, 0, 1);
        this.tableLayoutPanel_0.Controls.Add(this.label_2, 0, 2);
        this.tableLayoutPanel_0.Controls.Add(this.dateTimePicker_0, 1, 2);
        this.tableLayoutPanel_0.Controls.Add(this.label_3, 0, 3);
        this.tableLayoutPanel_0.Controls.Add(this.richTextBox_0, 1, 3);
        this.tableLayoutPanel_0.Controls.Add(this.button_0, 0, 6);
        this.tableLayoutPanel_0.Dock = DockStyle.Fill;
        this.tableLayoutPanel_0.Location = new Point(0, 0);
        this.tableLayoutPanel_0.Name = "tableLayoutPanel1";
        this.tableLayoutPanel_0.RowCount = 7;
        this.tableLayoutPanel_0.RowStyles.Add(new RowStyle());
        this.tableLayoutPanel_0.RowStyles.Add(new RowStyle());
        this.tableLayoutPanel_0.RowStyles.Add(new RowStyle());
        this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 26f));
        this.tableLayoutPanel_0.RowStyles.Add(new RowStyle());
        this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 10f));
        this.tableLayoutPanel_0.RowStyles.Add(new RowStyle());
        this.tableLayoutPanel_0.Size = new Size(0x13d, 0xac);
        this.tableLayoutPanel_0.TabIndex = 10;
        base.AcceptButton = this.button_0;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.CancelButton = this.button_1;
        base.ClientSize = new Size(0x13d, 0xac);
        base.Controls.Add(this.tableLayoutPanel_0);
        base.Name = "FormExcavationStatusAddEdit";
        base.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Новый статус";
        base.FormClosing += new FormClosingEventHandler(this.Form47_FormClosing);
        base.Load += new EventHandler(this.Form47_Load);
        this.dataSetExcavation_0.EndInit();
        this.tableLayoutPanel_0.ResumeLayout(false);
        this.tableLayoutPanel_0.PerformLayout();
        base.ResumeLayout(false);
    }

    private void nullableDateTimePicker_0_VisibleChanged(object sender, EventArgs e)
    {
        if (this.nullableDateTimePicker_0.Visible)
        {
            base.Height += this.nullableDateTimePicker_0.Height;
        }
        else
        {
            base.Height -= this.nullableDateTimePicker_0.Height;
        }
    }
}

