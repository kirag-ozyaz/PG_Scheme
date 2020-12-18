namespace Documents.Forms.JournalRelayProtectionAutomation
{
    using ControlsLbr.DataGridViewExcelFilter;
    using DataSql;
    using Documents.DataSets;
    using Documents.Properties;
    using FormLbr;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;

    public class FormJournalRelayProtectionAutomation : FormBase
    {
        private BindingSource bindingSource_0;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_2;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_3;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_4;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_20;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_22;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_23;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_24;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_25;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_26;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_28;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_29;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_31;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;
        private DataSetGES dataSetGES_0;
        private IContainer icontainer_0;
        private int? nullable_0;
        private SplitContainer splitContainer_0;
        private ToolStrip toolStrip_0;
        private ToolStrip toolStrip_1;
        private ToolStrip toolStrip_2;
        private ToolStripButton toolStripButton_0;
        private ToolStripButton toolStripButton_1;
        private ToolStripButton toolStripButton_10;
        private ToolStripButton toolStripButton_11;
        private ToolStripButton toolStripButton_12;
        private ToolStripButton toolStripButton_2;
        private ToolStripButton toolStripButton_3;
        private ToolStripButton toolStripButton_4;
        private ToolStripButton toolStripButton_5;
        private ToolStripButton toolStripButton_6;
        private ToolStripButton toolStripButton_7;
        private ToolStripButton toolStripButton_8;
        private ToolStripButton toolStripButton_9;
        private ToolStripSeparator toolStripSeparator_0;
        private ToolStripSeparator toolStripSeparator_1;
        private ToolStripSeparator toolStripSeparator_2;
        private ToolStripTextBox toolStripTextBox_0;
        private TreeView treeView_0;

        public FormJournalRelayProtectionAutomation()
        {
            this.method_5();
            this.toolStripButton_9.Visible = false;
        }

        public FormJournalRelayProtectionAutomation(int selSubstation)
        {
            this.method_5();
            this.nullable_0 = new int?(selSubstation);
            this.toolStripButton_9.Visible = false;
        }

        private void dataGridViewExcelFilter_0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.toolStripButton_4.Enabled && this.toolStripButton_4.Visible)
            {
                this.toolStripButton_4_Click(sender, e);
            }
            else
            {
                this.toolStripButton_11_Click(sender, e);
            }
        }

        private void dataGridViewExcelFilter_0_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (Convert.ToBoolean(this.dataGridViewExcelFilter_0[this.dataGridViewCheckBoxColumn_3.Name, e.RowIndex].Value))
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                if (Convert.ToBoolean(this.dataGridViewExcelFilter_0[this.dataGridViewCheckBoxColumn_4.Name, e.RowIndex].Value))
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Italic | FontStyle.Bold);
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

        private void FormJournalRelayProtectionAutomation_Load(object sender, EventArgs e)
        {
            this.method_0();
        }

        private void method_0()
        {
            DataSetOrder order = new DataSetOrder();
            base.SelectSqlData(order, order.tR_Classifier, true, " where ParentKey = ';SCM;PS;' and isgroup = 0 and deleted = 0 order by name");
            this.treeView_0.BeginUpdate();
            TreeNode node = this.treeView_0.Nodes.Add("Все объекты");
            this.treeView_0.SelectedNode = node;
            foreach (DataRow row in order.tR_Classifier.Rows)
            {
                TreeNode node2 = node.Nodes.Add(row["SocrName"].ToString());
                node2.Tag = row["id"];
                base.SelectSqlData(order, order.vSchm_ObjList, true, " where typeCodeId = " + row["id"].ToString() + " and deleted = 0 order by name");
                foreach (DataRow row2 in order.vSchm_ObjList)
                {
                    string str = "";
                    TreeNode node3 = node2.Nodes.Add(row2["typeCodeSocr"].ToString() + "-" + row2["Name"].ToString() + str);
                    node3.Tag = row2["id"];
                    if (this.nullable_0.HasValue && (Convert.ToInt32(row2["id"]) == this.nullable_0.Value))
                    {
                        this.treeView_0.SelectedNode = node3;
                    }
                    node3.Nodes.Add("");
                }
            }
            this.treeView_0.EndUpdate();
            node.Expand();
        }

        private List<TreeNode> method_1(TreeNodeCollection treeNodeCollection_0, List<TreeNode> list_0)
        {
            foreach (TreeNode node in treeNodeCollection_0)
            {
                list_0.Add(node);
                list_0 = this.method_1(node.Nodes, list_0);
            }
            return list_0;
        }

        private TreeNode method_2(List<TreeNode> list_0, TreeNode treeNode_0, string string_0, Enum25 enum25_0)
        {
            bool flag = enum25_0 == Enum25.const_0;
            if (enum25_0 == Enum25.const_2)
            {
                list_0.Reverse();
            }
            foreach (TreeNode node in list_0)
            {
                if (flag && node.Text.ToUpper().Contains(string_0.ToUpper()))
                {
                    return node;
                }
                if (node == treeNode_0)
                {
                    flag = true;
                }
            }
            return null;
        }

        private void method_3()
        {
            int num = -1;
            if (this.dataGridViewExcelFilter_0.CurrentRow != null)
            {
                num = Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_0.Name].Value);
            }
            string str = "";
            if (this.toolStripButton_8.Checked)
            {
                str = " deleted in (0,1) ";
            }
            else
            {
                string[] textArray1 = new string[] { " (deleted = ", Convert.ToInt32(this.toolStripButton_8.Checked).ToString(), " and deletedObj = ", Convert.ToInt32(this.toolStripButton_8.Checked).ToString(), ") " };
                str = string.Concat(textArray1);
            }
            switch (this.treeView_0.SelectedNode.Level)
            {
                case 0:
                    base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.vJ_RelayProtectionAutomation, true, " where " + str + " order by Sub_name, bus_name, cell_name");
                    break;

                case 1:
                    base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.vJ_RelayProtectionAutomation, true, " where TypeSub = " + this.treeView_0.SelectedNode.Tag.ToString() + " and " + str + " order by Sub_name, bus_name, cell_name");
                    break;

                case 2:
                    base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.vJ_RelayProtectionAutomation, true, " where subId = " + this.treeView_0.SelectedNode.Tag.ToString() + " and " + str + " order by Sub_name, bus_name, cell_name");
                    break;

                case 3:
                    base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.vJ_RelayProtectionAutomation, true, " where busId = " + this.treeView_0.SelectedNode.Tag.ToString() + " and " + str + " order by Sub_name, bus_name, cell_name");
                    break;

                case 4:
                    base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.vJ_RelayProtectionAutomation, true, " where cellId = " + this.treeView_0.SelectedNode.Tag.ToString() + " and " + str + " order by Sub_name, bus_name, cell_name");
                    break;
            }
            if (num > 0)
            {
                this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewTextBoxColumn_0.Name, num.ToString(), false);
            }
        }

        private void method_4(object sender, FormClosedEventArgs e)
        {
            if (((Form) sender).DialogResult == DialogResult.OK)
            {
                this.method_3();
            }
        }

        private void method_5()
        {
            this.icontainer_0 = new Container();
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(FormJournalRelayProtectionAutomation));
            this.toolStrip_0 = new ToolStrip();
            this.toolStripButton_3 = new ToolStripButton();
            this.toolStripButton_6 = new ToolStripButton();
            this.toolStripSeparator_1 = new ToolStripSeparator();
            this.toolStripButton_10 = new ToolStripButton();
            this.toolStripSeparator_0 = new ToolStripSeparator();
            this.toolStripButton_7 = new ToolStripButton();
            this.toolStripButton_8 = new ToolStripButton();
            this.toolStripButton_9 = new ToolStripButton();
            this.toolStripSeparator_2 = new ToolStripSeparator();
            this.toolStripButton_12 = new ToolStripButton();
            this.toolStripButton_4 = new ToolStripButton();
            this.splitContainer_0 = new SplitContainer();
            this.treeView_0 = new TreeView();
            this.toolStrip_1 = new ToolStrip();
            this.toolStripButton_0 = new ToolStripButton();
            this.toolStripTextBox_0 = new ToolStripTextBox();
            this.toolStripButton_1 = new ToolStripButton();
            this.toolStripButton_2 = new ToolStripButton();
            this.dataGridViewExcelFilter_0 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.toolStrip_2 = new ToolStrip();
            this.toolStripButton_5 = new ToolStripButton();
            this.toolStripButton_11 = new ToolStripButton();
            this.bindingSource_0 = new BindingSource(this.icontainer_0);
            this.dataSetGES_0 = new DataSetGES();
            this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_12 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_13 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_14 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_15 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_16 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_17 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_18 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_19 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_20 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_21 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_22 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_23 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_24 = new DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn_1 = new DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn_2 = new DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn_25 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_26 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_27 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_28 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_29 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_30 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_31 = new DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn_3 = new DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn_4 = new DataGridViewCheckBoxColumn();
            this.toolStrip_0.SuspendLayout();
            this.splitContainer_0.Panel1.SuspendLayout();
            this.splitContainer_0.Panel2.SuspendLayout();
            this.splitContainer_0.SuspendLayout();
            this.toolStrip_1.SuspendLayout();
            this.dataGridViewExcelFilter_0.BeginInit();
            this.toolStrip_2.SuspendLayout();
            ((ISupportInitialize) this.bindingSource_0).BeginInit();
            this.dataSetGES_0.BeginInit();
            base.SuspendLayout();
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripButton_3, this.toolStripButton_6, this.toolStripSeparator_1, this.toolStripButton_10, this.toolStripSeparator_0, this.toolStripButton_7, this.toolStripButton_8, this.toolStripButton_9, this.toolStripSeparator_2, this.toolStripButton_12 };
            this.toolStrip_0.Items.AddRange(toolStripItems);
            this.toolStrip_0.Location = new Point(0, 0);
            this.toolStrip_0.Name = "toolStripMain";
            this.toolStrip_0.Size = new Size(0x442, 0x19);
            this.toolStrip_0.TabIndex = 0;
            this.toolStrip_0.Text = "toolStrip1";
            this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_3.Image = Resources.ElementAdd;
            this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_3.Name = "toolBtnAdd";
            this.toolStripButton_3.Size = new Size(0x17, 0x16);
            this.toolStripButton_3.Text = "Новая уставка";
            this.toolStripButton_3.Click += new EventHandler(this.toolStripButton_3_Click);
            this.toolStripButton_6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_6.Image = Resources.ElementDel;
            this.toolStripButton_6.ImageTransparentColor = Color.Transparent;
            this.toolStripButton_6.Name = "toolBtnDel";
            this.toolStripButton_6.Size = new Size(0x17, 0x16);
            this.toolStripButton_6.Text = "Удалить уставку";
            this.toolStripButton_6.Click += new EventHandler(this.toolStripButton_6_Click);
            this.toolStripSeparator_1.Name = "toolStripSeparator2";
            this.toolStripSeparator_1.Size = new Size(6, 0x19);
            this.toolStripButton_10.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_10.Image = Resources.refresh_16;
            this.toolStripButton_10.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_10.Name = "toolBtnRefresh";
            this.toolStripButton_10.Size = new Size(0x17, 0x16);
            this.toolStripButton_10.Text = "Обновить";
            this.toolStripButton_10.Click += new EventHandler(this.toolStripButton_10_Click);
            this.toolStripSeparator_0.Name = "toolStripSeparator1";
            this.toolStripSeparator_0.Size = new Size(6, 0x19);
            this.toolStripButton_7.Checked = true;
            this.toolStripButton_7.CheckOnClick = true;
            this.toolStripButton_7.CheckState = CheckState.Checked;
            this.toolStripButton_7.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_7.Image = Resources.Tree3;
            this.toolStripButton_7.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_7.Name = "toolBtnShowTree";
            this.toolStripButton_7.Size = new Size(0x17, 0x16);
            this.toolStripButton_7.Text = "Скрыть дерево объектов";
            this.toolStripButton_7.Click += new EventHandler(this.toolStripButton_7_Click);
            this.toolStripButton_8.CheckOnClick = true;
            this.toolStripButton_8.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_8.Image = Resources.Trash;
            this.toolStripButton_8.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_8.Name = "toolBrnShowDel";
            this.toolStripButton_8.Size = new Size(0x17, 0x16);
            this.toolStripButton_8.Text = "Показать удаленные уставки";
            this.toolStripButton_8.Click += new EventHandler(this.toolStripButton_8_Click);
            this.toolStripButton_9.Alignment = ToolStripItemAlignment.Right;
            this.toolStripButton_9.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_9.Image = Resources.ElementGo;
            this.toolStripButton_9.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_9.Name = "toolBTnImportOldBase";
            this.toolStripButton_9.Size = new Size(0x17, 0x16);
            this.toolStripButton_9.Text = "Загрузить из старой базы";
            this.toolStripButton_9.Click += new EventHandler(this.toolStripButton_9_Click);
            this.toolStripSeparator_2.Name = "toolStripSeparator3";
            this.toolStripSeparator_2.Size = new Size(6, 0x19);
            this.toolStripButton_12.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_12.Image = Resources.report;
            this.toolStripButton_12.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_12.Name = "toolBtnReport";
            this.toolStripButton_12.Size = new Size(0x17, 0x16);
            this.toolStripButton_12.Text = "Отчет";
            this.toolStripButton_12.Click += new EventHandler(this.toolStripButton_12_Click);
            this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_4.Image = Resources.ElementEdit;
            this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_4.Name = "toolBtnEditValue";
            this.toolStripButton_4.Size = new Size(0x17, 0x16);
            this.toolStripButton_4.Text = "Редактировать";
            this.toolStripButton_4.Click += new EventHandler(this.toolStripButton_4_Click);
            this.splitContainer_0.Dock = DockStyle.Fill;
            this.splitContainer_0.FixedPanel = FixedPanel.Panel1;
            this.splitContainer_0.Location = new Point(0, 0x19);
            this.splitContainer_0.Name = "splitContainer";
            this.splitContainer_0.Panel1.Controls.Add(this.treeView_0);
            this.splitContainer_0.Panel1.Controls.Add(this.toolStrip_1);
            this.splitContainer_0.Panel2.Controls.Add(this.dataGridViewExcelFilter_0);
            this.splitContainer_0.Panel2.Controls.Add(this.toolStrip_2);
            this.splitContainer_0.Size = new Size(0x442, 0x225);
            this.splitContainer_0.SplitterDistance = 190;
            this.splitContainer_0.TabIndex = 1;
            this.treeView_0.Dock = DockStyle.Fill;
            this.treeView_0.HideSelection = false;
            this.treeView_0.Location = new Point(0, 0x19);
            this.treeView_0.Name = "treeViewSubstation";
            this.treeView_0.Size = new Size(190, 0x20c);
            this.treeView_0.TabIndex = 1;
            this.treeView_0.BeforeExpand += new TreeViewCancelEventHandler(this.treeView_0_BeforeExpand);
            this.treeView_0.AfterSelect += new TreeViewEventHandler(this.treeView_0_AfterSelect);
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.toolStripButton_0, this.toolStripTextBox_0, this.toolStripButton_1, this.toolStripButton_2 };
            this.toolStrip_1.Items.AddRange(itemArray2);
            this.toolStrip_1.Location = new Point(0, 0);
            this.toolStrip_1.Name = "toolStripTree";
            this.toolStrip_1.Size = new Size(190, 0x19);
            this.toolStrip_1.TabIndex = 0;
            this.toolStrip_1.Text = "toolStrip1";
            this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_0.Image = Resources.Find;
            this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_0.Name = "toolBtnFindTree";
            this.toolStripButton_0.Size = new Size(0x17, 0x16);
            this.toolStripButton_0.Text = "toolStripButton1";
            this.toolStripButton_0.Click += new EventHandler(this.toolStripButton_0_Click);
            this.toolStripTextBox_0.Name = "toolTxtFind";
            this.toolStripTextBox_0.Size = new Size(100, 0x19);
            this.toolStripTextBox_0.KeyDown += new KeyEventHandler(this.toolStripTextBox_0_KeyDown);
            this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_1.Image = Resources.FindPrev;
            this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_1.Name = "toolBtnFindPrevTree";
            this.toolStripButton_1.Size = new Size(0x17, 0x16);
            this.toolStripButton_1.Text = "toolStripButton1";
            this.toolStripButton_1.Click += new EventHandler(this.toolStripButton_1_Click);
            this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_2.Image = Resources.FindNext;
            this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_2.Name = "toolBtnFindNextTree";
            this.toolStripButton_2.Size = new Size(0x17, 0x16);
            this.toolStripButton_2.Text = "toolStripButton2";
            this.toolStripButton_2.Click += new EventHandler(this.toolStripButton_2_Click);
            this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToOrderColumns = true;
            style.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dataGridViewExcelFilter_0.AlternatingRowsDefaultCellStyle = style;
            this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
            this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { 
                this.dataGridViewTextBoxColumn_0, this.dataGridViewTextBoxColumn_1, this.dataGridViewTextBoxColumn_2, this.dataGridViewTextBoxColumn_3, this.dataGridViewTextBoxColumn_4, this.dataGridViewTextBoxColumn_5, this.dataGridViewTextBoxColumn_6, this.dataGridViewTextBoxColumn_7, this.dataGridViewTextBoxColumn_8, this.dataGridViewTextBoxColumn_9, this.dataGridViewTextBoxColumn_10, this.dataGridViewTextBoxColumn_11, this.dataGridViewTextBoxColumn_12, this.dataGridViewTextBoxColumn_13, this.dataGridViewTextBoxColumn_14, this.dataGridViewTextBoxColumn_15,
                this.dataGridViewTextBoxColumn_16, this.dataGridViewTextBoxColumn_17, this.dataGridViewTextBoxColumn_18, this.dataGridViewTextBoxColumn_19, this.dataGridViewTextBoxColumn_20, this.dataGridViewTextBoxColumn_21, this.dataGridViewTextBoxColumn_22, this.dataGridViewTextBoxColumn_23, this.dataGridViewTextBoxColumn_24, this.dataGridViewCheckBoxColumn_0, this.dataGridViewCheckBoxColumn_1, this.dataGridViewCheckBoxColumn_2, this.dataGridViewTextBoxColumn_25, this.dataGridViewTextBoxColumn_26, this.dataGridViewTextBoxColumn_27, this.dataGridViewTextBoxColumn_28,
                this.dataGridViewTextBoxColumn_29, this.dataGridViewTextBoxColumn_30, this.dataGridViewTextBoxColumn_31, this.dataGridViewCheckBoxColumn_3, this.dataGridViewCheckBoxColumn_4
            };
            this.dataGridViewExcelFilter_0.Columns.AddRange(dataGridViewColumns);
            this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
            this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_0.Location = new Point(0, 0x19);
            this.dataGridViewExcelFilter_0.Name = "dgvRelay";
            this.dataGridViewExcelFilter_0.ReadOnly = true;
            this.dataGridViewExcelFilter_0.RowHeadersWidth = 0x15;
            this.dataGridViewExcelFilter_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExcelFilter_0.Size = new Size(0x380, 0x20c);
            this.dataGridViewExcelFilter_0.TabIndex = 0;
            this.dataGridViewExcelFilter_0.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_0_CellDoubleClick);
            this.dataGridViewExcelFilter_0.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridViewExcelFilter_0_CellFormatting);
            ToolStripItem[] itemArray3 = new ToolStripItem[] { this.toolStripButton_5, this.toolStripButton_4, this.toolStripButton_11 };
            this.toolStrip_2.Items.AddRange(itemArray3);
            this.toolStrip_2.Location = new Point(0, 0);
            this.toolStrip_2.Name = "toolStripValue";
            this.toolStrip_2.Size = new Size(0x380, 0x19);
            this.toolStrip_2.TabIndex = 1;
            this.toolStrip_2.Text = "toolStrip1";
            this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_5.Image = Resources.ElementAdd;
            this.toolStripButton_5.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_5.Name = "toolBtnNewValue";
            this.toolStripButton_5.Size = new Size(0x17, 0x16);
            this.toolStripButton_5.Text = "Новые значения";
            this.toolStripButton_5.Click += new EventHandler(this.toolStripButton_5_Click);
            this.toolStripButton_11.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_11.Image = Resources.ElementInformation;
            this.toolStripButton_11.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_11.Name = "toolBtnReadValue";
            this.toolStripButton_11.Size = new Size(0x17, 0x16);
            this.toolStripButton_11.Text = "Просмотр";
            this.toolStripButton_11.Click += new EventHandler(this.toolStripButton_11_Click);
            this.bindingSource_0.DataMember = "vJ_RelayProtectionAutomation";
            this.bindingSource_0.DataSource = this.dataSetGES_0;
            this.dataSetGES_0.DataSetName = "DataSetGES";
            this.dataSetGES_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.dataGridViewTextBoxColumn_0.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_0.HeaderText = "id";
            this.dataGridViewTextBoxColumn_0.Name = "idDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewTextBoxColumn_0.Visible = false;
            this.dataGridViewTextBoxColumn_1.DataPropertyName = "relayidValue";
            this.dataGridViewTextBoxColumn_1.HeaderText = "relayidValue";
            this.dataGridViewTextBoxColumn_1.Name = "relayidValueDgvTxtColumn";
            this.dataGridViewTextBoxColumn_1.ReadOnly = true;
            this.dataGridViewTextBoxColumn_1.Visible = false;
            this.dataGridViewTextBoxColumn_2.DataPropertyName = "subId";
            this.dataGridViewTextBoxColumn_2.HeaderText = "subId";
            this.dataGridViewTextBoxColumn_2.Name = "subIdDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_2.ReadOnly = true;
            this.dataGridViewTextBoxColumn_2.Visible = false;
            this.dataGridViewTextBoxColumn_3.DataPropertyName = "sub_Name";
            this.dataGridViewTextBoxColumn_3.HeaderText = "Подстанция";
            this.dataGridViewTextBoxColumn_3.Name = "subNameDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_3.ReadOnly = true;
            this.dataGridViewTextBoxColumn_3.Width = 80;
            this.dataGridViewTextBoxColumn_4.DataPropertyName = "typeSub";
            this.dataGridViewTextBoxColumn_4.HeaderText = "typeSub";
            this.dataGridViewTextBoxColumn_4.Name = "typeSubDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_4.ReadOnly = true;
            this.dataGridViewTextBoxColumn_4.Visible = false;
            this.dataGridViewTextBoxColumn_5.DataPropertyName = "busID";
            this.dataGridViewTextBoxColumn_5.HeaderText = "busID";
            this.dataGridViewTextBoxColumn_5.Name = "busIDDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_5.ReadOnly = true;
            this.dataGridViewTextBoxColumn_5.Visible = false;
            this.dataGridViewTextBoxColumn_6.DataPropertyName = "bus_name";
            this.dataGridViewTextBoxColumn_6.HeaderText = "Шина";
            this.dataGridViewTextBoxColumn_6.Name = "busnameDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_6.ReadOnly = true;
            this.dataGridViewTextBoxColumn_6.Width = 40;
            this.dataGridViewTextBoxColumn_7.DataPropertyName = "cell_Name";
            this.dataGridViewTextBoxColumn_7.HeaderText = "Ячейка";
            this.dataGridViewTextBoxColumn_7.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_7.ReadOnly = true;
            this.dataGridViewTextBoxColumn_7.Width = 50;
            this.dataGridViewTextBoxColumn_8.DataPropertyName = "relName";
            this.dataGridViewTextBoxColumn_8.HeaderText = "№ прогр.";
            this.dataGridViewTextBoxColumn_8.Name = "relNameDgvTxtColumn";
            this.dataGridViewTextBoxColumn_8.ReadOnly = true;
            this.dataGridViewTextBoxColumn_8.Width = 0x23;
            this.dataGridViewTextBoxColumn_9.DataPropertyName = "cellID";
            this.dataGridViewTextBoxColumn_9.HeaderText = "cellID";
            this.dataGridViewTextBoxColumn_9.Name = "cellIDDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_9.ReadOnly = true;
            this.dataGridViewTextBoxColumn_9.Visible = false;
            this.dataGridViewTextBoxColumn_10.DataPropertyName = "coefTR";
            this.dataGridViewTextBoxColumn_10.HeaderText = "Коэф. тр.";
            this.dataGridViewTextBoxColumn_10.Name = "coefTRDgvTxtColumn";
            this.dataGridViewTextBoxColumn_10.ReadOnly = true;
            this.dataGridViewTextBoxColumn_10.Width = 50;
            this.dataGridViewTextBoxColumn_11.DataPropertyName = "amp_primary";
            this.dataGridViewTextBoxColumn_11.HeaderText = "Ток1";
            this.dataGridViewTextBoxColumn_11.Name = "ampprimaryDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_11.ReadOnly = true;
            this.dataGridViewTextBoxColumn_11.Visible = false;
            this.dataGridViewTextBoxColumn_12.DataPropertyName = "amp_secondary";
            this.dataGridViewTextBoxColumn_12.HeaderText = "Ток2";
            this.dataGridViewTextBoxColumn_12.Name = "ampsecondaryDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_12.ReadOnly = true;
            this.dataGridViewTextBoxColumn_12.Visible = false;
            this.dataGridViewTextBoxColumn_13.DataPropertyName = "idTypeTr";
            this.dataGridViewTextBoxColumn_13.HeaderText = "idTypeTr";
            this.dataGridViewTextBoxColumn_13.Name = "idTypeTrDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_13.ReadOnly = true;
            this.dataGridViewTextBoxColumn_13.Visible = false;
            this.dataGridViewTextBoxColumn_14.DataPropertyName = "Typetr";
            this.dataGridViewTextBoxColumn_14.HeaderText = "Тип ТТ";
            this.dataGridViewTextBoxColumn_14.Name = "typetrDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_14.ReadOnly = true;
            this.dataGridViewTextBoxColumn_14.Width = 60;
            this.dataGridViewTextBoxColumn_15.DataPropertyName = "amp_mtz";
            this.dataGridViewTextBoxColumn_15.HeaderText = "МТЗ, А";
            this.dataGridViewTextBoxColumn_15.Name = "ampmtzDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_15.ReadOnly = true;
            this.dataGridViewTextBoxColumn_15.Width = 40;
            this.dataGridViewTextBoxColumn_16.DataPropertyName = "time_mtz";
            this.dataGridViewTextBoxColumn_16.HeaderText = "МТЗ, с";
            this.dataGridViewTextBoxColumn_16.Name = "timemtzDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_16.ReadOnly = true;
            this.dataGridViewTextBoxColumn_16.Width = 40;
            this.dataGridViewTextBoxColumn_17.DataPropertyName = "amp_to";
            this.dataGridViewTextBoxColumn_17.HeaderText = "ТО, А";
            this.dataGridViewTextBoxColumn_17.Name = "amptoDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_17.ReadOnly = true;
            this.dataGridViewTextBoxColumn_17.Width = 40;
            this.dataGridViewTextBoxColumn_18.DataPropertyName = "time_to";
            this.dataGridViewTextBoxColumn_18.HeaderText = "ТО, с";
            this.dataGridViewTextBoxColumn_18.Name = "timetoDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_18.ReadOnly = true;
            this.dataGridViewTextBoxColumn_18.Width = 40;
            this.dataGridViewTextBoxColumn_19.DataPropertyName = "amp_ozz";
            this.dataGridViewTextBoxColumn_19.HeaderText = "ОЗЗ, А";
            this.dataGridViewTextBoxColumn_19.Name = "ampozzDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_19.ReadOnly = true;
            this.dataGridViewTextBoxColumn_19.Width = 40;
            this.dataGridViewTextBoxColumn_20.DataPropertyName = "time_ozz";
            this.dataGridViewTextBoxColumn_20.HeaderText = "ОЗЗ, с";
            this.dataGridViewTextBoxColumn_20.Name = "timeozzDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_20.ReadOnly = true;
            this.dataGridViewTextBoxColumn_20.Width = 40;
            this.dataGridViewTextBoxColumn_21.DataPropertyName = "speed_mtz";
            this.dataGridViewTextBoxColumn_21.HeaderText = "Ускор МТЗ";
            this.dataGridViewTextBoxColumn_21.Name = "speedmtzDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_21.ReadOnly = true;
            this.dataGridViewTextBoxColumn_21.Width = 40;
            this.dataGridViewTextBoxColumn_22.DataPropertyName = "act_ozz";
            this.dataGridViewTextBoxColumn_22.HeaderText = "Действие ОЗЗ";
            this.dataGridViewTextBoxColumn_22.Name = "act_ozzDGVTxtColumn";
            this.dataGridViewTextBoxColumn_22.ReadOnly = true;
            this.dataGridViewTextBoxColumn_22.Width = 40;
            this.dataGridViewTextBoxColumn_23.DataPropertyName = "amp_urov";
            this.dataGridViewTextBoxColumn_23.HeaderText = "УРОВ, А";
            this.dataGridViewTextBoxColumn_23.Name = "ampurovDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_23.ReadOnly = true;
            this.dataGridViewTextBoxColumn_23.Width = 40;
            this.dataGridViewTextBoxColumn_24.DataPropertyName = "time_urov";
            this.dataGridViewTextBoxColumn_24.HeaderText = "УРОВ, с";
            this.dataGridViewTextBoxColumn_24.Name = "timeurovDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_24.ReadOnly = true;
            this.dataGridViewTextBoxColumn_24.Width = 40;
            this.dataGridViewCheckBoxColumn_0.DataPropertyName = "avr";
            this.dataGridViewCheckBoxColumn_0.HeaderText = "АВР";
            this.dataGridViewCheckBoxColumn_0.Name = "avrDGVTxtColumn";
            this.dataGridViewCheckBoxColumn_0.ReadOnly = true;
            this.dataGridViewCheckBoxColumn_0.Width = 30;
            this.dataGridViewCheckBoxColumn_1.DataPropertyName = "lzsh";
            this.dataGridViewCheckBoxColumn_1.HeaderText = "ЛЗШ";
            this.dataGridViewCheckBoxColumn_1.Name = "lzshDataGridViewCheckBoxColumn";
            this.dataGridViewCheckBoxColumn_1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn_1.Width = 0x23;
            this.dataGridViewCheckBoxColumn_2.DataPropertyName = "ArcProtection";
            this.dataGridViewCheckBoxColumn_2.HeaderText = "Дугоая защита";
            this.dataGridViewCheckBoxColumn_2.Name = "ArcProtection";
            this.dataGridViewCheckBoxColumn_2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn_2.Width = 50;
            this.dataGridViewTextBoxColumn_25.DataPropertyName = "type_relay";
            this.dataGridViewTextBoxColumn_25.HeaderText = "Тип реле";
            this.dataGridViewTextBoxColumn_25.Name = "typerelayDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_25.ReadOnly = true;
            this.dataGridViewTextBoxColumn_25.Width = 50;
            this.dataGridViewTextBoxColumn_26.DataPropertyName = "type_proc";
            this.dataGridViewTextBoxColumn_26.HeaderText = "Тип микропроц.";
            this.dataGridViewTextBoxColumn_26.Name = "typeprocDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_26.ReadOnly = true;
            this.dataGridViewTextBoxColumn_26.Width = 50;
            this.dataGridViewTextBoxColumn_27.DataPropertyName = "cp";
            this.dataGridViewTextBoxColumn_27.HeaderText = "Наименование присоединения";
            this.dataGridViewTextBoxColumn_27.Name = "cpDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_27.ReadOnly = true;
            this.dataGridViewTextBoxColumn_28.DataPropertyName = "cp_cell";
            this.dataGridViewTextBoxColumn_28.HeaderText = "Ячейка присоединения";
            this.dataGridViewTextBoxColumn_28.Name = "cpcellDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_28.ReadOnly = true;
            this.dataGridViewTextBoxColumn_28.Width = 40;
            this.dataGridViewTextBoxColumn_29.DataPropertyName = "comment";
            this.dataGridViewTextBoxColumn_29.HeaderText = "Примечание";
            this.dataGridViewTextBoxColumn_29.Name = "commentDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_29.ReadOnly = true;
            this.dataGridViewTextBoxColumn_30.DataPropertyName = "dateCreate";
            this.dataGridViewTextBoxColumn_30.HeaderText = "dateCreate";
            this.dataGridViewTextBoxColumn_30.Name = "dateCreateDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_30.ReadOnly = true;
            this.dataGridViewTextBoxColumn_30.Visible = false;
            this.dataGridViewTextBoxColumn_31.DataPropertyName = "dateIn";
            this.dataGridViewTextBoxColumn_31.HeaderText = "dateIn";
            this.dataGridViewTextBoxColumn_31.Name = "dateInDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_31.ReadOnly = true;
            this.dataGridViewTextBoxColumn_31.Visible = false;
            this.dataGridViewCheckBoxColumn_3.DataPropertyName = "deleted";
            this.dataGridViewCheckBoxColumn_3.HeaderText = "deleted";
            this.dataGridViewCheckBoxColumn_3.Name = "deletedDataGridViewCheckBoxColumn";
            this.dataGridViewCheckBoxColumn_3.ReadOnly = true;
            this.dataGridViewCheckBoxColumn_3.Visible = false;
            this.dataGridViewCheckBoxColumn_4.DataPropertyName = "deletedObj";
            this.dataGridViewCheckBoxColumn_4.HeaderText = "deletedObj";
            this.dataGridViewCheckBoxColumn_4.Name = "deletedObjDgvColumn";
            this.dataGridViewCheckBoxColumn_4.ReadOnly = true;
            this.dataGridViewCheckBoxColumn_4.Visible = false;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x442, 0x23e);
            base.Controls.Add(this.splitContainer_0);
            base.Controls.Add(this.toolStrip_0);
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Name = "FormJournalRelayProtectionAutomation";
            this.Text = "Уставки РЗА";
            base.Load += new EventHandler(this.FormJournalRelayProtectionAutomation_Load);
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            this.splitContainer_0.Panel1.ResumeLayout(false);
            this.splitContainer_0.Panel1.PerformLayout();
            this.splitContainer_0.Panel2.ResumeLayout(false);
            this.splitContainer_0.Panel2.PerformLayout();
            this.splitContainer_0.ResumeLayout(false);
            this.toolStrip_1.ResumeLayout(false);
            this.toolStrip_1.PerformLayout();
            this.dataGridViewExcelFilter_0.EndInit();
            this.toolStrip_2.ResumeLayout(false);
            this.toolStrip_2.PerformLayout();
            ((ISupportInitialize) this.bindingSource_0).EndInit();
            this.dataSetGES_0.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void toolStripButton_0_Click(object sender, EventArgs e)
        {
            List<TreeNode> list = new List<TreeNode>();
            list = this.method_1(this.treeView_0.Nodes, list);
            TreeNode node = this.method_2(list, this.treeView_0.SelectedNode, this.toolStripTextBox_0.Text, Enum25.const_0);
            if (node != null)
            {
                this.treeView_0.SelectedNode = node;
                this.treeView_0.SelectedNode.Expand();
            }
        }

        private void toolStripButton_1_Click(object sender, EventArgs e)
        {
            List<TreeNode> list = new List<TreeNode>();
            list = this.method_1(this.treeView_0.Nodes, list);
            TreeNode node = this.method_2(list, this.treeView_0.SelectedNode, this.toolStripTextBox_0.Text, Enum25.const_2);
            if (node != null)
            {
                this.treeView_0.SelectedNode = node;
                this.treeView_0.SelectedNode.Expand();
            }
        }

        private void toolStripButton_10_Click(object sender, EventArgs e)
        {
            this.method_3();
        }

        private void toolStripButton_11_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_0.CurrentRow != null)
            {
                try
                {
                    int num = Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_2.Name].Value);
                    int num2 = Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_5.Name].Value);
                    int num3 = Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_9.Name].Value);
                    int num4 = Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_0.Name].Value);
                    int num5 = Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_1.Name].Value);
                    Form45 form1 = new Form45(Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_4.Name].Value), num, num2, num3, num4, num5, true);
                    form1.set_SqlSettings(this.get_SqlSettings());
                    form1.MdiParent = base.MdiParent;
                    form1.FormClosed += new FormClosedEventHandler(this.method_4);
                    form1.Show();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, exception.Source);
                }
            }
        }

        private void toolStripButton_12_Click(object sender, EventArgs e)
        {
            FormReportRelayProtectionAutomation automation1 = new FormReportRelayProtectionAutomation();
            automation1.set_SqlSettings(this.get_SqlSettings());
            automation1.MdiParent = base.MdiParent;
            automation1.Show();
        }

        private void toolStripButton_2_Click(object sender, EventArgs e)
        {
            List<TreeNode> list = new List<TreeNode>();
            list = this.method_1(this.treeView_0.Nodes, list);
            TreeNode node = this.method_2(list, this.treeView_0.SelectedNode, this.toolStripTextBox_0.Text, Enum25.const_1);
            if (node != null)
            {
                this.treeView_0.SelectedNode = node;
                this.treeView_0.SelectedNode.Expand();
            }
        }

        private void toolStripButton_3_Click(object sender, EventArgs e)
        {
            int num = -1;
            int num2 = -1;
            int num3 = -1;
            int num4 = -1;
            if (this.treeView_0.SelectedNode != null)
            {
                switch (this.treeView_0.SelectedNode.Level)
                {
                    case 1:
                        num = Convert.ToInt32(this.treeView_0.SelectedNode.Tag);
                        break;

                    case 2:
                        num2 = Convert.ToInt32(this.treeView_0.SelectedNode.Tag);
                        num = Convert.ToInt32(this.treeView_0.SelectedNode.Parent.Tag);
                        break;

                    case 3:
                        num3 = Convert.ToInt32(this.treeView_0.SelectedNode.Tag);
                        num2 = Convert.ToInt32(this.treeView_0.SelectedNode.Parent.Tag);
                        num = Convert.ToInt32(this.treeView_0.SelectedNode.Parent.Parent.Tag);
                        break;

                    case 4:
                        num4 = Convert.ToInt32(this.treeView_0.SelectedNode.Tag);
                        num3 = Convert.ToInt32(this.treeView_0.SelectedNode.Parent.Tag);
                        num2 = Convert.ToInt32(this.treeView_0.SelectedNode.Parent.Parent.Tag);
                        num = Convert.ToInt32(this.treeView_0.SelectedNode.Parent.Parent.Parent.Tag);
                        break;
                }
            }
            Form45 form1 = new Form45(num, num2, num3, num4, -1, -1);
            form1.set_SqlSettings(this.get_SqlSettings());
            form1.MdiParent = base.MdiParent;
            form1.FormClosed += new FormClosedEventHandler(this.method_4);
            form1.Show();
        }

        private void toolStripButton_4_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_0.CurrentRow != null)
            {
                if (Convert.ToBoolean(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewCheckBoxColumn_4.Name].Value))
                {
                    MessageBox.Show("Данный объект удален из схемы. Редактирование уставки РЗиА невозможно. ");
                }
                else
                {
                    int num = Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_2.Name].Value);
                    int num2 = Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_5.Name].Value);
                    int num3 = Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_9.Name].Value);
                    int num4 = Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_0.Name].Value);
                    int num5 = Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_1.Name].Value);
                    Form45 form1 = new Form45(Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_4.Name].Value), num, num2, num3, num4, num5);
                    form1.set_SqlSettings(this.get_SqlSettings());
                    form1.MdiParent = base.MdiParent;
                    form1.FormClosed += new FormClosedEventHandler(this.method_4);
                    form1.Show();
                }
            }
        }

        private void toolStripButton_5_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_0.CurrentRow != null)
            {
                if (Convert.ToBoolean(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewCheckBoxColumn_4.Name].Value))
                {
                    MessageBox.Show("Данный объект удален из схемы. Редактирование уставки РЗиА невозможно. ");
                }
                else
                {
                    int num = Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_2.Name].Value);
                    int num2 = Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_5.Name].Value);
                    int num3 = Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_9.Name].Value);
                    int num4 = Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_0.Name].Value);
                    Form45 form1 = new Form45(Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_4.Name].Value), num, num2, num3, num4, -1);
                    form1.set_SqlSettings(this.get_SqlSettings());
                    form1.MdiParent = base.MdiParent;
                    form1.FormClosed += new FormClosedEventHandler(this.method_4);
                    form1.Show();
                }
            }
        }

        private void toolStripButton_6_Click(object sender, EventArgs e)
        {
            if ((this.dataGridViewExcelFilter_0.CurrentRow != null) && (MessageBox.Show("Вы действиетльно хотите удалить выделенную уставку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_RelayProtectionAutomation, true, " where id = " + Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_0.Name].Value).ToString());
                if (this.dataSetGES_0.tJ_RelayProtectionAutomation.Rows.Count >= 0)
                {
                    this.dataSetGES_0.tJ_RelayProtectionAutomation.Rows[0]["deleted"] = true;
                    this.dataSetGES_0.tJ_RelayProtectionAutomation.Rows[0].EndEdit();
                    base.UpdateSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_RelayProtectionAutomation);
                    MessageBox.Show("Уставка успешно удалена", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.method_3();
                }
                else
                {
                    MessageBox.Show("Нету записи для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void toolStripButton_7_Click(object sender, EventArgs e)
        {
            if (!this.toolStripButton_7.Checked)
            {
                this.toolStripButton_7.Text = "Показать дерево объектов";
                this.splitContainer_0.Panel1Collapsed = true;
            }
            else
            {
                this.toolStripButton_7.Text = "Скрыть дерево объектов";
                this.splitContainer_0.Panel1Collapsed = false;
            }
        }

        private void toolStripButton_8_Click(object sender, EventArgs e)
        {
            if (this.toolStripButton_8.Checked)
            {
                this.toolStripButton_8.Text = "Скрыть удаленные уставки";
            }
            else
            {
                this.toolStripButton_8.Text = "Показать удаленные уставки";
            }
            this.method_3();
        }

        private void toolStripButton_9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить существующие уставки?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_RelayProtectionAutomation, true);
                foreach (DataSetGES.Class55 local1 in this.dataSetGES_0.tJ_RelayProtectionAutomation)
                {
                    local1["deleted"] = true;
                    local1.EndEdit();
                }
                base.UpdateSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_RelayProtectionAutomation);
            }
            DataSetOrder order = new DataSetOrder();
            base.SelectSqlData(order, order.vSchm_ObjList, true, "where typecodeid in (535,536,537,538, 674,675,676)");
            List<string> list = new List<string>();
            List<string> list2 = new List<string>();
            base.SelectSqlData(order, order.tR_Classifier, true, " where isGRoup = 0 and ParentKey in (';TypeTransformatorAmperage;')");
            foreach (DataRow row in new SqlDataCommand(new SQLSettings("ulges-sql", "PTS", "WINDOWS", "", "")).SelectSqlData("RZA", false, "", null).Rows)
            {
                string str2 = row["ps"].ToString();
                if (str2.Trim() == "ПС УЛЬЯНОВСКАЯ - 110/6 кВ")
                {
                    str2 = "ПС УЛЬЯНОВСКАЯ Новое ЗРУ-6кВ";
                }
                DataRow[] rowArray = order.vSchm_ObjList.Select("TypeCodeId in (535,536,537,538) and name = '" + str2 + "'");
                if (rowArray.Length != 0)
                {
                    DataRow[] rowArray2 = order.vSchm_ObjList.Select(" TypeCodeId in (674,675,676) and name = '" + row["cell"].ToString() + "' and idParent = " + rowArray[0]["id"].ToString());
                    if (rowArray2.Length != 0)
                    {
                        int num = Convert.ToInt32(rowArray2[0]["id"]);
                        if (rowArray2.Length > 1)
                        {
                            string[] textArray1 = new string[] { " TypeCodeId in (674,675,676) and name = '", row["cell"].ToString(), "' and idParent = ", rowArray[0]["id"].ToString(), " and deleted = 0" };
                            rowArray2 = order.vSchm_ObjList.Select(string.Concat(textArray1));
                            if (rowArray2.Length != 0)
                            {
                                num = Convert.ToInt32(rowArray2[0]["id"]);
                            }
                        }
                        this.dataSetGES_0.tJ_RelayProtectionAutomation.Clear();
                        DataRow row2 = this.dataSetGES_0.tJ_RelayProtectionAutomation.NewRow();
                        row2["idSChmObj"] = num;
                        row2["name"] = row["cell_note"].ToString().Trim();
                        row2["deleted"] = false;
                        this.dataSetGES_0.tJ_RelayProtectionAutomation.Rows.Add(row2);
                        int num2 = base.InsertSqlDataOneRow(this.dataSetGES_0, this.dataSetGES_0.tJ_RelayProtectionAutomation);
                        this.dataSetGES_0.tJ_RelayProtectionAutomationValue.Clear();
                        row2 = this.dataSetGES_0.tJ_RelayProtectionAutomationValue.NewRow();
                        if (row["trr_type"] != DBNull.Value)
                        {
                            string text = row["trr_type"].ToString().Trim();
                            switch (text)
                            {
                                case "ТВЛМ10":
                                    text = "ТВЛМ-10";
                                    break;

                                case "ТПЛ_10":
                                    text = "ТПЛ-10";
                                    break;

                                case "ТЛК10":
                                    text = "ТЛК-10";
                                    break;
                            }
                            DataRow[] rowArray3 = order.tR_Classifier.Select(" PArentKey = ';TypeTransformatorAmperage;' and name = '" + text + "'");
                            if (rowArray3.Length != 0)
                            {
                                row2["idTypeTR"] = rowArray3[0]["id"];
                            }
                            else
                            {
                                MessageBox.Show(text);
                            }
                        }
                        row2["amp_primary"] = row["trr_kf"];
                        row2["amp_secondary"] = row["trr_kf1"];
                        row2["amp_mtz"] = row["i_mtz_max"];
                        row2["time_mtz"] = row["t_mtz"];
                        row2["amp_to"] = row["i_to"];
                        row2["time_to"] = row["t_to"];
                        row2["amp_ozz"] = row["i_ozz"];
                        row2["time_ozz"] = row["t_ozz"];
                        row2["type_relay"] = row["device_type1"].ToString().Trim();
                        row2["type_proc"] = row["device_type2"].ToString().Trim();
                        row2["cp"] = row["cp"].ToString().Trim();
                        row2["cp_cell"] = row["cp_cell"].ToString().Trim();
                        row2["comment"] = row["note"].ToString().Trim();
                        row2["idRelay"] = num2;
                        row2["dateCreate"] = DateTime.Now;
                        row2["DateIn"] = new DateTime(0x7dc, 1, 1);
                        row2["deleted"] = false;
                        this.dataSetGES_0.tJ_RelayProtectionAutomationValue.Rows.Add(row2);
                        base.InsertSqlDataOneRow(this.dataSetGES_0, this.dataSetGES_0.tJ_RelayProtectionAutomationValue);
                    }
                    else
                    {
                        list2.Add(row["ps"].ToString() + " ячейка - " + row["cell"].ToString());
                    }
                }
                else if (!list.Contains(row["ps"].ToString()))
                {
                    list.Add(row["ps"].ToString());
                }
            }
            string str = "";
            foreach (string str4 in list)
            {
                str = str + str4 + "\n";
            }
            foreach (string str5 in list2)
            {
                str = str + str5 + "\n";
            }
            File.WriteAllLines("RZANoFind.txt", list.ToArray());
            list2.Sort();
            File.WriteAllLines("RZANoFind.txt", list2.ToArray());
            this.method_3();
            MessageBox.Show("ОК");
        }

        private void toolStripTextBox_0_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (e.Modifiers)
                {
                    case Keys.None:
                        this.toolStripButton_2_Click(sender, e);
                        break;

                    case Keys.Shift:
                        this.toolStripButton_1_Click(sender, e);
                        break;
                }
            }
        }

        private void treeView_0_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.method_3();
        }

        private void treeView_0_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if ((e.Node.Nodes.Count > 0) && (e.Node.Level > 1))
            {
                DataSetOrder order;
                e.Node.Nodes.Clear();
                switch (e.Node.Level)
                {
                    case 2:
                    {
                        order = new DataSetOrder();
                        base.SelectSqlData(order, order.tR_Classifier, true, " where ParentKey in (';SCM;BUS;BUSHV;', ';SCM;BUS;BUSMV;') and deleted = 0 and isgroup = 0 ");
                        string str = "";
                        foreach (DataRow row in order.tR_Classifier.Rows)
                        {
                            str = str + row["id"].ToString() + ",";
                        }
                        str = str.Remove(str.Length - 1);
                        base.SelectSqlData(order, order.vSchm_ObjList, true, " where idParent = " + e.Node.Tag.ToString() + " and typecodeId in (" + str + ") and deleted = 0");
                        foreach (DataRow row2 in order.vSchm_ObjList)
                        {
                            string str2 = "";
                            TreeNode node2 = e.Node.Nodes.Add(row2["TypeCodeSocr"].ToString() + " - " + row2["Name"].ToString() + str2);
                            node2.Tag = row2["id"];
                            node2.Nodes.Add("");
                        }
                        break;
                    }
                    case 3:
                        order = new DataSetOrder();
                        base.SelectSqlData(order, order.vSchm_TreeCellLine, true, " where ParentLink = " + e.Node.Tag.ToString());
                        foreach (DataRow row3 in order.vSchm_TreeCellLine)
                        {
                            string str3 = "";
                            TreeNode node1 = e.Node.Nodes.Add(row3["FullName"].ToString() + str3);
                            node1.Tag = row3["id"];
                            node1.Nodes.Add("");
                        }
                        break;
                }
            }
        }

        private enum Enum25
        {
            const_0,
            const_1,
            const_2
        }
    }
}

