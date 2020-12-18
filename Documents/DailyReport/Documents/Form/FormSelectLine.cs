using Constants.Scheme;
using ControlsLbr.DataGridViewExcelFilter;
//using Documents.Properties;
using FormLbr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
/// <summary>
/// Выбор объекта схемы
/// NS036/c000153
/// </summary>
internal class FormSelectLine : FormBase
{
    private BindingSource bindingSource_0;
    private bool bool_0 = true;
    private Button buttonOK;
    private Button buttonCancel;
    [CompilerGenerated]
    private Class33 class33_0;
    [CompilerGenerated]
    private Class33 class33_1;
    private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvCabSection;
    private DataGridViewTextBoxColumn columnNameCabSrction;
    private DataGridViewTextBoxColumn columnId;
    private IContainer components = null;
    private Label labelLoad;
    private List<int> list_0;
    private List<Class32> list_Line = new List<Class32>();
    private List<Class32> list_PS = new List<Class32>();
    private ProgressBar progressBarLoad;
    private SplitContainer splitContainer1;
    private ToolStrip toolStrip1;
    private ToolStripButton toolBtnFind;
    private ToolStripButton toolBTnFindPrev;
    private ToolStripButton toolBtnFindNext;
    private ToolStripTextBox txtFind;
    private TreeView treeViewLine;

    internal FormSelectLine(List<int> list_3 = null)
    {
        this.InitializeComponent();
        this.list_0 = list_3;
    }

    private void buttonOK_Click(object sender, EventArgs e)
    {
        base.Close();
    }

