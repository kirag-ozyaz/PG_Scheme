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
using System.Windows.Forms;

internal class Form39 : FormBase
{
    private Button button_0;
    private Button button_1;
    private ComboBox comboBox_0;
    private ComboBox comboBox_1;
    private ContextMenuStrip contextMenuStrip_0;
    private ContextMenuStrip contextMenuStrip_1;
    private DataColumn dataColumn_0;
    private DataColumn dataColumn_1;
    private DataColumn dataColumn_2;
    private DataColumn dataColumn_3;
    private DataColumn dataColumn_4;
    private DataGridView dataGridView_0;
    private DataGridViewImageColumn dataGridViewImageColumn_0;
    private DataGridViewImageColumnNotNull dataGridViewImageColumnNotNull_0;
    private DataGridViewLinkColumn dataGridViewLinkColumn_0;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;
    private DataSet dataSet_0;
    private DataSetGES dataSetGES_0;
    private DataTable dataTable_0;
    private DataTable dataTable_1;
    private Enum10 enum10_0;
    private IContainer icontainer_0;
    private int int_0;
    private Label label_0;
    private Label label_1;
    private Label label_2;
    private Label label_3;
    private RichTextBoxWithContextMenu richTextBoxWithContextMenu_0;
    private TextBox textBox_0;
    private ToolStrip toolStrip_0;
    private ToolStripButton toolStripButton_0;
    private ToolStripButton toolStripButton_1;
    private ToolStripMenuItem toolStripMenuItem_0;
    private ToolStripMenuItem toolStripMenuItem_1;
    private ToolStripMenuItem toolStripMenuItem_2;
    private ToolStripMenuItem toolStripMenuItem_3;
    private ToolStripMenuItem toolStripMenuItem_4;
    private ToolStripMenuItem toolStripMenuItem_5;
    private ToolStripMenuItem toolStripMenuItem_6;
    private ToolStripSeparator toolStripSeparator_0;

    public Form39()
    {
        this.int_0 = -1;
        this.method_1();
    }

    public Form39(int int_1, Enum10 enum10_1)
    {
        this.int_0 = -1;
        this.method_1();
        this.enum10_0 = enum10_1;
        this.int_0 = int_1;
        switch (this.enum10_0)
        {
            case Enum10.const_0:
                this.Text = "Новая задача";
                return;

            case Enum10.const_1:
                this.Text = "Редактировать задачу";
                return;

            case Enum10.const_2:
                this.Text = "Просмотр задачи";
                return;
        }
    }

    private void button_0_Click(object sender, EventArgs e)
    {
        base.Close();
    }

    private void button_1_Click(object sender, EventArgs e)
    {
        base.Close();
    }

