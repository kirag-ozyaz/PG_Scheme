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

internal class Form36 : FormBase
{
    private Button button_0;
    private Button button_1;
    private ComboBox comboBox_0;
    private ContextMenuStrip contextMenuStrip_0;
    private DataGridView dataGridView_0;
    private DataGridViewImageColumn dataGridViewImageColumn_0;
    private DataGridViewImageColumnNotNull dataGridViewImageColumnNotNull_0;
    private DataGridViewLinkColumn dataGridViewLinkColumn_0;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
    private DataSetGES dataSetGES_0;
    private DateTimePicker dateTimePicker_0;
    private IContainer icontainer_0;
    private int int_0;
    private Label label_0;
    private Label label_1;
    private Label label_2;
    private Label label_3;
    private RichTextBox richTextBox_0;
    private RichTextBox richTextBox_1;
    private ToolStrip toolStrip_0;
    private ToolStripButton toolStripButton_0;
    private ToolStripButton toolStripButton_1;
    private ToolStripMenuItem toolStripMenuItem_0;
    private ToolStripMenuItem toolStripMenuItem_1;
    private ToolStripMenuItem toolStripMenuItem_2;

    internal Form36()
    {
        this.int_0 = -1;
        this.method_0();
    }

    internal Form36(int int_1)
    {
        this.int_0 = -1;
        this.method_0();
        this.int_0 = int_1;
        if (int_1 == -1)
        {
            this.Text = "Добавить обновление";
        }
        else
        {
            this.Text = "Изменить обновление";
        }
    }

