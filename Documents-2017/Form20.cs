using ControlsLbr.DataGridViewExcelFilter;
using Documents.DataSets;
using FormLbr;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

internal class Form20 : FormBase
{
    private BindingSource bindingSource_0;
    private BindingSource bindingSource_1;
    private Button button_0;
    private Button button_1;
    private Button button_2;
    private Button button_3;
    private ComboBox comboBox_0;
    private ComboBox comboBox_1;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1;
    private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_0;
    private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_1;
    private DataGridViewFilterDateTimePickerColumn dataGridViewFilterDateTimePickerColumn_0;
    private DataGridViewFilterDateTimePickerColumn dataGridViewFilterDateTimePickerColumn_1;
    private DataGridViewFilterDateTimePickerColumn dataGridViewFilterDateTimePickerColumn_2;
    private DataGridViewFilterDateTimePickerColumn dataGridViewFilterDateTimePickerColumn_3;
    private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;
    private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_1;
    private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_2;
    private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_3;
    private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_4;
    private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_5;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_17;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_18;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_20;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_22;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_23;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_24;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_25;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_26;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_28;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_29;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_31;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_32;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_33;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_34;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_35;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_36;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_37;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_38;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_39;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_40;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_41;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_42;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_43;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_44;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_45;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_46;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_47;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;
    private DataSetOrder dataSetOrder_0;
    private DataSetOrder dataSetOrder_1;
    private DateTimePicker dateTimePicker_0;
    private DateTimePicker dateTimePicker_1;
    private IContainer icontainer_0;
    private Label label_0;
    private Label label_1;
    private Label label_2;
    private Label label_3;
    private Panel panel_0;
    private Panel panel_1;
    private TabControl tabControl_0;
    private TabPage tabPage_0;
    private TabPage tabPage_1;

    internal Form20()
    {
        this.method_3();
    }

    private void button_0_Click(object sender, EventArgs e)
    {
        if (this.comboBox_0.SelectedValue == null)
        {
            MessageBox.Show("Не выбран диспетчер", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        else
        {
            using (IEnumerator enumerator = this.dataGridViewExcelFilter_0.SelectedRows.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    int num = Convert.ToInt32(((DataGridViewRow) enumerator.Current).Cells[this.dataGridViewTextBoxColumn_9.Name].Value);
                    DataRow[] rowArray = this.dataSetOrder_0.tJ_Order.Select("id = " + num.ToString());
                    if (rowArray.Length != 0)
                    {
                        rowArray[0]["DateClose"] = this.dateTimePicker_0.Value;
                        rowArray[0]["closeWorker"] = this.comboBox_0.SelectedValue;
                        rowArray[0].EndEdit();
                    }
                }
            }
            base.UpdateSqlData(this.dataSetOrder_0, this.dataSetOrder_0.tJ_Order);
            this.method_1();
            MessageBox.Show("Наряды успешно закрыты");
        }
    }

    private void button_1_Click(object sender, EventArgs e)
    {
        if (this.comboBox_0.SelectedValue == null)
        {
            MessageBox.Show("Не выбран диспетчер", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        else
        {
            using (IEnumerator enumerator = ((IEnumerable) this.dataGridViewExcelFilter_0.Rows).GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    int num = Convert.ToInt32(((DataGridViewRow) enumerator.Current).Cells[this.dataGridViewTextBoxColumn_9.Name].Value);
                    DataRow[] rowArray = this.dataSetOrder_0.tJ_Order.Select("id = " + num.ToString());
                    if (rowArray.Length != 0)
                    {
                        rowArray[0]["DateClose"] = this.dateTimePicker_0.Value;
                        rowArray[0]["closeWorker"] = this.comboBox_0.SelectedValue;
                        rowArray[0].EndEdit();
                    }
                }
            }
            base.UpdateSqlData(this.dataSetOrder_0, this.dataSetOrder_0.tJ_Order);
            this.method_1();
            MessageBox.Show("Наряды успешно закрыты");
        }
    }

    private void button_2_Click(object sender, EventArgs e)
    {
        if (this.comboBox_1.SelectedValue == null)
        {
            MessageBox.Show("Не выбран диспетчер", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        else
        {
            using (IEnumerator enumerator = this.dataGridViewExcelFilter_1.SelectedRows.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    int num = Convert.ToInt32(((DataGridViewRow) enumerator.Current).Cells[this.dataGridViewTextBoxColumn_33.Name].Value);
                    DataRow[] rowArray = this.dataSetOrder_1.tJ_Order.Select("id = " + num.ToString());
                    if (rowArray.Length != 0)
                    {
                        rowArray[0]["DateClose"] = this.dateTimePicker_1.Value;
                        rowArray[0]["closeWorker"] = this.comboBox_1.SelectedValue;
                        rowArray[0].EndEdit();
                    }
                }
            }
            base.UpdateSqlData(this.dataSetOrder_1, this.dataSetOrder_1.tJ_Order);
            this.method_2();
            MessageBox.Show("Наряды успешно закрыты");
        }
    }

    private void button_3_Click(object sender, EventArgs e)
    {
        if (this.comboBox_1.SelectedValue == null)
        {
            MessageBox.Show("Не выбран диспетчер", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        else
        {
            using (IEnumerator enumerator = ((IEnumerable) this.dataGridViewExcelFilter_1.Rows).GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    int num = Convert.ToInt32(((DataGridViewRow) enumerator.Current).Cells[this.dataGridViewTextBoxColumn_33.Name].Value);
                    DataRow[] rowArray = this.dataSetOrder_1.tJ_Order.Select("id = " + num.ToString());
                    if (rowArray.Length != 0)
                    {
                        rowArray[0]["DateClose"] = this.dateTimePicker_1.Value;
                        rowArray[0]["closeWorker"] = this.comboBox_1.SelectedValue;
                        rowArray[0].EndEdit();
                    }
                }
            }
            base.UpdateSqlData(this.dataSetOrder_1, this.dataSetOrder_1.tJ_Order);
            this.method_2();
            MessageBox.Show("Наряды успешно закрыты");
        }
    }

    private void dataGridViewExcelFilter_0_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (((e.RowIndex >= 0) && (e.ColumnIndex >= 0)) && (this.dataGridViewExcelFilter_0.CurrentRow != null))
        {
            Form19 form = new Form19(Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_9.Name].Value), false);
            form.set_SqlSettings(this.get_SqlSettings());
            form.ShowDialog();
            this.method_1();
            this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewTextBoxColumn_9.Name, form.method_2().ToString(), false);
        }
    }

