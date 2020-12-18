namespace Documents.Forms
{
    using ControlsLbr.DataGridViewExcelFilter;
    using FormLbr;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Windows.Forms;

    public class FormFileExplorer : FormBase
    {
        private DataColumn dataColumn_0;
        private DataColumn dataColumn_1;
        private DataColumn dataColumn_2;
        private DataColumn dataColumn_3;
        private DataColumn dataColumn_4;
        private DataGridView dataGridView_0;
        private DataGridViewImageColumnNotNull dataGridViewImageColumnNotNull_0;
        private DataGridViewLinkColumn dataGridViewLinkColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
        private DataSet dataSet_0;
        private DataTable dataTable_0 = new DataTable();
        private DataTable dataTable_1 = new DataTable();
        private DataTable dataTable_2;
        private IContainer icontainer_0;
        private SplitContainer splitContainer_0;
        private SplitContainer splitContainer_1;
        private TextBox textBox_0;
        private ToolStrip toolStrip_0;
        private ToolStrip toolStrip_1;
        private ToolStripButton toolStripButton_0;
        private ToolStripButton toolStripButton_1;
        private ToolStripButton toolStripButton_2;
        private ToolStripButton toolStripButton_3;
        private TreeView treeView_0;

        public FormFileExplorer()
        {
            this.method_3();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormFileExplorer_Load(object sender, EventArgs e)
        {
            this.method_0();
        }

        private void method_0()
        {
            SqlConnection connection = new SqlConnection(this.get_SqlSettings().GetConnectionString());
            SqlCommand command = new SqlCommand("SELECT [id]\r\n                                                        ,[idparent]\r\n                                                        ,[level]\r\n                                                        ,[name]\r\n                                                        ,[path]\r\n                                                    FROM [vDoc_GetDirectoryFromFileSystem]\r\n                                                    order by [path]", connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                this.dataTable_0.Load(reader);
                reader.Close();
            }
            catch
            {
            }
            finally
            {
                connection.Close();
            }
            TreeNode node = null;
            foreach (DataRow row in this.dataTable_0.Rows)
            {
                Class28 class2 = new Class28(Convert.ToInt32(row["id"]), Convert.ToInt32((row["idparent"] == DBNull.Value) ? 0 : row["idparent"]), Convert.ToInt32(row["level"]), row["name"].ToString(), row["path"].ToString());
                TreeNode node2 = new TreeNode(class2.Name) {
                    Tag = class2
                };
                if (class2.method_2() == 0)
                {
                    this.treeView_0.Nodes.Add(node2);
                }
                else
                {
                    if (node.Level >= class2.method_2())
                    {
                        goto Label_0142;
                    }
                    node.Nodes.Add(node2);
                }
                goto Label_015F;
            Label_013B:
                node = node.Parent;
            Label_0142:
                if (node.Level >= class2.method_2())
                {
                    goto Label_013B;
                }
                node.Nodes.Add(node2);
            Label_015F:
                node = node2;
            }
        }

        private void method_1(Class28 class28_0)
        {
            int id = class28_0.Id;
            SqlConnection connection = new SqlConnection(this.get_SqlSettings().GetConnectionString());
            SqlCommand command = new SqlCommand("SELECT [id]\r\n                                                        ,[idParent]\r\n                                                        ,[Name]\r\n                                                        ,[Comment]\r\n                                                        ,[idOwner]\r\n                                                        ,[DateIn]\r\n                                                    FROM tDoc_FileSystem\r\n                                                    where idParent = " + id + " and isdirectory = 0", connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                this.dataTable_1.Load(reader);
                reader.Close();
            }
            catch
            {
            }
            finally
            {
                connection.Close();
            }
        }

        private string method_2(Class29 class29_0)
        {
            SqlConnection connection = new SqlConnection(this.get_SqlSettings().GetConnectionString());
            new SqlCommand("SELECT [id]                                                        \r\n                                                        ,[Name]\r\n                                                        ,[Data]\r\n                                                    FROM tDoc_FileSystem\r\n                                                    where isdirectory = 0", connection);
            return string.Empty;
        }

        private void method_3()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(FormFileExplorer));
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            DataGridViewCellStyle style3 = new DataGridViewCellStyle();
            DataGridViewCellStyle style4 = new DataGridViewCellStyle();
            this.splitContainer_0 = new SplitContainer();
            this.treeView_0 = new TreeView();
            this.toolStrip_1 = new ToolStrip();
            this.toolStripButton_2 = new ToolStripButton();
            this.toolStripButton_3 = new ToolStripButton();
            this.splitContainer_1 = new SplitContainer();
            this.textBox_0 = new TextBox();
            this.toolStrip_0 = new ToolStrip();
            this.toolStripButton_0 = new ToolStripButton();
            this.toolStripButton_1 = new ToolStripButton();
            this.dataGridView_0 = new DataGridView();
            this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
            this.dataGridViewImageColumnNotNull_0 = new DataGridViewImageColumnNotNull();
            this.dataGridViewLinkColumn_0 = new DataGridViewLinkColumn();
            this.dataSet_0 = new DataSet();
            this.dataTable_2 = new DataTable();
            this.dataColumn_0 = new DataColumn();
            this.dataColumn_1 = new DataColumn();
            this.dataColumn_2 = new DataColumn();
            this.dataColumn_3 = new DataColumn();
            this.dataColumn_4 = new DataColumn();
            this.splitContainer_0.Panel1.SuspendLayout();
            this.splitContainer_0.Panel2.SuspendLayout();
            this.splitContainer_0.SuspendLayout();
            this.toolStrip_1.SuspendLayout();
            this.splitContainer_1.Panel1.SuspendLayout();
            this.splitContainer_1.Panel2.SuspendLayout();
            this.splitContainer_1.SuspendLayout();
            this.toolStrip_0.SuspendLayout();
            ((ISupportInitialize) this.dataGridView_0).BeginInit();
            this.dataSet_0.BeginInit();
            this.dataTable_2.BeginInit();
            base.SuspendLayout();
            this.splitContainer_0.Dock = DockStyle.Fill;
            this.splitContainer_0.Location = new Point(0, 0);
            this.splitContainer_0.Name = "splitContainer1";
            this.splitContainer_0.Panel1.Controls.Add(this.treeView_0);
            this.splitContainer_0.Panel1.Controls.Add(this.toolStrip_1);
            this.splitContainer_0.Panel2.Controls.Add(this.splitContainer_1);
            this.splitContainer_0.Panel2.Controls.Add(this.toolStrip_0);
            this.splitContainer_0.Size = new Size(0x1aa, 0x179);
            this.splitContainer_0.SplitterDistance = 0x8e;
            this.splitContainer_0.TabIndex = 0;
            this.treeView_0.Dock = DockStyle.Fill;
            this.treeView_0.Location = new Point(0, 0x19);
            this.treeView_0.Name = "treeView1";
            this.treeView_0.Size = new Size(0x8e, 0x160);
            this.treeView_0.TabIndex = 0;
            this.treeView_0.AfterSelect += new TreeViewEventHandler(this.treeView_0_AfterSelect);
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripButton_2, this.toolStripButton_3 };
            this.toolStrip_1.Items.AddRange(toolStripItems);
            this.toolStrip_1.Location = new Point(0, 0);
            this.toolStrip_1.Name = "toolStrip2";
            this.toolStrip_1.Size = new Size(0x8e, 0x19);
            this.toolStrip_1.TabIndex = 1;
            this.toolStrip_1.Text = "toolStrip2";
            this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_2.Image = (Image) manager.GetObject("toolStripButton3.Image");
            this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_2.Name = "toolStripButton3";
            this.toolStripButton_2.Size = new Size(0x17, 0x16);
            this.toolStripButton_2.Text = "toolStripButton1";
            this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_3.Image = (Image) manager.GetObject("toolStripButton4.Image");
            this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_3.Name = "toolStripButton4";
            this.toolStripButton_3.Size = new Size(0x17, 0x16);
            this.toolStripButton_3.Text = "toolStripButton2";
            this.splitContainer_1.Dock = DockStyle.Fill;
            this.splitContainer_1.Location = new Point(0, 0x19);
            this.splitContainer_1.Name = "splitContainer2";
            this.splitContainer_1.Orientation = Orientation.Horizontal;
            this.splitContainer_1.Panel1.Controls.Add(this.dataGridView_0);
            this.splitContainer_1.Panel2.Controls.Add(this.textBox_0);
            this.splitContainer_1.Size = new Size(280, 0x160);
            this.splitContainer_1.SplitterDistance = 0x107;
            this.splitContainer_1.TabIndex = 1;
            this.textBox_0.Dock = DockStyle.Fill;
            this.textBox_0.Location = new Point(0, 0);
            this.textBox_0.Multiline = true;
            this.textBox_0.Name = "textBox1";
            this.textBox_0.Size = new Size(280, 0x55);
            this.textBox_0.TabIndex = 0;
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.toolStripButton_0, this.toolStripButton_1 };
            this.toolStrip_0.Items.AddRange(itemArray2);
            this.toolStrip_0.Location = new Point(0, 0);
            this.toolStrip_0.Name = "toolStrip1";
            this.toolStrip_0.Size = new Size(280, 0x19);
            this.toolStrip_0.TabIndex = 0;
            this.toolStrip_0.Text = "toolStrip1";
            this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_0.Image = (Image) manager.GetObject("toolStripButton1.Image");
            this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_0.Name = "toolStripButton1";
            this.toolStripButton_0.Size = new Size(0x17, 0x16);
            this.toolStripButton_0.Text = "toolStripButton1";
            this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_1.Image = (Image) manager.GetObject("toolStripButton2.Image");
            this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_1.Name = "toolStripButton2";
            this.toolStripButton_1.Size = new Size(0x17, 0x16);
            this.toolStripButton_1.Text = "toolStripButton2";
            this.dataGridView_0.AllowUserToAddRows = false;
            this.dataGridView_0.AllowUserToDeleteRows = false;
            this.dataGridView_0.AllowUserToResizeColumns = false;
            this.dataGridView_0.AllowUserToResizeRows = false;
            this.dataGridView_0.BackgroundColor = Color.White;
            this.dataGridView_0.BorderStyle = BorderStyle.None;
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
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_0, this.dataGridViewImageColumnNotNull_0, this.dataGridViewLinkColumn_0 };
            this.dataGridView_0.Columns.AddRange(dataGridViewColumns);
            this.dataGridView_0.DataMember = "tJ_RequestDoc";
            style2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style2.BackColor = SystemColors.Control;
            style2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style2.ForeColor = SystemColors.ControlText;
            style2.SelectionBackColor = SystemColors.Highlight;
            style2.SelectionForeColor = SystemColors.HighlightText;
            style2.WrapMode = DataGridViewTriState.False;
            this.dataGridView_0.DefaultCellStyle = style2;
            this.dataGridView_0.Dock = DockStyle.Fill;
            this.dataGridView_0.GridColor = SystemColors.Control;
            this.dataGridView_0.Location = new Point(0, 0);
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
            this.dataGridView_0.Size = new Size(280, 0x107);
            this.dataGridView_0.TabIndex = 0x10;
            this.dataGridView_0.VirtualMode = true;
            this.dataGridViewTextBoxColumn_0.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn_0.HeaderText = "Id";
            this.dataGridViewTextBoxColumn_0.Name = "IdDocDgvTxtColumn";
            this.dataGridViewTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewTextBoxColumn_0.Visible = false;
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
            this.dataSet_0.DataSetName = "NewDataSet";
            DataTable[] tables = new DataTable[] { this.dataTable_2 };
            this.dataSet_0.Tables.AddRange(tables);
            DataColumn[] columns = new DataColumn[] { this.dataColumn_0, this.dataColumn_1, this.dataColumn_2, this.dataColumn_3, this.dataColumn_4 };
            this.dataTable_2.Columns.AddRange(columns);
            this.dataTable_2.TableName = "Table1";
            this.dataColumn_0.AllowDBNull = false;
            this.dataColumn_0.AutoIncrement = true;
            this.dataColumn_0.ColumnName = "id";
            this.dataColumn_0.DataType = typeof(int);
            this.dataColumn_1.AllowDBNull = false;
            this.dataColumn_1.ColumnName = "Name";
            this.dataColumn_2.ColumnName = "Data";
            this.dataColumn_2.DataType = typeof(byte[]);
            this.dataColumn_3.ColumnName = "Comment";
            this.dataColumn_4.ColumnName = "Column1";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x1aa, 0x179);
            base.Controls.Add(this.splitContainer_0);
            base.Name = "FormFileExplorer";
            this.Text = "FormFileExplorer";
            base.Load += new EventHandler(this.FormFileExplorer_Load);
            this.splitContainer_0.Panel1.ResumeLayout(false);
            this.splitContainer_0.Panel1.PerformLayout();
            this.splitContainer_0.Panel2.ResumeLayout(false);
            this.splitContainer_0.Panel2.PerformLayout();
            this.splitContainer_0.ResumeLayout(false);
            this.toolStrip_1.ResumeLayout(false);
            this.toolStrip_1.PerformLayout();
            this.splitContainer_1.Panel1.ResumeLayout(false);
            this.splitContainer_1.Panel2.ResumeLayout(false);
            this.splitContainer_1.Panel2.PerformLayout();
            this.splitContainer_1.ResumeLayout(false);
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            ((ISupportInitialize) this.dataGridView_0).EndInit();
            this.dataSet_0.EndInit();
            this.dataTable_2.EndInit();
            base.ResumeLayout(false);
        }

        private void treeView_0_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }
    }
}

