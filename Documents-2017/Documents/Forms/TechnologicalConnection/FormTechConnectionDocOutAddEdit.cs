namespace Documents.Forms.TechnologicalConnection
{
    using ControlsLbr;
    using FormLbr;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;

    public class FormTechConnectionDocOutAddEdit : FormBase
    {
        private Button button_0;
        private Button button_1;
        private ComboBox comboBox_0;
        private ComboBox comboBox_1;
        private ComboBox comboBox_2;
        private DataSetTechConnection dataSetTechConnection_0;
        private IContainer icontainer_0;
        private int int_0;
        private int int_1;
        private Label label_0;
        private Label label_1;
        private Label label_2;
        private Label label_3;
        private Label label_4;
        private Label label_5;
        private Label label_6;
        private NullableDateTimePicker nullableDateTimePicker_0;
        private NumericUpDown numericUpDown_0;
        private TextBox textBox_0;
        private TextBox textBox_1;
        private TextBox textBox_2;

        public FormTechConnectionDocOutAddEdit()
        {
            this.int_0 = -1;
            this.int_1 = -1;
            this.method_2();
        }

        public FormTechConnectionDocOutAddEdit(int int_2, int idDoc)
        {
            this.int_0 = -1;
            this.int_1 = -1;
            this.method_2();
            this.int_0 = int_2;
            this.int_1 = idDoc;
            this.Text = (int_2 == -1) ? "Новый документ" : "Редактирование";
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

        private void FormTechConnectionDocOutAddEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (base.DialogResult == DialogResult.OK)
            {
                if (this.comboBox_0.SelectedIndex < 0)
                {
                    MessageBox.Show("Не выбран тип документа");
                    e.Cancel = true;
                }
                else if (this.int_0 == -1)
                {
                    this.dataSetTechConnection_0.tTC_Doc.Rows[0].EndEdit();
                    int num = base.InsertSqlDataOneRow(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Doc);
                    this.dataSetTechConnection_0.tTC_DocOut.Rows[0]["idDocOut"] = num;
                    this.dataSetTechConnection_0.tTC_DocOut.Rows[0].EndEdit();
                    this.int_0 = base.InsertSqlDataOneRow(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_DocOut);
                }
                else
                {
                    this.dataSetTechConnection_0.tTC_Doc.Rows[0].EndEdit();
                    base.UpdateSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Doc);
                    this.dataSetTechConnection_0.tTC_DocOut.Rows[0].EndEdit();
                    base.UpdateSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_DocOut);
                }
            }
        }

        private void FormTechConnectionDocOutAddEdit_Load(object sender, EventArgs e)
        {
            this.method_0();
            if (this.int_0 == -1)
            {
                this.method_1();
                DataRow row = this.dataSetTechConnection_0.tTC_DocOut.NewRow();
                row["idDoc"] = this.int_1;
                row["idDocOut"] = this.dataSetTechConnection_0.tTC_Doc.Rows[0]["id"];
                this.dataSetTechConnection_0.tTC_DocOut.Rows.Add(row);
            }
            else
            {
                base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_DocOut, true, "where id = " + this.int_0.ToString());
                if (this.dataSetTechConnection_0.tTC_DocOut.Rows.Count > 0)
                {
                    base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Doc, true, " where id = " + this.dataSetTechConnection_0.tTC_DocOut.Rows[0]["idDocOut"].ToString());
                }
            }
        }

        private void method_0()
        {
            DataSetTechConnection.tR_ClassifierDataTable table = new DataSetTechConnection.tR_ClassifierDataTable();
            string[] textArray1 = new string[0x11];
            textArray1[0] = " where id in (";
            textArray1[1] = 0x464.ToString();
            textArray1[2] = ",";
            textArray1[3] = 0x465.ToString();
            textArray1[4] = ",";
            textArray1[5] = 0x47f.ToString();
            textArray1[6] = ",";
            textArray1[7] = 0x480.ToString();
            textArray1[8] = ",";
            textArray1[9] = 0x481.ToString();
            textArray1[10] = ",";
            textArray1[11] = 0x482.ToString();
            textArray1[12] = ",";
            textArray1[13] = 0x4c2.ToString();
            textArray1[14] = ",";
            int num = 0x483;
            textArray1[15] = num.ToString();
            textArray1[0x10] = ") order by name";
            base.SelectSqlData(table, true, string.Concat(textArray1), false);
            if (this.int_1 != -1)
            {
                DataTable table4 = base.SelectSqlData("tTC_Doc", true, "where id = " + this.int_1.ToString());
                if ((table4.Rows.Count > 0) && (Convert.ToInt32(table4.Rows[0]["TypeDoc"]) == 0x4c4))
                {
                    string[] textArray2 = new string[0x13];
                    textArray2[0] = " where id in (";
                    num = 0x464;
                    textArray2[1] = num.ToString();
                    textArray2[2] = ",";
                    num = 0x465;
                    textArray2[3] = num.ToString();
                    textArray2[4] = ",";
                    num = 0x47f;
                    textArray2[5] = num.ToString();
                    textArray2[6] = ",";
                    num = 0x480;
                    textArray2[7] = num.ToString();
                    textArray2[8] = ",";
                    num = 0x481;
                    textArray2[9] = num.ToString();
                    textArray2[10] = ",";
                    num = 0x482;
                    textArray2[11] = num.ToString();
                    textArray2[12] = ",";
                    num = 0x4c2;
                    textArray2[13] = num.ToString();
                    textArray2[14] = ",";
                    num = 0x483;
                    textArray2[15] = num.ToString();
                    textArray2[0x10] = ",";
                    textArray2[0x11] = 0x4d5.ToString();
                    textArray2[0x12] = ") order by name";
                    base.SelectSqlData(table, true, string.Concat(textArray2), false);
                }
            }
            this.comboBox_0.DataSource = table;
            this.comboBox_0.DisplayMember = "Name";
            this.comboBox_0.ValueMember = "id";
            DataSetTechConnection.tR_ClassifierDataTable table2 = new DataSetTechConnection.tR_ClassifierDataTable();
            base.SelectSqlData(table2, true, " where ParentKey = ';TechConnect;DocOutStatus;' and isGRoup = 0 and deleted = 0 order by name", false);
            this.comboBox_1.DataSource = table2;
            this.comboBox_1.DisplayMember = "Name";
            this.comboBox_1.ValueMember = "id";
            DataSetTechConnection.tR_ClassifierDataTable table3 = new DataSetTechConnection.tR_ClassifierDataTable();
            base.SelectSqlData(table3, true, " where ParentKey = ';TechConnect;DocSendMode;' and isGRoup = 0 and deleted = 0 order by name", false);
            this.comboBox_2.DataSource = table3;
            this.comboBox_2.DisplayMember = "Name";
            this.comboBox_2.ValueMember = "id";
        }

        private void method_1()
        {
            DataRow row = this.dataSetTechConnection_0.tTC_Doc.NewRow();
            row["TypeDoc"] = -1;
            this.dataSetTechConnection_0.tTC_Doc.Rows.Add(row);
        }

        private void method_2()
        {
            this.label_0 = new Label();
            this.comboBox_0 = new ComboBox();
            this.dataSetTechConnection_0 = new DataSetTechConnection();
            this.label_1 = new Label();
            this.textBox_0 = new TextBox();
            this.nullableDateTimePicker_0 = new NullableDateTimePicker();
            this.button_0 = new Button();
            this.button_1 = new Button();
            this.label_2 = new Label();
            this.comboBox_1 = new ComboBox();
            this.label_3 = new Label();
            this.comboBox_2 = new ComboBox();
            this.label_4 = new Label();
            this.numericUpDown_0 = new NumericUpDown();
            this.label_5 = new Label();
            this.textBox_1 = new TextBox();
            this.label_6 = new Label();
            this.textBox_2 = new TextBox();
            this.dataSetTechConnection_0.BeginInit();
            this.numericUpDown_0.BeginInit();
            base.SuspendLayout();
            this.label_0.AutoSize = true;
            this.label_0.Location = new Point(12, 9);
            this.label_0.Name = "label1";
            this.label_0.Size = new Size(0x8d, 13);
            this.label_0.TabIndex = 0;
            this.label_0.Text = "Тип выданного документа";
            this.comboBox_0.DataBindings.Add(new Binding("SelectedValue", this.dataSetTechConnection_0, "tTC_Doc.TypeDoc", true));
            this.comboBox_0.FormattingEnabled = true;
            this.comboBox_0.Location = new Point(12, 0x19);
            this.comboBox_0.Name = "cmbTypeDocOut";
            this.comboBox_0.Size = new Size(0x125, 0x15);
            this.comboBox_0.TabIndex = 1;
            this.dataSetTechConnection_0.DataSetName = "DataSetTechConnection";
            this.dataSetTechConnection_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.label_1.AutoSize = true;
            this.label_1.Location = new Point(12, 0x31);
            this.label_1.Name = "label2";
            this.label_1.Size = new Size(0xbf, 13);
            this.label_1.TabIndex = 2;
            this.label_1.Text = "Номер и дата выданного документа";
            this.textBox_0.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tTC_Doc.numDoc", true));
            this.textBox_0.Location = new Point(12, 0x41);
            this.textBox_0.Name = "txtNumDocOut";
            this.textBox_0.Size = new Size(0x80, 20);
            this.textBox_0.TabIndex = 3;
            this.nullableDateTimePicker_0.DataBindings.Add(new Binding("Value", this.dataSetTechConnection_0, "tTC_Doc.dateDoc", true));
            this.nullableDateTimePicker_0.Location = new Point(0x92, 0x41);
            this.nullableDateTimePicker_0.Name = "dateTimePickerDocOut";
            this.nullableDateTimePicker_0.Size = new Size(0x9f, 20);
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
            this.label_2.AutoSize = true;
            this.label_2.Location = new Point(0xda, 9);
            this.label_2.Name = "label3";
            this.label_2.Size = new Size(0x62, 13);
            this.label_2.TabIndex = 13;
            this.label_2.Text = "Статус документа";
            this.label_2.Visible = false;
            this.comboBox_1.DataBindings.Add(new Binding("SelectedValue", this.dataSetTechConnection_0, "tTC_DocOut.idStatus", true));
            this.comboBox_1.FormattingEnabled = true;
            this.comboBox_1.Location = new Point(230, 1);
            this.comboBox_1.Name = "cmbDocOutStatus";
            this.comboBox_1.Size = new Size(0x27, 0x15);
            this.comboBox_1.TabIndex = 14;
            this.comboBox_1.Visible = false;
            this.label_3.AutoSize = true;
            this.label_3.Location = new Point(0x6f, 0x12d);
            this.label_3.Name = "label4";
            this.label_3.Size = new Size(0x5e, 13);
            this.label_3.TabIndex = 15;
            this.label_3.Text = "Способ отправки";
            this.label_3.Visible = false;
            this.comboBox_2.DataBindings.Add(new Binding("SelectedValue", this.dataSetTechConnection_0, "tTC_DocOut.SendMode", true));
            this.comboBox_2.FormattingEnabled = true;
            this.comboBox_2.Location = new Point(0x7b, 0x132);
            this.comboBox_2.Name = "cmbSendMode";
            this.comboBox_2.Size = new Size(0x2a, 0x15);
            this.comboBox_2.TabIndex = 0x10;
            this.comboBox_2.Visible = false;
            this.label_4.AutoSize = true;
            this.label_4.Location = new Point(12, 0xab);
            this.label_4.Name = "label5";
            this.label_4.Size = new Size(0x63, 13);
            this.label_4.TabIndex = 7;
            this.label_4.Text = "Количество копий";
            this.numericUpDown_0.DataBindings.Add(new Binding("Value", this.dataSetTechConnection_0, "tTC_DocOut.number", true));
            this.numericUpDown_0.Location = new Point(12, 0xbb);
            this.numericUpDown_0.Name = "numericUpDown";
            this.numericUpDown_0.Size = new Size(0x125, 20);
            this.numericUpDown_0.TabIndex = 8;
            this.numericUpDown_0.TextAlign = HorizontalAlignment.Right;
            this.label_5.AutoSize = true;
            this.label_5.Location = new Point(12, 210);
            this.label_5.Name = "label6";
            this.label_5.Size = new Size(0x4d, 13);
            this.label_5.TabIndex = 9;
            this.label_5.Text = "Комментарий";
            this.textBox_1.AcceptsReturn = true;
            this.textBox_1.AcceptsTab = true;
            this.textBox_1.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tTC_DocOut.comment", true));
            this.textBox_1.Location = new Point(12, 0xe2);
            this.textBox_1.Multiline = true;
            this.textBox_1.Name = "txtComment";
            this.textBox_1.Size = new Size(0x125, 0x40);
            this.textBox_1.TabIndex = 10;
            this.label_6.AutoSize = true;
            this.label_6.Location = new Point(12, 0x58);
            this.label_6.Name = "label7";
            this.label_6.Size = new Size(70, 13);
            this.label_6.TabIndex = 5;
            this.label_6.Text = "Содержание";
            this.textBox_2.AcceptsReturn = true;
            this.textBox_2.AcceptsTab = true;
            this.textBox_2.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tTC_Doc.Body", true));
            this.textBox_2.Location = new Point(12, 0x68);
            this.textBox_2.Multiline = true;
            this.textBox_2.Name = "txtBody";
            this.textBox_2.Size = new Size(0x125, 0x40);
            this.textBox_2.TabIndex = 6;
            base.AcceptButton = this.button_0;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.CancelButton = this.button_1;
            base.ClientSize = new Size(0x135, 330);
            base.Controls.Add(this.textBox_2);
            base.Controls.Add(this.label_6);
            base.Controls.Add(this.textBox_1);
            base.Controls.Add(this.label_5);
            base.Controls.Add(this.numericUpDown_0);
            base.Controls.Add(this.label_4);
            base.Controls.Add(this.comboBox_2);
            base.Controls.Add(this.label_3);
            base.Controls.Add(this.comboBox_1);
            base.Controls.Add(this.label_2);
            base.Controls.Add(this.button_1);
            base.Controls.Add(this.button_0);
            base.Controls.Add(this.nullableDateTimePicker_0);
            base.Controls.Add(this.textBox_0);
            base.Controls.Add(this.label_1);
            base.Controls.Add(this.comboBox_0);
            base.Controls.Add(this.label_0);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "FormTechConnectionDocOutAddEdit";
            this.Text = "FormTechConnectionDocOutAddEdit";
            base.FormClosing += new FormClosingEventHandler(this.FormTechConnectionDocOutAddEdit_FormClosing);
            base.Load += new EventHandler(this.FormTechConnectionDocOutAddEdit_Load);
            this.dataSetTechConnection_0.EndInit();
            this.numericUpDown_0.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        public int IdDocOut
        {
            get
            {
                return this.int_0;
            }
        }
    }
}

