namespace Documents.Forms.Memorandums
{
    using Documents.DataSets;
    using Documents.Properties;
    using FormLbr;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    public class FormBossUsers : FormBase
    {
        private BindingSource bindingSource_0;
        private Button button_0;
        private ContextMenuStrip contextMenuStrip_0;
        private ContextMenuStrip contextMenuStrip_1;
        private DataGridView dataGridView_0;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;
        private DataSetGES dataSetGES_0;
        private IContainer icontainer_0;
        private List<int> list_0;
        private TableLayoutPanel tableLayoutPanel_0;
        private ToolStrip toolStrip_0;
        private ToolStrip toolStrip_1;
        private ToolStripButton toolStripButton_0;
        private ToolStripButton toolStripButton_1;
        private ToolStripButton toolStripButton_2;
        private ToolStripButton toolStripButton_3;
        private ToolStripButton toolStripButton_4;
        private ToolStripButton toolStripButton_5;
        private ToolStripButton toolStripButton_6;
        private ToolStripButton toolStripButton_7;
        private ToolStripButton toolStripButton_8;
        private ToolStripMenuItem toolStripMenuItem_0;
        private ToolStripMenuItem toolStripMenuItem_1;
        private ToolStripMenuItem toolStripMenuItem_2;
        private ToolStripMenuItem toolStripMenuItem_3;
        private ToolStripMenuItem toolStripMenuItem_4;
        private ToolStripMenuItem toolStripMenuItem_5;
        private ToolStripMenuItem toolStripMenuItem_6;
        private ToolStripMenuItem toolStripMenuItem_7;
        private ToolStripMenuItem toolStripMenuItem_8;
        private ToolStripSeparator toolStripSeparator_0;
        private ToolStripSeparator toolStripSeparator_1;
        private ToolStripSeparator toolStripSeparator_2;
        private ToolStripSeparator toolStripSeparator_3;
        private ToolStripSeparator toolStripSeparator_4;
        private ToolStripSeparator toolStripSeparator_5;
        private ToolStripSeparator toolStripSeparator_6;
        private ToolStripSeparator toolStripSeparator_7;
        private TreeView treeView_0;

        public FormBossUsers()
        {
            this.method_13();
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void dataGridView_0_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((e.ColumnIndex >= 0) && (e.RowIndex >= 0))
            {
                this.toolStripButton_1_Click(this.toolStripButton_4, e);
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

        private void FormBossUsers_Load(object sender, EventArgs e)
        {
            this.method_1();
        }

        private void method_0(object sender, FormClosedEventArgs e)
        {
            Form24 form = (Form24) sender;
            this.method_2(form.Id);
        }

        private void method_1()
        {
            base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_BossUserGroup, true, "WHERE Deleted = 0");
            this.method_3();
        }

        private void method_10(object sender, FormClosedEventArgs e)
        {
            Form23 form = (Form23) sender;
            this.method_12((int) this.treeView_0.SelectedNode.Tag, form.Id);
        }

        private void method_11(int int_0)
        {
            base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_BossUser, true, "WHERE idGroup = " + int_0.ToString() + " AND Deleted = 0");
        }

        private void method_12(int int_0, int int_1)
        {
            base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_BossUser, true, "WHERE idGroup = " + int_0.ToString() + " AND Deleted = 0");
            this.bindingSource_0.Position = this.bindingSource_0.Find("id", int_1);
        }

