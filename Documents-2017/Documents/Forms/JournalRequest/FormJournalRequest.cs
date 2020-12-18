namespace Documents.Forms.JournalRequest
{
    using ControlsLbr;
    using ControlsLbr.DataGridViewExcelFilter;
    using Documents.DataSets;
    using Documents.Properties;
    using FormLbr;
    using FormLbr.Classes;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    public class FormJournalRequest : FormBase
    {
        private BindingSource bindingSource_0;
        private ContextMenuStrip contextMenuStrip_0;
        private DataColumn dataColumn_0;
        private DataColumn dataColumn_1;
        private DataColumn dataColumn_2;
        private DataGridView dataGridView_0;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_0;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_1;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_10;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_2;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_3;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_4;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_5;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_6;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_7;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_8;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_9;
        private DataGridViewImageColumnNotNull dataGridViewImageColumnNotNull_0;
        private DataGridViewLinkColumn dataGridViewLinkColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;
        private DataSet dataSet_0;
        private DataSetGES dataSetGES_0;
        private DataTable dataTable_0;
        private IContainer icontainer_0;
        private Label label_0;
        private Label label_1;
        private Panel panel_0;
        private RichTextBoxWithContextMenu richTextBoxWithContextMenu_0;
        private RichTextBoxWithContextMenu richTextBoxWithContextMenu_1;
        private SplitContainer splitContainer_0;
        private SplitContainer splitContainer_1;
        private SplitContainer splitContainer_2;
        private ToolStrip toolStrip_0;
        private ToolStripButton toolStripButton_0;
        private ToolStripButton toolStripButton_1;
        private ToolStripButton toolStripButton_2;
        private ToolStripButton toolStripButton_3;
        private ToolStripButton toolStripButton_4;
        private ToolStripButton toolStripButton_5;
        private ToolStripButton toolStripButton_6;
        private ToolStripMenuItem toolStripMenuItem_0;
        private ToolStripMenuItem toolStripMenuItem_1;
        private ToolStripSeparator toolStripSeparator_0;
        private ToolStripSeparator toolStripSeparator_1;
        private ToolStripSeparator toolStripSeparator_2;
        private ToolStripSeparator toolStripSeparator_3;

        public FormJournalRequest()
        {
            this.method_3();
        }

        private void bindingSource_0_CurrentChanged(object sender, EventArgs e)
        {
            if (this.bindingSource_0.Current != null)
            {
                int num = Convert.ToInt32(((DataRowView) this.bindingSource_0.Current)["id"]);
                DataTable table = new DataTable("vJ_Request");
                table.Columns.Add("TextTaskBin", typeof(byte[]));
                base.SelectSqlData(table, true, string.Format("where id = {0}", num), false);
                if ((table.Rows.Count > 0) && (table.Rows[0]["TextTaskBin"] != DBNull.Value))
                {
                    this.richTextBoxWithContextMenu_0.Rtf = smethod_0((byte[]) table.Rows[0]["TextTaskBin"]);
                }
                else
                {
                    this.richTextBoxWithContextMenu_0.Rtf = "";
                    if (((DataRowView) this.bindingSource_0.Current)["TextTask"] != DBNull.Value)
                    {
                        this.richTextBoxWithContextMenu_0.Text = ((DataRowView) this.bindingSource_0.Current)["TextTask"].ToString();
                    }
                    else
                    {
                        this.richTextBoxWithContextMenu_0.Text = "";
                    }
                }
                base.SelectSqlData(this.dataSet_0, this.dataSet_0.Tables["tJ_Requestdoc"], true, " where idRequest = " + num.ToString() + " order by filename");
            }
        }

        private void dataGridView_0_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView_0.CurrentRow != null)
            {
                int num = Convert.ToInt32(this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_1.Name].Value);
                if (e.ColumnIndex == this.dataGridView_0.Columns[this.dataGridViewLinkColumn_0.Name].Index)
                {
                    base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_RequestDoc, true, "where id = " + num.ToString());
                    byte[] buffer = (byte[]) this.dataSetGES_0.tJ_RequestDoc.method_2(num)["Document"];
                    string path = Path.ChangeExtension(Path.GetTempFileName(), Path.GetExtension(this.dataSetGES_0.tJ_RequestDoc.method_2(num)["FileName"].ToString()));
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
                this.dataGridView_0.CurrentCell = this.dataGridView_0["columnimage", e.RowIndex];
                this.contextMenuStrip_0.Show(Cursor.Position);
            }
        }

        private void dataGridView_0_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if ((this.dataGridView_0.RowCount > 0) && (this.dataGridView_0["filenameDgvTxtColumn", e.RowIndex].Value != null))
            {
                if (e.ColumnIndex == this.dataGridView_0.Columns["shortFileNameDgvTxtColumn"].Index)
                {
                    e.Value = Path.GetFileName(this.dataGridView_0["filenameDgvTxtColumn", e.RowIndex].Value.ToString());
                }
                if (e.ColumnIndex == this.dataGridView_0.Columns["ColumnImage"].Index)
                {
                    Icon icon = FileInfo.IconOfFile(this.dataGridView_0["filenameDgvTxtColumn", e.RowIndex].Value.ToString());
                    if (icon != null)
                    {
                        e.Value = icon.ToBitmap();
                    }
                }
            }
        }

        private void dataGridViewExcelFilter_0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int num = Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells["idDgvTxtColumn"].Value);
                Form39 form1 = new Form39(num, Form39.Enum10.const_1);
                form1.set_SqlSettings(this.get_SqlSettings());
                if (form1.ShowDialog() == DialogResult.OK)
                {
                    this.method_0(num);
                }
            }
        }

        private void dataGridViewExcelFilter_0_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (this.dataGridViewExcelFilter_0["nameStatusTaskDgvTxtColumn", e.RowIndex].Value.ToString() == "Выполненная")
                {
                    e.CellStyle.ForeColor = Color.Green;
                }
                if (this.dataGridViewExcelFilter_0["nameStatusTaskDgvTxtColumn", e.RowIndex].Value.ToString() == "Открытая")
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                if (this.dataGridViewExcelFilter_0["nameStatusTaskDgvTxtColumn", e.RowIndex].Value.ToString() == "Архивная")
                {
                    e.CellStyle.ForeColor = Color.Yellow;
                }
            }
        }

        private void dataGridViewExcelFilter_0_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormJournalRequest_Load(object sender, EventArgs e)
        {
            this.method_0(-1);
        }

        private void method_0(int int_0 = -1)
        {
            DataSetGES.vJ_RequestDataTable table = new DataSetGES.vJ_RequestDataTable();
            table.Columns.Remove("TextTaskBin");
            this.bindingSource_0.DataSource = table;
            base.SelectSqlData(table, true, "", false);
            if (int_0 != -1)
            {
                this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewTextBoxColumn_2.Name, int_0.ToString(), false);
            }
        }

        private void method_1(object sender, FormClosedEventArgs e)
        {
            Form39 form = (Form39) sender;
            if (form.DialogResult == DialogResult.OK)
            {
                this.method_0(form.method_0());
            }
        }

        private void method_2(object sender, FormClosedEventArgs e)
        {
            Form38 form = (Form38) sender;
            if (form.DialogResult == DialogResult.OK)
            {
                this.method_0(!form.method_0().HasValue ? -1 : form.method_0().Value);
            }
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
            ComponentResourceManager manager = new ComponentResourceManager(typeof(FormJournalRequest));
            this.toolStrip_0 = new ToolStrip();
            this.toolStripButton_0 = new ToolStripButton();
            this.toolStripButton_1 = new ToolStripButton();
            this.toolStripSeparator_0 = new ToolStripSeparator();
            this.toolStripButton_2 = new ToolStripButton();
            this.toolStripButton_3 = new ToolStripButton();
            this.toolStripSeparator_2 = new ToolStripSeparator();
            this.toolStripButton_5 = new ToolStripButton();
            this.toolStripSeparator_1 = new ToolStripSeparator();
            this.toolStripButton_4 = new ToolStripButton();
            this.toolStripSeparator_3 = new ToolStripSeparator();
            this.toolStripButton_6 = new ToolStripButton();
            this.bindingSource_0 = new BindingSource(this.icontainer_0);
            this.dataSetGES_0 = new DataSetGES();
            this.splitContainer_0 = new SplitContainer();
            this.dataGridViewExcelFilter_0 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_1 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_2 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_3 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_4 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_5 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_6 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_7 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_8 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_9 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_10 = new DataGridViewFilterTextBoxColumn();
            this.splitContainer_1 = new SplitContainer();
            this.splitContainer_2 = new SplitContainer();
            this.richTextBoxWithContextMenu_0 = new RichTextBoxWithContextMenu();
            this.panel_0 = new Panel();
            this.dataGridView_0 = new DataGridView();
            this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
            this.dataGridViewImageColumnNotNull_0 = new DataGridViewImageColumnNotNull();
            this.dataGridViewLinkColumn_0 = new DataGridViewLinkColumn();
            this.dataSet_0 = new DataSet();
            this.dataTable_0 = new DataTable();
            this.dataColumn_0 = new DataColumn();
            this.dataColumn_1 = new DataColumn();
            this.dataColumn_2 = new DataColumn();
            this.label_0 = new Label();
            this.richTextBoxWithContextMenu_1 = new RichTextBoxWithContextMenu();
            this.label_1 = new Label();
            this.contextMenuStrip_0 = new ContextMenuStrip(this.icontainer_0);
            this.toolStripMenuItem_0 = new ToolStripMenuItem();
            this.toolStripMenuItem_1 = new ToolStripMenuItem();
            this.toolStrip_0.SuspendLayout();
            ((ISupportInitialize) this.bindingSource_0).BeginInit();
            this.dataSetGES_0.BeginInit();
            this.splitContainer_0.Panel1.SuspendLayout();
            this.splitContainer_0.Panel2.SuspendLayout();
            this.splitContainer_0.SuspendLayout();
            this.dataGridViewExcelFilter_0.BeginInit();
            this.splitContainer_1.Panel1.SuspendLayout();
            this.splitContainer_1.Panel2.SuspendLayout();
            this.splitContainer_1.SuspendLayout();
            this.splitContainer_2.Panel1.SuspendLayout();
            this.splitContainer_2.Panel2.SuspendLayout();
            this.splitContainer_2.SuspendLayout();
            this.panel_0.SuspendLayout();
            ((ISupportInitialize) this.dataGridView_0).BeginInit();
            this.dataSet_0.BeginInit();
            this.dataTable_0.BeginInit();
            this.contextMenuStrip_0.SuspendLayout();
            base.SuspendLayout();
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripButton_0, this.toolStripButton_1, this.toolStripSeparator_0, this.toolStripButton_2, this.toolStripButton_3, this.toolStripSeparator_2, this.toolStripButton_5, this.toolStripSeparator_1, this.toolStripButton_4, this.toolStripSeparator_3, this.toolStripButton_6 };
            this.toolStrip_0.Items.AddRange(toolStripItems);
            this.toolStrip_0.Location = new Point(0, 0);
            this.toolStrip_0.Name = "toolStrip";
            this.toolStrip_0.Size = new Size(0x33b, 0x19);
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
            this.toolStripSeparator_0.Name = "toolStripSeparator1";
            this.toolStripSeparator_0.Size = new Size(6, 0x19);
            this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_2.Image = Resources.ElementAccept;
            this.toolStripButton_2.ImageTransparentColor = Color.Transparent;
            this.toolStripButton_2.Name = "toolBtnAccept";
            this.toolStripButton_2.Size = new Size(0x17, 0x16);
            this.toolStripButton_2.Text = "Поменять тип/статус";
            this.toolStripButton_2.Click += new EventHandler(this.toolStripButton_2_Click);
            this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_3.Image = Resources.ElementDel;
            this.toolStripButton_3.ImageTransparentColor = Color.Transparent;
            this.toolStripButton_3.Name = "toolBtnDel";
            this.toolStripButton_3.Size = new Size(0x17, 0x16);
            this.toolStripButton_3.Text = "Удалить задачу";
            this.toolStripButton_3.Click += new EventHandler(this.toolStripButton_3_Click);
            this.toolStripSeparator_2.Name = "toolStripSeparator3";
            this.toolStripSeparator_2.Size = new Size(6, 0x19);
            this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_5.Image = Resources.refresh_16;
            this.toolStripButton_5.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_5.Name = "toolBtnRefresh";
            this.toolStripButton_5.Size = new Size(0x17, 0x16);
            this.toolStripButton_5.Text = "Обновить";
            this.toolStripButton_5.Click += new EventHandler(this.toolStripButton_5_Click);
            this.toolStripSeparator_1.Name = "toolStripSeparator2";
            this.toolStripSeparator_1.Size = new Size(6, 0x19);
            this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_4.Image = Resources.printer;
            this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_4.Name = "toolBtnPrint";
            this.toolStripButton_4.Size = new Size(0x17, 0x16);
            this.toolStripButton_4.Text = "Печать";
            this.toolStripButton_4.Click += new EventHandler(this.toolStripButton_4_Click);
            this.toolStripSeparator_3.Name = "toolStripSeparator4";
            this.toolStripSeparator_3.Size = new Size(6, 0x19);
            this.toolStripButton_6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_6.Image = Resources.mail;
            this.toolStripButton_6.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_6.Name = "toolBtnSendMail";
            this.toolStripButton_6.Size = new Size(0x17, 0x16);
            this.toolStripButton_6.Text = "Отправить email";
            this.toolStripButton_6.Click += new EventHandler(this.toolStripButton_6_Click);
            this.bindingSource_0.DataMember = "vJ_Request";
            this.bindingSource_0.DataSource = this.dataSetGES_0;
            this.bindingSource_0.Sort = "DateTask desc";
            this.bindingSource_0.CurrentChanged += new EventHandler(this.bindingSource_0_CurrentChanged);
            this.dataSetGES_0.DataSetName = "DataSetGES";
            this.dataSetGES_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.splitContainer_0.Dock = DockStyle.Fill;
            this.splitContainer_0.FixedPanel = FixedPanel.Panel2;
            this.splitContainer_0.Location = new Point(0, 0x19);
            this.splitContainer_0.Name = "splitContainer";
            this.splitContainer_0.Orientation = Orientation.Horizontal;
            this.splitContainer_0.Panel1.Controls.Add(this.dataGridViewExcelFilter_0);
            this.splitContainer_0.Panel2.Controls.Add(this.splitContainer_1);
            this.splitContainer_0.Size = new Size(0x33b, 0x187);
            this.splitContainer_0.SplitterDistance = 180;
            this.splitContainer_0.TabIndex = 1;
            this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
            style.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dataGridViewExcelFilter_0.AlternatingRowsDefaultCellStyle = style;
            this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
            style2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style2.BackColor = SystemColors.Control;
            style2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            style2.ForeColor = SystemColors.WindowText;
            style2.SelectionBackColor = SystemColors.Highlight;
            style2.SelectionForeColor = SystemColors.HighlightText;
            style2.WrapMode = DataGridViewTriState.True;
            this.dataGridViewExcelFilter_0.ColumnHeadersDefaultCellStyle = style2;
            this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { 
                this.dataGridViewTextBoxColumn_2, this.dataGridViewTextBoxColumn_3, this.dataGridViewFilterTextBoxColumn_0, this.dataGridViewFilterTextBoxColumn_1, this.dataGridViewFilterTextBoxColumn_2, this.dataGridViewFilterTextBoxColumn_3, this.dataGridViewTextBoxColumn_4, this.dataGridViewTextBoxColumn_5, this.dataGridViewFilterTextBoxColumn_4, this.dataGridViewTextBoxColumn_6, this.dataGridViewTextBoxColumn_7, this.dataGridViewTextBoxColumn_8, this.dataGridViewFilterTextBoxColumn_5, this.dataGridViewFilterTextBoxColumn_6, this.dataGridViewFilterTextBoxColumn_7, this.dataGridViewTextBoxColumn_9,
                this.dataGridViewFilterTextBoxColumn_8, this.dataGridViewFilterTextBoxColumn_9, this.dataGridViewFilterTextBoxColumn_10
            };
            this.dataGridViewExcelFilter_0.Columns.AddRange(dataGridViewColumns);
            this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
            style3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style3.BackColor = SystemColors.Window;
            style3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style3.ForeColor = SystemColors.ControlText;
            style3.SelectionBackColor = SystemColors.Highlight;
            style3.SelectionForeColor = SystemColors.HighlightText;
            style3.WrapMode = DataGridViewTriState.False;
            this.dataGridViewExcelFilter_0.DefaultCellStyle = style3;
            this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_0.Location = new Point(0, 0);
            this.dataGridViewExcelFilter_0.Name = "dgvRequest";
            this.dataGridViewExcelFilter_0.ReadOnly = true;
            style4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style4.BackColor = SystemColors.Control;
            style4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style4.ForeColor = SystemColors.WindowText;
            style4.SelectionBackColor = SystemColors.Highlight;
            style4.SelectionForeColor = SystemColors.HighlightText;
            style4.WrapMode = DataGridViewTriState.True;
            this.dataGridViewExcelFilter_0.RowHeadersDefaultCellStyle = style4;
            this.dataGridViewExcelFilter_0.RowHeadersWidth = 0x15;
            this.dataGridViewExcelFilter_0.Size = new Size(0x33b, 180);
            this.dataGridViewExcelFilter_0.TabIndex = 0;
            this.dataGridViewExcelFilter_0.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_0_CellDoubleClick);
            this.dataGridViewExcelFilter_0.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridViewExcelFilter_0_CellFormatting);
            this.dataGridViewExcelFilter_0.RowEnter += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_0_RowEnter);
            this.dataGridViewTextBoxColumn_2.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_2.HeaderText = "№";
            this.dataGridViewTextBoxColumn_2.Name = "idDgvTxtColumn";
            this.dataGridViewTextBoxColumn_2.ReadOnly = true;
            this.dataGridViewTextBoxColumn_2.Width = 40;
            this.dataGridViewTextBoxColumn_3.DataPropertyName = "idUserTask";
            this.dataGridViewTextBoxColumn_3.HeaderText = "idUserTask";
            this.dataGridViewTextBoxColumn_3.Name = "idUserTaskDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_3.ReadOnly = true;
            this.dataGridViewTextBoxColumn_3.Visible = false;
            this.dataGridViewFilterTextBoxColumn_0.DataPropertyName = "nameUserTask";
            this.dataGridViewFilterTextBoxColumn_0.HeaderText = "Постановщик";
            this.dataGridViewFilterTextBoxColumn_0.Name = "nameUserTaskDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_0.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_0.Width = 110;
            this.dataGridViewFilterTextBoxColumn_1.DataPropertyName = "DateTask";
            style5.Format = "d";
            this.dataGridViewFilterTextBoxColumn_1.DefaultCellStyle = style5;
            this.dataGridViewFilterTextBoxColumn_1.HeaderText = "Дата";
            this.dataGridViewFilterTextBoxColumn_1.Name = "dateTaskDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_1.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_1.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_1.Width = 70;
            this.dataGridViewFilterTextBoxColumn_2.DataPropertyName = "Modul";
            this.dataGridViewFilterTextBoxColumn_2.HeaderText = "Modul";
            this.dataGridViewFilterTextBoxColumn_2.Name = "modulDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_2.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_2.Visible = false;
            this.dataGridViewFilterTextBoxColumn_2.Width = 70;
            this.dataGridViewFilterTextBoxColumn_3.DataPropertyName = "nameModul";
            this.dataGridViewFilterTextBoxColumn_3.HeaderText = "Модуль";
            this.dataGridViewFilterTextBoxColumn_3.Name = "nameModulDgvTxtColumn";
            this.dataGridViewFilterTextBoxColumn_3.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_3.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_4.DataPropertyName = "TextTask";
            this.dataGridViewTextBoxColumn_4.HeaderText = "Текст";
            this.dataGridViewTextBoxColumn_4.Name = "textTaskDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_4.ReadOnly = true;
            this.dataGridViewTextBoxColumn_4.Visible = false;
            this.dataGridViewTextBoxColumn_5.DataPropertyName = "idUserWhom";
            this.dataGridViewTextBoxColumn_5.HeaderText = "idUserWhom";
            this.dataGridViewTextBoxColumn_5.Name = "idUserWhomDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_5.ReadOnly = true;
            this.dataGridViewTextBoxColumn_5.Visible = false;
            this.dataGridViewFilterTextBoxColumn_4.DataPropertyName = "NameUserWhom";
            this.dataGridViewFilterTextBoxColumn_4.HeaderText = "Кому";
            this.dataGridViewFilterTextBoxColumn_4.Name = "nameUserWhomDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_4.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_4.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_4.Width = 70;
            this.dataGridViewTextBoxColumn_6.DataPropertyName = "TypeTask";
            this.dataGridViewTextBoxColumn_6.HeaderText = "TypeTask";
            this.dataGridViewTextBoxColumn_6.Name = "typeTaskDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_6.ReadOnly = true;
            this.dataGridViewTextBoxColumn_6.Visible = false;
            this.dataGridViewTextBoxColumn_7.DataPropertyName = "idUserPerfom";
            this.dataGridViewTextBoxColumn_7.HeaderText = "idUserPerfom";
            this.dataGridViewTextBoxColumn_7.Name = "idUserPerfomDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_7.ReadOnly = true;
            this.dataGridViewTextBoxColumn_7.Visible = false;
            this.dataGridViewTextBoxColumn_8.DataPropertyName = "StatusTask";
            this.dataGridViewTextBoxColumn_8.HeaderText = "StatusTask";
            this.dataGridViewTextBoxColumn_8.Name = "StatusTaskDgvTxtColumn";
            this.dataGridViewTextBoxColumn_8.ReadOnly = true;
            this.dataGridViewTextBoxColumn_8.Visible = false;
            this.dataGridViewFilterTextBoxColumn_5.DataPropertyName = "nameStatusTask";
            this.dataGridViewFilterTextBoxColumn_5.HeaderText = "Статус";
            this.dataGridViewFilterTextBoxColumn_5.Name = "nameStatusTaskDgvTxtColumn";
            this.dataGridViewFilterTextBoxColumn_5.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_6.DataPropertyName = "nameUserPerfom";
            this.dataGridViewFilterTextBoxColumn_6.HeaderText = "Исполнитель";
            this.dataGridViewFilterTextBoxColumn_6.Name = "nameUserPerfomDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_6.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_6.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_7.DataPropertyName = "DatePerfom";
            this.dataGridViewFilterTextBoxColumn_7.HeaderText = "Дата исп";
            this.dataGridViewFilterTextBoxColumn_7.Name = "datePerfomDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_7.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_7.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_7.Width = 60;
            this.dataGridViewTextBoxColumn_9.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn_9.HeaderText = "Коммент";
            this.dataGridViewTextBoxColumn_9.Name = "commentDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_9.ReadOnly = true;
            this.dataGridViewTextBoxColumn_9.Visible = false;
            this.dataGridViewFilterTextBoxColumn_8.DataPropertyName = "NameTypeTask";
            this.dataGridViewFilterTextBoxColumn_8.HeaderText = "Тип задачи";
            this.dataGridViewFilterTextBoxColumn_8.Name = "NameTypeTaskDgvTxtColumn";
            this.dataGridViewFilterTextBoxColumn_8.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_8.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_9.DataPropertyName = "DateSendMail";
            this.dataGridViewFilterTextBoxColumn_9.HeaderText = "Дата почты";
            this.dataGridViewFilterTextBoxColumn_9.Name = "DateSendMail";
            this.dataGridViewFilterTextBoxColumn_9.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_10.DataPropertyName = "FIOSendMail";
            this.dataGridViewFilterTextBoxColumn_10.HeaderText = "ФИО отправителя";
            this.dataGridViewFilterTextBoxColumn_10.Name = "FIOSendMail";
            this.dataGridViewFilterTextBoxColumn_10.ReadOnly = true;
            this.splitContainer_1.Dock = DockStyle.Fill;
            this.splitContainer_1.Location = new Point(0, 0);
            this.splitContainer_1.Name = "splitContainer1";
            this.splitContainer_1.Panel1.Controls.Add(this.splitContainer_2);
            this.splitContainer_1.Panel2.Controls.Add(this.richTextBoxWithContextMenu_1);
            this.splitContainer_1.Panel2.Controls.Add(this.label_1);
            this.splitContainer_1.Size = new Size(0x33b, 0xcf);
            this.splitContainer_1.SplitterDistance = 0x220;
            this.splitContainer_1.TabIndex = 0x12;
            this.splitContainer_2.Dock = DockStyle.Fill;
            this.splitContainer_2.Location = new Point(0, 0);
            this.splitContainer_2.Name = "splitContainer2";
            this.splitContainer_2.Panel1.Controls.Add(this.richTextBoxWithContextMenu_0);
            this.splitContainer_2.Panel2.Controls.Add(this.panel_0);
            this.splitContainer_2.Size = new Size(0x220, 0xcf);
            this.splitContainer_2.SplitterDistance = 0x124;
            this.splitContainer_2.TabIndex = 0x12;
            this.richTextBoxWithContextMenu_0.AcceptsTab = true;
            this.richTextBoxWithContextMenu_0.BackColor = SystemColors.Window;
            this.richTextBoxWithContextMenu_0.Dock = DockStyle.Fill;
            this.richTextBoxWithContextMenu_0.Location = new Point(0, 0);
            this.richTextBoxWithContextMenu_0.Name = "richTextBox";
            this.richTextBoxWithContextMenu_0.ReadOnly = true;
            this.richTextBoxWithContextMenu_0.Size = new Size(0x124, 0xcf);
            this.richTextBoxWithContextMenu_0.TabIndex = 0x10;
            this.richTextBoxWithContextMenu_0.Text = "";
            this.panel_0.Controls.Add(this.dataGridView_0);
            this.panel_0.Controls.Add(this.label_0);
            this.panel_0.Dock = DockStyle.Fill;
            this.panel_0.Location = new Point(0, 0);
            this.panel_0.Name = "panel1";
            this.panel_0.Size = new Size(0xf8, 0xcf);
            this.panel_0.TabIndex = 0x11;
            this.dataGridView_0.AllowUserToAddRows = false;
            this.dataGridView_0.AllowUserToDeleteRows = false;
            this.dataGridView_0.AllowUserToResizeColumns = false;
            this.dataGridView_0.AllowUserToResizeRows = false;
            this.dataGridView_0.AutoGenerateColumns = false;
            this.dataGridView_0.BackgroundColor = SystemColors.Control;
            this.dataGridView_0.BorderStyle = BorderStyle.None;
            this.dataGridView_0.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            style6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style6.BackColor = SystemColors.Control;
            style6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style6.ForeColor = SystemColors.WindowText;
            style6.SelectionBackColor = SystemColors.Highlight;
            style6.SelectionForeColor = SystemColors.HighlightText;
            style6.WrapMode = DataGridViewTriState.True;
            this.dataGridView_0.ColumnHeadersDefaultCellStyle = style6;
            this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_0.ColumnHeadersVisible = false;
            DataGridViewColumn[] columnArray2 = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_0, this.dataGridViewTextBoxColumn_1, this.dataGridViewImageColumnNotNull_0, this.dataGridViewLinkColumn_0 };
            this.dataGridView_0.Columns.AddRange(columnArray2);
            this.dataGridView_0.DataMember = "tJ_RequestDoc";
            this.dataGridView_0.DataSource = this.dataSet_0;
            style7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style7.BackColor = SystemColors.Control;
            style7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style7.ForeColor = SystemColors.ControlText;
            style7.SelectionBackColor = SystemColors.Highlight;
            style7.SelectionForeColor = SystemColors.HighlightText;
            style7.WrapMode = DataGridViewTriState.False;
            this.dataGridView_0.DefaultCellStyle = style7;
            this.dataGridView_0.Dock = DockStyle.Fill;
            this.dataGridView_0.GridColor = SystemColors.Control;
            this.dataGridView_0.Location = new Point(0, 13);
            this.dataGridView_0.MultiSelect = false;
            this.dataGridView_0.Name = "dgvDocs";
            this.dataGridView_0.ReadOnly = true;
            style8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style8.BackColor = SystemColors.Control;
            style8.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style8.ForeColor = SystemColors.WindowText;
            style8.SelectionBackColor = SystemColors.Highlight;
            style8.SelectionForeColor = SystemColors.HighlightText;
            style8.WrapMode = DataGridViewTriState.True;
            this.dataGridView_0.RowHeadersDefaultCellStyle = style8;
            this.dataGridView_0.RowHeadersVisible = false;
            this.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_0.Size = new Size(0xf8, 0xc2);
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
            style9.NullValue = null;
            this.dataGridViewImageColumnNotNull_0.DefaultCellStyle = style9;
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
            this.label_0.AutoSize = true;
            this.label_0.Dock = DockStyle.Top;
            this.label_0.Location = new Point(0, 0);
            this.label_0.Name = "label1";
            this.label_0.Size = new Size(0x7e, 13);
            this.label_0.TabIndex = 0x11;
            this.label_0.Text = "Прикрепленные файлы";
            this.richTextBoxWithContextMenu_1.BackColor = SystemColors.Window;
            this.richTextBoxWithContextMenu_1.DataBindings.Add(new Binding("Text", this.bindingSource_0, "Comment", true));
            this.richTextBoxWithContextMenu_1.Dock = DockStyle.Fill;
            this.richTextBoxWithContextMenu_1.Location = new Point(0, 13);
            this.richTextBoxWithContextMenu_1.Name = "richTextBoxComment";
            this.richTextBoxWithContextMenu_1.ReadOnly = true;
            this.richTextBoxWithContextMenu_1.Size = new Size(0x117, 0xc2);
            this.richTextBoxWithContextMenu_1.TabIndex = 1;
            this.richTextBoxWithContextMenu_1.Text = "";
            this.label_1.AutoSize = true;
            this.label_1.Dock = DockStyle.Top;
            this.label_1.Location = new Point(0, 0);
            this.label_1.Name = "label2";
            this.label_1.Size = new Size(0x76, 13);
            this.label_1.TabIndex = 0;
            this.label_1.Text = "Исполнение (резюме)";
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
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x33b, 0x1a0);
            base.Controls.Add(this.splitContainer_0);
            base.Controls.Add(this.toolStrip_0);
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Name = "FormJournalRequest";
            this.Text = "Журнал задач";
            base.Load += new EventHandler(this.FormJournalRequest_Load);
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            ((ISupportInitialize) this.bindingSource_0).EndInit();
            this.dataSetGES_0.EndInit();
            this.splitContainer_0.Panel1.ResumeLayout(false);
            this.splitContainer_0.Panel2.ResumeLayout(false);
            this.splitContainer_0.ResumeLayout(false);
            this.dataGridViewExcelFilter_0.EndInit();
            this.splitContainer_1.Panel1.ResumeLayout(false);
            this.splitContainer_1.Panel2.ResumeLayout(false);
            this.splitContainer_1.Panel2.PerformLayout();
            this.splitContainer_1.ResumeLayout(false);
            this.splitContainer_2.Panel1.ResumeLayout(false);
            this.splitContainer_2.Panel2.ResumeLayout(false);
            this.splitContainer_2.ResumeLayout(false);
            this.panel_0.ResumeLayout(false);
            this.panel_0.PerformLayout();
            ((ISupportInitialize) this.dataGridView_0).EndInit();
            this.dataSet_0.EndInit();
            this.dataTable_0.EndInit();
            this.contextMenuStrip_0.ResumeLayout(false);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private static string smethod_0(byte[] byte_0)
        {
            char[] dst = new char[byte_0.Length / 2];
            Buffer.BlockCopy(byte_0, 0, dst, 0, byte_0.Length);
            return new string(dst);
        }

        private void toolStripButton_0_Click(object sender, EventArgs e)
        {
            Form39 form1 = new Form39(-1, Form39.Enum10.const_0);
            form1.set_SqlSettings(this.get_SqlSettings());
            form1.MdiParent = base.MdiParent;
            form1.FormClosed += new FormClosedEventHandler(this.method_1);
            form1.Show();
        }

        private void toolStripButton_1_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_0.CurrentRow == null)
            {
                MessageBox.Show("Не выбран документ для редактирования");
            }
            else
            {
                Form39 form1 = new Form39(Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_2.Name].Value), Form39.Enum10.const_1);
                form1.set_SqlSettings(this.get_SqlSettings());
                form1.MdiParent = base.MdiParent;
                form1.FormClosed += new FormClosedEventHandler(this.method_1);
                form1.Show();
            }
        }

        private void toolStripButton_2_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_0.CurrentRow == null)
            {
                MessageBox.Show("Не выбран документ для редактирования");
            }
            else
            {
                int num = Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_2.Name].Value);
                Form40 form1 = new Form40(num);
                form1.set_SqlSettings(this.get_SqlSettings());
                if (form1.ShowDialog() == DialogResult.OK)
                {
                    this.method_0(num);
                }
            }
        }

        private void toolStripButton_3_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_0.CurrentRow == null)
            {
                MessageBox.Show("Не выбрана задача для удаления");
            }
            else if (MessageBox.Show("Вы действительно хотите удалить текущую задачу?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int num = Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells["idDgvTxtColumn"].Value);
                this.dataGridViewExcelFilter_0.Rows.Remove(this.dataGridViewExcelFilter_0.CurrentRow);
                base.DeleteSqlDataById(this.dataSetGES_0.tJ_Request, num);
            }
        }

        private void toolStripButton_4_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_0.CurrentRow == null)
            {
                MessageBox.Show("Не выбрана задача для удаления");
            }
            else
            {
                Form41 form1 = new Form41(Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells["idDgvTxtColumn"].Value));
                form1.set_SqlSettings(this.get_SqlSettings());
                form1.MdiParent = base.MdiParent;
                form1.Show();
            }
        }

        private void toolStripButton_5_Click(object sender, EventArgs e)
        {
            this.method_0(-1);
        }

        private void toolStripButton_6_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_0.CurrentRow == null)
            {
                MessageBox.Show("Не выбран документ для отправки");
            }
            else
            {
                Form38 form1 = new Form38(new int?(Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_2.Name].Value)));
                form1.set_SqlSettings(this.get_SqlSettings());
                form1.MdiParent = base.MdiParent;
                form1.FormClosed += new FormClosedEventHandler(this.method_2);
                form1.Show();
            }
        }

        private void toolStripMenuItem_0_Click(object sender, EventArgs e)
        {
            if (this.dataGridView_0.CurrentRow != null)
            {
                int num = Convert.ToInt32(this.dataGridView_0.CurrentRow.Cells["idDocDgvTxtColumn"].Value);
                base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_RequestDoc, true, "where id = " + num.ToString());
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
                    base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_RequestDoc, true, "where id = " + num.ToString());
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

