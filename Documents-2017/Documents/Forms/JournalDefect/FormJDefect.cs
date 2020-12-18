namespace Documents.Forms.JournalDefect
{
    using ControlsLbr.DataGridViewExcelFilter;
    using Documents.Properties;
    using FormLbr;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;

    public class FormJDefect : FormBase
    {
        private BindingSource bindingSource_0;
        private ComboBox comboBox_0;
        private ComboBox comboBox_1;
        private ComboBox comboBox_2;
        private DataColumn dataColumn_0;
        private DataColumn dataColumn_1;
        private DataColumn dataColumn_2;
        private DataColumn dataColumn_3;
        private DataColumn dataColumn_4;
        private DataColumn dataColumn_5;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;
        private DataSet dataSet_0;
        private DataTable dataTable_0;
        private DateTimePicker dateTimePicker_0;
        private DateTimePicker dateTimePicker_1;
        private IContainer icontainer_0;
        private Label label_0;
        private Label label_1;
        private Label label_2;
        private RadioButton radioButton_0;
        private RadioButton radioButton_1;
        private RadioButton radioButton_2;
        private SplitContainer splitContainer_0;
        private ToolStrip toolStrip_0;
        private ToolStripButton toolStripButton_0;
        private ToolStripButton toolStripButton_1;
        private ToolStripButton toolStripButton_2;
        private ToolStripButton toolStripButton_3;
        private ToolStripButton toolStripButton_4;

        public FormJDefect()
        {
            this.method_1();
            this.dateTimePicker_1.Value = this.dateTimePicker_0.Value = DateTime.Now.Date;
            for (int i = 0x7c6; i < (DateTime.Now.Year + 20); i++)
            {
                this.comboBox_1.Items.Add(i);
                this.comboBox_0.Items.Add(i);
            }
            this.comboBox_2.SelectedIndex = DateTime.Now.Month - 1;
            this.comboBox_1.SelectedItem = DateTime.Now.Year;
            this.comboBox_0.SelectedItem = DateTime.Now.Year;
        }

        private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.method_0();
        }

        private void dataGridViewExcelFilter_0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.ColumnIndex >= 0))
            {
                this.toolStripButton_1_Click(sender, e);
            }
        }

        private void dataGridViewExcelFilter_0_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridViewExcelFilter_0.AutoResizeRow(e.RowIndex);
        }

        private void dateTimePicker_0_ValueChanged(object sender, EventArgs e)
        {
            this.method_0();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormJDefect_Load(object sender, EventArgs e)
        {
            this.comboBox_2.SelectedIndexChanged += new EventHandler(this.comboBox_0_SelectedIndexChanged);
            this.comboBox_1.SelectedIndexChanged += new EventHandler(this.comboBox_0_SelectedIndexChanged);
            this.comboBox_0.SelectedIndexChanged += new EventHandler(this.comboBox_0_SelectedIndexChanged);
            this.dateTimePicker_1.ValueChanged += new EventHandler(this.dateTimePicker_0_ValueChanged);
            this.dateTimePicker_0.ValueChanged += new EventHandler(this.dateTimePicker_0_ValueChanged);
            this.method_0();
        }

        private void method_0()
        {
            string str = "";
            if (this.radioButton_2.Checked)
            {
                DateTime time = new DateTime(Convert.ToInt32(this.comboBox_1.SelectedItem), this.comboBox_2.SelectedIndex + 1, 1);
                string[] textArray1 = new string[] { " where datedefect >= '", time.ToString("yyyyMMdd"), "' and datedefect < '", time.AddMonths(1).ToString("yyyyMMdd"), "'" };
                str = string.Concat(textArray1);
            }
            else if (this.radioButton_1.Checked)
            {
                DateTime time3 = new DateTime(Convert.ToInt32(this.comboBox_0.SelectedItem), 1, 1);
                string[] textArray2 = new string[] { " where datedefect >= '", time3.ToString("yyyyMMdd"), "' and datedefect < '", time3.AddYears(1).ToString("yyyyMMdd"), "'" };
                str = string.Concat(textArray2);
            }
            else if (this.radioButton_0.Checked)
            {
                string[] textArray3 = new string[] { " where datedefect >= '", this.dateTimePicker_1.Value.ToString("yyyyMMdd"), "' and datedefect < '", this.dateTimePicker_0.Value.AddDays(1.0).ToString("yyyyMMdd"), "'" };
                str = string.Concat(textArray3);
            }
            int? nullable = null;
            if (this.dataGridViewExcelFilter_0.CurrentRow != null)
            {
                nullable = new int?(Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_0.Name].Value));
            }
            base.SelectSqlData(this.dataTable_0, true, str, false);
            if (nullable.HasValue)
            {
                this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewTextBoxColumn_0.Name, nullable.ToString(), false);
            }
        }

        private void method_1()
        {
            this.icontainer_0 = new Container();
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            DataGridViewCellStyle style3 = new DataGridViewCellStyle();
            DataGridViewCellStyle style4 = new DataGridViewCellStyle();
            this.toolStrip_0 = new ToolStrip();
            this.toolStripButton_0 = new ToolStripButton();
            this.toolStripButton_1 = new ToolStripButton();
            this.toolStripButton_2 = new ToolStripButton();
            this.toolStripButton_3 = new ToolStripButton();
            this.toolStripButton_4 = new ToolStripButton();
            this.splitContainer_0 = new SplitContainer();
            this.label_0 = new Label();
            this.dateTimePicker_0 = new DateTimePicker();
            this.label_1 = new Label();
            this.dateTimePicker_1 = new DateTimePicker();
            this.radioButton_0 = new RadioButton();
            this.comboBox_0 = new ComboBox();
            this.radioButton_1 = new RadioButton();
            this.comboBox_1 = new ComboBox();
            this.comboBox_2 = new ComboBox();
            this.radioButton_2 = new RadioButton();
            this.label_2 = new Label();
            this.dataGridViewExcelFilter_0 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.bindingSource_0 = new BindingSource(this.icontainer_0);
            this.dataSet_0 = new DataSet();
            this.dataTable_0 = new DataTable();
            this.dataColumn_0 = new DataColumn();
            this.dataColumn_1 = new DataColumn();
            this.dataColumn_2 = new DataColumn();
            this.dataColumn_3 = new DataColumn();
            this.dataColumn_4 = new DataColumn();
            this.dataColumn_5 = new DataColumn();
            this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
            this.toolStrip_0.SuspendLayout();
            this.splitContainer_0.Panel1.SuspendLayout();
            this.splitContainer_0.Panel2.SuspendLayout();
            this.splitContainer_0.SuspendLayout();
            this.dataGridViewExcelFilter_0.BeginInit();
            ((ISupportInitialize) this.bindingSource_0).BeginInit();
            this.dataSet_0.BeginInit();
            this.dataTable_0.BeginInit();
            base.SuspendLayout();
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripButton_0, this.toolStripButton_1, this.toolStripButton_2, this.toolStripButton_3, this.toolStripButton_4 };
            this.toolStrip_0.Items.AddRange(toolStripItems);
            this.toolStrip_0.Location = new Point(0, 0);
            this.toolStrip_0.Name = "toolStripMain";
            this.toolStrip_0.Size = new Size(0x375, 0x19);
            this.toolStrip_0.TabIndex = 0;
            this.toolStrip_0.Text = "toolStrip1";
            this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_0.Image = Resources.ElementAdd;
            this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_0.Name = "toolBtnAdd";
            this.toolStripButton_0.Size = new Size(0x17, 0x16);
            this.toolStripButton_0.Text = "Добавить";
            this.toolStripButton_0.Click += new EventHandler(this.toolStripButton_0_Click);
            this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_1.Image = Resources.ElementEdit;
            this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_1.Name = "toolBtnEdit";
            this.toolStripButton_1.Size = new Size(0x17, 0x16);
            this.toolStripButton_1.Text = "Редактировать";
            this.toolStripButton_1.Click += new EventHandler(this.toolStripButton_1_Click);
            this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_2.Image = Resources.ElementDel;
            this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_2.Name = "toolBtnRemove";
            this.toolStripButton_2.Size = new Size(0x17, 0x16);
            this.toolStripButton_2.Text = "Удалить";
            this.toolStripButton_2.Click += new EventHandler(this.toolStripButton_2_Click);
            this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_3.Image = Resources.refresh_16;
            this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_3.Name = "toolBtnRefresh";
            this.toolStripButton_3.Size = new Size(0x17, 0x16);
            this.toolStripButton_3.Text = "Обновить";
            this.toolStripButton_3.Click += new EventHandler(this.toolStripButton_3_Click);
            this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_4.Image = Resources.report;
            this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_4.Name = "toolBtnReport";
            this.toolStripButton_4.Size = new Size(0x17, 0x16);
            this.toolStripButton_4.Text = "Отчет";
            this.toolStripButton_4.Click += new EventHandler(this.toolStripButton_4_Click);
            this.splitContainer_0.Dock = DockStyle.Fill;
            this.splitContainer_0.Location = new Point(0, 0x19);
            this.splitContainer_0.Name = "splitContainer1";
            this.splitContainer_0.Panel1.Controls.Add(this.label_0);
            this.splitContainer_0.Panel1.Controls.Add(this.dateTimePicker_0);
            this.splitContainer_0.Panel1.Controls.Add(this.label_1);
            this.splitContainer_0.Panel1.Controls.Add(this.dateTimePicker_1);
            this.splitContainer_0.Panel1.Controls.Add(this.radioButton_0);
            this.splitContainer_0.Panel1.Controls.Add(this.comboBox_0);
            this.splitContainer_0.Panel1.Controls.Add(this.radioButton_1);
            this.splitContainer_0.Panel1.Controls.Add(this.comboBox_1);
            this.splitContainer_0.Panel1.Controls.Add(this.comboBox_2);
            this.splitContainer_0.Panel1.Controls.Add(this.radioButton_2);
            this.splitContainer_0.Panel1.Controls.Add(this.label_2);
            this.splitContainer_0.Panel2.Controls.Add(this.dataGridViewExcelFilter_0);
            this.splitContainer_0.Size = new Size(0x375, 0x170);
            this.splitContainer_0.SplitterDistance = 0xc7;
            this.splitContainer_0.TabIndex = 1;
            this.label_0.AutoSize = true;
            this.label_0.Location = new Point(12, 0xb0);
            this.label_0.Name = "label3";
            this.label_0.Size = new Size(0x13, 13);
            this.label_0.TabIndex = 10;
            this.label_0.Text = "до";
            this.dateTimePicker_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.dateTimePicker_0.Enabled = false;
            this.dateTimePicker_0.Location = new Point(0x23, 0xae);
            this.dateTimePicker_0.Name = "dateTimePickerEnd";
            this.dateTimePicker_0.Size = new Size(0x9c, 20);
            this.dateTimePicker_0.TabIndex = 9;
            this.label_1.AutoSize = true;
            this.label_1.Location = new Point(12, 0x98);
            this.label_1.Name = "label2";
            this.label_1.Size = new Size(0x12, 13);
            this.label_1.TabIndex = 8;
            this.label_1.Text = "от";
            this.dateTimePicker_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.dateTimePicker_1.Enabled = false;
            this.dateTimePicker_1.Location = new Point(0x23, 0x94);
            this.dateTimePicker_1.Name = "dateTimePickerBeg";
            this.dateTimePicker_1.Size = new Size(0x9c, 20);
            this.dateTimePicker_1.TabIndex = 7;
            this.radioButton_0.AutoSize = true;
            this.radioButton_0.Location = new Point(12, 0x7d);
            this.radioButton_0.Name = "radioButtonPeriod";
            this.radioButton_0.Size = new Size(0x3f, 0x11);
            this.radioButton_0.TabIndex = 6;
            this.radioButton_0.Text = "Период";
            this.radioButton_0.UseVisualStyleBackColor = true;
            this.radioButton_0.CheckedChanged += new EventHandler(this.radioButton_0_CheckedChanged);
            this.comboBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.comboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox_0.Enabled = false;
            this.comboBox_0.FormattingEnabled = true;
            this.comboBox_0.Location = new Point(12, 0x62);
            this.comboBox_0.Name = "cmbYear";
            this.comboBox_0.Size = new Size(0xb3, 0x15);
            this.comboBox_0.TabIndex = 5;
            this.radioButton_1.AutoSize = true;
            this.radioButton_1.Location = new Point(12, 0x4b);
            this.radioButton_1.Name = "radioButtonYear";
            this.radioButton_1.Size = new Size(0x2b, 0x11);
            this.radioButton_1.TabIndex = 4;
            this.radioButton_1.Text = "Год";
            this.radioButton_1.UseVisualStyleBackColor = true;
            this.radioButton_1.CheckedChanged += new EventHandler(this.radioButton_1_CheckedChanged);
            this.comboBox_1.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.comboBox_1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_1.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox_1.FormattingEnabled = true;
            this.comboBox_1.Location = new Point(0x7d, 0x30);
            this.comboBox_1.Name = "cmbMonthYear";
            this.comboBox_1.Size = new Size(0x42, 0x15);
            this.comboBox_1.TabIndex = 3;
            this.comboBox_2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.comboBox_2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_2.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox_2.FormattingEnabled = true;
            object[] items = new object[] { "январь", "февраль", "март", "апрель", "май", "июнь", "июль", "август", "сентябрь", "октябрь", "ноябрь", "декабрь" };
            this.comboBox_2.Items.AddRange(items);
            this.comboBox_2.Location = new Point(12, 0x30);
            this.comboBox_2.Name = "cmbMonth";
            this.comboBox_2.Size = new Size(0x70, 0x15);
            this.comboBox_2.TabIndex = 2;
            this.radioButton_2.AutoSize = true;
            this.radioButton_2.Checked = true;
            this.radioButton_2.Location = new Point(12, 0x19);
            this.radioButton_2.Name = "radioButtonMonth";
            this.radioButton_2.Size = new Size(0x3a, 0x11);
            this.radioButton_2.TabIndex = 1;
            this.radioButton_2.TabStop = true;
            this.radioButton_2.Text = "Месяц";
            this.radioButton_2.UseVisualStyleBackColor = true;
            this.radioButton_2.CheckedChanged += new EventHandler(this.radioButton_2_CheckedChanged);
            this.label_2.AutoSize = true;
            this.label_2.Location = new Point(12, 9);
            this.label_2.Name = "label1";
            this.label_2.Size = new Size(0x2f, 13);
            this.label_2.TabIndex = 0;
            this.label_2.Text = "Фильтр";
            this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToOrderColumns = true;
            this.dataGridViewExcelFilter_0.set_AllowUserToVisibleColumns(false);
            this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
            this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_0, this.dataGridViewTextBoxColumn_1, this.dataGridViewTextBoxColumn_2, this.dataGridViewTextBoxColumn_3, this.dataGridViewTextBoxColumn_4, this.dataGridViewTextBoxColumn_5 };
            this.dataGridViewExcelFilter_0.Columns.AddRange(dataGridViewColumns);
            this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
            this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_0.Location = new Point(0, 0);
            this.dataGridViewExcelFilter_0.Name = "dgv";
            this.dataGridViewExcelFilter_0.ReadOnly = true;
            this.dataGridViewExcelFilter_0.Size = new Size(0x2aa, 0x170);
            this.dataGridViewExcelFilter_0.TabIndex = 0;
            this.dataGridViewExcelFilter_0.VirtualMode = true;
            this.dataGridViewExcelFilter_0.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_0_CellDoubleClick);
            this.dataGridViewExcelFilter_0.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dataGridViewExcelFilter_0_RowPostPaint);
            this.bindingSource_0.DataMember = "tJ_Defect";
            this.bindingSource_0.DataSource = this.dataSet_0;
            this.dataSet_0.DataSetName = "NewDataSet";
            DataTable[] tables = new DataTable[] { this.dataTable_0 };
            this.dataSet_0.Tables.AddRange(tables);
            DataColumn[] columns = new DataColumn[] { this.dataColumn_0, this.dataColumn_1, this.dataColumn_2, this.dataColumn_3, this.dataColumn_4, this.dataColumn_5 };
            this.dataTable_0.Columns.AddRange(columns);
            Constraint[] constraints = new Constraint[1];
            string[] columnNames = new string[] { "id" };
            constraints[0] = new UniqueConstraint("Constraint1", columnNames, true);
            this.dataTable_0.Constraints.AddRange(constraints);
            this.dataTable_0.PrimaryKey = new DataColumn[] { this.dataColumn_0 };
            this.dataTable_0.TableName = "tJ_Defect";
            this.dataColumn_0.AllowDBNull = false;
            this.dataColumn_0.AutoIncrement = true;
            this.dataColumn_0.AutoIncrementStep = -1L;
            this.dataColumn_0.ColumnName = "id";
            this.dataColumn_0.DataType = typeof(int);
            this.dataColumn_1.ColumnName = "num";
            this.dataColumn_1.DataType = typeof(int);
            this.dataColumn_2.ColumnName = "nameDefect";
            this.dataColumn_3.ColumnName = "dateDefect";
            this.dataColumn_3.DataType = typeof(DateTime);
            this.dataColumn_4.ColumnName = "Direct";
            this.dataColumn_5.ColumnName = "Mark";
            this.dataGridViewTextBoxColumn_0.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_0.HeaderText = "id";
            this.dataGridViewTextBoxColumn_0.Name = "idDgvColumn";
            this.dataGridViewTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewTextBoxColumn_0.Visible = false;
            this.dataGridViewTextBoxColumn_1.DataPropertyName = "num";
            this.dataGridViewTextBoxColumn_1.HeaderText = "num";
            this.dataGridViewTextBoxColumn_1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_1.ReadOnly = true;
            this.dataGridViewTextBoxColumn_1.Visible = false;
            this.dataGridViewTextBoxColumn_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_2.DataPropertyName = "nameDefect";
            style.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_2.DefaultCellStyle = style;
            this.dataGridViewTextBoxColumn_2.FillWeight = 50.08942f;
            this.dataGridViewTextBoxColumn_2.HeaderText = "Наименование дефекта";
            this.dataGridViewTextBoxColumn_2.Name = "nameDefectDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_2.ReadOnly = true;
            this.dataGridViewTextBoxColumn_3.DataPropertyName = "dateDefect";
            style2.Format = "d";
            style2.NullValue = null;
            this.dataGridViewTextBoxColumn_3.DefaultCellStyle = style2;
            this.dataGridViewTextBoxColumn_3.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn_3.Name = "dateDefectDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_3.ReadOnly = true;
            this.dataGridViewTextBoxColumn_3.Width = 80;
            this.dataGridViewTextBoxColumn_4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_4.DataPropertyName = "Direct";
            style3.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_4.DefaultCellStyle = style3;
            this.dataGridViewTextBoxColumn_4.FillWeight = 29.8748f;
            this.dataGridViewTextBoxColumn_4.HeaderText = "Указания рук-ля";
            this.dataGridViewTextBoxColumn_4.Name = "directDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_4.ReadOnly = true;
            this.dataGridViewTextBoxColumn_5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_5.DataPropertyName = "Mark";
            style4.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_5.DefaultCellStyle = style4;
            this.dataGridViewTextBoxColumn_5.FillWeight = 20.03578f;
            this.dataGridViewTextBoxColumn_5.HeaderText = "Отмека об устр-ии";
            this.dataGridViewTextBoxColumn_5.Name = "markDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_5.ReadOnly = true;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x375, 0x189);
            base.Controls.Add(this.splitContainer_0);
            base.Controls.Add(this.toolStrip_0);
            base.Name = "FormJDefect";
            this.Text = "Журнал дефектов и неполадок";
            base.Load += new EventHandler(this.FormJDefect_Load);
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            this.splitContainer_0.Panel1.ResumeLayout(false);
            this.splitContainer_0.Panel1.PerformLayout();
            this.splitContainer_0.Panel2.ResumeLayout(false);
            this.splitContainer_0.ResumeLayout(false);
            this.dataGridViewExcelFilter_0.EndInit();
            ((ISupportInitialize) this.bindingSource_0).EndInit();
            this.dataSet_0.EndInit();
            this.dataTable_0.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void radioButton_0_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton_0.Checked)
            {
                this.comboBox_2.Enabled = false;
                this.comboBox_1.Enabled = false;
                this.comboBox_0.Enabled = false;
                this.dateTimePicker_1.Enabled = true;
                this.dateTimePicker_0.Enabled = true;
                this.method_0();
            }
        }

        private void radioButton_1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton_1.Checked)
            {
                this.comboBox_2.Enabled = false;
                this.comboBox_1.Enabled = false;
                this.comboBox_0.Enabled = true;
                this.dateTimePicker_1.Enabled = false;
                this.dateTimePicker_0.Enabled = false;
                this.method_0();
            }
        }

        private void radioButton_2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton_2.Checked)
            {
                this.comboBox_2.Enabled = true;
                this.comboBox_1.Enabled = true;
                this.comboBox_0.Enabled = false;
                this.dateTimePicker_1.Enabled = false;
                this.dateTimePicker_0.Enabled = false;
                this.method_0();
            }
        }

        private void toolStripButton_0_Click(object sender, EventArgs e)
        {
            Form50 form = new Form50(-1);
            form.set_SqlSettings(this.get_SqlSettings());
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.method_0();
                this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewTextBoxColumn_0.Name, form.Id.ToString(), false);
            }
        }

        private void toolStripButton_1_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_0.CurrentRow != null)
            {
                Form50 form = new Form50(Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_0.Name].Value));
                form.set_SqlSettings(this.get_SqlSettings());
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.method_0();
                    this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewTextBoxColumn_0.Name, form.Id.ToString(), false);
                }
            }
        }

        private void toolStripButton_2_Click(object sender, EventArgs e)
        {
            if (((this.dataGridViewExcelFilter_0.CurrentRow != null) && (MessageBox.Show("Вы действиетльно хотите удалить текущую запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)) && base.DeleteSqlDataById(this.dataTable_0, Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_0.Name].Value)))
            {
                this.dataGridViewExcelFilter_0.Rows.Remove(this.dataGridViewExcelFilter_0.CurrentRow);
            }
        }

        private void toolStripButton_3_Click(object sender, EventArgs e)
        {
            this.method_0();
        }

        private void toolStripButton_4_Click(object sender, EventArgs e)
        {
            FormJDefectReport report1 = new FormJDefectReport {
                MdiParent = base.MdiParent
            };
            report1.set_SqlSettings(this.get_SqlSettings());
            report1.Show();
        }
    }
}