    private void dataGridView_0_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (this.dataGridView_0.CurrentRow != null)
        {
            int num = Convert.ToInt32(this.dataGridView_0.CurrentRow.Cells["idDgvTxtColumn"].Value);
            if (e.ColumnIndex == this.dataGridView_0.Columns["shortFileNameDgvTxtColumn"].Index)
            {
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
                e.Value = FileInfo.IconOfFile(this.dataGridView_0["filenameDgvTxtColumn", e.RowIndex].Value.ToString()).ToBitmap();
            }
        }
    }

    private void dataGridView_0_DragDrop(object sender, DragEventArgs e)
    {
        if (e.Data.GetDataPresent(DataFormats.FileDrop) && (e.Effect == DragDropEffects.Move))
        {
            string[] data = (string[]) e.Data.GetData(DataFormats.FileDrop);
            for (int i = 0; i < data.Length; i++)
            {
                if (File.GetAttributes(data[i]) != FileAttributes.Directory)
                {
                    DataRow row = this.dataSetGES_0.tJ_RequestDoc.NewRow();
                    row["idRequest"] = -1;
                    row["Document"] = File.ReadAllBytes(data[i]);
                    row["FileName"] = data[i];
                    this.dataSetGES_0.tJ_RequestDoc.Rows.Add(row);
                }
            }
        }
    }

    private void dataGridView_0_DragEnter(object sender, DragEventArgs e)
    {
        if (e.Data.GetDataPresent(DataFormats.FileDrop))
        {
            e.Effect = DragDropEffects.Move;
        }
        else
        {
            e.Effect = DragDropEffects.None;
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

    private void Form39_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (base.DialogResult == DialogResult.OK)
        {
            if (this.comboBox_0.SelectedIndex < 0)
            {
                MessageBox.Show("Не выбран модуль");
                e.Cancel = true;
            }
            else if (string.IsNullOrEmpty(this.richTextBoxWithContextMenu_0.Text))
            {
                MessageBox.Show("Не заполнено поле текста задачи");
                e.Cancel = true;
            }
            else
            {
                if (!string.IsNullOrEmpty(this.richTextBoxWithContextMenu_0.Rtf))
                {
                    this.dataSetGES_0.tJ_Request.Rows[0]["TextTaskBin"] = smethod_0(this.richTextBoxWithContextMenu_0.Rtf);
                }
                else
                {
                    this.dataSetGES_0.tJ_Request.Rows[0]["TextTaskBin"] = DBNull.Value;
                }
                switch (this.enum10_0)
                {
                    case Enum10.const_0:
                        this.dataSetGES_0.tJ_Request.Rows[0].EndEdit();
                        this.int_0 = base.InsertSqlDataOneRow(this.dataSetGES_0, this.dataSetGES_0.tJ_Request);
                        if (this.int_0 > 0)
                        {
                            foreach (DataRow row1 in this.dataSetGES_0.tJ_RequestDoc.Rows)
                            {
                                row1["idRequest"] = this.int_0;
                                row1.EndEdit();
                            }
                            base.InsertSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_RequestDoc);
                        }
                        break;

                    case Enum10.const_1:
                        this.dataSetGES_0.tJ_Request.Rows[0].EndEdit();
                        base.UpdateSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_Request);
                        if (this.int_0 > 0)
                        {
                            foreach (DataRow row in this.dataSetGES_0.tJ_RequestDoc.Rows)
                            {
                                if (row.RowState != DataRowState.Deleted)
                                {
                                    row["idRequest"] = this.int_0;
                                }
                                row.EndEdit();
                            }
                            base.InsertSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_RequestDoc);
                            base.DeleteSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_RequestDoc);
                        }
                        break;
                }
            }
        }
    }

    private void Form39_Load(object sender, EventArgs e)
    {
        base.SelectSqlData(this.dataSet_0, this.dataSet_0.Tables["tUser"], true, " where deleted = 0 order by [name]");
        base.SelectSqlData(this.dataSet_0, this.dataSet_0.Tables["tR_Classifier"], true, " where ParentKey = ';Other;ModulPC;' and isGroup = 0 and deleted = 0 order by [name]");
        base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tUser, true, " where [Login] = SYSTEM_USER ", 1);
        int num = -1;
        if (this.dataSetGES_0.tUser.Rows.Count > 0)
        {
            num = Convert.ToInt32(this.dataSetGES_0.tUser.Rows[0]["idUser"]);
        }
        switch (this.enum10_0)
        {
            case Enum10.const_0:
            {
                DataRow row = this.dataSetGES_0.tJ_Request.NewRow();
                row["idUserTask"] = num;
                row["DateTask"] = DateTime.Now;
                this.dataSetGES_0.tJ_Request.Rows.Add(row);
                break;
            }
            case Enum10.const_1:
                base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_Request, true, " where id = " + this.int_0.ToString());
                base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_RequestDoc, true, " where idRequest = " + this.int_0.ToString());
                if (this.dataSetGES_0.tJ_Request.Rows[0]["TextTaskBin"] != DBNull.Value)
                {
                    this.richTextBoxWithContextMenu_0.Rtf = smethod_1((byte[]) this.dataSetGES_0.tJ_Request.Rows[0]["TextTaskBin"]);
                }
                if (this.dataSetGES_0.tJ_Request.Rows.Count == 0)
                {
                    MessageBox.Show("Не удалось открыть документ для редактирования");
                    base.DialogResult = DialogResult.Cancel;
                    base.Close();
                }
                else
                {
                    if ((num == -1) || (num != Convert.ToInt32(this.dataSetGES_0.tJ_Request.Rows[0]["idUserTask"])))
                    {
                        this.comboBox_0.Enabled = false;
                        this.richTextBoxWithContextMenu_0.ReadOnly = true;
                        this.toolStrip_0.Enabled = false;
                        this.toolStripMenuItem_2.Visible = false;
                        this.comboBox_1.Enabled = false;
                    }
                    if ((this.dataSetGES_0.tJ_Request.Rows[0]["idUserWhom"] != DBNull.Value) && (num == Convert.ToInt32(this.dataSetGES_0.tJ_Request.Rows[0]["idUserWhom"])))
                    {
                        this.comboBox_1.Enabled = true;
                        this.toolStrip_0.Enabled = true;
                    }
                }
                break;
        }
    }

    internal int method_0()
    {
        return this.int_0;
    }

    private void method_1()
    {
        this.icontainer_0 = new Container();
        DataGridViewCellStyle style = new DataGridViewCellStyle();
        DataGridViewCellStyle style2 = new DataGridViewCellStyle();
        this.dataSetGES_0 = new DataSetGES();
        this.label_0 = new Label();
        this.textBox_0 = new TextBox();
        this.label_1 = new Label();
        this.comboBox_0 = new ComboBox();
        this.dataSet_0 = new DataSet();
        this.dataTable_0 = new DataTable();
        this.dataColumn_0 = new DataColumn();
        this.dataColumn_1 = new DataColumn();
        this.dataTable_1 = new DataTable();
        this.dataColumn_2 = new DataColumn();
        this.dataColumn_3 = new DataColumn();
        this.dataColumn_4 = new DataColumn();
        this.label_2 = new Label();
        this.button_0 = new Button();
        this.button_1 = new Button();
        this.label_3 = new Label();
        this.comboBox_1 = new ComboBox();
        this.dataGridView_0 = new DataGridView();
        this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
        this.dataGridViewImageColumn_0 = new DataGridViewImageColumn();
        this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
        this.dataGridViewImageColumnNotNull_0 = new DataGridViewImageColumnNotNull();
        this.dataGridViewLinkColumn_0 = new DataGridViewLinkColumn();
        this.toolStrip_0 = new ToolStrip();
        this.toolStripButton_0 = new ToolStripButton();
        this.toolStripButton_1 = new ToolStripButton();
        this.contextMenuStrip_0 = new ContextMenuStrip(this.icontainer_0);
        this.toolStripMenuItem_0 = new ToolStripMenuItem();
        this.toolStripMenuItem_1 = new ToolStripMenuItem();
        this.toolStripMenuItem_2 = new ToolStripMenuItem();
        this.contextMenuStrip_1 = new ContextMenuStrip(this.icontainer_0);
        this.toolStripMenuItem_3 = new ToolStripMenuItem();
        this.toolStripSeparator_0 = new ToolStripSeparator();
        this.toolStripMenuItem_4 = new ToolStripMenuItem();
        this.toolStripMenuItem_5 = new ToolStripMenuItem();
        this.toolStripMenuItem_6 = new ToolStripMenuItem();
        this.richTextBoxWithContextMenu_0 = new RichTextBoxWithContextMenu();
        this.dataSetGES_0.BeginInit();
        this.dataSet_0.BeginInit();
        this.dataTable_0.BeginInit();
        this.dataTable_1.BeginInit();
        ((ISupportInitialize) this.dataGridView_0).BeginInit();
        this.toolStrip_0.SuspendLayout();
        this.contextMenuStrip_0.SuspendLayout();
        this.contextMenuStrip_1.SuspendLayout();
        base.SuspendLayout();
        this.dataSetGES_0.DataSetName = "DataSetGES";
        this.dataSetGES_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        this.label_0.AutoSize = true;
        this.label_0.Location = new Point(12, 10);
        this.label_0.Name = "label1";
        this.label_0.Size = new Size(0x38, 13);
        this.label_0.TabIndex = 0;
        this.label_0.Text = "№ задачи";
        this.textBox_0.BackColor = SystemColors.Window;
        this.textBox_0.DataBindings.Add(new Binding("Text", this.dataSetGES_0, "tJ_Request.id", true));
        this.textBox_0.Location = new Point(0x4a, 7);
        this.textBox_0.Name = "textBoxId";
        this.textBox_0.ReadOnly = true;
        this.textBox_0.Size = new Size(0x71, 20);
        this.textBox_0.TabIndex = 1;
        this.label_1.AutoSize = true;
        this.label_1.Location = new Point(0xbd, 10);
        this.label_1.Name = "label2";
        this.label_1.Size = new Size(0x2d, 13);
        this.label_1.TabIndex = 2;
        this.label_1.Text = "Модуль";
        this.comboBox_0.DataBindings.Add(new Binding("SelectedValue", this.dataSetGES_0, "tJ_Request.Modul", true));
        this.comboBox_0.DataSource = this.dataSet_0;
        this.comboBox_0.DisplayMember = "tR_Classifier.Name";
        this.comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
        this.comboBox_0.FormattingEnabled = true;
        this.comboBox_0.Location = new Point(240, 6);
        this.comboBox_0.Name = "comboBoxModul";
        this.comboBox_0.Size = new Size(0x9c, 0x15);
        this.comboBox_0.TabIndex = 3;
        this.comboBox_0.ValueMember = "tR_Classifier.Id";
        this.dataSet_0.DataSetName = "NewDataSet";
        DataTable[] tables = new DataTable[] { this.dataTable_0, this.dataTable_1 };
        this.dataSet_0.Tables.AddRange(tables);
        DataColumn[] columns = new DataColumn[] { this.dataColumn_0, this.dataColumn_1 };
        this.dataTable_0.Columns.AddRange(columns);
        this.dataTable_0.TableName = "tUser";
        this.dataColumn_0.ColumnName = "idUser";
        this.dataColumn_0.DataType = typeof(int);
        this.dataColumn_1.ColumnName = "Name";
        DataColumn[] columnArray2 = new DataColumn[] { this.dataColumn_2, this.dataColumn_3, this.dataColumn_4 };
        this.dataTable_1.Columns.AddRange(columnArray2);
        this.dataTable_1.TableName = "tR_Classifier";
        this.dataColumn_2.ColumnName = "Id";
        this.dataColumn_2.DataType = typeof(int);
        this.dataColumn_3.ColumnName = "Name";
        this.dataColumn_4.ColumnName = "ParentKey";
        this.label_2.AutoSize = true;
        this.label_2.Location = new Point(12, 0x45);
        this.label_2.Name = "label3";
        this.label_2.Size = new Size(0x4c, 13);
        this.label_2.TabIndex = 4;
        this.label_2.Text = "Текст Задачи";
        this.button_0.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
        this.button_0.DialogResult = DialogResult.OK;
        this.button_0.Location = new Point(15, 0x135);
        this.button_0.Name = "buttonOK";
        this.button_0.Size = new Size(0x4b, 0x17);
        this.button_0.TabIndex = 6;
        this.button_0.Text = "ОК";
        this.button_0.UseVisualStyleBackColor = true;
        this.button_0.Click += new EventHandler(this.button_0_Click);
        this.button_1.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
        this.button_1.DialogResult = DialogResult.Cancel;
        this.button_1.Location = new Point(0x141, 0x135);
        this.button_1.Name = "buttonCancel";
        this.button_1.Size = new Size(0x4b, 0x17);
        this.button_1.TabIndex = 7;
        this.button_1.Text = "Отмена";
        this.button_1.UseVisualStyleBackColor = true;
        this.button_1.Click += new EventHandler(this.button_1_Click);
        this.label_3.AutoSize = true;
        this.label_3.Location = new Point(12, 0x2b);
        this.label_3.Name = "label4";
        this.label_3.Size = new Size(0x21, 13);
        this.label_3.TabIndex = 12;
        this.label_3.Text = "Кому";
        this.comboBox_1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        this.comboBox_1.AutoCompleteSource = AutoCompleteSource.ListItems;
        this.comboBox_1.DataBindings.Add(new Binding("SelectedValue", this.dataSetGES_0, "tJ_Request.idUserWhom", true));
        this.comboBox_1.DataSource = this.dataSet_0;
        this.comboBox_1.DisplayMember = "tUser.Name";
        this.comboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
        this.comboBox_1.FormattingEnabled = true;
        this.comboBox_1.Location = new Point(0x35, 40);
        this.comboBox_1.Name = "comboBoxWhom";
        this.comboBox_1.Size = new Size(0x157, 0x15);
        this.comboBox_1.TabIndex = 13;
        this.comboBox_1.ValueMember = "tUser.idUser";
        this.dataGridView_0.AllowDrop = true;
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
        DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_0, this.dataGridViewTextBoxColumn_1, this.dataGridViewImageColumn_0, this.dataGridViewTextBoxColumn_2, this.dataGridViewImageColumnNotNull_0, this.dataGridViewLinkColumn_0 };
        this.dataGridView_0.Columns.AddRange(dataGridViewColumns);
        this.dataGridView_0.DataMember = "tJ_RequestDoc";
        this.dataGridView_0.DataSource = this.dataSetGES_0;
        style.Alignment = DataGridViewContentAlignment.MiddleLeft;
        style.BackColor = SystemColors.Control;
        style.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        style.ForeColor = SystemColors.ControlText;
        style.SelectionBackColor = SystemColors.Highlight;
        style.SelectionForeColor = SystemColors.HighlightText;
        style.WrapMode = DataGridViewTriState.False;
        this.dataGridView_0.DefaultCellStyle = style;
        this.dataGridView_0.GridColor = SystemColors.Control;
        this.dataGridView_0.Location = new Point(0x2a, 0xb7);
        this.dataGridView_0.MultiSelect = false;
        this.dataGridView_0.Name = "dgvDocs";
        this.dataGridView_0.ReadOnly = true;
        this.dataGridView_0.RowHeadersVisible = false;
        this.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        this.dataGridView_0.Size = new Size(0x162, 0x65);
        this.dataGridView_0.TabIndex = 14;
        this.dataGridView_0.VirtualMode = true;
        this.dataGridView_0.CellContentClick += new DataGridViewCellEventHandler(this.dataGridView_0_CellContentClick);
        this.dataGridView_0.CellMouseClick += new DataGridViewCellMouseEventHandler(this.dataGridView_0_CellMouseClick);
        this.dataGridView_0.CellValueNeeded += new DataGridViewCellValueEventHandler(this.dataGridView_0_CellValueNeeded);
        this.dataGridView_0.DragDrop += new DragEventHandler(this.dataGridView_0_DragDrop);
        this.dataGridView_0.DragEnter += new DragEventHandler(this.dataGridView_0_DragEnter);
        this.dataGridViewTextBoxColumn_0.DataPropertyName = "id";
        this.dataGridViewTextBoxColumn_0.HeaderText = "id";
        this.dataGridViewTextBoxColumn_0.Name = "idDgvTxtColumn";
        this.dataGridViewTextBoxColumn_0.ReadOnly = true;
        this.dataGridViewTextBoxColumn_0.Visible = false;
        this.dataGridViewTextBoxColumn_1.DataPropertyName = "idRequest";
        this.dataGridViewTextBoxColumn_1.HeaderText = "idRequest";
        this.dataGridViewTextBoxColumn_1.Name = "idRequestDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_1.ReadOnly = true;
        this.dataGridViewTextBoxColumn_1.Visible = false;
        this.dataGridViewImageColumn_0.DataPropertyName = "Document";
        this.dataGridViewImageColumn_0.HeaderText = "Document";
        this.dataGridViewImageColumn_0.Name = "documentDataGridViewImageColumn";
        this.dataGridViewImageColumn_0.ReadOnly = true;
        this.dataGridViewImageColumn_0.Visible = false;
        this.dataGridViewTextBoxColumn_2.DataPropertyName = "FileName";
        this.dataGridViewTextBoxColumn_2.HeaderText = "FileName";
        this.dataGridViewTextBoxColumn_2.Name = "fileNameDgvTxtColumn";
        this.dataGridViewTextBoxColumn_2.ReadOnly = true;
        this.dataGridViewTextBoxColumn_2.Visible = false;
        style2.NullValue = null;
        this.dataGridViewImageColumnNotNull_0.DefaultCellStyle = style2;
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
        this.toolStrip_0.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
        this.toolStrip_0.Dock = DockStyle.None;
        this.toolStrip_0.GripStyle = ToolStripGripStyle.Hidden;
        ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripButton_0, this.toolStripButton_1 };
        this.toolStrip_0.Items.AddRange(toolStripItems);
        this.toolStrip_0.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
        this.toolStrip_0.Location = new Point(15, 0xb7);
        this.toolStrip_0.Name = "toolStrip";
        this.toolStrip_0.Size = new Size(0x18, 0x30);
        this.toolStrip_0.TabIndex = 15;
        this.toolStrip_0.Text = "toolStrip1";
        this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_0.Image = Resources.ElementAdd;
        this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
        this.toolStripButton_0.Name = "toolBtnAdd";
        this.toolStripButton_0.Size = new Size(0x16, 20);
        this.toolStripButton_0.Text = "Добавить файл";
        this.toolStripButton_0.Click += new EventHandler(this.toolStripButton_0_Click);
        this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_1.Image = Resources.ElementDel;
        this.toolStripButton_1.ImageTransparentColor = Color.Transparent;
        this.toolStripButton_1.Name = "toolBtnDel";
        this.toolStripButton_1.Size = new Size(0x16, 20);
        this.toolStripButton_1.Text = "Удалить";
        this.toolStripButton_1.Click += new EventHandler(this.toolStripButton_1_Click);
        ToolStripItem[] itemArray2 = new ToolStripItem[] { this.toolStripMenuItem_0, this.toolStripMenuItem_1, this.toolStripMenuItem_2 };
        this.contextMenuStrip_0.Items.AddRange(itemArray2);
        this.contextMenuStrip_0.Name = "contextMenuDgvDoc";
        this.contextMenuStrip_0.Size = new Size(0x85, 70);
        this.toolStripMenuItem_0.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
        this.toolStripMenuItem_0.Name = "toolMenuOpen";
        this.toolStripMenuItem_0.Size = new Size(0x84, 0x16);
        this.toolStripMenuItem_0.Text = "Открыть";
        this.toolStripMenuItem_0.Click += new EventHandler(this.toolStripMenuItem_0_Click);
        this.toolStripMenuItem_1.Image = Resources.save;
        this.toolStripMenuItem_1.Name = "toolMenuSave";
        this.toolStripMenuItem_1.Size = new Size(0x84, 0x16);
        this.toolStripMenuItem_1.Text = "Сохранить";
        this.toolStripMenuItem_1.Click += new EventHandler(this.toolStripMenuItem_1_Click);
        this.toolStripMenuItem_2.Image = Resources.ElementDel;
        this.toolStripMenuItem_2.Name = "toolMenuDel";
        this.toolStripMenuItem_2.Size = new Size(0x84, 0x16);
        this.toolStripMenuItem_2.Text = "Удалить";
        this.toolStripMenuItem_2.Click += new EventHandler(this.toolStripMenuItem_2_Click);
        ToolStripItem[] itemArray3 = new ToolStripItem[] { this.toolStripMenuItem_3, this.toolStripSeparator_0, this.toolStripMenuItem_4, this.toolStripMenuItem_5, this.toolStripMenuItem_6 };
        this.contextMenuStrip_1.Items.AddRange(itemArray3);
        this.contextMenuStrip_1.Name = "contextMenuTxt";
        this.contextMenuStrip_1.Size = new Size(140, 0x62);
        this.toolStripMenuItem_3.Name = "отменитьToolStripMenuItem";
        this.toolStripMenuItem_3.Size = new Size(0x8b, 0x16);
        this.toolStripMenuItem_3.Text = "Отменить";
        this.toolStripSeparator_0.Name = "toolStripSeparator1";
        this.toolStripSeparator_0.Size = new Size(0x88, 6);
        this.toolStripMenuItem_4.Name = "вырезатьToolStripMenuItem";
        this.toolStripMenuItem_4.Size = new Size(0x8b, 0x16);
        this.toolStripMenuItem_4.Text = "Вырезать";
        this.toolStripMenuItem_5.Name = "копироватьToolStripMenuItem";
        this.toolStripMenuItem_5.Size = new Size(0x8b, 0x16);
        this.toolStripMenuItem_5.Text = "Копировать";
        this.toolStripMenuItem_6.Name = "вставитьToolStripMenuItem";
        this.toolStripMenuItem_6.Size = new Size(0x8b, 0x16);
        this.toolStripMenuItem_6.Text = "Вставить";
        this.richTextBoxWithContextMenu_0.AcceptsTab = true;
        this.richTextBoxWithContextMenu_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
        this.richTextBoxWithContextMenu_0.DataBindings.Add(new Binding("Text", this.dataSetGES_0, "tJ_Request.TextTask", true));
        this.richTextBoxWithContextMenu_0.Location = new Point(15, 0x55);
        this.richTextBoxWithContextMenu_0.Name = "richTextBoxTextTask";
        this.richTextBoxWithContextMenu_0.Size = new Size(0x17d, 0x5c);
        this.richTextBoxWithContextMenu_0.TabIndex = 0x10;
        this.richTextBoxWithContextMenu_0.Text = "";
        base.AcceptButton = this.button_0;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.CancelButton = this.button_1;
        base.ClientSize = new Size(0x195, 0x158);
        base.Controls.Add(this.richTextBoxWithContextMenu_0);
        base.Controls.Add(this.toolStrip_0);
        base.Controls.Add(this.dataGridView_0);
        base.Controls.Add(this.comboBox_1);
        base.Controls.Add(this.label_3);
        base.Controls.Add(this.button_1);
        base.Controls.Add(this.button_0);
        base.Controls.Add(this.label_2);
        base.Controls.Add(this.comboBox_0);
        base.Controls.Add(this.label_1);
        base.Controls.Add(this.textBox_0);
        base.Controls.Add(this.label_0);
        base.Name = "FormAddEditRequest";
        this.Text = "j";
        base.FormClosing += new FormClosingEventHandler(this.Form39_FormClosing);
        base.Load += new EventHandler(this.Form39_Load);
        this.dataSetGES_0.EndInit();
        this.dataSet_0.EndInit();
        this.dataTable_0.EndInit();
        this.dataTable_1.EndInit();
        ((ISupportInitialize) this.dataGridView_0).EndInit();
        this.toolStrip_0.ResumeLayout(false);
        this.toolStrip_0.PerformLayout();
        this.contextMenuStrip_0.ResumeLayout(false);
        this.contextMenuStrip_1.ResumeLayout(false);
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    private static byte[] smethod_0(string string_0)
    {
        byte[] dst = new byte[string_0.Length * 2];
        Buffer.BlockCopy(string_0.ToCharArray(), 0, dst, 0, dst.Length);
        return dst;
    }

    private static string smethod_1(byte[] byte_0)
    {
        char[] dst = new char[byte_0.Length / 2];
        Buffer.BlockCopy(byte_0, 0, dst, 0, byte_0.Length);
        return new string(dst);
    }

    private void toolStripButton_0_Click(object sender, EventArgs e)
    {
        try
        {
            OpenFileDialog dialog = new OpenFileDialog {
                Multiselect = true
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < dialog.FileNames.Length; i++)
                {
                    DataRow row = this.dataSetGES_0.tJ_RequestDoc.NewRow();
                    row["idRequest"] = -1;
                    row["Document"] = File.ReadAllBytes(dialog.FileNames[i]);
                    row["FileName"] = dialog.FileNames[i];
                    this.dataSetGES_0.tJ_RequestDoc.Rows.Add(row);
                }
            }
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message, exception.Source);
        }
    }

    private void toolStripButton_1_Click(object sender, EventArgs e)
    {
        if (this.dataGridView_0.CurrentRow != null)
        {
            Convert.ToInt32(this.dataGridView_0.CurrentRow.Cells["idDgvTxtColumn"].Value);
            this.dataGridView_0.Rows.Remove(this.dataGridView_0.CurrentRow);
        }
        else
        {
            MessageBox.Show("Не выбрано ни одного файла");
        }
    }

    private void toolStripMenuItem_0_Click(object sender, EventArgs e)
    {
        if (this.dataGridView_0.CurrentRow != null)
        {
            int num = Convert.ToInt32(this.dataGridView_0.CurrentRow.Cells["idDgvTxtColumn"].Value);
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
            int num = Convert.ToInt32(this.dataGridView_0.CurrentRow.Cells["idDgvTxtColumn"].Value);
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

    private void toolStripMenuItem_2_Click(object sender, EventArgs e)
    {
        this.toolStripButton_1_Click(sender, e);
    }

    internal enum Enum10
    {
        const_0,
        const_1,
        const_2
    }
}