    private void dataGridViewExcelFilter_1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (((e.RowIndex >= 0) && (e.ColumnIndex >= 0)) && (this.dataGridViewExcelFilter_1.CurrentRow != null))
        {
            Form19 form = new Form19(Convert.ToInt32(this.dataGridViewExcelFilter_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_33.Name].Value), false);
            form.set_SqlSettings(this.get_SqlSettings());
            form.ShowDialog();
            this.method_2();
            this.dataGridViewExcelFilter_1.SearchGrid(this.dataGridViewTextBoxColumn_33.Name, form.method_2().ToString(), false);
        }
    }

    private void dataGridViewExcelFilter_1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            if (this.dataGridViewExcelFilter_1[this.dataGridViewTextBoxColumn_44.Name, e.RowIndex].Value != DBNull.Value)
            {
                e.CellStyle.BackColor = Color.LawnGreen;
            }
            if ((this.dataGridViewExcelFilter_1[this.dataGridViewTextBoxColumn_45.Name, e.RowIndex].Value != DBNull.Value) && (this.dataGridViewExcelFilter_1.Columns[e.ColumnIndex] == this.dataGridViewFilterTextBoxColumn_0))
            {
                e.CellStyle.BackColor = Color.Red;
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

    private void Form20_Load(object sender, EventArgs e)
    {
        this.dateTimePicker_0.Value = DateTime.Now;
        this.dateTimePicker_1.Value = DateTime.Now;
        this.method_0();
        this.method_1();
        this.method_2();
    }

    private void method_0()
    {
        base.SelectSqlData(this.dataSetOrder_0, this.dataSetOrder_0.vWorkerGroup, true, " where ParentKey in (';GroupWorker;Dispatchers;')  and dateend is null order by fio ");
        base.SelectSqlData(this.dataSetOrder_1, this.dataSetOrder_1.vWorkerGroup, true, " where ParentKey in (';GroupWorker;Dispatchers;')  and dateend is null order by fio ");
        this.comboBox_0.SelectedIndex = -1;
        this.comboBox_1.SelectedIndex = -1;
    }

    private void method_1()
    {
        this.Cursor = Cursors.WaitCursor;
        int num = -1;
        if (this.dataGridViewExcelFilter_0.CurrentRow != null)
        {
            num = Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_9.Name].Value);
        }
        string[] textArray1 = new string[] { " (registered <> 0 and beginRes is null and dateclose is null) and dateEnd < '", this.dateTimePicker_0.Value.ToString("yyyyMMdd HH:mm"), "' and (dateEndExt < '", this.dateTimePicker_0.Value.ToString("yyyyMMdd HH:mm"), "' or dateEndExt is null)" };
        string str = string.Concat(textArray1);
        string[] textArray2 = new string[] { " (registered <> 0 and dateclose is null) and dateEnd < '", this.dateTimePicker_0.Value.ToString("yyyyMMdd HH:mm"), "' and (dateEndExt < '", this.dateTimePicker_0.Value.ToString("yyyyMMdd HH:mm"), "' or dateEndExt is null)" };
        string str2 = string.Concat(textArray2);
        base.SelectSqlData(this.dataSetOrder_0, this.dataSetOrder_0.vJ_Order, true, " where " + str + " order by num");
        base.SelectSqlData(this.dataSetOrder_0, this.dataSetOrder_0.tJ_Order, true, " where " + str2 + " order by num");
        if (num > 0)
        {
            this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewTextBoxColumn_9.Name, num.ToString(), false);
        }
        this.Cursor = Cursors.Default;
    }

    private void method_2()
    {
        this.Cursor = Cursors.WaitCursor;
        int num = -1;
        if (this.dataGridViewExcelFilter_1.CurrentRow != null)
        {
            num = Convert.ToInt32(this.dataGridViewExcelFilter_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_33.Name].Value);
        }
        string[] textArray1 = new string[] { " (beginRes is not null and dateClose is null) and dateEnd < '", this.dateTimePicker_1.Value.ToString("yyyyMMdd HH:mm"), "' and (dateEndExt < '", this.dateTimePicker_0.Value.ToString("yyyyMMdd HH:mm"), "' or dateEndExt is null)" };
        string str = string.Concat(textArray1);
        string[] textArray2 = new string[] { " (dateclose is null) and dateEnd < '", this.dateTimePicker_1.Value.ToString("yyyyMMdd HH:mm"), "' and (dateEndExt < '", this.dateTimePicker_0.Value.ToString("yyyyMMdd HH:mm"), "' or dateEndExt is null)" };
        string str2 = string.Concat(textArray2);
        base.SelectSqlData(this.dataSetOrder_1, this.dataSetOrder_1.vJ_Order, true, " where " + str + " order by num");
        base.SelectSqlData(this.dataSetOrder_1, this.dataSetOrder_1.tJ_Order, true, " where " + str2 + " order by num");
        if (num > 0)
        {
            this.dataGridViewExcelFilter_1.SearchGrid(this.dataGridViewTextBoxColumn_33.Name, num.ToString(), false);
        }
        this.Cursor = Cursors.Default;
    }

    private void method_3()
    {
        this.icontainer_0 = new Container();
        DataGridViewCellStyle style = new DataGridViewCellStyle();
        DataGridViewCellStyle style2 = new DataGridViewCellStyle();
        DataGridViewCellStyle style3 = new DataGridViewCellStyle();
        DataGridViewCellStyle style4 = new DataGridViewCellStyle();
        DataGridViewCellStyle style5 = new DataGridViewCellStyle();
        DataGridViewCellStyle style6 = new DataGridViewCellStyle();
        DataGridViewCellStyle style7 = new DataGridViewCellStyle();
        DataGridViewCellStyle style8 = new DataGridViewCellStyle();
        DataGridViewCellStyle style9 = new DataGridViewCellStyle();
        DataGridViewCellStyle style10 = new DataGridViewCellStyle();
        DataGridViewCellStyle style11 = new DataGridViewCellStyle();
        DataGridViewCellStyle style12 = new DataGridViewCellStyle();
        ComponentResourceManager manager = new ComponentResourceManager(typeof(Form20));
        this.tabControl_0 = new TabControl();
        this.tabPage_0 = new TabPage();
        this.dataGridViewExcelFilter_0 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
        this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
        this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
        this.dataGridViewFilterTextBoxColumn_1 = new DataGridViewFilterTextBoxColumn();
        this.dataGridViewFilterDateTimePickerColumn_0 = new DataGridViewFilterDateTimePickerColumn();
        this.dataGridViewFilterDateTimePickerColumn_1 = new DataGridViewFilterDateTimePickerColumn();
        this.dataGridViewFilterTextBoxColumn_2 = new DataGridViewFilterTextBoxColumn();
        this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_12 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_13 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_14 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_15 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_16 = new DataGridViewTextBoxColumn();
        this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
        this.dataGridViewTextBoxColumn_17 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_18 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_19 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_20 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_21 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_22 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_23 = new DataGridViewTextBoxColumn();
        this.bindingSource_0 = new BindingSource(this.icontainer_0);
        this.dataSetOrder_0 = new DataSetOrder();
        this.panel_0 = new Panel();
        this.button_0 = new Button();
        this.button_1 = new Button();
        this.dateTimePicker_0 = new DateTimePicker();
        this.label_0 = new Label();
        this.comboBox_0 = new ComboBox();
        this.label_1 = new Label();
        this.tabPage_1 = new TabPage();
        this.dataGridViewExcelFilter_1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
        this.dataGridViewFilterTextBoxColumn_3 = new DataGridViewFilterTextBoxColumn();
        this.dataGridViewTextBoxColumn_24 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_25 = new DataGridViewTextBoxColumn();
        this.dataGridViewFilterTextBoxColumn_4 = new DataGridViewFilterTextBoxColumn();
        this.dataGridViewFilterDateTimePickerColumn_2 = new DataGridViewFilterDateTimePickerColumn();
        this.dataGridViewFilterDateTimePickerColumn_3 = new DataGridViewFilterDateTimePickerColumn();
        this.dataGridViewFilterTextBoxColumn_5 = new DataGridViewFilterTextBoxColumn();
        this.dataGridViewTextBoxColumn_26 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_27 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_28 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_29 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_30 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_31 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_32 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_33 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_34 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_35 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_36 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_37 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_38 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_39 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_40 = new DataGridViewTextBoxColumn();
        this.dataGridViewCheckBoxColumn_1 = new DataGridViewCheckBoxColumn();
        this.dataGridViewTextBoxColumn_41 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_42 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_43 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_44 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_45 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_46 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_47 = new DataGridViewTextBoxColumn();
        this.bindingSource_1 = new BindingSource(this.icontainer_0);
        this.dataSetOrder_1 = new DataSetOrder();
        this.panel_1 = new Panel();
        this.button_2 = new Button();
        this.button_3 = new Button();
        this.dateTimePicker_1 = new DateTimePicker();
        this.label_2 = new Label();
        this.comboBox_1 = new ComboBox();
        this.label_3 = new Label();
        this.tabControl_0.SuspendLayout();
        this.tabPage_0.SuspendLayout();
        this.dataGridViewExcelFilter_0.BeginInit();
        ((ISupportInitialize) this.bindingSource_0).BeginInit();
        this.dataSetOrder_0.BeginInit();
        this.panel_0.SuspendLayout();
        this.tabPage_1.SuspendLayout();
        this.dataGridViewExcelFilter_1.BeginInit();
        ((ISupportInitialize) this.bindingSource_1).BeginInit();
        this.dataSetOrder_1.BeginInit();
        this.panel_1.SuspendLayout();
        base.SuspendLayout();
        this.tabControl_0.Controls.Add(this.tabPage_0);
        this.tabControl_0.Controls.Add(this.tabPage_1);
        this.tabControl_0.Dock = DockStyle.Fill;
        this.tabControl_0.Location = new Point(0, 0);
        this.tabControl_0.Name = "tabControl";
        this.tabControl_0.SelectedIndex = 0;
        this.tabControl_0.Size = new Size(0x30f, 0x177);
        this.tabControl_0.TabIndex = 0;
        this.tabPage_0.Controls.Add(this.dataGridViewExcelFilter_0);
        this.tabPage_0.Controls.Add(this.panel_0);
        this.tabPage_0.Location = new Point(4, 0x16);
        this.tabPage_0.Name = "tabPageRegistered";
        this.tabPage_0.Padding = new Padding(3);
        this.tabPage_0.Size = new Size(0x307, 0x15d);
        this.tabPage_0.TabIndex = 0;
        this.tabPage_0.Text = "Зарегистрированные";
        this.tabPage_0.UseVisualStyleBackColor = true;
        this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
        this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
        this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
        style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        style.BackColor = SystemColors.Control;
        style.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        style.ForeColor = SystemColors.WindowText;
        style.SelectionBackColor = SystemColors.Highlight;
        style.SelectionForeColor = SystemColors.HighlightText;
        style.WrapMode = DataGridViewTriState.True;
        this.dataGridViewExcelFilter_0.ColumnHeadersDefaultCellStyle = style;
        this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { 
            this.dataGridViewFilterTextBoxColumn_0, this.dataGridViewTextBoxColumn_0, this.dataGridViewTextBoxColumn_1, this.dataGridViewFilterTextBoxColumn_1, this.dataGridViewFilterDateTimePickerColumn_0, this.dataGridViewFilterDateTimePickerColumn_1, this.dataGridViewFilterTextBoxColumn_2, this.dataGridViewTextBoxColumn_2, this.dataGridViewTextBoxColumn_3, this.dataGridViewTextBoxColumn_4, this.dataGridViewTextBoxColumn_5, this.dataGridViewTextBoxColumn_6, this.dataGridViewTextBoxColumn_7, this.dataGridViewTextBoxColumn_8, this.dataGridViewTextBoxColumn_9, this.dataGridViewTextBoxColumn_10,
            this.dataGridViewTextBoxColumn_11, this.dataGridViewTextBoxColumn_12, this.dataGridViewTextBoxColumn_13, this.dataGridViewTextBoxColumn_14, this.dataGridViewTextBoxColumn_15, this.dataGridViewTextBoxColumn_16, this.dataGridViewCheckBoxColumn_0, this.dataGridViewTextBoxColumn_17, this.dataGridViewTextBoxColumn_18, this.dataGridViewTextBoxColumn_19, this.dataGridViewTextBoxColumn_20, this.dataGridViewTextBoxColumn_21, this.dataGridViewTextBoxColumn_22, this.dataGridViewTextBoxColumn_23
        };
        this.dataGridViewExcelFilter_0.Columns.AddRange(dataGridViewColumns);
        this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
        this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
        this.dataGridViewExcelFilter_0.Location = new Point(3, 3);
        this.dataGridViewExcelFilter_0.Name = "dgvOrderRegistered";
        this.dataGridViewExcelFilter_0.ReadOnly = true;
        this.dataGridViewExcelFilter_0.RowHeadersWidth = 0x15;
        this.dataGridViewExcelFilter_0.RowTemplate.Height = 0x2c;
        this.dataGridViewExcelFilter_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        this.dataGridViewExcelFilter_0.Size = new Size(0x301, 0x12b);
        this.dataGridViewExcelFilter_0.TabIndex = 1;
        this.dataGridViewExcelFilter_0.CellContentDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_0_CellContentDoubleClick);
        this.dataGridViewFilterTextBoxColumn_0.DataPropertyName = "num";
        this.dataGridViewFilterTextBoxColumn_0.HeaderText = "№";
        this.dataGridViewFilterTextBoxColumn_0.Name = "numDgvColumn";
        this.dataGridViewFilterTextBoxColumn_0.ReadOnly = true;
        this.dataGridViewFilterTextBoxColumn_0.Resizable = DataGridViewTriState.True;
        this.dataGridViewFilterTextBoxColumn_0.Width = 50;
        this.dataGridViewTextBoxColumn_0.DataPropertyName = "dateOutput";
        style2.Format = "dd.MM.yyyy HH:mm:ss";
        this.dataGridViewTextBoxColumn_0.DefaultCellStyle = style2;
        this.dataGridViewTextBoxColumn_0.HeaderText = "Дата выдачи наряда";
        this.dataGridViewTextBoxColumn_0.Name = "dateOutputDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_0.ReadOnly = true;
        this.dataGridViewTextBoxColumn_0.Resizable = DataGridViewTriState.False;
        this.dataGridViewTextBoxColumn_0.Width = 0x7d;
        this.dataGridViewTextBoxColumn_1.DataPropertyName = "OutputMaker";
        style3.WrapMode = DataGridViewTriState.True;
        this.dataGridViewTextBoxColumn_1.DefaultCellStyle = style3;
        this.dataGridViewTextBoxColumn_1.HeaderText = "Наряд выдал Производитель работ";
        this.dataGridViewTextBoxColumn_1.Name = "outputMakerDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_1.ReadOnly = true;
        this.dataGridViewTextBoxColumn_1.Resizable = DataGridViewTriState.False;
        this.dataGridViewFilterTextBoxColumn_1.DataPropertyName = "srNum";
        style4.Alignment = DataGridViewContentAlignment.MiddleCenter;
        this.dataGridViewFilterTextBoxColumn_1.DefaultCellStyle = style4;
        this.dataGridViewFilterTextBoxColumn_1.HeaderText = "Сетевой район";
        this.dataGridViewFilterTextBoxColumn_1.Name = "srNumDataGridViewTextBoxColumn";
        this.dataGridViewFilterTextBoxColumn_1.ReadOnly = true;
        this.dataGridViewFilterTextBoxColumn_1.Resizable = DataGridViewTriState.False;
        this.dataGridViewFilterTextBoxColumn_1.Width = 80;
        this.dataGridViewFilterDateTimePickerColumn_0.DataPropertyName = "dateBegin";
        this.dataGridViewFilterDateTimePickerColumn_0.HeaderText = "Дата начала работ";
        this.dataGridViewFilterDateTimePickerColumn_0.Name = "dateBeginDataGridViewTextBoxColumn";
        this.dataGridViewFilterDateTimePickerColumn_0.ReadOnly = true;
        this.dataGridViewFilterDateTimePickerColumn_0.Resizable = DataGridViewTriState.True;
        this.dataGridViewFilterDateTimePickerColumn_0.SortMode = DataGridViewColumnSortMode.Programmatic;
        this.dataGridViewFilterDateTimePickerColumn_0.Width = 80;
        this.dataGridViewFilterDateTimePickerColumn_1.DataPropertyName = "dateEnd";
        this.dataGridViewFilterDateTimePickerColumn_1.HeaderText = "Дата окончания работ";
        this.dataGridViewFilterDateTimePickerColumn_1.Name = "dateEndDataGridViewTextBoxColumn";
        this.dataGridViewFilterDateTimePickerColumn_1.ReadOnly = true;
        this.dataGridViewFilterDateTimePickerColumn_1.Resizable = DataGridViewTriState.True;
        this.dataGridViewFilterDateTimePickerColumn_1.SortMode = DataGridViewColumnSortMode.Programmatic;
        this.dataGridViewFilterDateTimePickerColumn_1.Width = 80;
        this.dataGridViewFilterTextBoxColumn_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.dataGridViewFilterTextBoxColumn_2.DataPropertyName = "instruction";
        style5.WrapMode = DataGridViewTriState.True;
        this.dataGridViewFilterTextBoxColumn_2.DefaultCellStyle = style5;
        this.dataGridViewFilterTextBoxColumn_2.HeaderText = "Содержание работ";
        this.dataGridViewFilterTextBoxColumn_2.Name = "instructionDataGridViewTextBoxColumn";
        this.dataGridViewFilterTextBoxColumn_2.ReadOnly = true;
        this.dataGridViewFilterTextBoxColumn_2.Resizable = DataGridViewTriState.True;
        this.dataGridViewTextBoxColumn_2.DataPropertyName = "Resolution";
        style6.WrapMode = DataGridViewTriState.True;
        this.dataGridViewTextBoxColumn_2.DefaultCellStyle = style6;
        this.dataGridViewTextBoxColumn_2.HeaderText = "Разрешение выдал";
        this.dataGridViewTextBoxColumn_2.Name = "resolutionDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_2.ReadOnly = true;
        this.dataGridViewTextBoxColumn_2.Visible = false;
        this.dataGridViewTextBoxColumn_2.Width = 120;
        this.dataGridViewTextBoxColumn_3.DataPropertyName = "idSR";
        this.dataGridViewTextBoxColumn_3.HeaderText = "idSR";
        this.dataGridViewTextBoxColumn_3.Name = "idSRDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_3.ReadOnly = true;
        this.dataGridViewTextBoxColumn_3.Visible = false;
        this.dataGridViewTextBoxColumn_4.DataPropertyName = "srName";
        this.dataGridViewTextBoxColumn_4.HeaderText = "srName";
        this.dataGridViewTextBoxColumn_4.Name = "srNameDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_4.ReadOnly = true;
        this.dataGridViewTextBoxColumn_4.Visible = false;
        this.dataGridViewTextBoxColumn_5.DataPropertyName = "headworker";
        this.dataGridViewTextBoxColumn_5.HeaderText = "headworker";
        this.dataGridViewTextBoxColumn_5.Name = "headworkerDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_5.ReadOnly = true;
        this.dataGridViewTextBoxColumn_5.Visible = false;
        this.dataGridViewTextBoxColumn_6.DataPropertyName = "headFio";
        this.dataGridViewTextBoxColumn_6.HeaderText = "headFio";
        this.dataGridViewTextBoxColumn_6.Name = "headFioDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_6.ReadOnly = true;
        this.dataGridViewTextBoxColumn_6.Visible = false;
        this.dataGridViewTextBoxColumn_7.DataPropertyName = "acceptworker";
        this.dataGridViewTextBoxColumn_7.HeaderText = "acceptworker";
        this.dataGridViewTextBoxColumn_7.Name = "acceptworkerDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_7.ReadOnly = true;
        this.dataGridViewTextBoxColumn_7.Visible = false;
        this.dataGridViewTextBoxColumn_8.DataPropertyName = "acceptFIO";
        this.dataGridViewTextBoxColumn_8.HeaderText = "acceptFIO";
        this.dataGridViewTextBoxColumn_8.Name = "acceptFIODataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_8.ReadOnly = true;
        this.dataGridViewTextBoxColumn_8.Visible = false;
        this.dataGridViewTextBoxColumn_9.DataPropertyName = "id";
        this.dataGridViewTextBoxColumn_9.HeaderText = "id";
        this.dataGridViewTextBoxColumn_9.Name = "idDgvColumnReg";
        this.dataGridViewTextBoxColumn_9.ReadOnly = true;
        this.dataGridViewTextBoxColumn_9.Visible = false;
        this.dataGridViewTextBoxColumn_10.DataPropertyName = "watchWorker";
        this.dataGridViewTextBoxColumn_10.HeaderText = "watchWorker";
        this.dataGridViewTextBoxColumn_10.Name = "watchWorkerDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_10.ReadOnly = true;
        this.dataGridViewTextBoxColumn_10.Visible = false;
        this.dataGridViewTextBoxColumn_11.DataPropertyName = "watchFIO";
        this.dataGridViewTextBoxColumn_11.HeaderText = "watchFIO";
        this.dataGridViewTextBoxColumn_11.Name = "watchFIODataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_11.ReadOnly = true;
        this.dataGridViewTextBoxColumn_11.Visible = false;
        this.dataGridViewTextBoxColumn_12.DataPropertyName = "makerWorker";
        this.dataGridViewTextBoxColumn_12.HeaderText = "makerWorker";
        this.dataGridViewTextBoxColumn_12.Name = "makerWorkerDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_12.ReadOnly = true;
        this.dataGridViewTextBoxColumn_12.Visible = false;
        this.dataGridViewTextBoxColumn_13.DataPropertyName = "makerFIO";
        this.dataGridViewTextBoxColumn_13.HeaderText = "makerFIO";
        this.dataGridViewTextBoxColumn_13.Name = "makerFIODataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_13.ReadOnly = true;
        this.dataGridViewTextBoxColumn_13.Visible = false;
        this.dataGridViewTextBoxColumn_14.DataPropertyName = "otherInstruction";
        this.dataGridViewTextBoxColumn_14.HeaderText = "otherInstruction";
        this.dataGridViewTextBoxColumn_14.Name = "otherInstructionDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_14.ReadOnly = true;
        this.dataGridViewTextBoxColumn_14.Visible = false;
        this.dataGridViewTextBoxColumn_15.DataPropertyName = "outputWorker";
        this.dataGridViewTextBoxColumn_15.HeaderText = "outputWorker";
        this.dataGridViewTextBoxColumn_15.Name = "outputWorkerDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_15.ReadOnly = true;
        this.dataGridViewTextBoxColumn_15.Visible = false;
        this.dataGridViewTextBoxColumn_16.DataPropertyName = "outputFIO";
        this.dataGridViewTextBoxColumn_16.HeaderText = "outputFIO";
        this.dataGridViewTextBoxColumn_16.Name = "outputFIODataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_16.ReadOnly = true;
        this.dataGridViewTextBoxColumn_16.Visible = false;
        this.dataGridViewCheckBoxColumn_0.DataPropertyName = "registered";
        this.dataGridViewCheckBoxColumn_0.HeaderText = "registered";
        this.dataGridViewCheckBoxColumn_0.Name = "registeredDgvColumn";
        this.dataGridViewCheckBoxColumn_0.ReadOnly = true;
        this.dataGridViewCheckBoxColumn_0.Visible = false;
        this.dataGridViewTextBoxColumn_17.DataPropertyName = "dateClose";
        this.dataGridViewTextBoxColumn_17.HeaderText = "dateClose";
        this.dataGridViewTextBoxColumn_17.Name = "dateCloseDgvColumn";
        this.dataGridViewTextBoxColumn_17.ReadOnly = true;
        this.dataGridViewTextBoxColumn_17.Visible = false;
        this.dataGridViewTextBoxColumn_18.DataPropertyName = "closeWorker";
        this.dataGridViewTextBoxColumn_18.HeaderText = "closeWorker";
        this.dataGridViewTextBoxColumn_18.Name = "closeWorkerDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_18.ReadOnly = true;
        this.dataGridViewTextBoxColumn_18.Visible = false;
        this.dataGridViewTextBoxColumn_19.DataPropertyName = "closeFIO";
        this.dataGridViewTextBoxColumn_19.HeaderText = "closeFIO";
        this.dataGridViewTextBoxColumn_19.Name = "closeFIODataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_19.ReadOnly = true;
        this.dataGridViewTextBoxColumn_19.Visible = false;
        this.dataGridViewTextBoxColumn_20.DataPropertyName = "beginRes";
        this.dataGridViewTextBoxColumn_20.HeaderText = "beginRes";
        this.dataGridViewTextBoxColumn_20.Name = "beginResDgvColumn";
        this.dataGridViewTextBoxColumn_20.ReadOnly = true;
        this.dataGridViewTextBoxColumn_20.Visible = false;
        this.dataGridViewTextBoxColumn_21.DataPropertyName = "EndRes";
        this.dataGridViewTextBoxColumn_21.HeaderText = "EndRes";
        this.dataGridViewTextBoxColumn_21.Name = "EndResDgvColumn";
        this.dataGridViewTextBoxColumn_21.ReadOnly = true;
        this.dataGridViewTextBoxColumn_21.Visible = false;
        this.dataGridViewTextBoxColumn_22.DataPropertyName = "resWorkerId";
        this.dataGridViewTextBoxColumn_22.HeaderText = "resWorkerId";
        this.dataGridViewTextBoxColumn_22.Name = "resWorkerIdDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_22.ReadOnly = true;
        this.dataGridViewTextBoxColumn_22.Visible = false;
        this.dataGridViewTextBoxColumn_23.DataPropertyName = "resWorker";
        this.dataGridViewTextBoxColumn_23.HeaderText = "resWorker";
        this.dataGridViewTextBoxColumn_23.Name = "resWorkerDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_23.ReadOnly = true;
        this.dataGridViewTextBoxColumn_23.Visible = false;
        this.bindingSource_0.DataMember = "vJ_Order";
        this.bindingSource_0.DataSource = this.dataSetOrder_0;
        this.dataSetOrder_0.DataSetName = "DataSetOrder";
        this.dataSetOrder_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        this.panel_0.Controls.Add(this.button_0);
        this.panel_0.Controls.Add(this.button_1);
        this.panel_0.Controls.Add(this.dateTimePicker_0);
        this.panel_0.Controls.Add(this.label_0);
        this.panel_0.Controls.Add(this.comboBox_0);
        this.panel_0.Controls.Add(this.label_1);
        this.panel_0.Dock = DockStyle.Bottom;
        this.panel_0.Location = new Point(3, 0x12e);
        this.panel_0.Name = "panelRegistered";
        this.panel_0.Size = new Size(0x301, 0x2c);
        this.panel_0.TabIndex = 2;
        this.button_0.Anchor = AnchorStyles.Right | AnchorStyles.Top;
        this.button_0.Location = new Point(0x26e, 0x10);
        this.button_0.Name = "buttonCloseSelReg";
        this.button_0.Size = new Size(0x8e, 0x17);
        this.button_0.TabIndex = 5;
        this.button_0.Text = "Закрыть выделенные";
        this.button_0.UseVisualStyleBackColor = true;
        this.button_0.Click += new EventHandler(this.button_0_Click);
        this.button_1.Anchor = AnchorStyles.Right | AnchorStyles.Top;
        this.button_1.Location = new Point(0x207, 0x10);
        this.button_1.Name = "buttonCloseAllReg";
        this.button_1.Size = new Size(0x61, 0x17);
        this.button_1.TabIndex = 4;
        this.button_1.Text = "Закрыть все";
        this.button_1.UseVisualStyleBackColor = true;
        this.button_1.Click += new EventHandler(this.button_1_Click);
        this.dateTimePicker_0.CustomFormat = "dd.MM.yyyy HH:mm";
        this.dateTimePicker_0.Enabled = false;
        this.dateTimePicker_0.Format = DateTimePickerFormat.Custom;
        this.dateTimePicker_0.Location = new Point(180, 0x13);
        this.dateTimePicker_0.Name = "dateTimePickerCloseReg";
        this.dateTimePicker_0.Size = new Size(0x85, 20);
        this.dateTimePicker_0.TabIndex = 3;
        this.label_0.AutoSize = true;
        this.label_0.Location = new Point(0xb1, 3);
        this.label_0.Name = "label2";
        this.label_0.Size = new Size(0x21, 13);
        this.label_0.TabIndex = 2;
        this.label_0.Text = "Дата";
        this.comboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        this.comboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
        this.comboBox_0.DataSource = this.dataSetOrder_0;
        this.comboBox_0.DisplayMember = "vWorkerGroup.FIO";
        this.comboBox_0.FormattingEnabled = true;
        this.comboBox_0.Location = new Point(8, 0x12);
        this.comboBox_0.Name = "cmbCloseWorkerRegistered";
        this.comboBox_0.Size = new Size(0xa3, 0x15);
        this.comboBox_0.TabIndex = 1;
        this.comboBox_0.ValueMember = "vR_Worker.id";
        this.label_1.AutoSize = true;
        this.label_1.Location = new Point(5, 3);
        this.label_1.Name = "label1";
        this.label_1.Size = new Size(0x3e, 13);
        this.label_1.TabIndex = 0;
        this.label_1.Text = "Диспетчер";
        this.tabPage_1.Controls.Add(this.dataGridViewExcelFilter_1);
        this.tabPage_1.Controls.Add(this.panel_1);
        this.tabPage_1.Location = new Point(4, 0x16);
        this.tabPage_1.Name = "tabPageRes";
        this.tabPage_1.Padding = new Padding(3);
        this.tabPage_1.Size = new Size(0x307, 0x15d);
        this.tabPage_1.TabIndex = 1;
        this.tabPage_1.Text = "Действующие";
        this.tabPage_1.UseVisualStyleBackColor = true;
        this.dataGridViewExcelFilter_1.AllowUserToAddRows = false;
        this.dataGridViewExcelFilter_1.AllowUserToDeleteRows = false;
        this.dataGridViewExcelFilter_1.AutoGenerateColumns = false;
        style7.Alignment = DataGridViewContentAlignment.MiddleCenter;
        style7.BackColor = SystemColors.Control;
        style7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        style7.ForeColor = SystemColors.WindowText;
        style7.SelectionBackColor = SystemColors.Highlight;
        style7.SelectionForeColor = SystemColors.HighlightText;
        style7.WrapMode = DataGridViewTriState.True;
        this.dataGridViewExcelFilter_1.ColumnHeadersDefaultCellStyle = style7;
        this.dataGridViewExcelFilter_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DataGridViewColumn[] columnArray2 = new DataGridViewColumn[] { 
            this.dataGridViewFilterTextBoxColumn_3, this.dataGridViewTextBoxColumn_24, this.dataGridViewTextBoxColumn_25, this.dataGridViewFilterTextBoxColumn_4, this.dataGridViewFilterDateTimePickerColumn_2, this.dataGridViewFilterDateTimePickerColumn_3, this.dataGridViewFilterTextBoxColumn_5, this.dataGridViewTextBoxColumn_26, this.dataGridViewTextBoxColumn_27, this.dataGridViewTextBoxColumn_28, this.dataGridViewTextBoxColumn_29, this.dataGridViewTextBoxColumn_30, this.dataGridViewTextBoxColumn_31, this.dataGridViewTextBoxColumn_32, this.dataGridViewTextBoxColumn_33, this.dataGridViewTextBoxColumn_34,
            this.dataGridViewTextBoxColumn_35, this.dataGridViewTextBoxColumn_36, this.dataGridViewTextBoxColumn_37, this.dataGridViewTextBoxColumn_38, this.dataGridViewTextBoxColumn_39, this.dataGridViewTextBoxColumn_40, this.dataGridViewCheckBoxColumn_1, this.dataGridViewTextBoxColumn_41, this.dataGridViewTextBoxColumn_42, this.dataGridViewTextBoxColumn_43, this.dataGridViewTextBoxColumn_44, this.dataGridViewTextBoxColumn_45, this.dataGridViewTextBoxColumn_46, this.dataGridViewTextBoxColumn_47
        };
        this.dataGridViewExcelFilter_1.Columns.AddRange(columnArray2);
        this.dataGridViewExcelFilter_1.DataSource = this.bindingSource_1;
        this.dataGridViewExcelFilter_1.Dock = DockStyle.Fill;
        this.dataGridViewExcelFilter_1.Location = new Point(3, 3);
        this.dataGridViewExcelFilter_1.Name = "dgvOrder";
        this.dataGridViewExcelFilter_1.ReadOnly = true;
        this.dataGridViewExcelFilter_1.RowHeadersWidth = 0x15;
        this.dataGridViewExcelFilter_1.RowTemplate.Height = 0x2c;
        this.dataGridViewExcelFilter_1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        this.dataGridViewExcelFilter_1.Size = new Size(0x301, 0x12b);
        this.dataGridViewExcelFilter_1.TabIndex = 1;
        this.dataGridViewExcelFilter_1.CellContentDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_1_CellContentDoubleClick);
        this.dataGridViewExcelFilter_1.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridViewExcelFilter_1_CellFormatting);
        this.dataGridViewFilterTextBoxColumn_3.DataPropertyName = "num";
        this.dataGridViewFilterTextBoxColumn_3.HeaderText = "№";
        this.dataGridViewFilterTextBoxColumn_3.Name = "dataGridViewFilterTextBoxColumn1";
        this.dataGridViewFilterTextBoxColumn_3.ReadOnly = true;
        this.dataGridViewFilterTextBoxColumn_3.Resizable = DataGridViewTriState.True;
        this.dataGridViewFilterTextBoxColumn_3.Width = 50;
        this.dataGridViewTextBoxColumn_24.DataPropertyName = "dateOutput";
        style8.Format = "dd.MM.yyyy HH:mm:ss";
        this.dataGridViewTextBoxColumn_24.DefaultCellStyle = style8;
        this.dataGridViewTextBoxColumn_24.HeaderText = "Дата выдачи наряда";
        this.dataGridViewTextBoxColumn_24.Name = "dataGridViewTextBoxColumn1";
        this.dataGridViewTextBoxColumn_24.ReadOnly = true;
        this.dataGridViewTextBoxColumn_24.Resizable = DataGridViewTriState.False;
        this.dataGridViewTextBoxColumn_24.Width = 0x7d;
        this.dataGridViewTextBoxColumn_25.DataPropertyName = "OutputMaker";
        style9.WrapMode = DataGridViewTriState.True;
        this.dataGridViewTextBoxColumn_25.DefaultCellStyle = style9;
        this.dataGridViewTextBoxColumn_25.HeaderText = "Наряд выдал Производитель работ";
        this.dataGridViewTextBoxColumn_25.Name = "dataGridViewTextBoxColumn2";
        this.dataGridViewTextBoxColumn_25.ReadOnly = true;
        this.dataGridViewTextBoxColumn_25.Resizable = DataGridViewTriState.False;
        this.dataGridViewFilterTextBoxColumn_4.DataPropertyName = "srNum";
        style10.Alignment = DataGridViewContentAlignment.MiddleCenter;
        this.dataGridViewFilterTextBoxColumn_4.DefaultCellStyle = style10;
        this.dataGridViewFilterTextBoxColumn_4.HeaderText = "Сетевой район";
        this.dataGridViewFilterTextBoxColumn_4.Name = "dataGridViewFilterTextBoxColumn2";
        this.dataGridViewFilterTextBoxColumn_4.ReadOnly = true;
        this.dataGridViewFilterTextBoxColumn_4.Resizable = DataGridViewTriState.False;
        this.dataGridViewFilterTextBoxColumn_4.Width = 80;
        this.dataGridViewFilterDateTimePickerColumn_2.DataPropertyName = "dateBegin";
        this.dataGridViewFilterDateTimePickerColumn_2.HeaderText = "Дата начала работ";
        this.dataGridViewFilterDateTimePickerColumn_2.Name = "dataGridViewFilterDateTimePickerColumn1";
        this.dataGridViewFilterDateTimePickerColumn_2.ReadOnly = true;
        this.dataGridViewFilterDateTimePickerColumn_2.Resizable = DataGridViewTriState.True;
        this.dataGridViewFilterDateTimePickerColumn_2.SortMode = DataGridViewColumnSortMode.Programmatic;
        this.dataGridViewFilterDateTimePickerColumn_2.Width = 80;
        this.dataGridViewFilterDateTimePickerColumn_3.DataPropertyName = "dateEnd";
        this.dataGridViewFilterDateTimePickerColumn_3.HeaderText = "Дата окончания работ";
        this.dataGridViewFilterDateTimePickerColumn_3.Name = "dataGridViewFilterDateTimePickerColumn2";
        this.dataGridViewFilterDateTimePickerColumn_3.ReadOnly = true;
        this.dataGridViewFilterDateTimePickerColumn_3.Resizable = DataGridViewTriState.True;
        this.dataGridViewFilterDateTimePickerColumn_3.SortMode = DataGridViewColumnSortMode.Programmatic;
        this.dataGridViewFilterDateTimePickerColumn_3.Width = 80;
        this.dataGridViewFilterTextBoxColumn_5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.dataGridViewFilterTextBoxColumn_5.DataPropertyName = "instruction";
        style11.WrapMode = DataGridViewTriState.True;
        this.dataGridViewFilterTextBoxColumn_5.DefaultCellStyle = style11;
        this.dataGridViewFilterTextBoxColumn_5.HeaderText = "Содержание работ";
        this.dataGridViewFilterTextBoxColumn_5.Name = "dataGridViewFilterTextBoxColumn3";
        this.dataGridViewFilterTextBoxColumn_5.ReadOnly = true;
        this.dataGridViewFilterTextBoxColumn_5.Resizable = DataGridViewTriState.True;
        this.dataGridViewTextBoxColumn_26.DataPropertyName = "Resolution";
        style12.WrapMode = DataGridViewTriState.True;
        this.dataGridViewTextBoxColumn_26.DefaultCellStyle = style12;
        this.dataGridViewTextBoxColumn_26.HeaderText = "Разрешение выдал";
        this.dataGridViewTextBoxColumn_26.Name = "dataGridViewTextBoxColumn3";
        this.dataGridViewTextBoxColumn_26.ReadOnly = true;
        this.dataGridViewTextBoxColumn_26.Width = 120;
        this.dataGridViewTextBoxColumn_27.DataPropertyName = "idSR";
        this.dataGridViewTextBoxColumn_27.HeaderText = "idSR";
        this.dataGridViewTextBoxColumn_27.Name = "dataGridViewTextBoxColumn4";
        this.dataGridViewTextBoxColumn_27.ReadOnly = true;
        this.dataGridViewTextBoxColumn_27.Visible = false;
        this.dataGridViewTextBoxColumn_28.DataPropertyName = "srName";
        this.dataGridViewTextBoxColumn_28.HeaderText = "srName";
        this.dataGridViewTextBoxColumn_28.Name = "dataGridViewTextBoxColumn5";
        this.dataGridViewTextBoxColumn_28.ReadOnly = true;
        this.dataGridViewTextBoxColumn_28.Visible = false;
        this.dataGridViewTextBoxColumn_29.DataPropertyName = "headworker";
        this.dataGridViewTextBoxColumn_29.HeaderText = "headworker";
        this.dataGridViewTextBoxColumn_29.Name = "dataGridViewTextBoxColumn6";
        this.dataGridViewTextBoxColumn_29.ReadOnly = true;
        this.dataGridViewTextBoxColumn_29.Visible = false;
        this.dataGridViewTextBoxColumn_30.DataPropertyName = "headFio";
        this.dataGridViewTextBoxColumn_30.HeaderText = "headFio";
        this.dataGridViewTextBoxColumn_30.Name = "dataGridViewTextBoxColumn7";
        this.dataGridViewTextBoxColumn_30.ReadOnly = true;
        this.dataGridViewTextBoxColumn_30.Visible = false;
        this.dataGridViewTextBoxColumn_31.DataPropertyName = "acceptworker";
        this.dataGridViewTextBoxColumn_31.HeaderText = "acceptworker";
        this.dataGridViewTextBoxColumn_31.Name = "dataGridViewTextBoxColumn8";
        this.dataGridViewTextBoxColumn_31.ReadOnly = true;
        this.dataGridViewTextBoxColumn_31.Visible = false;
        this.dataGridViewTextBoxColumn_32.DataPropertyName = "acceptFIO";
        this.dataGridViewTextBoxColumn_32.HeaderText = "acceptFIO";
        this.dataGridViewTextBoxColumn_32.Name = "dataGridViewTextBoxColumn9";
        this.dataGridViewTextBoxColumn_32.ReadOnly = true;
        this.dataGridViewTextBoxColumn_32.Visible = false;
        this.dataGridViewTextBoxColumn_33.DataPropertyName = "id";
        this.dataGridViewTextBoxColumn_33.HeaderText = "id";
        this.dataGridViewTextBoxColumn_33.Name = "idDgvColumn";
        this.dataGridViewTextBoxColumn_33.ReadOnly = true;
        this.dataGridViewTextBoxColumn_33.Visible = false;
        this.dataGridViewTextBoxColumn_34.DataPropertyName = "watchWorker";
        this.dataGridViewTextBoxColumn_34.HeaderText = "watchWorker";
        this.dataGridViewTextBoxColumn_34.Name = "dataGridViewTextBoxColumn10";
        this.dataGridViewTextBoxColumn_34.ReadOnly = true;
        this.dataGridViewTextBoxColumn_34.Visible = false;
        this.dataGridViewTextBoxColumn_35.DataPropertyName = "watchFIO";
        this.dataGridViewTextBoxColumn_35.HeaderText = "watchFIO";
        this.dataGridViewTextBoxColumn_35.Name = "dataGridViewTextBoxColumn11";
        this.dataGridViewTextBoxColumn_35.ReadOnly = true;
        this.dataGridViewTextBoxColumn_35.Visible = false;
        this.dataGridViewTextBoxColumn_36.DataPropertyName = "makerWorker";
        this.dataGridViewTextBoxColumn_36.HeaderText = "makerWorker";
        this.dataGridViewTextBoxColumn_36.Name = "dataGridViewTextBoxColumn12";
        this.dataGridViewTextBoxColumn_36.ReadOnly = true;
        this.dataGridViewTextBoxColumn_36.Visible = false;
        this.dataGridViewTextBoxColumn_37.DataPropertyName = "makerFIO";
        this.dataGridViewTextBoxColumn_37.HeaderText = "makerFIO";
        this.dataGridViewTextBoxColumn_37.Name = "dataGridViewTextBoxColumn13";
        this.dataGridViewTextBoxColumn_37.ReadOnly = true;
        this.dataGridViewTextBoxColumn_37.Visible = false;
        this.dataGridViewTextBoxColumn_38.DataPropertyName = "otherInstruction";
        this.dataGridViewTextBoxColumn_38.HeaderText = "otherInstruction";
        this.dataGridViewTextBoxColumn_38.Name = "dataGridViewTextBoxColumn14";
        this.dataGridViewTextBoxColumn_38.ReadOnly = true;
        this.dataGridViewTextBoxColumn_38.Visible = false;
        this.dataGridViewTextBoxColumn_39.DataPropertyName = "outputWorker";
        this.dataGridViewTextBoxColumn_39.HeaderText = "outputWorker";
        this.dataGridViewTextBoxColumn_39.Name = "dataGridViewTextBoxColumn15";
        this.dataGridViewTextBoxColumn_39.ReadOnly = true;
        this.dataGridViewTextBoxColumn_39.Visible = false;
        this.dataGridViewTextBoxColumn_40.DataPropertyName = "outputFIO";
        this.dataGridViewTextBoxColumn_40.HeaderText = "outputFIO";
        this.dataGridViewTextBoxColumn_40.Name = "dataGridViewTextBoxColumn16";
        this.dataGridViewTextBoxColumn_40.ReadOnly = true;
        this.dataGridViewTextBoxColumn_40.Visible = false;
        this.dataGridViewCheckBoxColumn_1.DataPropertyName = "registered";
        this.dataGridViewCheckBoxColumn_1.HeaderText = "registered";
        this.dataGridViewCheckBoxColumn_1.Name = "registeredDgvColumnRes";
        this.dataGridViewCheckBoxColumn_1.ReadOnly = true;
        this.dataGridViewCheckBoxColumn_1.Visible = false;
        this.dataGridViewTextBoxColumn_41.DataPropertyName = "dateClose";
        this.dataGridViewTextBoxColumn_41.HeaderText = "dateClose";
        this.dataGridViewTextBoxColumn_41.Name = "dataGridViewTextBoxColumn17";
        this.dataGridViewTextBoxColumn_41.ReadOnly = true;
        this.dataGridViewTextBoxColumn_41.Visible = false;
        this.dataGridViewTextBoxColumn_42.DataPropertyName = "closeWorker";
        this.dataGridViewTextBoxColumn_42.HeaderText = "closeWorker";
        this.dataGridViewTextBoxColumn_42.Name = "dataGridViewTextBoxColumn18";
        this.dataGridViewTextBoxColumn_42.ReadOnly = true;
        this.dataGridViewTextBoxColumn_42.Visible = false;
        this.dataGridViewTextBoxColumn_43.DataPropertyName = "closeFIO";
        this.dataGridViewTextBoxColumn_43.HeaderText = "closeFIO";
        this.dataGridViewTextBoxColumn_43.Name = "dataGridViewTextBoxColumn19";
        this.dataGridViewTextBoxColumn_43.ReadOnly = true;
        this.dataGridViewTextBoxColumn_43.Visible = false;
        this.dataGridViewTextBoxColumn_44.DataPropertyName = "beginRes";
        this.dataGridViewTextBoxColumn_44.HeaderText = "beginRes";
        this.dataGridViewTextBoxColumn_44.Name = "beginResDgvColumnRes";
        this.dataGridViewTextBoxColumn_44.ReadOnly = true;
        this.dataGridViewTextBoxColumn_44.Visible = false;
        this.dataGridViewTextBoxColumn_45.DataPropertyName = "EndRes";
        this.dataGridViewTextBoxColumn_45.HeaderText = "EndRes";
        this.dataGridViewTextBoxColumn_45.Name = "endResDgvColumnRes";
        this.dataGridViewTextBoxColumn_45.ReadOnly = true;
        this.dataGridViewTextBoxColumn_45.Visible = false;
        this.dataGridViewTextBoxColumn_46.DataPropertyName = "resWorkerId";
        this.dataGridViewTextBoxColumn_46.HeaderText = "resWorkerId";
        this.dataGridViewTextBoxColumn_46.Name = "dataGridViewTextBoxColumn22";
        this.dataGridViewTextBoxColumn_46.ReadOnly = true;
        this.dataGridViewTextBoxColumn_46.Visible = false;
        this.dataGridViewTextBoxColumn_47.DataPropertyName = "resWorker";
        this.dataGridViewTextBoxColumn_47.HeaderText = "resWorker";
        this.dataGridViewTextBoxColumn_47.Name = "dataGridViewTextBoxColumn23";
        this.dataGridViewTextBoxColumn_47.ReadOnly = true;
        this.dataGridViewTextBoxColumn_47.Visible = false;
        this.bindingSource_1.DataMember = "vJ_Order";
        this.bindingSource_1.DataSource = this.dataSetOrder_1;
        this.dataSetOrder_1.DataSetName = "DataSetOrder";
        this.dataSetOrder_1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        this.panel_1.Controls.Add(this.button_2);
        this.panel_1.Controls.Add(this.button_3);
        this.panel_1.Controls.Add(this.dateTimePicker_1);
        this.panel_1.Controls.Add(this.label_2);
        this.panel_1.Controls.Add(this.comboBox_1);
        this.panel_1.Controls.Add(this.label_3);
        this.panel_1.Dock = DockStyle.Bottom;
        this.panel_1.Location = new Point(3, 0x12e);
        this.panel_1.Name = "panel1";
        this.panel_1.Size = new Size(0x301, 0x2c);
        this.panel_1.TabIndex = 3;
        this.button_2.Anchor = AnchorStyles.Right | AnchorStyles.Top;
        this.button_2.Location = new Point(0x26e, 0x10);
        this.button_2.Name = "buttonCloseSelRes";
        this.button_2.Size = new Size(0x8e, 0x17);
        this.button_2.TabIndex = 5;
        this.button_2.Text = "Закрыть выделенные";
        this.button_2.UseVisualStyleBackColor = true;
        this.button_2.Click += new EventHandler(this.button_2_Click);
        this.button_3.Anchor = AnchorStyles.Right | AnchorStyles.Top;
        this.button_3.Location = new Point(0x207, 0x10);
        this.button_3.Name = "buttonCloseAllRes";
        this.button_3.Size = new Size(0x61, 0x17);
        this.button_3.TabIndex = 4;
        this.button_3.Text = "Закрыть все";
        this.button_3.UseVisualStyleBackColor = true;
        this.button_3.Click += new EventHandler(this.button_3_Click);
        this.dateTimePicker_1.CustomFormat = "dd.MM.yyyy HH:mm";
        this.dateTimePicker_1.Enabled = false;
        this.dateTimePicker_1.Format = DateTimePickerFormat.Custom;
        this.dateTimePicker_1.Location = new Point(180, 0x13);
        this.dateTimePicker_1.Name = "dateTimePickerRes";
        this.dateTimePicker_1.Size = new Size(0x85, 20);
        this.dateTimePicker_1.TabIndex = 3;
        this.label_2.AutoSize = true;
        this.label_2.Location = new Point(0xb1, 3);
        this.label_2.Name = "label3";
        this.label_2.Size = new Size(0x21, 13);
        this.label_2.TabIndex = 2;
        this.label_2.Text = "Дата";
        this.comboBox_1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        this.comboBox_1.AutoCompleteSource = AutoCompleteSource.ListItems;
        this.comboBox_1.DataSource = this.dataSetOrder_1;
        this.comboBox_1.DisplayMember = "vWorkerGroup.FIO";
        this.comboBox_1.FormattingEnabled = true;
        this.comboBox_1.Location = new Point(8, 0x12);
        this.comboBox_1.Name = "cmbOrderRes";
        this.comboBox_1.Size = new Size(0xa3, 0x15);
        this.comboBox_1.TabIndex = 1;
        this.comboBox_1.ValueMember = "vR_Worker.id";
        this.label_3.AutoSize = true;
        this.label_3.Location = new Point(5, 3);
        this.label_3.Name = "label4";
        this.label_3.Size = new Size(0x3e, 13);
        this.label_3.TabIndex = 0;
        this.label_3.Text = "Диспетчер";
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(0x30f, 0x177);
        base.Controls.Add(this.tabControl_0);
        base.Icon = (Icon) manager.GetObject("$this.Icon");
        base.Name = "FormJournalOrderClose";
        this.Text = "Закрытие нарядов";
        base.Load += new EventHandler(this.Form20_Load);
        this.tabControl_0.ResumeLayout(false);
        this.tabPage_0.ResumeLayout(false);
        this.dataGridViewExcelFilter_0.EndInit();
        ((ISupportInitialize) this.bindingSource_0).EndInit();
        this.dataSetOrder_0.EndInit();
        this.panel_0.ResumeLayout(false);
        this.panel_0.PerformLayout();
        this.tabPage_1.ResumeLayout(false);
        this.dataGridViewExcelFilter_1.EndInit();
        ((ISupportInitialize) this.bindingSource_1).EndInit();
        this.dataSetOrder_1.EndInit();
        this.panel_1.ResumeLayout(false);
        this.panel_1.PerformLayout();
        base.ResumeLayout(false);
    }
}

