namespace Documents.Forms
{
    using DataSql;
    using Documents.DataSets;
    using Documents.Forms.GRPApplication;
    using Documents.Properties;
    using FormLbr;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;
    using System.Xml;

    public class FormList : FormBase
    {
        private BindingSource bindingSource_0;
        private Class202 class202_0;
        private DataGridView dataGridView_0;
        private DataGridViewImageColumn dataGridViewImageColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;
        private FormFilter formFilter_0;
        private IContainer icontainer_0;
        private List<string> list_0;
        private OrgDataSet orgDataSet_0;
        private const string string_0 = "RequestODS";
        private ToolStrip toolStrip_0;
        private ToolStrip toolStrip_1;
        private ToolStripButton toolStripButton_0;
        private ToolStripButton toolStripButton_1;
        private ToolStripButton toolStripButton_2;
        private ToolStripButton toolStripButton_3;
        private ToolStripButton toolStripButton_4;
        private ToolStripButton toolStripButton_5;
        private ToolStripButton toolStripButton_6;

        public FormList()
        {
            this.formFilter_0 = new FormFilter();
            this.list_0 = new List<string>();
            this.method_1();
        }

        public FormList(SQLSettings SqlSettings)
        {
            this.formFilter_0 = new FormFilter();
            this.list_0 = new List<string>();
            this.method_1();
            this.set_SqlSettings(SqlSettings);
        }

