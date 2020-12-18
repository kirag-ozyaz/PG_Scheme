namespace Documents.Forms.TechnologicalConnection.Consumers
{
    using ControlsLbr.DataGridViewExcelFilter;
    using Documents.Forms.TechnologicalConnection;
    using Documents.Forms.TechnologicalConnection.TU;
    using Documents.Properties;
    using FormLbr;
    using FormLbr.Classes;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Windows.Forms;

    public class FormDistributionConsumers : FormBase
    {
        private BindingSource bindingSource_0;
        private CheckBox checkBox_0;
        private ContextMenuStrip contextMenuStrip_0;
        private DataColumn dataColumn_0;
        private DataColumn dataColumn_1;
        private DataColumn dataColumn_10;
        private DataColumn dataColumn_11;
        private DataColumn dataColumn_12;
        private DataColumn dataColumn_13;
        private DataColumn dataColumn_2;
        private DataColumn dataColumn_3;
        private DataColumn dataColumn_4;
        private DataColumn dataColumn_5;
        private DataColumn dataColumn_6;
        private DataColumn dataColumn_7;
        private DataColumn dataColumn_8;
        private DataColumn dataColumn_9;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_0;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_1;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_2;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_3;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_4;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_5;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_6;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_7;
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
        private SplitContainer splitContainer_0;
        private ToolStrip toolStrip_0;
        private ToolStrip toolStrip_1;
        private ToolStripButton toolStripButton_0;
        private ToolStripButton toolStripButton_1;
        private ToolStripButton toolStripButton_10;
        private ToolStripButton toolStripButton_2;
        private ToolStripButton toolStripButton_3;
        private ToolStripButton toolStripButton_4;
        private ToolStripButton toolStripButton_5;
        private ToolStripButton toolStripButton_6;
        private ToolStripButton toolStripButton_7;
        private ToolStripButton toolStripButton_8;
        private ToolStripButton toolStripButton_9;
        private ToolStripMenuItem toolStripMenuItem_0;
        private ToolStripMenuItem toolStripMenuItem_1;
        private ToolStripMenuItem toolStripMenuItem_2;
        private ToolStripMenuItem toolStripMenuItem_3;
        private ToolStripSeparator toolStripSeparator_0;
        private ToolStripSeparator toolStripSeparator_1;
        private ToolStripSeparator toolStripSeparator_2;
        private ToolStripSeparator toolStripSeparator_3;
        private ToolStripSeparator toolStripSeparator_4;
        private ToolStripTextBox toolStripTextBox_0;

        public FormDistributionConsumers()
        {
            this.method_2();
            this.method_0();
        }

        private void bindingSource_0_CurrentChanged(object sender, EventArgs e)
        {
            if (this.bindingSource_0.Current != null)
            {
                this.toolStripMenuItem_0.Enabled = true;
                this.toolStripButton_3.Enabled = true;
                if (((DataRowView) this.bindingSource_0.Current).Row["TUid"] != DBNull.Value)
                {
                    this.toolStripMenuItem_1.Enabled = true;
                    this.toolStripButton_4.Enabled = true;
                }
                else
                {
                    this.toolStripMenuItem_1.Enabled = false;
                    this.toolStripButton_4.Enabled = false;
                }
                int num = Convert.ToInt32(((DataRowView) this.bindingSource_0.Current).Row["TypeAbn"]);
                if ((num != 0xcf) && (num != 0xce))
                {
                    this.toolStripMenuItem_2.Enabled = false;
                    this.toolStripButton_5.Enabled = false;
                }
                else
                {
                    this.toolStripMenuItem_2.Enabled = true;
                    this.toolStripButton_5.Enabled = true;
                }
            }
            else
            {
                this.toolStripMenuItem_2.Enabled = false;
                this.toolStripButton_5.Enabled = false;
                this.toolStripMenuItem_0.Enabled = false;
                this.toolStripButton_3.Enabled = false;
                this.toolStripMenuItem_1.Enabled = false;
                this.toolStripButton_4.Enabled = false;
            }
        }

        private void dataGridViewExcelFilter_0_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int num = Convert.ToInt32(this.dataGridViewExcelFilter_0[this.dataGridViewTextBoxColumn_1.Name, e.RowIndex].Value);
                switch (num)
                {
                    case 0x40e:
                    case 0xcf:
                        e.CellStyle.BackColor = Color.LightGray;
                        break;
                }
                if ((num == 0x40d) || (num == 0x40e))
                {
                    e.CellStyle.ForeColor = Color.Blue;
                }
            }
        }

        private void dataGridViewExcelFilter_0_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo info = this.dataGridViewExcelFilter_0.HitTest(e.X, e.Y);
                if (info.RowIndex >= 0)
                {
                    this.dataGridViewExcelFilter_0.ClearSelection();
                    this.dataGridViewExcelFilter_0.Rows[info.RowIndex].Selected = true;
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

        private void FormDistributionConsumers_Load(object sender, EventArgs e)
        {
            this.method_1();
        }

        private void method_0()
        {
            this.dateTimePicker_1.Value = new DateTime(DateTime.Now.Year, 1, 1);
            this.dateTimePicker_0.Value = new DateTime(DateTime.Now.Year, 12, 0x1f);
            this.checkBox_0.Checked = true;
        }

        private void method_1()
        {
            using (SqlConnection connection = new SqlConnection(this.SqlSettings.GetConnectionString() + ";Connection Timeout=0"))
            {
                connection.Open();
                try
                {
                    string selectCommandText = ResourceReader.GetStringAssembly("Documents.Forms.TechnologicalConnection.SqlScripts.vDistributionConsumers.sql") + string.Format(" and req.DateIn >= '{0}' and req.DateIn <= '{1}'", this.dateTimePicker_1.Value.ToString("yyyyMMdd"), this.dateTimePicker_0.Value.ToString("yyyyMMdd"));
                    if (this.checkBox_0.Checked)
                    {
                        selectCommandText = selectCommandText + " and tu.id is not null ";
                    }
                    selectCommandText = selectCommandText + " order by ao.codeAbonent";
                    this.dataTable_0.Clear();
                    new SqlDataAdapter(selectCommandText, connection).Fill(this.dataTable_0);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, exception.Source);
                }
            }
        }

        private void method_2()
        {
            this.icontainer_0 = new Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(FormDistributionConsumers));
            this.toolStrip_0 = new ToolStrip();
            this.toolStripButton_2 = new ToolStripButton();
            this.toolStripSeparator_0 = new ToolStripSeparator();
            this.toolStripButton_3 = new ToolStripButton();
            this.toolStripButton_4 = new ToolStripButton();
            this.toolStripButton_5 = new ToolStripButton();
            this.toolStripSeparator_1 = new ToolStripSeparator();
            this.toolStripButton_6 = new ToolStripButton();
            this.splitContainer_0 = new SplitContainer();
            this.checkBox_0 = new CheckBox();
            this.dateTimePicker_0 = new DateTimePicker();
            this.label_0 = new Label();
            this.dateTimePicker_1 = new DateTimePicker();
            this.label_1 = new Label();
            this.toolStrip_1 = new ToolStrip();
            this.toolStripButton_0 = new ToolStripButton();
            this.toolStripButton_1 = new ToolStripButton();
            this.dataGridViewExcelFilter_0 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_1 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_2 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_3 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_4 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_5 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_6 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_7 = new DataGridViewFilterTextBoxColumn();
            this.contextMenuStrip_0 = new ContextMenuStrip(this.icontainer_0);
            this.toolStripMenuItem_0 = new ToolStripMenuItem();
            this.toolStripMenuItem_1 = new ToolStripMenuItem();
            this.toolStripMenuItem_2 = new ToolStripMenuItem();
            this.toolStripSeparator_2 = new ToolStripSeparator();
            this.toolStripMenuItem_3 = new ToolStripMenuItem();
            this.bindingSource_0 = new BindingSource(this.icontainer_0);
            this.dataSet_0 = new DataSet();
            this.dataTable_0 = new DataTable();
            this.dataColumn_0 = new DataColumn();
            this.dataColumn_1 = new DataColumn();
            this.dataColumn_2 = new DataColumn();
            this.dataColumn_3 = new DataColumn();
            this.dataColumn_4 = new DataColumn();
            this.dataColumn_5 = new DataColumn();
            this.dataColumn_6 = new DataColumn();
            this.dataColumn_7 = new DataColumn();
            this.dataColumn_8 = new DataColumn();
            this.dataColumn_9 = new DataColumn();
            this.dataColumn_10 = new DataColumn();
            this.dataColumn_11 = new DataColumn();
            this.dataColumn_12 = new DataColumn();
            this.dataColumn_13 = new DataColumn();
            this.toolStripSeparator_3 = new ToolStripSeparator();
            this.toolStripButton_7 = new ToolStripButton();
            this.toolStripTextBox_0 = new ToolStripTextBox();
            this.toolStripButton_8 = new ToolStripButton();
            this.toolStripButton_9 = new ToolStripButton();
            this.toolStripSeparator_4 = new ToolStripSeparator();
            this.toolStripButton_10 = new ToolStripButton();
            this.toolStrip_0.SuspendLayout();
            this.splitContainer_0.Panel1.SuspendLayout();
            this.splitContainer_0.Panel2.SuspendLayout();
            this.splitContainer_0.SuspendLayout();
            this.toolStrip_1.SuspendLayout();
            this.dataGridViewExcelFilter_0.BeginInit();
            this.contextMenuStrip_0.SuspendLayout();
            ((ISupportInitialize) this.bindingSource_0).BeginInit();
            this.dataSet_0.BeginInit();
            this.dataTable_0.BeginInit();
            base.SuspendLayout();
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripButton_2, this.toolStripSeparator_0, this.toolStripButton_3, this.toolStripButton_4, this.toolStripButton_5, this.toolStripSeparator_1, this.toolStripButton_6, this.toolStripSeparator_3, this.toolStripButton_7, this.toolStripTextBox_0, this.toolStripButton_8, this.toolStripButton_9, this.toolStripSeparator_4, this.toolStripButton_10 };
            this.toolStrip_0.Items.AddRange(toolStripItems);
            this.toolStrip_0.Location = new Point(0, 0);
            this.toolStrip_0.Name = "toolStrip";
            this.toolStrip_0.Size = new Size(0x337, 0x19);
            this.toolStrip_0.TabIndex = 0;
            this.toolStrip_0.Text = "toolStrip1";
            this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_2.Image = Resources.refresh_16;
            this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_2.Name = "toolBtnRefresh";
            this.toolStripButton_2.Size = new Size(0x17, 0x16);
            this.toolStripButton_2.Text = "Обновить";
            this.toolStripButton_2.Click += new EventHandler(this.toolStripButton_2_Click);
            this.toolStripSeparator_0.Name = "toolStripSeparator1";
            this.toolStripSeparator_0.Size = new Size(6, 0x19);
            this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_3.Image = (Image) manager.GetObject("toolBtnShowRequest.Image");
            this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_3.Name = "toolBtnShowRequest";
            this.toolStripButton_3.Size = new Size(0x17, 0x16);
            this.toolStripButton_3.Text = "Открыть заявку";
            this.toolStripButton_3.Click += new EventHandler(this.toolStripButton_3_Click);
            this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_4.Image = Resources._1381484495_Terms_rev;
            this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_4.Name = "toolBtnShowTU";
            this.toolStripButton_4.Size = new Size(0x17, 0x16);
            this.toolStripButton_4.Text = "Открыть тех условие";
            this.toolStripButton_4.Click += new EventHandler(this.toolStripButton_4_Click);
            this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_5.Image = Resources.Person;
            this.toolStripButton_5.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_5.Name = "toolBtnShowAbn";
            this.toolStripButton_5.Size = new Size(0x17, 0x16);
            this.toolStripButton_5.Text = "Открыть карточку абонента";
            this.toolStripButton_5.Click += new EventHandler(this.toolStripButton_5_Click);
            this.toolStripSeparator_1.Name = "toolStripSeparator2";
            this.toolStripSeparator_1.Size = new Size(6, 0x19);
            this.toolStripButton_6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_6.Image = Resources.AbonentsSettings;
            this.toolStripButton_6.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_6.Name = "toolBtnChangeTypeKontragent";
            this.toolStripButton_6.Size = new Size(0x17, 0x16);
            this.toolStripButton_6.Text = "Сменить тип контрагента";
            this.toolStripButton_6.Click += new EventHandler(this.toolStripButton_6_Click);
            this.splitContainer_0.Dock = DockStyle.Fill;
            this.splitContainer_0.FixedPanel = FixedPanel.Panel1;
            this.splitContainer_0.Location = new Point(0, 0x19);
            this.splitContainer_0.Name = "splitContainer1";
            this.splitContainer_0.Panel1.Controls.Add(this.checkBox_0);
            this.splitContainer_0.Panel1.Controls.Add(this.dateTimePicker_0);
            this.splitContainer_0.Panel1.Controls.Add(this.label_0);
            this.splitContainer_0.Panel1.Controls.Add(this.dateTimePicker_1);
            this.splitContainer_0.Panel1.Controls.Add(this.label_1);
            this.splitContainer_0.Panel1.Controls.Add(this.toolStrip_1);
            this.splitContainer_0.Panel2.Controls.Add(this.dataGridViewExcelFilter_0);
            this.splitContainer_0.Size = new Size(0x337, 440);
            this.splitContainer_0.SplitterDistance = 0xa7;
            this.splitContainer_0.TabIndex = 1;
            this.checkBox_0.AutoSize = true;
            this.checkBox_0.Checked = true;
            this.checkBox_0.CheckState = CheckState.Checked;
            this.checkBox_0.Location = new Point(15, 0x6a);
            this.checkBox_0.Name = "checkBoxExistTU";
            this.checkBox_0.Size = new Size(0x44, 0x11);
            this.checkBox_0.TabIndex = 14;
            this.checkBox_0.Text = "Есть ТУ";
            this.checkBox_0.UseVisualStyleBackColor = true;
            this.dateTimePicker_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.dateTimePicker_0.Location = new Point(12, 80);
            this.dateTimePicker_0.Name = "dateTimePickerFilterEnd";
            this.dateTimePicker_0.Size = new Size(140, 20);
            this.dateTimePicker_0.TabIndex = 13;
            this.label_0.AutoSize = true;
            this.label_0.Location = new Point(12, 0x40);
            this.label_0.Name = "label2";
            this.label_0.Size = new Size(0x59, 13);
            this.label_0.TabIndex = 12;
            this.label_0.Text = "Дата окончания";
            this.dateTimePicker_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.dateTimePicker_1.Location = new Point(12, 0x29);
            this.dateTimePicker_1.Name = "dateTimePickerFilterBeg";
            this.dateTimePicker_1.Size = new Size(140, 20);
            this.dateTimePicker_1.TabIndex = 11;
            this.label_1.AutoSize = true;
            this.label_1.Location = new Point(12, 0x19);
            this.label_1.Name = "label1";
            this.label_1.Size = new Size(0x47, 13);
            this.label_1.TabIndex = 10;
            this.label_1.Text = "Дата начала";
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.toolStripButton_0, this.toolStripButton_1 };
            this.toolStrip_1.Items.AddRange(itemArray2);
            this.toolStrip_1.Location = new Point(0, 0);
            this.toolStrip_1.Name = "toolStripFilter";
            this.toolStrip_1.Size = new Size(0xa7, 0x19);
            this.toolStrip_1.TabIndex = 6;
            this.toolStrip_1.Text = "toolStrip1";
            this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_0.Image = (Image) manager.GetObject("toolBtnApplyFilter.Image");
            this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_0.Name = "toolBtnApplyFilter";
            this.toolStripButton_0.Size = new Size(0x17, 0x16);
            this.toolStripButton_0.Text = "Применить фильтр";
            this.toolStripButton_0.Click += new EventHandler(this.toolStripButton_0_Click);
            this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_1.Image = (Image) manager.GetObject("toolBtnClearFilter.Image");
            this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_1.Name = "toolBtnClearFilter";
            this.toolStripButton_1.Size = new Size(0x17, 0x16);
            this.toolStripButton_1.Text = "Очистить фильтр";
            this.toolStripButton_1.Click += new EventHandler(this.toolStripButton_1_Click);
            this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToOrderColumns = true;
            this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
            this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewFilterTextBoxColumn_0, this.dataGridViewTextBoxColumn_0, this.dataGridViewFilterTextBoxColumn_1, this.dataGridViewTextBoxColumn_1, this.dataGridViewFilterTextBoxColumn_2, this.dataGridViewTextBoxColumn_2, this.dataGridViewFilterTextBoxColumn_3, this.dataGridViewTextBoxColumn_3, this.dataGridViewTextBoxColumn_4, this.dataGridViewFilterTextBoxColumn_4, this.dataGridViewFilterTextBoxColumn_5, this.dataGridViewTextBoxColumn_5, this.dataGridViewFilterTextBoxColumn_6, this.dataGridViewFilterTextBoxColumn_7 };
            this.dataGridViewExcelFilter_0.Columns.AddRange(dataGridViewColumns);
            this.dataGridViewExcelFilter_0.ContextMenuStrip = this.contextMenuStrip_0;
            this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
            this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_0.Location = new Point(0, 0);
            this.dataGridViewExcelFilter_0.Name = "dgv";
            this.dataGridViewExcelFilter_0.ReadOnly = true;
            this.dataGridViewExcelFilter_0.Size = new Size(0x28c, 440);
            this.dataGridViewExcelFilter_0.TabIndex = 0;
            this.dataGridViewExcelFilter_0.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridViewExcelFilter_0_CellFormatting);
            this.dataGridViewExcelFilter_0.MouseDown += new MouseEventHandler(this.dataGridViewExcelFilter_0_MouseDown);
            this.dataGridViewFilterTextBoxColumn_0.DataPropertyName = "CodeAbonent";
            this.dataGridViewFilterTextBoxColumn_0.HeaderText = "Код";
            this.dataGridViewFilterTextBoxColumn_0.Name = "codeAbonentDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_0.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_0.DataPropertyName = "idAbn";
            this.dataGridViewTextBoxColumn_0.HeaderText = "idAbn";
            this.dataGridViewTextBoxColumn_0.Name = "idAbnDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewTextBoxColumn_0.Visible = false;
            this.dataGridViewFilterTextBoxColumn_1.DataPropertyName = "nameAbn";
            this.dataGridViewFilterTextBoxColumn_1.HeaderText = "Контрагент";
            this.dataGridViewFilterTextBoxColumn_1.Name = "nameAbnDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_1.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_1.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_1.DataPropertyName = "TypeAbn";
            this.dataGridViewTextBoxColumn_1.HeaderText = "TypeAbn";
            this.dataGridViewTextBoxColumn_1.Name = "typeAbnDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_1.ReadOnly = true;
            this.dataGridViewTextBoxColumn_1.Visible = false;
            this.dataGridViewFilterTextBoxColumn_2.DataPropertyName = "TypeAbnName";
            this.dataGridViewFilterTextBoxColumn_2.HeaderText = "Тип";
            this.dataGridViewFilterTextBoxColumn_2.Name = "typeAbnNameDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_2.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_2.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_2.DataPropertyName = "idAbnObj";
            this.dataGridViewTextBoxColumn_2.HeaderText = "idAbnObj";
            this.dataGridViewTextBoxColumn_2.Name = "idAbnObjDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_2.ReadOnly = true;
            this.dataGridViewTextBoxColumn_2.Visible = false;
            this.dataGridViewFilterTextBoxColumn_3.DataPropertyName = "nameObj";
            this.dataGridViewFilterTextBoxColumn_3.HeaderText = "Объект";
            this.dataGridViewFilterTextBoxColumn_3.Name = "nameObjDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_3.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_3.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_3.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn_3.HeaderText = "Address";
            this.dataGridViewTextBoxColumn_3.Name = "addressDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_3.ReadOnly = true;
            this.dataGridViewTextBoxColumn_3.Visible = false;
            this.dataGridViewTextBoxColumn_4.DataPropertyName = "idRequest";
            this.dataGridViewTextBoxColumn_4.HeaderText = "idRequest";
            this.dataGridViewTextBoxColumn_4.Name = "idRequestDgvColumn";
            this.dataGridViewTextBoxColumn_4.ReadOnly = true;
            this.dataGridViewTextBoxColumn_4.Visible = false;
            this.dataGridViewFilterTextBoxColumn_4.DataPropertyName = "numIn";
            this.dataGridViewFilterTextBoxColumn_4.HeaderText = "№ заявки";
            this.dataGridViewFilterTextBoxColumn_4.Name = "numInDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_4.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_4.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_5.DataPropertyName = "DateIn";
            this.dataGridViewFilterTextBoxColumn_5.HeaderText = "Дата заявки";
            this.dataGridViewFilterTextBoxColumn_5.Name = "dateInDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_5.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_5.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_5.DataPropertyName = "tuId";
            this.dataGridViewTextBoxColumn_5.HeaderText = "tuId";
            this.dataGridViewTextBoxColumn_5.Name = "idTUDgvColumn";
            this.dataGridViewTextBoxColumn_5.ReadOnly = true;
            this.dataGridViewTextBoxColumn_5.Visible = false;
            this.dataGridViewFilterTextBoxColumn_6.DataPropertyName = "numTu";
            this.dataGridViewFilterTextBoxColumn_6.HeaderText = "№ ТУ";
            this.dataGridViewFilterTextBoxColumn_6.Name = "numTuDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_6.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_6.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_7.DataPropertyName = "dateTU";
            this.dataGridViewFilterTextBoxColumn_7.HeaderText = "Дата ТУ";
            this.dataGridViewFilterTextBoxColumn_7.Name = "dateTUDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_7.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_7.Resizable = DataGridViewTriState.True;
            ToolStripItem[] itemArray3 = new ToolStripItem[] { this.toolStripMenuItem_0, this.toolStripMenuItem_1, this.toolStripMenuItem_2, this.toolStripSeparator_2, this.toolStripMenuItem_3 };
            this.contextMenuStrip_0.Items.AddRange(itemArray3);
            this.contextMenuStrip_0.Name = "contextMenuDgv";
            this.contextMenuStrip_0.Size = new Size(0xd7, 0x62);
            this.toolStripMenuItem_0.Image = Resources.network_connection_manager;
            this.toolStripMenuItem_0.Name = "toolMenuItemShowRequest";
            this.toolStripMenuItem_0.Size = new Size(0xd6, 0x16);
            this.toolStripMenuItem_0.Text = "Открыть заявку";
            this.toolStripMenuItem_0.Click += new EventHandler(this.toolStripMenuItem_0_Click);
            this.toolStripMenuItem_1.Image = Resources._1381484495_Terms_rev;
            this.toolStripMenuItem_1.Name = "toolMenuItemShowTU";
            this.toolStripMenuItem_1.Size = new Size(0xd6, 0x16);
            this.toolStripMenuItem_1.Text = "Открыть тех условие";
            this.toolStripMenuItem_1.Click += new EventHandler(this.toolStripMenuItem_1_Click);
            this.toolStripMenuItem_2.Image = Resources.Person;
            this.toolStripMenuItem_2.Name = "toolMenuItemShowAbn";
            this.toolStripMenuItem_2.Size = new Size(0xd6, 0x16);
            this.toolStripMenuItem_2.Text = "Карточка потребителя";
            this.toolStripMenuItem_2.Click += new EventHandler(this.toolStripMenuItem_2_Click);
            this.toolStripSeparator_2.Name = "toolStripSeparator3";
            this.toolStripSeparator_2.Size = new Size(0xd3, 6);
            this.toolStripMenuItem_3.Image = Resources.AbonentsSettings;
            this.toolStripMenuItem_3.Name = "toolMenuChangeTypeKontragenе";
            this.toolStripMenuItem_3.Size = new Size(0xd6, 0x16);
            this.toolStripMenuItem_3.Text = "Сменить тип контрагента";
            this.toolStripMenuItem_3.Click += new EventHandler(this.toolStripMenuItem_3_Click);
            this.bindingSource_0.DataMember = "dtDistrCons";
            this.bindingSource_0.DataSource = this.dataSet_0;
            this.bindingSource_0.CurrentChanged += new EventHandler(this.bindingSource_0_CurrentChanged);
            this.dataSet_0.DataSetName = "NewDataSet";
            DataTable[] tables = new DataTable[] { this.dataTable_0 };
            this.dataSet_0.Tables.AddRange(tables);
            DataColumn[] columns = new DataColumn[] { this.dataColumn_0, this.dataColumn_1, this.dataColumn_2, this.dataColumn_3, this.dataColumn_4, this.dataColumn_5, this.dataColumn_6, this.dataColumn_7, this.dataColumn_8, this.dataColumn_9, this.dataColumn_10, this.dataColumn_11, this.dataColumn_12, this.dataColumn_13 };
            this.dataTable_0.Columns.AddRange(columns);
            this.dataTable_0.TableName = "dtDistrCons";
            this.dataColumn_0.ColumnName = "idAbn";
            this.dataColumn_0.DataType = typeof(int);
            this.dataColumn_1.ColumnName = "CodeAbonent";
            this.dataColumn_1.DataType = typeof(int);
            this.dataColumn_2.ColumnName = "nameAbn";
            this.dataColumn_3.ColumnName = "TypeAbn";
            this.dataColumn_3.DataType = typeof(int);
            this.dataColumn_4.ColumnName = "TypeAbnName";
            this.dataColumn_5.ColumnName = "idAbnObj";
            this.dataColumn_5.DataType = typeof(int);
            this.dataColumn_6.ColumnName = "nameObj";
            this.dataColumn_7.ColumnName = "Address";
            this.dataColumn_8.ColumnName = "idRequest";
            this.dataColumn_9.ColumnName = "numIn";
            this.dataColumn_10.ColumnName = "DateIn";
            this.dataColumn_10.DataType = typeof(DateTime);
            this.dataColumn_11.ColumnName = "tuId";
            this.dataColumn_11.DataType = typeof(int);
            this.dataColumn_12.ColumnName = "numTu";
            this.dataColumn_13.ColumnName = "dateTU";
            this.dataColumn_13.DataType = typeof(DateTime);
            this.toolStripSeparator_3.Name = "toolStripSeparator4";
            this.toolStripSeparator_3.Size = new Size(6, 0x19);
            this.toolStripButton_7.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_7.Image = (Image) manager.GetObject("toolBtnFind.Image");
            this.toolStripButton_7.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_7.Name = "toolBtnFind";
            this.toolStripButton_7.Size = new Size(0x17, 0x16);
            this.toolStripButton_7.Text = "Поиск";
            this.toolStripButton_7.Click += new EventHandler(this.toolStripButton_7_Click);
            this.toolStripTextBox_0.Name = "toolTxtFind";
            this.toolStripTextBox_0.Size = new Size(100, 0x19);
            this.toolStripTextBox_0.ToolTipText = "Текст поиска";
            this.toolStripTextBox_0.KeyDown += new KeyEventHandler(this.toolStripTextBox_0_KeyDown);
            this.toolStripButton_8.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_8.Image = (Image) manager.GetObject("toolBtnFindPrev.Image");
            this.toolStripButton_8.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_8.Name = "toolBtnFindPrev";
            this.toolStripButton_8.Size = new Size(0x17, 0x16);
            this.toolStripButton_8.Text = "Поиск назад";
            this.toolStripButton_8.Click += new EventHandler(this.toolStripButton_8_Click);
            this.toolStripButton_9.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_9.Image = (Image) manager.GetObject("toolBtnFindNext.Image");
            this.toolStripButton_9.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_9.Name = "toolBtnFindNext";
            this.toolStripButton_9.Size = new Size(0x17, 0x16);
            this.toolStripButton_9.Text = "Поиск вперед";
            this.toolStripButton_9.Click += new EventHandler(this.toolStripButton_9_Click);
            this.toolStripSeparator_4.Name = "toolStripSeparator5";
            this.toolStripSeparator_4.Size = new Size(6, 0x19);
            this.toolStripButton_10.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_10.Image = (Image) manager.GetObject("toolBtnExportExcel.Image");
            this.toolStripButton_10.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_10.Name = "toolBtnExportExcel";
            this.toolStripButton_10.Size = new Size(0x17, 0x16);
            this.toolStripButton_10.Text = "Экспорт в Excel";
            this.toolStripButton_10.Click += new EventHandler(this.toolStripButton_10_Click);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x337, 0x1d1);
            base.Controls.Add(this.splitContainer_0);
            base.Controls.Add(this.toolStrip_0);
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Name = "FormDistributionConsumers";
            this.Text = "Журанл распределения контрагентов";
            base.Load += new EventHandler(this.FormDistributionConsumers_Load);
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            this.splitContainer_0.Panel1.ResumeLayout(false);
            this.splitContainer_0.Panel1.PerformLayout();
            this.splitContainer_0.Panel2.ResumeLayout(false);
            this.splitContainer_0.ResumeLayout(false);
            this.toolStrip_1.ResumeLayout(false);
            this.toolStrip_1.PerformLayout();
            this.dataGridViewExcelFilter_0.EndInit();
            this.contextMenuStrip_0.ResumeLayout(false);
            ((ISupportInitialize) this.bindingSource_0).EndInit();
            this.dataSet_0.EndInit();
            this.dataTable_0.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void toolStripButton_0_Click(object sender, EventArgs e)
        {
            this.method_1();
        }

        private void toolStripButton_1_Click(object sender, EventArgs e)
        {
            this.method_0();
            this.method_1();
        }

        private void toolStripButton_10_Click(object sender, EventArgs e)
        {
            this.dataGridViewExcelFilter_0.ExportToExcel();
        }

        private void toolStripButton_2_Click(object sender, EventArgs e)
        {
            this.method_1();
        }

        private void toolStripButton_3_Click(object sender, EventArgs e)
        {
            if (((this.dataGridViewExcelFilter_0.CurrentRow != null) && (this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_4.Name].Value != null)) && (this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_4.Name].Value != DBNull.Value))
            {
                FormTechConnectionRequest request1 = new FormTechConnectionRequest(Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_4.Name].Value)) {
                    MdiParent = base.MdiParent
                };
                request1.set_SqlSettings(this.get_SqlSettings());
                request1.Show();
            }
        }

        private void toolStripButton_4_Click(object sender, EventArgs e)
        {
            if (((this.dataGridViewExcelFilter_0.CurrentRow != null) && (this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_5.Name].Value != null)) && (this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_5.Name].Value != DBNull.Value))
            {
                FormJournalTU ltu1 = new FormJournalTU(Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_5.Name].Value)) {
                    MdiParent = base.MdiParent
                };
                ltu1.set_SqlSettings(this.get_SqlSettings());
                ltu1.Show();
            }
        }

        private void toolStripButton_5_Click(object sender, EventArgs e)
        {
            if (((this.dataGridViewExcelFilter_0.CurrentRow != null) && (this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_1.Name].Value != null)) && (this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_1.Name].Value != DBNull.Value))
            {
                int num = Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_1.Name].Value);
                switch (num)
                {
                    case 0xce:
                    {
                        ShowFormEventArgs args = new ShowFormEventArgs();
                        args.set_TypeForm("Prv.Forms.Abonent.FormAbonent, Prv");
                        args.set_FormMode(1);
                        args.set_Param(new object[2]);
                        args.get_Param()[0] = Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewFilterTextBoxColumn_0.Name].Value);
                        args.get_Param()[1] = num;
                        args.set_SQLSettings(this.get_SqlSettings());
                        this.OnShowForm(args);
                        break;
                    }
                    case 0xcf:
                    {
                        ShowFormEventArgs args2 = new ShowFormEventArgs();
                        args2.set_TypeForm("Legal.Forms.FormAbn, Legal");
                        args2.set_FormMode(1);
                        args2.set_Param(new object[2]);
                        args2.get_Param()[0] = Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewFilterTextBoxColumn_0.Name].Value);
                        args2.get_Param()[1] = Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_2.Name].Value);
                        args2.set_SQLSettings(this.get_SqlSettings());
                        this.OnShowForm(args2);
                        break;
                    }
                }
            }
        }

        private void toolStripButton_6_Click(object sender, EventArgs e)
        {
            if (((this.dataGridViewExcelFilter_0.CurrentRow != null) && (this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_1.Name].Value != null)) && (this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_1.Name].Value != DBNull.Value))
            {
                List<int> list = new List<int> { 
                    0x40d,
                    0x40e
                };
                Form16 form1 = new Form16(Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_0.Name].Value), list);
                form1.set_SqlSettings(this.get_SqlSettings());
                if (form1.ShowDialog() == DialogResult.OK)
                {
                    this.method_1();
                }
            }
        }

        private void toolStripButton_7_Click(object sender, EventArgs e)
        {
            this.dataGridViewExcelFilter_0.SearchGrid(1, this.toolStripTextBox_0.Text);
        }

        private void toolStripButton_8_Click(object sender, EventArgs e)
        {
            this.dataGridViewExcelFilter_0.SearchGrid(3, this.toolStripTextBox_0.Text);
        }

        private void toolStripButton_9_Click(object sender, EventArgs e)
        {
            this.dataGridViewExcelFilter_0.SearchGrid(2, this.toolStripTextBox_0.Text);
        }

        private void toolStripMenuItem_0_Click(object sender, EventArgs e)
        {
            this.toolStripButton_3_Click(sender, e);
        }

        private void toolStripMenuItem_1_Click(object sender, EventArgs e)
        {
            this.toolStripButton_4_Click(sender, e);
        }

        private void toolStripMenuItem_2_Click(object sender, EventArgs e)
        {
            this.toolStripButton_5_Click(sender, e);
        }

        private void toolStripMenuItem_3_Click(object sender, EventArgs e)
        {
            this.toolStripButton_6_Click(sender, e);
        }

        private void toolStripTextBox_0_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (e.Modifiers == Keys.None)
                {
                    this.dataGridViewExcelFilter_0.SearchGrid(2, this.toolStripTextBox_0.Text);
                }
                if (e.Modifiers == Keys.Shift)
                {
                    this.dataGridViewExcelFilter_0.SearchGrid(3, this.toolStripTextBox_0.Text);
                }
            }
        }
    }
}