        private void method_13()
        {
            this.icontainer_0 = new Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(FormBossUsers));
            this.tableLayoutPanel_0 = new TableLayoutPanel();
            this.dataGridView_0 = new DataGridView();
            this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
            this.contextMenuStrip_1 = new ContextMenuStrip(this.icontainer_0);
            this.toolStripMenuItem_0 = new ToolStripMenuItem();
            this.toolStripMenuItem_1 = new ToolStripMenuItem();
            this.toolStripMenuItem_2 = new ToolStripMenuItem();
            this.toolStripSeparator_4 = new ToolStripSeparator();
            this.toolStripMenuItem_3 = new ToolStripMenuItem();
            this.toolStripSeparator_5 = new ToolStripSeparator();
            this.toolStripMenuItem_4 = new ToolStripMenuItem();
            this.bindingSource_0 = new BindingSource(this.icontainer_0);
            this.dataSetGES_0 = new DataSetGES();
            this.treeView_0 = new TreeView();
            this.contextMenuStrip_0 = new ContextMenuStrip(this.icontainer_0);
            this.toolStripMenuItem_5 = new ToolStripMenuItem();
            this.toolStripMenuItem_6 = new ToolStripMenuItem();
            this.toolStripSeparator_6 = new ToolStripSeparator();
            this.toolStripMenuItem_7 = new ToolStripMenuItem();
            this.toolStripSeparator_7 = new ToolStripSeparator();
            this.toolStripMenuItem_8 = new ToolStripMenuItem();
            this.button_0 = new Button();
            this.toolStrip_0 = new ToolStrip();
            this.toolStripButton_0 = new ToolStripButton();
            this.toolStripButton_1 = new ToolStripButton();
            this.toolStripButton_8 = new ToolStripButton();
            this.toolStripSeparator_0 = new ToolStripSeparator();
            this.toolStripButton_2 = new ToolStripButton();
            this.toolStripSeparator_1 = new ToolStripSeparator();
            this.toolStripButton_6 = new ToolStripButton();
            this.toolStrip_1 = new ToolStrip();
            this.toolStripButton_3 = new ToolStripButton();
            this.toolStripButton_4 = new ToolStripButton();
            this.toolStripSeparator_2 = new ToolStripSeparator();
            this.toolStripButton_5 = new ToolStripButton();
            this.toolStripSeparator_3 = new ToolStripSeparator();
            this.toolStripButton_7 = new ToolStripButton();
            this.tableLayoutPanel_0.SuspendLayout();
            ((ISupportInitialize) this.dataGridView_0).BeginInit();
            this.contextMenuStrip_1.SuspendLayout();
            ((ISupportInitialize) this.bindingSource_0).BeginInit();
            this.dataSetGES_0.BeginInit();
            this.contextMenuStrip_0.SuspendLayout();
            this.toolStrip_0.SuspendLayout();
            this.toolStrip_1.SuspendLayout();
            base.SuspendLayout();
            this.tableLayoutPanel_0.ColumnCount = 3;
            this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.71533f));
            this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.28467f));
            this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 102f));
            this.tableLayoutPanel_0.Controls.Add(this.dataGridView_0, 1, 1);
            this.tableLayoutPanel_0.Controls.Add(this.treeView_0, 0, 1);
            this.tableLayoutPanel_0.Controls.Add(this.button_0, 2, 2);
            this.tableLayoutPanel_0.Controls.Add(this.toolStrip_0, 1, 0);
            this.tableLayoutPanel_0.Controls.Add(this.toolStrip_1, 0, 0);
            this.tableLayoutPanel_0.Dock = DockStyle.Fill;
            this.tableLayoutPanel_0.Location = new Point(0, 0);
            this.tableLayoutPanel_0.Name = "tlpGeneral";
            this.tableLayoutPanel_0.RowCount = 3;
            this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
            this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 39f));
            this.tableLayoutPanel_0.Size = new Size(0x20a, 400);
            this.tableLayoutPanel_0.TabIndex = 0;
            this.dataGridView_0.AllowUserToAddRows = false;
            this.dataGridView_0.AllowUserToDeleteRows = false;
            this.dataGridView_0.AllowUserToOrderColumns = true;
            this.dataGridView_0.AutoGenerateColumns = false;
            this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_0, this.dataGridViewTextBoxColumn_1, this.dataGridViewTextBoxColumn_2, this.dataGridViewTextBoxColumn_3, this.dataGridViewTextBoxColumn_4, this.dataGridViewTextBoxColumn_5, this.dataGridViewCheckBoxColumn_0, this.dataGridViewTextBoxColumn_6 };
            this.dataGridView_0.Columns.AddRange(dataGridViewColumns);
            this.tableLayoutPanel_0.SetColumnSpan(this.dataGridView_0, 2);
            this.dataGridView_0.ContextMenuStrip = this.contextMenuStrip_1;
            this.dataGridView_0.DataSource = this.bindingSource_0;
            this.dataGridView_0.Dock = DockStyle.Fill;
            this.dataGridView_0.Location = new Point(0xc7, 0x19);
            this.dataGridView_0.Name = "dgvUser";
            this.dataGridView_0.ReadOnly = true;
            this.dataGridView_0.RowHeadersVisible = false;
            this.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_0.Size = new Size(320, 0x14d);
            this.dataGridView_0.TabIndex = 1;
            this.dataGridView_0.CellMouseDoubleClick += new DataGridViewCellMouseEventHandler(this.dataGridView_0_CellMouseDoubleClick);
            this.dataGridViewTextBoxColumn_0.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_0.HeaderText = "id";
            this.dataGridViewTextBoxColumn_0.Name = "idDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewTextBoxColumn_0.Visible = false;
            this.dataGridViewTextBoxColumn_1.DataPropertyName = "idGroup";
            this.dataGridViewTextBoxColumn_1.HeaderText = "idGroup";
            this.dataGridViewTextBoxColumn_1.Name = "idGroupDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_1.ReadOnly = true;
            this.dataGridViewTextBoxColumn_1.Visible = false;
            this.dataGridViewTextBoxColumn_2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn_2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn_2.Name = "firstNameDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_2.ReadOnly = true;
            this.dataGridViewTextBoxColumn_3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn_3.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn_3.Name = "lastNameDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_3.ReadOnly = true;
            this.dataGridViewTextBoxColumn_4.DataPropertyName = "MiddleInitial";
            this.dataGridViewTextBoxColumn_4.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn_4.Name = "middleInitialDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_4.ReadOnly = true;
            this.dataGridViewTextBoxColumn_5.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn_5.HeaderText = "Password";
            this.dataGridViewTextBoxColumn_5.Name = "passwordDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_5.ReadOnly = true;
            this.dataGridViewTextBoxColumn_5.Visible = false;
            this.dataGridViewCheckBoxColumn_0.DataPropertyName = "Deleted";
            this.dataGridViewCheckBoxColumn_0.HeaderText = "Deleted";
            this.dataGridViewCheckBoxColumn_0.Name = "deletedDataGridViewCheckBoxColumn";
            this.dataGridViewCheckBoxColumn_0.ReadOnly = true;
            this.dataGridViewCheckBoxColumn_0.Visible = false;
            this.dataGridViewTextBoxColumn_6.DataPropertyName = "BossUNID";
            this.dataGridViewTextBoxColumn_6.HeaderText = "BossUNID";
            this.dataGridViewTextBoxColumn_6.Name = "bossUNIDDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_6.ReadOnly = true;
            this.dataGridViewTextBoxColumn_6.Visible = false;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripMenuItem_0, this.toolStripMenuItem_1, this.toolStripMenuItem_2, this.toolStripSeparator_4, this.toolStripMenuItem_3, this.toolStripSeparator_5, this.toolStripMenuItem_4 };
            this.contextMenuStrip_1.Items.AddRange(toolStripItems);
            this.contextMenuStrip_1.Name = "cmsUser";
            this.contextMenuStrip_1.Size = new Size(0x9b, 0x7e);
            this.toolStripMenuItem_0.Image = Resources.ElementAdd;
            this.toolStripMenuItem_0.Name = "tsmiAddUser";
            this.toolStripMenuItem_0.Size = new Size(0x9a, 0x16);
            this.toolStripMenuItem_0.Text = "Добавить";
            this.toolStripMenuItem_0.Click += new EventHandler(this.toolStripButton_0_Click);
            this.toolStripMenuItem_1.Image = Resources.ElementEdit;
            this.toolStripMenuItem_1.Name = "tsmiEditUser";
            this.toolStripMenuItem_1.Size = new Size(0x9a, 0x16);
            this.toolStripMenuItem_1.Text = "Редактировать";
            this.toolStripMenuItem_1.Click += new EventHandler(this.toolStripButton_1_Click);
            this.toolStripMenuItem_2.Image = Resources.ElementInformation;
            this.toolStripMenuItem_2.Name = "tsmiViewUser";
            this.toolStripMenuItem_2.Size = new Size(0x9a, 0x16);
            this.toolStripMenuItem_2.Text = "Просмотр";
            this.toolStripMenuItem_2.Click += new EventHandler(this.toolStripButton_8_Click);
            this.toolStripSeparator_4.Name = "toolStripSeparator7";
            this.toolStripSeparator_4.Size = new Size(0x97, 6);
            this.toolStripMenuItem_3.Image = Resources.ElementDel;
            this.toolStripMenuItem_3.Name = "tsmiDeleteUser";
            this.toolStripMenuItem_3.Size = new Size(0x9a, 0x16);
            this.toolStripMenuItem_3.Text = "Удалить";
            this.toolStripMenuItem_3.Click += new EventHandler(this.toolStripButton_2_Click);
            this.toolStripSeparator_5.Name = "toolStripSeparator8";
            this.toolStripSeparator_5.Size = new Size(0x97, 6);
            this.toolStripMenuItem_4.Image = Resources.refresh_16;
            this.toolStripMenuItem_4.Name = "tsmiRefreshUser";
            this.toolStripMenuItem_4.Size = new Size(0x9a, 0x16);
            this.toolStripMenuItem_4.Text = "Обновить";
            this.toolStripMenuItem_4.Click += new EventHandler(this.toolStripButton_6_Click);
            this.bindingSource_0.DataMember = "tJ_BossUser";
            this.bindingSource_0.DataSource = this.dataSetGES_0;
            this.dataSetGES_0.DataSetName = "DataSetGES";
            this.dataSetGES_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.treeView_0.ContextMenuStrip = this.contextMenuStrip_0;
            this.treeView_0.Dock = DockStyle.Fill;
            this.treeView_0.Location = new Point(3, 0x19);
            this.treeView_0.Name = "trvGroup";
            this.treeView_0.Size = new Size(190, 0x14d);
            this.treeView_0.TabIndex = 0;
            this.treeView_0.AfterSelect += new TreeViewEventHandler(this.treeView_0_AfterSelect);
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.toolStripMenuItem_5, this.toolStripMenuItem_6, this.toolStripSeparator_6, this.toolStripMenuItem_7, this.toolStripSeparator_7, this.toolStripMenuItem_8 };
            this.contextMenuStrip_0.Items.AddRange(itemArray2);
            this.contextMenuStrip_0.Name = "cmsGroup";
            this.contextMenuStrip_0.Size = new Size(0x9b, 0x68);
            this.toolStripMenuItem_5.Image = Resources._1353328228_folder_add;
            this.toolStripMenuItem_5.Name = "tsmiAddGroup";
            this.toolStripMenuItem_5.Size = new Size(0x9a, 0x16);
            this.toolStripMenuItem_5.Text = "Добавить";
            this.toolStripMenuItem_5.Click += new EventHandler(this.toolStripButton_3_Click);
            this.toolStripMenuItem_6.Image = Resources.FolderEditYellow;
            this.toolStripMenuItem_6.Name = "tsmiEditGroup";
            this.toolStripMenuItem_6.Size = new Size(0x9a, 0x16);
            this.toolStripMenuItem_6.Text = "Редактировать";
            this.toolStripMenuItem_6.Click += new EventHandler(this.toolStripButton_4_Click);
            this.toolStripSeparator_6.Name = "toolStripSeparator5";
            this.toolStripSeparator_6.Size = new Size(0x97, 6);
            this.toolStripMenuItem_7.Image = Resources._1353328250_folder_open_delete;
            this.toolStripMenuItem_7.Name = "tsmiDeleteGroup";
            this.toolStripMenuItem_7.Size = new Size(0x9a, 0x16);
            this.toolStripMenuItem_7.Text = "Удалить";
            this.toolStripMenuItem_7.Click += new EventHandler(this.toolStripButton_5_Click);
            this.toolStripSeparator_7.Name = "toolStripSeparator6";
            this.toolStripSeparator_7.Size = new Size(0x97, 6);
            this.toolStripMenuItem_8.Image = Resources.refresh_16;
            this.toolStripMenuItem_8.Name = "tsmiRefreshGroup";
            this.toolStripMenuItem_8.Size = new Size(0x9a, 0x16);
            this.toolStripMenuItem_8.Text = "Обновить";
            this.toolStripMenuItem_8.Click += new EventHandler(this.toolStripButton_7_Click);
            this.button_0.Location = new Point(0x1a6, 0x171);
            this.button_0.Margin = new Padding(3, 8, 3, 3);
            this.button_0.Name = "btnClose";
            this.button_0.Size = new Size(0x4b, 0x17);
            this.button_0.TabIndex = 2;
            this.button_0.Text = "Закрыть";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new EventHandler(this.button_0_Click);
            this.tableLayoutPanel_0.SetColumnSpan(this.toolStrip_0, 2);
            this.toolStrip_0.Dock = DockStyle.Fill;
            ToolStripItem[] itemArray3 = new ToolStripItem[] { this.toolStripButton_0, this.toolStripButton_1, this.toolStripButton_8, this.toolStripSeparator_0, this.toolStripButton_2, this.toolStripSeparator_1, this.toolStripButton_6 };
            this.toolStrip_0.Items.AddRange(itemArray3);
            this.toolStrip_0.Location = new Point(0xc4, 0);
            this.toolStrip_0.Name = "tsUser";
            this.toolStrip_0.Size = new Size(0x146, 0x16);
            this.toolStrip_0.TabIndex = 3;
            this.toolStrip_0.Text = "toolStrip1";
            this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_0.Image = (Image) manager.GetObject("tsbAddUser.Image");
            this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_0.Name = "tsbAddUser";
            this.toolStripButton_0.Size = new Size(0x17, 0x13);
            this.toolStripButton_0.Text = "Добавить пользователя";
            this.toolStripButton_0.Click += new EventHandler(this.toolStripButton_0_Click);
            this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_1.Image = (Image) manager.GetObject("tsbEditUser.Image");
            this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_1.Name = "tsbEditUser";
            this.toolStripButton_1.Size = new Size(0x17, 0x13);
            this.toolStripButton_1.Text = "Редактировать пользователя";
            this.toolStripButton_1.Click += new EventHandler(this.toolStripButton_1_Click);
            this.toolStripButton_8.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_8.Image = Resources.ElementInformation;
            this.toolStripButton_8.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_8.Name = "tsbViewUser";
            this.toolStripButton_8.Size = new Size(0x17, 0x13);
            this.toolStripButton_8.Text = "toolStripButton1";
            this.toolStripButton_8.Click += new EventHandler(this.toolStripButton_8_Click);
            this.toolStripSeparator_0.Name = "toolStripSeparator1";
            this.toolStripSeparator_0.Size = new Size(6, 0x16);
            this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_2.Image = (Image) manager.GetObject("tsbDeleteUser.Image");
            this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_2.Name = "tsbDeleteUser";
            this.toolStripButton_2.Size = new Size(0x17, 0x13);
            this.toolStripButton_2.Text = "Удалить пользователя";
            this.toolStripButton_2.Click += new EventHandler(this.toolStripButton_2_Click);
            this.toolStripSeparator_1.Name = "toolStripSeparator2";
            this.toolStripSeparator_1.Size = new Size(6, 0x16);
            this.toolStripButton_6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_6.Image = (Image) manager.GetObject("tsbRefreshUser.Image");
            this.toolStripButton_6.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_6.Name = "tsbRefreshUser";
            this.toolStripButton_6.Size = new Size(0x17, 0x13);
            this.toolStripButton_6.Text = "Обновить";
            this.toolStripButton_6.Click += new EventHandler(this.toolStripButton_6_Click);
            this.toolStrip_1.Dock = DockStyle.Fill;
            ToolStripItem[] itemArray4 = new ToolStripItem[] { this.toolStripButton_3, this.toolStripButton_4, this.toolStripSeparator_2, this.toolStripButton_5, this.toolStripSeparator_3, this.toolStripButton_7 };
            this.toolStrip_1.Items.AddRange(itemArray4);
            this.toolStrip_1.Location = new Point(0, 0);
            this.toolStrip_1.Name = "tsGroup";
            this.toolStrip_1.Size = new Size(0xc4, 0x16);
            this.toolStrip_1.TabIndex = 4;
            this.toolStrip_1.Text = "toolStrip2";
            this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_3.Image = (Image) manager.GetObject("tsbAddGroup.Image");
            this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_3.Name = "tsbAddGroup";
            this.toolStripButton_3.Size = new Size(0x17, 0x13);
            this.toolStripButton_3.Text = "Добавить группу";
            this.toolStripButton_3.Click += new EventHandler(this.toolStripButton_3_Click);
            this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_4.Image = (Image) manager.GetObject("tsbEditGroup.Image");
            this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_4.Name = "tsbEditGroup";
            this.toolStripButton_4.Size = new Size(0x17, 0x13);
            this.toolStripButton_4.Text = "Редактировать группу";
            this.toolStripButton_4.Click += new EventHandler(this.toolStripButton_4_Click);
            this.toolStripSeparator_2.Name = "toolStripSeparator3";
            this.toolStripSeparator_2.Size = new Size(6, 0x16);
            this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_5.Image = (Image) manager.GetObject("tsbDeleteGroup.Image");
            this.toolStripButton_5.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_5.Name = "tsbDeleteGroup";
            this.toolStripButton_5.Size = new Size(0x17, 0x13);
            this.toolStripButton_5.Text = "Удалить группу";
            this.toolStripButton_5.Click += new EventHandler(this.toolStripButton_5_Click);
            this.toolStripSeparator_3.Name = "toolStripSeparator4";
            this.toolStripSeparator_3.Size = new Size(6, 0x16);
            this.toolStripButton_7.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_7.Image = (Image) manager.GetObject("tsbRefreshGroup.Image");
            this.toolStripButton_7.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_7.Name = "tsbRefreshGroup";
            this.toolStripButton_7.Size = new Size(0x17, 0x13);
            this.toolStripButton_7.Text = "Обновить";
            this.toolStripButton_7.Click += new EventHandler(this.toolStripButton_7_Click);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x20a, 400);
            base.Controls.Add(this.tableLayoutPanel_0);
            base.Name = "FormBossUsers";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Пользователи \"Босс Референт\"";
            base.Load += new EventHandler(this.FormBossUsers_Load);
            this.tableLayoutPanel_0.ResumeLayout(false);
            this.tableLayoutPanel_0.PerformLayout();
            ((ISupportInitialize) this.dataGridView_0).EndInit();
            this.contextMenuStrip_1.ResumeLayout(false);
            ((ISupportInitialize) this.bindingSource_0).EndInit();
            this.dataSetGES_0.EndInit();
            this.contextMenuStrip_0.ResumeLayout(false);
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            this.toolStrip_1.ResumeLayout(false);
            this.toolStrip_1.PerformLayout();
            base.ResumeLayout(false);
        }

        [CompilerGenerated]
        private bool method_14(DataSetGES.Class147 class147_0)
        {
            return (class147_0.Int32_0 == ((int) this.treeView_0.SelectedNode.Tag));
        }

        [CompilerGenerated]
        private bool method_15(DataSetGES.Class154 class154_0)
        {
            return (class154_0.Int32_0 == ((int) this.dataGridView_0.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value));
        }

        private void method_2(int int_0)
        {
            base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_BossUserGroup, true, "WHERE Deleted = 0");
            this.method_4(int_0);
        }

        private void method_3()
        {
            this.method_4((this.treeView_0.SelectedNode != null) ? ((int) this.treeView_0.SelectedNode.Tag) : -1);
        }

        private void method_4(int int_0)
        {
            this.list_0 = this.method_8(this.treeView_0.Nodes, this.list_0);
            this.treeView_0.Nodes.Clear();
            this.treeView_0.BeginUpdate();
            foreach (DataSetGES.Class147 class2 in this.dataSetGES_0.tJ_BossUserGroup.Where<DataSetGES.Class147>(<>c.<>9__10_0 ?? (<>c.<>9__10_0 = new Func<DataSetGES.Class147, bool>(<>c.<>9.method_0))))
            {
                TreeNode node = new TreeNode(class2.Name) {
                    Tag = class2.Int32_0
                };
                this.method_7(node);
                this.treeView_0.Nodes.Add(node);
            }
            this.method_9(this.treeView_0.Nodes, this.list_0);
            if (int_0 != -1)
            {
                List<TreeNode> list = new List<TreeNode>();
                list = this.method_5(this.treeView_0.Nodes, list);
                this.treeView_0.SelectedNode = this.method_6(list, int_0);
            }
            this.treeView_0.EndUpdate();
        }

        private List<TreeNode> method_5(TreeNodeCollection treeNodeCollection_0, List<TreeNode> list_1)
        {
            if (list_1 == null)
            {
                list_1 = new List<TreeNode>();
            }
            foreach (TreeNode node in treeNodeCollection_0)
            {
                list_1.Add(node);
                list_1 = this.method_5(node.Nodes, list_1);
            }
            return list_1;
        }

        private TreeNode method_6(List<TreeNode> list_1, int int_0)
        {
            foreach (TreeNode node in list_1)
            {
                if (((int) node.Tag) == int_0)
                {
                    return node;
                }
            }
            return null;
        }

        private void method_7(TreeNode treeNode_0)
        {
            Class296 class2 = new Class296 {
                treeNode_0 = treeNode_0
            };
            foreach (DataSetGES.Class147 class3 in this.dataSetGES_0.tJ_BossUserGroup.Where<DataSetGES.Class147>(new Func<DataSetGES.Class147, bool>(class2.method_0)))
            {
                TreeNode node = new TreeNode(class3.Name) {
                    Tag = class3.Int32_0
                };
                this.method_7(node);
                class2.treeNode_0.Nodes.Add(node);
            }
        }

        private List<int> method_8(TreeNodeCollection treeNodeCollection_0, List<int> list_1)
        {
            if (list_1 == null)
            {
                list_1 = new List<int>();
            }
            foreach (TreeNode node in treeNodeCollection_0)
            {
                if (node.IsExpanded)
                {
                    list_1.Add((int) node.Tag);
                }
                list_1 = this.method_8(node.Nodes, list_1);
            }
            return list_1;
        }

        private void method_9(TreeNodeCollection treeNodeCollection_0, List<int> list_1)
        {
            foreach (TreeNode node in treeNodeCollection_0)
            {
                if (list_1.Contains((int) node.Tag))
                {
                    node.Expand();
                }
                this.method_9(node.Nodes, list_1);
            }
        }

        private void toolStripButton_0_Click(object sender, EventArgs e)
        {
            if (this.treeView_0.SelectedNode != null)
            {
                Form23 form1 = new Form23();
                form1.set_SqlSettings(this.get_SqlSettings());
                form1.MdiParent = base.MdiParent;
                form1.method_3(0);
                form1.method_1((int) this.treeView_0.SelectedNode.Tag);
                form1.FormClosed += new FormClosedEventHandler(this.method_10);
                form1.Show();
            }
        }

        private void toolStripButton_1_Click(object sender, EventArgs e)
        {
            if ((this.dataGridView_0.SelectedRows != null) && (this.dataGridView_0.SelectedRows.Count != 0))
            {
                Form23 form1 = new Form23();
                form1.set_SqlSettings(this.get_SqlSettings());
                form1.MdiParent = base.MdiParent;
                form1.method_3(1);
                form1.Id = (int) this.dataGridView_0.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value;
                form1.FormClosed += new FormClosedEventHandler(this.method_10);
                form1.Show();
            }
        }

        private void toolStripButton_2_Click(object sender, EventArgs e)
        {
            if (((this.dataGridView_0.SelectedRows != null) && (this.dataGridView_0.SelectedRows.Count != 0)) && (MessageBox.Show("Вы действительно хотите удалить пользавателя?", "Удаление.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                DataSetGES.Class154 local1 = this.dataSetGES_0.tJ_BossUser.Where<DataSetGES.Class154>(new Func<DataSetGES.Class154, bool>(this.method_15)).First<DataSetGES.Class154>();
                local1.Deleted = true;
                local1.EndEdit();
                if (base.UpdateSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_BossUser))
                {
                    MessageBox.Show("Пользователь успешно удален.");
                    this.method_11((int) this.treeView_0.SelectedNode.Tag);
                }
            }
        }

        private void toolStripButton_3_Click(object sender, EventArgs e)
        {
            Form24 form1 = new Form24();
            form1.set_SqlSettings(this.get_SqlSettings());
            form1.MdiParent = base.MdiParent;
            form1.method_1(0);
            form1.IdParent = (this.treeView_0.SelectedNode != null) ? ((int) this.treeView_0.SelectedNode.Tag) : -1;
            form1.FormClosed += new FormClosedEventHandler(this.method_0);
            form1.Show();
        }

        private void toolStripButton_4_Click(object sender, EventArgs e)
        {
            if (this.treeView_0.SelectedNode != null)
            {
                Form24 form1 = new Form24();
                form1.set_SqlSettings(this.get_SqlSettings());
                form1.MdiParent = base.MdiParent;
                form1.method_1(1);
                form1.Id = (int) this.treeView_0.SelectedNode.Tag;
                form1.FormClosed += new FormClosedEventHandler(this.method_0);
                form1.Show();
            }
        }

        private void toolStripButton_5_Click(object sender, EventArgs e)
        {
            if ((this.treeView_0.SelectedNode != null) && (MessageBox.Show("Вы действительно хотите удалить группу пользавателей?", "Удаление.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                if (this.dataGridView_0.Rows.Count > 0)
                {
                    MessageBox.Show("Удаление невозможно! Группа не пуста!", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    DataSetGES.Class147 local1 = this.dataSetGES_0.tJ_BossUserGroup.Where<DataSetGES.Class147>(new Func<DataSetGES.Class147, bool>(this.method_14)).First<DataSetGES.Class147>();
                    local1.Deleted = true;
                    local1.EndEdit();
                    if (base.UpdateSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_BossUserGroup))
                    {
                        MessageBox.Show("Группа успешно удалена.");
                    }
                    this.method_3();
                }
            }
        }

        private void toolStripButton_6_Click(object sender, EventArgs e)
        {
            this.method_11((int) this.treeView_0.SelectedNode.Tag);
        }

        private void toolStripButton_7_Click(object sender, EventArgs e)
        {
            this.method_1();
        }

        private void toolStripButton_8_Click(object sender, EventArgs e)
        {
            if ((this.dataGridView_0.SelectedRows != null) && (this.dataGridView_0.SelectedRows.Count != 0))
            {
                Form23 form1 = new Form23();
                form1.set_SqlSettings(this.get_SqlSettings());
                form1.MdiParent = base.MdiParent;
                form1.method_3(7);
                form1.Id = (int) this.dataGridView_0.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value;
                form1.Show();
            }
        }

        private void treeView_0_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.method_11((int) this.treeView_0.SelectedNode.Tag);
        }

        [Serializable, CompilerGenerated]
        private sealed class <>c
        {
            public static readonly FormBossUsers.<>c <>9 = new FormBossUsers.<>c();
            public static Func<DataSetGES.Class147, bool> <>9__10_0;

            internal bool method_0(DataSetGES.Class147 class147_0)
            {
                return (class147_0["idParent"] == DBNull.Value);
            }
        }

        [CompilerGenerated]
        private sealed class Class296
        {
            public TreeNode treeNode_0;

            internal bool method_0(DataSetGES.Class147 class147_0)
            {
                return ((class147_0["idParent"] != DBNull.Value) && (class147_0.idParent == ((int) this.treeNode_0.Tag)));
            }
        }
    }
}

