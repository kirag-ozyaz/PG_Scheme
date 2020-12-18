using ControlsLbr;
using Documents.DataSets;
using FormLbr;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

internal class Form40 : FormBase
{
    private BindingSource bindingSource_0;
    private BindingSource bindingSource_1;
    private Button button_0;
    private Button button_1;
    private ComboBox comboBox_0;
    private ComboBox comboBox_1;
    private DataColumn dataColumn_0;
    private DataColumn dataColumn_1;
    private DataColumn dataColumn_2;
    private DataSet dataSet_0;
    private DataSetGES dataSetGES_0;
    private DataTable dataTable_0;
    private IContainer icontainer_0;
    private int int_0;
    private Label label_0;
    private Label label_1;
    private Label label_2;
    private Label label_3;
    private RichTextBoxWithContextMenu richTextBoxWithContextMenu_0;
    private TextBox textBox_0;

    internal Form40()
    {
        this.int_0 = -1;
        this.method_0();
    }

    internal Form40(int int_1)
    {
        this.int_0 = -1;
        this.method_0();
        this.int_0 = int_1;
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.icontainer_0 != null))
        {
            this.icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    private void Form40_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (base.DialogResult == DialogResult.OK)
        {
            this.dataSetGES_0.tJ_Request.Rows[0].EndEdit();
            base.UpdateSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_Request);
        }
    }

    private void Form40_Load(object sender, EventArgs e)
    {
        base.SelectSqlData(this.dataSet_0, this.dataSet_0.Tables["tR_Classifier"], true, "where deleted = 0 and isgroup = 0 and ParentKey in (';Other;StatusTask;', ';Other;TypeTask;')");
        base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_Request, true, "where id = " + this.int_0.ToString());
    }

    private void method_0()
    {
        this.icontainer_0 = new Container();
        this.label_0 = new Label();
        this.textBox_0 = new TextBox();
        this.dataSetGES_0 = new DataSetGES();
        this.label_1 = new Label();
        this.label_2 = new Label();
        this.comboBox_0 = new ComboBox();
        this.bindingSource_0 = new BindingSource(this.icontainer_0);
        this.dataSet_0 = new DataSet();
        this.dataTable_0 = new DataTable();
        this.dataColumn_0 = new DataColumn();
        this.dataColumn_1 = new DataColumn();
        this.dataColumn_2 = new DataColumn();
        this.comboBox_1 = new ComboBox();
        this.bindingSource_1 = new BindingSource(this.icontainer_0);
        this.label_3 = new Label();
        this.richTextBoxWithContextMenu_0 = new RichTextBoxWithContextMenu();
        this.button_0 = new Button();
        this.button_1 = new Button();
        this.dataSetGES_0.BeginInit();
        ((ISupportInitialize) this.bindingSource_0).BeginInit();
        this.dataSet_0.BeginInit();
        this.dataTable_0.BeginInit();
        ((ISupportInitialize) this.bindingSource_1).BeginInit();
        base.SuspendLayout();
        this.label_0.AutoSize = true;
        this.label_0.Location = new Point(12, 9);
        this.label_0.Name = "label1";
        this.label_0.Size = new Size(0x38, 13);
        this.label_0.TabIndex = 0;
        this.label_0.Text = "№ задачи";
        this.textBox_0.DataBindings.Add(new Binding("Text", this.dataSetGES_0, "tJ_Request.id", true));
        this.textBox_0.Location = new Point(0x4a, 6);
        this.textBox_0.Name = "textBoxID";
        this.textBox_0.ReadOnly = true;
        this.textBox_0.Size = new Size(0x9c, 20);
        this.textBox_0.TabIndex = 1;
        this.dataSetGES_0.DataSetName = "DataSetGES";
        this.dataSetGES_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        this.label_1.AutoSize = true;
        this.label_1.Location = new Point(12, 0x2e);
        this.label_1.Name = "label2";
        this.label_1.Size = new Size(0x29, 13);
        this.label_1.TabIndex = 2;
        this.label_1.Text = "Статус";
        this.label_2.AutoSize = true;
        this.label_2.Location = new Point(12, 0x53);
        this.label_2.Name = "label3";
        this.label_2.Size = new Size(0x40, 13);
        this.label_2.TabIndex = 3;
        this.label_2.Text = "Тип задачи";
        this.comboBox_0.DataBindings.Add(new Binding("SelectedValue", this.dataSetGES_0, "tJ_Request.StatusTask", true));
        this.comboBox_0.DataSource = this.bindingSource_0;
        this.comboBox_0.DisplayMember = "Name";
        this.comboBox_0.FormattingEnabled = true;
        this.comboBox_0.Location = new Point(0x4a, 0x2b);
        this.comboBox_0.Name = "comboBoxStatus";
        this.comboBox_0.Size = new Size(0x9c, 0x15);
        this.comboBox_0.TabIndex = 4;
        this.comboBox_0.ValueMember = "Id";
        this.bindingSource_0.DataMember = "tR_Classifier";
        this.bindingSource_0.DataSource = this.dataSet_0;
        this.bindingSource_0.Filter = "ParentKey = ';Other;StatusTask;'";
        this.dataSet_0.DataSetName = "NewDataSet";
        DataTable[] tables = new DataTable[] { this.dataTable_0 };
        this.dataSet_0.Tables.AddRange(tables);
        DataColumn[] columns = new DataColumn[] { this.dataColumn_0, this.dataColumn_1, this.dataColumn_2 };
        this.dataTable_0.Columns.AddRange(columns);
        this.dataTable_0.TableName = "tR_Classifier";
        this.dataColumn_0.ColumnName = "Id";
        this.dataColumn_0.DataType = typeof(int);
        this.dataColumn_1.ColumnName = "Name";
        this.dataColumn_2.ColumnName = "ParentKey";
        this.comboBox_1.DataBindings.Add(new Binding("SelectedValue", this.dataSetGES_0, "tJ_Request.TypeTask", true));
        this.comboBox_1.DataSource = this.bindingSource_1;
        this.comboBox_1.DisplayMember = "Name";
        this.comboBox_1.FormattingEnabled = true;
        this.comboBox_1.Location = new Point(0x4a, 80);
        this.comboBox_1.Name = "comboBoxType";
        this.comboBox_1.Size = new Size(0x9c, 0x15);
        this.comboBox_1.TabIndex = 5;
        this.comboBox_1.ValueMember = "Id";
        this.bindingSource_1.DataMember = "tR_Classifier";
        this.bindingSource_1.DataSource = this.dataSet_0;
        this.bindingSource_1.Filter = "ParentKey = ';Other;TypeTask;'";
        this.label_3.AutoSize = true;
        this.label_3.Location = new Point(0xf5, 6);
        this.label_3.Name = "label4";
        this.label_3.Size = new Size(0x30, 13);
        this.label_3.TabIndex = 6;
        this.label_3.Text = "Резюме";
        this.richTextBoxWithContextMenu_0.AcceptsTab = true;
        this.richTextBoxWithContextMenu_0.DataBindings.Add(new Binding("Text", this.dataSetGES_0, "tJ_Request.Comment", true));
        this.richTextBoxWithContextMenu_0.Location = new Point(0xf8, 0x16);
        this.richTextBoxWithContextMenu_0.Name = "richTextBoxComment";
        this.richTextBoxWithContextMenu_0.Size = new Size(0xda, 0x4f);
        this.richTextBoxWithContextMenu_0.TabIndex = 7;
        this.richTextBoxWithContextMenu_0.Text = "";
        this.button_0.DialogResult = DialogResult.OK;
        this.button_0.Location = new Point(15, 0x77);
        this.button_0.Name = "buttonOK";
        this.button_0.Size = new Size(0x4b, 0x17);
        this.button_0.TabIndex = 8;
        this.button_0.Text = "ОК";
        this.button_0.UseVisualStyleBackColor = true;
        this.button_1.DialogResult = DialogResult.Cancel;
        this.button_1.Location = new Point(0x187, 0x77);
        this.button_1.Name = "buttonCancel";
        this.button_1.Size = new Size(0x4b, 0x17);
        this.button_1.TabIndex = 9;
        this.button_1.Text = "Отмена";
        this.button_1.UseVisualStyleBackColor = true;
        base.AcceptButton = this.button_0;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.CancelButton = this.button_1;
        base.ClientSize = new Size(0x1de, 0x9a);
        base.Controls.Add(this.button_1);
        base.Controls.Add(this.button_0);
        base.Controls.Add(this.richTextBoxWithContextMenu_0);
        base.Controls.Add(this.label_3);
        base.Controls.Add(this.comboBox_1);
        base.Controls.Add(this.comboBox_0);
        base.Controls.Add(this.label_2);
        base.Controls.Add(this.label_1);
        base.Controls.Add(this.textBox_0);
        base.Controls.Add(this.label_0);
        base.FormBorderStyle = FormBorderStyle.FixedDialog;
        base.MaximizeBox = false;
        base.MinimizeBox = false;
        base.Name = "FormEditRequeststatus";
        this.Text = "Изменение статуса";
        base.FormClosing += new FormClosingEventHandler(this.Form40_FormClosing);
        base.Load += new EventHandler(this.Form40_Load);
        this.dataSetGES_0.EndInit();
        ((ISupportInitialize) this.bindingSource_0).EndInit();
        this.dataSet_0.EndInit();
        this.dataTable_0.EndInit();
        ((ISupportInitialize) this.bindingSource_1).EndInit();
        base.ResumeLayout(false);
        base.PerformLayout();
    }
}