    private void buttonCancel_Click(object sender, EventArgs e)
    {
        base.Close();
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.components != null))
        {
            this.components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void FormSelectLine_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (base.DialogResult == DialogResult.OK)
        {
            List<int> list = new List<int>();
            foreach (TypeLine item in Enum.GetValues(typeof(TypeLine)))
            {
                list.Add((int)item);
            }
            if (((this.treeViewLine.SelectedNode == null) || (this.treeViewLine.SelectedNode.Level < 1)) || ((this.treeViewLine.SelectedNode.Level == 1) && list.Contains(Convert.ToInt32(this.treeViewLine.SelectedNode.Parent.Tag))))
            {
                MessageBox.Show("Не выбран объект", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                e.Cancel = true;
            }
            else
            {
                if ((this.treeViewLine.SelectedNode.Level == 2) && this.bool_0)
                {
                    if (this.dgvCabSection.CurrentRow == null)
                    {
                        if (MessageBox.Show("Не выбран участок КЛ/ВЛ. Продолжить?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        {
                            e.Cancel = true;
                            return;
                        }
                    }
                    else
                    {
                        this.method_3(new Class33(this.dgvCabSection.CurrentRow.Cells[this.columnNameCabSrction.Name].Value.ToString(), Convert.ToInt32(this.dgvCabSection.CurrentRow.Cells[this.columnId.Name].Value)));
                    }
                }
                this.method_1(new Class33(this.treeViewLine.SelectedNode.Text, Convert.ToInt32(this.treeViewLine.SelectedNode.Tag)));
            }
        }
    }

    private void FormSelectLine_Load(object sender, EventArgs e)
    {
        this.method_6();
    }

    private void FormSelectLine_Shown(object sender, EventArgs e)
    {
        List<Class32>.Enumerator enumerator;
        Label_0000:
            Application.DoEvents();
            bool flag = true;
            using (enumerator = this.list_Line.GetEnumerator())
            {
                    while (enumerator.MoveNext())
                    {
                        if (!enumerator.Current.bool_0)
                        {
                            goto Label_002F;
                        }
                    }
                    goto Label_0074;
                    Label_002F:
                    flag = false;
                    goto Label_0074;
            }
        Label_0041:
            try
            {
                while (enumerator.MoveNext())
                {
                    if (!enumerator.Current.bool_0)
                    {
                        goto Label_005D;
                    }
                }
                goto Label_006F;
                Label_005D:
                flag = false;
            }
            finally
            {
                enumerator.Dispose();
            }
        Label_006F:
            if (!flag)
            {
                goto Label_0000;
            }
            this.progressBarLoad.Visible = false;
            this.labelLoad.Visible = false;
            return;
        Label_0074:
            enumerator = this.list_PS.GetEnumerator();
            goto Label_0041;
    }
 //********************************************//
    //  [CompilerGenerated]
    // GET
    internal Class33 method_0()
    {
        return this.class33_0;
    }
   // [CompilerGenerated]
   // Set
    private void method_1(Class33 class33_2)
    {
        this.class33_0 = class33_2;
    }
 //********************************************//
    private void InitializeComponent()
    {
        this.components = new Container();
        this.splitContainer1 = new SplitContainer();
        this.treeViewLine = new TreeView();
        this.toolStrip1 = new ToolStrip();
        this.toolBtnFind = new ToolStripButton();
        this.txtFind = new ToolStripTextBox();
        this.toolBTnFindPrev = new ToolStripButton();
        this.toolBtnFindNext = new ToolStripButton();
        this.dgvCabSection = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
        this.columnNameCabSrction = new DataGridViewTextBoxColumn();
        this.columnId = new DataGridViewTextBoxColumn();
        this.buttonOK = new Button();
        this.buttonCancel = new Button();
        this.progressBarLoad = new ProgressBar();
        this.labelLoad = new Label();
        this.bindingSource_0 = new BindingSource(this.components);
        this.splitContainer1.Panel1.SuspendLayout();
        this.splitContainer1.Panel2.SuspendLayout();
        this.splitContainer1.SuspendLayout();
        this.toolStrip1.SuspendLayout();
        ((ISupportInitialize)this.dgvCabSection).BeginInit();
        ((ISupportInitialize) this.bindingSource_0).BeginInit();
        base.SuspendLayout();
        this.splitContainer1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
        this.splitContainer1.Location = new Point(0, 0);
        this.splitContainer1.Name = "splitContainer1";
        this.splitContainer1.Panel1.Controls.Add(this.treeViewLine);
        this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
        this.splitContainer1.Panel2.Controls.Add(this.dgvCabSection);
        this.splitContainer1.Size = new Size(0x2b5, 0x20a);
        this.splitContainer1.SplitterDistance = 0x14f;
        this.splitContainer1.TabIndex = 0;
        this.treeViewLine.Dock = DockStyle.Fill;
        this.treeViewLine.HideSelection = false;
        this.treeViewLine.Location = new Point(0, 0x19);
        this.treeViewLine.Name = "treeViewLine";
        this.treeViewLine.Size = new Size(0x14f, 0x1f1);
        this.treeViewLine.TabIndex = 1;
        this.treeViewLine.AfterSelect += new TreeViewEventHandler(this.treeViewLine_AfterSelect);
        ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolBtnFind, this.txtFind, this.toolBTnFindPrev, this.toolBtnFindNext };
        this.toolStrip1.Items.AddRange(toolStripItems);
        this.toolStrip1.Location = new Point(0, 0);
        this.toolStrip1.Name = "toolStrip1";
        this.toolStrip1.Size = new Size(0x14f, 0x19);
        this.toolStrip1.TabIndex = 0;
        this.toolStrip1.Text = "toolStrip1";
        this.toolBtnFind.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolBtnFind.Image = global::DailyReport.Properties.Resources.Find;
        this.toolBtnFind.ImageTransparentColor = Color.Magenta;
        this.toolBtnFind.Name = "toolBtnFind";
        this.toolBtnFind.Size = new Size(0x17, 0x16);
        this.toolBtnFind.Text = "Поиск";
        this.toolBtnFind.Click += new EventHandler(this.toolBtnFind_Click);
        this.txtFind.Name = "txtFind";
        this.txtFind.Size = new Size(100, 0x19);
        this.txtFind.ToolTipText = "Строка поиска";
        this.txtFind.KeyDown += new KeyEventHandler(this.txtFind_KeyDown);
        this.toolBTnFindPrev.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolBTnFindPrev.Image = global::DailyReport.Properties.Resources.FindPrev;
        this.toolBTnFindPrev.ImageTransparentColor = Color.Magenta;
        this.toolBTnFindPrev.Name = "toolBTnFindPrev";
        this.toolBTnFindPrev.Size = new Size(0x17, 0x16);
        this.toolBTnFindPrev.Text = "Поиск назад";
        this.toolBTnFindPrev.Click += new EventHandler(this.toolBTnFindPrev_Click);
        this.toolBtnFindNext.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolBtnFindNext.Image = global::DailyReport.Properties.Resources.FindNext;
        this.toolBtnFindNext.ImageTransparentColor = Color.Magenta;
        this.toolBtnFindNext.Name = "toolBtnFindNext";
        this.toolBtnFindNext.Size = new Size(0x17, 0x16);
        this.toolBtnFindNext.Text = "Поиск вперед";
        this.toolBtnFindNext.Click += new EventHandler(this.toolBtnFindNext_Click);
        this.dgvCabSection.AllowUserToAddRows = false;
        this.dgvCabSection.AllowUserToDeleteRows = false;
        this.dgvCabSection.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.columnNameCabSrction, this.columnId };
        this.dgvCabSection.Columns.AddRange(dataGridViewColumns);
        this.dgvCabSection.Dock = DockStyle.Fill;
        this.dgvCabSection.Location = new Point(0, 0);
        this.dgvCabSection.Name = "dgvCabSection";
        this.dgvCabSection.ReadOnly = true;
        this.dgvCabSection.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        this.dgvCabSection.Size = new Size(0x162, 0x20a);
        this.dgvCabSection.TabIndex = 0;
        this.columnNameCabSrction.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.columnNameCabSrction.DataPropertyName = "Number";
        this.columnNameCabSrction.HeaderText = "Участок";
        this.columnNameCabSrction.Name = "columnNameCabSrction";
        this.columnNameCabSrction.ReadOnly = true;
        this.columnId.DataPropertyName = "id";
        this.columnId.HeaderText = "Id";
        this.columnId.Name = "columnId";
        this.columnId.ReadOnly = true;
        this.columnId.Visible = false;
        this.buttonOK.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
        this.buttonOK.DialogResult = DialogResult.OK;
        this.buttonOK.Location = new Point(12, 0x213);
        this.buttonOK.Name = "buttonOK";
        this.buttonOK.Size = new Size(0x4b, 0x17);
        this.buttonOK.TabIndex = 1;
        this.buttonOK.Text = "ОК";
        this.buttonOK.UseVisualStyleBackColor = true;
        this.buttonOK.Click += new EventHandler(this.buttonOK_Click);
        this.buttonCancel.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
        this.buttonCancel.DialogResult = DialogResult.Cancel;
        this.buttonCancel.Location = new Point(0x25e, 0x213);
        this.buttonCancel.Name = "buttonCancel";
        this.buttonCancel.Size = new Size(0x4b, 0x17);
        this.buttonCancel.TabIndex = 2;
        this.buttonCancel.Text = "Отмена";
        this.buttonCancel.UseVisualStyleBackColor = true;
        this.buttonCancel.Click += new EventHandler(this.buttonCancel_Click);
        this.progressBarLoad.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
        this.progressBarLoad.Location = new Point(0x108, 0x213);
        this.progressBarLoad.Name = "progressBarLoad";
        this.progressBarLoad.Size = new Size(0x150, 0x17);
        this.progressBarLoad.Style = ProgressBarStyle.Marquee;
        this.progressBarLoad.TabIndex = 3;
        this.labelLoad.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
        this.labelLoad.AutoSize = true;
        this.labelLoad.Location = new Point(0x69, 0x218);
        this.labelLoad.Name = "labelLoad";
        this.labelLoad.Size = new Size(0x99, 13);
        this.labelLoad.TabIndex = 4;
        this.labelLoad.Text = "Загрузка дерева объектов...";
        base.AcceptButton = this.buttonOK;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.CancelButton = this.buttonCancel;
        base.ClientSize = new Size(0x2b5, 0x236);
        base.Controls.Add(this.labelLoad);
        base.Controls.Add(this.progressBarLoad);
        base.Controls.Add(this.buttonCancel);
        base.Controls.Add(this.buttonOK);
        base.Controls.Add(this.splitContainer1);
        base.Name = "FormSelectLine";
        this.Text = "Выбор объекта схемы";
        base.FormClosing += new FormClosingEventHandler(this.FormSelectLine_FormClosing);
        base.Load += new EventHandler(this.FormSelectLine_Load);
        base.Shown += new EventHandler(this.FormSelectLine_Shown);
        this.splitContainer1.Panel1.ResumeLayout(false);
        this.splitContainer1.Panel1.PerformLayout();
        this.splitContainer1.Panel2.ResumeLayout(false);
        this.splitContainer1.ResumeLayout(false);
        this.toolStrip1.ResumeLayout(false);
        this.toolStrip1.PerformLayout();
        ((ISupportInitialize)this.dgvCabSection).EndInit();
        ((ISupportInitialize) this.bindingSource_0).EndInit();
        base.ResumeLayout(false);
        base.PerformLayout();
    }

 //********************************************//
    // [CompilerGenerated]
    // GET
    internal Class33 method_2()
    {
        return this.class33_1;
    }
    //[CompilerGenerated]
    // SET
    private void method_3(Class33 class33_2)
    {
        this.class33_1 = class33_2;
    }
