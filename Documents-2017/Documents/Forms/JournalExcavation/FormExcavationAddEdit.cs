namespace Documents.Forms.JournalExcavation
{
    using ControlsLbr;
    using Documents.Properties;
    using FormLbr;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;

    public class FormExcavationAddEdit : FormBase
    {
        private Button button_0;
        private Button button_1;
        private CheckBox checkBox_0;
        private ComboBox comboBox_0;
        private ComboBox comboBox_1;
        private ComboBox comboBox_2;
        private ComboBox comboBox_3;
        private ComboBox comboBox_4;
        private ComboBox comboBox_5;
        private DataSetExcavation dataSetExcavation_0;
        private DateTimePicker dateTimePicker_0;
        private Dictionary<string, string> dictionary_0;
        private GroupBox groupBox_0;
        private GroupBox groupBox_1;
        private GroupBox groupBox_2;
        private GroupBox groupBox_3;
        private GroupBox groupBox_4;
        private IContainer icontainer_0;
        internal int int_0;
        private KladrStreetControl kladrStreetControl_0;
        private Label label_0;
        private Label label_1;
        private Label label_10;
        private Label label_11;
        private Label label_12;
        private Label label_13;
        private Label label_14;
        private Label label_15;
        private Label label_16;
        private Label label_17;
        private Label label_2;
        private Label label_3;
        private Label label_4;
        private Label label_5;
        private Label label_6;
        private Label label_7;
        private Label label_8;
        private Label label_9;
        private NullableDateTimePicker nullableDateTimePicker_0;
        private NullableDateTimePicker nullableDateTimePicker_1;
        private NullableDateTimePicker nullableDateTimePicker_2;
        private NullableDateTimePicker nullableDateTimePicker_3;
        private NullableDateTimePicker nullableDateTimePicker_4;
        private NullableDateTimePicker nullableDateTimePicker_5;
        private NullableDateTimePicker nullableDateTimePicker_6;
        private NullableDateTimePicker nullableDateTimePicker_7;
        private TextBox textBox_0;
        private TextBox textBox_1;
        private TextBox textBox_2;
        private TextBox textBox_3;
        private DataSetExcavation.tJ_ExcavationStatusDataTable tJ_ExcavationStatusDataTable_0;
        private ToolStrip toolStrip_0;
        private ToolStripButton toolStripButton_0;

        public FormExcavationAddEdit()
        {
            this.int_0 = -1;
            this.dictionary_0 = new Dictionary<string, string>();
            this.method_3();
            this.method_0();
        }

        public FormExcavationAddEdit(int int_1)
        {
            this.int_0 = -1;
            this.dictionary_0 = new Dictionary<string, string>();
            this.method_3();
            this.int_0 = int_1;
            this.method_0();
        }

        private void checkBox_0_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_0.Checked && (this.dataSetExcavation_0.tJ_Excavation.Rows.Count > 0))
            {
                this.nullableDateTimePicker_7.set_Value(DateTime.Now.Date);
                this.dataSetExcavation_0.tJ_Excavation.Rows[0]["dateAgreed"] = DateTime.Now.Date;
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

        private void FormExcavationAddEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (base.DialogResult == DialogResult.OK)
            {
                if (this.kladrStreetControl_0.get_CmbStreet().SelectedIndex < 0)
                {
                    MessageBox.Show("Не указан адрес раскопки");
                    e.Cancel = true;
                }
                else if (string.IsNullOrEmpty(this.comboBox_4.Text) && (this.comboBox_4.SelectedValue == null))
                {
                    MessageBox.Show("Не указана кабельная линия");
                    e.Cancel = true;
                }
                else
                {
                    if (this.checkBox_0.Checked)
                    {
                        if ((this.nullableDateTimePicker_7.get_Value() == null) || (this.nullableDateTimePicker_7.get_Value() == DBNull.Value))
                        {
                            MessageBox.Show("Не указана дата согласования");
                            e.Cancel = true;
                            return;
                        }
                        if ((this.comboBox_5.SelectedIndex < 0) && (this.comboBox_5.Items.Count > 0))
                        {
                            MessageBox.Show("Не указан согласующий");
                            e.Cancel = true;
                            return;
                        }
                    }
                    if (this.int_0 == -1)
                    {
                        this.dataSetExcavation_0.tJ_Excavation.Rows[0].EndEdit();
                        this.int_0 = base.InsertSqlDataOneRow(this.dataSetExcavation_0, this.dataSetExcavation_0.tJ_Excavation);
                        this.tJ_ExcavationStatusDataTable_0.Rows[0]["idExcavation"] = this.int_0;
                        this.tJ_ExcavationStatusDataTable_0.Rows[0]["dateChange"] = this.dateTimePicker_0.Value;
                        this.tJ_ExcavationStatusDataTable_0.Rows[0].EndEdit();
                        base.InsertSqlData(null, this.tJ_ExcavationStatusDataTable_0);
                    }
                    else
                    {
                        this.dataSetExcavation_0.tJ_Excavation.Rows[0].EndEdit();
                        base.UpdateSqlData(this.dataSetExcavation_0, this.dataSetExcavation_0.tJ_Excavation);
                    }
                    this.dataSetExcavation_0.tJ_ExcavationAddress.Rows[0]["idExcavation"] = this.int_0;
                    this.dataSetExcavation_0.tJ_ExcavationAddress.Rows[0]["idStreet"] = this.kladrStreetControl_0.get_CmbStreet().SelectedValue;
                    this.dataSetExcavation_0.tJ_ExcavationAddress.Rows[0].EndEdit();
                    base.InsertSqlData(this.dataSetExcavation_0, this.dataSetExcavation_0.tJ_ExcavationAddress);
                    base.UpdateSqlData(this.dataSetExcavation_0, this.dataSetExcavation_0.tJ_ExcavationAddress);
                    this.dataSetExcavation_0.tJ_ExcavationSchmObj.Rows[0]["idExcavation"] = this.int_0;
                    if (this.comboBox_4.SelectedValue == null)
                    {
                        this.dataSetExcavation_0.tJ_ExcavationSchmObj.Rows[0]["idKL"] = DBNull.Value;
                    }
                    else
                    {
                        this.dataSetExcavation_0.tJ_ExcavationSchmObj.Rows[0]["idkl"] = this.comboBox_4.SelectedValue;
                    }
                    this.dataSetExcavation_0.tJ_ExcavationSchmObj.Rows[0]["namekl"] = this.comboBox_4.Text;
                    this.dataSetExcavation_0.tJ_ExcavationSchmObj.Rows[0].EndEdit();
                    base.InsertSqlData(this.dataSetExcavation_0, this.dataSetExcavation_0.tJ_ExcavationSchmObj);
                    base.UpdateSqlData(this.dataSetExcavation_0, this.dataSetExcavation_0.tJ_ExcavationSchmObj);
                }
            }
        }

        private void FormExcavationAddEdit_Load(object sender, EventArgs e)
        {
            this.kladrStreetControl_0.set_SqlSettings(this.get_SqlSettings());
            this.method_1();
            if (this.int_0 == -1)
            {
                DataRow row = this.dataSetExcavation_0.tJ_Excavation.NewRow();
                row["num"] = -1;
                row["DateBeg"] = DateTime.Now.Date;
                this.dataSetExcavation_0.tJ_Excavation.Rows.Add(row);
                row = this.tJ_ExcavationStatusDataTable_0.NewRow();
                row["idExcavation"] = this.int_0;
                row["idType"] = 1;
                row["idStatus"] = this.comboBox_2.SelectedValue;
                row["dateChange"] = this.dateTimePicker_0.Value;
                this.tJ_ExcavationStatusDataTable_0.Rows.Add(row);
                row = this.dataSetExcavation_0.tJ_ExcavationAddress.NewRow();
                row["idExcavation"] = this.int_0;
                this.dataSetExcavation_0.tJ_ExcavationAddress.Rows.Add(row);
                row = this.dataSetExcavation_0.tJ_ExcavationSchmObj.NewRow();
                row["idExcavation"] = this.int_0;
                this.dataSetExcavation_0.tJ_ExcavationSchmObj.Rows.Add(row);
            }
            else
            {
                base.SelectSqlData(this.dataSetExcavation_0, this.dataSetExcavation_0.tJ_Excavation, true, "where id = " + this.int_0.ToString());
                base.SelectSqlData(this.tJ_ExcavationStatusDataTable_0, true, "where idExcavation = " + this.int_0.ToString() + " and idType = 1 order by datechange desc ", false);
                this.comboBox_2.Enabled = false;
                base.SelectSqlData(this.dataSetExcavation_0, this.dataSetExcavation_0.tJ_ExcavationAddress, true, " where idExcavation = " + this.int_0.ToString());
                if (this.dataSetExcavation_0.tJ_ExcavationAddress.Rows.Count == 0)
                {
                    DataRow row2 = this.dataSetExcavation_0.tJ_ExcavationAddress.NewRow();
                    row2["idExcavation"] = this.int_0;
                    this.dataSetExcavation_0.tJ_ExcavationAddress.Rows.Add(row2);
                }
                else
                {
                    this.kladrStreetControl_0.get_CmbStreet().SelectedValue = this.dataSetExcavation_0.tJ_ExcavationAddress.Rows[0]["idStreet"];
                    if (this.dataSetExcavation_0.tJ_ExcavationAddress.Rows.Count > 1)
                    {
                        this.groupBox_2.Enabled = false;
                    }
                    else
                    {
                        this.dataSetExcavation_0.tJ_ExcavationAddress.Rows[0].BeginEdit();
                    }
                }
                base.SelectSqlData(this.dataSetExcavation_0, this.dataSetExcavation_0.tJ_ExcavationSchmObj, true, " where idExcavation = " + this.int_0.ToString());
                if (this.dataSetExcavation_0.tJ_ExcavationAddress.Rows.Count == 0)
                {
                    DataRow row3 = this.dataSetExcavation_0.tJ_ExcavationSchmObj.NewRow();
                    row3["idExcavation"] = this.int_0;
                    this.dataSetExcavation_0.tJ_ExcavationSchmObj.Rows.Add(row3);
                }
                else
                {
                    if (this.dataSetExcavation_0.tJ_ExcavationSchmObj.Rows[0]["idKL"] != DBNull.Value)
                    {
                        this.comboBox_4.SelectedValue = this.dataSetExcavation_0.tJ_ExcavationSchmObj.Rows[0]["idKL"];
                    }
                    else
                    {
                        this.comboBox_4.Text = this.dataSetExcavation_0.tJ_ExcavationSchmObj.Rows[0]["nameKL"].ToString();
                    }
                    if (this.dataSetExcavation_0.tJ_ExcavationSchmObj.Rows.Count > 1)
                    {
                        this.groupBox_3.Enabled = false;
                    }
                    else
                    {
                        this.dataSetExcavation_0.tJ_ExcavationSchmObj.Rows[0].BeginEdit();
                    }
                }
            }
        }

        private void kladrStreetControl_0_ChangeStreetSelect(object sender, EventArgs e)
        {
            if ((this.kladrStreetControl_0.get_SelectedStreet().get_SelectedValue() != null) && (this.kladrStreetControl_0.get_SelectedStreet().get_SelectedValue() != DBNull.Value))
            {
                DataTable table = base.SelectSqlData("tr_KladrStreet", true, " where id = " + this.kladrStreetControl_0.get_SelectedStreet().get_SelectedValue().ToString());
                if ((table.Rows.Count > 0) && (table.Rows[0]["GNINMB"] != DBNull.Value))
                {
                    this.comboBox_3.Text = this.dictionary_0[table.Rows[0]["GNINMB"].ToString()];
                    if (this.dataSetExcavation_0.tJ_ExcavationAddress.Rows.Count == 1)
                    {
                        this.dataSetExcavation_0.tJ_ExcavationAddress.Rows[0]["idregion"] = this.comboBox_3.SelectedValue;
                    }
                }
            }
        }

        private void method_0()
        {
            object obj2;
            this.Text = (this.int_0 == -1) ? "Новая раскопка" : "Редактирование раскопки";
            this.nullableDateTimePicker_1.set_Value(obj2 = DateTime.Now.Date);
            this.nullableDateTimePicker_0.set_Value(obj2);
            this.tJ_ExcavationStatusDataTable_0 = new DataSetExcavation.tJ_ExcavationStatusDataTable();
            this.comboBox_2.DataBindings.Add(new Binding("SelectedValue", this.tJ_ExcavationStatusDataTable_0, "idStatus", true));
            this.dictionary_0.Add("7325", "Ленинский");
            this.dictionary_0.Add("7328", "Заволжский");
            this.dictionary_0.Add("7327", "Засвияжский");
            this.dictionary_0.Add("7326", "Железнодорожный");
        }

        private void method_1()
        {
            DataTable table = base.SelectSqlData("tr_classifier", true, " where ParentKey = ';Excavation;TypeWork;' and isGRoup = 0 and deleted = 0 order by name");
            this.comboBox_1.DataSource = table;
            this.comboBox_1.DisplayMember = "Name";
            this.comboBox_1.ValueMember = "Id";
            this.comboBox_1.SelectedIndex = -1;
            this.method_2();
            this.comboBox_0.SelectedIndex = -1;
            if (this.int_0 == -1)
            {
                table = base.SelectSqlData("tr_classifier", true, " where ParentKey = ';Excavation;StatusOrder;' and isGRoup = 0 and value <> 4 and deleted = 0 order by name");
            }
            else
            {
                table = base.SelectSqlData("tr_classifier", true, " where ParentKey = ';Excavation;StatusOrder;' and isGRoup = 0 and deleted = 0 order by name");
            }
            this.comboBox_2.DataSource = table;
            this.comboBox_2.DisplayMember = "Name";
            this.comboBox_2.ValueMember = "Id";
            if ((table.Rows.Count > 0) && (table.Select("Value = 1").Length != 0))
            {
                this.comboBox_2.SelectedValue = table.Select("Value = 1")[0]["id"];
            }
            else
            {
                this.comboBox_2.SelectedIndex = -1;
            }
            table = base.SelectSqlData("tR_Classifier", true, " where ParentKey = ';CityRaion;UlyanovskRaion;' and isGRoup = 0 and deleted = 0 order by name");
            this.comboBox_3.DataSource = table;
            this.comboBox_3.DisplayMember = "Name";
            this.comboBox_3.ValueMember = "id";
            this.comboBox_3.SelectedIndex = -1;
            table = new DataTable("tSChm_ObjList");
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("name", typeof(string));
            base.SelectSqlData(table, true, " where typeCodeid = 546 and deleted = 0 order by name", false);
            this.comboBox_4.DataSource = table;
            this.comboBox_4.DisplayMember = "name";
            this.comboBox_4.ValueMember = "id";
            this.comboBox_4.SelectedIndex = -1;
            table = new DataTable("vWorkerGroup");
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("fio", typeof(string));
            base.SelectSqlData(table, true, " where ParentKey in (';GroupWorker;ReconcileExcavation;') and dateEnd is null order by fio ", false);
            this.comboBox_5.DataSource = table;
            this.comboBox_5.DisplayMember = "fio";
            this.comboBox_5.ValueMember = "id";
            this.comboBox_5.SelectedIndex = -1;
        }

        private void method_2()
        {
            DataTable table = base.SelectSqlData("vAbnType", true, " where typeKontragent = " + 0x416.ToString() + " and deleted = 0 order by name ");
            this.comboBox_0.DataSource = table;
            this.comboBox_0.DisplayMember = "Name";
            this.comboBox_0.ValueMember = "idAbn";
        }

        private void method_3()
        {
            this.dataSetExcavation_0 = new DataSetExcavation();
            this.label_0 = new Label();
            this.textBox_0 = new TextBox();
            this.label_1 = new Label();
            this.dateTimePicker_0 = new DateTimePicker();
            this.label_2 = new Label();
            this.comboBox_0 = new ComboBox();
            this.label_3 = new Label();
            this.comboBox_1 = new ComboBox();
            this.groupBox_0 = new GroupBox();
            this.comboBox_2 = new ComboBox();
            this.label_4 = new Label();
            this.nullableDateTimePicker_0 = new NullableDateTimePicker();
            this.label_5 = new Label();
            this.nullableDateTimePicker_1 = new NullableDateTimePicker();
            this.label_6 = new Label();
            this.groupBox_1 = new GroupBox();
            this.nullableDateTimePicker_2 = new NullableDateTimePicker();
            this.label_7 = new Label();
            this.textBox_1 = new TextBox();
            this.label_8 = new Label();
            this.label_9 = new Label();
            this.nullableDateTimePicker_3 = new NullableDateTimePicker();
            this.nullableDateTimePicker_4 = new NullableDateTimePicker();
            this.label_10 = new Label();
            this.nullableDateTimePicker_5 = new NullableDateTimePicker();
            this.label_11 = new Label();
            this.nullableDateTimePicker_6 = new NullableDateTimePicker();
            this.label_12 = new Label();
            this.kladrStreetControl_0 = new KladrStreetControl();
            this.groupBox_2 = new GroupBox();
            this.comboBox_3 = new ComboBox();
            this.label_15 = new Label();
            this.textBox_2 = new TextBox();
            this.label_13 = new Label();
            this.textBox_3 = new TextBox();
            this.label_14 = new Label();
            this.groupBox_3 = new GroupBox();
            this.comboBox_4 = new ComboBox();
            this.button_0 = new Button();
            this.button_1 = new Button();
            this.groupBox_4 = new GroupBox();
            this.comboBox_5 = new ComboBox();
            this.label_16 = new Label();
            this.label_17 = new Label();
            this.nullableDateTimePicker_7 = new NullableDateTimePicker();
            this.checkBox_0 = new CheckBox();
            this.toolStrip_0 = new ToolStrip();
            this.toolStripButton_0 = new ToolStripButton();
            this.dataSetExcavation_0.BeginInit();
            this.groupBox_0.SuspendLayout();
            this.groupBox_1.SuspendLayout();
            this.groupBox_2.SuspendLayout();
            this.groupBox_3.SuspendLayout();
            this.groupBox_4.SuspendLayout();
            this.toolStrip_0.SuspendLayout();
            base.SuspendLayout();
            this.dataSetExcavation_0.DataSetName = "DataSetExcavation";
            this.dataSetExcavation_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.label_0.AutoSize = true;
            this.label_0.Location = new Point(12, 9);
            this.label_0.Name = "label1";
            this.label_0.Size = new Size(0x29, 13);
            this.label_0.TabIndex = 0;
            this.label_0.Text = "Номер";
            this.textBox_0.DataBindings.Add(new Binding("Text", this.dataSetExcavation_0, "tJ_Excavation.num", true));
            this.textBox_0.Enabled = false;
            this.textBox_0.Location = new Point(15, 0x19);
            this.textBox_0.Name = "txtNum";
            this.textBox_0.Size = new Size(100, 20);
            this.textBox_0.TabIndex = 1;
            this.label_1.AutoSize = true;
            this.label_1.Location = new Point(0x90, 9);
            this.label_1.Name = "label2";
            this.label_1.Size = new Size(0x47, 13);
            this.label_1.TabIndex = 2;
            this.label_1.Text = "Дата начала";
            this.dateTimePicker_0.DataBindings.Add(new Binding("Value", this.dataSetExcavation_0, "tJ_Excavation.dateBeg", true));
            this.dateTimePicker_0.Location = new Point(0x93, 0x19);
            this.dateTimePicker_0.Name = "dateTimePickerBeg";
            this.dateTimePicker_0.Size = new Size(0x9d, 20);
            this.dateTimePicker_0.TabIndex = 3;
            this.label_2.AutoSize = true;
            this.label_2.Location = new Point(12, 0x39);
            this.label_2.Name = "label3";
            this.label_2.Size = new Size(0x3e, 13);
            this.label_2.TabIndex = 4;
            this.label_2.Text = "Подрядчик";
            this.comboBox_0.DataBindings.Add(new Binding("SelectedValue", this.dataSetExcavation_0, "tJ_Excavation.idContractor", true));
            this.comboBox_0.FormattingEnabled = true;
            this.comboBox_0.Location = new Point(15, 0x49);
            this.comboBox_0.Name = "cmbContractor";
            this.comboBox_0.Size = new Size(0xff, 0x15);
            this.comboBox_0.TabIndex = 5;
            this.label_3.AutoSize = true;
            this.label_3.Location = new Point(12, 0x6a);
            this.label_3.Name = "label4";
            this.label_3.Size = new Size(0x3a, 13);
            this.label_3.TabIndex = 6;
            this.label_3.Text = "Вид работ";
            this.comboBox_1.DataBindings.Add(new Binding("SelectedValue", this.dataSetExcavation_0, "tJ_Excavation.TypeWork", true));
            this.comboBox_1.FormattingEnabled = true;
            this.comboBox_1.Location = new Point(15, 0x7a);
            this.comboBox_1.Name = "cmbTypeWork";
            this.comboBox_1.Size = new Size(0xff, 0x15);
            this.comboBox_1.TabIndex = 7;
            this.groupBox_0.Controls.Add(this.comboBox_2);
            this.groupBox_0.Controls.Add(this.label_4);
            this.groupBox_0.Controls.Add(this.nullableDateTimePicker_0);
            this.groupBox_0.Controls.Add(this.label_5);
            this.groupBox_0.Controls.Add(this.nullableDateTimePicker_1);
            this.groupBox_0.Controls.Add(this.label_6);
            this.groupBox_0.Location = new Point(15, 0x95);
            this.groupBox_0.Name = "groupBoxOrder";
            this.groupBox_0.Size = new Size(0x121, 80);
            this.groupBox_0.TabIndex = 8;
            this.groupBox_0.TabStop = false;
            this.groupBox_0.Text = "Ордер";
            this.comboBox_2.FormattingEnabled = true;
            this.comboBox_2.Location = new Point(0x48, 50);
            this.comboBox_2.Name = "cmbStatusOrder";
            this.comboBox_2.Size = new Size(0xcf, 0x15);
            this.comboBox_2.TabIndex = 5;
            this.label_4.AutoSize = true;
            this.label_4.Location = new Point(6, 0x35);
            this.label_4.Name = "label7";
            this.label_4.Size = new Size(60, 13);
            this.label_4.TabIndex = 4;
            this.label_4.Text = "состояние";
            this.nullableDateTimePicker_0.DataBindings.Add(new Binding("Value", this.dataSetExcavation_0, "tJ_Excavation.dateEndOrder", true));
            this.nullableDateTimePicker_0.set_Format(DateTimePickerFormat.Short);
            this.nullableDateTimePicker_0.Location = new Point(0xa2, 0x12);
            this.nullableDateTimePicker_0.Name = "datetimePickerOrderEnd";
            this.nullableDateTimePicker_0.Size = new Size(0x75, 20);
            this.nullableDateTimePicker_0.TabIndex = 3;
            this.nullableDateTimePicker_0.set_Value(new DateTime(0x7dd, 3, 0x1c, 9, 0x26, 4, 0x35e));
            this.label_5.AutoSize = true;
            this.label_5.Location = new Point(0x8a, 0x18);
            this.label_5.Name = "label6";
            this.label_5.Size = new Size(0x13, 13);
            this.label_5.TabIndex = 2;
            this.label_5.Text = "до";
            this.nullableDateTimePicker_1.DataBindings.Add(new Binding("Value", this.dataSetExcavation_0, "tJ_Excavation.dateBegOrder", true));
            this.nullableDateTimePicker_1.set_Format(DateTimePickerFormat.Short);
            this.nullableDateTimePicker_1.Location = new Point(30, 0x13);
            this.nullableDateTimePicker_1.Name = "dateTimePickerOrderBeg";
            this.nullableDateTimePicker_1.Size = new Size(0x66, 20);
            this.nullableDateTimePicker_1.TabIndex = 1;
            this.nullableDateTimePicker_1.set_Value(new DateTime(0x7dd, 3, 0x1c, 9, 0x26, 4, 0x35e));
            this.label_6.AutoSize = true;
            this.label_6.Location = new Point(6, 0x18);
            this.label_6.Name = "label5";
            this.label_6.Size = new Size(0x12, 13);
            this.label_6.TabIndex = 0;
            this.label_6.Text = "от";
            this.groupBox_1.Controls.Add(this.nullableDateTimePicker_2);
            this.groupBox_1.Controls.Add(this.label_7);
            this.groupBox_1.Controls.Add(this.textBox_1);
            this.groupBox_1.Controls.Add(this.label_8);
            this.groupBox_1.Location = new Point(15, 0xeb);
            this.groupBox_1.Name = "groupBoxPermission";
            this.groupBox_1.Size = new Size(0x121, 0x35);
            this.groupBox_1.TabIndex = 9;
            this.groupBox_1.TabStop = false;
            this.groupBox_1.Text = "Разрешение";
            this.nullableDateTimePicker_2.DataBindings.Add(new Binding("Value", this.dataSetExcavation_0, "tJ_Excavation.DatePermission", true));
            this.nullableDateTimePicker_2.set_Format(DateTimePickerFormat.Short);
            this.nullableDateTimePicker_2.Location = new Point(0xac, 0x13);
            this.nullableDateTimePicker_2.Name = "datetimePickerPermission";
            this.nullableDateTimePicker_2.Size = new Size(0x6b, 20);
            this.nullableDateTimePicker_2.TabIndex = 4;
            this.nullableDateTimePicker_2.set_Value(new DateTime(0x7dd, 3, 0x1c, 9, 0x26, 4, 0x35e));
            this.label_7.AutoSize = true;
            this.label_7.Location = new Point(0x8a, 0x16);
            this.label_7.Name = "label9";
            this.label_7.Size = new Size(30, 13);
            this.label_7.TabIndex = 2;
            this.label_7.Text = "дата";
            this.textBox_1.DataBindings.Add(new Binding("Text", this.dataSetExcavation_0, "tJ_Excavation.NumPermission", true));
            this.textBox_1.Location = new Point(0x2f, 0x13);
            this.textBox_1.Name = "txtNumPermission";
            this.textBox_1.Size = new Size(0x55, 20);
            this.textBox_1.TabIndex = 1;
            this.label_8.AutoSize = true;
            this.label_8.Location = new Point(6, 0x16);
            this.label_8.Name = "label8";
            this.label_8.Size = new Size(0x29, 13);
            this.label_8.TabIndex = 0;
            this.label_8.Text = "Номер";
            this.label_9.AutoSize = true;
            this.label_9.Location = new Point(12, 0x123);
            this.label_9.Name = "label10";
            this.label_9.Size = new Size(0x61, 13);
            this.label_9.TabIndex = 10;
            this.label_9.Text = "Сдано под асф-ие";
            this.nullableDateTimePicker_3.DataBindings.Add(new Binding("Value", this.dataSetExcavation_0, "tJ_Excavation.dateUnderAsphalt", true));
            this.nullableDateTimePicker_3.set_Format(DateTimePickerFormat.Short);
            this.nullableDateTimePicker_3.Location = new Point(15, 0x133);
            this.nullableDateTimePicker_3.Name = "dateTimePickerUnderAsphalt";
            this.nullableDateTimePicker_3.Size = new Size(0x84, 20);
            this.nullableDateTimePicker_3.TabIndex = 11;
            this.nullableDateTimePicker_3.set_Value(new DateTime(0x7dd, 3, 0x1c, 9, 0x26, 4, 0x35e));
            this.nullableDateTimePicker_4.DataBindings.Add(new Binding("Value", this.dataSetExcavation_0, "tJ_Excavation.dateAsphalt", true));
            this.nullableDateTimePicker_4.set_Format(DateTimePickerFormat.Short);
            this.nullableDateTimePicker_4.Location = new Point(0x9c, 0x133);
            this.nullableDateTimePicker_4.Name = "dateTimePickerAsphalt";
            this.nullableDateTimePicker_4.Size = new Size(0x8a, 20);
            this.nullableDateTimePicker_4.TabIndex = 13;
            this.nullableDateTimePicker_4.set_Value(new DateTime(0x7dd, 3, 0x1c, 9, 0x26, 4, 0x35e));
            this.label_10.AutoSize = true;
            this.label_10.Location = new Point(0x99, 0x123);
            this.label_10.Name = "label11";
            this.label_10.Size = new Size(0x7f, 13);
            this.label_10.TabIndex = 12;
            this.label_10.Text = "Дата асфальтирования";
            this.nullableDateTimePicker_5.DataBindings.Add(new Binding("Value", this.dataSetExcavation_0, "tJ_Excavation.datePay", true));
            this.nullableDateTimePicker_5.set_Format(DateTimePickerFormat.Short);
            this.nullableDateTimePicker_5.Location = new Point(0x9c, 0x15a);
            this.nullableDateTimePicker_5.Name = "dateTimePcikerPay";
            this.nullableDateTimePicker_5.Size = new Size(0x8a, 20);
            this.nullableDateTimePicker_5.TabIndex = 0x11;
            this.nullableDateTimePicker_5.set_Value(new DateTime(0x7dd, 3, 0x1c, 9, 0x26, 4, 0x35e));
            this.label_11.AutoSize = true;
            this.label_11.Location = new Point(0x99, 330);
            this.label_11.Name = "label12";
            this.label_11.Size = new Size(0x68, 13);
            this.label_11.TabIndex = 0x10;
            this.label_11.Text = "Передано к оплате";
            this.nullableDateTimePicker_6.DataBindings.Add(new Binding("Value", this.dataSetExcavation_0, "tJ_Excavation.dateEnd", true));
            this.nullableDateTimePicker_6.set_Format(DateTimePickerFormat.Short);
            this.nullableDateTimePicker_6.Location = new Point(15, 0x15a);
            this.nullableDateTimePicker_6.Name = "dateTimePickerEnd";
            this.nullableDateTimePicker_6.Size = new Size(0x84, 20);
            this.nullableDateTimePicker_6.TabIndex = 15;
            this.nullableDateTimePicker_6.set_Value(new DateTime(0x7dd, 3, 0x1c, 9, 0x26, 4, 0x35e));
            this.label_12.AutoSize = true;
            this.label_12.Location = new Point(12, 330);
            this.label_12.Name = "label13";
            this.label_12.Size = new Size(0x4c, 13);
            this.label_12.TabIndex = 14;
            this.label_12.Text = "Сдано адм-ии";
            this.kladrStreetControl_0.Location = new Point(6, 0x13);
            this.kladrStreetControl_0.Name = "kladrStreetControl1";
            this.kladrStreetControl_0.Size = new Size(0xcb, 0xad);
            this.kladrStreetControl_0.set_SqlSettings(null);
            this.kladrStreetControl_0.TabIndex = 0x12;
            this.kladrStreetControl_0.set_VisibleCmbTypeHouse(false);
            this.kladrStreetControl_0.add_ChangeStreetSelect(new EventHandler(this.kladrStreetControl_0_ChangeStreetSelect));
            this.groupBox_2.Controls.Add(this.comboBox_3);
            this.groupBox_2.Controls.Add(this.label_15);
            this.groupBox_2.Controls.Add(this.textBox_2);
            this.groupBox_2.Controls.Add(this.label_13);
            this.groupBox_2.Controls.Add(this.textBox_3);
            this.groupBox_2.Controls.Add(this.label_14);
            this.groupBox_2.Controls.Add(this.kladrStreetControl_0);
            this.groupBox_2.Location = new Point(310, 9);
            this.groupBox_2.Name = "groupBoxAddress";
            this.groupBox_2.Size = new Size(0xd4, 0x12f);
            this.groupBox_2.TabIndex = 0x13;
            this.groupBox_2.TabStop = false;
            this.groupBox_2.Text = "Адрес";
            this.comboBox_3.DataBindings.Add(new Binding("SelectedValue", this.dataSetExcavation_0, "tJ_ExcavationAddress.idRegion", true));
            this.comboBox_3.FormattingEnabled = true;
            this.comboBox_3.Location = new Point(13, 0x111);
            this.comboBox_3.Name = "cmbRegion";
            this.comboBox_3.Size = new Size(0xba, 0x15);
            this.comboBox_3.TabIndex = 0x18;
            this.label_15.AutoSize = true;
            this.label_15.Location = new Point(13, 0x101);
            this.label_15.Name = "label16";
            this.label_15.Size = new Size(0x26, 13);
            this.label_15.TabIndex = 0x17;
            this.label_15.Text = "Район";
            this.textBox_2.DataBindings.Add(new Binding("Text", this.dataSetExcavation_0, "tJ_ExcavationAddress.Comment", true));
            this.textBox_2.Location = new Point(13, 0xea);
            this.textBox_2.Name = "txtAddressComment";
            this.textBox_2.Size = new Size(0xba, 20);
            this.textBox_2.TabIndex = 0x16;
            this.label_13.AutoSize = true;
            this.label_13.Location = new Point(13, 0xda);
            this.label_13.Name = "label15";
            this.label_13.Size = new Size(70, 13);
            this.label_13.TabIndex = 0x15;
            this.label_13.Text = "Примечание";
            this.textBox_3.DataBindings.Add(new Binding("Text", this.dataSetExcavation_0, "tJ_ExcavationAddress.House", true));
            this.textBox_3.Location = new Point(13, 0xc3);
            this.textBox_3.Name = "txtAddressHouse";
            this.textBox_3.Size = new Size(0xba, 20);
            this.textBox_3.TabIndex = 20;
            this.label_14.AutoSize = true;
            this.label_14.Location = new Point(13, 0xb3);
            this.label_14.Name = "label14";
            this.label_14.Size = new Size(30, 13);
            this.label_14.TabIndex = 0x13;
            this.label_14.Text = "Дом";
            this.groupBox_3.Controls.Add(this.comboBox_4);
            this.groupBox_3.Location = new Point(310, 0x13e);
            this.groupBox_3.Name = "groupBoxKL";
            this.groupBox_3.Size = new Size(0xd4, 0x30);
            this.groupBox_3.TabIndex = 20;
            this.groupBox_3.TabStop = false;
            this.groupBox_3.Text = "Кабельная линия";
            this.comboBox_4.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_4.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox_4.FormattingEnabled = true;
            this.comboBox_4.Location = new Point(6, 0x15);
            this.comboBox_4.Name = "cmbKL";
            this.comboBox_4.Size = new Size(200, 0x15);
            this.comboBox_4.TabIndex = 0;
            this.button_0.DialogResult = DialogResult.OK;
            this.button_0.Location = new Point(15, 0x1ab);
            this.button_0.Name = "buttonOK";
            this.button_0.Size = new Size(0x4b, 0x17);
            this.button_0.TabIndex = 0x15;
            this.button_0.Text = "ОК";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_1.DialogResult = DialogResult.Cancel;
            this.button_1.Location = new Point(0x1bf, 0x1ab);
            this.button_1.Name = "buttonCancel";
            this.button_1.Size = new Size(0x4b, 0x17);
            this.button_1.TabIndex = 0x16;
            this.button_1.Text = "Отмена";
            this.button_1.UseVisualStyleBackColor = true;
            this.groupBox_4.Controls.Add(this.comboBox_5);
            this.groupBox_4.Controls.Add(this.label_16);
            this.groupBox_4.Controls.Add(this.label_17);
            this.groupBox_4.Controls.Add(this.nullableDateTimePicker_7);
            this.groupBox_4.Controls.Add(this.checkBox_0);
            this.groupBox_4.Location = new Point(3, 0x176);
            this.groupBox_4.Name = "groupBoxAgreed";
            this.groupBox_4.Size = new Size(0x207, 0x2f);
            this.groupBox_4.TabIndex = 0x18;
            this.groupBox_4.TabStop = false;
            this.groupBox_4.Text = "Согласование";
            this.comboBox_5.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_5.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox_5.DataBindings.Add(new Binding("SelectedValue", this.dataSetExcavation_0, "tJ_Excavation.workeragreed", true));
            this.comboBox_5.FormattingEnabled = true;
            this.comboBox_5.Location = new Point(0x188, 0x10);
            this.comboBox_5.Name = "cmbDispatcher";
            this.comboBox_5.Size = new Size(0x79, 0x15);
            this.comboBox_5.TabIndex = 15;
            this.label_16.AutoSize = true;
            this.label_16.Location = new Point(310, 0x13);
            this.label_16.Name = "label17";
            this.label_16.Size = new Size(0x4d, 13);
            this.label_16.TabIndex = 14;
            this.label_16.Text = "Согласующий";
            this.label_17.AutoSize = true;
            this.label_17.Location = new Point(0x8b, 20);
            this.label_17.Name = "label18";
            this.label_17.Size = new Size(0x21, 13);
            this.label_17.TabIndex = 13;
            this.label_17.Text = "Дата";
            this.nullableDateTimePicker_7.DataBindings.Add(new Binding("Value", this.dataSetExcavation_0, "tJ_Excavation.dateagreed", true));
            this.nullableDateTimePicker_7.Location = new Point(0xb2, 0x11);
            this.nullableDateTimePicker_7.Name = "dateTimePickerDateAgreed";
            this.nullableDateTimePicker_7.Size = new Size(0x7e, 20);
            this.nullableDateTimePicker_7.TabIndex = 12;
            this.nullableDateTimePicker_7.set_Value(new DateTime(0x7dc, 9, 0x1a, 9, 0x3a, 0x1c, 0x3a4));
            this.checkBox_0.DataBindings.Add(new Binding("Checked", this.dataSetExcavation_0, "tJ_Excavation.agreed", true));
            this.checkBox_0.Location = new Point(12, 0x10);
            this.checkBox_0.Name = "checkBoxAgreed";
            this.checkBox_0.Size = new Size(0x79, 0x1f);
            this.checkBox_0.TabIndex = 11;
            this.checkBox_0.Text = "Согласовано сетевым районом";
            this.checkBox_0.UseVisualStyleBackColor = true;
            this.checkBox_0.CheckedChanged += new EventHandler(this.checkBox_0_CheckedChanged);
            this.toolStrip_0.Dock = DockStyle.None;
            this.toolStrip_0.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripButton_0 };
            this.toolStrip_0.Items.AddRange(toolStripItems);
            this.toolStrip_0.Location = new Point(0x111, 0x49);
            this.toolStrip_0.Name = "toolStrip1";
            this.toolStrip_0.Size = new Size(0x1a, 0x19);
            this.toolStrip_0.TabIndex = 0x19;
            this.toolStrip_0.Text = "toolStrip1";
            this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_0.Image = Resources.partners;
            this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_0.Name = "toolBtnContractor";
            this.toolStripButton_0.Size = new Size(0x17, 0x16);
            this.toolStripButton_0.Text = "Справочник подрядчиков";
            this.toolStripButton_0.Click += new EventHandler(this.toolStripButton_0_Click);
            base.AcceptButton = this.button_0;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.CancelButton = this.button_1;
            base.ClientSize = new Size(0x213, 0x1c9);
            base.Controls.Add(this.toolStrip_0);
            base.Controls.Add(this.groupBox_4);
            base.Controls.Add(this.button_1);
            base.Controls.Add(this.button_0);
            base.Controls.Add(this.groupBox_3);
            base.Controls.Add(this.groupBox_2);
            base.Controls.Add(this.nullableDateTimePicker_5);
            base.Controls.Add(this.label_11);
            base.Controls.Add(this.nullableDateTimePicker_6);
            base.Controls.Add(this.label_12);
            base.Controls.Add(this.nullableDateTimePicker_4);
            base.Controls.Add(this.label_10);
            base.Controls.Add(this.nullableDateTimePicker_3);
            base.Controls.Add(this.label_9);
            base.Controls.Add(this.groupBox_1);
            base.Controls.Add(this.groupBox_0);
            base.Controls.Add(this.comboBox_1);
            base.Controls.Add(this.label_3);
            base.Controls.Add(this.comboBox_0);
            base.Controls.Add(this.label_2);
            base.Controls.Add(this.dateTimePicker_0);
            base.Controls.Add(this.label_1);
            base.Controls.Add(this.textBox_0);
            base.Controls.Add(this.label_0);
            base.Name = "FormExcavationAddEdit";
            this.Text = "Новая раскопка";
            base.FormClosing += new FormClosingEventHandler(this.FormExcavationAddEdit_FormClosing);
            base.Load += new EventHandler(this.FormExcavationAddEdit_Load);
            this.dataSetExcavation_0.EndInit();
            this.groupBox_0.ResumeLayout(false);
            this.groupBox_0.PerformLayout();
            this.groupBox_1.ResumeLayout(false);
            this.groupBox_1.PerformLayout();
            this.groupBox_2.ResumeLayout(false);
            this.groupBox_2.PerformLayout();
            this.groupBox_3.ResumeLayout(false);
            this.groupBox_4.ResumeLayout(false);
            this.groupBox_4.PerformLayout();
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void toolStripButton_0_Click(object sender, EventArgs e)
        {
            FormFindAddKontragentExcavation excavation1 = new FormFindAddKontragentExcavation();
            excavation1.set_SqlSettings(this.get_SqlSettings());
            if (excavation1.ShowDialog() == DialogResult.OK)
            {
                this.method_2();
            }
        }
    }
}

