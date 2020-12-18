using Documents.Forms.TechnologicalConnection;
using FormLbr;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

internal class Form6 : FormBase
{
    private Button button_0;
    private Button button_1;
    private ComboBox comboBox_0;
    private ComboBox comboBox_1;
    private DataSetTechConnection dataSetTechConnection_0;
    private DateTimePicker dateTimePicker_0;
    private IContainer icontainer_0;
    private int int_0;
    private int int_1;
    private Label label_0;
    private Label label_1;
    private Label label_2;
    private Label label_3;
    private TextBox textBox_0;

    internal Form6()
    {
        this.int_0 = -1;
        this.int_1 = -1;
        this.method_0();
    }

    internal Form6(int int_2, int int_3, bool bool_0)
    {
        this.int_0 = -1;
        this.int_1 = -1;
        this.method_0();
        this.int_0 = int_2;
        this.int_1 = int_3;
        this.Text = (int_2 == -1) ? "Новый статус" : "Редактирование";
        this.dateTimePicker_0.Value = DateTime.Now.Date;
        if (!bool_0)
        {
            base.Height -= this.label_2.Height + this.comboBox_1.Height;
        }
        this.label_2.Visible = this.comboBox_1.Visible = bool_0;
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.icontainer_0 != null))
        {
            this.icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    private void Form6_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (base.DialogResult == DialogResult.OK)
        {
            if (this.comboBox_0.SelectedIndex < 0)
            {
                MessageBox.Show("Не выбран статус документа");
                e.Cancel = true;
            }
            else
            {
                this.dataSetTechConnection_0.tTC_DocStatus.Rows[0].EndEdit();
                if (this.int_0 == -1)
                {
                    this.int_0 = base.InsertSqlDataOneRow(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_DocStatus);
                }
                else
                {
                    base.UpdateSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_DocStatus);
                }
            }
        }
    }

    private void Form6_Load(object sender, EventArgs e)
    {
        base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tR_Classifier, true, " where ParentKey = ';TechConnect;RequestStatus;' and isGRoup = 0 and deleted = 0 order by name");
        DataSetTechConnection.tR_ClassifierDataTable table = new DataSetTechConnection.tR_ClassifierDataTable();
        base.SelectSqlData(table, true, " where ParentKey = ';TechConnect;DocSendMode;' and isGRoup = 0 and deleted = 0 order by name", false);
        this.comboBox_1.DataSource = table;
        this.comboBox_1.DisplayMember = "Name";
        this.comboBox_1.ValueMember = "id";
        if (this.int_0 == -1)
        {
            DataRow row = this.dataSetTechConnection_0.tTC_DocStatus.NewRow();
            row["idDoc"] = this.int_1;
            row["DateChange"] = DateTime.Now.Date;
            row["idStatus"] = -1;
            this.dataSetTechConnection_0.tTC_DocStatus.Rows.Add(row);
        }
        else
        {
            base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_DocStatus, true, " where id = " + this.int_0.ToString());
        }
    }

    private void method_0()
    {
        this.label_0 = new Label();
        this.dateTimePicker_0 = new DateTimePicker();
        this.dataSetTechConnection_0 = new DataSetTechConnection();
        this.label_1 = new Label();
        this.comboBox_0 = new ComboBox();
        this.button_0 = new Button();
        this.button_1 = new Button();
        this.label_2 = new Label();
        this.comboBox_1 = new ComboBox();
        this.label_3 = new Label();
        this.textBox_0 = new TextBox();
        this.dataSetTechConnection_0.BeginInit();
        base.SuspendLayout();
        this.label_0.AutoSize = true;
        this.label_0.Location = new Point(12, 9);
        this.label_0.Name = "label1";
        this.label_0.Size = new Size(0x21, 13);
        this.label_0.TabIndex = 0;
        this.label_0.Text = "Дата";
        this.dateTimePicker_0.DataBindings.Add(new Binding("Value", this.dataSetTechConnection_0, "tTC_DocStatus.DateChange", true));
        this.dateTimePicker_0.Location = new Point(12, 0x19);
        this.dateTimePicker_0.Name = "dateTimePicker";
        this.dateTimePicker_0.Size = new Size(0xf9, 20);
        this.dateTimePicker_0.TabIndex = 1;
        this.dataSetTechConnection_0.DataSetName = "DataSetTechConnection";
        this.dataSetTechConnection_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        this.label_1.AutoSize = true;
        this.label_1.Location = new Point(12, 0x30);
        this.label_1.Name = "label2";
        this.label_1.Size = new Size(0x29, 13);
        this.label_1.TabIndex = 2;
        this.label_1.Text = "Статус";
        this.comboBox_0.DataBindings.Add(new Binding("SelectedValue", this.dataSetTechConnection_0, "tTC_DocStatus.idStatus", true));
        this.comboBox_0.DataSource = this.dataSetTechConnection_0;
        this.comboBox_0.DisplayMember = "tR_Classifier.Name";
        this.comboBox_0.FormattingEnabled = true;
        this.comboBox_0.Location = new Point(12, 0x40);
        this.comboBox_0.Name = "cmbStatus";
        this.comboBox_0.Size = new Size(0xf9, 0x15);
        this.comboBox_0.TabIndex = 3;
        this.comboBox_0.ValueMember = "tR_Classifier.Id";
        this.button_0.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
        this.button_0.DialogResult = DialogResult.OK;
        this.button_0.Location = new Point(12, 0xe8);
        this.button_0.Name = "buttonOK";
        this.button_0.Size = new Size(0x4b, 0x17);
        this.button_0.TabIndex = 4;
        this.button_0.Text = "ОК";
        this.button_0.UseVisualStyleBackColor = true;
        this.button_1.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
        this.button_1.DialogResult = DialogResult.Cancel;
        this.button_1.Location = new Point(0xba, 0xe8);
        this.button_1.Name = "buttonCancel";
        this.button_1.Size = new Size(0x4b, 0x17);
        this.button_1.TabIndex = 5;
        this.button_1.Text = "Отмена";
        this.button_1.UseVisualStyleBackColor = true;
        this.label_2.AutoSize = true;
        this.label_2.Location = new Point(9, 0x58);
        this.label_2.Name = "labelSendMode";
        this.label_2.Size = new Size(0x5e, 13);
        this.label_2.TabIndex = 6;
        this.label_2.Text = "Способ отправки";
        this.comboBox_1.DataBindings.Add(new Binding("SelectedValue", this.dataSetTechConnection_0, "tTC_DocStatus.SendMode", true));
        this.comboBox_1.FormattingEnabled = true;
        this.comboBox_1.Location = new Point(12, 0x68);
        this.comboBox_1.Name = "cmbSendMode";
        this.comboBox_1.Size = new Size(0xf9, 0x15);
        this.comboBox_1.TabIndex = 7;
        this.label_3.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
        this.label_3.AutoSize = true;
        this.label_3.Location = new Point(12, 0x80);
        this.label_3.Name = "labelComment";
        this.label_3.Size = new Size(0x4d, 13);
        this.label_3.TabIndex = 8;
        this.label_3.Text = "Комментарий";
        this.textBox_0.AcceptsReturn = true;
        this.textBox_0.AcceptsTab = true;
        this.textBox_0.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
        this.textBox_0.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tTC_DocStatus.Comment", true));
        this.textBox_0.Location = new Point(12, 0x90);
        this.textBox_0.Multiline = true;
        this.textBox_0.Name = "txtComment";
        this.textBox_0.Size = new Size(0xf9, 0x52);
        this.textBox_0.TabIndex = 9;
        base.AcceptButton = this.button_0;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.CancelButton = this.button_1;
        base.ClientSize = new Size(0x10f, 0x10b);
        base.Controls.Add(this.textBox_0);
        base.Controls.Add(this.label_3);
        base.Controls.Add(this.comboBox_1);
        base.Controls.Add(this.label_2);
        base.Controls.Add(this.button_1);
        base.Controls.Add(this.button_0);
        base.Controls.Add(this.comboBox_0);
        base.Controls.Add(this.label_1);
        base.Controls.Add(this.dateTimePicker_0);
        base.Controls.Add(this.label_0);
        base.FormBorderStyle = FormBorderStyle.FixedDialog;
        base.MaximizeBox = false;
        base.MinimizeBox = false;
        base.Name = "FormTechConnectionAddEditRequestStatus";
        this.Text = "FormTechConnectionAddEditRequestStatus";
        base.FormClosing += new FormClosingEventHandler(this.Form6_FormClosing);
        base.Load += new EventHandler(this.Form6_Load);
        this.dataSetTechConnection_0.EndInit();
        base.ResumeLayout(false);
        base.PerformLayout();
    }
}