//********************************************//
    internal bool method_4()
    {
        return this.bool_0;
    }

    internal void splitContainer1_Visible(bool flag)
    {
        this.bool_0 = flag;
        this.splitContainer1.Panel2Collapsed = !this.bool_0;
    }

    private void method_6()
    {
        DataTable table = new DataTable("tR_Classifier");
        table.Columns.Add("id", typeof(int));
        table.Columns.Add("socrName", typeof(string));
        base.SelectSqlData(table, true, " where ParentKey = ';SCM;Line;' and isGRoup = 0 and deleted = 0 order by name", null, false, 0);
        foreach (DataRow row in table.Rows)
        {
            if ((this.list_0 != null) && this.list_0.Contains(Convert.ToInt32(row["id"])))
            {
                TreeNode node = new TreeNode(row["SocrNAme"].ToString()) {
                    Tag = row["id"]
                };
                this.treeViewLine.Nodes.Add(node);
                TreeNode node2 = new TreeNode("0,23-0,4 кВ");
                node.Nodes.Add(node2);
                this.list_Line.Add(new Class32(node2, Convert.ToInt32(row["id"]), Enum5.LV, false));
                TreeNode node3 = new TreeNode("6-10 кВ");
                node.Nodes.Add(node3);
                this.list_Line.Add(new Class32(node3, Convert.ToInt32(row["id"]), Enum5.HV, false));
            }
        }
        base.SelectSqlData(table, true, " where ParentKey = ';SCM;PS;' and isGRoup = 0 and deleted = 0 order by name", null, false, 0);
        foreach (DataRow row2 in table.Rows)
        {
            if ((this.list_0 != null) && this.list_0.Contains(Convert.ToInt32(row2["id"])))
            {
                TreeNode node4 = new TreeNode(row2["SocrNAme"].ToString()) {
                    Tag = row2["id"]
                };
                this.treeViewLine.Nodes.Add(node4);
                this.list_PS.Add(new Class32(node4, Convert.ToInt32(row2["id"]), Enum5.HV, false));
            }
        }
        foreach (Class32 current in this.list_Line)
        {
            new Thread(new ParameterizedThreadStart(this.method_7)).Start(current);
        }
        foreach (Class32 current in this.list_PS)
        {
            new Thread(new ParameterizedThreadStart(this.method_8)).Start(current);
        }
    }

    private void method_7(object object_0)
    {
        if (object_0 is Class32)
        {
            Class32 class2 = (Class32) object_0;
            DataTable table = new DataTable("VP_CAbleLine");
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("text", typeof(string));
            base.SelectSqlData(table, true, string.Format("where typeCodeid = {0} and voltage in ({1}) order by text", class2.int_0, (class2.enum5_0 == Enum5.LV) ? "0.23, 0.4" : "6, 10"), null, false, 0);
            foreach (DataRow row in table.Rows)
            {
                TreeNode node = new TreeNode(row["TExt"].ToString()) {
                    Tag = row["id"]
                };
                this.method_9(this.treeViewLine, class2.treeNode_0, node);
            }
            Class32 class3 = class2;
            lock (class3)
            {
                class2.bool_0 = true;
            }
        }
    }

    private void method_8(object object_0)
    {
        if (object_0 is Class32)
        {
            Class32 class2 = (Class32) object_0;
            DataTable table = new DataTable("vschm_ObjList");
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("name", typeof(string));
            table.Columns.Add("typeCodeSocr", typeof(string));
            base.SelectSqlData(table, true, string.Format("where typeCodeid = {0} and deleted = 0 order by name", class2.int_0), null, false, 0);
            foreach (DataRow row in table.Rows)
            {
                TreeNode node = new TreeNode(row["TypeCodeSocr"].ToString() + "-" + row["Name"].ToString()) {
                    Tag = row["id"]
                };
                this.method_9(this.treeViewLine, class2.treeNode_0, node);
            }
            Class32 class3 = class2;
            lock (class3)
            {
                class2.bool_0 = true;
            }
        }
    }

    private void method_9(TreeView treeView_1, TreeNode treeNode_0, TreeNode treeNode_1)
    {
        if ((((treeView_1 != null) && !treeView_1.IsDisposed) && !treeView_1.Disposing) && treeView_1.IsHandleCreated)
        {
            try
            {
                if (!treeView_1.InvokeRequired)
                {
                    if (treeNode_0 == null)
                    {
                        treeView_1.Nodes.Add(treeNode_1);
                    }
                    else
                    {
                        treeNode_0.Nodes.Add(treeNode_1);
                    }
                }
                else
                {
                    object[] args = new object[] { treeView_1, treeNode_0, treeNode_1 };
                    treeView_1.Invoke(new Delegate0(this.method_9), args);
                }
            }
            catch
            {
            }
        }
    }

    private void toolBtnFind_Click(object sender, EventArgs e)
    {
        this.treeViewLine.Find(this.txtFind.Text, FindElementTreeNode.eSearchNode.First);
    }

    private void toolBTnFindPrev_Click(object sender, EventArgs e)
    {
        this.treeViewLine.Find(this.txtFind.Text, FindElementTreeNode.eSearchNode.Prev);
    }

    private void toolBtnFindNext_Click(object sender, EventArgs e)
    {
        this.treeViewLine.Find(this.txtFind.Text, FindElementTreeNode.eSearchNode.Next);
    }

    private void txtFind_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            if (e.Modifiers == Keys.Shift)
            {
                this.treeViewLine.Find(this.txtFind.Text, FindElementTreeNode.eSearchNode.Prev);
            }
            if (e.Modifiers == Keys.None)
            {
                this.treeViewLine.Find(this.txtFind.Text, FindElementTreeNode.eSearchNode.Next);
            }
        }
    }

    private void treeViewLine_AfterSelect(object sender, TreeViewEventArgs e)
    {
        if ((e.Node.Level > 1) && (e.Node.Tag != null))
        {
            int num = Convert.ToInt32(e.Node.Tag);
            DataTable table = new DataTable("tP_CabSection");
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("number", typeof(int));
            this.bindingSource_0.DataSource = table;
            base.SelectSqlData(table, true, "where idObjList = " + num.ToString() + " order by number", null, false, 0);
            this.dgvCabSection.DataSource = this.bindingSource_0;
        }
    }

    private class Class32
    {
        internal bool bool_0;
        internal FormSelectLine.Enum5 enum5_0;
        internal int int_0;
        internal TreeNode treeNode_0;

        internal Class32(TreeNode treeNode_1, int int_1, FormSelectLine.Enum5 enum5_1 = (FormSelectLine.Enum5)1, bool bool_1 = false)
        {
            this.treeNode_0 = treeNode_1;
            this.int_0 = int_1;
            this.enum5_0 = enum5_1;
            this.bool_0 = bool_1;
        }
    }

    private delegate void Delegate0(TreeView treeView_0, TreeNode treeNode_0, TreeNode treeNode_1);

    private enum Enum5
    {
        /// <summary>
        /// "0,23-0,4 кВ"
        /// </summary>
        LV = 0,
        /// <summary>
        /// "6-10 кВ"
        /// </summary>
        HV = 1
    }
}