    private void dataGridView_0_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (this.dataGridView_0.CurrentRow != null)
        {
            int num = Convert.ToInt32(this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_0.Name].Value);
            if (e.ColumnIndex == this.dataGridView_0.Columns[this.dataGridViewLinkColumn_0.Name].Index)
            {
                byte[] buffer = (byte[]) this.dataSetGES_0.tJ_UpdateProgramDoc.method_2(num)["Document"];
                string path = Path.ChangeExtension(Path.GetTempFileName(), Path.GetExtension(this.dataSetGES_0.tJ_UpdateProgramDoc.method_2(num)["FileName"].ToString()));
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
            this.dataGridView_0.CurrentCell = this.dataGridView_0[this.dataGridViewImageColumnNotNull_0.Name, e.RowIndex];
            this.contextMenuStrip_0.Show(Cursor.Position);
        }
    }

    private void dataGridView_0_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
    {
        if ((this.dataGridView_0.RowCount > 0) && (this.dataGridView_0[this.dataGridViewTextBoxColumn_1.Name, e.RowIndex].Value != null))
        {
            if (e.ColumnIndex == this.dataGridView_0.Columns[this.dataGridViewLinkColumn_0.Name].Index)
            {
                e.Value = Path.GetFileName(this.dataGridView_0[this.dataGridViewTextBoxColumn_1.Name, e.RowIndex].Value.ToString());
            }
            if (e.ColumnIndex == this.dataGridView_0.Columns[this.dataGridViewImageColumnNotNull_0.Name].Index)
            {
                e.Value = FileInfo.IconOfFile(this.dataGridView_0[this.dataGridViewTextBoxColumn_1.Name, e.RowIndex].Value.ToString()).ToBitmap();
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

    private void Form36_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (base.DialogResult == DialogResult.OK)
        {
            if (this.comboBox_0.SelectedIndex < 0)
            {
                MessageBox.Show("Не выбран модуль");
                e.Cancel = true;
            }
            else if (string.IsNullOrEmpty(this.richTextBox_0.Text) || string.IsNullOrEmpty(this.richTextBox_1.Text))
            {
                MessageBox.Show("Не заполнено поле текста");
                e.Cancel = true;
            }
            else if (this.int_0 == -1)
            {
                this.dataSetGES_0.tJ_UpdateProgram.Rows[0].EndEdit();
                this.int_0 = base.InsertSqlDataOneRow(this.dataSetGES_0, this.dataSetGES_0.tJ_UpdateProgram);
                if (this.int_0 > 0)
                {
                    foreach (DataRow row1 in this.dataSetGES_0.tJ_UpdateProgramDoc.Rows)
                    {
                        row1["idUpdate"] = this.int_0;
                        row1.EndEdit();
                    }
                    base.InsertSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_UpdateProgramDoc);
                }
            }
            else
            {
                this.dataSetGES_0.tJ_UpdateProgram.Rows[0].EndEdit();
                base.UpdateSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_UpdateProgram);
                if (this.int_0 > 0)
                {
                    foreach (DataRow row in this.dataSetGES_0.tJ_UpdateProgramDoc.Rows)
                    {
                        if (row.RowState != DataRowState.Deleted)
                        {
                            row["idUpdate"] = this.int_0;
                        }
                        row.EndEdit();
                    }
                    base.InsertSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_UpdateProgramDoc);
                    base.DeleteSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_UpdateProgramDoc);
                }
            }
        }
    }

    private void Form36_Load(object sender, EventArgs e)
    {
        base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tR_Classifier, true, " where ParentKey = ';Other;ModulPC;' and isGroup = 0 and deleted = 0 order by [name]");
        if (this.int_0 == -1)
        {
            DataRow row = this.dataSetGES_0.tJ_UpdateProgram.NewRow();
            row["Dateupdate"] = DateTime.Now;
            this.dataSetGES_0.tJ_UpdateProgram.Rows.Add(row);
            this.comboBox_0.SelectedIndex = -1;
        }
        else
        {
            base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_UpdateProgram, true, " where id = " + this.int_0.ToString());
            base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_UpdateProgramDoc, true, " where idUpdate = " + this.int_0.ToString());
        }
    }

    private void method_0()
    {
        this.icontainer_0 = new Container();
        DataGridViewCellStyle style = new DataGridViewCellStyle();
        DataGridViewCellStyle style2 = new DataGridViewCellStyle();
        this.label_0 = new Label();
        this.dataSetGES_0 = new DataSetGES();
        this.dateTimePicker_0 = new DateTimePicker();
        this.label_1 = new Label();
        this.comboBox_0 = new ComboBox();
        this.label_2 = new Label();
        this.richTextBox_0 = new RichTextBox();
        this.label_3 = new Label();
        this.richTextBox_1 = new RichTextBox();
        this.toolStrip_0 = new ToolStrip();
        this.toolStripButton_0 = new ToolStripButton();
        this.toolStripButton_1 = new ToolStripButton();
        this.dataGridView_0 = new DataGridView();
        this.dataGridViewImageColumnNotNull_0 = new DataGridViewImageColumnNotNull();
        this.dataGridViewLinkColumn_0 = new DataGridViewLinkColumn();
        this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
        this.dataGridViewImageColumn_0 = new DataGridViewImageColumn();
        this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
        this.button_0 = new Button();
        this.button_1 = new Button();
        this.contextMenuStrip_0 = new ContextMenuStrip(this.icontainer_0);
        this.toolStripMenuItem_0 = new ToolStripMenuItem();
        this.toolStripMenuItem_1 = new ToolStripMenuItem();
        this.toolStripMenuItem_2 = new ToolStripMenuItem();
        this.dataSetGES_0.BeginInit();
        this.toolStrip_0.SuspendLayout();
        ((ISupportInitialize) this.dataGridView_0).BeginInit();
        this.contextMenuStrip_0.SuspendLayout();
        base.SuspendLayout();
        this.label_0.AutoSize = true;
        this.label_0.Location = new Point(12, 9);
        this.label_0.Name = "label1";
        this.label_0.Size = new Size(0x21, 13);
        this.label_0.TabIndex = 0;
        this.label_0.Text = "Дата";
        this.dataSetGES_0.DataSetName = "DataSetGES";
        this.dataSetGES_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        this.dateTimePicker_0.CustomFormat = "dd MMMM yyyy HH:mm";
        this.dateTimePicker_0.DataBindings.Add(new Binding("Value", this.dataSetGES_0, "tJ_UpdateProgram.DateUpdate", true));
        this.dateTimePicker_0.Format = DateTimePickerFormat.Custom;
        this.dateTimePicker_0.Location = new Point(15, 0x19);
        this.dateTimePicker_0.Name = "dateTimePicker1";
        this.dateTimePicker_0.Size = new Size(200, 20);
        this.dateTimePicker_0.TabIndex = 1;
        this.label_1.AutoSize = true;
        this.label_1.Location = new Point(240, 9);
        this.label_1.Name = "label2";
        this.label_1.Size = new Size(0x2d, 13);
        this.label_1.TabIndex = 2;
        this.label_1.Text = "Модуль";
        this.comboBox_0.DataBindings.Add(new Binding("SelectedValue", this.dataSetGES_0, "tJ_UpdateProgram.Modul", true));
        this.comboBox_0.DataSource = this.dataSetGES_0;
        this.comboBox_0.DisplayMember = "tR_Classifier.Name";
        this.comboBox_0.FormattingEnabled = true;
        this.comboBox_0.Location = new Point(0xf3, 0x18);
        this.comboBox_0.Name = "comboBoxModul";
        this.comboBox_0.Size = new Size(0x11c, 0x15);
        this.comboBox_0.TabIndex = 3;
        this.comboBox_0.ValueMember = "tR_Classifier.Id";
        this.label_2.AutoSize = true;
        this.label_2.DataBindings.Add(new Binding("Text", this.dataSetGES_0, "tJ_UpdateProgram.Description", true));
        this.label_2.Location = new Point(12, 0x30);
        this.label_2.Name = "label3";
        this.label_2.Size = new Size(0x45, 13);
        this.label_2.TabIndex = 4;
        this.label_2.Text = "Обновление";
        this.richTextBox_0.AcceptsTab = true;
        this.richTextBox_0.DataBindings.Add(new Binding("Text", this.dataSetGES_0, "tJ_UpdateProgram.Description", true));
        this.richTextBox_0.Location = new Point(15, 0x40);
        this.richTextBox_0.Name = "richTextBox1";
        this.richTextBox_0.Size = new Size(0x200, 0x4d);
        this.richTextBox_0.TabIndex = 5;
        this.richTextBox_0.Text = "";
        this.label_3.AutoSize = true;
        this.label_3.Location = new Point(12, 0x90);
        this.label_3.Name = "label4";
        this.label_3.Size = new Size(0x25, 13);
        this.label_3.TabIndex = 6;
        this.label_3.Text = "Текст";
        this.richTextBox_1.AcceptsTab = true;
        this.richTextBox_1.DataBindings.Add(new Binding("Text", this.dataSetGES_0, "tJ_UpdateProgram.TextUpdate", true));
        this.richTextBox_1.Location = new Point(15, 160);
        this.richTextBox_1.Name = "richTextBox2";
        this.richTextBox_1.Size = new Size(0x200, 0x60);
        this.richTextBox_1.TabIndex = 7;
        this.richTextBox_1.Text = "";
        this.toolStrip_0.Dock = DockStyle.None;
        this.toolStrip_0.GripStyle = ToolStripGripStyle.Hidden;
        ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripButton_0, this.toolStripButton_1 };
        this.toolStrip_0.Items.AddRange(toolStripItems);
        this.toolStrip_0.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
        this.toolStrip_0.Location = new Point(0x11, 0x103);
        this.toolStrip_0.Name = "toolStrip";
        this.toolStrip_0.Size = new Size(0x18, 0x30);
        this.toolStrip_0.TabIndex = 0x10;
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
        this.dataGridView_0.AllowUserToAddRows = false;
        this.dataGridView_0.AllowUserToDeleteRows = false;
        this.dataGridView_0.AllowUserToResizeColumns = false;
        this.dataGridView_0.AllowUserToResizeRows = false;
        this.dataGridView_0.AutoGenerateColumns = false;
        this.dataGridView_0.BackgroundColor = SystemColors.Control;
        this.dataGridView_0.BorderStyle = BorderStyle.None;
        this.dataGridView_0.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView_0.ColumnHeadersVisible = false;
        DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewImageColumnNotNull_0, this.dataGridViewLinkColumn_0, this.dataGridViewTextBoxColumn_0, this.dataGridViewImageColumn_0, this.dataGridViewTextBoxColumn_1 };
        this.dataGridView_0.Columns.AddRange(dataGridViewColumns);
        this.dataGridView_0.DataMember = "tJ_UpdateProgramDoc";
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
        this.dataGridView_0.Location = new Point(0x2c, 0x103);
        this.dataGridView_0.MultiSelect = false;
        this.dataGridView_0.Name = "dgvDocs";
        this.dataGridView_0.ReadOnly = true;
        this.dataGridView_0.RowHeadersVisible = false;
        this.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        this.dataGridView_0.Size = new Size(0x1e3, 0x73);
        this.dataGridView_0.TabIndex = 0x11;
        this.dataGridView_0.VirtualMode = true;
        this.dataGridView_0.CellContentClick += new DataGridViewCellEventHandler(this.dataGridView_0_CellContentClick);
        this.dataGridView_0.CellMouseClick += new DataGridViewCellMouseEventHandler(this.dataGridView_0_CellMouseClick);
        this.dataGridView_0.CellValueNeeded += new DataGridViewCellValueEventHandler(this.dataGridView_0_CellValueNeeded);
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
        this.dataGridViewTextBoxColumn_0.DataPropertyName = "id";
        this.dataGridViewTextBoxColumn_0.HeaderText = "id";
        this.dataGridViewTextBoxColumn_0.Name = "idDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_0.ReadOnly = true;
        this.dataGridViewTextBoxColumn_0.Visible = false;
        this.dataGridViewImageColumn_0.DataPropertyName = "Document";
        this.dataGridViewImageColumn_0.HeaderText = "Document";
        this.dataGridViewImageColumn_0.Name = "documentDataGridViewImageColumn";
        this.dataGridViewImageColumn_0.ReadOnly = true;
        this.dataGridViewImageColumn_0.Visible = false;
        this.dataGridViewTextBoxColumn_1.DataPropertyName = "FileName";
        this.dataGridViewTextBoxColumn_1.HeaderText = "FileName";
        this.dataGridViewTextBoxColumn_1.Name = "fileNameDataGridViewTextBoxColumn";
        this.dataGridViewTextBoxColumn_1.ReadOnly = true;
        this.dataGridViewTextBoxColumn_1.Visible = false;
        this.button_0.DialogResult = DialogResult.Cancel;
        this.button_0.Location = new Point(0x1c4, 380);
        this.button_0.Name = "buttonCancel";
        this.button_0.Size = new Size(0x4b, 0x17);
        this.button_0.TabIndex = 0x13;
        this.button_0.Text = "Отмена";
        this.button_0.UseVisualStyleBackColor = true;
        this.button_1.DialogResult = DialogResult.OK;
        this.button_1.Location = new Point(15, 380);
        this.button_1.Name = "buttonOK";
        this.button_1.Size = new Size(0x4b, 0x17);
        this.button_1.TabIndex = 0x12;
        this.button_1.Text = "ОК";
        this.button_1.UseVisualStyleBackColor = true;
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
        base.AcceptButton = this.button_1;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.CancelButton = this.button_0;
        base.ClientSize = new Size(540, 0x19f);
        base.Controls.Add(this.button_0);
        base.Controls.Add(this.button_1);
        base.Controls.Add(this.dataGridView_0);
        base.Controls.Add(this.toolStrip_0);
        base.Controls.Add(this.richTextBox_1);
        base.Controls.Add(this.label_3);
        base.Controls.Add(this.richTextBox_0);
        base.Controls.Add(this.label_2);
        base.Controls.Add(this.comboBox_0);
        base.Controls.Add(this.label_1);
        base.Controls.Add(this.dateTimePicker_0);
        base.Controls.Add(this.label_0);
        base.Name = "FormAddEditUpdateProgram";
        this.Text = "FormAddEditUpdateProgram";
        base.FormClosing += new FormClosingEventHandler(this.Form36_FormClosing);
        base.Load += new EventHandler(this.Form36_Load);
        this.dataSetGES_0.EndInit();
        this.toolStrip_0.ResumeLayout(false);
        this.toolStrip_0.PerformLayout();
        ((ISupportInitialize) this.dataGridView_0).EndInit();
        this.contextMenuStrip_0.ResumeLayout(false);
        base.ResumeLayout(false);
        base.PerformLayout();
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
                    DataRow row = this.dataSetGES_0.tJ_UpdateProgramDoc.NewRow();
                    row["idUpdate"] = this.int_0;
                    row["Document"] = File.ReadAllBytes(dialog.FileNames[i]);
                    row["FileName"] = dialog.FileNames[i];
                    this.dataSetGES_0.tJ_UpdateProgramDoc.Rows.Add(row);
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
            Convert.ToInt32(this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_0.Name].Value);
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
            int num = Convert.ToInt32(this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_0.Name].Value);
            byte[] buffer = (byte[]) this.dataSetGES_0.tJ_UpdateProgramDoc.method_2(num)["Document"];
            string path = Path.ChangeExtension(Path.GetTempFileName(), Path.GetExtension(this.dataSetGES_0.tJ_UpdateProgramDoc.method_2(num)["FileName"].ToString()));
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
            int num = Convert.ToInt32(this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_0.Name].Value);
            string path = this.dataGridView_0.CurrentRow.Cells[this.dataGridViewLinkColumn_0.Name].Value.ToString();
            string extension = Path.GetExtension(path);
            SaveFileDialog dialog = new SaveFileDialog {
                Filter = "(*" + extension + ")|*" + extension,
                FileName = path
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                byte[] buffer = (byte[]) this.dataSetGES_0.tJ_UpdateProgramDoc.method_2(num)["Document"];
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
}

