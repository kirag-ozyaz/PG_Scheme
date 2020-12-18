namespace Documents.Forms.JournalExcavation
{
    using ControlsLbr;
    using ControlsLbr.DataGridViewExcelFilter;
    using Documents.Properties;
    using FormLbr;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;

    public class FormExcavationAddEdit2 : FormBase
    {
        private BindingSource bindingSource_0;
        private BindingSource bindingSource_1;
        private Button button_0;
        private Button button_1;
        private CheckBox checkBox_0;
        private ComboBox comboBox_0;
        private ComboBox comboBox_1;
        private ComboBox comboBox_2;
        private ComboBox comboBox_3;
        private ComboBox comboBox_4;
        private DataColumn dataColumn_0;
        private DataColumn dataColumn_1;
        private DataColumn dataColumn_2;
        private DataColumn dataColumn_3;
        private DataColumn dataColumn_4;
        private DataColumn dataColumn_5;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_0;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_1;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_0;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;
        private DataSet dataSet_0;
        private DataSetExcavation dataSetExcavation_0;
        private DataTable dataTable_0;
        private DataTable dataTable_1;
        private DataTable dataTable_2;
        private DateTimePicker dateTimePicker_0;
        private Dictionary<string, string> dictionary_0;
        private GroupBox groupBox_0;
        private GroupBox groupBox_1;
        private GroupBox groupBox_2;
        private IContainer icontainer_0;
        internal int int_0;
        private Label label_0;
        private Label label_1;
        private Label label_10;
        private Label label_11;
        private Label label_12;
        private Label label_13;
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
        private TabControl tabControl_0;
        private TabPage tabPage_0;
        private TabPage tabPage_1;
        private TabPage tabPage_2;
        private TextBox textBox_0;
        private TextBox textBox_1;
        private DataSetExcavation.tJ_ExcavationStatusDataTable tJ_ExcavationStatusDataTable_0;
        private ToolStrip toolStrip_0;
        private ToolStrip toolStrip_1;
        private ToolStrip toolStrip_2;
        private ToolStripButton toolStripButton_0;
        private ToolStripButton toolStripButton_1;
        private ToolStripButton toolStripButton_2;
        private ToolStripButton toolStripButton_3;
        private ToolStripButton toolStripButton_4;
        private ToolStripButton toolStripButton_5;
        private ToolStripButton toolStripButton_6;

        public FormExcavationAddEdit2()
        {
            this.int_0 = -1;
            this.dictionary_0 = new Dictionary<string, string>();
            this.method_5();
            this.method_0();
        }

        public FormExcavationAddEdit2(int int_1)
        {
            this.int_0 = -1;
            this.dictionary_0 = new Dictionary<string, string>();
            this.method_5();
            this.int_0 = int_1;
            this.method_0();
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void checkBox_0_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_0.Checked && (this.dataSetExcavation_0.tJ_Excavation.Rows.Count > 0))
            {
                this.nullableDateTimePicker_4.set_Value(DateTime.Now.Date);
                this.dataSetExcavation_0.tJ_Excavation.Rows[0]["dateAgreed"] = DateTime.Now.Date;
            }
        }

        private void dataGridViewExcelFilter_0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((this.toolStripButton_2.Visible && this.toolStripButton_2.Enabled) && (this.toolStrip_1.Visible && this.toolStrip_1.Enabled))
            {
                this.toolStripButton_2_Click(sender, e);
            }
        }

        private void dataGridViewExcelFilter_1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((this.toolStripButton_5.Visible && this.toolStripButton_5.Enabled) && (this.toolStrip_2.Visible && this.toolStrip_2.Enabled))
            {
                this.toolStripButton_5_Click(sender, e);
            }
        }

        private void dataGridViewExcelFilter_1_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.ColumnIndex == this.dataGridViewExcelFilter_1.Columns[this.dataGridViewTextBoxColumn_8.Name].Index))
            {
                if ((this.dataGridViewExcelFilter_1[this.dataGridViewTextBoxColumn_7.Name, e.RowIndex].Value != null) && (this.dataGridViewExcelFilter_1[this.dataGridViewTextBoxColumn_7.Name, e.RowIndex].Value != DBNull.Value))
                {
                    DataRow[] rowArray = this.dataTable_2.Select("id = " + Convert.ToInt32(this.dataGridViewExcelFilter_1[this.dataGridViewTextBoxColumn_7.Name, e.RowIndex].Value));
                    if (rowArray.Length != 0)
                    {
                        e.Value = rowArray[0]["name"];
                    }
                    else
                    {
                        e.Value = this.dataGridViewExcelFilter_1[this.dataGridViewTextBoxColumn_6.Name, e.RowIndex].Value;
                    }
                }
                else
                {
                    e.Value = this.dataGridViewExcelFilter_1[this.dataGridViewTextBoxColumn_6.Name, e.RowIndex].Value;
                }
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

        private void FormExcavationAddEdit2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (base.DialogResult == DialogResult.OK)
            {
                if (this.dataSetExcavation_0.tJ_ExcavationAddress.Rows.Count <= 0)
                {
                    MessageBox.Show("Не указан адрес раскопки");
                    this.tabControl_0.SelectedTab = this.tabPage_1;
                    e.Cancel = true;
                }
                else if (this.dataSetExcavation_0.tJ_ExcavationSchmObj.Rows.Count <= 0)
                {
                    MessageBox.Show("Не указана кабельная линия");
                    this.tabControl_0.SelectedTab = this.tabPage_2;
                    e.Cancel = true;
                }
                else
                {
                    if (this.checkBox_0.Checked)
                    {
                        if ((this.nullableDateTimePicker_4.get_Value() == null) || (this.nullableDateTimePicker_4.get_Value() == DBNull.Value))
                        {
                            MessageBox.Show("Не указана дата согласования");
                            e.Cancel = true;
                            return;
                        }
                        if ((this.comboBox_3.SelectedIndex < 0) && (this.comboBox_3.Items.Count > 0))
                        {
                            MessageBox.Show("Не указан согласующий");
                            e.Cancel = true;
                            return;
                        }
                    }
                    bool flag = this.int_0 == -1;
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
                    foreach (DataRow row in this.dataSetExcavation_0.tJ_ExcavationAddress)
                    {
                        if (flag)
                        {
                            row["idExcavation"] = this.int_0;
                        }
                        row.EndEdit();
                    }
                    base.InsertSqlData(this.dataSetExcavation_0, this.dataSetExcavation_0.tJ_ExcavationAddress);
                    base.UpdateSqlData(this.dataSetExcavation_0, this.dataSetExcavation_0.tJ_ExcavationAddress);
                    base.DeleteSqlData(this.dataSetExcavation_0, this.dataSetExcavation_0.tJ_ExcavationAddress);
                    foreach (DataRow row2 in this.dataSetExcavation_0.tJ_ExcavationSchmObj)
                    {
                        if (flag)
                        {
                            row2["idExcavation"] = this.int_0;
                        }
                        row2.EndEdit();
                    }
                    base.InsertSqlData(this.dataSetExcavation_0, this.dataSetExcavation_0.tJ_ExcavationSchmObj);
                    base.UpdateSqlData(this.dataSetExcavation_0, this.dataSetExcavation_0.tJ_ExcavationSchmObj);
                    base.DeleteSqlData(this.dataSetExcavation_0, this.dataSetExcavation_0.tJ_ExcavationSchmObj);
                }
            }
        }

        private void FormExcavationAddEdit2_Load(object sender, EventArgs e)
        {
            this.method_1();
            this.method_2();
            this.method_4();
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
            }
            else
            {
                base.SelectSqlData(this.dataSetExcavation_0, this.dataSetExcavation_0.tJ_Excavation, true, "where id = " + this.int_0.ToString());
                base.SelectSqlData(this.tJ_ExcavationStatusDataTable_0, true, "where idExcavation = " + this.int_0.ToString() + " and idType = 1 order by datechange desc ", false);
                base.SelectSqlData(this.dataSetExcavation_0, this.dataSetExcavation_0.tJ_ExcavationAddress, true, " where idExcavation = " + this.int_0.ToString());
                base.SelectSqlData(this.dataSetExcavation_0, this.dataSetExcavation_0.tJ_ExcavationSchmObj, true, " where idExcavation = " + this.int_0.ToString());
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
            base.SelectSqlData(this.dataSet_0, this.dataTable_0, true, "where parentKey = ';CityRaion;UlyanovskRaion;' and isgroup = 0 and deleted = 0");
            base.SelectSqlData(this.dataSet_0, this.dataTable_1, true);
            base.SelectSqlData(this.dataSet_0, this.dataTable_2, true, "where typeCodeId in (546) and deleted = 0");
        }

        private void method_2()
        {
            DataTable table = base.SelectSqlData("tr_classifier", true, " where ParentKey = ';Excavation;TypeWork;' and isGRoup = 0 and deleted = 0 order by name");
            this.comboBox_1.DataSource = table;
            this.comboBox_1.DisplayMember = "Name";
            this.comboBox_1.ValueMember = "Id";
            this.comboBox_1.SelectedIndex = -1;
            this.method_3();
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
            table = base.SelectSqlData("tR_Classifier", true, " where ParentKey in (';NetworkAreas;', ';Other;DivisionOrder;SESNO;') and isGRoup = 0 and deleted = 0 order by name");
            this.comboBox_4.DataSource = table;
            this.comboBox_4.DisplayMember = "Name";
            this.comboBox_4.ValueMember = "id";
            this.comboBox_4.SelectedIndex = -1;
            table = new DataTable("vWorkerGroup");
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("fio", typeof(string));
            base.SelectSqlData(table, true, " where ParentKey in (';GroupWorker;ReconcileExcavation;') and dateEnd is null order by fio ", false);
            this.comboBox_3.DataSource = table;
            this.comboBox_3.DisplayMember = "fio";
            this.comboBox_3.ValueMember = "id";
            this.comboBox_3.SelectedIndex = -1;
        }

        private void method_3()
        {
            DataTable table = base.SelectSqlData("vAbnType", true, " where typeKontragent = " + 0x416.ToString() + " and deleted = 0 order by name ");
            this.comboBox_0.DataSource = table;
            this.comboBox_0.DisplayMember = "Name";
            this.comboBox_0.ValueMember = "idAbn";
        }

        private void method_4()
        {
            DataTable table = base.SelectSqlData("tJ_ExcavationStatus", true, "where idStatus = '1102' and idExcavation = '" + this.int_0.ToString() + "' order by dateChange desc");
            if (table.Rows.Count > 0)
            {
                this.nullableDateTimePicker_3.set_Value(table.Rows[0]["dateChange"]);
            }
            else
            {
                this.nullableDateTimePicker_3.set_Value(DBNull.Value);
            }
        }

        private void method_5()
        {
            this.icontainer_0 = new Container();
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
            this.nullableDateTimePicker_5 = new NullableDateTimePicker();
            this.label_12 = new Label();
            this.label_13 = new Label();
            this.comboBox_2 = new ComboBox();
            this.label_4 = new Label();
            this.nullableDateTimePicker_0 = new NullableDateTimePicker();
            this.label_5 = new Label();
            this.nullableDateTimePicker_1 = new NullableDateTimePicker();
            this.nullableDateTimePicker_3 = new NullableDateTimePicker();
            this.label_6 = new Label();
            this.groupBox_1 = new GroupBox();
            this.nullableDateTimePicker_2 = new NullableDateTimePicker();
            this.label_7 = new Label();
            this.textBox_1 = new TextBox();
            this.label_8 = new Label();
            this.button_0 = new Button();
            this.button_1 = new Button();
            this.groupBox_2 = new GroupBox();
            this.comboBox_3 = new ComboBox();
            this.label_9 = new Label();
            this.label_10 = new Label();
            this.nullableDateTimePicker_4 = new NullableDateTimePicker();
            this.checkBox_0 = new CheckBox();
            this.toolStrip_0 = new ToolStrip();
            this.toolStripButton_0 = new ToolStripButton();
            this.tabControl_0 = new TabControl();
            this.tabPage_0 = new TabPage();
            this.comboBox_4 = new ComboBox();
            this.label_11 = new Label();
            this.tabPage_1 = new TabPage();
            this.dataGridViewExcelFilter_0 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewComboBoxColumn_0 = new DataGridViewComboBoxColumn();
            this.dataSet_0 = new DataSet();
            this.dataTable_0 = new DataTable();
            this.dataColumn_0 = new DataColumn();
            this.dataColumn_1 = new DataColumn();
            this.dataTable_1 = new DataTable();
            this.dataColumn_2 = new DataColumn();
            this.dataColumn_3 = new DataColumn();
            this.dataTable_2 = new DataTable();
            this.dataColumn_4 = new DataColumn();
            this.dataColumn_5 = new DataColumn();
            this.dataGridViewComboBoxColumn_1 = new DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
            this.bindingSource_0 = new BindingSource(this.icontainer_0);
            this.toolStrip_1 = new ToolStrip();
            this.toolStripButton_1 = new ToolStripButton();
            this.toolStripButton_2 = new ToolStripButton();
            this.toolStripButton_3 = new ToolStripButton();
            this.tabPage_2 = new TabPage();
            this.dataGridViewExcelFilter_1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
            this.bindingSource_1 = new BindingSource(this.icontainer_0);
            this.toolStrip_2 = new ToolStrip();
            this.toolStripButton_4 = new ToolStripButton();
            this.toolStripButton_5 = new ToolStripButton();
            this.toolStripButton_6 = new ToolStripButton();
            this.dataSetExcavation_0.BeginInit();
            this.groupBox_0.SuspendLayout();
            this.groupBox_1.SuspendLayout();
            this.groupBox_2.SuspendLayout();
            this.toolStrip_0.SuspendLayout();
            this.tabControl_0.SuspendLayout();
            this.tabPage_0.SuspendLayout();
            this.tabPage_1.SuspendLayout();
            this.dataGridViewExcelFilter_0.BeginInit();
            this.dataSet_0.BeginInit();
            this.dataTable_0.BeginInit();
            this.dataTable_1.BeginInit();
            this.dataTable_2.BeginInit();
            ((ISupportInitialize) this.bindingSource_0).BeginInit();
            this.toolStrip_1.SuspendLayout();
            this.tabPage_2.SuspendLayout();
            this.dataGridViewExcelFilter_1.BeginInit();
            ((ISupportInitialize) this.bindingSource_1).BeginInit();
            this.toolStrip_2.SuspendLayout();
            base.SuspendLayout();
            this.dataSetExcavation_0.DataSetName = "DataSetExcavation";
            this.dataSetExcavation_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.label_0.AutoSize = true;
            this.label_0.Location = new Point(8, 3);
            this.label_0.Name = "label1";
            this.label_0.Size = new Size(0x29, 13);
            this.label_0.TabIndex = 0;
            this.label_0.Text = "Номер";
            this.textBox_0.DataBindings.Add(new Binding("Text", this.dataSetExcavation_0, "tJ_Excavation.num", true));
            this.textBox_0.Enabled = false;
            this.textBox_0.Location = new Point(9, 0x13);
            this.textBox_0.Name = "txtNum";
            this.textBox_0.Size = new Size(0x7c, 20);
            this.textBox_0.TabIndex = 1;
            this.label_1.AutoSize = true;
            this.label_1.Location = new Point(0x9c, 3);
            this.label_1.Name = "label2";
            this.label_1.Size = new Size(0x47, 13);
            this.label_1.TabIndex = 2;
            this.label_1.Text = "Дата начала";
            this.dateTimePicker_0.DataBindings.Add(new Binding("Value", this.dataSetExcavation_0, "tJ_Excavation.dateBeg", true));
            this.dateTimePicker_0.Location = new Point(0x9c, 0x10);
            this.dateTimePicker_0.Name = "dateTimePickerBeg";
            this.dateTimePicker_0.Size = new Size(0xaf, 20);
            this.dateTimePicker_0.TabIndex = 3;
            this.label_2.AutoSize = true;
            this.label_2.Location = new Point(8, 0x57);
            this.label_2.Name = "label3";
            this.label_2.Size = new Size(0x3e, 13);
            this.label_2.TabIndex = 4;
            this.label_2.Text = "Подрядчик";
            this.comboBox_0.DataBindings.Add(new Binding("SelectedValue", this.dataSetExcavation_0, "tJ_Excavation.idContractor", true));
            this.comboBox_0.FormattingEnabled = true;
            this.comboBox_0.Location = new Point(9, 0x67);
            this.comboBox_0.Name = "cmbContractor";
            this.comboBox_0.Size = new Size(0x128, 0x15);
            this.comboBox_0.TabIndex = 5;
            this.label_3.AutoSize = true;
            this.label_3.Location = new Point(8, 0x7f);
            this.label_3.Name = "label4";
            this.label_3.Size = new Size(0x3a, 13);
            this.label_3.TabIndex = 6;
            this.label_3.Text = "Вид работ";
            this.comboBox_1.DataBindings.Add(new Binding("SelectedValue", this.dataSetExcavation_0, "tJ_Excavation.TypeWork", true));
            this.comboBox_1.FormattingEnabled = true;
            this.comboBox_1.Location = new Point(9, 0x8f);
            this.comboBox_1.Name = "cmbTypeWork";
            this.comboBox_1.Size = new Size(0x128, 0x15);
            this.comboBox_1.TabIndex = 7;
            this.groupBox_0.Controls.Add(this.nullableDateTimePicker_5);
            this.groupBox_0.Controls.Add(this.label_12);
            this.groupBox_0.Controls.Add(this.label_13);
            this.groupBox_0.Controls.Add(this.comboBox_2);
            this.groupBox_0.Controls.Add(this.label_4);
            this.groupBox_0.Controls.Add(this.nullableDateTimePicker_0);
            this.groupBox_0.Controls.Add(this.label_5);
            this.groupBox_0.Controls.Add(this.nullableDateTimePicker_1);
            this.groupBox_0.Controls.Add(this.nullableDateTimePicker_3);
            this.groupBox_0.Controls.Add(this.label_6);
            this.groupBox_0.Location = new Point(9, 170);
            this.groupBox_0.Name = "groupBoxOrder";
            this.groupBox_0.Size = new Size(0x142, 0x89);
            this.groupBox_0.TabIndex = 8;
            this.groupBox_0.TabStop = false;
            this.groupBox_0.Text = "Ордер";
            this.nullableDateTimePicker_5.DataBindings.Add(new Binding("Value", this.dataSetExcavation_0, "tJ_Excavation.dateEnd", true));
            this.nullableDateTimePicker_5.set_Format(DateTimePickerFormat.Short);
            this.nullableDateTimePicker_5.Location = new Point(0x6d, 0x69);
            this.nullableDateTimePicker_5.Name = "dtpDateEnd";
            this.nullableDateTimePicker_5.Size = new Size(0x6d, 20);
            this.nullableDateTimePicker_5.TabIndex = 0x12;
            this.nullableDateTimePicker_5.set_Value(new DateTime(0x7e0, 6, 0x16, 13, 40, 0x22, 0x34e));
            this.label_12.Location = new Point(6, 0x69);
            this.label_12.Name = "label19";
            this.label_12.Size = new Size(0x61, 0x1c);
            this.label_12.TabIndex = 0x11;
            this.label_12.Text = "плановое время выполнения";
            this.label_13.AutoSize = true;
            this.label_13.Location = new Point(6, 0x55);
            this.label_13.Name = "label16";
            this.label_13.Size = new Size(0x12, 13);
            this.label_13.TabIndex = 0x10;
            this.label_13.Text = "от";
            this.comboBox_2.Enabled = false;
            this.comboBox_2.FormattingEnabled = true;
            this.comboBox_2.Location = new Point(0x48, 50);
            this.comboBox_2.Name = "cmbStatusOrder";
            this.comboBox_2.Size = new Size(0xf4, 0x15);
            this.comboBox_2.TabIndex = 5;
            this.label_4.AutoSize = true;
            this.label_4.Location = new Point(6, 0x35);
            this.label_4.Name = "label7";
            this.label_4.Size = new Size(60, 13);
            this.label_4.TabIndex = 4;
            this.label_4.Text = "состояние";
            this.nullableDateTimePicker_0.DataBindings.Add(new Binding("Value", this.dataSetExcavation_0, "tJ_Excavation.dateEndOrder", true));
            this.nullableDateTimePicker_0.set_Format(DateTimePickerFormat.Short);
            this.nullableDateTimePicker_0.Location = new Point(0xc7, 0x11);
            this.nullableDateTimePicker_0.Name = "datetimePickerOrderEnd";
            this.nullableDateTimePicker_0.Size = new Size(0x75, 20);
            this.nullableDateTimePicker_0.TabIndex = 3;
            this.nullableDateTimePicker_0.set_Value(new DateTime(0x7e0, 6, 0x16, 13, 40, 0x22, 850));
            this.label_5.AutoSize = true;
            this.label_5.Location = new Point(0xae, 0x17);
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
            this.nullableDateTimePicker_1.set_Value(new DateTime(0x7e0, 6, 0x16, 13, 40, 0x22, 0x354));
            this.nullableDateTimePicker_3.Enabled = false;
            this.nullableDateTimePicker_3.set_Format(DateTimePickerFormat.Short);
            this.nullableDateTimePicker_3.Location = new Point(0x6d, 0x4f);
            this.nullableDateTimePicker_3.Margin = new Padding(3, 5, 3, 3);
            this.nullableDateTimePicker_3.Name = "dtpSetAdm";
            this.nullableDateTimePicker_3.Size = new Size(0x6d, 20);
            this.nullableDateTimePicker_3.TabIndex = 15;
            this.nullableDateTimePicker_3.set_Value(new DateTime(0x7e0, 6, 0x16, 13, 40, 0x22, 0x355));
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
            this.groupBox_1.Location = new Point(9, 0x139);
            this.groupBox_1.Name = "groupBoxPermission";
            this.groupBox_1.Size = new Size(0x142, 0x35);
            this.groupBox_1.TabIndex = 9;
            this.groupBox_1.TabStop = false;
            this.groupBox_1.Text = "Разрешение";
            this.nullableDateTimePicker_2.DataBindings.Add(new Binding("Value", this.dataSetExcavation_0, "tJ_Excavation.DatePermission", true));
            this.nullableDateTimePicker_2.set_Format(DateTimePickerFormat.Short);
            this.nullableDateTimePicker_2.Location = new Point(0xc7, 0x13);
            this.nullableDateTimePicker_2.Name = "datetimePickerPermission";
            this.nullableDateTimePicker_2.Size = new Size(0x75, 20);
            this.nullableDateTimePicker_2.TabIndex = 4;
            this.nullableDateTimePicker_2.set_Value(new DateTime(0x7e0, 6, 0x16, 13, 40, 0x22, 0x357));
            this.label_7.AutoSize = true;
            this.label_7.Location = new Point(0xa3, 0x16);
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
            this.button_0.DialogResult = DialogResult.OK;
            this.button_0.Location = new Point(13, 0x1ec);
            this.button_0.Name = "buttonOK";
            this.button_0.Size = new Size(0x4b, 0x17);
            this.button_0.TabIndex = 0x15;
            this.button_0.Text = "ОК";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new EventHandler(this.button_1_Click);
            this.button_1.DialogResult = DialogResult.Cancel;
            this.button_1.Location = new Point(260, 0x1ec);
            this.button_1.Name = "buttonCancel";
            this.button_1.Size = new Size(0x4b, 0x17);
            this.button_1.TabIndex = 0x16;
            this.button_1.Text = "Отмена";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new EventHandler(this.button_1_Click);
            this.groupBox_2.Controls.Add(this.comboBox_3);
            this.groupBox_2.Controls.Add(this.label_9);
            this.groupBox_2.Controls.Add(this.label_10);
            this.groupBox_2.Controls.Add(this.nullableDateTimePicker_4);
            this.groupBox_2.Controls.Add(this.checkBox_0);
            this.groupBox_2.Location = new Point(9, 0x174);
            this.groupBox_2.Name = "groupBoxAgreed";
            this.groupBox_2.Size = new Size(0x142, 0x52);
            this.groupBox_2.TabIndex = 0x18;
            this.groupBox_2.TabStop = false;
            this.groupBox_2.Text = "Согласование";
            this.comboBox_3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_3.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox_3.DataBindings.Add(new Binding("SelectedValue", this.dataSetExcavation_0, "tJ_Excavation.workeragreed", true));
            this.comboBox_3.FormattingEnabled = true;
            this.comboBox_3.Location = new Point(0x93, 0x34);
            this.comboBox_3.Name = "cmbDispatcher";
            this.comboBox_3.Size = new Size(0xa9, 0x15);
            this.comboBox_3.TabIndex = 15;
            this.label_9.AutoSize = true;
            this.label_9.Location = new Point(0x90, 0x24);
            this.label_9.Name = "label17";
            this.label_9.Size = new Size(0x4d, 13);
            this.label_9.TabIndex = 14;
            this.label_9.Text = "Согласующий";
            this.label_10.AutoSize = true;
            this.label_10.Location = new Point(6, 0x24);
            this.label_10.Name = "label18";
            this.label_10.Size = new Size(0x21, 13);
            this.label_10.TabIndex = 13;
            this.label_10.Text = "Дата";
            this.nullableDateTimePicker_4.DataBindings.Add(new Binding("Value", this.dataSetExcavation_0, "tJ_Excavation.dateagreed", true));
            this.nullableDateTimePicker_4.set_Format(DateTimePickerFormat.Short);
            this.nullableDateTimePicker_4.Location = new Point(9, 0x34);
            this.nullableDateTimePicker_4.Name = "dateTimePickerDateAgreed";
            this.nullableDateTimePicker_4.Size = new Size(0x7b, 20);
            this.nullableDateTimePicker_4.TabIndex = 12;
            this.nullableDateTimePicker_4.set_Value(new DateTime(0x7e0, 6, 0x16, 13, 40, 0x22, 840));
            this.checkBox_0.AutoSize = true;
            this.checkBox_0.DataBindings.Add(new Binding("Checked", this.dataSetExcavation_0, "tJ_Excavation.agreed", true));
            this.checkBox_0.Location = new Point(12, 0x10);
            this.checkBox_0.Name = "checkBoxAgreed";
            this.checkBox_0.Size = new Size(0xbb, 0x11);
            this.checkBox_0.TabIndex = 11;
            this.checkBox_0.Text = "Согласовано сетевым районом";
            this.checkBox_0.UseVisualStyleBackColor = true;
            this.checkBox_0.CheckedChanged += new EventHandler(this.checkBox_0_CheckedChanged);
            this.toolStrip_0.Dock = DockStyle.None;
            this.toolStrip_0.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripButton_0 };
            this.toolStrip_0.Items.AddRange(toolStripItems);
            this.toolStrip_0.Location = new Point(0x134, 0x63);
            this.toolStrip_0.Name = "toolStripContractor";
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
            this.tabControl_0.Controls.Add(this.tabPage_0);
            this.tabControl_0.Controls.Add(this.tabPage_1);
            this.tabControl_0.Controls.Add(this.tabPage_2);
            this.tabControl_0.Dock = DockStyle.Top;
            this.tabControl_0.Location = new Point(0, 0);
            this.tabControl_0.Name = "tabControl";
            this.tabControl_0.SelectedIndex = 0;
            this.tabControl_0.Size = new Size(0x15b, 0x1e6);
            this.tabControl_0.TabIndex = 0x1a;
            this.tabControl_0.SelectedIndexChanged += new EventHandler(this.tabControl_0_SelectedIndexChanged);
            this.tabPage_0.Controls.Add(this.comboBox_4);
            this.tabPage_0.Controls.Add(this.label_11);
            this.tabPage_0.Controls.Add(this.label_0);
            this.tabPage_0.Controls.Add(this.toolStrip_0);
            this.tabPage_0.Controls.Add(this.textBox_0);
            this.tabPage_0.Controls.Add(this.groupBox_2);
            this.tabPage_0.Controls.Add(this.label_1);
            this.tabPage_0.Controls.Add(this.dateTimePicker_0);
            this.tabPage_0.Controls.Add(this.label_2);
            this.tabPage_0.Controls.Add(this.comboBox_0);
            this.tabPage_0.Controls.Add(this.label_3);
            this.tabPage_0.Controls.Add(this.comboBox_1);
            this.tabPage_0.Controls.Add(this.groupBox_0);
            this.tabPage_0.Controls.Add(this.groupBox_1);
            this.tabPage_0.Location = new Point(4, 0x16);
            this.tabPage_0.Name = "tabPageGeneral";
            this.tabPage_0.Padding = new Padding(3);
            this.tabPage_0.Size = new Size(0x153, 460);
            this.tabPage_0.TabIndex = 0;
            this.tabPage_0.Text = "Основные";
            this.tabPage_0.UseVisualStyleBackColor = true;
            this.comboBox_4.DataBindings.Add(new Binding("SelectedValue", this.dataSetExcavation_0, "tJ_Excavation.idSR", true));
            this.comboBox_4.FormattingEnabled = true;
            this.comboBox_4.Location = new Point(9, 0x3f);
            this.comboBox_4.Name = "cmbSR";
            this.comboBox_4.Size = new Size(0x128, 0x15);
            this.comboBox_4.TabIndex = 0x1c;
            this.label_11.AutoSize = true;
            this.label_11.Location = new Point(8, 0x2f);
            this.label_11.Name = "label14";
            this.label_11.Size = new Size(0x52, 13);
            this.label_11.TabIndex = 0x1b;
            this.label_11.Text = "Сетевой район";
            this.tabPage_1.Controls.Add(this.dataGridViewExcelFilter_0);
            this.tabPage_1.Controls.Add(this.toolStrip_1);
            this.tabPage_1.Location = new Point(4, 0x16);
            this.tabPage_1.Name = "tabPageAddress";
            this.tabPage_1.Padding = new Padding(3);
            this.tabPage_1.Size = new Size(0x153, 460);
            this.tabPage_1.TabIndex = 1;
            this.tabPage_1.Text = "Адреса";
            this.tabPage_1.UseVisualStyleBackColor = true;
            this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
            this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewComboBoxColumn_0, this.dataGridViewComboBoxColumn_1, this.dataGridViewTextBoxColumn_0, this.dataGridViewTextBoxColumn_1, this.dataGridViewTextBoxColumn_2, this.dataGridViewTextBoxColumn_3 };
            this.dataGridViewExcelFilter_0.Columns.AddRange(dataGridViewColumns);
            this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
            this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_0.Location = new Point(3, 0x1c);
            this.dataGridViewExcelFilter_0.Name = "dgvAddress";
            this.dataGridViewExcelFilter_0.ReadOnly = true;
            this.dataGridViewExcelFilter_0.RowHeadersVisible = false;
            this.dataGridViewExcelFilter_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExcelFilter_0.Size = new Size(0x14d, 0x1ad);
            this.dataGridViewExcelFilter_0.TabIndex = 2;
            this.dataGridViewExcelFilter_0.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_0_CellDoubleClick);
            this.dataGridViewComboBoxColumn_0.DataPropertyName = "idRegion";
            this.dataGridViewComboBoxColumn_0.DataSource = this.dataSet_0;
            this.dataGridViewComboBoxColumn_0.DisplayMember = "tR_Classifier.Name";
            this.dataGridViewComboBoxColumn_0.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn_0.HeaderText = "Район";
            this.dataGridViewComboBoxColumn_0.Name = "idRegionDgvColumn";
            this.dataGridViewComboBoxColumn_0.ReadOnly = true;
            this.dataGridViewComboBoxColumn_0.Resizable = DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn_0.SortMode = DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn_0.ValueMember = "tR_Classifier.id";
            this.dataSet_0.DataSetName = "NewDataSet";
            DataTable[] tables = new DataTable[] { this.dataTable_0, this.dataTable_1, this.dataTable_2 };
            this.dataSet_0.Tables.AddRange(tables);
            DataColumn[] columns = new DataColumn[] { this.dataColumn_0, this.dataColumn_1 };
            this.dataTable_0.Columns.AddRange(columns);
            this.dataTable_0.TableName = "tR_Classifier";
            this.dataColumn_0.ColumnName = "id";
            this.dataColumn_0.DataType = typeof(int);
            this.dataColumn_1.ColumnName = "Name";
            DataColumn[] columnArray3 = new DataColumn[] { this.dataColumn_2, this.dataColumn_3 };
            this.dataTable_1.Columns.AddRange(columnArray3);
            this.dataTable_1.TableName = "vR_KladrStreet";
            this.dataColumn_2.ColumnName = "id";
            this.dataColumn_2.DataType = typeof(int);
            this.dataColumn_3.ColumnName = "Name";
            DataColumn[] columnArray4 = new DataColumn[] { this.dataColumn_4, this.dataColumn_5 };
            this.dataTable_2.Columns.AddRange(columnArray4);
            this.dataTable_2.TableName = "tSchm_ObjList";
            this.dataColumn_4.ColumnName = "id";
            this.dataColumn_4.DataType = typeof(int);
            this.dataColumn_5.ColumnName = "name";
            this.dataGridViewComboBoxColumn_1.DataPropertyName = "idStreet";
            this.dataGridViewComboBoxColumn_1.DataSource = this.dataSet_0;
            this.dataGridViewComboBoxColumn_1.DisplayMember = "vR_KladrStreet.Name";
            this.dataGridViewComboBoxColumn_1.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn_1.HeaderText = "Улица";
            this.dataGridViewComboBoxColumn_1.Name = "idStreetdgvColumn";
            this.dataGridViewComboBoxColumn_1.ReadOnly = true;
            this.dataGridViewComboBoxColumn_1.Resizable = DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn_1.SortMode = DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn_1.ValueMember = "vR_KladrStreet.id";
            this.dataGridViewComboBoxColumn_1.Width = 150;
            this.dataGridViewTextBoxColumn_0.DataPropertyName = "House";
            this.dataGridViewTextBoxColumn_0.HeaderText = "Дом";
            this.dataGridViewTextBoxColumn_0.Name = "houseDgvColumn";
            this.dataGridViewTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewTextBoxColumn_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_1.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn_1.HeaderText = "Примечание";
            this.dataGridViewTextBoxColumn_1.Name = "commentdgvColumn";
            this.dataGridViewTextBoxColumn_1.ReadOnly = true;
            this.dataGridViewTextBoxColumn_2.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_2.HeaderText = "id";
            this.dataGridViewTextBoxColumn_2.Name = "idAddressDgvColumn";
            this.dataGridViewTextBoxColumn_2.ReadOnly = true;
            this.dataGridViewTextBoxColumn_2.Visible = false;
            this.dataGridViewTextBoxColumn_3.DataPropertyName = "idExcavation";
            this.dataGridViewTextBoxColumn_3.HeaderText = "idExcavation";
            this.dataGridViewTextBoxColumn_3.Name = "idExcavationDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_3.ReadOnly = true;
            this.dataGridViewTextBoxColumn_3.Visible = false;
            this.bindingSource_0.DataMember = "tJ_ExcavationAddress";
            this.bindingSource_0.DataSource = this.dataSetExcavation_0;
            this.toolStrip_1.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.toolStripButton_1, this.toolStripButton_2, this.toolStripButton_3 };
            this.toolStrip_1.Items.AddRange(itemArray2);
            this.toolStrip_1.Location = new Point(3, 3);
            this.toolStrip_1.Name = "toolStripAddress";
            this.toolStrip_1.Size = new Size(0x14d, 0x19);
            this.toolStrip_1.TabIndex = 3;
            this.toolStrip_1.Text = "Панель кнопок для адреса";
            this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_1.Image = Resources.ElementAdd;
            this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_1.Name = "tollBtnAddAddress";
            this.toolStripButton_1.Size = new Size(0x17, 0x16);
            this.toolStripButton_1.Text = "Добавить адрес";
            this.toolStripButton_1.Click += new EventHandler(this.toolStripButton_1_Click);
            this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_2.Image = Resources.ElementEdit;
            this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_2.Name = "toolBtnEditAddress";
            this.toolStripButton_2.Size = new Size(0x17, 0x16);
            this.toolStripButton_2.Text = "Редактировать адрес";
            this.toolStripButton_2.Click += new EventHandler(this.toolStripButton_2_Click);
            this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_3.Image = Resources.ElementDel;
            this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_3.Name = "toolBtnDelAddress";
            this.toolStripButton_3.Size = new Size(0x17, 0x16);
            this.toolStripButton_3.Text = "Удалить адрес";
            this.toolStripButton_3.Click += new EventHandler(this.toolStripButton_3_Click);
            this.tabPage_2.Controls.Add(this.dataGridViewExcelFilter_1);
            this.tabPage_2.Controls.Add(this.toolStrip_2);
            this.tabPage_2.Location = new Point(4, 0x16);
            this.tabPage_2.Name = "tabPageSchmObj";
            this.tabPage_2.Padding = new Padding(3);
            this.tabPage_2.Size = new Size(0x153, 460);
            this.tabPage_2.TabIndex = 2;
            this.tabPage_2.Text = "Каб.линии";
            this.tabPage_2.UseVisualStyleBackColor = true;
            this.dataGridViewExcelFilter_1.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_1.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_1.AllowUserToResizeColumns = false;
            this.dataGridViewExcelFilter_1.AllowUserToResizeRows = false;
            this.dataGridViewExcelFilter_1.AutoGenerateColumns = false;
            this.dataGridViewExcelFilter_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray5 = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_4, this.dataGridViewTextBoxColumn_5, this.dataGridViewTextBoxColumn_6, this.dataGridViewTextBoxColumn_7, this.dataGridViewTextBoxColumn_8 };
            this.dataGridViewExcelFilter_1.Columns.AddRange(columnArray5);
            this.dataGridViewExcelFilter_1.DataSource = this.bindingSource_1;
            this.dataGridViewExcelFilter_1.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_1.Location = new Point(3, 0x1c);
            this.dataGridViewExcelFilter_1.MultiSelect = false;
            this.dataGridViewExcelFilter_1.Name = "dgvKL";
            this.dataGridViewExcelFilter_1.ReadOnly = true;
            this.dataGridViewExcelFilter_1.RowHeadersVisible = false;
            this.dataGridViewExcelFilter_1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExcelFilter_1.Size = new Size(0x14d, 0x1ad);
            this.dataGridViewExcelFilter_1.TabIndex = 3;
            this.dataGridViewExcelFilter_1.VirtualMode = true;
            this.dataGridViewExcelFilter_1.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_1_CellDoubleClick);
            this.dataGridViewExcelFilter_1.CellValueNeeded += new DataGridViewCellValueEventHandler(this.dataGridViewExcelFilter_1_CellValueNeeded);
            this.dataGridViewTextBoxColumn_4.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_4.HeaderText = "id";
            this.dataGridViewTextBoxColumn_4.Name = "idLinkDgvColumn";
            this.dataGridViewTextBoxColumn_4.ReadOnly = true;
            this.dataGridViewTextBoxColumn_4.Visible = false;
            this.dataGridViewTextBoxColumn_5.DataPropertyName = "idExcavation";
            this.dataGridViewTextBoxColumn_5.HeaderText = "idExcavation";
            this.dataGridViewTextBoxColumn_5.Name = "idExcavationDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_5.ReadOnly = true;
            this.dataGridViewTextBoxColumn_5.Visible = false;
            this.dataGridViewTextBoxColumn_6.DataPropertyName = "NameKL";
            this.dataGridViewTextBoxColumn_6.HeaderText = "NameKL";
            this.dataGridViewTextBoxColumn_6.Name = "nameKLDgvColumn";
            this.dataGridViewTextBoxColumn_6.ReadOnly = true;
            this.dataGridViewTextBoxColumn_6.Visible = false;
            this.dataGridViewTextBoxColumn_7.DataPropertyName = "idKL";
            this.dataGridViewTextBoxColumn_7.HeaderText = "idKL";
            this.dataGridViewTextBoxColumn_7.Name = "idKLDgvColumn";
            this.dataGridViewTextBoxColumn_7.ReadOnly = true;
            this.dataGridViewTextBoxColumn_7.Visible = false;
            this.dataGridViewTextBoxColumn_8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_8.HeaderText = "Имя линии";
            this.dataGridViewTextBoxColumn_8.Name = "viewNameKLDgvColumn";
            this.dataGridViewTextBoxColumn_8.ReadOnly = true;
            this.bindingSource_1.DataMember = "tJ_ExcavationSchmObj";
            this.bindingSource_1.DataSource = this.dataSetExcavation_0;
            this.toolStrip_2.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] itemArray3 = new ToolStripItem[] { this.toolStripButton_4, this.toolStripButton_5, this.toolStripButton_6 };
            this.toolStrip_2.Items.AddRange(itemArray3);
            this.toolStrip_2.Location = new Point(3, 3);
            this.toolStrip_2.Name = "toolStripKL";
            this.toolStrip_2.Size = new Size(0x14d, 0x19);
            this.toolStrip_2.TabIndex = 2;
            this.toolStrip_2.Text = "Панель кнопок для адреса";
            this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_4.Image = Resources.ElementAdd;
            this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_4.Name = "toolBtnAddKL";
            this.toolStripButton_4.Size = new Size(0x17, 0x16);
            this.toolStripButton_4.Text = "Добавить кабельную линию";
            this.toolStripButton_4.Click += new EventHandler(this.toolStripButton_4_Click);
            this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_5.Image = Resources.ElementEdit;
            this.toolStripButton_5.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_5.Name = "toolBtnEditKL";
            this.toolStripButton_5.Size = new Size(0x17, 0x16);
            this.toolStripButton_5.Text = "Редактировать кабельную линию";
            this.toolStripButton_5.Click += new EventHandler(this.toolStripButton_5_Click);
            this.toolStripButton_6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_6.Image = Resources.ElementDel;
            this.toolStripButton_6.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_6.Name = "toolBtnRemoveKL";
            this.toolStripButton_6.Size = new Size(0x17, 0x16);
            this.toolStripButton_6.Text = "Удалить кабельную линию";
            this.toolStripButton_6.Click += new EventHandler(this.toolStripButton_6_Click);
            base.AcceptButton = this.button_0;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.CancelButton = this.button_1;
            base.ClientSize = new Size(0x15b, 0x20b);
            base.Controls.Add(this.tabControl_0);
            base.Controls.Add(this.button_1);
            base.Controls.Add(this.button_0);
            this.MinimumSize = new Size(0x16b, 0x231);
            base.Name = "FormExcavationAddEdit2";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Новая раскопка";
            base.FormClosing += new FormClosingEventHandler(this.FormExcavationAddEdit2_FormClosing);
            base.Load += new EventHandler(this.FormExcavationAddEdit2_Load);
            this.dataSetExcavation_0.EndInit();
            this.groupBox_0.ResumeLayout(false);
            this.groupBox_0.PerformLayout();
            this.groupBox_1.ResumeLayout(false);
            this.groupBox_1.PerformLayout();
            this.groupBox_2.ResumeLayout(false);
            this.groupBox_2.PerformLayout();
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            this.tabControl_0.ResumeLayout(false);
            this.tabPage_0.ResumeLayout(false);
            this.tabPage_0.PerformLayout();
            this.tabPage_1.ResumeLayout(false);
            this.tabPage_1.PerformLayout();
            this.dataGridViewExcelFilter_0.EndInit();
            this.dataSet_0.EndInit();
            this.dataTable_0.EndInit();
            this.dataTable_1.EndInit();
            this.dataTable_2.EndInit();
            ((ISupportInitialize) this.bindingSource_0).EndInit();
            this.toolStrip_1.ResumeLayout(false);
            this.toolStrip_1.PerformLayout();
            this.tabPage_2.ResumeLayout(false);
            this.tabPage_2.PerformLayout();
            this.dataGridViewExcelFilter_1.EndInit();
            ((ISupportInitialize) this.bindingSource_1).EndInit();
            this.toolStrip_2.ResumeLayout(false);
            this.toolStrip_2.PerformLayout();
            base.ResumeLayout(false);
        }

        private void tabControl_0_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dataGridViewTextBoxColumn_4.Visible = false;
        }

        private void toolStripButton_0_Click(object sender, EventArgs e)
        {
            FormFindAddKontragentExcavation excavation1 = new FormFindAddKontragentExcavation();
            excavation1.set_SqlSettings(this.get_SqlSettings());
            if (excavation1.ShowDialog() == DialogResult.OK)
            {
                this.method_3();
            }
        }

        private void toolStripButton_1_Click(object sender, EventArgs e)
        {
            Form46 form = new Form46(-1, this.int_0);
            form.set_SqlSettings(this.get_SqlSettings());
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (this.int_0 == -1)
                {
                    DataRow row = this.dataSetExcavation_0.tJ_ExcavationAddress.NewRow();
                    row["idExcavation"] = this.int_0;
                    if (form.method_0().HasValue)
                    {
                        row["idRegion"] = form.method_0();
                    }
                    if (form.method_2().HasValue)
                    {
                        row["idStreet"] = form.method_2();
                    }
                    if (!string.IsNullOrEmpty(form.method_4()))
                    {
                        row["house"] = form.method_4();
                    }
                    if (!string.IsNullOrEmpty(form.Comment))
                    {
                        row["comment"] = form.Comment;
                    }
                    this.dataSetExcavation_0.tJ_ExcavationAddress.Rows.Add(row);
                }
                else
                {
                    base.SelectSqlData(this.dataSetExcavation_0, this.dataSetExcavation_0.tJ_ExcavationAddress, true, " where idExcavation = " + this.int_0.ToString());
                }
            }
        }

        private void toolStripButton_2_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_0.CurrentRow != null)
            {
                int num = Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_2.Name].Value);
                Form46 form = new Form46(num, this.int_0);
                if ((this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewComboBoxColumn_0.Name].Value != null) && (this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewComboBoxColumn_0.Name].Value != DBNull.Value))
                {
                    form.method_1(new int?(Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewComboBoxColumn_0.Name].Value)));
                }
                if ((this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewComboBoxColumn_1.Name].Value != null) && (this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewComboBoxColumn_1.Name].Value != DBNull.Value))
                {
                    form.method_3(new int?(Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewComboBoxColumn_1.Name].Value)));
                }
                if ((this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_0.Name].Value != null) && (this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_0.Name].Value != DBNull.Value))
                {
                    form.method_5(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_0.Name].Value.ToString());
                }
                if ((this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_1.Name].Value != null) && (this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_1.Name].Value != DBNull.Value))
                {
                    form.Comment = this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_1.Name].Value.ToString();
                }
                form.set_SqlSettings(this.get_SqlSettings());
                if (form.ShowDialog() == DialogResult.OK)
                {
                    if (this.int_0 == -1)
                    {
                        DataRow[] rowArray = this.dataSetExcavation_0.tJ_ExcavationAddress.Select("id = " + num.ToString());
                        if (rowArray.Length != 0)
                        {
                            if (form.method_0().HasValue)
                            {
                                rowArray[0]["idRegion"] = form.method_0();
                            }
                            else
                            {
                                rowArray[0]["idRegion"] = DBNull.Value;
                            }
                            if (form.method_2().HasValue)
                            {
                                rowArray[0]["idStreet"] = form.method_2();
                            }
                            else
                            {
                                rowArray[0]["idStreet"] = DBNull.Value;
                            }
                            if (!string.IsNullOrEmpty(form.method_4()))
                            {
                                rowArray[0]["house"] = form.method_4();
                            }
                            else
                            {
                                rowArray[0]["House"] = DBNull.Value;
                            }
                            if (!string.IsNullOrEmpty(form.Comment))
                            {
                                rowArray[0]["comment"] = form.Comment;
                            }
                            else
                            {
                                rowArray[0]["comment"] = DBNull.Value;
                            }
                        }
                    }
                    else
                    {
                        base.SelectSqlData(this.dataSetExcavation_0, this.dataSetExcavation_0.tJ_ExcavationAddress, true, " where idExcavation = " + this.int_0.ToString());
                    }
                }
            }
        }

        private void toolStripButton_3_Click(object sender, EventArgs e)
        {
            if ((this.dataGridViewExcelFilter_0.CurrentRow != null) && (MessageBox.Show("Вы действительно хотите удалить текущий адрес?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                if (this.int_0 == -1)
                {
                    this.dataGridViewExcelFilter_0.Rows.Remove(this.dataGridViewExcelFilter_0.CurrentRow);
                }
                else if (base.DeleteSqlDataById(this.dataSetExcavation_0.tJ_ExcavationAddress, Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_2.Name].Value)))
                {
                    this.dataGridViewExcelFilter_0.Rows.Remove(this.dataGridViewExcelFilter_0.CurrentRow);
                }
            }
        }

        private void toolStripButton_4_Click(object sender, EventArgs e)
        {
            Form49 form = new Form49(-1, this.int_0);
            form.set_SqlSettings(this.get_SqlSettings());
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (this.int_0 == -1)
                {
                    DataRow row = this.dataSetExcavation_0.tJ_ExcavationSchmObj.NewRow();
                    row["idExcavation"] = this.int_0;
                    if (form.method_0().HasValue)
                    {
                        row["idKL"] = form.method_0();
                    }
                    if (!string.IsNullOrEmpty(form.method_2()))
                    {
                        row["nameKL"] = form.method_2();
                    }
                    this.dataSetExcavation_0.tJ_ExcavationSchmObj.Rows.Add(row);
                }
                else
                {
                    base.SelectSqlData(this.dataSetExcavation_0, this.dataSetExcavation_0.tJ_ExcavationSchmObj, true, " where idExcavation = " + this.int_0.ToString());
                }
            }
        }

        private void toolStripButton_5_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(this.dataGridViewExcelFilter_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_4.Name].Value);
            Form49 form = new Form49(num, this.int_0);
            if ((this.dataGridViewExcelFilter_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_7.Name].Value != null) && (this.dataGridViewExcelFilter_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_7.Name].Value != DBNull.Value))
            {
                form.method_1(new int?(Convert.ToInt32(this.dataGridViewExcelFilter_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_7.Name].Value)));
            }
            if ((this.dataGridViewExcelFilter_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_8.Name].Value != null) && (this.dataGridViewExcelFilter_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_8.Name].Value != DBNull.Value))
            {
                form.method_3(this.dataGridViewExcelFilter_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_8.Name].Value.ToString());
            }
            form.set_SqlSettings(this.get_SqlSettings());
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (this.int_0 == -1)
                {
                    DataRow[] rowArray = this.dataSetExcavation_0.tJ_ExcavationSchmObj.Select("id = " + num.ToString());
                    if (rowArray.Length != 0)
                    {
                        if (form.method_0().HasValue)
                        {
                            rowArray[0]["idKL"] = form.method_0();
                        }
                        else
                        {
                            rowArray[0]["idKL"] = DBNull.Value;
                        }
                        if (!string.IsNullOrEmpty(form.method_2()))
                        {
                            rowArray[0]["namekl"] = form.method_2();
                        }
                        else
                        {
                            rowArray[0]["namekl"] = DBNull.Value;
                        }
                    }
                }
                else
                {
                    base.SelectSqlData(this.dataSetExcavation_0, this.dataSetExcavation_0.tJ_ExcavationSchmObj, true, " where idExcavation = " + this.int_0.ToString());
                }
            }
        }

        private void toolStripButton_6_Click(object sender, EventArgs e)
        {
            if ((this.dataGridViewExcelFilter_1.CurrentRow != null) && (MessageBox.Show("Вы действительно хотите удалить текущую кабельную линию?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                if (this.int_0 == -1)
                {
                    this.dataGridViewExcelFilter_1.Rows.Remove(this.dataGridViewExcelFilter_1.CurrentRow);
                }
                else if (base.DeleteSqlDataById(this.dataSetExcavation_0.tJ_ExcavationSchmObj, Convert.ToInt32(this.dataGridViewExcelFilter_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_4.Name].Value)))
                {
                    this.dataGridViewExcelFilter_1.Rows.Remove(this.dataGridViewExcelFilter_1.CurrentRow);
                }
            }
        }
    }
}

