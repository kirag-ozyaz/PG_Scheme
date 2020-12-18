namespace Documents.Forms.JournalUpdateProgram
{
    using ControlsLbr.DataGridViewExcelFilter;
    using DataSql;
    using Documents.DataSets;
    using Documents.Properties;
    using FormLbr;
    using FormLbr.Classes;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;

    public class FormJournalUpdateProgram : FormBase
    {
        private BindingSource bindingSource_0;
        private BindingSource bindingSource_1;
        private ContextMenuStrip contextMenuStrip_0;
        private DataColumn dataColumn_0;
        private DataColumn dataColumn_1;
        private DataColumn dataColumn_2;
        private DataGridView dataGridView_0;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_0;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_1;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_2;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_3;
        private DataGridViewImageColumnNotNull dataGridViewImageColumnNotNull_0;
        private DataGridViewLinkColumn dataGridViewLinkColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;
        private DataSet dataSet_0;
        private DataSetGES dataSetGES_0;
        private DataTable dataTable_0;
        private DateTime dateTime_0 = DateTime.MinValue;
        private IContainer icontainer_0;
        private Label label_0;
        private RichTextBox richTextBox_0;
        private SplitContainer splitContainer_0;
        private ToolStrip toolStrip_0;
        private ToolStripButton toolStripButton_0;
        private ToolStripButton toolStripButton_1;
        private ToolStripButton toolStripButton_2;
        private ToolStripMenuItem toolStripMenuItem_0;
        private ToolStripMenuItem toolStripMenuItem_1;

        public FormJournalUpdateProgram()
        {
            this.method_1();
        }

        private void dataGridView_0_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView_0.CurrentRow != null)
            {
                int num = Convert.ToInt32(this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_1.Name].Value);
                if (e.ColumnIndex == this.dataGridView_0.Columns[this.dataGridViewLinkColumn_0.Name].Index)
                {
                    byte[] buffer = (byte[]) this.dataSetGES_0.tJ_UpdateProgramDoc.method_2(num)["Document"];
                    string path = Path.ChangeExtension(Path.GetTempFileName(), Path.GetExtension(this.dataSetGES_0.tJ_UpdateProgramDoc.method_2(num)["FileName"].ToString()));
                    FileStream stream1 = File.Create(path);
                    stream1.Write(buffer, 0, buffer.Length);
                    stream1.Close();
                    try
                    {
                        new Process { StartInfo = { 
                            FileName = path,
                            UseShellExecute = true
                        } }.Start();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, exception.Source);
                    }
                }
            }
        }

        private void dataGridView_0_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Right) && (e.RowIndex >= 0))
            {
                this.dataGridView_0.Rows[e.RowIndex].Selected = true;
                this.dataGridView_0.CurrentCell = this.dataGridView_0[this.dataGridViewImageColumnNotNull_0.Name, e.RowIndex];
                this.contextMenuStrip_0.Show(Cursor.Position);
            }
        }

        private void dataGridView_0_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if ((this.dataGridView_0.RowCount > 0) && (this.dataGridView_0[this.dataGridViewTextBoxColumn_0.Name, e.RowIndex].Value != null))
            {
                if (e.ColumnIndex == this.dataGridView_0.Columns[this.dataGridViewLinkColumn_0.Name].Index)
                {
                    e.Value = Path.GetFileName(this.dataGridView_0[this.dataGridViewTextBoxColumn_0.Name, e.RowIndex].Value.ToString());
                }
                if (e.ColumnIndex == this.dataGridView_0.Columns[this.dataGridViewImageColumnNotNull_0.Name].Index)
                {
                    Icon icon = FileInfo.IconOfFile(this.dataGridView_0[this.dataGridViewTextBoxColumn_0.Name, e.RowIndex].Value.ToString());
                    if (icon != null)
                    {
                        e.Value = icon.ToBitmap();
                    }
                }
            }
        }

        private void dataGridViewExcelFilter_0_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.RowIndex >= 0) && (Convert.ToDateTime(this.dataGridViewExcelFilter_0[this.dataGridViewFilterTextBoxColumn_0.Name, e.RowIndex].Value) > this.dateTime_0))
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
            }
        }

        private void dataGridViewExcelFilter_0_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_UpdateProgramDoc, true, " where idUpdate = " + Convert.ToInt32(this.dataGridViewExcelFilter_0[this.dataGridViewTextBoxColumn_2.Name, e.RowIndex].Value).ToString() + " order by filename");
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

        private void FormJournalUpdateProgram_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_UpdateProgramUserCheck, true, "where Login = SYSTEM_USER");
            if (this.dataSetGES_0.tJ_UpdateProgramUserCheck.Rows.Count > 0)
            {
                this.dataSetGES_0.tJ_UpdateProgramUserCheck.Rows[0]["dateCheck"] = DateTime.Now;
                this.dataSetGES_0.tJ_UpdateProgramUserCheck.Rows[0].EndEdit();
                base.UpdateSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_UpdateProgramUserCheck);
            }
            else
            {
                SqlDataConnect connect = new SqlDataConnect();
                connect.OpenConnection(this.get_SqlSettings());
                SqlCommand command = new SqlCommand("select SYSTEM_USER", connect.get_Connection());
                object obj2 = command.ExecuteScalar();
                string[] textArray1 = new string[] { "insert into tJ_UpdateProgramUserCheck (login, dateCheck) values('", obj2.ToString(), "' , '", DateTime.Now.ToString("yyyyMMdd HH:mm"), "')" };
                command.CommandText = string.Concat(textArray1);
                command.ExecuteNonQuery();
            }
        }

        private void FormJournalUpdateProgram_Load(object sender, EventArgs e)
        {
            this.method_0();
            base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_UpdateProgramUserCheck, true, "where Login = SYSTEM_USER");
            if (this.dataSetGES_0.tJ_UpdateProgramUserCheck.Rows.Count > 0)
            {
                this.dateTime_0 = Convert.ToDateTime(this.dataSetGES_0.tJ_UpdateProgramUserCheck.Rows[0]["dateCheck"]);
            }
        }

        private void method_0()
        {
            base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.vJ_UpdateProgram, true, " where dateUpdate < getdate() order by dateUpdate Desc");
        }

        private void method_1()
        {
            this.icontainer_0 = new Container();
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            DataGridViewCellStyle style3 = new DataGridViewCellStyle();
            DataGridViewCellStyle style4 = new DataGridViewCellStyle();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(FormJournalUpdateProgram));
            this.toolStrip_0 = new ToolStrip();
            this.toolStripButton_0 = new ToolStripButton();
            this.toolStripButton_1 = new ToolStripButton();
            this.toolStripButton_2 = new ToolStripButton();
            this.bindingSource_0 = new BindingSource(this.icontainer_0);
            this.dataSetGES_0 = new DataSetGES();
            this.splitContainer_0 = new SplitContainer();
            this.dataGridViewExcelFilter_0 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.bindingSource_1 = new BindingSource(this.icontainer_0);
            this.dataGridView_0 = new DataGridView();
            this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
            this.dataGridViewImageColumnNotNull_0 = new DataGridViewImageColumnNotNull();
            this.dataGridViewLinkColumn_0 = new DataGridViewLinkColumn();
            this.label_0 = new Label();
            this.richTextBox_0 = new RichTextBox();
            this.dataSet_0 = new DataSet();
            this.dataTable_0 = new DataTable();
            this.dataColumn_0 = new DataColumn();
            this.dataColumn_1 = new DataColumn();
            this.dataColumn_2 = new DataColumn();
            this.contextMenuStrip_0 = new ContextMenuStrip(this.icontainer_0);
            this.toolStripMenuItem_0 = new ToolStripMenuItem();
            this.toolStripMenuItem_1 = new ToolStripMenuItem();
            this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_1 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_2 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_3 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
            this.toolStrip_0.SuspendLayout();
            ((ISupportInitialize) this.bindingSource_0).BeginInit();
            this.dataSetGES_0.BeginInit();
            this.splitContainer_0.Panel1.SuspendLayout();
            this.splitContainer_0.Panel2.SuspendLayout();
            this.splitContainer_0.SuspendLayout();
            this.dataGridViewExcelFilter_0.BeginInit();
            ((ISupportInitialize) this.bindingSource_1).BeginInit();
            ((ISupportInitialize) this.dataGridView_0).BeginInit();
            this.dataSet_0.BeginInit();
            this.dataTable_0.BeginInit();
            this.contextMenuStrip_0.SuspendLayout();
            base.SuspendLayout();
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripButton_0, this.toolStripButton_1, this.toolStripButton_2 };
            this.toolStrip_0.Items.AddRange(toolStripItems);
            this.toolStrip_0.Location = new Point(0, 0);
            this.toolStrip_0.Name = "toolStrip";
            this.toolStrip_0.Size = new Size(0x3b4, 0x19);
            this.toolStrip_0.TabIndex = 0;
            this.toolStrip_0.Text = "toolStrip1";
            this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_0.Image = Resources.ElementAdd;
            this.toolStripButton_0.ImageTransparentColor = Color.Transparent;
            this.toolStripButton_0.Name = "toolBtnAdd";
            this.toolStripButton_0.Size = new Size(0x17, 0x16);
            this.toolStripButton_0.Text = "Добавить";
            this.toolStripButton_0.Click += new EventHandler(this.toolStripButton_0_Click);
            this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_1.Image = Resources.ElementEdit;
            this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_1.Name = "toolBtnEdit";
            this.toolStripButton_1.Size = new Size(0x17, 0x16);
            this.toolStripButton_1.Text = "Изменить";
            this.toolStripButton_1.Click += new EventHandler(this.toolStripButton_1_Click);
            this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_2.Image = Resources.ElementDel;
            this.toolStripButton_2.ImageTransparentColor = Color.Transparent;
            this.toolStripButton_2.Name = "toolBtnDel";
            this.toolStripButton_2.Size = new Size(0x17, 0x16);
            this.toolStripButton_2.Text = "Удалить задачу";
            this.toolStripButton_2.Click += new EventHandler(this.toolStripButton_2_Click);
            this.bindingSource_0.DataMember = "vJ_Request";
            this.bindingSource_0.DataSource = this.dataSetGES_0;
            this.bindingSource_0.Sort = "DateTask desc";
            this.dataSetGES_0.DataSetName = "DataSetGES";
            this.dataSetGES_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.splitContainer_0.Dock = DockStyle.Fill;
            this.splitContainer_0.FixedPanel = FixedPanel.Panel2;
            this.splitContainer_0.Location = new Point(0, 0x19);
            this.splitContainer_0.Name = "splitContainer";
            this.splitContainer_0.Panel1.Controls.Add(this.dataGridViewExcelFilter_0);
            this.splitContainer_0.Panel2.Controls.Add(this.dataGridView_0);
            this.splitContainer_0.Panel2.Controls.Add(this.label_0);
            this.splitContainer_0.Panel2.Controls.Add(this.richTextBox_0);
            this.splitContainer_0.Panel2.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.splitContainer_0.Size = new Size(0x3b4, 0x1b7);
            this.splitContainer_0.SplitterDistance = 0x1b4;
            this.splitContainer_0.TabIndex = 1;
            this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToOrderColumns = true;
            this.dataGridViewExcelFilter_0.set_AllowUserToVisibleColumns(false);
            style.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dataGridViewExcelFilter_0.AlternatingRowsDefaultCellStyle = style;
            this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
            this.dataGridViewExcelFilter_0.BackgroundColor = Color.White;
            this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_2, this.dataGridViewFilterTextBoxColumn_0, this.dataGridViewFilterTextBoxColumn_1, this.dataGridViewFilterTextBoxColumn_2, this.dataGridViewFilterTextBoxColumn_3, this.dataGridViewTextBoxColumn_3 };
            this.dataGridViewExcelFilter_0.Columns.AddRange(dataGridViewColumns);
            this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_1;
            this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_0.Location = new Point(0, 0);
            this.dataGridViewExcelFilter_0.Name = "dgvUpdate";
            this.dataGridViewExcelFilter_0.ReadOnly = true;
            this.dataGridViewExcelFilter_0.RowHeadersWidth = 0x15;
            this.dataGridViewExcelFilter_0.Size = new Size(0x1b4, 0x1b7);
            this.dataGridViewExcelFilter_0.TabIndex = 0;
            this.dataGridViewExcelFilter_0.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridViewExcelFilter_0_CellFormatting);
            this.dataGridViewExcelFilter_0.RowEnter += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_0_RowEnter);
            this.bindingSource_1.DataMember = "vJ_UpdateProgram";
            this.bindingSource_1.DataSource = this.dataSetGES_0;
            this.bindingSource_1.Sort = "DateUpdate desc";
            this.dataGridView_0.AllowUserToAddRows = false;
            this.dataGridView_0.AllowUserToDeleteRows = false;
            this.dataGridView_0.AllowUserToResizeColumns = false;
            this.dataGridView_0.AllowUserToResizeRows = false;
            this.dataGridView_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.dataGridView_0.AutoGenerateColumns = false;
            this.dataGridView_0.BackgroundColor = SystemColors.Control;
            this.dataGridView_0.BorderStyle = BorderStyle.None;
            this.dataGridView_0.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_0.ColumnHeadersVisible = false;
            DataGridViewColumn[] columnArray2 = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_0, this.dataGridViewTextBoxColumn_1, this.dataGridViewImageColumnNotNull_0, this.dataGridViewLinkColumn_0 };
            this.dataGridView_0.Columns.AddRange(columnArray2);
            this.dataGridView_0.DataMember = "tJ_UpdateProgramDoc";
            this.dataGridView_0.DataSource = this.dataSetGES_0;
            style2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style2.BackColor = SystemColors.Control;
            style2.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style2.ForeColor = SystemColors.ControlText;
            style2.SelectionBackColor = SystemColors.Highlight;
            style2.SelectionForeColor = SystemColors.HighlightText;
            style2.WrapMode = DataGridViewTriState.False;
            this.dataGridView_0.DefaultCellStyle = style2;
            this.dataGridView_0.GridColor = SystemColors.Control;
            this.dataGridView_0.Location = new Point(2, 0x12e);
            this.dataGridView_0.MultiSelect = false;
            this.dataGridView_0.Name = "dgvDocs";
            this.dataGridView_0.ReadOnly = true;
            this.dataGridView_0.RowHeadersVisible = false;
            this.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_0.Size = new Size(0x1fa, 0x89);
            this.dataGridView_0.TabIndex = 15;
            this.dataGridView_0.VirtualMode = true;
            this.dataGridView_0.CellContentClick += new DataGridViewCellEventHandler(this.dataGridView_0_CellContentClick);
            this.dataGridView_0.CellMouseClick += new DataGridViewCellMouseEventHandler(this.dataGridView_0_CellMouseClick);
            this.dataGridView_0.CellValueNeeded += new DataGridViewCellValueEventHandler(this.dataGridView_0_CellValueNeeded);
            this.dataGridViewTextBoxColumn_0.DataPropertyName = "FileName";
            this.dataGridViewTextBoxColumn_0.HeaderText = "FileName";
            this.dataGridViewTextBoxColumn_0.Name = "fileNameDgvTxtColumn";
            this.dataGridViewTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewTextBoxColumn_0.Visible = false;
            this.dataGridViewTextBoxColumn_1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn_1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn_1.Name = "IdDocDgvTxtColumn";
            this.dataGridViewTextBoxColumn_1.ReadOnly = true;
            this.dataGridViewTextBoxColumn_1.Visible = false;
            style3.NullValue = null;
            this.dataGridViewImageColumnNotNull_0.DefaultCellStyle = style3;
            this.dataGridViewImageColumnNotNull_0.HeaderText = "";
            this.dataGridViewImageColumnNotNull_0.ImageLayout = DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumnNotNull_0.Name = "ColumnImage";
            this.dataGridViewImageColumnNotNull_0.ReadOnly = true;
            this.dataGridViewImageColumnNotNull_0.Width = 30;
            this.dataGridViewLinkColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewLinkColumn_0.HeaderText = "Файл";
            this.dataGridViewLinkColumn_0.Name = "shortFileNameDgvTxtColumn";
            this.dataGridViewLinkColumn_0.ReadOnly = true;
            this.dataGridViewLinkColumn_0.Resizable = DataGridViewTriState.True;
            this.dataGridViewLinkColumn_0.SortMode = DataGridViewColumnSortMode.Automatic;
            this.label_0.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.label_0.AutoSize = true;
            this.label_0.Location = new Point(3, 0x114);
            this.label_0.Name = "label1";
            this.label_0.Size = new Size(0xa4, 0x11);
            this.label_0.TabIndex = 0x11;
            this.label_0.Text = "Прикрепленные файлы";
            this.richTextBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.richTextBox_0.BackColor = SystemColors.Window;
            this.richTextBox_0.DataBindings.Add(new Binding("Text", this.bindingSource_1, "TextUpdate", true));
            this.richTextBox_0.Location = new Point(2, 0);
            this.richTextBox_0.Name = "richTextBox";
            this.richTextBox_0.ReadOnly = true;
            this.richTextBox_0.Size = new Size(0x1fa, 0x111);
            this.richTextBox_0.TabIndex = 0x10;
            this.richTextBox_0.Text = "";
            this.dataSet_0.DataSetName = "NewDataSet";
            DataTable[] tables = new DataTable[] { this.dataTable_0 };
            this.dataSet_0.Tables.AddRange(tables);
            DataColumn[] columns = new DataColumn[] { this.dataColumn_0, this.dataColumn_1, this.dataColumn_2 };
            this.dataTable_0.Columns.AddRange(columns);
            this.dataTable_0.TableName = "tJ_RequestDoc";
            this.dataColumn_0.ColumnName = "Id";
            this.dataColumn_0.DataType = typeof(int);
            this.dataColumn_1.ColumnName = "IdRequest";
            this.dataColumn_1.DataType = typeof(int);
            this.dataColumn_2.ColumnName = "FileName";
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.toolStripMenuItem_0, this.toolStripMenuItem_1 };
            this.contextMenuStrip_0.Items.AddRange(itemArray2);
            this.contextMenuStrip_0.Name = "contextMenuDgvDoc";
            this.contextMenuStrip_0.Size = new Size(0x86, 0x30);
            this.toolStripMenuItem_0.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold);
            this.toolStripMenuItem_0.Name = "toolMenuOpen";
            this.toolStripMenuItem_0.Size = new Size(0x85, 0x16);
            this.toolStripMenuItem_0.Text = "Открыть";
            this.toolStripMenuItem_0.Click += new EventHandler(this.toolStripMenuItem_0_Click);
            this.toolStripMenuItem_1.Image = Resources.save;
            this.toolStripMenuItem_1.Name = "toolMenuSave";
            this.toolStripMenuItem_1.Size = new Size(0x85, 0x16);
            this.toolStripMenuItem_1.Text = "Сохранить";
            this.toolStripMenuItem_1.Click += new EventHandler(this.toolStripMenuItem_1_Click);
            this.dataGridViewTextBoxColumn_2.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_2.HeaderText = "id";
            this.dataGridViewTextBoxColumn_2.Name = "idDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_2.ReadOnly = true;
            this.dataGridViewTextBoxColumn_2.Visible = false;
            this.dataGridViewFilterTextBoxColumn_0.DataPropertyName = "DateUpdate";
            style4.Format = "d";
            style4.NullValue = null;
            this.dataGridViewFilterTextBoxColumn_0.DefaultCellStyle = style4;
            this.dataGridViewFilterTextBoxColumn_0.HeaderText = "Дата";
            this.dataGridViewFilterTextBoxColumn_0.Name = "dateUpdateDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_0.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_0.Width = 70;
            this.dataGridViewFilterTextBoxColumn_1.DataPropertyName = "Modul";
            this.dataGridViewFilterTextBoxColumn_1.HeaderText = "Модуль";
            this.dataGridViewFilterTextBoxColumn_1.Name = "modulDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_1.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_1.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_1.Visible = false;
            this.dataGridViewFilterTextBoxColumn_2.DataPropertyName = "modulname";
            this.dataGridViewFilterTextBoxColumn_2.HeaderText = "Модуль";
            this.dataGridViewFilterTextBoxColumn_2.Name = "modulnameDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_2.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_2.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewFilterTextBoxColumn_3.DataPropertyName = "Description";
            this.dataGridViewFilterTextBoxColumn_3.HeaderText = "Обновление";
            this.dataGridViewFilterTextBoxColumn_3.Name = "descriptionDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_3.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_3.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_3.DataPropertyName = "TextUpdate";
            this.dataGridViewTextBoxColumn_3.HeaderText = "TextUpdate";
            this.dataGridViewTextBoxColumn_3.Name = "textUpdateDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_3.ReadOnly = true;
            this.dataGridViewTextBoxColumn_3.Visible = false;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x3b4, 0x1d0);
            base.Controls.Add(this.splitContainer_0);
            base.Controls.Add(this.toolStrip_0);
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Name = "FormJournalUpdateProgram";
            this.Text = "Журнал обновлений";
            base.FormClosing += new FormClosingEventHandler(this.FormJournalUpdateProgram_FormClosing);
            base.Load += new EventHandler(this.FormJournalUpdateProgram_Load);
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            ((ISupportInitialize) this.bindingSource_0).EndInit();
            this.dataSetGES_0.EndInit();
            this.splitContainer_0.Panel1.ResumeLayout(false);
            this.splitContainer_0.Panel2.ResumeLayout(false);
            this.splitContainer_0.Panel2.PerformLayout();
            this.splitContainer_0.ResumeLayout(false);
            this.dataGridViewExcelFilter_0.EndInit();
            ((ISupportInitialize) this.bindingSource_1).EndInit();
            ((ISupportInitialize) this.dataGridView_0).EndInit();
            this.dataSet_0.EndInit();
            this.dataTable_0.EndInit();
            this.contextMenuStrip_0.ResumeLayout(false);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void toolStripButton_0_Click(object sender, EventArgs e)
        {
            Form36 form1 = new Form36(-1);
            form1.set_SqlSettings(this.get_SqlSettings());
            if (form1.ShowDialog() == DialogResult.OK)
            {
                this.method_0();
            }
        }

        private void toolStripButton_1_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_0.CurrentRow == null)
            {
                MessageBox.Show("Не выбран документ для редактирования");
            }
            else
            {
                int num = Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_2.Name].Value);
                Form36 form1 = new Form36(num);
                form1.set_SqlSettings(this.get_SqlSettings());
                if (form1.ShowDialog() == DialogResult.OK)
                {
                    this.method_0();
                    this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewTextBoxColumn_2.Name, num.ToString(), false);
                }
            }
        }

        private void toolStripButton_2_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_0.CurrentRow == null)
            {
                MessageBox.Show("Не выбран документ для удаления");
            }
            else if (MessageBox.Show("Вы действительно хотите удалить текущий документ?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int num = Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_2.Name].Value);
                this.dataGridViewExcelFilter_0.Rows.Remove(this.dataGridViewExcelFilter_0.CurrentRow);
                base.DeleteSqlDataById(this.dataSetGES_0.tJ_UpdateProgram, num);
            }
        }

        private void toolStripMenuItem_0_Click(object sender, EventArgs e)
        {
            if (this.dataGridView_0.CurrentRow != null)
            {
                int num = Convert.ToInt32(this.dataGridView_0.CurrentRow.Cells["idDocDgvTxtColumn"].Value);
                byte[] buffer = (byte[]) this.dataSetGES_0.tJ_RequestDoc.method_2(num)["Document"];
                string path = Path.ChangeExtension(Path.GetTempFileName(), Path.GetExtension(this.dataSetGES_0.tJ_RequestDoc.method_2(num)["FileName"].ToString()));
                FileStream stream1 = File.Create(path);
                stream1.Write(buffer, 0, buffer.Length);
                stream1.Close();
                new Process { StartInfo = { 
                    FileName = path,
                    UseShellExecute = true
                } }.Start();
            }
        }

        private void toolStripMenuItem_1_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(this.dataGridView_0.CurrentRow.Cells["idDocDgvTxtColumn"].Value);
                string path = this.dataGridView_0.CurrentRow.Cells["shortFileNameDgvTxtColumn"].Value.ToString();
                string extension = Path.GetExtension(path);
                SaveFileDialog dialog = new SaveFileDialog {
                    Filter = "(*" + extension + ")|*" + extension,
                    FileName = path
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    byte[] buffer = (byte[]) this.dataSetGES_0.tJ_RequestDoc.method_2(num)["Document"];
                    FileStream stream1 = File.Create(dialog.FileName);
                    stream1.Write(buffer, 0, buffer.Length);
                    stream1.Close();
                    MessageBox.Show("Файл успешно сохранен", "Сохранение");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source);
            }
        }
    }
}

