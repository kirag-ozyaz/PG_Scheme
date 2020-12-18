namespace Documents.Forms
{
    using ControlsLbr.DataGridViewExcelFilter;
    using DataSql;
    using Documents.Properties;
    using FormLbr;
    using FormLbr.Classes;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;

    public class FormFiles : FormBase
    {
        private bool bool_0;
        private DataColumn dataColumn_0;
        private DataColumn dataColumn_1;
        private DataColumn dataColumn_2;
        private DataColumn dataColumn_3;
        private DataColumn dataColumn_4;
        private DataColumn dataColumn_5;
        private DataGridView dataGridView_0;
        private DataGridViewImageColumnNotNull dataGridViewImageColumnNotNull_0;
        private DataGridViewLinkColumn dataGridViewLinkColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
        private DataSet dataSet_0;
        private DataSet dataSet_1;
        private DataTable dataTable_0;
        private DataTable dataTable_1;
        private DataTable dataTable_2;
        private DataTable dataTable_3;
        private IContainer icontainer_0;
        private int int_0;
        private List<int> list_0;
        private ToolStrip toolStrip_0;
        private ToolStripButton toolStripButton_0;
        private ToolStripButton toolStripButton_1;

        public FormFiles(SQLSettings sqlSettings)
        {
            this.int_0 = -1;
            this.list_0 = new List<int>();
            this.method_0();
            this.dataTable_0 = this.dataSet_0.Tables["tblAbnReqFiles"];
            this.dataTable_1 = this.dataSet_1.Tables["tblAbnReqFiles"];
            this.set_SqlSettings(sqlSettings);
        }

        public FormFiles(SQLSettings sqlSettings, int int_1)
        {
            this.int_0 = -1;
            this.list_0 = new List<int>();
            this.method_0();
            this.int_0 = int_1;
            this.dataTable_0 = this.dataSet_0.Tables["tblAbnReqFiles"];
            this.dataTable_1 = this.dataSet_1.Tables["tblAbnReqFiles"];
            this.LoadFiles();
        }

        private void dataGridView_0_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView_0.CurrentRow != null)
            {
                int num = Convert.ToInt32(this.dataTable_0.Rows[this.dataGridView_0.CurrentRow.Index]["Id"]);
                if (num > 0)
                {
                    this.dataTable_1.Clear();
                    base.SelectSqlData(this.dataSet_1, this.dataTable_1, true, "where Id =" + num.ToString());
                    byte[] buffer = (byte[]) this.dataTable_1.Rows[0]["AttachedFile"];
                    string path = Path.ChangeExtension(Path.GetTempFileName(), Path.GetExtension(this.dataTable_0.Rows[this.dataGridView_0.CurrentRow.Index]["FileName"].ToString()));
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
            if (e.Button == MouseButtons.Right)
            {
                int rowIndex = e.RowIndex;
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

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormFiles_Load(object sender, EventArgs e)
        {
        }

        public void LoadFiles()
        {
            if (this.int_0 != -1)
            {
                this.dataTable_0.Clear();
                base.SelectSqlData(this.dataSet_0, this.dataTable_0, true, "where IdRequest = " + this.int_0.ToString());
            }
        }

        private void method_0()
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            DataGridViewCellStyle style3 = new DataGridViewCellStyle();
            DataGridViewCellStyle style4 = new DataGridViewCellStyle();
            this.toolStrip_0 = new ToolStrip();
            this.toolStripButton_0 = new ToolStripButton();
            this.toolStripButton_1 = new ToolStripButton();
            this.dataSet_0 = new DataSet();
            this.dataTable_2 = new DataTable();
            this.dataColumn_0 = new DataColumn();
            this.dataColumn_1 = new DataColumn();
            this.dataColumn_2 = new DataColumn();
            this.dataGridView_0 = new DataGridView();
            this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
            this.dataGridViewImageColumnNotNull_0 = new DataGridViewImageColumnNotNull();
            this.dataGridViewLinkColumn_0 = new DataGridViewLinkColumn();
            this.dataSet_1 = new DataSet();
            this.dataTable_3 = new DataTable();
            this.dataColumn_3 = new DataColumn();
            this.dataColumn_4 = new DataColumn();
            this.dataColumn_5 = new DataColumn();
            this.toolStrip_0.SuspendLayout();
            this.dataSet_0.BeginInit();
            this.dataTable_2.BeginInit();
            ((ISupportInitialize) this.dataGridView_0).BeginInit();
            this.dataSet_1.BeginInit();
            this.dataTable_3.BeginInit();
            base.SuspendLayout();
            this.toolStrip_0.Dock = DockStyle.None;
            this.toolStrip_0.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripButton_0, this.toolStripButton_1 };
            this.toolStrip_0.Items.AddRange(toolStripItems);
            this.toolStrip_0.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip_0.Location = new Point(9, 9);
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
            this.dataSet_0.DataSetName = "NewDataSet";
            DataTable[] tables = new DataTable[] { this.dataTable_2 };
            this.dataSet_0.Tables.AddRange(tables);
            DataColumn[] columns = new DataColumn[] { this.dataColumn_0, this.dataColumn_1, this.dataColumn_2 };
            this.dataTable_2.Columns.AddRange(columns);
            Constraint[] constraints = new Constraint[1];
            string[] columnNames = new string[] { "Id" };
            constraints[0] = new UniqueConstraint("Constraint1", columnNames, true);
            this.dataTable_2.Constraints.AddRange(constraints);
            this.dataTable_2.PrimaryKey = new DataColumn[] { this.dataColumn_0 };
            this.dataTable_2.TableName = "tblAbnReqFiles";
            this.dataColumn_0.AllowDBNull = false;
            this.dataColumn_0.AutoIncrement = true;
            this.dataColumn_0.ColumnName = "Id";
            this.dataColumn_0.DataType = typeof(int);
            this.dataColumn_1.ColumnName = "IdRequest";
            this.dataColumn_1.DataType = typeof(int);
            this.dataColumn_2.ColumnName = "FileName";
            this.dataGridView_0.AllowUserToAddRows = false;
            this.dataGridView_0.AllowUserToDeleteRows = false;
            this.dataGridView_0.AllowUserToResizeColumns = false;
            this.dataGridView_0.AllowUserToResizeRows = false;
            this.dataGridView_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.dataGridView_0.AutoGenerateColumns = false;
            this.dataGridView_0.BackgroundColor = SystemColors.Control;
            this.dataGridView_0.BorderStyle = BorderStyle.Fixed3D;
            this.dataGridView_0.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style.BackColor = SystemColors.Control;
            style.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style.ForeColor = SystemColors.WindowText;
            style.SelectionBackColor = SystemColors.Highlight;
            style.SelectionForeColor = SystemColors.HighlightText;
            style.WrapMode = DataGridViewTriState.True;
            this.dataGridView_0.ColumnHeadersDefaultCellStyle = style;
            this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_0.ColumnHeadersVisible = false;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_0, this.dataGridViewTextBoxColumn_1, this.dataGridViewImageColumnNotNull_0, this.dataGridViewLinkColumn_0 };
            this.dataGridView_0.Columns.AddRange(dataGridViewColumns);
            this.dataGridView_0.DataMember = "tblAbnReqFiles";
            this.dataGridView_0.DataSource = this.dataSet_0;
            style2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style2.BackColor = SystemColors.Control;
            style2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style2.ForeColor = SystemColors.ControlText;
            style2.SelectionBackColor = SystemColors.Highlight;
            style2.SelectionForeColor = SystemColors.HighlightText;
            style2.WrapMode = DataGridViewTriState.False;
            this.dataGridView_0.DefaultCellStyle = style2;
            this.dataGridView_0.GridColor = SystemColors.Control;
            this.dataGridView_0.Location = new Point(0x24, 9);
            this.dataGridView_0.MultiSelect = false;
            this.dataGridView_0.Name = "dgvDocs";
            this.dataGridView_0.ReadOnly = true;
            style3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style3.BackColor = SystemColors.Control;
            style3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style3.ForeColor = SystemColors.WindowText;
            style3.SelectionBackColor = SystemColors.Highlight;
            style3.SelectionForeColor = SystemColors.HighlightText;
            style3.WrapMode = DataGridViewTriState.True;
            this.dataGridView_0.RowHeadersDefaultCellStyle = style3;
            this.dataGridView_0.RowHeadersVisible = false;
            this.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_0.Size = new Size(0x112, 0xcc);
            this.dataGridView_0.TabIndex = 0x11;
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
            style4.NullValue = null;
            this.dataGridViewImageColumnNotNull_0.DefaultCellStyle = style4;
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
            this.dataSet_1.DataSetName = "NewDataSet";
            DataTable[] tableArray2 = new DataTable[] { this.dataTable_3 };
            this.dataSet_1.Tables.AddRange(tableArray2);
            DataColumn[] columnArray4 = new DataColumn[] { this.dataColumn_3, this.dataColumn_4, this.dataColumn_5 };
            this.dataTable_3.Columns.AddRange(columnArray4);
            this.dataTable_3.TableName = "tblAbnReqFiles";
            this.dataColumn_3.ColumnName = "IdRequest";
            this.dataColumn_3.DataType = typeof(int);
            this.dataColumn_4.ColumnName = "AttachedFile";
            this.dataColumn_4.DataType = typeof(byte[]);
            this.dataColumn_5.ColumnName = "FileName";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x142, 0xe1);
            base.ControlBox = false;
            base.Controls.Add(this.dataGridView_0);
            base.Controls.Add(this.toolStrip_0);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.Name = "FormFiles";
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.Manual;
            base.Load += new EventHandler(this.FormFiles_Load);
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            this.dataSet_0.EndInit();
            this.dataTable_2.EndInit();
            ((ISupportInitialize) this.dataGridView_0).EndInit();
            this.dataSet_1.EndInit();
            this.dataTable_3.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        protected override void OnDeactivate(EventArgs eventArgs_0)
        {
            if (!this.bool_0)
            {
                base.OnDeactivate(eventArgs_0);
                base.Hide();
            }
        }

        public void SaveFiles()
        {
            if (this.int_0 != -1)
            {
                DataTable changes = this.dataTable_0.GetChanges(DataRowState.Added);
                if (changes != null)
                {
                    this.dataTable_1.Clear();
                    foreach (DataRow row in changes.Rows)
                    {
                        DataRow row2 = this.dataTable_1.NewRow();
                        row2["idRequest"] = this.IdRequest;
                        row2["FileName"] = row["FileName"];
                        row2["AttachedFile"] = File.ReadAllBytes(row["FileName"].ToString());
                        this.dataTable_1.Rows.Add(row2);
                    }
                    base.InsertSqlData(this.dataSet_1, this.dataTable_1);
                }
                base.DeleteSqlData(this.dataSet_0, this.dataTable_0);
            }
        }

        private void toolStripButton_0_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog {
                    Multiselect = true
                };
                this.bool_0 = true;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    for (int i = 0; i < dialog.FileNames.Length; i++)
                    {
                        DataRow row = this.dataSet_0.Tables[0].NewRow();
                        row["idRequest"] = -1;
                        row["FileName"] = dialog.FileNames[i];
                        this.dataSet_0.Tables[0].Rows.Add(row);
                    }
                }
                this.bool_0 = false;
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
                int index = this.dataGridView_0.CurrentRow.Index;
                this.dataTable_0.Rows[index].Delete();
            }
            else
            {
                MessageBox.Show("Не выбрано ни одного файла");
            }
        }

        public int IdRequest
        {
            get
            {
                return this.int_0;
            }
            set
            {
                this.int_0 = value;
            }
        }
    }
}