        private void dataGridView_0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((OrgDataSet.Class410) ((DataRowView) this.bindingSource_0.Current).Row).method_6())
            {
                FormAddApplication application1 = new FormAddApplication(this, true, this.get_SqlSettings()) {
                    tblAbnAplForDisconBindingSource = { 
                        DataSource = this.bindingSource_0,
                        Filter = this.bindingSource_0.Filter,
                        Position = this.bindingSource_0.Position
                    }
                };
                if (application1.ShowDialog() == DialogResult.OK)
                {
                    this.class202_0.vmethod_0(this.orgDataSet_0.tblAbnAplForDiscon);
                }
            }
            else
            {
                FormAddApplication application2 = new FormAddApplication(this, false, this.get_SqlSettings()) {
                    tblAbnAplForDisconBindingSource = { 
                        DataSource = this.bindingSource_0,
                        Filter = this.bindingSource_0.Filter,
                        Position = this.bindingSource_0.Position
                    }
                };
                if (application2.ShowDialog() == DialogResult.OK)
                {
                    this.class202_0.vmethod_0(this.orgDataSet_0.tblAbnAplForDiscon);
                }
            }
        }

        private void dataGridView_0_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = e.RowIndex; i < (e.RowIndex + e.RowCount); i++)
            {
                if (!((OrgDataSet.Class410) ((DataRowView) this.bindingSource_0[i]).Row).method_12())
                {
                    if (this.list_0.Count <= ((OrgDataSet.Class410) ((DataRowView) this.bindingSource_0[i]).Row).NetArea)
                    {
                        this.dataGridView_0.Rows[i].Cells[3].Value = string.Empty;
                    }
                    else
                    {
                        this.dataGridView_0.Rows[i].Cells[3].Value = this.list_0[((OrgDataSet.Class410) ((DataRowView) this.bindingSource_0[i]).Row).NetArea];
                    }
                }
                if (!((OrgDataSet.Class410) ((DataRowView) this.bindingSource_0[i]).Row).method_14())
                {
                    switch (((OrgDataSet.Class410) ((DataRowView) this.bindingSource_0[i]).Row).TypeAction)
                    {
                        case 0:
                            this.dataGridView_0.Rows[i].Cells[4].Value = "ОТКЛЮЧЕНИЕ";
                            break;

                        case 1:
                            this.dataGridView_0.Rows[i].Cells[4].Value = "ВОЗОБНОВЛЕНИЕ";
                            break;

                        case 2:
                            this.dataGridView_0.Rows[i].Cells[4].Value = "ОТМЕНА";
                            break;
                    }
                }
                if (!((OrgDataSet.Class410) ((DataRowView) this.bindingSource_0[i]).Row).method_26())
                {
                    if (((OrgDataSet.Class410) ((DataRowView) this.bindingSource_0[i]).Row).method_6())
                    {
                        this.dataGridView_0.Rows[i].Cells[0].Value = Resources.legaluser;
                    }
                    else
                    {
                        this.dataGridView_0.Rows[i].Cells[0].Value = Resources.individualuser;
                    }
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

        private void formFilter_0_Deactivate(object sender, EventArgs e)
        {
            this.method_0();
        }

        private void FormList_Load(object sender, EventArgs e)
        {
            this.class202_0.vmethod_0(this.orgDataSet_0.tblAbnAplForDiscon);
            this.formFilter_0.ShowDoNotDisplayZone = false;
            this.formFilter_0.ShowPeriodExecutionApplication = false;
            this.formFilter_0.Deactivate += new EventHandler(this.formFilter_0_Deactivate);
            this.formFilter_0.Legal = true;
            this.formFilter_0.Individual = true;
            this.formFilter_0.UsePeriod = true;
            this.formFilter_0.BeginningOfPeriod = DateTime.Today.AddDays((double) (-1 * (DateTime.Today.Day - 1)));
            this.formFilter_0.EndOfPeriod = DateTime.Today.AddDays((double) (DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month) - DateTime.Today.Day));
            this.formFilter_0.Disconnection = true;
            this.formFilter_0.Resumption = true;
            this.formFilter_0.Cancel = true;
            this.formFilter_0.ShowNetArea = false;
            SqlConnection connection = new SqlConnection(SqlDataConnect.GetConnectionString(this.get_SqlSettings()));
            connection.Open();
            SqlDataReader reader = new SqlCommand("select top 1 * from tSettings where Module = 'RequestODS'", connection).ExecuteReader();
            if (reader.Read())
            {
                XmlDocument document1 = new XmlDocument();
                document1.LoadXml(reader["Settings"].ToString());
                foreach (XmlNode node in document1.SelectSingleNode("ApplSet").SelectNodes("NetArea"))
                {
                    this.list_0.Add(node.Attributes["Name"].Value);
                }
            }
            this.method_0();
        }

        private void method_0()
        {
            List<string> list = new List<string>();
            if (this.formFilter_0.UsePeriod)
            {
                string[] textArray1 = new string[] { "DateAppl>='", this.formFilter_0.BeginningOfPeriod.ToString(), "' and DateAppl<='", this.formFilter_0.EndOfPeriod.ToString(), "'" };
                string item = string.Concat(textArray1);
                list.Add(item);
            }
            if (!this.formFilter_0.Legal)
            {
                list.Add("LegalAbns <> True");
            }
            if (!this.formFilter_0.Individual)
            {
                list.Add("LegalAbns <> false");
            }
            if (!this.formFilter_0.Disconnection)
            {
                list.Add("TypeAction<>0");
            }
            if (!this.formFilter_0.Resumption)
            {
                list.Add("TypeAction<>1");
            }
            if (!this.formFilter_0.Cancel)
            {
                list.Add("TypeAction<>2");
            }
            if (list.Count == 0)
            {
                this.bindingSource_0.RemoveFilter();
            }
            else
            {
                StringBuilder builder = new StringBuilder();
                bool flag = false;
                foreach (string str2 in list)
                {
                    if (flag)
                    {
                        builder.Append(" AND ");
                    }
                    else
                    {
                        flag = true;
                    }
                    builder.Append(str2);
                }
                this.bindingSource_0.Filter = builder.ToString();
            }
        }

        private void method_1()
        {
            this.icontainer_0 = new Container();
            this.dataGridView_0 = new DataGridView();
            this.dataGridViewImageColumn_0 = new DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
            this.bindingSource_0 = new BindingSource(this.icontainer_0);
            this.orgDataSet_0 = new OrgDataSet();
            this.toolStrip_0 = new ToolStrip();
            this.toolStripButton_3 = new ToolStripButton();
            this.toolStripButton_4 = new ToolStripButton();
            this.toolStripButton_5 = new ToolStripButton();
            this.toolStripButton_6 = new ToolStripButton();
            this.toolStrip_1 = new ToolStrip();
            this.toolStripButton_0 = new ToolStripButton();
            this.toolStripButton_2 = new ToolStripButton();
            this.toolStripButton_1 = new ToolStripButton();
            this.class202_0 = new Class202();
            ((ISupportInitialize) this.dataGridView_0).BeginInit();
            ((ISupportInitialize) this.bindingSource_0).BeginInit();
            this.orgDataSet_0.BeginInit();
            this.toolStrip_0.SuspendLayout();
            this.toolStrip_1.SuspendLayout();
            base.SuspendLayout();
            this.dataGridView_0.AllowUserToAddRows = false;
            this.dataGridView_0.AllowUserToDeleteRows = false;
            this.dataGridView_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.dataGridView_0.AutoGenerateColumns = false;
            this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewImageColumn_0, this.dataGridViewTextBoxColumn_0, this.dataGridViewTextBoxColumn_1, this.dataGridViewTextBoxColumn_2, this.dataGridViewTextBoxColumn_3, this.dataGridViewTextBoxColumn_4 };
            this.dataGridView_0.Columns.AddRange(dataGridViewColumns);
            this.dataGridView_0.DataSource = this.bindingSource_0;
            this.dataGridView_0.Location = new Point(12, 0x35);
            this.dataGridView_0.MultiSelect = false;
            this.dataGridView_0.Name = "dataGridViewDocList";
            this.dataGridView_0.ReadOnly = true;
            this.dataGridView_0.RowHeadersWidth = 0x19;
            this.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_0.Size = new Size(0x235, 0x199);
            this.dataGridView_0.TabIndex = 0;
            this.dataGridView_0.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView_0_CellDoubleClick);
            this.dataGridView_0.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dataGridView_0_RowsAdded);
            this.dataGridViewImageColumn_0.HeaderText = "";
            this.dataGridViewImageColumn_0.Name = "TypeAbn";
            this.dataGridViewImageColumn_0.ReadOnly = true;
            this.dataGridViewImageColumn_0.Width = 0x18;
            this.dataGridViewTextBoxColumn_0.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn_0.HeaderText = "Номер распоряжения";
            this.dataGridViewTextBoxColumn_0.Name = "numDocDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewTextBoxColumn_0.Width = 0x55;
            this.dataGridViewTextBoxColumn_1.DataPropertyName = "DateAppl";
            this.dataGridViewTextBoxColumn_1.HeaderText = "Дата распоряжения";
            this.dataGridViewTextBoxColumn_1.Name = "dateApplDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_1.ReadOnly = true;
            this.dataGridViewTextBoxColumn_1.Width = 110;
            this.dataGridViewTextBoxColumn_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_2.DataPropertyName = "NetAreaCaption";
            this.dataGridViewTextBoxColumn_2.HeaderText = "Сетевой район/ОДС ";
            this.dataGridViewTextBoxColumn_2.Name = "netAreaCaptionDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_2.ReadOnly = true;
            this.dataGridViewTextBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_3.DataPropertyName = "TypeActionCaption";
            this.dataGridViewTextBoxColumn_3.HeaderText = "Вид заявки";
            this.dataGridViewTextBoxColumn_3.Name = "typeActionCaptionDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_3.ReadOnly = true;
            this.dataGridViewTextBoxColumn_4.DataPropertyName = "DateAction";
            this.dataGridViewTextBoxColumn_4.HeaderText = "Дата и время выполнения";
            this.dataGridViewTextBoxColumn_4.Name = "dateActionDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_4.ReadOnly = true;
            this.dataGridViewTextBoxColumn_4.Width = 110;
            this.bindingSource_0.DataMember = "tblAbnAplForDiscon";
            this.bindingSource_0.DataSource = this.orgDataSet_0;
            this.orgDataSet_0.DataSetName = "OrgDataSet";
            this.orgDataSet_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripButton_3, this.toolStripButton_4, this.toolStripButton_5, this.toolStripButton_6 };
            this.toolStrip_0.Items.AddRange(toolStripItems);
            this.toolStrip_0.Location = new Point(0, 0);
            this.toolStrip_0.Name = "toolStripEditTheList";
            this.toolStrip_0.Size = new Size(0x24d, 0x19);
            this.toolStrip_0.TabIndex = 1;
            this.toolStrip_0.Text = "toolStrip1";
            this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_3.Image = Resources.filter;
            this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_3.Name = "toolStripButton1";
            this.toolStripButton_3.Size = new Size(0x17, 0x16);
            this.toolStripButton_3.Text = "Фильтр";
            this.toolStripButton_3.Click += new EventHandler(this.toolStripButton_3_Click);
            this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_4.Image = Resources.Find;
            this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_4.Name = "toolStripButtonOpenSearchForm";
            this.toolStripButton_4.Size = new Size(0x17, 0x16);
            this.toolStripButton_4.Text = "Открыть окно поиска";
            this.toolStripButton_4.Click += new EventHandler(this.toolStripButton_4_Click);
            this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_5.Image = Resources.filter_delete;
            this.toolStripButton_5.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_5.Name = "toolStripButton2";
            this.toolStripButton_5.Size = new Size(0x17, 0x16);
            this.toolStripButton_5.Text = "Сброс фильтра и поиска";
            this.toolStripButton_5.Click += new EventHandler(this.toolStripButton_5_Click);
            this.toolStripButton_6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_6.Image = Resources.Setting;
            this.toolStripButton_6.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_6.Name = "toolStripButton3";
            this.toolStripButton_6.Size = new Size(0x17, 0x16);
            this.toolStripButton_6.Text = "Настройки";
            this.toolStripButton_6.Click += new EventHandler(this.toolStripButton_6_Click);
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.toolStripButton_0, this.toolStripButton_2, this.toolStripButton_1 };
            this.toolStrip_1.Items.AddRange(itemArray2);
            this.toolStrip_1.Location = new Point(0, 0x19);
            this.toolStrip_1.Name = "toolStripEditTheRecord";
            this.toolStrip_1.Size = new Size(0x24d, 0x19);
            this.toolStrip_1.TabIndex = 2;
            this.toolStrip_1.Text = "toolStrip2";
            this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_0.Image = Resources.legal_add;
            this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_0.Name = "toolStripButtonAddLegal";
            this.toolStripButton_0.Size = new Size(0x17, 0x16);
            this.toolStripButton_0.Text = "Добавить заявление на юридические лица";
            this.toolStripButton_0.Click += new EventHandler(this.toolStripButton_0_Click);
            this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_2.Image = Resources.individual_add;
            this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_2.Name = "toolStripButtonAddindIvidual";
            this.toolStripButton_2.Size = new Size(0x17, 0x16);
            this.toolStripButton_2.Text = "Добавить заявление на физические лица";
            this.toolStripButton_2.Click += new EventHandler(this.toolStripButton_2_Click);
            this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_1.Image = Resources.ButtonEdit;
            this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_1.Name = "toolStripButtonEdit";
            this.toolStripButton_1.Size = new Size(0x17, 0x16);
            this.toolStripButton_1.Text = "Редактировать";
            this.toolStripButton_1.Click += new EventHandler(this.toolStripButton_1_Click);
            this.class202_0.method_7(true);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x24d, 0x1da);
            base.Controls.Add(this.toolStrip_1);
            base.Controls.Add(this.toolStrip_0);
            base.Controls.Add(this.dataGridView_0);
            base.Name = "FormList";
            this.Text = "Список заявлений";
            base.Load += new EventHandler(this.FormList_Load);
            ((ISupportInitialize) this.dataGridView_0).EndInit();
            ((ISupportInitialize) this.bindingSource_0).EndInit();
            this.orgDataSet_0.EndInit();
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            this.toolStrip_1.ResumeLayout(false);
            this.toolStrip_1.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void toolStripButton_0_Click(object sender, EventArgs e)
        {
            if (this.list_0.Count == 0)
            {
                MessageBox.Show("В настройках не указан список адресатов заявок");
            }
            else
            {
                this.bindingSource_0.AddNew();
                OrgDataSet.Class410 row = (OrgDataSet.Class410) ((DataRowView) this.bindingSource_0.Current).Row;
                row.TypeAction = 0;
                row.NetArea = 0;
                row.DateAppl = DateTime.Now;
                row.DateAction = DateTime.Today.AddDays(2.0).AddHours(9.0);
                new FormAddApplication(this, true, this.get_SqlSettings()) { tblAbnAplForDisconBindingSource = { 
                    DataSource = this.bindingSource_0,
                    Filter = this.bindingSource_0.Filter,
                    Position = this.bindingSource_0.Position
                } }.ShowDialog();
                this.class202_0.vmethod_0(this.orgDataSet_0.tblAbnAplForDiscon);
            }
        }

        private void toolStripButton_1_Click(object sender, EventArgs e)
        {
            if (((OrgDataSet.Class410) ((DataRowView) this.bindingSource_0.Current).Row).method_6())
            {
                FormAddApplication application1 = new FormAddApplication(this, true, this.get_SqlSettings()) {
                    tblAbnAplForDisconBindingSource = { 
                        DataSource = this.bindingSource_0,
                        Filter = this.bindingSource_0.Filter,
                        Position = this.bindingSource_0.Position
                    }
                };
                if (application1.ShowDialog() == DialogResult.OK)
                {
                    this.class202_0.vmethod_0(this.orgDataSet_0.tblAbnAplForDiscon);
                }
            }
            else
            {
                FormAddApplication application2 = new FormAddApplication(this, false, this.get_SqlSettings()) {
                    tblAbnAplForDisconBindingSource = { 
                        DataSource = this.bindingSource_0,
                        Filter = this.bindingSource_0.Filter,
                        Position = this.bindingSource_0.Position
                    }
                };
                if (application2.ShowDialog() == DialogResult.OK)
                {
                    this.class202_0.vmethod_0(this.orgDataSet_0.tblAbnAplForDiscon);
                }
            }
        }

        private void toolStripButton_2_Click(object sender, EventArgs e)
        {
            if (this.list_0.Count == 0)
            {
                MessageBox.Show("В настройках не указан список адресатов заявок");
            }
            else
            {
                this.bindingSource_0.AddNew();
                OrgDataSet.Class410 row = (OrgDataSet.Class410) ((DataRowView) this.bindingSource_0.Current).Row;
                row.TypeAction = 0;
                row.NetArea = 0;
                row.DateAppl = DateTime.Today;
                row.DateAction = DateTime.Today.AddDays(2.0).AddHours(9.0);
                new FormAddApplication(this, false, this.get_SqlSettings()) { tblAbnAplForDisconBindingSource = { 
                    DataSource = this.bindingSource_0,
                    Filter = this.bindingSource_0.Filter,
                    Position = this.bindingSource_0.Position
                } }.ShowDialog();
                this.class202_0.vmethod_0(this.orgDataSet_0.tblAbnAplForDiscon);
            }
        }

        private void toolStripButton_3_Click(object sender, EventArgs e)
        {
            this.formFilter_0.Location = new Point((base.Location.X + 0x19) + base.MdiParent.Location.X, (base.Location.Y + 110) + base.MdiParent.Location.Y);
            this.formFilter_0.Show();
        }

        private void toolStripButton_4_Click(object sender, EventArgs e)
        {
            SearchForm form = new SearchForm {
                radioButtonLegal = { Checked = true },
                comboBoxSearchType = { SelectedIndex = 0 }
            };
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (form.radioButtonLegal.Checked)
                {
                    if (form.comboBoxSearchType.SelectedIndex == 0)
                    {
                        this.class202_0.vmethod_12(this.orgDataSet_0.tblAbnAplForDiscon, "%" + form.textBoxName.Text + "%");
                    }
                    else if (form.comboBoxSearchType.SelectedIndex == 1)
                    {
                        this.class202_0.vmethod_14(this.orgDataSet_0.tblAbnAplForDiscon, "%" + form.textBoxName.Text + "%");
                    }
                    else if (form.comboBoxSearchType.SelectedIndex == 2)
                    {
                        int num = -1;
                        try
                        {
                            num = Convert.ToInt32(form.textBoxName.Text);
                        }
                        catch
                        {
                        }
                        this.class202_0.vmethod_10(this.orgDataSet_0.tblAbnAplForDiscon, num);
                    }
                }
                else if (form.radioButtonIndiviual.Checked)
                {
                    if (form.comboBoxSearchType.SelectedIndex == 0)
                    {
                        this.class202_0.vmethod_8(this.orgDataSet_0.tblAbnAplForDiscon, "%" + form.textBoxName.Text + "%");
                    }
                    else if (form.comboBoxSearchType.SelectedIndex == 1)
                    {
                        this.class202_0.vmethod_4(this.orgDataSet_0.tblAbnAplForDiscon, "%" + form.textBoxName.Text + "%");
                    }
                    else if (form.comboBoxSearchType.SelectedIndex == 2)
                    {
                        int num2 = -1;
                        try
                        {
                            num2 = Convert.ToInt32(form.textBoxName.Text);
                        }
                        catch
                        {
                        }
                        this.class202_0.vmethod_6(this.orgDataSet_0.tblAbnAplForDiscon, new int?(num2));
                    }
                }
            }
        }

        private void toolStripButton_5_Click(object sender, EventArgs e)
        {
            this.class202_0.vmethod_0(this.orgDataSet_0.tblAbnAplForDiscon);
            this.formFilter_0.ShowDoNotDisplayZone = false;
            this.formFilter_0.ShowPeriodExecutionApplication = false;
            this.formFilter_0.Legal = true;
            this.formFilter_0.Individual = true;
            this.formFilter_0.UsePeriod = true;
            this.formFilter_0.BeginningOfPeriod = DateTime.Today.AddDays((double) (-1 * (DateTime.Today.Day - 1)));
            this.formFilter_0.EndOfPeriod = DateTime.Today.AddDays((double) (DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month) - DateTime.Today.Day));
            this.formFilter_0.Disconnection = true;
            this.formFilter_0.Resumption = true;
            this.formFilter_0.Cancel = true;
            this.formFilter_0.ShowNetArea = false;
            this.method_0();
        }

        private void toolStripButton_6_Click(object sender, EventArgs e)
        {
            FormApplicationsSetting setting1 = new FormApplicationsSetting();
            setting1.set_SqlSettings(this.get_SqlSettings());
            setting1.ShowDialog();
        }

        public int UpdatetblAbnAplForDisconTableAdapter()
        {
            return this.class202_0.vmethod_16(this.orgDataSet_0.tblAbnAplForDiscon);
        }

        public override SQLSettings SqlSettings
        {
            get
            {
                return base.get_SqlSettings();
            }
            set
            {
                base.set_SqlSettings(value);
                this.class202_0.method_1().ConnectionString = this.get_SqlSettings().GetConnectionString();
            }
        }
    }
}

