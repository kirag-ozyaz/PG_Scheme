namespace Documents.Forms.TechnologicalConnection
{
    using ControlsLbr;
    using Documents.Properties;
    using FormLbr;
    using FormLbr.Classes;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    public class FormTechConnectionRequestAddEdit : FormBase
    {
        private Button button_0;
        private Button button_1;
        private ComboBox comboBox_0;
        private ComboBox comboBox_1;
        private DataSetTechConnection dataSetTechConnection_0;
        private DateTimePicker dateTimePicker_0;
        private GroupBox groupBox_0;
        private IContainer icontainer_0;
        private int int_0;
        private int int_1;
        private int int_2;
        private int int_3;
        private int int_4;
        private Label label_0;
        private Label label_1;
        private Label label_10;
        private Label label_2;
        private Label label_3;
        private Label label_4;
        private Label label_5;
        private Label label_6;
        private Label label_7;
        private Label label_8;
        private Label label_9;
        private int? nullable_0;
        private int? nullable_1;
        private int? nullable_2;
        private NullableDateTimePicker nullableDateTimePicker_0;
        private NumericUpDown numericUpDown_0;
        private NumericUpDown numericUpDown_1;
        private NumericUpDown numericUpDown_2;
        private TextBox textBox_0;
        private TextBox textBox_1;
        private TextBox textBox_2;
        private TextBox textBox_3;
        private TextBox textBox_4;
        private ToolStrip toolStrip_0;
        private ToolStripButton toolStripButton_0;

        public FormTechConnectionRequestAddEdit()
        {
            this.int_0 = -1;
            this.int_1 = -1;
            this.int_2 = -1;
            this.int_3 = -1;
            this.int_4 = 0x459;
            this.method_9();
            this.method_0();
        }

        public FormTechConnectionRequestAddEdit(int int_5, int typeDoc = 0x459, int? idParent = new int?())
        {
            this.int_0 = -1;
            this.int_1 = -1;
            this.int_2 = -1;
            this.int_3 = -1;
            this.int_4 = 0x459;
            this.method_9();
            this.int_0 = this.int_1 = int_5;
            this.int_4 = typeDoc;
            this.nullable_0 = idParent;
            this.method_0();
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void comboBox_0_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((this.comboBox_0.SelectedValue != null) || (this.comboBox_0.SelectedValue != DBNull.Value))
            {
                this.int_3 = Convert.ToInt32(this.comboBox_0.SelectedValue);
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

        private void FormTechConnectionRequestAddEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (base.DialogResult == DialogResult.OK)
            {
                this.dataSetTechConnection_0.tTC_Doc.Rows[0].EndEdit();
                this.dataSetTechConnection_0.tTC_Request.Rows[0].EndEdit();
                this.dataSetTechConnection_0.tTC_Request.Rows[0]["idAbn"] = this.int_2;
                this.dataSetTechConnection_0.tTC_Request.Rows[0]["idAbnObj"] = this.int_3;
                if (this.int_0 == -1)
                {
                    this.int_0 = base.InsertSqlDataOneRow(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Doc);
                    this.dataSetTechConnection_0.tTC_Request.Rows[0]["id"] = this.int_0;
                    this.dataSetTechConnection_0.tTC_Request.Rows[0].EndEdit();
                    base.InsertSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Request);
                }
                else if (base.UpdateSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Doc))
                {
                    if (this.int_1 == -1)
                    {
                        this.dataSetTechConnection_0.tTC_Request.Rows[0]["id"] = this.int_0;
                        this.dataSetTechConnection_0.tTC_Request.Rows[0].EndEdit();
                        base.InsertSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Request);
                    }
                    else if (base.UpdateSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Request))
                    {
                        int? nullable = this.nullable_1;
                        int num = this.int_2;
                        if (!((nullable.GetValueOrDefault() == num) ? !nullable.HasValue : true))
                        {
                            nullable = this.nullable_2;
                            num = this.int_3;
                            if (!((nullable.GetValueOrDefault() == num) ? !nullable.HasValue : true))
                            {
                                return;
                            }
                        }
                        this.method_8();
                    }
                }
            }
        }

        private void FormTechConnectionRequestAddEdit_Load(object sender, EventArgs e)
        {
            base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tR_Classifier, true, " where ParentKey like ';VoltageLevels;%' and isGRoup = 0 and deleted = 0 order by value");
            if (this.int_0 == -1)
            {
                this.method_3();
                this.method_4();
            }
            else
            {
                base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Doc, true, "where id = " + this.int_0.ToString());
                if (this.dataSetTechConnection_0.tTC_Doc.Rows.Count > 0)
                {
                    if (this.dataSetTechConnection_0.tTC_Doc.Rows[0]["idParent"] != DBNull.Value)
                    {
                        this.nullable_0 = new int?(Convert.ToInt32(this.dataSetTechConnection_0.tTC_Doc.Rows[0]["idParent"]));
                    }
                    base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Request, true, "where id = " + this.int_0.ToString());
                    if (this.dataSetTechConnection_0.tTC_Request.Rows.Count == 0)
                    {
                        this.method_4();
                    }
                    else
                    {
                        this.method_2(this.int_0);
                    }
                }
                else
                {
                    this.method_3();
                    this.method_4();
                }
            }
            if ((this.dataSetTechConnection_0.tTC_Doc.Rows.Count > 0) && (this.dataSetTechConnection_0.tTC_Doc.Rows[0]["IdParent"] != DBNull.Value))
            {
                this.toolStripButton_0.Enabled = false;
                this.comboBox_0.Enabled = false;
            }
        }

        private void method_0()
        {
            this.Text = (this.int_0 == -1) ? "Новая заявка" : "Редактировать заявку";
            this.nullableDateTimePicker_0.set_Value(this.dateTimePicker_0.Value = DateTime.Now.Date);
        }

        private void method_1()
        {
            DataSetTechConnection.tAbnDataTable table = new DataSetTechConnection.tAbnDataTable();
            base.SelectSqlData(table, true, " where id = " + this.int_2.ToString(), false);
            if (table.Rows.Count > 0)
            {
                this.comboBox_0.SelectedValueChanged -= new EventHandler(this.comboBox_0_SelectedValueChanged);
                int num = Convert.ToInt32(table.Rows[0]["typeAbn"]);
                DataSetTechConnection.vAbnObjAddressDataTable table2 = new DataSetTechConnection.vAbnObjAddressDataTable();
                DataColumn column = new DataColumn("AddressFL") {
                    Expression = "street + ', д. ' + houseall + isnull(', кв. ' + name, '')"
                };
                table2.Columns.Add(column);
                column = new DataColumn("AddressUL") {
                    Expression = "street + ', д. ' + houseall"
                };
                table2.Columns.Add(column);
                base.SelectSqlData(table2, true, "where idAbn = " + this.int_2.ToString() + " order by name", false);
                this.comboBox_0.ValueMember = "id";
                this.comboBox_0.DataSource = table2;
                if (((num != 0xce) && (num != 0xfd)) && (num != 0x40d))
                {
                    this.comboBox_0.DisplayMember = "name";
                }
                else
                {
                    this.comboBox_0.DisplayMember = "AddressFL";
                }
                this.comboBox_0.SelectedValue = this.int_3;
                if (this.comboBox_0.SelectedValue == null)
                {
                    this.int_3 = -1;
                }
                this.comboBox_0.SelectedValueChanged += new EventHandler(this.comboBox_0_SelectedValueChanged);
            }
            else
            {
                this.comboBox_0.Items.Clear();
                this.int_3 = -1;
            }
        }

        private void method_2(int int_5)
        {
            DataSetTechConnection.tTC_RequestDataTable table = new DataSetTechConnection.tTC_RequestDataTable();
            base.SelectSqlData(table, true, " where id = " + int_5.ToString(), false);
            if (table.Rows.Count > 0)
            {
                if (table.Rows[0]["idAbn"] != DBNull.Value)
                {
                    this.nullable_1 = new int?(this.int_2 = Convert.ToInt32(table.Rows[0]["idAbn"]));
                    DataSetTechConnection.tAbnDataTable table2 = new DataSetTechConnection.tAbnDataTable();
                    base.SelectSqlData(table2, true, "where id = " + this.int_2.ToString(), false);
                    if (table2.Rows.Count > 0)
                    {
                        this.textBox_1.Text = table2.Rows[0]["name"].ToString();
                    }
                }
                if (table.Rows[0]["idAbnObj"] != DBNull.Value)
                {
                    this.nullable_2 = new int?(this.int_3 = Convert.ToInt32(table.Rows[0]["idAbnObj"]));
                }
                this.method_1();
            }
        }

        private void method_3()
        {
            this.int_0 = -1;
            DataRow row = this.dataSetTechConnection_0.tTC_Doc.NewRow();
            row["TypeDoc"] = this.int_4;
            row["DateDoc"] = DateTime.Now.Date;
            if (this.nullable_0.HasValue)
            {
                row["idParent"] = this.nullable_0;
                this.method_2(this.nullable_0.Value);
            }
            this.dataSetTechConnection_0.tTC_Doc.Rows.Add(row);
        }

        private void method_4()
        {
            this.int_1 = -1;
            DataRow row = this.dataSetTechConnection_0.tTC_Request.NewRow();
            row["id"] = this.dataSetTechConnection_0.tTC_Doc.Rows[0]["id"];
            this.dataSetTechConnection_0.tTC_Request.Rows.Add(row);
        }

        private void method_5(object sender, FormClosedEventArgs e)
        {
            FormTechConnectionAddAbn abn = (FormTechConnectionAddAbn) sender;
            if (abn.DialogResult == DialogResult.OK)
            {
                this.textBox_1.Text = abn.AbnName;
                this.int_2 = abn.IdAbn;
                this.textBox_2.Text = abn.AbnObjName;
                this.int_3 = abn.IdAbnObj;
                this.method_1();
            }
        }

        private bool method_6()
        {
            if (this.Id <= 0)
            {
                return false;
            }
            int num = 0x463;
            return (base.SelectSqlData("ttc_docout", true, " inner join ttc_doc d on d.id = ttc_docout.idDocout and d.TypeDoc = " + num.ToString() + " where ttc_docout.idDoc = " + this.Id.ToString()).Rows.Count > 0);
        }

        private FormBase method_7(object object_0, ShowFormEventArgs showFormEventArgs_0)
        {
            return this.OnShowForm(showFormEventArgs_0);
        }

        private void method_8()
        {
            using (SqlConnection connection = new SqlConnection(this.get_SqlSettings().GetConnectionString() + ";Connection Timeout=1000"))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    using (SqlCommand command = new SqlCommand(ResourceReader.GetStringAssembly("Documents.Forms.TechnologicalConnection.SqlScripts.ChangeAbnAndAbnObjRequest.sql"), connection))
                    {
                        command.Transaction = transaction;
                        command.Parameters.Add("id", SqlDbType.Int).Value = this.int_0;
                        command.Parameters.Add("idAbn", SqlDbType.Int).Value = this.int_2;
                        command.Parameters.Add("idAbnObj", SqlDbType.Int).Value = this.int_3;
                        command.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
                catch (Exception exception)
                {
                    transaction.Rollback();
                    MessageBox.Show(exception.Message, exception.Source);
                }
                finally
                {
                    if (transaction != null)
                    {
                        transaction.Dispose();
                    }
                }
            }
        }

        private void method_9()
        {
            this.label_0 = new Label();
            this.dateTimePicker_0 = new DateTimePicker();
            this.dataSetTechConnection_0 = new DataSetTechConnection();
            this.groupBox_0 = new GroupBox();
            this.nullableDateTimePicker_0 = new NullableDateTimePicker();
            this.label_1 = new Label();
            this.textBox_0 = new TextBox();
            this.label_2 = new Label();
            this.button_0 = new Button();
            this.button_1 = new Button();
            this.label_3 = new Label();
            this.textBox_1 = new TextBox();
            this.label_4 = new Label();
            this.textBox_2 = new TextBox();
            this.label_5 = new Label();
            this.textBox_3 = new TextBox();
            this.label_6 = new Label();
            this.numericUpDown_0 = new NumericUpDown();
            this.label_7 = new Label();
            this.textBox_4 = new TextBox();
            this.toolStripButton_0 = new ToolStripButton();
            this.toolStrip_0 = new ToolStrip();
            this.comboBox_0 = new ComboBox();
            this.label_8 = new Label();
            this.comboBox_1 = new ComboBox();
            this.numericUpDown_1 = new NumericUpDown();
            this.label_9 = new Label();
            this.numericUpDown_2 = new NumericUpDown();
            this.label_10 = new Label();
            this.dataSetTechConnection_0.BeginInit();
            this.groupBox_0.SuspendLayout();
            this.numericUpDown_0.BeginInit();
            this.toolStrip_0.SuspendLayout();
            this.numericUpDown_1.BeginInit();
            this.numericUpDown_2.BeginInit();
            base.SuspendLayout();
            this.label_0.AutoSize = true;
            this.label_0.Location = new Point(40, 0x13);
            this.label_0.Name = "label1";
            this.label_0.Size = new Size(100, 13);
            this.label_0.TabIndex = 0;
            this.label_0.Text = "Дата поступления";
            this.dateTimePicker_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.dateTimePicker_0.DataBindings.Add(new Binding("Value", this.dataSetTechConnection_0, "tTC_Doc.dateDoc", true));
            this.dateTimePicker_0.Location = new Point(0x92, 12);
            this.dateTimePicker_0.Name = "dateTimePickerDate";
            this.dateTimePicker_0.Size = new Size(0x112, 20);
            this.dateTimePicker_0.TabIndex = 1;
            this.dataSetTechConnection_0.DataSetName = "DataSetTechConnection";
            this.dataSetTechConnection_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.groupBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.groupBox_0.Controls.Add(this.nullableDateTimePicker_0);
            this.groupBox_0.Controls.Add(this.label_1);
            this.groupBox_0.Controls.Add(this.textBox_0);
            this.groupBox_0.Controls.Add(this.label_2);
            this.groupBox_0.Location = new Point(2, 0x26);
            this.groupBox_0.Name = "groupBoxDocIn";
            this.groupBox_0.Size = new Size(0x1be, 0x38);
            this.groupBox_0.TabIndex = 2;
            this.groupBox_0.TabStop = false;
            this.groupBox_0.Text = "Входящий документ";
            this.nullableDateTimePicker_0.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.nullableDateTimePicker_0.set_CustomFormat("dd.MM.yyyy");
            this.nullableDateTimePicker_0.DataBindings.Add(new Binding("Value", this.dataSetTechConnection_0, "tTC_Request.dateIn", true));
            this.nullableDateTimePicker_0.set_Format(DateTimePickerFormat.Custom);
            this.nullableDateTimePicker_0.Location = new Point(0x145, 0x18);
            this.nullableDateTimePicker_0.Name = "dateTimePickerDateDocIn";
            this.nullableDateTimePicker_0.Size = new Size(0x73, 20);
            this.nullableDateTimePicker_0.TabIndex = 3;
            this.nullableDateTimePicker_0.set_Value(new DateTime(0x7dd, 4, 15, 13, 0x1c, 0x35, 0x324));
            this.label_1.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.label_1.AutoSize = true;
            this.label_1.Location = new Point(0x11e, 0x1b);
            this.label_1.Name = "label3";
            this.label_1.Size = new Size(0x21, 13);
            this.label_1.TabIndex = 2;
            this.label_1.Text = "Дата";
            this.textBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_0.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tTC_Request.numIn", true));
            this.textBox_0.Location = new Point(0x39, 0x18);
            this.textBox_0.Name = "txtNumDocIn";
            this.textBox_0.Size = new Size(0xdf, 20);
            this.textBox_0.TabIndex = 1;
            this.label_2.AutoSize = true;
            this.label_2.Location = new Point(10, 0x1b);
            this.label_2.Name = "label2";
            this.label_2.Size = new Size(0x29, 13);
            this.label_2.TabIndex = 0;
            this.label_2.Text = "Номер";
            this.button_0.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.button_0.DialogResult = DialogResult.OK;
            this.button_0.Location = new Point(12, 520);
            this.button_0.Name = "buttonOK";
            this.button_0.Size = new Size(0x4b, 0x17);
            this.button_0.TabIndex = 0x15;
            this.button_0.Text = "ОК";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new EventHandler(this.button_0_Click);
            this.button_1.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.button_1.DialogResult = DialogResult.Cancel;
            this.button_1.Location = new Point(0x175, 520);
            this.button_1.Name = "buttonCancel";
            this.button_1.Size = new Size(0x4b, 0x17);
            this.button_1.TabIndex = 0x16;
            this.button_1.Text = "Отмена";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new EventHandler(this.button_1_Click);
            this.label_3.AutoSize = true;
            this.label_3.Location = new Point(9, 0x61);
            this.label_3.Name = "label4";
            this.label_3.Size = new Size(0x31, 13);
            this.label_3.TabIndex = 3;
            this.label_3.Text = "Абонент";
            this.textBox_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_1.BackColor = SystemColors.Window;
            this.textBox_1.Location = new Point(12, 0x71);
            this.textBox_1.Name = "txtAbn";
            this.textBox_1.ReadOnly = true;
            this.textBox_1.Size = new Size(0x1b4, 20);
            this.textBox_1.TabIndex = 4;
            this.label_4.AutoSize = true;
            this.label_4.Location = new Point(12, 0x88);
            this.label_4.Name = "label5";
            this.label_4.Size = new Size(0x2d, 13);
            this.label_4.TabIndex = 5;
            this.label_4.Text = "Объект";
            this.textBox_2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_2.BackColor = SystemColors.Window;
            this.textBox_2.Location = new Point(0xd7, 130);
            this.textBox_2.Name = "txtAbnObj";
            this.textBox_2.ReadOnly = true;
            this.textBox_2.Size = new Size(0x9d, 20);
            this.textBox_2.TabIndex = 7;
            this.textBox_2.Visible = false;
            this.label_5.AutoSize = true;
            this.label_5.Location = new Point(12, 0xaf);
            this.label_5.Name = "label6";
            this.label_5.Size = new Size(0x49, 13);
            this.label_5.TabIndex = 9;
            this.label_5.Text = "Тело письма";
            this.textBox_3.AcceptsReturn = true;
            this.textBox_3.AcceptsTab = true;
            this.textBox_3.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_3.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tTC_Request.body", true));
            this.textBox_3.Location = new Point(12, 0xbf);
            this.textBox_3.Multiline = true;
            this.textBox_3.Name = "txtBody";
            this.textBox_3.Size = new Size(0x1b4, 0x61);
            this.textBox_3.TabIndex = 10;
            this.label_6.AutoSize = true;
            this.label_6.Location = new Point(12, 0x158);
            this.label_6.Name = "label7";
            this.label_6.Size = new Size(0x8b, 13);
            this.label_6.TabIndex = 15;
            this.label_6.Text = "Максимальная мощность";
            this.numericUpDown_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.numericUpDown_0.DataBindings.Add(new Binding("Value", this.dataSetTechConnection_0, "tTC_Request.Power", true));
            this.numericUpDown_0.DecimalPlaces = 3;
            this.numericUpDown_0.Location = new Point(0x9e, 0x156);
            int[] bits = new int[4];
            bits[0] = 0x186a0;
            this.numericUpDown_0.Maximum = new decimal(bits);
            this.numericUpDown_0.Name = "numericUpDown1";
            this.numericUpDown_0.Size = new Size(290, 20);
            this.numericUpDown_0.TabIndex = 0x10;
            this.numericUpDown_0.TextAlign = HorizontalAlignment.Right;
            this.label_7.AutoSize = true;
            this.label_7.Location = new Point(12, 0x18e);
            this.label_7.Name = "label8";
            this.label_7.Size = new Size(0x4d, 13);
            this.label_7.TabIndex = 0x13;
            this.label_7.Text = "Комментарий";
            this.textBox_4.AcceptsReturn = true;
            this.textBox_4.AcceptsTab = true;
            this.textBox_4.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.textBox_4.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tTC_Doc.Comment", true));
            this.textBox_4.Location = new Point(15, 0x19e);
            this.textBox_4.Multiline = true;
            this.textBox_4.Name = "txtComment";
            this.textBox_4.Size = new Size(0x1b1, 100);
            this.textBox_4.TabIndex = 20;
            this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_0.Image = Resources.partners;
            this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_0.Name = "toolBtnContractor";
            this.toolStripButton_0.Size = new Size(0x17, 0x16);
            this.toolStripButton_0.Text = "Выбрать контрагента";
            this.toolStripButton_0.Click += new EventHandler(this.toolStripButton_0_Click);
            this.toolStrip_0.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.toolStrip_0.Dock = DockStyle.None;
            this.toolStrip_0.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripButton_0 };
            this.toolStrip_0.Items.AddRange(toolStripItems);
            this.toolStrip_0.Location = new Point(0x1a5, 130);
            this.toolStrip_0.Name = "toolStrip1";
            this.toolStrip_0.Size = new Size(0x1a, 0x19);
            this.toolStrip_0.TabIndex = 8;
            this.toolStrip_0.Text = "toolStrip1";
            this.comboBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.comboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox_0.FormattingEnabled = true;
            this.comboBox_0.Location = new Point(12, 0x97);
            this.comboBox_0.Name = "cmbAbnObj";
            this.comboBox_0.Size = new Size(0x1b4, 0x15);
            this.comboBox_0.TabIndex = 6;
            this.comboBox_0.SelectedValueChanged += new EventHandler(this.comboBox_0_SelectedValueChanged);
            this.label_8.AutoSize = true;
            this.label_8.Location = new Point(12, 0x174);
            this.label_8.Name = "label9";
            this.label_8.Size = new Size(0x47, 13);
            this.label_8.TabIndex = 0x11;
            this.label_8.Text = "Напряжение";
            this.comboBox_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.comboBox_1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_1.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox_1.DataBindings.Add(new Binding("SelectedValue", this.dataSetTechConnection_0, "tTC_Request.VoltageLevel", true));
            this.comboBox_1.DataSource = this.dataSetTechConnection_0;
            this.comboBox_1.DisplayMember = "tR_Classifier.Name";
            this.comboBox_1.FormattingEnabled = true;
            this.comboBox_1.Location = new Point(0x9e, 0x171);
            this.comboBox_1.Name = "cmbVoltage";
            this.comboBox_1.Size = new Size(0x121, 0x15);
            this.comboBox_1.TabIndex = 0x12;
            this.comboBox_1.ValueMember = "tR_Classifier.Id";
            this.numericUpDown_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.numericUpDown_1.DataBindings.Add(new Binding("Value", this.dataSetTechConnection_0, "tTC_Request.PowerAdd", true));
            this.numericUpDown_1.DecimalPlaces = 3;
            this.numericUpDown_1.Location = new Point(0x9e, 0x13e);
            int[] numArray2 = new int[4];
            numArray2[0] = 0x186a0;
            this.numericUpDown_1.Maximum = new decimal(numArray2);
            this.numericUpDown_1.Name = "numericUpDown2";
            this.numericUpDown_1.Size = new Size(290, 20);
            this.numericUpDown_1.TabIndex = 14;
            this.numericUpDown_1.TextAlign = HorizontalAlignment.Right;
            this.label_9.AutoSize = true;
            this.label_9.Location = new Point(12, 320);
            this.label_9.Name = "label10";
            this.label_9.Size = new Size(0x94, 13);
            this.label_9.TabIndex = 13;
            this.label_9.Text = "Дополнительная мощность";
            this.numericUpDown_2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.numericUpDown_2.DataBindings.Add(new Binding("Value", this.dataSetTechConnection_0, "tTC_Request.PowerCurrent", true));
            this.numericUpDown_2.DecimalPlaces = 3;
            this.numericUpDown_2.Location = new Point(0x9e, 0x126);
            int[] numArray3 = new int[4];
            numArray3[0] = 0x186a0;
            this.numericUpDown_2.Maximum = new decimal(numArray3);
            this.numericUpDown_2.Name = "numericUpDown3";
            this.numericUpDown_2.Size = new Size(290, 20);
            this.numericUpDown_2.TabIndex = 12;
            this.numericUpDown_2.TextAlign = HorizontalAlignment.Right;
            this.label_10.AutoSize = true;
            this.label_10.Location = new Point(12, 0x128);
            this.label_10.Name = "label11";
            this.label_10.Size = new Size(140, 13);
            this.label_10.TabIndex = 11;
            this.label_10.Text = "Существующая мощность";
            base.AcceptButton = this.button_0;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.CancelButton = this.button_1;
            base.ClientSize = new Size(0x1c9, 0x225);
            base.Controls.Add(this.numericUpDown_2);
            base.Controls.Add(this.label_10);
            base.Controls.Add(this.numericUpDown_1);
            base.Controls.Add(this.label_9);
            base.Controls.Add(this.comboBox_1);
            base.Controls.Add(this.label_8);
            base.Controls.Add(this.comboBox_0);
            base.Controls.Add(this.textBox_4);
            base.Controls.Add(this.label_7);
            base.Controls.Add(this.toolStrip_0);
            base.Controls.Add(this.numericUpDown_0);
            base.Controls.Add(this.label_6);
            base.Controls.Add(this.textBox_3);
            base.Controls.Add(this.label_5);
            base.Controls.Add(this.textBox_2);
            base.Controls.Add(this.label_4);
            base.Controls.Add(this.textBox_1);
            base.Controls.Add(this.label_3);
            base.Controls.Add(this.button_1);
            base.Controls.Add(this.button_0);
            base.Controls.Add(this.groupBox_0);
            base.Controls.Add(this.dateTimePicker_0);
            base.Controls.Add(this.label_0);
            base.Name = "FormTechConnectionRequestAddEdit";
            this.Text = "FormTechConnectionRequestAddEdit";
            base.FormClosing += new FormClosingEventHandler(this.FormTechConnectionRequestAddEdit_FormClosing);
            base.Load += new EventHandler(this.FormTechConnectionRequestAddEdit_Load);
            this.dataSetTechConnection_0.EndInit();
            this.groupBox_0.ResumeLayout(false);
            this.groupBox_0.PerformLayout();
            this.numericUpDown_0.EndInit();
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            this.numericUpDown_1.EndInit();
            this.numericUpDown_2.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void toolStripButton_0_Click(object sender, EventArgs e)
        {
            FormTechConnectionAddAbn abn1 = new FormTechConnectionAddAbn(this.int_2, this.int_3, true);
            abn1.add_ShowForm(new ShowFormEventHandler(this, this.method_7));
            abn1.set_SqlSettings(this.get_SqlSettings());
            abn1.MdiParent = base.MdiParent;
            abn1.FormClosed += new FormClosedEventHandler(this.method_5);
            abn1.Show();
        }

        public int Id
        {
            get
            {
                if (this.nullable_0.HasValue)
                {
                    return this.nullable_0.Value;
                }
                return this.int_0;
            }
            set
            {
                this.int_0 = value;
            }
        }
    }
}

